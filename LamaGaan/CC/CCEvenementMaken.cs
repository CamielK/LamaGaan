using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LamaGaan.BU;

namespace LamaGaan.CC
{
    public class CCEvenementMaken
    {
        public string AddEvent(Dictionary<string, object> nieuwEvent)
        {
            try
            {
                //convert dictionary naar Evenement parameters
                DateTime datum = DateTime.Parse(nieuwEvent["Datum"].ToString());
                int aantalPersonen = Int32.Parse(nieuwEvent["AantalPersonen"].ToString());
                int korting = Int32.Parse(nieuwEvent["Korting"].ToString());

                

                //convert parameters naar evenement object.
                Evenement evenement = new Evenement()
                {
                    Naam = nieuwEvent["Naam"].ToString(),
                    Soort = nieuwEvent["Soort"].ToString(),
                    Datum = datum,
                    MaxAantalPersonen = aantalPersonen,
                    Korting = korting
                };

                string response = evenement.AddEvent(evenement); //geef evenement object door aan BU laag.
                return response; //geslaagd of niet?
            }
            catch (Exception)
            {
                string response = "Evenement opslaan is mislukt.";
                return response;
            }
            // id opzoeken van het net toegevoegde evenement (GetID();)
            // For(aantalPersonen) add een reservering per persoon de reservering krijgt een naam en een ID.
        }

       
    }
}