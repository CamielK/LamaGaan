using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Web;
using Microsoft.Ajax.Utilities;

namespace LamaGaan.BU
{
    partial class Persoon
    {
        //public void test()
        //{
        //    this.
        //}

        public void AddPersoon()
        {
            //methode die door CC aangeroepen word om nieuwe persoon toe te voegen.
        }


        

        //test methode:
        public List<string> GetPersoon()
        {
            List<string> namen = new List<string>();

            using (LamaGaanModelContainer context = new LamaGaanModelContainer())
            {
                //IQueryable<Persoon> persoon = context.Persoon;
                //int[] persoon = new int[7] { 0, 1, 2, 3, 4, 5, 6 };

                IQueryable<Persoon> naamQuery =
                    from naam in context.Persoon
                    where naam.Id > 0
                    select naam;

                foreach (Persoon naam in naamQuery)
                {
                    namen.Add(naam.Naam.ToString());   
                }
            }

            return namen;
        }




        

    }
}