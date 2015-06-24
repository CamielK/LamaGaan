using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using LamaGaan.BU;

namespace LamaGaan.CC
{
    public class CCVrijwilligersBeheren
    {
        private Persoon nieuwePersoon = new Persoon();



        //geeft een list met strings van alle namen van de personen in Persoon
        public List<string> GetAllPersoonNamen()
        {
            List<string> namen = new Persoon().GetAllPersoonNamen();
            return namen;
        }


        //functie geeft een dictionary met daarin alle attributen van de gegeven persoon
        public Dictionary<string, object> GetPersoonInfo(string naam)
        {
            Dictionary<string, object> persoonDict = new Dictionary<string, object>();

            using (LamaGaanModelContainer context = new LamaGaanModelContainer())
            {
                IQueryable<Persoon> naamQuery =
                    from x in context.Persoon
                    where x.Naam == naam
                    select x;

                foreach (Persoon persoon in naamQuery)
                {
                    if (persoon != null)
                    {
                        persoonDict.Add("Naam", persoon.Naam.ToString());
                        persoonDict.Add("Email", persoon.Email.ToString());
                        persoonDict.Add("Geboorte Datum", persoon.GeboorteDatum.ToString("MM-dd-yyyy"));
                        persoonDict.Add("Start Datum", persoon.Startdatum.ToString("MM-dd-yyyy"));
                    }
                }
            }

            return persoonDict;
        }
    }
}