using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LamaGaan.BU
{
    partial class Werkrooster
    {
        //public void test()
        //{
        //    this.
        //}

        public string AddWerkrooster()//Dictionary<string, object> rooster
        {
            string response;

            //add rooster to database
            string datum2 = "03-02-2015";
            TimeSpan begintime = TimeSpan.Parse("12:00");
            TimeSpan eindtime = TimeSpan.Parse("14:00");
            int persoonId = 1;
            int taakId = 2;

            

            using (LamaGaanModelContainer context = new LamaGaanModelContainer())
            {
                //convert dictionary to Werkrooster object
                Werkrooster werkrooster = new Werkrooster
                {
                    Datum = DateTime.ParseExact(datum2, "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture),
                    EindTijd = eindtime,
                    BeginTijd = begintime,
                    Persoon = Persoon.GetPersoon(persoonId),
                    Taak = Taak.GetTaak(taakId)
                };

                context.Entry(werkrooster).State = EntityState.Modified;
                context.Werkrooster.Add(werkrooster);

                try
                {
                    context.SaveChanges();
                    response = "Succesfully added werkrooster";
                }
                catch (Exception)
                {
                    response = "Could not add werkrooster";
                }
            }

            return response;
        }
    }
}