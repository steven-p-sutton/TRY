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

                    Boolean b = false;
                    DateTimeOffset d = new DateTimeOffset();

                    while (rdr.Read())
                    {
                        b = DateTimeOffset.TryParse(rdr[1].ToString(), out d);

                        listWidgetModel.Add(new WidgetModel
                        {
                            Id = Convert.ToInt32(rdr[0]),
                            Date = d,
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



