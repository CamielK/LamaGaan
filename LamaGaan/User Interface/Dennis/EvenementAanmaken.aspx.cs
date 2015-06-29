using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LamaGaan.CC;

namespace LamaGaan.User_Interface.Dennis
{
    public partial class EvenementAanmaken : System.Web.UI.Page
    {
        public string Naam;
        public string Soort;
        public string Datum;
        public string AantalPersonen;
        public string Korting;

        private LamaGaan.CC.CCEvenementMaken evenement;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            
            //CCEvenementMaken allEvenement = new CCEvenementMaken();
            //List<string> namenList = allEvenement.GetAllEvents();
            //foreach (string naam in namenList)
            //{
            //    Label1.Text += naam + "<br />";
            //}
        }

        protected void btAanmaken_Click(object sender, EventArgs e)
        {
            //Dit is verkeerd
            //evenement = new CCEvenementMaken();
            //Naam = tbName.Text;
            //Soort = ddlSoort.Text;
            //Datum = tbDatum.ToString();
            //AantalPersonen = tbAantalPersonen.Text;
            //Korting = ddlKorting.Text;
            //evenement.SetVar();
        }
    }
}