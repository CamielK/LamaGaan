using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using LamaGaan.BU;


    //Op deze pagina worden de werkroosters van een vrijwilliger weergeven.
    //use case: Werkrooster bekijken
    //Auteur: Camiel Kerkhofs


namespace LamaGaan.User_Interface
{
    public partial class Werkrooster_bekijken : System.Web.UI.Page
    {
        private LamaGaan.CC.CCWerkroosterBekijken werkrooster;

        protected void Page_Load(object sender, EventArgs e)
        {
            werkrooster = new LamaGaan.CC.CCWerkroosterBekijken(); //CC aanroepen

            if (!IsPostBack)
            {
                //dropdownlist 1 vullen met alle persoon namen
                //text = Naam, value = persoon Id
                List<string>[] namen = werkrooster.GetAllPersoonNamen();
                for (int i = 0; i < namen[0].Count; i++)
                {
                    DropDownListNamen.Items.Add(new ListItem(namen[1][i], namen[0][i])); //voegt toe aan DDL: (text = naam, value = Id)
                }
            }
        }

        //werkroosters ophalen en koppelen aan gridview.
        protected void Button1_Click(object sender, EventArgs e)
        {
            GridView1.DataSource = werkrooster.DrawRooster(DropDownListNamen.SelectedItem.Text);
            GridView1.DataBind();
            werkroosterSpan.Visible = true;
        }
    }
}