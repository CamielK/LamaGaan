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

        public List<string> GetAllEvents()
        {
            List<string> events = new List<string>();
            using (LamaGaanModelContainer context = new LamaGaanModelContainer())
            {
                IQueryable<Evenement> eventQuery = from a in context.Evenement select a;
                foreach (Evenement a in eventQuery)
                {
                    events.Add(a.Naam.ToString());
                }
            }
            return events;
        }
        //public Dictionary<string,object> GetAllEvents()
        //{
        //    Dictionary<string, object> allevents = new Dictionary<string, object>();
        //    using (LamaGaanModelContainer context = new LamaGaanModelContainer())
        //    {
        //        IQueryable<Evenement> allEvenementsQ = from x in context.Evenement select x;
        //        foreach (Evenement evenement in allEvenementsQ)
        //        {
        //            allevents.Add("Naam", Naam);
        //            allevents.Add("Soort", Soort);
        //            allevents.Add("Datum", Datum);
        //            allevents.Add("AantalPersonen", AantalPersonen);
        //            allevents.Add("Korting", Korting);
        //            allevents.Add("RowEnd", "RowEnd");
        //        }
        //        return allevents;
        //    }
    }
}