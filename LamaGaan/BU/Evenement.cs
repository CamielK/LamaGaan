using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.UI.WebControls;

namespace LamaGaan.BU
{
    partial class Evenement
    {
        public Dictionary<string, object> GetDictionary()
        {

            Dictionary<string, object> eventDictionary = new Dictionary<string, object>();
            

            using (LamaGaanModelContainer db = new LamaGaanModelContainer())
            {
                IQueryable<Evenement> eventQueryable = from a in db.Evenement select a;
                

                foreach (Evenement a in eventQueryable)
                {
                    if (!eventDictionary.ContainsKey("Id"))
                    {
                        
                        eventDictionary.Add("Id", Id.ToString());
                        eventDictionary.Add("Naam", Naam);
                        eventDictionary.Add("Soort", Soort);
                        eventDictionary.Add("Datum", Datum.ToString("MM-dd-yyyy"));
                        eventDictionary.Add("AantalPersonen", AantalPersonen.ToString());
                        eventDictionary.Add("Korting", Korting);
                    }
                    else
                    {
                        eventDictionary["Id"] = new Dictionary<string, object>();
                    }
                }
            }
            return eventDictionary;
        }
        //Hier nog een textbox met datums bij toevoegen, een knop waarbij de cc wordt aangeroepen en via de cc deze functie aanroepen. Dan af.
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

        //public List<string> GetAllEvents()
        //{
        //    List<string> events = new List<string>();
        //    using (LamaGaanModelContainer context = new LamaGaanModelContainer())
        //    {
        //        IQueryable<Evenement> eventQuery = from a in context.Evenement select a;
        //        foreach (Evenement a in eventQuery)
        //        {
        //            events.Add(a.Naam.ToString());
        //        }
        //    }
        //    return events;
        //}


        





    }
}