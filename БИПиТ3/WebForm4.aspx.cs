using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace БИПиТ3
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ScriptManager.ScriptResourceMapping.AddDefinition("jquery", new ScriptResourceDefinition
            {
                Path = "~/Content/Js/jquery-3.2.1.min.js",
            });
        }
        WebService1 obj = new WebService1();
        protected void Button1_Click(object sender, EventArgs e) //Добавление
        {
            if (Page.IsValid)
            {
                obj.NewRec(Convert.ToInt32(DropDownList1.SelectedValue), Convert.ToInt32(DropDownList2.SelectedValue), Convert.ToInt32(TextBox1.Text), Convert.ToDateTime(Txt1.Text));
                Page.Response.Redirect("WebForm3.aspx", true);
            }
        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            try
            {
                args.IsValid = Convert.ToDouble(TextBox1.Text) > 0;
            }

            catch
            {
                args.IsValid = false;
            }
        }
    }
}