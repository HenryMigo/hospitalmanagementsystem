﻿using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BedsideMonitoring
{
    //Make it so that there will be a connection to the database and the table displays that.
    class DatabaseController
    {
        #region Attributes
        //Attributes
        private static string connectStr = Properties.Settings.Default.RegDeRegDBConnectionString;
        private static DatabaseController dbInstance;
        private SqlConnection connectToDatabase;
        private SqlDataAdapter dataAdapter;
        #endregion

        #region Properties

        //Returning the connection to the database.
        public static DatabaseController DBInstance
        {
            get
            {
                if (dbInstance == null)
                {
                    dbInstance = new DatabaseController();
                }

                return dbInstance;
            }
        }
        #endregion

        #region Methods

        //Opens the connection to the database.
        public void ConnectionOpen()
        {
            //Creates the connection to the database as an instance.
            connectToDatabase = new SqlConnection(connectStr);

            //Opens the connection.
            connectToDatabase.Open();
        }

        //Closing the Connection.
        public void CloseConnection()
        {
            //Closes the connection to the database.
            if (connectToDatabase != null)
                connectToDatabase.Close();
        }

        // Get the data set generated by the sqlStatement
        public DataSet GetDataSet(string sqlQuery)
        {
            DataSet dataSet;

            ConnectionOpen();

            // create the object dataAdapter to manipulate a table from the database StudentDissertations specified by connectionToDB
            dataAdapter = new SqlDataAdapter(sqlQuery, connectToDatabase);

            // create the dataset
            dataSet = new DataSet();

            dataAdapter.Fill(dataSet);

            CloseConnection();
            //return the dataSet
            return dataSet;

        }

        //Get a data table from the DB for a certain sql statement
        public DataTable GetDataTable(string sqlQuery)
        {
            //Create a dataTable object 
            DataTable dataTable = new DataTable();

            //Create the sqlConnection
            using (SqlConnection sqlConnection = new SqlConnection(connectStr))
            {
                sqlConnection.Open();

                using (SqlCommand command = new SqlCommand(sqlQuery, sqlConnection))
                {
                    dataTable.Load(command.ExecuteReader());
                }
            }
            return dataTable;
        }

        //Insert a row in the table
        public int InsertRowInTable(int staffID, DateTime registered, string sqlQuery)
        {
            //Create the sql connection
            using (SqlConnection sqlConnection = new SqlConnection(connectStr))
            {
                //Create and initialise an sql command
                using (SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlConnection))
                {
                    //Set the parameters of the sql statement
                    sqlCommand.Parameters.AddWithValue("@StaffID", staffID);
                    sqlCommand.Parameters.AddWithValue("@Registered", registered);

                    //Open the connection and execute the command containing the sql statement
                    try
                    {
                        sqlConnection.Open();
                        int noOfRows = sqlCommand.ExecuteNonQuery();

                        //Return the no of rows inserted(is 1 if executed correctly)
                        return noOfRows;
                    }
                    catch (SqlException ex)
                    {
                        //Return an error code
                        return Constants.errNoRowInserted;
                    }
                }
            }
        }

        // delete the speciefied row from the table Students
        //public void DeleteRow()
        //{
        //    ConnectionOpen();
        //    DataSet dataSet;
        //    dataSet = DatabaseController.DBInstance.GetDataSet(Constants.selectAll);
        //    DataTable table = dataSet.Tables[0];

        //    dataAdapter.Update(dataSet, "table");
        //    CloseConnection();
        //}

        public int deregisterRow(DateTime deRegistered, string sqlQuery)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectStr))
            {
                //Create and initialise an sql command
                using (SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlConnection))
                {
                    //Set the parameters of the sql statement
                    sqlCommand.Parameters.AddWithValue("@Registered", deRegistered);

                    //Open the connection and execute the command containing the sql statement
                    try
                    {
                        sqlConnection.Open();
                        int noOfRows = sqlCommand.ExecuteNonQuery();

                        //Return the no of rows inserted(is 1 if executed correctly)
                        return noOfRows;
                    }
                    catch (SqlException ex)
                    {
                        //Return an error code
                        return Constants.errNoRowInserted;
                    }
                }
            }
        }

    public int InsertRowInTimes(DateTime triggerTime, DateTime muteTime, string sqlQuery)
        {
            //Create the sql connection
            using (SqlConnection sqlConnection = new SqlConnection(connectStr))
            {
                //Create and initialise an sql command
                using (SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlConnection))
                {
                    //Set the parameters of the sql statement
                    sqlCommand.Parameters.AddWithValue("@TriggerTime", triggerTime);
                    sqlCommand.Parameters.AddWithValue("@MuteTime", muteTime);

                    //Open the connection and execute the command containing the sql statement
                    try
                    {
                        sqlConnection.Open();
                        int noOfRows = sqlCommand.ExecuteNonQuery();

                        //Return the no of rows inserted(is 1 if executed correctly)
                        return noOfRows;
                    }
                    catch (SqlException ex)
                    {
                        //Return an error code
                        return Constants.errNoRowInserted;
                    }
                }
            }
        }
        #endregion
    }
}
// I have put them in regions to make them easier to look at and find pieces of code.