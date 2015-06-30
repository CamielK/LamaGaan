using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LamaGaan.BU
{
    partial class Reservering
    {

          public string ReserveringPlaatsen(Reservering nieuweReservering)
        {
            string response = "Evenement niet kunnen toevoegen";

            using (LamaGaanModelContainer db = new LamaGaanModelContainer())
            {
                db.Entry(nieuweReservering).State = EntityState.Modified;
                db.Reservering.Add(nieuweReservering);
                try
                {
                    db.SaveChanges();
                    response = "Evenement toevoegen was succesvol.";
                }
                catch (Exception)
                {
                    response = "Evenement toevoegen mislukt.";
                }
            }
            return response;
        }
    }
}