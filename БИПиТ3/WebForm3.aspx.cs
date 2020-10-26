using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.Data;

namespace БИПиТ3
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        WebService1 obj = new WebService1();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e) //Удаление
        {
            for(int i=0; i < GridView1.Rows.Count;i++)
            {
                CheckBox chBox = (CheckBox)GridView1.Rows[i].FindControl("CheckBox1");
                if (chBox != null && chBox.Checked)
                {
                    int orderID = Convert.ToInt32(GridView1.Rows[i].Cells[1].Text);
                    obj.DeleteRec(orderID);
                    Page.Response.Redirect(Page.Request.Url.ToString(), true);
                }
            }
        }

        protected void Button2_Click(object sender, EventArgs e) //Фильтрация
        {
            List<string> rowsID = obj.GetData(Txt1.Text, Txt2.Text);
            if (rowsID.Count == GridView1.Rows.Count)
                Page.Response.Redirect(Page.Request.Url.ToString(), true);
            else
            {
                foreach (GridViewRow row in GridView1.Rows)
                {
                    foreach (string ID in rowsID)
                    {
                        if (row.Cells[1].Text == ID)
                            row.Visible = false;
                    }
                }
            }
        }
    }
}