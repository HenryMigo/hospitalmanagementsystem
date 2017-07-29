using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;

namespace BedsideMonitoring
{
    public partial class BedsideMonitor : Form
    {
        CSVReader _Csvreader = new CSVReader();
        Alarm _alarm = new Alarm();
        Mail _mail = new Mail();
        Timer a = new Timer();
        //System.Timers.Timer stopwatch = new System.Timers.Timer(100);






        private int PatientUpperLimit1,
                PatientLowerLimit1,
                PatientUpperLimit2,
                PatientLowerLimit2,
                PatientUpperLimit3,
                PatientLowerLimit3,
                PatientUpperLimit4,
                PatientLowerLimit4;
        private string /*BN,*/ PN;

        private void btn_mute_Click(object sender, EventArgs e)
        {
            //_alarm.MuteAlarm();
            a.Stop();
            _alarm.AlarmCurrentlyTriggered = false;
            this.BackColor = System.Drawing.SystemColors.Control;
        }

        public BedsideMonitor(string bedName, string module1Name, string module2Name, string module3Name, string module4Name, string PName)
        {
            InitializeComponent();
            Timer stopwatch = new Timer();      
            bedsideModule1.lblBedsideModule.Text = module1Name;
            bedsideModule2.lblBedsideModule.Text = module2Name;
            bedsideModule3.lblBedsideModule.Text = module3Name;
            bedsideModule4.lblBedsideModule.Text = module4Name;
            lblBed.Text = bedName;
            _alarm.BedOfAlarm = lblBed.Text;
            PN = PName;
            a.Tick += A_Tick;
            a.Interval = 100;
            _Csvreader.csvVitalReader(bedName);
            //
            stopwatch.Tick += Stopwatch_Tick1;
            stopwatch.Interval = 100;
            stopwatch.Start();

           
            //// bedsideModule1.lblPatientVital.Text = ;
        }

        private void Stopwatch_Tick1(object sender, EventArgs e)
        {
            
            _Csvreader.SetPatientData(_Csvreader.csvGetData());
            bedsideModule1.lblPatientVital.Text = _Csvreader.Col1;
            bedsideModule2.lblPatientVital.Text = _Csvreader.Col2;
            bedsideModule3.lblPatientVital.Text = _Csvreader.Col3;
            bedsideModule4.lblPatientVital.Text = _Csvreader.Col4;       
        }

       

