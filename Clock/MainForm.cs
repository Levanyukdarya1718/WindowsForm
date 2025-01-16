using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.IO;
using System.Diagnostics;
using Microsoft.Win32;


namespace Clock
{
	public partial class MainForm : Form
	{
		ChooseFontForm fontDialog = null;
		AlarmForm alarms = null;
		Alarm nextAlarm = null;
		public MainForm()
		{
			//Console.WriteLine(DateTime.MinValue);
			InitializeComponent();
			labelTime.BackColor = Color.Black;
			labelTime.ForeColor = Color.DeepPink;
			this.Location = new Point(Screen.PrimaryScreen.Bounds.Width - this.Width, 50);
			SetVisibility(false);
			cmShowConsole.Checked = true;
			//fontDialog = new ChooseFontForm();
			LoadSettings();
			alarms = new AlarmForm();
			axWindowsMediaPlayer.Visible = false;
		}
		void CompareAlarmDEBUG()
		{
			Alarm alarm1 = new Alarm();
			Alarm alarm2 = new Alarm();

			alarm1.Date = new DateTime(2025, 01, 15);
			alarm1.Time = new TimeSpan(9, 5, 0);

			alarm2.Date = new DateTime(2025, 01, 16);
			alarm2.Time = new TimeSpan(9, 11, 00);

			// Console.WriteLine(alarm1 < alarm2);

		}
		void SetVisibility(bool vicible)
		{
			cbShowDate.Visible = vicible;
			cbShowWeekDay.Visible = vicible;
			btnHideControls.Visible = vicible;
			this.TransparencyKey = vicible ? Color.Empty : this.BackColor;
			this.FormBorderStyle = vicible ? FormBorderStyle.FixedToolWindow : FormBorderStyle.None;
			this.ShowInTaskbar = vicible;
		}
		void SaveSettings()
		{

			StreamWriter sw = new StreamWriter("Settings.ini");
			sw.WriteLine($"{cmTopmost.Checked}");
			sw.WriteLine($"{cmShowControls.Checked}");
			sw.WriteLine($"{cmShowDate.Checked}");
			sw.WriteLine($"{cmShowWeekday.Checked}");
			sw.WriteLine($"{cmShowConsole.Checked}");
			sw.WriteLine($"{labelTime.BackColor.ToArgb()}");
			sw.WriteLine($"{labelTime.ForeColor.ToArgb()}");
			sw.WriteLine($"{fontDialog.Filename}");
			sw.WriteLine($"{labelTime.Font.Size}");


			sw.Close();
			// Process.Start("notepad", "Settings.ini");
		}
		void LoadSettings()
		{
			string exicution_path = Path.GetDirectoryName(Application.ExecutablePath);
			Directory.SetCurrentDirectory($"{exicution_path}\\..\\..\\Fonts");
			StreamReader sr = new StreamReader("Settings.ini");
			cmTopmost.Checked = bool.Parse(sr.ReadLine());
			cmShowControls.Checked = bool.Parse(sr.ReadLine());
			cmShowDate.Checked = bool.Parse(sr.ReadLine());
			cmShowWeekday.Checked = bool.Parse(sr.ReadLine());
			cmShowConsole.Checked = bool.Parse(sr.ReadLine());
			labelTime.BackColor = Color.FromArgb(Convert.ToInt32(sr.ReadLine()));
			labelTime.ForeColor = Color.FromArgb(Convert.ToInt32(sr.ReadLine()));
			string font_name = sr.ReadLine();
			int font_size = (int)Convert.ToDouble(sr.ReadLine());

			sr.Close();
			fontDialog = new ChooseFontForm(this, font_name, font_size);
			labelTime.Font = fontDialog.Font;

		}
		Alarm FindNextAlarm()
		{
			//  Alarm nextAlarm = null; //new Alarm(alarms.LB_Alarms.Items.Cast<Alarm>().ToArray().Min());
			Alarm[] actualAlarms = alarms.LB_Alarms.Items.Cast<Alarm>().Where(a => a.Time > DateTime.Now.TimeOfDay).ToArray();
			//Alarm nextAlarms = new Alarm(actoalAlarms.Min());
			//return nextAlarm; 
			return actualAlarms.Min();

		}
		bool CompareDates(DateTime date1, DateTime date2)
		{
			return date1.Year == date2.Year && date1.Month == date2.Month && date1.Day == date2.Day;
		}
		void PlayAlarm()
		{
			axWindowsMediaPlayer.URL = nextAlarm.Filename;
			axWindowsMediaPlayer.settings.volume = 100;
			axWindowsMediaPlayer.Ctlcontrols.play();
			axWindowsMediaPlayer.Visible=true;
		}

