using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaDatos;

namespace SitiosWeb
{
	public partial class signUp : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void Button1_Click(object sender, EventArgs e)
		{
			Class1 c = new Class1();
			c.retrr(txtUser.Text,txtPass.Text);
		}
	}
}