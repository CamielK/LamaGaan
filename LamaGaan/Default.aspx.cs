using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LamaGaan.BU;

namespace LamaGaan
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Persoon x = new Persoon();
            List<string> namen = x.GetPersoon();

            foreach (string naam in namen)
            {
                Label1.Text += naam;
            }
        }
    }
}