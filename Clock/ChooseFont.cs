using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Text;

namespace Clock
{
	public partial class ChooseFontForm : Form
	{
		public Font Font { get; set; }
		public string Filename { get; set; }
		public ChooseFontForm()
		{
			InitializeComponent();
			LoadFonts();
			cbFonts.SelectedIndex = 0;
		}
		public ChooseFontForm(string font_name, int font_size)
		{
			InitializeComponent();
			Filename = font_name;
			nudFontSize.Value = font_size;
			LoadFonts();
			cbFonts.SelectedIndex = cbFonts.Items.IndexOf(Filename);
			Font = labelExample.Font;
		}
		void LoadFonts()
		{
			//Directory.SetCurrentDirectory("..\\..\\Fonts");
			Console.WriteLine(Directory.GetCurrentDirectory());

			string[] files = Directory.GetFiles(Directory.GetCurrentDirectory(), "*.ttf");
			for (int i = 0; i < files.Length; i++)
			{
				files[i] = files[i].Split('\\').Last();
			}
			cbFonts.Items.AddRange(GetFontsFormat("*.ttf"));
			cbFonts.Items.AddRange(GetFontsFormat("*.otf"));

		}
		static string[] GetFontsFormat(string format)
		{
			string[] files = Directory.GetFiles(Directory.GetCurrentDirectory(), format);
			for (int i = 0; i < files.Length; i++)
				files[i] = files[i].Split('\\').Last();
			return files;

		}


		private void cbFonts_SelectedIndexChanged(object sender, EventArgs e)
		{
			PrivateFontCollection pfs = new PrivateFontCollection();
			string full_name = $"{Directory.GetCurrentDirectory()}\\{cbFonts.SelectedItem}";
			pfs.AddFontFile(full_name);
			labelExample.Font = new Font(pfs.Families[0], Convert.ToInt32(nudFontSize.Value));
		}
		private void btnOK_Click(object sender, EventArgs e)
		{
			cbFonts_SelectedIndexChanged(sender, e);
			Font = labelExample.Font;
			Filename = cbFonts.SelectedItem.ToString();
		}

		private void btnApply_Click(object sender, EventArgs e)
		{
			cbFonts_SelectedIndexChanged(sender, e);
			
		}
	}
}
