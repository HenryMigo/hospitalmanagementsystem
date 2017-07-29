using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedsideMonitoring
{
    class Constants
    {
        //Constants that allow you to edit the data.
        public static string selectAll = "SELECT * FROM StaffShifts";
        public static string insertRow = "INSERT INTO StaffShifts (StaffID, Registered) VALUES (@StaffID, @Registered)";
        public static string deleteRow = "DELETE FROM StaffShifts WHERE StaffID = @StaffID";
        // public static string registeredTime = "INSERT INTO [Table] (Registered) Values (@GetDate())";

        public static string selectTimes = "SELECT * FROM AlarmTimes";
        public static string insertTime = "INSERT INTO AlarmTimes (TriggerTime, MuteTime) VALUES (@TriggerTime, @MuteTime)";
        public static string deleteTime = "DELETE FROM AlarmTimes WHERE TriggerTime = @TriggerTime";

        // Consultant Email Address
              //Error messages
        public static string errInsertInTableStr = "The row was not inserted in the table";
        public static string errDeleteRowFromTableStr = "The selected row was not deleted from the DB";

        //Error codes
        public static int errNoRowInserted = 0;
        public static int errNoRowDeleted = 0;

      
    }
}
