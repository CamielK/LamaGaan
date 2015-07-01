using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LamaGaan.BU;

    //---------
    //Deze CC behoort tot de use case 'Kassa bedienen'.
    //BU klassen (entiteiten) die hierbij betrokken zijn zijn: Product (HuidigeVoorraad, VerkoopOrder(toevoegen) en Reservering (toevoegen)
    //auteur: Mischa Rouleaux
    //---------

namespace LamaGaan.CC
{
    public class CCKassa
    {
        private Product product = new Product

        public List<Int32>[] GetHoeveelheidProduct()
        {
            List<Int32>[] producten = product.GetHoeveelheidProduct();
            return producten;
        }



        public string ChangeKassa(Dictionary<string, object> nieuwKassa)
        {
            int HuidigeVoorraad = Int32.Parse(nieuwKassa["//......"].ToString());
            
        }
    }
}