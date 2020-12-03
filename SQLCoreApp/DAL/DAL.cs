using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using SQLCoreApp.Model;

namespace SQLCoreApp.DAL
{
    public class WidgetDAL
    {
        // Lets use a ConnectionStringBuilder class for the database type chosen

        private string _connectionString;
        public WidgetDAL(IConfiguration iconfiguration)
        {
            ConnectionMSSQLStringBuilder myConnectionString1 = new ConnectionMSSQLStringBuilder
            (
                iconfiguration.GetConnectionString("Database")
            );
            _connectionString = myConnectionString1.ToString();

            ConnectionMSSQLStringBuilder myConnectionString2 = new ConnectionMSSQLStringBuilder
            (
                iconfiguration.GetConnectionString("Server"),
                iconfiguration.GetConnectionString("Database")
            );
            _connectionString = myConnectionString2.ToString();

            ConnectionMSSQLStringBuilder myConnectionString3 = new ConnectionMSSQLStringBuilder
            (
                iconfiguration.GetConnectionString("Database"),
                iconfiguration.GetConnectionString("UserName"),
                iconfiguration.GetConnectionString("Password")
            );
            _connectionString = myConnectionString3.ToString();

            ConnectionMSSQLStringBuilder myConnectionString4 = new ConnectionMSSQLStringBuilder
            (
                iconfiguration.GetConnectionString("Server"),
                iconfiguration.GetConnectionString("Database"),
                iconfiguration.GetConnectionString("UserName"),
                iconfiguration.GetConnectionString("Password")
            );
            _connectionString = myConnectionString4.ToString();

            ConnectionMSSQLStringBuilder myConnectionString5 = new ConnectionMSSQLStringBuilder
            (
                "(LocalDB)\\MSSQLLocalDB",
                "Widget",
                "Widget",
                "widget"
            );
            _connectionString = myConnectionString5.ToString();

            // Decide which one to use in connection
            _connectionString = myConnectionString5.ToString();


        }
        public List<WidgetModel> GetList()
        {
            var listWidgetModel = new List<WidgetModel>();
            try
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    SqlCommand cmd = new SqlCommand("SP_WIDGET_GET_LIST", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();

                    // Have to convert string to DateOffset outside of the WidgetModel 
                    // constructor so use Date varible define here and assigned in the 
                    // read processinbg loop below

                    DateTimeOffset Date = new DateTimeOffset();

                    while (rdr.Read())
                    {
                        DateTimeOffset.TryParse(rdr[1].ToString(), out Date);

                        listWidgetModel.Add(new WidgetModel
                        {
                            Id = Convert.ToInt32(rdr[0]),
                            Date = Date, // see TryParse(rdr[1].ToString()) above
                            Name = rdr[2].ToString(),
                            Count = Convert.ToInt32(rdr[3]),
                            Secret = rdr[4].ToString()
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return listWidgetModel;
        }
    }
}



