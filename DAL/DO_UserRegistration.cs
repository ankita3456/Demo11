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
   public class DO_UserRegistration
    {                
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Dbconnection"].ToString());

        public void Insert(String _full_Name, String _password, String _con_Password, DateTime _bdate, string _mob_no, string _con_Mob_No, String _email, string _ref_mob_no, String _mob_no_Country, Int64? _iD = null)
        {
            con.Open();
            SqlCommand cmdToExecute = new SqlCommand();
            cmdToExecute.CommandText = "dbo.[usp_UserRegistration_Insert]";
            cmdToExecute.CommandType = CommandType.StoredProcedure;

            // Use base class' connection object
            cmdToExecute.Connection = con;
            try
            {
                cmdToExecute.Parameters.Add(new SqlParameter("@sFull_Name", SqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _full_Name));
                cmdToExecute.Parameters.Add(new SqlParameter("@sPassword", SqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _password));
                cmdToExecute.Parameters.Add(new SqlParameter("@sCon_Password", SqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _con_Password));
                cmdToExecute.Parameters.Add(new SqlParameter("@daBdate", SqlDbType.DateTime, 8, ParameterDirection.Input, true, 0, 0, "", DataRowVersion.Proposed, _bdate));
                cmdToExecute.Parameters.Add(new SqlParameter("@lMob_no", SqlDbType.VarChar, 15, ParameterDirection.Input, false, 19, 0, "", DataRowVersion.Proposed, _mob_no));
                cmdToExecute.Parameters.Add(new SqlParameter("@lCon_Mob_No", SqlDbType.VarChar, 15, ParameterDirection.Input, false, 19, 0, "", DataRowVersion.Proposed, _con_Mob_No));
                cmdToExecute.Parameters.Add(new SqlParameter("@sEmail", SqlDbType.VarChar, 50, ParameterDirection.Input, true, 0, 0, "", DataRowVersion.Proposed, _email));
                cmdToExecute.Parameters.Add(new SqlParameter("@lref_mob_no", SqlDbType.VarChar, 15, ParameterDirection.Input, true, 19, 0, "", DataRowVersion.Proposed, _ref_mob_no));
                cmdToExecute.Parameters.Add(new SqlParameter("@sMob_no_Country", SqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _mob_no_Country));
                cmdToExecute.Parameters.Add(new SqlParameter("@lID", SqlDbType.BigInt, 8, ParameterDirection.Output, true, 19, 0, "", DataRowVersion.Proposed, _iD));
          //      cmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, true, 10, 0, "", DataRowVersion.Proposed, i32ErrorCode));

                cmdToExecute.ExecuteNonQuery();

                _iD = (Int64)cmdToExecute.Parameters["@lID"].Value;
                // cmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, true, 10, 0, "", DataRowVersion.Proposed, i32ErrorCode));
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
        public DataTable Login(string Mob_no, string Password)
        {
            con.Open();
            SqlCommand cmdToExecute = new SqlCommand();
            cmdToExecute.CommandText = "dbo.[usp_User_Login]";
            cmdToExecute.CommandType = CommandType.StoredProcedure;
            DataTable toReturn = new DataTable("User");
            SqlDataAdapter adapter = new SqlDataAdapter(cmdToExecute);
            // Use base class' connection object
            cmdToExecute.Connection = con;
            try
            {
                cmdToExecute.Parameters.Add(new SqlParameter("@sPassword", SqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, Password));
                cmdToExecute.Parameters.Add(new SqlParameter("@sMobNo", SqlDbType.VarChar, 15, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, Mob_no));
                cmdToExecute.ExecuteNonQuery();


                adapter.Fill(toReturn);
                return toReturn;
                // cmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, true, 10, 0, "", DataRowVersion.Proposed, i32ErrorCode));
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
