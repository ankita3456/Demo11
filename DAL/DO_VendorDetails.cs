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
   public class DO_VendorDetails
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Dbconnection"].ToString());
        public void Insert(int _buisnessCategory, String _buisnessName, string _contactNo, string _address, string _city, string _state, string _postCode, int _id_Vendor, Int64? _iD = null)
        {

            con.Open();
            SqlCommand cmdToExecute = new SqlCommand();
            cmdToExecute.CommandText = "dbo.[usp_VendorDetails_Insert]";
            cmdToExecute.CommandType = CommandType.StoredProcedure;

            // Use base class' connection object
            cmdToExecute.Connection = con;
            try
            {
                cmdToExecute.Parameters.Add(new SqlParameter("@iIDBuisnessCategory", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _buisnessCategory));
                cmdToExecute.Parameters.Add(new SqlParameter("@sBuisnessName", SqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _buisnessName));
                cmdToExecute.Parameters.Add(new SqlParameter("@sContactNo", SqlDbType.VarChar, 20, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _contactNo));
                cmdToExecute.Parameters.Add(new SqlParameter("@sAddress", SqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _address));
                cmdToExecute.Parameters.Add(new SqlParameter("@sCity", SqlDbType.VarChar, 10, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _city));
                cmdToExecute.Parameters.Add(new SqlParameter("@sState", SqlDbType.VarChar, 10, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _state));
                cmdToExecute.Parameters.Add(new SqlParameter("@sPostCode", SqlDbType.VarChar, 20, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _postCode));
                cmdToExecute.Parameters.Add(new SqlParameter("@iId_Vendor", SqlDbType.BigInt, 8, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, _id_Vendor));
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
    }
}
