using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BedsideMonitoring
{
    public partial class RegisterConsultant : Form
    {
        public RegisterConsultant()
        {
            InitializeComponent();
        }

        private void btnRegConClose_Click(object sender, EventArgs e)
        {
            ConsultantStaff.Instance.NameStaff = tbConName.Text;
            ConsultantStaff.Instance.ContactInformation = tbConEmail.Text;
            CloseAndOpenOverview();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            CloseAndOpenOverview();
        }

        private void CloseAndOpenOverview()
        {
            Close();
            Program.NewCentralStationOverview.Show();
        }

        private void RegisterConsultant_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.NewCentralStationOverview.Show();
        }
    }
}
