using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ConsultaBDIvanEliasLinQ
{
    public partial class ConsultaBD : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PruebaDataContext db = new PruebaDataContext();
            GrillaUsuarios.DataSource = db.usuarios;
            GrillaUsuarios.DataBind();
        }
    }
}