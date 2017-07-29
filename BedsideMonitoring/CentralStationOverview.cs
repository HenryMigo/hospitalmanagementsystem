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
    public partial class CentralStationOverview : Form
    {
        CSVReader _CSVReader = new CSVReader();
        public CentralStationOverview()
        {
            InitializeComponent();
            PopulateCentralStationBedsideDetails();
            //streamsntimeOne();
            
        }

        private void PopulateCentralStationBedsideDetails()
        {
            centralStationBedsideDetails1.lblBedNumber.Text = "Bed 1";
            centralStationBedsideDetails2.lblBedNumber.Text = "Bed 2";
            centralStationBedsideDetails3.lblBedNumber.Text = "Bed 3";
            centralStationBedsideDetails4.lblBedNumber.Text = "Bed 4";
            centralStationBedsideDetails5.lblBedNumber.Text = "Bed 5";
            centralStationBedsideDetails6.lblBedNumber.Text = "Bed 6";
            centralStationBedsideDetails7.lblBedNumber.Text = "Bed 7";
            centralStationBedsideDetails8.lblBedNumber.Text = "Bed 8";
            //centralStationBedsideDetails1.
        }

#region centralStationBedsideDetails Accessors

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

        #endregion

        #region
        /*Timer stoptime = new Timer();*/

       // public void streamsntimeOne()
       //{
       //     CSVReader _CSVReader = new CSVReader();
       //     _CSVReader.csvVitalReader(CentralStationBedsideDetails1.lblBedNumber.Text);
       //     stoptime.Tick += Stoptime_TickOne;
       //     stoptime.Interval = 100;
       //     stoptime.Start();
       // }

       // public void Stoptime_TickOne(object sender, EventArgs e)
       // {
       //     _CSVReader.SetPatientData(_CSVReader.csvGetData());
       //     CentralStationBedsideDetails1.label1.Text = _CSVReader.Col1;
       //     CentralStationBedsideDetails1.label2.Text = _CSVReader.Col2;
       //     CentralStationBedsideDetails1.label3.Text = _CSVReader.Col3;
       //     CentralStationBedsideDetails1.label4.Text = _CSVReader.Col4;
       // }





        #endregion


        //Register staff button
        private void btnRegisterStaff_Click(object sender, EventArgs e)
        {
            Hide();
            new StaffShifts().Show();          
        }
        // Register Consultant
        private void btnRegCon_Click(object sender, EventArgs e)
        {
            Hide();
            new RegisterConsultant().Show();
        }
        // Deregister Consultant
        private void btnDeRegCon_Click(object sender, EventArgs e)
        {
            ConsultantStaff.Instance.ContactInformation = null;
            ConsultantStaff.Instance.NameStaff = null;
        }

        //Exit button
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /*
        I need the centralStationBedside to know which controller is his from here on out. As is
        it always refers to the one that is created here. So it always thinks the controller has been
        created regardless of which bedside you press.
                
        */
        private void centralStationBedsideDetails_MouseDown(object sender, MouseEventArgs e)
        {
            CentralStationBedsideDetails clickedCentralStationBedsideDetails = sender as CentralStationBedsideDetails;

            for (int i = 0; i <= BedsideController.ListOfBedsideControllers.Count; i++)
            {
                    if (BedsideController.ListOfBedsideControllers.Count == 0 || BedsideController.ListOfBedsideControllers[i] == null)
                    {
                        BedsideController.ListOfBedsideControllers.Add(new BedsideController());
                        BedsideController.ListOfBedsideControllers[i].CentralStationBedsideDetails = clickedCentralStationBedsideDetails;
                        BedsideController.ListOfBedsideControllers[i].OpenModuleSelectionForm(BedsideController.ListOfBedsideControllers[i]);
                        Hide();
                        break;
                    }
                    else if (BedsideController.ListOfBedsideControllers[i].CentralStationBedsideDetails == clickedCentralStationBedsideDetails)
                    {
                        BedsideController.ListOfBedsideControllers[i].OpenBedsideMonitor();
                        Hide();
                        break;
                    }
               
            }
        }

        private void btnAlarmResponseTimes_Click(object sender, EventArgs e)
        {
            Hide();
            new AlarmTimes().Show();
        }

       
        //public void BedBackgroudFlash()
        //{

        //    Alarm.AlarmTriggered = true;

        //    if (Alarm.AlarmTriggered == true)
        //    {
        //        switch (Alarm.BedOfAlarm)
        //        {
        //            case "bed1":
        //                DialogResult result = MessageBox.Show("Bed 1 is in alarm!", "Alarm", MessageBoxButtons.YesNo);
        //                while (Alarm.AlarmTriggered == true)
        //                {
        //                    centralStationBedsideDetails1.BackColor = Color.DarkRed;
        //                    timer.Enabled = true;
        //                    centralStationBedsideDetails1.BackColor = DefaultBackColor;

        //                    if (result == DialogResult.Yes)
        //                    {
        //                        Alarm.AlarmTriggered = false;
        //                    }
        //                    else
        //                    {
        //                        break;
        //                    }
        //                }
        //                break;
        //        }
        //    }

        //    /*
        // * if alarm = true
        // *      {
        // *          Switch (bedOfAlarm)
        // *          
        // *              case Bed 1
        // *                  while alarm  = true
        // *                  {
        // *                      centralStationBedsideDetails1.BackColor = Color.DarkRed;
        // *                      insert timer, not use threading.sleep as this will freeze UI
        // *                      centralStationBedsideDetails1.BackColor = DefaultBackColor;
        // *                  }
        // *              Default messagebox.show("alarm not true for any beds, should alarm be disabled?"yes no);
        // *      }
         
        // */
        //}

    }
}