        private void btnSetModuleLimits_Click(object sender, EventArgs e)
        {
            int col1CSV = Int32.Parse(bedsideModule1.lblPatientVital.Text);
            int col2CSV = Int32.Parse(bedsideModule2.lblPatientVital.Text);
            int col3CSV = Int32.Parse(bedsideModule3.lblPatientVital.Text);
            int col4CSV = Int32.Parse(bedsideModule4.lblPatientVital.Text);
            SetModuleLimits(bedsideModule1.numericUpDown1.Text, bedsideModule1.numericUpDown2.Text, ref PatientUpperLimit1, ref PatientLowerLimit1);
            SetModuleLimits(bedsideModule2.numericUpDown1.Text, bedsideModule2.numericUpDown2.Text, ref PatientUpperLimit2, ref PatientLowerLimit2);
            SetModuleLimits(bedsideModule3.numericUpDown1.Text, bedsideModule3.numericUpDown2.Text, ref PatientUpperLimit3, ref PatientLowerLimit3);
            SetModuleLimits(bedsideModule4.numericUpDown1.Text, bedsideModule4.numericUpDown2.Text, ref PatientUpperLimit4, ref PatientLowerLimit4);

            // Module1
            if (PatientUpperLimit1 < col1CSV)
            {
                
                
                a.Start();
                _alarm.TriggerAlarm();
                _alarm.SendAlertMessageAlarm( "Nurse",PN ,_alarm.BedOfAlarm,bedsideModule1.lblBedsideModule.Text);
                _mail.SendEmail(ConsultantStaff.Instance.ContactInformation, PN, _alarm.BedOfAlarm, bedsideModule1.lblBedsideModule.Text);
                
            }
            if (PatientLowerLimit1 > col1CSV)
            {
                a.Start();
                _alarm.TriggerAlarm();
                _alarm.SendAlertMessageAlarm("Nurse", PN, _alarm.BedOfAlarm, bedsideModule1.lblBedsideModule.Text);
                _mail.SendEmail(ConsultantStaff.Instance.ContactInformation, PN, _alarm.BedOfAlarm, bedsideModule1.lblBedsideModule.Text);
            }
            // Module2
            if (PatientUpperLimit2 < col2CSV)
            {
                a.Start();
                _alarm.TriggerAlarm();
                _alarm.SendAlertMessageAlarm("Nurse", PN, _alarm.BedOfAlarm, bedsideModule2.lblBedsideModule.Text);
                _mail.SendEmail(ConsultantStaff.Instance.ContactInformation, PN, _alarm.BedOfAlarm, bedsideModule2.lblBedsideModule.Text);
            }
            if (PatientLowerLimit2 > col2CSV)
            {
                a.Start();
                _alarm.TriggerAlarm();
                _alarm.SendAlertMessageAlarm("Nurse", PN, _alarm.BedOfAlarm, bedsideModule2.lblBedsideModule.Text);
                _mail.SendEmail(ConsultantStaff.Instance.ContactInformation, PN, _alarm.BedOfAlarm, bedsideModule2.lblBedsideModule.Text);
            }
            // Module3
            if (PatientUpperLimit3 < col3CSV)
            {
                a.Start();
                _alarm.TriggerAlarm();
                _alarm.SendAlertMessageAlarm("Nurse", PN, _alarm.BedOfAlarm, bedsideModule3.lblBedsideModule.Text);
                _mail.SendEmail(ConsultantStaff.Instance.ContactInformation, PN, _alarm.BedOfAlarm, bedsideModule3.lblBedsideModule.Text);
            }
            if (PatientLowerLimit3 > col3CSV)
            {
                a.Start();
                _alarm.TriggerAlarm();
                _alarm.SendAlertMessageAlarm("Nurse", PN, _alarm.BedOfAlarm, bedsideModule3.lblBedsideModule.Text);
                _mail.SendEmail(ConsultantStaff.Instance.ContactInformation, PN, _alarm.BedOfAlarm, bedsideModule3.lblBedsideModule.Text);
            }
            //Module4
            if (PatientUpperLimit4 < col4CSV)
            {
                a.Start();
                _alarm.TriggerAlarm();
                _alarm.SendAlertMessageAlarm("Nurse", PN, _alarm.BedOfAlarm, bedsideModule4.lblBedsideModule.Text);
                _mail.SendEmail(ConsultantStaff.Instance.ContactInformation, PN, _alarm.BedOfAlarm, bedsideModule4.lblBedsideModule.Text);
            }
            if (PatientLowerLimit4 > col4CSV)
            {
                a.Start();
                _alarm.TriggerAlarm();
                _alarm.SendAlertMessageAlarm("Nurse", PN, _alarm.BedOfAlarm, bedsideModule4.lblBedsideModule.Text);
                _mail.SendEmail(ConsultantStaff.Instance.ContactInformation, PN, _alarm.BedOfAlarm, bedsideModule4.lblBedsideModule.Text);
            }

        }

        private void A_Tick(object sender, EventArgs e)
        {
            if (this.BackColor == System.Drawing.SystemColors.Control)
            {
                this.BackColor = System.Drawing.Color.DarkRed;
            }
            else
            {
                this.BackColor = System.Drawing.SystemColors.Control;
            }
        }

        private void SetModuleLimits(string numericUpDown1, string numericUpDown2, ref int patientUpperLimit, ref int patientLowerLimit)
        {
            if (patientUpperLimit < 0) throw new ArgumentOutOfRangeException("patientUpperLimit");
            patientUpperLimit = Convert.ToInt32(numericUpDown1);
            patientLowerLimit = Convert.ToInt32(numericUpDown2);
        }

        private void BedsideMonitor_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.NewCentralStationOverview.Show();
        }
    }
}
