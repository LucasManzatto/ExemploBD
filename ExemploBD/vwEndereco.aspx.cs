using ExemploBD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExemploBD
{
    public partial class vwEndereco : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["cliente"] != null)
            {
                Cliente c = Session["cliente"] as Cliente;
                lblCliente.Text = "Id: " + c.Id + " Nome: " + c.Nome;
            }
           
        }
    }
}