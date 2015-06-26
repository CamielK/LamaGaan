using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


//Deze pagina is onderdeel van use case 'Werkrooster maken' en vormt de UI voor het aanmaken van een werkrooster.
//De CC die bij deze pagina hoort is te vinden in de map CC met als naam 'CCWerkroosterMaken.cs'
//Auteur: Camiel Kerkhofs


namespace LamaGaan.User_Interface
{
    public partial class WerkroosterMaken : System.Web.UI.Page
    {
        private LamaGaan.CC.CCWerkroosterMaken vrijwilliger;

        protected void Page_Load(object sender, EventArgs e)
        {
            vrijwilliger = new LamaGaan.CC.CCWerkroosterMaken(); //CC aanroepen

            //dropdownlist vullen met alle persoon namen
            if (DropDownList1.Items.Count == 0)
            {
                List<string> namen = vrijwilliger.GetAllPersoonNamen();
                foreach (string naam in namen)
                {
                    DropDownList1.Items.Add(naam);
                }
            }
        }


        //informatie van de geslecteerde persoon ophalen en weergeven 
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