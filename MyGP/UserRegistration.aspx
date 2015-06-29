<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UserRegistration.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Register Page</title>
    <link href="CSS/bootstrap.min.css" rel="stylesheet" />
    <link href="CSS/index.css" rel="stylesheet" />
    <link href="CSS/font-awesome.min.css" rel="stylesheet" />
    <script src="SCRIPT/jquery-1.11.2.min.js"></script>
    <script src="SCRIPT/bootstrap.min.js"></script>
    <meta charset="UTF-8" />
    <meta name="description" content="Free Web tutorials" />
    <meta name="keywords" content="HTML,CSS,XML,JavaScript" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />

</head>
<body>

    <div class="container-fluid" style="background-color: rgba(0, 0, 0, 0.8)">
        <div class="row">
            <div class="col-md-12">
                <h4 style="color: #fff; text-align: center">Registration</h4>
            </div>
        </div>
    </div>


    <div class="container-fluid" style="background-color: #E8E3E3">
        <div class="row">

            <div style="margin: 10px 0 0 21%">
                <asp:Image ID="imgHeader" CssClass="img-responsive" runat="server" ImageUrl="~/Images/header-img.jpg" Width="74%" />

                <%--<asp:Image ID="img" cssClass="img-responsive" runat="server" ImageUrl="~/Images/header-img.jpg"   Width="100%" />--%>
            </div>

        </div>
        <div class="row" style="margin: 15px 0 0 0px">
            <div class="col-lg-8">
            </div>

            <%-- <div class="col-lg-2">
                <button type="button" class="btn btn-primary">Like</button>
            </div>--%>
            <button type="button" class="btn btn-primary btn-lg" style="margin-left: 80px">
                Like <span class="glyphicon glyphicon-thumbs-up" aria-hidden="true"></span>
            </button>

        </div>
        <div class="container">
            <form id="form1" runat="server">
                <div class="row">

                    <div class="col-md-2"></div>
                    <div class="col-md-8" style="border: 1px solid #C4C0C0; border-radius: 10px; margin: 4% 0 0 0; background-color: #fff">
                        <div class="row">
                            <div class="col-md-12" style="margin-left: 12px">
                                <h3 class="personalinformation">Personal Information</h3>

                                <h6>* Required</h6>
                            </div>
                        </div>
                        <div class="col-md-4" style="margin-top: 2%">
                            <asp:Label ID="lblFullName" runat="server" Text="Full Name *"></asp:Label>
                        </div>
                        <div class="col-md-6" style="margin-top: 2%">
                            <%--<asp:TextBox ID="txtFullName" runat="server" style="width:100%;padding:1%"></asp:TextBox>--%>
                            <asp:TextBox ID="txtFullName" runat="server" class="form-control" name="username" required="" autofocus="" Width="100%"></asp:TextBox>
                        </div>
                        <div class="col-md-4" style="margin-top: 2%">
                            <asp:Label ID="lblPswd" runat="server" Text="Password *"></asp:Label>
                        </div>
                        <div class="col-md-6" style="margin-top: 2%">
                            <%-- <asp:TextBox ID="txtPswd" runat="server" style="width:100%;padding:1%"></asp:TextBox>--%>
                            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" class="form-control" name="password" required="" Width="100%"></asp:TextBox>
                        </div>

                        <div class="col-md-4" style="margin-top: 2%">
                            <asp:Label ID="lblCnfirmPswd" runat="server" Text="Confirm Password *"></asp:Label>
                        </div>
                        <div class="col-md-6" style="margin-top: 2%">
                            <%--<asp:TextBox ID="txtCnfirmPswd" runat="server" style="width:100%;padding:1%"></asp:TextBox>--%>
                            <asp:TextBox ID="txtCnfirmPswd" runat="server" TextMode="Password" class="form-control" name="confirmpassword" required="" Width="100%"></asp:TextBox>
                            <asp:CompareValidator ID="cmparePswd" runat="server" ErrorMessage="Password must be the same" ControlToCompare="txtPassword" ControlToValidate="txtCnfirmPswd" ForeColor="Red" ValueToCompare="txtCnfirmPswd"></asp:CompareValidator>
                        </div>
                        <div class="col-md-4" style="margin-top: 2%">
                            <asp:Label ID="lblBday" runat="server" Text="Birthday "></asp:Label>
                        </div>
                        <div class="col-md-1" style="margin: 2% 0 0 1%">
                            <asp:DropDownList ID="cmbDays" runat="server">
                            </asp:DropDownList>

                            <%-- <select name="ctl00$ContentPlaceHolder1$drpDay" id="ctl00_ContentPlaceHolder1_drpDay" style="float:left;margin-top:2%">
	                        <option selected="selected" value="23">23</option>
	                        <option value="24">24</option>
	                        <option value="25">25</option>
	                       
                         </select>--%>
                        </div>
                        <div style="margin: 2% 0 0 1%; float: left">
                            <asp:DropDownList ID="cmbMonths" runat="server">
                            </asp:DropDownList>


                            <%-- <select name="ctl00$ContentPlaceHolder1$drpMonth" id="ctl00_ContentPlaceHolder1_drpMonth">
	                    <option value="1">JAN</option>
	                    <option value="2">FEB</option>
	                    <option value="3">MAR</option>
	                    <option value="4">APR</option>
	                    <option value="5">MAY</option>
	                    <option selected="selected" value="6">JUN</option>
	                    

                    </select>--%>
                        </div>
                        <div style="margin-top: 2%; float: left">
                            <asp:DropDownList ID="CmbYears" runat="server">
                            </asp:DropDownList>


                            <%--<select name="ctl00$ContentPlaceHolder1$drpYear" id="ctl00_ContentPlaceHolder1_drpYear">
	                        
	                        <option value="2013">2013</option>
	                        <option value="2014">2014</option>
	                        <option selected="selected" value="2015">2015</option>

                        </select>--%>
                        </div>
                        <div class="row">
                            <div class="col-md-12" style="margin-left: 12px">
                                <h3 class="contact-information">Contact Information</h3>
                            </div>
                        </div>
                        <div class="col-md-4" style="margin-top: 2%">
                            <asp:Label ID="lblMobile" runat="server" Text="Mobile No *"></asp:Label>
                        </div>
                        <div class="col-md-6" style="margin-top: 2%">
                            <asp:DropDownList ID="ddlMobile" runat="server" class="form-control" required="" autofocus="" Style="width: 100%; padding: 1%">
                                <asp:ListItem Value="Bru(673)" Text="Brunei Darussalam(673)"></asp:ListItem>
                                <asp:ListItem Value="Hon(852)" Text="Hong Kong(852)"></asp:ListItem>
                                <asp:ListItem Value="Mal(60)" Text="Malaysia(60)"></asp:ListItem>
                                <asp:ListItem Value="Sin(65)" Text="Singapore(65)"></asp:ListItem>
                            </asp:DropDownList>
                            <asp:TextBox ID="txtMobile" runat="server" Style="width: 100%"></asp:TextBox>
                           <%-- <cc1:filteredtextboxextender id="FTEPhone" runat="server" targetcontrolid="txtMobile"
                                filtertype="Custom, Numbers" validchars=",-">
                                            </cc1:filteredtextboxextender>--%>
                        </div>
                        <div class="col-md-4" style="margin-top: 2%">
                            <asp:Label ID="lblConfirmMobile" runat="server" Text="Confirm Mobile No *"></asp:Label>

                        </div>
                        <div class="col-md-6" style="margin-top: 2%">
                            <asp:DropDownList ID="ddlConfirmMobile" runat="server" class="form-control" required="" autofocus="" Style="width: 100%; padding: 1%">
                                <asp:ListItem Value="Bru(673)" Text="Brunei Darussalam(673)"></asp:ListItem>
                                <asp:ListItem Value="Hon(852)" Text="Hong Kong(852)"></asp:ListItem>
                                <asp:ListItem Value="Mal(60)" Text="Malaysia(60)"></asp:ListItem>
                                <asp:ListItem Value="Sin(65)" Text="Singapore(65)"></asp:ListItem>
                               
                            </asp:DropDownList>
                            <asp:CompareValidator ID="CompareValidator3" runat="server" ErrorMessage="Country must be the same" ControlToCompare="ddlConfirmMobile" ControlToValidate="ddlMobile" ForeColor="Red" ValueToCompare="ddlMobile"></asp:CompareValidator>
                            <asp:TextBox ID="txtConfirmMobile" runat="server" Style="width: 100%"></asp:TextBox>
                            <asp:CompareValidator ID="CompareValidator2" runat="server" ErrorMessage="Mob No. must be the same" ControlToCompare="txtMobile" ControlToValidate="txtConfirmMobile" ForeColor="Red" ValueToCompare="txtConfirmMobile"></asp:CompareValidator>
                        </div>
                        <div class="col-md-4" style="margin-top: 2%">
                            <asp:Label ID="lblEmail" runat="server" Text="Email "></asp:Label>
                        </div>
                        <div class="col-md-6" style="margin-top: 2%">
                            <%-- <asp:TextBox ID="txtEmail" runat="server" style="width:100%;padding:1%"></asp:TextBox>--%>
                            <asp:TextBox ID="txtEmail" runat="server" class="form-control" name="email" autofocus="" Width="100%"></asp:TextBox>
                        </div>
                        <div class="row">
                            <div class="col-md-12" style="margin-left: 12px">
                                <h3 class="optional-information">Optional Information</h3>
                            </div>
                        </div>
                        <div class="col-md-4" style="margin-top: 2%">
                            <asp:Label ID="lblReferalNo" runat="server" Text="Referal Mobile No "></asp:Label>
                        </div>
                        <div class="col-md-6" style="margin-top: 2%">
                            <%-- <asp:TextBox ID="txtReferalNo" runat="server" style="width:100%;padding:1%"></asp:TextBox>--%>
                            <asp:TextBox ID="txtReferalNo" runat="server" class="form-control" name="refermobile" autofocus="" Width="100%"></asp:TextBox>
                        </div>
                        <div class="col-md-12">
                            <asp:Button ID="btnSubmit" OnClick="btnSubmit_Click" CssClass="btn-group-lg" runat="server" Text="Submit" Style="width: 90%; margin: 3% 0 3% 5%; padding: 1%; border-radius: 10px; background-color: #b91d47; color: #fff" />
                        </div>
                    </div>

                </div>
                <div class="row">

                    <div class="col-md-2"></div>
                    <div class="col-md-8" style="border: 1px solid #C4C0C0; border-radius: 7px; margin: 4% 0 0 0; background-color: #fff">
                        <div class="row">
                            <h2 class="get-the-app">Get the App</h2>

                        </div>
                        <div class="row" style="margin: 3% 0">

                            <div class="col-md-4"></div>
                            <asp:ImageButton ID="ImageButton1" CssClass="img-responsive" runat="server" ImageUrl="~/Images/footer-img.jpg" />

                        </div>

                    </div>
            </form>

        </div>
    </div>

</body>
</html>
