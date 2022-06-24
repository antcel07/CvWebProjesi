using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityProje
{
    public partial class MesajDetay : System.Web.UI.Page
    {
        DBCVENTITYEntities db = new DBCVENTITYEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["ID"]);
            var mesaj = db.TBLILETISIM.Find(x);
            TextBox1.Text = mesaj.ADSOYAD;
            TextBox2.Text = mesaj.MAIL;
            TextBox3.Text = mesaj.KONU;
            TextBox4.Text = mesaj.MESAJ;

        }
    }
}