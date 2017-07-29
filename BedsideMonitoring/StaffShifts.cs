using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace BedsideMonitoring
{
    public partial class StaffShifts : Form//find better name
    {
        MedicalStaff newMedicalStaff = new MedicalStaff();

        DataRow dataRow;
        DataSet dataSet;

        public StaffShifts()
        {
            InitializeComponent();
        }

        private void regBtn_Click(object sender, EventArgs e)
        {
            int staffIDINT;
            bool tryParse = int.TryParse(staffIDTxt.Text, out staffIDINT);
            if (tryParse)
            {
                SaveTextField(staffIDINT);
                newMedicalStaff.IDStaff = staffIDINT;
            }
            else
            {
                MessageBox.Show("Staff ID needs to be an integer");
                staffIDTxt.Clear();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
            Program.NewCentralStationOverview.Show();
        }

        private void LoadTable()
        {
            //get the dataSet
            dataSet = DatabaseController.DBInstance.GetDataSet(Constants.selectAll);
            DataTable table = dataSet.Tables[0];

            FillInTextFields(table);
            //DataTable table = DatabaseController.DBInstance.GetDataTable(Constants.selectAll);

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

        private void SaveTextField(int staffIDINT)
        {
            int rows = DatabaseController.DBInstance.InsertRowInTable(staffIDINT, DateTime.Now, Constants.insertRow);
            if (rows == Constants.errNoRowInserted)
            {
                MessageBox.Show(Constants.errInsertInTableStr);
            }
            LoadTable();
        }

        private void StaffShifts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'registeringDerigesteringDatabaseDataSet.Table' table. You can move, or remove it, as needed.
            //this.tableTableAdapter.Fill(this.registeringDerigesteringDatabaseDataSet.Table);
            LoadTable();
        }

        private void btnDeregister_Click(object sender, EventArgs e)
        {
            int rows = DatabaseController.DBInstance.deregisterRow(DateTime.Now, Constants.insertRow);
            if (rows == Constants.errNoRowInserted)
            {
                MessageBox.Show(Constants.errInsertInTableStr);
            }
            LoadTable();
        }

        private void StaffShifts_FormClosing(object sender, FormClosingEventArgs e)
        {
            DatabaseController.DBInstance.CloseConnection();
            Program.NewCentralStationOverview.Show();
        }
    }
}
