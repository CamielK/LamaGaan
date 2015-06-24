﻿using System;
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
        //public void test()
        //{
        //    this.
        //}

        public void AddPersoon()
        {
            //methode die door CC aangeroepen word om nieuwe persoon toe te voegen.
        }


        

        //test methode:
        //geeft een list met strings van alle namen van de personen in Persoon
        public List<string> GetAllPersoonNamen()
        {
            List<string> namen = new List<string>();

            using (LamaGaanModelContainer context = new LamaGaanModelContainer())
            {
                IQueryable<Persoon> naamQuery =
                    from naam in context.Persoon
                    select naam;

                foreach (Persoon naam in naamQuery)
                {
                    namen.Add(naam.Naam.ToString());
                }
            }
            return namen;
        }


        //functie geeft een dictionary met daarin alle attributen van de gegeven persoon
        public Dictionary<string, object> GetPersoonInfo(string naam)
        {
            Dictionary<string, object> persoonDict = new Dictionary<string, object>();

            using (LamaGaanModelContainer context = new LamaGaanModelContainer())
            {
                IQueryable<Persoon> naamQuery =
                    from x in context.Persoon
                    where x.Naam == naam
                    select x;

                foreach (Persoon persoon in naamQuery)
                {
                    if (persoon != null)
                    {
                        persoonDict.Add("Naam", persoon.Naam.ToString());
                        persoonDict.Add("Email", persoon.Email.ToString());
                        persoonDict.Add("Geboorte Datum", persoon.GeboorteDatum.ToString("MM-dd-yyyy"));
                        persoonDict.Add("Start Datum", persoon.Startdatum.ToString("MM-dd-yyyy"));
                    }
                }
            }

            return persoonDict;
        }


        

    }
}