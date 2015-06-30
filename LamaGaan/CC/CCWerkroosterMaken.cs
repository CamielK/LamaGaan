using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Web;
using LamaGaan.BU;

    //---------
    //Deze CC behoort tot de use case 'Werkrooster Maken'.
    //BU klassen (entiteiten) die hierbij betrokken zijn zijn: Persoon (lezen namen), Taak(lezen taken), Werkrooster(schrijven nieuw werkrooster)
    //auteur: Camiel Kerkhofs
    //---------

namespace LamaGaan.CC
{
    public class CCWerkroosterMaken
    {
        private Persoon persoon = new Persoon(); //entiteit Persoon aanroepen (lezen van personen en Id)
        private Taak taak = new Taak(); //entiteit Taak aanroepen (lezen van taken en Id)
        private Werkrooster rooster = new Werkrooster(); //entiteit Werkrooster aanroepen (Schrijven nieuw rooster)


        //roept functie aan uit BU 'Persoon'. geeft een list met strings van alle namen van de personen in Persoon en hun bijbehorende Id
        //auteur: Camiel Kerkhofs
        public List<string>[] GetAllPersoonNamen()
        {
            List<string>[] namen = persoon.GetAllPersoonNamen(); //proxy pattern
            return namen;
        }


        //roept functie aan uit BU 'Taak'. geeft een list met strings van alle taak omschrijvingen en hun bijbehorende taak Id
        //auteur: Camiel Kerkhofs
        public List<string>[] GetAllTaakOmschrijvingen()
        {
            List<string>[] taken = taak.GetAllTaakOmschrijvingen(); //proxy pattern
            return taken;
        }


        //converteerd werkrooster dictionary naar een werkrooster object. object word doorgegeven aan BU laag.
        //auteur: Camiel Kerkhofs
        public string AddWerkrooster(Dictionary<string, object> nieuwWerkrooster) 
        {
            try
            {
                //convert dictionary naar Werkrooster parameters
                DateTime datum = DateTime.Parse(nieuwWerkrooster["Datum"].ToString());
                TimeSpan begintime = TimeSpan.Parse(nieuwWerkrooster["Begintijd"].ToString());
                TimeSpan eindtime = TimeSpan.Parse(nieuwWerkrooster["Eindtijd"].ToString());
                int persoonId = Int32.Parse(nieuwWerkrooster["Persoon"].ToString());
                int taakId = Int32.Parse(nieuwWerkrooster["Taak"].ToString());

                //convert parameters naar werkrooster object.
                Werkrooster werkrooster = new Werkrooster
                {
                    Datum = datum,
                    EindTijd = eindtime,
                    BeginTijd = begintime,
                    Persoon = Persoon.GetPersoon(persoonId),
                    Taak = Taak.GetTaak(taakId)
                };

                string response = rooster.AddWerkrooster(werkrooster); //geef werkrooster object door aan BU laag.
                return response; //geslaagd of niet?
            }
            catch (Exception)
            {
                string response = "Werkrooster opslaan is mislukt.";
                return response;
            }
            


            
        }
    }
}