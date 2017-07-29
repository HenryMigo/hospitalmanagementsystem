using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace BedsideMonitoring
{
    public class BedsideController
    {
        private static List<BedsideController> listOfBedsideControllers = new List<BedsideController>();
        private BedsideMonitor bedsideMonitor;
        private ModuleSelection moduleSelection;
        private CentralStationBedsideDetails centralStationBedsideDetails;
        private string module1Name, module2Name, module3Name, module4Name, bedName, patientName;
        private CSVReader _csvReader = new CSVReader();
            
        public static List<BedsideController> ListOfBedsideControllers
        {
            get { return listOfBedsideControllers; }
            set { listOfBedsideControllers = value; }
        }
        public CentralStationBedsideDetails CentralStationBedsideDetails
        {
            get { return centralStationBedsideDetails; }
            set { centralStationBedsideDetails = value; }
        }

        public void OpenModuleSelectionForm(BedsideController createdBedsideController)
        {
            moduleSelection = new ModuleSelection(centralStationBedsideDetails.lblBedNumber.Text, createdBedsideController);
            moduleSelection.Show();
        }


        public void SetSelectedModules(string module1, string module2, string module3, string module4, string bednumber,string pName)
        {
            module1Name = module1;
            module2Name = module2;
            module3Name = module3;
            module4Name = module4;
            bedName = bednumber;
            patientName = pName;
            OpenBedsideMonitor();
            SetCentralStationBedsideDetails();
            Stremr();



        }

        System.Windows.Forms.Timer stopwatch = new System.Windows.Forms.Timer();
        public void Stremr()
        {
            _csvReader.csvVitalReader(bedName);
            stopwatch.Tick += Stopwatch_Tick1;
            stopwatch.Interval = 100;
            stopwatch.Start();

        }
        private void Stopwatch_Tick1(object sender, EventArgs e)
        {

            _csvReader.SetPatientData(_csvReader.csvGetData());
            centralStationBedsideDetails.label1.Text = _csvReader.Col1;
            centralStationBedsideDetails.label2.Text = _csvReader.Col2;
            centralStationBedsideDetails.label3.Text = _csvReader.Col3;
            centralStationBedsideDetails.label4.Text = _csvReader.Col4;
        }

        private void SetCentralStationBedsideDetails()
        {
            centralStationBedsideDetails.lblPatientVital1.Text = module1Name;
            centralStationBedsideDetails.lblPatientVital2.Text = module2Name;
            centralStationBedsideDetails.lblPatientVital3.Text = module3Name;
            centralStationBedsideDetails.lblPatientVital4.Text = module4Name;
            centralStationBedsideDetails.lblBedNumber.Text = bedName;
            centralStationBedsideDetails.lblPatientName.Text = patientName;


        }

        public void OpenBedsideMonitor()
        {
            bedsideMonitor = new BedsideMonitor(bedName, module1Name, module2Name, module3Name, module4Name, patientName);
            bedsideMonitor.Show();
        }




    }




    public class CSVReader
    {
        //private CentralStationBedsideDetails centralStationBedsideDetails;
        StreamReader dataFile;
        //System.Timers.Timer stopwatch = new System.Timers.Timer(100);
        // Used to read the CSV file (Which is created)




        public void csvVitalReader(string bedNo /*string fileName*/)
        {
            //bedNo = centralStationBedsideDetails.lblBedNumber.Text;
            //string fileName = @""+bedNo+".csv";
            //string path = Path.
            string path = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            string location = Path.Combine( Directory.GetParent(path).Parent.FullName, "Resources");
            string fileName = @"\"+ bedNo + ".csv";
            dataFile = new StreamReader(location + fileName);
            dataFile.ReadLine();
        }


        



        public string csvGetData()
        {
            if(!dataFile.EndOfStream)
            {
                return dataFile.ReadLine();
            }
            else
            {
                dataFile.DiscardBufferedData();
                dataFile.BaseStream.Seek(1,SeekOrigin.Begin);
                dataFile.ReadLine();
                return dataFile.ReadLine();
            }
            
        }



        public string Col1 { get; private set; }
        public string Col2 { get; private set; }
        public string Col3 { get; private set; }
        public string Col4 { get; private set; }





        // Sets the patient data.
        public void SetPatientData(string patientData)
        {
            string[] dataItems = patientData.Split(',');
            Col1 = (dataItems[0]);
            Col2 = (dataItems[1]);
            Col3 = (dataItems[2]);
            Col4 = (dataItems[3]);
        }
      
    }
}
    