using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;

namespace LamaGaan.BU
{
    partial class Evenement
    {
        public Dictionary<string, object> GetDateEvents(string date)
        {
            Dictionary<string, object> eventDictionary = new Dictionary<string, object>();

            using (LamaGaanModelContainer context = new LamaGaanModelContainer())
            {
                IQueryable<Evenement> chooseEvenements 
                    = from x in context.Evenement 
                      where x.Datum.ToString("MM-dd-yyyy") == date 
                      select x;
                foreach (Evenement evenement in chooseEvenements)
                {
                    if (evenement != null)
                    {
                        eventDictionary.Add("Naam", Naam);
                        eventDictionary.Add("Soort", Soort);
                        eventDictionary.Add("Datum", Datum);
                        eventDictionary.Add("AantalPersonen", AantalPersonen);
                        eventDictionary.Add("Korting", Korting);
                    }
                   
                }
            }
            return eventDictionary;
        }

        public Dictionary<string,object>[] GetAllEvents()
        {
            Dictionary<string, object>[] allevents = new Dictionary<string, object>[];
            using (LamaGaanModelContainer context = new LamaGaanModelContainer())
            {
                IQueryable<Evenement> allEvenements = from x in context.Evenement select x;
                foreach (Evenement evenement in allEvenements)
                {

                    
                }
            }
        }
    }
}