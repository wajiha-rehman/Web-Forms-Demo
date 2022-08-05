using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormsDemo
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnClick_Submit(object sender, EventArgs e)
        {
            string message = string.Format("Your name is {0}.\nYou are {1} years old.\nYour email is {2}.\nYour favorite color is {3}.", txtName.Text,
                txtAge.Text, txtEmail.Text, ddlColor.SelectedValue);
            ltlMessage.Text = message;
        }
    }
}