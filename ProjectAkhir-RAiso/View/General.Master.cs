﻿using ProjectAkhir_RAiso.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectAkhir_RAiso.View
{
    public partial class General : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            User Logged = (User) Session["UserData"];
            
            if (Logged == null)
            {
                Hl_Login.Visible = true;
                Hl_Register.Visible = true;
                Btn_Cart.Visible = false;
                Btn_Transaction.Visible = false;
                Lbl_Profile.Visible = false;
                Img_Profile.Visible = false;

                return;
            }else if (Logged.UserRole == "Customer")
            {
                Hl_Login.Visible = false;
                Hl_Register.Visible = false;
                Btn_Cart.Visible = true;
                Btn_Transaction.Visible = true;
                //Transaction Link to Transaction Page
                Lbl_Profile.Visible = true;
                Img_Profile.Visible = true;

                Lbl_Profile.Text = "Hi, " + Logged.UserName;
            }
            else if (Logged.UserRole == "Admin")
            {
                Hl_Login.Visible = false;
                Hl_Register.Visible = false;
                Btn_Cart.Visible = false;
                Btn_Transaction.Visible = true;
                //Transaction Link to Transaction Report
                Lbl_Profile.Visible = true;
                Img_Profile.Visible = true;

                Lbl_Profile.Text = "Hi, " + Logged.UserName;
            }
        }

        protected void Img_Store_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }

        protected void Btn_Cart_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("CartPage.aspx");
        }

        protected void Btn_Transaction_Click(object sender, ImageClickEventArgs e)
        {
            User Logged = (User)Session["UserData"];

            if(Logged.UserRole == "Customer")
            {
                Response.Redirect("TransactionHistoryPage.aspx");
            }else if(Logged.UserRole == "Admin")
            {
                Response.Redirect("TransactionReportPage.aspx");
            }
            else
            {
                Response.Redirect("HomePage.aspx");
            }
        }
    }
}