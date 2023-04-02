using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BedsideMonitoring
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

            //get the SID
            //staffIDTxt.Text = dataRow.ItemArray.GetValue(0).ToString();
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
            // TODO: This line of code loads data into the 'registeringDerigesteringDatabaseDataSet.Table' table. You can move, or remove it, as needed.
            //this.tableTableAdapter.Fill(this.registeringDerigesteringDatabaseDataSet.Table);
            LoadTable();
        }

        private void AlarmTimes_FormClosing(object sender, FormClosingEventArgs e)
        {
            DatabaseController.DBInstance.CloseConnection();
            Program.NewCentralStationOverview.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
            Program.NewCentralStationOverview.Show();
        }


    }
}
