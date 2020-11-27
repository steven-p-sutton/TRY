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
        private string _connectionString;
        public WidgetDAL(IConfiguration iconfiguration)
        {
            _connectionString = iconfiguration.GetConnectionString("Default");
        }
        public List<WidgetObject> GetList()
        {
            var listWidgetObject = new List<WidgetObject>();
            try
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    SqlCommand cmd = new SqlCommand("SP_WIDGET_GET_LIST", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();

                    DateTimeOffset Date = new DateTimeOffset();

                    while (rdr.Read())
                    {
                        DateTimeOffset.TryParse(rdr[1].ToString(), out Date);

                        listWidgetObject.Add(new WidgetObject
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
            return listWidgetObject;
        }
    }
}



