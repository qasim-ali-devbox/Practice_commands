using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login_master : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }
    //protected void Button1_Click(object sender, EventArgs e)
    //{
    //    if (service.authenticate(User_Name.Text, Password.Text))
    //    {
    //        try
    //        {
    //            Server.Transfer("Home.aspx",true);
    //        }catch(Exception ex){
    //            var str = ex.ToString();
    //        }
    //    }
    //    else
    //    {
    //        System.Text.StringBuilder sb = new System.Text.StringBuilder();
    //        sb.Append("alert('");
    //        sb.Append("failed");
    //        sb.Append("');");
    //        ClientScript.RegisterOnSubmitStatement(this.GetType(), "alert", sb.ToString());
    //    }
    //}


    protected void RedirecttoHome(object sender, AuthenticateEventArgs e)
    {
        Server.TransferRequest(@"~/Home/Home.aspx");
    }
    protected void RedirecttoHome(object sender, EventArgs e)
    {
        Server.TransferRequest(@"~/Home/Home.aspx");
    }
    protected void Submit_Click(object sender, EventArgs e)
    {
        Label4.Text = "";
        if (Membership.ValidateUser(TBUserName.Text, TBPassword.Text))
        {
            FormsAuthentication.RedirectFromLoginPage(TBUserName.Text, Remember.Checked);
        }
        Label4.Text = Label4.Text + "Login failed, so you can't go to home page";
    }
}