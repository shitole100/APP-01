using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace APP_01
{
	public partial class LOGIN : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			 
		}

		protected void Button2_Click(object sender, EventArgs e)
		{
			string username = TextBox1.Text;
			string password = TextBox2.Text;
			if(username == "swapnil" && password == "s123")
			{
				Response.Redirect("home.aspx");

			}
			else
			{
				Label3.Text = "invalied password or username";

			}
		}

		protected void TextBox1_TextChanged(object sender, EventArgs e)
		{

		}
	}
}