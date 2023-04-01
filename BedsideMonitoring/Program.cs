using System;
using System.Windows.Forms;

namespace BedsideMonitoring
{
    static class Program
    {
        private static CentralStationOverview newCentralStationOverview;

        public static CentralStationOverview NewCentralStationOverview
        {
            get { return newCentralStationOverview; }
        }
        //Do not uncomment unless you know what you are doing
        //If you want to test your own class then copy this class to
        //your own class
        //Make sure that before commiting and pushing you comment that
        //entry point class or someone is bound to have trouble

        //Main entry point for the program
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(newCentralStationOverview = new CentralStationOverview());
        }
    }
}
