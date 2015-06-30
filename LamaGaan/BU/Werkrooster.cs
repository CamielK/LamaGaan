using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LamaGaan.BU
{
    partial class Werkrooster
    {

        //probeert het werkrooster object op te slaan in de database en geeft een melding of dat gelukt is. 
        //use case: werkrooster maken
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


        //functie voor het geven van een list met werkroosters die horen bij de gegeven naam 
        //use case: Werkrooster bekijken
        //auteur: Camiel Kerkhofs
        public DataTable GetWerkroosters(string persoonNaam)
        {
            DataTable roosterTabel = new DataTable();
            roosterTabel.Columns.Add("Datum");
            roosterTabel.Columns.Add("Begintijd");
            roosterTabel.Columns.Add("Eindtijd");
            roosterTabel.Columns.Add("Taak");

            using (LamaGaanModelContainer context = new LamaGaanModelContainer())
            {
                IQueryable<Werkrooster> naamQuery =
                    from rooster in context.Werkrooster
                    where rooster.Persoon.Naam == persoonNaam
                    select rooster;

                foreach (Werkrooster rooster in naamQuery)
                {
                    if (rooster != null)
                    {
                        roosterTabel.Rows.Add(
                            rooster.Datum.ToString("dd-MM-yyyy"),
                            rooster.BeginTijd.ToString(),
                            rooster.EindTijd.ToString(),
                            rooster.Taak.Omschrijving);
                    }
                }
            }
            return roosterTabel;
        }
    }
}