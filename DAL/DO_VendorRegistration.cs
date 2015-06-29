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
    public class DO_VendorRegistration
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Dbconnection"].ToString());
        //int Id;
        public void Insert(string _f_Name, string _l_Name, string _e_Mail, string _password, string _con_Password, string _isConfirm, Int64? _iD = null)
        {
            con.Open();
            SqlCommand cmdToExecute = new SqlCommand();
            cmdToExecute.CommandText = "dbo.[usp_Vendor_Registration_Insert]";
            cmdToExecute.CommandType = CommandType.StoredProcedure;

            // Use base class' connection object
            cmdToExecute.Connection = con;
            try
            {
                cmdToExecute.Parameters.Add(new SqlParameter("@sF_Name", SqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _f_Name));
                cmdToExecute.Parameters.Add(new SqlParameter("@sL_Name", SqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _l_Name));
                cmdToExecute.Parameters.Add(new SqlParameter("@sE_Mail", SqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _e_Mail));
                cmdToExecute.Parameters.Add(new SqlParameter("@sPassword", SqlDbType.VarChar, 20, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _password));
                cmdToExecute.Parameters.Add(new SqlParameter("@sCon_Password", SqlDbType.VarChar, 20, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _con_Password));
                //cmdToExecute.Parameters.Add(new SqlParameter("@sBuisnessCategory", SqlDbType.VarChar, 20, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _buisnessCategory));
                //cmdToExecute.Parameters.Add(new SqlParameter("@sBuisnessName", SqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _buisnessName));
                //cmdToExecute.Parameters.Add(new SqlParameter("@sContactNo", SqlDbType.VarChar, 20, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _contactNo));
                //cmdToExecute.Parameters.Add(new SqlParameter("@sAddress", SqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _address));
                //cmdToExecute.Parameters.Add(new SqlParameter("@sCity", SqlDbType.VarChar, 10, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _city));
                //cmdToExecute.Parameters.Add(new SqlParameter("@sState", SqlDbType.VarChar, 10, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _state));
                //cmdToExecute.Parameters.Add(new SqlParameter("@sPostCode", SqlDbType.VarChar, 20, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _postCode));
                cmdToExecute.Parameters.Add(new SqlParameter("@sIsConfirm", SqlDbType.VarChar, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _isConfirm));
                cmdToExecute.Parameters.Add(new SqlParameter("@iID", SqlDbType.BigInt, 8, ParameterDirection.Output, true, 10, 0, "", DataRowVersion.Proposed, _iD));
                // cmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, true, 10, 0, "", DataRowVersion.Proposed, i32ErrorCode));


                cmdToExecute.ExecuteNonQuery();

                _iD = (Int64)cmdToExecute.Parameters["@iID"].Value;
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
        public DataTable Login(string Email, string Password)
        {
            con.Open();
            SqlCommand cmdToExecute = new SqlCommand();
            cmdToExecute.CommandText = "dbo.[usp_Vendor_Login]";
            cmdToExecute.CommandType = CommandType.StoredProcedure;
            DataTable toReturn = new DataTable("User");
            SqlDataAdapter adapter = new SqlDataAdapter(cmdToExecute);
            // Use base class' connection object
            //cmdToExecute.Connection = con;
            try
            {
                cmdToExecute.Parameters.Add(new SqlParameter("@sEmail", SqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, Email));
                cmdToExecute.Parameters.Add(new SqlParameter("@sPassWord", SqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, Password));
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
