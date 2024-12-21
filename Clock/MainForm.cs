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

namespace Clock
{
    public partial class MainForm : Form
    {
        ChooseFontForm fontDialog = null;
        public MainForm()
        {
            InitializeComponent();
            labelTime.BackColor = Color.Black;
            labelTime.ForeColor = Color.Red;
            this.Location = new Point(Screen.PrimaryScreen.Bounds.Width - this.Width, 50);
            SetVisibility(false);
            cmShowConsole.Checked=true;
            fontDialog = new ChooseFontForm();
        }
        void SetVisibility (bool vicible)
        {
            cbShowDate.Visible = vicible;
            cbShowWeekDay.Visible = vicible;
            btnHideControls.Visible = vicible;
            this.TransparencyKey = vicible? Color.Empty: this.BackColor;
            this.FormBorderStyle = vicible? FormBorderStyle.FixedToolWindow: FormBorderStyle.None;
            this.ShowInTaskbar = vicible;
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
            if(cbShowWeekDay.Checked)
            {
                labelTime.Text+="\n";
                labelTime.Text += DateTime.Now.DayOfWeek;
            }
            notifyIcon.Text = labelTime.Text;
        }

        private void btnHideControls_Click(object sender, EventArgs e)
        {
            //cbShowDate.Visible = false;
            //btnHideControls.Visible = false;
            //this.TransparencyKey = this.BackColor;
            //this.FormBorderStyle=FormBorderStyle.None;
            //labelTime.BackColor = Color.AliceBlue;
            //this.ShowInTaskbar = false;
             SetVisibility(cmShowControls.Checked= false);
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
            SetVisibility(cmShowControls.Checked= true);

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
            cbShowWeekDay.Checked=cmShowWeekday.Checked;
        }

        private void cbShowWeekDay_CheckedChanged(object sender, EventArgs e)
        {
            cmShowWeekday.Checked=cbShowWeekDay.Checked;
        }

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            if(!this.TopMost)
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
            ColorDialog dialog =new ColorDialog();
            //  dialog.Color = labelTime.BackColor;
            switch ((sender as ToolStripMenuItem).Text)
            {
                case "Background color": dialog.Color = labelTime.BackColor; break;
                case "Foreground color": dialog.Color = labelTime.ForeColor; break;
            }
            if (dialog.ShowDialog() == DialogResult.OK)
            // labelTime.BackColor = dialog.Color;
            {
                switch((sender as ToolStripMenuItem).Text)
                {
                    case "Background color": labelTime.BackColor = dialog.Color;break;
                    case "Foreground color": labelTime.ForeColor = dialog.Color; break;
                }
            }

        }

        private void cmChooseFont_Click(object sender, EventArgs e)
        {
           if(fontDialog.ShowDialog()==DialogResult.OK)
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
    }
}
