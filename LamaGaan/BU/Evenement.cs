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
        public int IdLastAddedEvent;
        
        public List<string> AddEvent(Evenement nieuwEvenement)
        {
            List<string> response = new List<string>();
            response.Add("response text");
            response.Add("Event Id");
            
            using (LamaGaanModelContainer db = new LamaGaanModelContainer())
            {
                db.Entry(nieuwEvenement).State = EntityState.Modified;
                db.Evenement.Add(nieuwEvenement);
                try
                {
                    db.SaveChanges();
                    response[1] =  nieuwEvenement.Id.ToString(); // id van pas toegevoegd evenement
                    response[0] = "Evenement toevoegen was succesvol.";
                    
                }
                catch (Exception)
                {
                    response[0] = "Evenement toevoegen mislukt.";
                }
            }
            return response;
            
            
        }


        public Evenement GetEvent(int Id)
        {
             Evenement evenement = new Evenement();

            using (LamaGaanModelContainer context = new LamaGaanModelContainer())
            {
                IQueryable<Evenement> naamQuery =
                    from p in context.Evenement
                    where p.Id == Id
                    select p;

                foreach (Evenement p in naamQuery)
                {
                    if (p != null)
                    {
                        evenement = p;
                    }
                }
            }
            return evenement;
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
