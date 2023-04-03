﻿using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace BedsideMonitoring.WinForms
{
    //Make it so that there will be a connection to the database and the table displays that.
    class DatabaseController
    {
        //Attributes
        private static readonly string connectStr = Properties.Settings.Default.RegDeRegDBConnectionString;
        private static DatabaseController dbInstance;
        private SqlConnection connectToDatabase;
        private SqlDataAdapter dataAdapter;

        //Returning the connection to the database.
        public static DatabaseController DBInstance
        {
            get
            {
                dbInstance ??= new DatabaseController();

                return dbInstance;
            }
        }
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
            connectToDatabase?.Close();
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

            return dataSet;

        }

        //Get a data table from the DB for a certain sql statement
        public static DataTable GetDataTable(string sqlQuery)
        {
            //Create a dataTable object 
            DataTable dataTable = new();

            //Create the sqlConnection
            using (SqlConnection sqlConnection = new(connectStr))
            {
                sqlConnection.Open();

                using SqlCommand command = new(sqlQuery, sqlConnection);
                dataTable.Load(command.ExecuteReader());
            }
            return dataTable;
        }

        //Insert a row in the table
        public static int InsertRowInTable(int staffID, DateTime registered, string sqlQuery)
        {
            //Create the sql connection
            using SqlConnection sqlConnection = new(connectStr);
            //Create and initialise an sql command
            using SqlCommand sqlCommand = new(sqlQuery, sqlConnection);
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
            catch (SqlException)
            {
                //Return an error code
                return Constants.errNoRowInserted;
            }
        }

        public static int DeregisterRow(DateTime deRegistered, string sqlQuery)
        {
            using SqlConnection sqlConnection = new(connectStr);
            //Create and initialise an sql command
            using SqlCommand sqlCommand = new(sqlQuery, sqlConnection);
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
            catch (SqlException)
            {
                //Return an error code
                return Constants.errNoRowInserted;
            }
        }

        public static int InsertRowInTimes(DateTime triggerTime, DateTime muteTime, string sqlQuery)
        {
            //Create the sql connection
            using SqlConnection sqlConnection = new(connectStr);
            //Create and initialise an sql command
            using SqlCommand sqlCommand = new(sqlQuery, sqlConnection);
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
            catch (SqlException)
            {
                //Return an error code
                return Constants.errNoRowInserted;
            }
        }
    }
}