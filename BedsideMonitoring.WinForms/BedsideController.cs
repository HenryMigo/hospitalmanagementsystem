using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace BedsideMonitoring.WinForms
{
    public class BedsideController
    {
        public int BedId { get; set; }
        private BedsideMonitor bedsideMonitor;
        private ModuleSelection moduleSelection;
        private CentralStationBedsideDetails centralStationBedsideDetails;
        private string module1Name, module2Name, module3Name, module4Name, bedName, patientName;
        private readonly CSVReader _csvReader = new();

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


        public void SetSelectedModules(string module1, string module2, string module3, string module4, string bedNumber, string pName)
        {
            module1Name = module1;
            module2Name = module2;
            module3Name = module3;
            module4Name = module4;
            bedName = bedNumber;
            patientName = pName;
            OpenBedsideMonitor();
            SetCentralStationBedsideDetails();
            StreamReader();
        }

        readonly Timer stopwatch = new();

        public void StreamReader()
        {
            _csvReader.CsvVitalReader(bedName);
            stopwatch.Tick += Stopwatch_Tick1;
            stopwatch.Interval = 100;
            stopwatch.Start();

        }

        private void Stopwatch_Tick1(object sender, EventArgs e)
        {

            _csvReader.SetPatientData(_csvReader.CsvGetData());
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
        StreamReader dataFile;

        public void CsvVitalReader(string bedNo)
        {
            string path = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            string location = Path.Combine(path, "Resources");
            string fileName = @"\" + bedNo + ".csv";
            dataFile = new StreamReader(location + fileName);
            dataFile.ReadLine();
        }

        public string CsvGetData()
        {
            if (!dataFile.EndOfStream)
            {
                return dataFile.ReadLine();
            }
            else
            {
                dataFile.DiscardBufferedData();
                dataFile.BaseStream.Seek(1, SeekOrigin.Begin);
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
