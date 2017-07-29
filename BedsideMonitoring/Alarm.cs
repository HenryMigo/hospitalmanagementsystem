using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using BedsideMonitoring.Properties;
using System.Windows.Forms.Design;
using System.Drawing;
using System.Timers;

namespace BedsideMonitoring
{
    
    public class Alarm
    {
        Mail _mail = new Mail();
        private DateTime triggerTime;
        private DateTime muteTime;

        //Sound file in resources to play when alarm triggered
        private SoundPlayer mutable = new SoundPlayer(Resources.Mutable);
        //for testing bed background flash
        private bool alarmCurrentlyTriggered;
        private string bedOfAlarm;

        public bool AlarmCurrentlyTriggered
        {
            get { return alarmCurrentlyTriggered; }
            set { alarmCurrentlyTriggered = value; }
        }

        public string BedOfAlarm
        {
            get { return bedOfAlarm; }
            set { bedOfAlarm = value; }
        }

        
        
        // testing code
        // Alarm.BackgroundFlash(a);
        
        public void FormBackgroundFlash(string acts)
        {
            bool act = acts == "a";
            while (act == true)
                if (CentralStationOverview.ActiveForm.BackColor == System.Drawing.SystemColors.Control)
                {
                    CentralStationOverview.ActiveForm.BackColor = System.Drawing.Color.DarkRed;
                }
                else
                    CentralStationOverview.ActiveForm.BackColor = System.Drawing.SystemColors.Control;
        }
        public void ModuleFlash()
        {
            while (alarmCurrentlyTriggered == true)
            {
                if (BedsideMonitor.ActiveForm.BackColor == System.Drawing.SystemColors.Control)
                {
                    BedsideMonitor.ActiveForm.BackColor = System.Drawing.Color.DarkRed;
                }
                else
                {
                    BedsideMonitor.ActiveForm.BackColor = System.Drawing.SystemColors.Control;
                }
            }
        }
        /// the switch for both the bedside module fl;ash and csv reader should be able to use same switch if not similar
        /// 
        /// </summary>
        //public void BedBackgroudFlash()
        //{  try "CentralStationOverview.activeform"
        //    if (AlarmCurrentlyTriggered)
        //    {
        //        switch (BedOfAlarm)
        //        {
        //            case "bed1":
        //                MessageBox.Show("Patient in Bed 1 has critical vitals", "Bed 1");
        //                CentralStationOverview.CentralStationBedsideDetails1.BackColor = Color.DarkRed;
        //                AlarmLoop();

        //                break;
        //            case "bed2":
        //                MessageBox.Show("Patient in Bed 2 has critical vitals", "Bed 2");
        //                CentralStationOverview.CentralStationBedsideDetails2.BackColor = Color.DarkRed;
        //                break;
        //            case "bed3":
        //                MessageBox.Show("Patient in Bed 3 has critical vitals", "Bed 3");
        //                CentralStationOverview.CentralStationBedsideDetails3.BackColor = Color.DarkRed;
        //                break;
        //            case "bed4":
        //                MessageBox.Show("Patient in Bed 4 has critical vitals", "Bed 4");
        //                CentralStationOverview.CentralStationBedsideDetails4.BackColor = Color.DarkRed;
        //                break;
        //            case "bed5":
        //                MessageBox.Show("Patient in Bed 5 has critical vitals", "Bed 5");
        //                CentralStationOverview.CentralStationBedsideDetails5.BackColor = Color.DarkRed;
        //                break;
        //            case "bed6":
        //                MessageBox.Show("Patient in Bed 6 has critical vitals", "Bed 6");
        //                CentralStationOverview.CentralStationBedsideDetails6.BackColor = Color.DarkRed;
        //                break;
        //            case "bed7":
        //                MessageBox.Show("Patient in Bed 7 has critical vitals", "Bed 7");
        //                CentralStationOverview.CentralStationBedsideDetails7.BackColor = Color.DarkRed;
        //                break;
        //            case "bed8":
        //                MessageBox.Show("Patient in Bed 8 has critical vitals", "Bed 8");
        //                CentralStationOverview.CentralStationBedsideDetails3.BackColor = Color.DarkRed;
        //                break;
        //            default:
        //                break;
        //        }
        //    }
        //    else
        //    {
        //        CentralStationOverview.CentralStationBedsideDetails1.BackColor = SystemColors.Control;
        //        CentralStationOverview.CentralStationBedsideDetails2.BackColor = SystemColors.Control;
        //        CentralStationOverview.CentralStationBedsideDetails3.BackColor = SystemColors.Control;
        //        CentralStationOverview.CentralStationBedsideDetails4.BackColor = SystemColors.Control;
        //        CentralStationOverview.CentralStationBedsideDetails5.BackColor = SystemColors.Control;
        //        CentralStationOverview.CentralStationBedsideDetails6.BackColor = SystemColors.Control;
        //        CentralStationOverview.CentralStationBedsideDetails7.BackColor = SystemColors.Control;
        //        CentralStationOverview.CentralStationBedsideDetails8.BackColor = SystemColors.Control;
        //    }

