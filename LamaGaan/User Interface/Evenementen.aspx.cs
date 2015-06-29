using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LamaGaan.BU;
using LamaGaan.CC;

namespace LamaGaan.User_Interface
{
    public partial class Evenementen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CCEvenementMaken allEvenement = new CCEvenementMaken();
            List<string> namenList = allEvenement.GetAllEvents();
            foreach(string naam in namenList)
            {
                Label1.Text += naam + "<br />";
            }
        }
    }
}