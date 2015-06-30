using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LamaGaan.BU
{
    partial class Reservering
    {
        /// <summary>
        /// plaatst een reservering in de database obv de verkregen waarde van bij het aanmaken van een evenement
        /// </summary>
        /// <param name="nieuweReservering">dictionary van de omgezette dictionary in de CC laag, die de waarde uit de UI heeft gehaald</param>
        /// <returns>geeft een string terug om aan te geven of de reservering gemaakt is in de database.</returns>
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