using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;

namespace Oblig4
{
    public partial class Login : System.Web.UI.Page
    {
        public MinDatabaseEntities context = new MinDatabaseEntities();


        protected void Page_Load(object sender, EventArgs e)
        {

        }


        /**
        Checks if user exists in the database
        @params username and password to check
        @return true or false
        **/
        protected Boolean UserExsist(String username, String password)
        {

            List<Users> users = context.Users.ToList();

            var query = users.Find(user => user.username.Equals(username) && user.password.Equals(password));

            if (query == null)
            {
                return false;

            }
            else
            {
                return true;

            }

        }


        /**
        Button click event handler
        if the regex is valid and the user exsist in the database then redirect
        else show error message
        **/

        protected void Button1_Click(object sender, EventArgs e)
        {
            String username = brukernavnTekstBox.Text;
            String password = passordTekstBox.Text;



            if (IsValid && UserExsist(username, password))
            {
                Response.Redirect("~/Default.aspx");
            }
            else
            {
                errorMessage.Visible = true;
            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            Validate();
        }

        protected void passordTekstBox_TextChanged(object sender, EventArgs e)
        {
            Validate();
        }
    }
}