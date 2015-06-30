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
                
                int korting = Int32.Parse(nieuwEvent["Korting"].ToString());
                int aantalReserveringen = Int32.Parse(nieuwEvent["AantalPersonen"].ToString());
                DateTime datum = DateTime.Parse(nieuwEvent["Datum"].ToString());
                
                //convert parameters naar evenement object.
                Evenement evenement = new Evenement()
                {
                    
                    Naam = nieuwEvent["Naam"].ToString(),
                    Soort = nieuwEvent["Soort"].ToString(),
                    Datum = datum,
                    MaxAantalPersonen = aantalReserveringen,
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
            // id opzoeken van het net toegevoegde evenement (GetID();) dit is gebeurd door middel van IdLastAddedEvent = nieuwEvenement.Id;  ln 24 van evenement.cs
            // For(aantalPersonen) add een reservering per persoon de reservering krijgt een naam en een ID.
            

        }

        public string AddReservering(Dictionary<string, object> nieuweReservering)
        {
            
            int aantalReserveringen = Int32.Parse(nieuweReservering["AantalPersonen"].ToString());
            
            for (int i = 0; i < aantalReserveringen; i++)
            {
                try
                {
                    DateTime datum = DateTime.Parse(nieuweReservering["Datum"].ToString());
                    Reservering res = new Reservering()
                    {
                        Naam = nieuweReservering["Naam"].ToString(),
                        Datum = datum
                    };
                    string response = res.ReserveringPlaatsen(res); //geef evenement object door aan BU laag.
                    return response; //geslaagd of niet?
                }
                catch (Exception)
                {
                  string response = "Reservering opslaan is mislukt.";
                  return response;
                }
            }
            return null;

        }

       
    }
}