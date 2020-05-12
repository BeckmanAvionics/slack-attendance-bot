using Attendance.Localization;
using Attendance.Modules;
using Attendance.Properties;
using IshanTools;
using System;
using System.Windows.Forms;

namespace Attendance.Main
{
    public partial class MainWindow : Form
    {
        public enum RequestType
        {
            Attendance = 0,
            Poll = 1
        }

        private readonly ToolStripMenuItem[] tsThemes;

        public MainWindow()
        {
            InitializeComponent();

            tsThemeSteel.Tag = StyleTheme.Steel;
            tsThemeJade.Tag = StyleTheme.Jade;
            tsThemeRose.Tag = StyleTheme.Rose;

            tsThemeSteel.Text = Strings.THEME_STEEL;
            tsThemeJade.Text = Strings.THEME_JADE;
            tsThemeRose.Text = Strings.THEME_ROSE;

            tsThemes = new ToolStripMenuItem[3];
            tsThemes[(int)StyleTheme.Steel] = tsThemeSteel;
            tsThemes[(int)StyleTheme.Jade] = tsThemeJade;
            tsThemes[(int)StyleTheme.Rose] = tsThemeRose;

            tsThemeX_Click(tsThemes[(int)Settings.Default.THEME], EventArgs.Empty);

            this.MinimumSize = this.Size;

            cboRequestType.SelectedIndex = (int)RequestType.Attendance;
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e) => Settings.Default.Save();

        private void cboRequestType_SelectedIndexChanged(object sender, EventArgs e) =>
            lblDate.Text = Strings.ResourceManager.GetString("DATE_" + ((RequestType)cboRequestType.SelectedIndex).ToString().ToUpper());

        private void tsThemeX_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem i in tsThemes)
                i.Checked = false;

            ToolStripMenuItem ts = sender as ToolStripMenuItem;

            ts.Checked = true;

            tsTheme.Text = string.Format(Strings.FORMAT_THEME, Strings.ResourceManager.GetString("THEME_" + ((StyleTheme)ts.Tag).ToString().ToUpper()));

            Settings.Default.THEME = (StyleTheme)ts.Tag;

            IshanStylers.RunStylers(this, Settings.Default.THEME);
        }

        private async void btnSendRequest_Click(object sender, EventArgs e)
        {
            dgv.Rows.Clear();

            foreach (string s in (await ServerInterop.GetAttendanceAsync(Settings.Default.SERVER, dtpDate.Value)).students)
                dgv.Rows.Add(s);
        }
    }
}
