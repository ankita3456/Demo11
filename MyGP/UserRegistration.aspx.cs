using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;
using DAL;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
     

        if (!IsPostBack)
        {
            FillDays();
            FillYears();
            FillMonths();
        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        try
        {
            DO_UserRegistration UserReg = new DO_UserRegistration();
            
            string Bdate;
            string Fbdate;
            int monthInDigit = DateTime.ParseExact(cmbMonths.SelectedValue, "MMM", CultureInfo.InvariantCulture).Month;
            if (monthInDigit < 10)
            {
                Bdate = cmbDays.SelectedValue + "/" + "0" + monthInDigit + "/" + CmbYears.SelectedValue;
            }
            else
            {
                Bdate = cmbDays.SelectedValue + "/"  + monthInDigit + "/" + CmbYears.SelectedValue;
            }
            
            
            Fbdate = Bdate.Replace(" ", "");
            DateTime dt = DateTime.ParseExact(Fbdate, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            UserReg.Insert(1, txtFullName.Text, txtPassword.Text, txtCnfirmPswd.Text, dt, Convert.ToInt64(txtMobile.Text), Convert.ToInt64(txtConfirmMobile.Text), txtEmail.Text, Convert.ToInt64(txtReferalNo.Text), ddlMobile.SelectedValue);


        }
        catch(Exception ex)
        {
            throw ex;
        }
      
    }
    protected void FillDays()
     {
         for (int i = 1; i <= 31; i++)
         {
             cmbDays.Items.Add(i.ToString());
         }
         cmbDays.Items.FindByValue(System.DateTime.Now.Day.ToString()).Selected = true;
    }
    protected void FillYears()
    {
        for (int i = 1915; i <= System.DateTime.Now.Year; i++)
        {
            CmbYears.Items.Add(i.ToString());
        }
        CmbYears.Items.FindByValue(System.DateTime.Now.Year.ToString()).Selected = true; 
    }
    protected void FillMonths()
    {
         for (int month = 1; month <= 12; month++)
        {
            string monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            string months = monthName.Substring(0, 3);
           
            cmbMonths.Items.Add(new ListItem(months));
        }
         string todayMonth = DateTimeFormatInfo.CurrentInfo.GetMonthName(System.DateTime.Now.Month).Substring(0,3);
       
        
        cmbMonths.Items.FindByValue(todayMonth).Selected = true;
    }
    }
