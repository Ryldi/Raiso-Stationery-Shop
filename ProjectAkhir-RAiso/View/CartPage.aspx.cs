using ProjectAkhir_RAiso.Controller;
using ProjectAkhir_RAiso.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectAkhir_RAiso.View
{
    public partial class CartPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                User Logged = (User)Session["UserData"];

                if (Logged == null || Logged.UserRole != "Customer")
                {
                    Response.Redirect("HomePage.aspx");
                }

                List<dynamic> carts = CartController.GetCartInformation(Logged.UserID);

                Gv_Cart.DataSource = carts;
                Gv_Cart.DataBind();
            }
        }

        protected void Btn_Edit_Click(object sender, ImageClickEventArgs e)
        {
            ImageButton Btn = (ImageButton)sender;

            GridViewRow row = (GridViewRow)Btn.NamingContainer;

            string StationeryName = row.Cells[0].Text;

            int id = StationeryController.findIDbyName(StationeryName);

            Response.Redirect("EditCartPage.aspx?Id=" + id);
        }

        protected void Btn_Delete_Click(object sender, ImageClickEventArgs e)
        {
            ImageButton Btn = (ImageButton)sender;

            GridViewRow row = (GridViewRow)Btn.NamingContainer;

            string StationeryName = row.Cells[0].Text;

            Lbl_Item.Text = StationeryName;
            Mdl_Delete.Visible = true;
        }
        protected void Btn_Confirm_Click(object sender, EventArgs e)
        {
            string name = Lbl_Item.Text;
            StationeryController.DeleteStationery(name);

            User Logged = (User)Session["UserData"];
            List<dynamic> carts = CartController.GetCartInformation(Logged.UserID);

            Gv_Cart.DataSource = carts;
            Gv_Cart.DataBind();

            Mdl_Delete.Visible = false;
        }

        protected void Btn_Cancel_Click(object sender, EventArgs e)
        {
            Mdl_Delete.Visible = false;
        }
    }
}