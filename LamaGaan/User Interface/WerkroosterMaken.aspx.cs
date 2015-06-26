using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LamaGaan
{
    public partial class VrijwilligerToevoegen : System.Web.UI.Page
    {
        private LamaGaan.CC.CCVrijwilligersBeheren vrijwilliger;

        protected void Page_Load(object sender, EventArgs e)
        {
            vrijwilliger = new LamaGaan.CC.CCVrijwilligersBeheren();

            if (DropDownList1.Items.Count == 0)
            {
                List<string> namen = vrijwilliger.GetAllPersoonNamen();
                foreach (string naam in namen)
                {
                    DropDownList1.Items.Add(naam);
                }
            }
        }

        protected void BtZoekpersoon_Click(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedValue != "")
            {
                Label1.Text = "";
                Dictionary<string, object> persoonInfo = vrijwilliger.GetPersoonInfo(DropDownList1.SelectedValue.ToString());
                foreach (KeyValuePair<string, object> attribuut in persoonInfo)
                {
                    Label1.Text += "<br />" + attribuut.Key + ": " + attribuut.Value;
                }
            }
        }
    }
}