        //      private void AlarmLoop(){
        //                  while (alarmTriggered == true)

        // {
        //                  
        //}
        //  }
        //}



        //Sound loops when alarm is triggered
        public void TriggerAlarm()
        {
            mutable.PlayLooping();
            triggerTime = DateTime.Now;
            AlarmCurrentlyTriggered = true;
            //ModuleFlash();
        }

        //FOR TESTING
        //Alarm.MuteAlarm(5)

        //Mute the alarm when button on bedside monitor is pressed
        public void MuteAlarm(int patientVitalValue, int patientVitalMinLimit, int patientVitalMaxLimit)
        {
            //If patientVitalValue is below the minimum or maximum allowable limit the alarm cannot be muted
            if (patientVitalValue < patientVitalMinLimit | patientVitalValue > patientVitalMaxLimit)
            {
                AlarmCurrentlyTriggered = true;
                MessageBox.Show("Alarm cannot be muted.");
            }
            //Else stop the alarm
            else
            {
                AlarmCurrentlyTriggered = false;

                mutable.Stop();
                muteTime = DateTime.Now;
                MessageBox.Show("The alarm has been muted");
            }
        }
        //FOR TESTING
        //Alarm.SendAlertMessageAlarm("00000000000", "Fred", 4, "Heart Rate");

        //Method to send alert messages to staff member via SMS or pager
        public void SendAlertMessageAlarm(string contactInformationMedicalStaff, string patientName, string bedNumber, string patientVitalName)
        {
            //Message to staff member
            MessageBox.Show(patientName + "'s (" + bedNumber + ") " +
                patientVitalName + " is outside the allowable limits.", "Staff Contact: " +
                contactInformationMedicalStaff);
        }
    }
}

    class Mail
    {
        //FOR TESTING
        //Mail.SendEmail("christopher1996@live.hk" , "James", 007,"Heartbroken")

        //Method to send email alerts to consultants
        //string patientName, string bedNumber, string vitalIssue)
        // need to pass data in from data base

        
        public void SendEmail(string emailadd, string patientName, string bedNumber, string vitalIssue)
        {
            //Create message object with sender and receiver email address

            MailMessage email = new MailMessage("eastangliahospital@gmail.com", BedsideMonitoring.ConsultantStaff.Instance.ContactInformation );

            //Create email subject and body
            email.Subject = "Dear " + BedsideMonitoring.ConsultantStaff.Instance.NameStaff +" " + bedNumber + "Vitals out of recommended range";
            email.Body = "The " + vitalIssue + " of " + patientName + " in " + bedNumber + " is outside of optimal range";

            //email authentication
            var engine = new SmtpClient("smtp.gmail.com", 587);
            engine.UseDefaultCredentials = false;

            //email login details for outgoing email account
            engine.Credentials = new NetworkCredential("eastangliahospital@gmail.com", "24506017");
            engine.EnableSsl = true;
            engine.Send(email);
        }

     
}
