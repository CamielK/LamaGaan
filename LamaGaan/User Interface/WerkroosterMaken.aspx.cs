using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LamaGaan.BU;


    //Deze pagina is onderdeel van use case 'Werkrooster maken' en vormt de UI voor het aanmaken van een werkrooster.
    //De CC die bij deze pagina hoort is te vinden in de map CC met als naam 'CCWerkroosterMaken.cs'
    //Auteur: Camiel Kerkhofs


namespace LamaGaan.User_Interface
{
    public partial class WerkroosterMaken : System.Web.UI.Page
    {
        private LamaGaan.CC.CCWerkroosterMaken werkrooster;

        protected void Page_Load(object sender, EventArgs e)
        {
            werkrooster = new LamaGaan.CC.CCWerkroosterMaken(); //CC aanroepen

            if (!IsPostBack)
            {
                RangeValidatorDatum.MinimumValue = DateTime.Today.ToShortDateString();
                RangeValidatorDatum.MaximumValue = DateTime.Today.AddYears(10).ToShortDateString();

                //dropdownlist 1 vullen met alle persoon namen
                //text = Naam, value = persoon Id
                List<string>[] namen = werkrooster.GetAllPersoonNamen();
                for (int i = 0; i < namen[0].Count; i++)
                {
                    DropDownListNamen.Items.Add(new ListItem(namen[1][i], namen[0][i])); //voegt toe aan DDL: (text = naam, value = Id)
                }


                //dropdownlist 2 vullen met alle taken
                //value = taak omschrijving Id, text = Taak
                List<string>[] taken = werkrooster.GetAllTaakOmschrijvingen();
                for (int i = 0; i < taken[0].Count; i++)
                {
                    DropDownListTaken.Items.Add(new ListItem(taken[1][i], taken[0][i])); //voegt toe aan DDL: (text = naam, value = Id)
                } 
            }
        }

        //dictionary vullen met formulier gegevens. +dictionary doorgeven aan CC laag
        protected void BtAanmaken_Click(object sender, EventArgs e)
        {
            //dictionary vullen met: - persoonId, Datum, begin tijd, eind tijd en taakId
            Dictionary<string, object> nieuwWerkrooster = new Dictionary<string, object>();

            nieuwWerkrooster.Add("Datum", TbDatum.Text);
            nieuwWerkrooster.Add("Persoon", DropDownListNamen.SelectedValue.ToString());
            nieuwWerkrooster.Add("Taak", DropDownListTaken.SelectedValue.ToString());
            nieuwWerkrooster.Add("Begintijd", TbBegintijd.Text);
            nieuwWerkrooster.Add("Eindtijd", TbEindtijd.Text);

            //geef dictionary mee aan CC methode 'AddWerkrooster'
            string response = werkrooster.AddWerkrooster(nieuwWerkrooster);

            //melding: toevoegen succesvol
            Label1.Text = response;
        }
    }
}