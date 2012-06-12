using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class _Default : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnTesteVerificar_Click(object sender, EventArgs e)
        {
            modeloPotz potz = new modeloPotz();
            
            lblResultado.Text=Equals(potz.teste("500123456-8"), 500).ToString();            
        }

    }
}