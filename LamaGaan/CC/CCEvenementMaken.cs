using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LamaGaan.BU;

namespace LamaGaan.CC
{
    //---------
    //Deze CC behoort tot de use case 'Evenement Maken'.
    //BU klassen (entiteiten) die hierbij betrokken zijn zijn: Evenement (lezen id en aanmaken evenement in de db), Reservering(Reservering maken in db)
    //auteur: Dennis Kooij
    //---------
    public class CCEvenementMaken
    {
        /// <summary>
        /// Deze functie maakt een evenement aan in de database door de BU Evenement aan te roepen en vervolgens wordt in de db tabel reservering een n aantal reserveringen aangemaakt op basis van het aantal ingevuld personen
        /// </summary>
        /// <param name="nieuwEvent"> is een dictionary van de ingevulde data op de pagina</param>
        /// <returns></returns>
        public string AddEvent(Dictionary<string, object> nieuwEvent)
        {
            //convert dictionary naar Evenement parameters
                
            int korting = Int32.Parse(nieuwEvent["Korting"].ToString());
            int aantalReserveringen = Int32.Parse(nieuwEvent["AantalPersonen"].ToString());
            DateTime datum = DateTime.Parse(nieuwEvent["Datum"].ToString());
                
            Evenement evenement = new Evenement()
            {
                Naam = nieuwEvent["Naam"].ToString(),
                Soort = nieuwEvent["Soort"].ToString(),
                Datum = datum,
                MaxAantalPersonen = aantalReserveringen,
                Korting = korting
            };

            List<string> response = evenement.AddEvent(evenement); // evenement toevoegen aan database

            for (int i = 0; i < aantalReserveringen; i++) // x aantal reserveringen inplannen zodat de dierentuin gereserveerd word
            {
                Evenement ev = new Evenement();

                Reservering res = new Reservering()
                {
                    Naam = nieuwEvent["Naam"].ToString(),
                    Datum = datum,
                    Evenement = ev.GetEvent(Int32.Parse(response[1]))
                };

                response[0] = res.ReserveringPlaatsen(res); //reserveringen opslaan in database
            }
            return response[0]; // Zijn er problemen?
        }

       
    }
}