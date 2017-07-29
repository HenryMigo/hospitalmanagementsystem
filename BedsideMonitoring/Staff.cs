using System;
using System.Windows.Forms;

namespace BedsideMonitoring
{
    //FOR TESTING UNCOMMENT BELOW!
    #region EntryPointForThisClass

    //static class Entrypoint
    //{
    //    [STAThread]
    //    static void Main()
    //    {
    //        Application.EnableVisualStyles();
    //        Application.SetCompatibleTextRenderingDefault(false);

    //        var medStaff1 = new MedicalStaff();
    //        medStaff1.WorkHourPerDayMedicalStaff = new TimeSpan(00, 06, 00, 00);
    //        medStaff1.RegisterOnCallMedicalStaff();
    //        MessageBox.Show(medStaff1.DeregisterOnCallMedicalStaff());
    //    }
    //}

    #endregion

    public abstract class Staff
    {
        //Staff attributes
        protected string nameStaff;
        protected int iDStaff;
        protected string contactInformation;

        public int IDStaff
        {
            get { return iDStaff; }
            set { iDStaff = value; }
        }

        public string ContactInformation
        {
            get { return contactInformation; }
            set { contactInformation = value; }
        }

        public string NameStaff
        {
            set { nameStaff = value; }
            get { return nameStaff;  }
        }
    }

    public class MedicalStaff : Staff
    {
        private DateTime shiftStartMedicalStaff = new DateTime(2015, 10, 14, 15, 00, 00);
        private DateTime shiftEndMedicalStaff = new DateTime(2015, 10, 14, 21, 00, 00);
        private TimeSpan workHourPerDayMedicalStaff;

        private bool onCallMedicalStaff = false;

        #region Accessors

        public TimeSpan WorkHourPerDayMedicalStaff
        {
            set
            {
                workHourPerDayMedicalStaff = value;
            }
        }

        public DateTime ShiftStartMedicalStaff
        {
            set
            {
                shiftStartMedicalStaff = value;
            }
        }

        public DateTime ShiftEndMedicalStaff
        {
            set
            {
                shiftEndMedicalStaff = value;
            }
        }

        public bool OnCallMedicalStaff
        {
            get
            {
                return onCallMedicalStaff;
            }
        }

        #endregion

        #region Public Methods

        public void RegisterOnCallMedicalStaff()
        {
            //var shiftStartMedicalStaff = DateTime.Now;
            onCallMedicalStaff = true;
        }

        public string DeregisterOnCallMedicalStaff()
        {
            //var shiftEndMedicalStaff = DateTime.Now;
            if (CanDeregister())
            {
                onCallMedicalStaff = false;
                return "You have been deregistered";
            }
            else
            {
                return "You cannot deregister, you have: "
                        + (workHourPerDayMedicalStaff - GetShiftHourLeft()).ToString(@"hh\:mm")
                        + " Hour(s) left on your shift";
            }
        }

        #endregion

        #region Private Methods

        private bool CanDeregister()
        {
            if (GetShiftHourLeft() >= workHourPerDayMedicalStaff)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private TimeSpan GetShiftHourLeft()
        {
            TimeSpan span = shiftEndMedicalStaff - shiftStartMedicalStaff;
            return span;
        }

        #endregion
    }
    public class ConsultantStaff : Staff
    {
        private static ConsultantStaff instance;

        protected ConsultantStaff()
        {

        }
        public static ConsultantStaff Instance
        {
            get
            {
                if (instance == null)
                {
                    return instance = new ConsultantStaff();
                }
                else
                {
                    return instance;
                }
            }
        }
    }
}
