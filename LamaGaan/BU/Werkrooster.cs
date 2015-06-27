using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LamaGaan.BU
{
    partial class Werkrooster
    {

        //probeert het werkrooster object op te slaan in de database en geeft een melding of dat gelukt is.
        //auteur: Camiel Kerkhofs
        public string AddWerkrooster(Werkrooster nieuwWerkrooster)
        {
            string response = "Werkrooster niet kunnen toevoegen";


            using (LamaGaanModelContainer context = new LamaGaanModelContainer())
            {
                context.Entry(nieuwWerkrooster).State = EntityState.Modified;
                context.Werkrooster.Add(nieuwWerkrooster);

                try
                {
                    context.SaveChanges();
                    response = "Werkrooster succesvol toegevoegd";
                }
                catch (Exception)
                {
                    response = "Saving changes to database failed";
                }
            }

            return response;
        }
    }
}