using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Oblig4
{
    public partial class _Default : Page
    {

        MinDatabaseEntities db = new MinDatabaseEntities();

        protected void Page_Load(object sender, EventArgs e)
        {



            //Kan tidligest Booke i dag
            CheckInValidator.MinimumValue = DateTime.Now.ToString("yyyy-MM-dd");
          
      
            //Tidligeste du kan sjekke ut er dagen etter i dag
            CheckOutValidator.MinimumValue = DateTime.Now.AddDays(1).ToString("yyyy-MM-dd");
            var rooms = db.Room.OrderBy(r => r.roomnumber).ToList();
            GridView1.DataSource = db.Room.Local;
            GridView1.DataBind();

            
        }

        protected void fraDatoTekstBox_TextChanged(object sender, EventArgs e)
        {
            Validate();
        }

        protected void tilDatoTekstBox_TextChanged(object sender, EventArgs e)
        {
            Validate();
        }

        protected void SearchButton_Click(object sender, EventArgs e)
        {

        }

        protected void BookRoomButton_Click(object sender, EventArgs e)
        {

        }
    }
}