using System.Windows.Forms;
using XeniaUpdater.Source;

namespace XeniaUpdater.Forms
{
    public partial class SettingsDialog : Form
    {
        public SettingsDialog()
        {
            InitializeComponent();

            xeniaMasterTextBox.Text = Program.Settings.MasterPath;
            xeniaCanaryPRTextBox.Text = Program.Settings.CanaryPath;
            xeniaCanaryExTextBox.Text = Program.Settings.CanaryExPath;
        }

        private void saveButton_Click(object sender, System.EventArgs e)
        {
            var settings = new Settings
            {
                MasterPath = xeniaMasterTextBox.Text,
                CanaryPath = xeniaCanaryPRTextBox.Text,
                CanaryExPath = xeniaCanaryExTextBox.Text
            };

            settings.SaveSettings();
        }

        private void saveAndExitButton_Click(object sender, System.EventArgs e)
        {
            var settings = new Settings
            {
                MasterPath = xeniaMasterTextBox.Text,
                CanaryPath = xeniaCanaryPRTextBox.Text,
                CanaryExPath = xeniaCanaryExTextBox.Text
            };

            settings.SaveSettings();

            Close();
        }
    }
}