		private void timer_Tick(object sender, EventArgs e)
		{
			labelTime.Text = DateTime.Now.ToString
				(
				"hh:mm:ss tt",
				System.Globalization.CultureInfo.InvariantCulture
				);
			if (cbShowDate.Checked)
			{
				labelTime.Text += "\n";
				labelTime.Text += DateTime.Now.ToString("yyyy, MM.dd");
			}
			if (cbShowWeekDay.Checked)
			{
				labelTime.Text += "\n";
				labelTime.Text += DateTime.Now.DayOfWeek;
			}
			notifyIcon.Text = labelTime.Text;
			if (
				nextAlarm != null &&
				(
					nextAlarm.Date==DateTime.MinValue?
					nextAlarm.WeekDays.Contains(DateTime.Now.DayOfWeek):
					CompareDates(nextAlarm.Date, DateTime.Now)
				) &&
				/*||nextAlarm.Date==DateTime.MinValue.Date*/
				//nextAlarm.WeekDays.Contains(DateTime.Now.DayOfWeek)&&
				nextAlarm.Time.Hours == DateTime.Now.Hour &&
				nextAlarm.Time.Minutes == DateTime.Now.Minute &&
				nextAlarm.Time.Seconds == DateTime.Now.Second
				)
			{
				//nextAlarm = FindNextAlarm();
				System.Threading.Thread.Sleep(1000);
				PlayAlarm();
				//MessageBox.Show(this, nextAlarm.ToString(), "Alarm", MessageBoxButtons.OK, MessageBoxIcon.Information);
				nextAlarm = null;
			}


			if ( alarms.LB_Alarms.Items.Count > 0) nextAlarm = FindNextAlarm(); //alarms.LB_Alarms.Items.Cast<Alarm>().ToArray().Min();
			if (nextAlarm != null) Console.WriteLine(nextAlarm);
			//else Console.WriteLine("No alarms found");
		}

		private void btnHideControls_Click(object sender, EventArgs e)
		{
			//cbShowDate.Visible = false;
			//btnHideControls.Visible = false;
			//this.TransparencyKey = this.BackColor;
			//this.FormBorderStyle=FormBorderStyle.None;
			//labelTime.BackColor = Color.AliceBlue;
			//this.ShowInTaskbar = false;
			SetVisibility(cmShowControls.Checked = false);
			// cmShowControls.Checked = false;
		}

		private void labelTime_DoubleClick(object sender, EventArgs e)
		{
			//MessageBox.Show
			//    (
			//    this,
			//    "Вы два раза щелкнули мышью мпо времени и теперь вы муправляете временем",
			//    "Info",
			//    MessageBoxButtons.OK,
			//    MessageBoxIcon.Information
			//    );
			//cbShowDate.Visible = true;
			//btnHideControls.Visible = true;
			//this.TransparencyKey = Color.Empty;
			//this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
			//labelTime.BackColor = Color.AliceBlue;
			//this.ShowInTaskbar = true;
			SetVisibility(cmShowControls.Checked = true);

		}

		private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
		{

		}

		private void cmExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void cmTopmost_CheckedChanged(object sender, EventArgs e)
		{
			this.TopMost = cmTopmost.Checked;
		}

		private void cmShowDate_CheckedChanged(object sender, EventArgs e)
		{
			cbShowDate.Checked = cmShowDate.Checked;
		}

		private void cbShowDate_CheckedChanged(object sender, EventArgs e)
		{
			cmShowDate.Checked = cbShowDate.Checked;
		}

		private void cmShowWeekday_CheckedChanged(object sender, EventArgs e)
		{
			cbShowWeekDay.Checked = cmShowWeekday.Checked;
		}

		private void cbShowWeekDay_CheckedChanged(object sender, EventArgs e)
		{
			cmShowWeekday.Checked = cbShowWeekDay.Checked;
		}

		private void notifyIcon_DoubleClick(object sender, EventArgs e)
		{
			if (!this.TopMost)
			{
				this.TopMost = true;
				this.TopMost = false;
			}
		}

		private void cmShowControls_CheckedChanged(object sender, EventArgs e)
		{
			SetVisibility(cmShowControls.Checked);
		}

		private void SetColor(object sender, EventArgs e)
		{
			ColorDialog dialog = new ColorDialog();
			//  dialog.Color = labelTime.BackColor;
			switch ((sender as ToolStripMenuItem).Text)
			{
				case "Background color": dialog.Color = labelTime.BackColor; break;
				case "Foreground color": dialog.Color = labelTime.ForeColor; break;
			}
			if (dialog.ShowDialog() == DialogResult.OK)
			// labelTime.BackColor = dialog.Color;
			{
				switch ((sender as ToolStripMenuItem).Text)
				{
					case "Background color": labelTime.BackColor = dialog.Color; break;
					case "Foreground color": labelTime.ForeColor = dialog.Color; break;
				}
			}

		}

		private void cmChooseFont_Click(object sender, EventArgs e)
		{
			if (fontDialog.ShowDialog() == DialogResult.OK)
			{
				labelTime.Font = fontDialog.Font;
			}
		}

		private void cmShowConsole_CheckedChanged(object sender, EventArgs e)
		{
			if ((sender as ToolStripMenuItem).Checked)
				AllocConsole();
			else
				FreeConsole();
		}
		[DllImport("kernel32.dll")]
		public static extern bool AllocConsole();
		[DllImport("kernel32.dll")]
		public static extern bool FreeConsole();

		private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			SaveSettings();
		}

		private void cmLoadOnWinStartup_CheckedChanged(object sender, EventArgs e)
		{
			string key_name = "ClockPV_319";
			RegistryKey rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true); //true - откроет ветку на запись
			if (cmLoadOnWinStartup.Checked) rk.SetValue(key_name, Application.ExecutablePath);
			else rk.DeleteValue(key_name, false);
			rk.Dispose();
		}

		private void cmAlarm_Click(object sender, EventArgs e)
		{
			alarms.StartPosition = FormStartPosition.Manual;
			alarms.Location = new Point(this.Location.X - alarms.Width, this.Location.Y);
			alarms.ShowDialog();

		}
	}
}
