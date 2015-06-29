using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Configuration;

namespace DAL
{
    public class DO_BuisnessCategory
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Dbconnection"].ToString());
       
        public DataTable Selectall()
        {
        con.Open();
        SqlCommand cmdToExecute = new SqlCommand();
        cmdToExecute.CommandText = "dbo.[usp_BuisnessCategory_SelectAll]";
        cmdToExecute.CommandType = CommandType.StoredProcedure;
        DataTable toReturn = new DataTable("BC");
        SqlDataAdapter adapter = new SqlDataAdapter(cmdToExecute);
        // Use base class' connection object
        cmdToExecute.Connection = con;
            try
            {
                adapter.Fill(toReturn);
                return toReturn;
            }

           // i32ErrorCode = (Int32)cmdToExecu cmdToExecute.ExecuteNonQuery();
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("DORegistration1::Insert::Error occured.", ex);
            }
            finally
            {
                // Close connection.
                con.Close();

            }
        }
        public DataTable Selectall_Buisness_Category_W_Vendor()
        {
            con.Open();
            SqlCommand cmdToExecute = new SqlCommand();
            cmdToExecute.CommandText = "dbo.[usp_Buisness_Category_W_Vendor]";
            cmdToExecute.CommandType = CommandType.StoredProcedure;
            DataTable toReturn = new DataTable("BC");
            SqlDataAdapter adapter = new SqlDataAdapter(cmdToExecute);
            // Use base class' connection object
            cmdToExecute.Connection = con;
            try
            {
                adapter.Fill(toReturn);
                return toReturn;
            }

           // i32ErrorCode = (Int32)cmdToExecu cmdToExecute.ExecuteNonQuery();
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("DORegistration1::Insert::Error occured.", ex);
            }
            finally
            {
                // Close connection.
                con.Close();

            }
        }
    }
}

    
