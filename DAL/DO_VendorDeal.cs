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
    public class DO_VendorDeal
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Dbconnection"].ToString());

        public void Insert(string _comp_Logo, string _deal_Description, DateTime _expiry_DateTime, DateTime _posting_DateTime, int _id_Vendor, int _id_Buisness_Category, string _deal_Image, string _is_Paid, string _Occasion, int? _iD = null)
        {
            con.Open();
            SqlCommand cmdToExecute = new SqlCommand();
            cmdToExecute.CommandText = "dbo.[usp_VendorDeal_Insert]";
            cmdToExecute.CommandType = CommandType.StoredProcedure;

            // Use base class' connection object
            cmdToExecute.Connection = con;
            try
            {
                cmdToExecute.Parameters.Add(new SqlParameter("@sComp_Logo", SqlDbType.VarChar, 100, ParameterDirection.Input, true, 0, 0, "", DataRowVersion.Proposed, _comp_Logo));
                cmdToExecute.Parameters.Add(new SqlParameter("@sDeal_Description", SqlDbType.VarChar, 50, ParameterDirection.Input, true, 0, 0, "", DataRowVersion.Proposed, _deal_Description));
                cmdToExecute.Parameters.Add(new SqlParameter("@daExpiry_DateTime", SqlDbType.DateTime, 8, ParameterDirection.Input, true, 0, 0, "", DataRowVersion.Proposed, _expiry_DateTime));
               
                cmdToExecute.Parameters.Add(new SqlParameter("@daPosting_DateTime", SqlDbType.DateTime, 8, ParameterDirection.Input, true, 0, 0, "", DataRowVersion.Proposed, _posting_DateTime));
                cmdToExecute.Parameters.Add(new SqlParameter("@iId_Vendor", SqlDbType.BigInt, 8, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, _id_Vendor));
                cmdToExecute.Parameters.Add(new SqlParameter("@iId_Buisness_Category", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, _id_Buisness_Category));
                cmdToExecute.Parameters.Add(new SqlParameter("@sDeal_Image", SqlDbType.VarChar, 100, ParameterDirection.Input, true, 0, 0, "", DataRowVersion.Proposed, _deal_Image));
                cmdToExecute.Parameters.Add(new SqlParameter("@sIsPaid", SqlDbType.VarChar, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _is_Paid));
                cmdToExecute.Parameters.Add(new SqlParameter("@sOccasion", SqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _Occasion));
                cmdToExecute.Parameters.Add(new SqlParameter("@iId", SqlDbType.Int, 4, ParameterDirection.Output, true, 10, 0, "", DataRowVersion.Proposed, _iD));
                // cmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, true, 10, 0, "", DataRowVersion.Proposed, i32ErrorCode));



                cmdToExecute.ExecuteNonQuery();

                _iD = (Int32)cmdToExecute.Parameters["@iID"].Value;
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
       public DataTable Vendor_Deal_Vendor_Details_Selectall(string Occasion)
        {
        con.Open();
        SqlCommand cmdToExecute = new SqlCommand();
        cmdToExecute.CommandText = "dbo.[usp_VendorDeal_VendorDetails_SelectAll]";
        cmdToExecute.CommandType = CommandType.StoredProcedure;
        DataTable toReturn = new DataTable("BC");
        SqlDataAdapter adapter = new SqlDataAdapter(cmdToExecute);
        // Use base class' connection object
        cmdToExecute.Connection = con;
            try
            {
                cmdToExecute.Parameters.Add(new SqlParameter("@sOccasion", SqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, Occasion));
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

