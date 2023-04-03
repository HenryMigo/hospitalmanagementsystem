using System;
using System.Data;
using System.Windows.Forms;

namespace BedsideMonitoring.WinForms
{
    public partial class AlarmTimes : Form
    {
        DataRow dataRow;
        DataSet dataSet;

        public AlarmTimes()
        {
            InitializeComponent();
        }
        private void LoadTable()
        {
            //get the dataSet
            dataSet = DatabaseController.DBInstance.GetDataSet(Constants.selectTimes);
            DataTable table = dataSet.Tables[0];

            FillInTextFields(table);
            //DataTable table = DatabaseController.DBInstance.GetDataTable(Constants.selectTimes);

            //set up the data grid view
            dataGridView1.DataSource = table;
        }

        // fill in the text fields with the data on the row given by ind
        private void FillInTextFields(DataTable table)
        {
            //get the table row specified by ind
            dataRow = table.NewRow();
        }

        public void SaveTextField(DateTime triggerTime, DateTime muteTime)
        {
            int rows = DatabaseController.InsertRowInTimes(triggerTime, muteTime, Constants.insertTime);
            
            if (rows == Constants.errNoRowInserted)
            {
                MessageBox.Show(Constants.errInsertInTableStr);
            }

            LoadTable();
        }

        private void AlarmTimes_Load(object sender, EventArgs e)
        {
            LoadTable();
        }

        private void AlarmTimes_FormClosing(object sender, FormClosingEventArgs e)
        {
            DatabaseController.DBInstance.CloseConnection();
            Program.NewCentralStationOverview.Show();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Close();
            Program.NewCentralStationOverview.Show();
        }
    }
}
