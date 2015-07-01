using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LamaGaan.BU;
using LamaGaan.CC;
//auteur: Mischa Rouleaux
namespace LamaGaan.User_Interface
{
    public partial class Kassa : System.Web.UI.Page
    {
        private LamaGaan.CC.CCKassa kassa;

        protected void RekenAf_OnClick(object sender, EventArgs e)
        {
            Dictionary<string, object> nieuwKassa = new Dictionary<string, object>();

            nieuwKassa.Add("Entree", HoeveelheidPersoon.Text);
            nieuwKassa.Add("Fanta", HoeveelheidFanta.Text);
            nieuwKassa.Add("Cola", HoeveelheidCola.Text);
            nieuwKassa.Add("Koffie", HoeveelheidKoffie.Text);
            nieuwKassa.Add("Thee", HoeveelheidThee.Text);
            nieuwKassa.Add("Ijs", HoeveelheidIjsje.Text);
            nieuwKassa.Add("Sleutelhanger", HoeveelheidSleutelhangers.Text);
            nieuwKassa.Add("T-shirt", HoeveelheidTshirts.Text);
            nieuwKassa.Add("Pet", HoeveelheidPetjes.Text);
            nieuwKassa.Add("Pluche Lama", Hoeveelheidlamas.Text);



            string response = kassa.ChangeKassa(nieuwKassa);


        }
    }
}