using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Web;

namespace LamaGaan.BU
{
    partial class Persoon
    {
        //geeft persoon object dat hoort bij het meegegeven Id
        //auteur: Camiel Kerkhofs
        public static Persoon GetPersoon(int Id)
        {
            Persoon persoon = new Persoon();

            using (LamaGaanModelContainer context = new LamaGaanModelContainer())
            {
                IQueryable<Persoon> naamQuery =
                    from p in context.Persoon
                    where p.Id == Id
                    select p;

                foreach (Persoon p in naamQuery)
                {
                    if (p != null)
                    {
                        persoon = p;
                    }
                }
            }
            return persoon;
        }


        //geeft een list met strings van alle namen van de personen in Persoon en hun bijbehorende persoon Id
        //auteur: Camiel Kerkhofs
        public List<string>[] GetAllPersoonNamen()
        {
            List<string>[] namen = new List<string>[2];
            namen[0] = new List<string>();//eerste list vullen met persoon ID
            namen[1] = new List<string>();//tweede list vullen met persoon naam

            using (LamaGaanModelContainer context = new LamaGaanModelContainer())
            {
                IQueryable<Persoon> naamQuery =
                    from naam in context.Persoon
                    select naam;

                foreach (Persoon naam in naamQuery)
                {
                    if (naam != null)
                    {
                        namen[0].Add(naam.Id.ToString());
                        namen[1].Add(naam.Naam.ToString());
                    }
                }
            }
            return namen;
        }

    }
}