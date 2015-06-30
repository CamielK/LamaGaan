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
        
        /// <summary>
        /// Voegt een nieuw evenement toe aan de database.
        /// </summary>
        /// <param name="nieuwEvenement"> dictionary van de toegevoegde data, doorgezet vanuit de CC laag.</param>
        /// <returns>returned een list waarbij index 0 een string is waarin staat of het event aanmaken is gelukt of niet en index 1 het laatst toegevoegde id.</returns>
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

        /// <summary>
        /// Returned het laatste toegevoegde evenement object
        /// </summary>
        /// <param name="Id"> is de waarde van de response[1] list in de bovenstaande functie</param>
        /// <returns>het laatst aangemaakte object</returns>
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
        



    }
}
