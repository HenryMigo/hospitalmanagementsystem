using BedsideMonitoring.Properties;
using System;
using System.Media;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace BedsideMonitoring
{

    public class Alarm
    {
        //Sound file in resources to play when alarm triggered
        // TODO: FIXME
        private readonly SoundPlayer mutable = new(Resources.Mutable);
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

        public void FormBackgroundFlash(string acts)
        {
            bool act = acts == "a";

            while (act == true)
            {
                if (Form.ActiveForm.BackColor == System.Drawing.SystemColors.Control)
                {
                    Form.ActiveForm.BackColor = System.Drawing.Color.DarkRed;
                }
                else
                {
                    Form.ActiveForm.BackColor = System.Drawing.SystemColors.Control;
                }
            }
        }

        public void ModuleFlash()
        {
            while (alarmCurrentlyTriggered == true)
            {
                if (Form.ActiveForm.BackColor == System.Drawing.SystemColors.Control)
                {
                    Form.ActiveForm.BackColor = System.Drawing.Color.DarkRed;
                }
                else
                {
                    BedsideMonitor.ActiveForm.BackColor = System.Drawing.SystemColors.Control;
                }
            }
        }

        // Sound loops when alarm is triggered
        public void TriggerAlarm()
        {
            // TODO: FIXME
            mutable.PlayLooping();
            AlarmCurrentlyTriggered = true;
        }

        //Mute the alarm when button on bedside monitor is pressed
        public void MuteAlarm(int patientVitalValue, int patientVitalMinLimit, int patientVitalMaxLimit)
        {
            if (patientVitalValue < patientVitalMinLimit | patientVitalValue > patientVitalMaxLimit)
            {
                AlarmCurrentlyTriggered = true;
                MessageBox.Show("Alarm cannot be muted.");
            }
            else
            {
                AlarmCurrentlyTriggered = false;

                // TODO: FIX ME
                mutable.Stop();
                MessageBox.Show("The alarm has been muted");
            }
        }

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
    public void SendEmail(string emailTo, string patientName, string bedNumber, string vitalIssue)
    {
        //Create message object with sender and receiver email address
        MailMessage email = new MailMessage("eastangliahospital@gmail.com", emailTo)
        {
            //Create email subject and body
            Subject = "Dear " + BedsideMonitoring.ConsultantStaff.Instance.NameStaff + " " + bedNumber + "Vitals out of recommended range",
            Body = "The " + vitalIssue + " of " + patientName + " in " + bedNumber + " is outside of optimal range"
        };

        //email authentication
        var smtpClient = new SmtpClient("smtp.gmail.com", 587)
        {
            UseDefaultCredentials = false,

            //email login details for outgoing email account
            Credentials = new NetworkCredential("eastangliahospital@gmail.com", "24506017"),
            EnableSsl = true
        };

        smtpClient.Send(email);
    }
}
