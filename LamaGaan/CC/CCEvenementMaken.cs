using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LamaGaan.BU;

namespace LamaGaan.CC
{
    public class CCEvenementMaken
    {
        public List<string> GetAllEvents()
        {
            Evenement allEvenement = new Evenement();
            List<string> namenList = allEvenement.GetAllEvents();
        } 
    }
}