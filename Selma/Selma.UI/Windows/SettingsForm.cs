using System;
using System.IO;
using System.Windows.Forms;
using Selma.DataAccess;

namespace Selma.UI.Windows
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            txtDataLocation.Text = Helper.GetDataPath();
            txtExamTemplatePath.Text = Path.Combine(Helper.GetDataPath(), "Prazna.pdf");
        }
    }
}
