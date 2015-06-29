using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;

namespace LamaGaan.BU
{
    partial class Evenement
    {

        public string AddEvent(Evenement nieuwEvenement)
        {
            string response = "Evenement niet kunnen toevoegen";

            using (LamaGaanModelContainer db = new LamaGaanModelContainer())
            {
                db.Entry(nieuwEvenement).State = EntityState.Modified;
                db.Evenement.Add(nieuwEvenement);
                try
                {
                    db.SaveChanges();
                    response = "Evenement toegevoegd.";
                }
                catch (Exception)
                {
                    response = "Evenement toevoegen mislukt.";
                }
            }
            return response;
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
