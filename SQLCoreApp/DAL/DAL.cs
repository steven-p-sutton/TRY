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
            //bool b = false;
            //bool.TryParse(iconfiguration.GetConnectionString("Integrated Security"), out b);

            ConnectionLocalDBStringBuilder myConnectionString1 = new ConnectionLocalDBStringBuilder
            (
                //"Widget", "True", "", ""
                iconfiguration.GetConnectionString("Database")

            );
            _connectionString = myConnectionString1.ToString();

            ConnectionLocalDBStringBuilder myConnectionString2 = new ConnectionLocalDBStringBuilder
            (
                //"Widget", "True", "", ""
                iconfiguration.GetConnectionString("Database"),
                iconfiguration.GetConnectionString("UserName"),
                iconfiguration.GetConnectionString("Password")
            );
            _connectionString = myConnectionString2.ToString();

            ConnectionLocalDBStringBuilder myConnectionString3 = new ConnectionLocalDBStringBuilder
            (
                //"Widget", "True", "", ""
                iconfiguration.GetConnectionString("Database"),
                iconfiguration.GetConnectionString("Integrated Security"),
                iconfiguration.GetConnectionString("UserName"),
                iconfiguration.GetConnectionString("Password")
            );
            _connectionString = myConnectionString3.ToString();

            ConnectionMSSQLStringBuilder myConnectionString4 = new ConnectionMSSQLStringBuilder
            (
                iconfiguration.GetConnectionString("Server"),
                iconfiguration.GetConnectionString("Database"),
                iconfiguration.GetConnectionString("Integrated Security"),
                iconfiguration.GetConnectionString("UserName"),
                iconfiguration.GetConnectionString("Password")
            );
            _connectionString = myConnectionString4.ToString();

            // The one going out
            _connectionString = myConnectionString4.ToString();
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



