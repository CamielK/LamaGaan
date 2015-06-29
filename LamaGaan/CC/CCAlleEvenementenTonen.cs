using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using LamaGaan.BU;

namespace LamaGaan.CC
{
    public class CCAlleEvenementenTonen
    {
        Evenement evenement = new Evenement();
        public Dictionary<string, object> GetEvents()
        {
            Dictionary<string, object> eventDictionary = evenement.GetDictionary();
            return eventDictionary;
        }
    }
}