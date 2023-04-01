using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BedsideMonitoring
{
    public partial class CentralStationOverview : Form
    {
        private static readonly List<BedsideController> listOfBedsideControllers = new List<BedsideController>();

        public CentralStationOverview()
        {
            InitializeComponent();
            PopulateCentralStationBedsideDetails();
        }

        private void PopulateCentralStationBedsideDetails()
        {
            centralStationBedsideDetails1.lblBedNumber.Text = "Bed 1";
            centralStationBedsideDetails1.BedId = 1;

            centralStationBedsideDetails2.lblBedNumber.Text = "Bed 2";
            centralStationBedsideDetails2.BedId = 2;

            centralStationBedsideDetails3.lblBedNumber.Text = "Bed 3";
            centralStationBedsideDetails3.BedId = 3;

            centralStationBedsideDetails4.lblBedNumber.Text = "Bed 4";
            centralStationBedsideDetails4.BedId = 4;

            centralStationBedsideDetails5.lblBedNumber.Text = "Bed 5";
            centralStationBedsideDetails5.BedId = 5;

            centralStationBedsideDetails6.lblBedNumber.Text = "Bed 6";
            centralStationBedsideDetails6.BedId = 6;

            centralStationBedsideDetails7.lblBedNumber.Text = "Bed 7";
            centralStationBedsideDetails7.BedId = 7;

            centralStationBedsideDetails8.lblBedNumber.Text = "Bed 8";
            centralStationBedsideDetails8.BedId = 8;
        }

        public static CentralStationBedsideDetails CentralStationBedsideDetails1
        {
            get { return centralStationBedsideDetails1; }
            set { centralStationBedsideDetails1 = value; }

        }

        public static CentralStationBedsideDetails CentralStationBedsideDetails2
        {
            get { return centralStationBedsideDetails2; }
            set { centralStationBedsideDetails2 = value; }
        }

        public static CentralStationBedsideDetails CentralStationBedsideDetails3
        {
            get { return centralStationBedsideDetails3; }
            set { centralStationBedsideDetails3 = value; }
        }

        public static CentralStationBedsideDetails CentralStationBedsideDetails4
        {
            get { return centralStationBedsideDetails4; }
            set { centralStationBedsideDetails4 = value; }
        }

        public static CentralStationBedsideDetails CentralStationBedsideDetails5
        {
            get { return centralStationBedsideDetails5; }
            set { centralStationBedsideDetails5 = value; }
        }

        public static CentralStationBedsideDetails CentralStationBedsideDetails6
        {
            get { return centralStationBedsideDetails6; }
            set { centralStationBedsideDetails6 = value; }
        }

        public static CentralStationBedsideDetails CentralStationBedsideDetails7
        {
            get { return centralStationBedsideDetails7; }
            set { centralStationBedsideDetails7 = value; }
        }

        public static CentralStationBedsideDetails CentralStationBedsideDetails8
        {
            get { return centralStationBedsideDetails8; }
            set { centralStationBedsideDetails8 = value; }
        }

        //Register staff button
        private void BtnRegisterStaff_Click(object sender, EventArgs e)
        {
            Hide();
            new StaffShifts().Show();
        }
        // Register Consultant
        private void BtnRegCon_Click(object sender, EventArgs e)
        {
            Hide();
            new RegisterConsultant().Show();
        }
        // Deregister Consultant
        private void BtnDeRegCon_Click(object sender, EventArgs e)
        {
            ConsultantStaff.Instance.ContactInformation = null;
            ConsultantStaff.Instance.NameStaff = null;
        }

        //Exit button
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /*
            I need the centralStationBedside to know which controller is his from here on out. As is
            it always refers to the one that is created here. So it always thinks the controller has been
            created regardless of which bedside you press.
        */
        private void CentralStationBedsideDetails_MouseDown(object sender, MouseEventArgs e)
        {
            CentralStationBedsideDetails clickedCentralStationBedsideDetails = sender as CentralStationBedsideDetails;

            var controller = listOfBedsideControllers.FirstOrDefault(x => x.BedId == clickedCentralStationBedsideDetails.BedId);

            if (controller == null)
            {
                var newController = new BedsideController
                {
                    BedId = int.Parse(clickedCentralStationBedsideDetails.lblBedNumber.Text.Split(' ')[1]),
                    CentralStationBedsideDetails = clickedCentralStationBedsideDetails
                };

                newController.OpenModuleSelectionForm(newController);
                listOfBedsideControllers.Add(newController);

                Hide();
            }
            else if (controller.CentralStationBedsideDetails == clickedCentralStationBedsideDetails)
            {
                controller.OpenBedsideMonitor();
                Hide();
            }
        }

        private void BtnAlarmResponseTimes_Click(object sender, EventArgs e)
        {
            Hide();
            new AlarmTimes().Show();
        }
    }
}
