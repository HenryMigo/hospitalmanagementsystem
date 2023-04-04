using Bassoon;
using BedsideMonitoring.WinForms;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace BedsideMonitoring.WinForms
{

    public class Alarm
    {
        //Sound file in resources to play when alarm triggered
        Sound _sound;

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

        public static void FormBackgroundFlash(string acts)
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
                    Form.ActiveForm.BackColor = System.Drawing.SystemColors.Control;
                }
            }
        }

        // Sound loops when alarm is triggered
        public void TriggerAlarm()
        {
            // TODO: FIX ME No sound
            using var bassonEngine = new BassoonEngine();

            _sound = new(@"D:\dev\hospitalmanagementsystem\BedsideMonitoring.WinForms\Resources\Mutable.wav")
            {
                Volume = 1.00f
            };

            if (!_sound.IsPlaying)
            {
                _sound.Play();
            }

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

                // TODO: Stop sound
                if (_sound.IsPlaying)
                {
                    _sound.Pause();
                }

                MessageBox.Show("The alarm has been muted");
            }
        }

        //Method to send alert messages to staff member via SMS or pager
        public static void SendAlertMessageAlarm(string contactInformationMedicalStaff, string patientName, string bedNumber, string patientVitalName)
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
    public static void SendEmail(string emailTo, string patientName, string bedNumber, string vitalIssue)
    {
        //Create message object with sender and receiver email address
        MailMessage email = new("eastangliahospital@gmail.com", emailTo)
        {
            //Create email subject and body
            Subject = "Dear " + ConsultantStaff.Instance.NameStaff + " " + bedNumber + "Vitals out of recommended range",
            Body = "The " + vitalIssue + " of " + patientName + " in " + bedNumber + " is outside of optimal range"
        };

        //email authentication
        SmtpClient smtpClient = new("smtp.gmail.com", 587)
        {
            UseDefaultCredentials = false,

            //email login details for outgoing email account
            Credentials = new NetworkCredential("eastangliahospital@gmail.com", "24506017"),
            EnableSsl = true
        };

        smtpClient.Send(email);
    }
}
