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
        private LamaGaan.CC.VrijwilligerToevoegen cc;

        protected void Page_Load(object sender, EventArgs e)
        {
            cc = new LamaGaan.CC.VrijwilligerToevoegen();
        }


        //input uit tekstvelden opslaan in een dictionary
        //dictionary vullen met persoon attrbituren. naam, geboortedatum, adres etc.
        protected void BtOpslaan_Click(object sender, EventArgs e)
        {
            Dictionary<String, object> persoon = new Dictionary<string, object>();
            persoon.Add("Naam", TbNaam.Text);
            //add geboortedatum, adress etc.

            cc.FillPersonDictionary(persoon);
        }
    }
}