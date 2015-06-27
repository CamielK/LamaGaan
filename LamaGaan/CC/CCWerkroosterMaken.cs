using System;
using System.Collections.Generic;
using System.Linq;
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
        private Persoon persoon = new Persoon(); //entiteit Persoon aanroepen (lezen van taken en Id)
        private Taak taak = new Taak(); //entiteit Taak aanroepen (lezen van taken en Id)
        private Werkrooster rooster = new Werkrooster(); //entiteit Werkrooster aanroepen (Schrijven nieuw rooster)


        //roept functie aan uit BU 'Persoon'. geeft een list met strings van alle namen van de personen in Persoon en hun bijbehorende Id
        public List<string>[] GetAllPersoonNamen()
        {
            List<string>[] namen = persoon.GetAllPersoonNamen(); //proxy pattern
            return namen;
        }


        //roept functie aan uit BU 'Taak'. geeft een list met strings van alle taak omschrijvingen en hun bijbehorende taak Id
        public List<string>[] GetAllTaakOmschrijvingen()
        {
            List<string>[] taken = taak.GetAllTaakOmschrijvingen(); //proxy pattern
            return taken;
        }


        //roept functie aan uit BU 'Werkrooster'. voegt nieuw werkrooster toe.
        public string AddWerkrooster()
        {
            string response = rooster.AddWerkrooster();
            return response;
        }
    }
}