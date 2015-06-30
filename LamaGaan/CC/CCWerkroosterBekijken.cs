using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using LamaGaan.BU;

    //---------
    //Deze CC behoort tot de use case 'Werkrooster bekijken'.
    //BU klassen (entiteiten) die hierbij betrokken zijn zijn: Persoon (lezen namen) en Werkrooster(ophalen werkroosters)
    //auteur: Camiel Kerkhofs
    //---------

namespace LamaGaan.CC
{
    public class CCWerkroosterBekijken
    {
        private Persoon persoon = new Persoon(); //entiteit Persoon aanroepen (lezen van personen en Id)
        private Werkrooster rooster = new Werkrooster(); //entiteit Werkrooster aanroepen (ophalen werkroosters)


        //roept functie aan uit BU 'Persoon'. geeft een list met strings van alle namen van de personen in Persoon en hun bijbehorende Id
        //auteur: Camiel Kerkhofs
        public List<string>[] GetAllPersoonNamen()
        {
            List<string>[] namen = persoon.GetAllPersoonNamen(); //proxy pattern
            return namen;
        }


        //roept functie aan uit BU "Werkrooster". geeft een datatable met alle roosters van de gegeven persoon (naam)
        //auteur: Camiel Kerkhofs
        public DataTable DrawRooster(string naam)
        {
            DataTable roosterTabel = rooster.GetWerkroosters(naam);//proxy pattern
            return roosterTabel;
        }

    }
}