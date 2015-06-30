using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LamaGaan.BU;
using LamaGaan.CC;
// Auteur Dennis Kooij.
namespace LamaGaan.User_Interface
{
    public partial class Evenementen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RangeValidatorDatum.Type = ValidationDataType.Date;
            RangeValidatorDatum.MinimumValue = DateTime.Today.ToShortDateString();
            RangeValidatorDatum.MaximumValue = DateTime.Today.AddYears(10).ToShortDateString();
            
        }
        /// <summary>
        /// Door op de knop Opslaan te klikken worden de ingevulde waarden in een dictionary gezet en doorgelinkt naar CCEvenementAanmaken
        /// </summary>
        
        protected void tbOpslaan_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> eventDictionary = new Dictionary<string, object>();
            eventDictionary.Add("Naam", tbNaam.Text);
            eventDictionary.Add("Soort", ddlSoort.Text);
            eventDictionary.Add("Datum", tbDatum.Text);
            eventDictionary.Add("AantalPersonen", tbAantalPersonen.Text);
            eventDictionary.Add("Korting", tbKorting.Text);

            CCEvenementMaken Evenement = new CCEvenementMaken();
            lbResponse.Text = Evenement.AddEvent(eventDictionary);
            
            
        }
    }
}