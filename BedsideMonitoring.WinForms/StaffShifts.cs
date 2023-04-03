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

namespace BedsideMonitoring.WinForms
{
    public partial class StaffShifts : Form//find better name
    {
        readonly MedicalStaff newMedicalStaff = new();

        DataRow dataRow;
        DataSet dataSet;

        public StaffShifts()
        {
            InitializeComponent();
        }

        private void RegBtn_Click(object sender, EventArgs e)
        {
            bool tryParse = int.TryParse(staffIDTxt.Text, out int staffIDINT);

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

        private void BtnBack_Click(object sender, EventArgs e)
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

            //set up the data grid view
            dataGridView1.DataSource = table;
        }

        // fill in the text fields with the data on the row given by ind
        private void FillInTextFields(DataTable table)
        {
            //get the table row specified by ind
            dataRow = table.NewRow();

            //get the SID
            staffIDTxt.Text = dataRow.ItemArray.GetValue(0).ToString();
        }

        private void SaveTextField(int staffIDINT)
        {
            int rows = DatabaseController.InsertRowInTable(staffIDINT, DateTime.Now, Constants.insertRow);
            
            if (rows == Constants.errNoRowInserted)
            {
                MessageBox.Show(Constants.errInsertInTableStr);
            }

            LoadTable();
        }

        private void StaffShifts_Load(object sender, EventArgs e)
        {
            LoadTable();
        }

        private void BtnDeregister_Click(object sender, EventArgs e)
        {
            int rows = DatabaseController.DeregisterRow(DateTime.Now, Constants.insertRow);
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
