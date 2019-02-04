using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class Index : System.Web.UI.Page
    {
        DataTable dt = new DataTable();
        WebApplication2.DataAccessLayer.DataAccessLayer dal = new WebApplication2.DataAccessLayer.DataAccessLayer();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void on_Submit(object sender, EventArgs e)
        {

            String str = dal.Submit(txtFruitId.Text);
            lblFruitName.Text = str;
        }
    }
}