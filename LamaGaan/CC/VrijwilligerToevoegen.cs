using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using LamaGaan.BU;

namespace LamaGaan.CC
{
    public class VrijwilligerToevoegen
    {
        private Persoon nieuwePersoon = new Persoon();

        public VrijwilligerToevoegen()
        {
            //roep BU methodes aan om de informatie uit de gevulde dictionary met persoonsgegevens op te slaan in de database.


            //nieuwePersoon.Naam = 
        }




        //dictionary maken waar de UI pagina de informatie in kan opslaan.
        public void FillPersonDictionary(Dictionary<string, object> dictionary)
        {
            Type t = nieuwePersoon.GetType();
            PropertyInfo[] props = t.GetProperties();
            foreach (PropertyInfo prp in props)
            {
                if (dictionary[prp.Name] != null)
                {
                    prp.SetValue(nieuwePersoon, Convert.ChangeType(dictionary[prp.Name], prp.PropertyType), null);
                }
            }
        }
    }
}