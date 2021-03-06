using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityProje
{
    public partial class YetenekGuncelle : System.Web.UI.Page
    {
        DBCVENTITYEntities db = new DBCVENTITYEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

            int x = Convert.ToInt32(Request.QueryString["ID"]);
            if (Page.IsPostBack == false)
            {
                var deger = db.TBLYETENEKLER.Find(x);
                TextBox1.Text = deger.YETENEK;
                TextBox2.Text = deger.DERECE.ToString();

            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["ID"]);
            var deger = db.TBLYETENEKLER.Find(x);
            deger.YETENEK = TextBox1.Text;
            deger.DERECE = byte.Parse(TextBox2.Text);
            db.SaveChanges();
            Response.Redirect("Yeteneklerim.aspx");
        }
    }
}