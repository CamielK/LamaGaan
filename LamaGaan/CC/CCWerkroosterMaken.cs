using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using LamaGaan.BU;

namespace LamaGaan.CC
{
    public class CCWerkroosterMaken
    {
        private Persoon persoon = new Persoon();

        //geeft een list met strings van alle namen van de personen in Persoon
        public List<string> GetAllPersoonNamen()
        {
            List<string> namen = persoon.GetAllPersoonNamen();
            return namen;
        }

        //functie geeft een dictionary met daarin alle attributen van de gegeven persoon
        public Dictionary<string, object> GetPersoonInfo(string naam)
        {
            Dictionary<string, object> persoonDict = persoon.GetPersoonInfo(naam);
            return persoonDict;
        }
    }
}