using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LamaGaan.BU
{
    partial class Taak
    {

        //geeft een list met strings van alle taak omschrijvingen in Taak en hun bijbehorende taak Id
        //auteur: Camiel Kerkhofs
        public List<string>[] GetAllTaakOmschrijvingen()
        {
            List<string>[] taken = new List<string>[2];
            taken[0] = new List<string>();//eerste list vullen met taak ID
            taken[1] = new List<string>();//tweede list vullen met taak omschrijving

            using (LamaGaanModelContainer context = new LamaGaanModelContainer())
            {
                IQueryable<Taak> taakQuery =
                    from taak in context.Taak
                    select taak;

                foreach (Taak taak in taakQuery)
                {
                    if (taak != null)
                    {
                        taken[0].Add(taak.Id.ToString());
                        taken[1].Add(taak.Omschrijving.ToString());
                    }
                }
            }
            return taken;
        }


        //geeft taak object dat hoort bij het gegeven Id
        //auteur: Camiel Kerkhofs
        public static Taak GetTaak(int Id)
        {
            Taak taak = new Taak();

            using (LamaGaanModelContainer context = new LamaGaanModelContainer())
            {
                IQueryable<Taak> naamQuery =
                    from t in context.Taak
                    where t.Id == Id
                    select t;

                foreach (Taak t in naamQuery)
                {
                    if (t != null)
                    {
                        taak = t;
                    }
                }
            }
            return taak;
        }
    }
}