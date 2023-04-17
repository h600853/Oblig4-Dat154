using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Oblig4
{
    public partial class _Default : Page
    {

        MinDatabaseEntities db = new MinDatabaseEntities();
        String PriceRange1 = "50-80";
        String PriceRange2 = "80-100";
        String PriceRange3 = "100-150";
        String SelectedSize = "Small";
        int SelectedBeds = 1;
        String selectedPriceRange = "50-80";
       

        protected void Page_Init(object sender, EventArgs e)
        {
            
            CheckInValidator.MinimumValue = DateTime.Now.ToString("yyyy-MM-dd");


            //Tidligeste du kan sjekke ut er dagen etter i dag
            CheckOutValidator.MinimumValue = DateTime.Now.AddDays(1).ToString("yyyy-MM-dd");
            var rooms = db.Room.OrderBy(r => r.roomnumber).ToList();
            GridView1.DataSource = db.Room.Local;
            GridView1.DataBind();

            //size drop down list
            var roomsize = db.Room.Select(r => r.size).OrderBy(r => r).Distinct().ToList();
            roomsize.Reverse();
            sizeDropDownList.Items.Clear();
            foreach (var size in roomsize)
            {
                sizeDropDownList.Items.Add(new ListItem(size, size));
            }
            sizeDropDownList.DataBind();
            //beds drop down list
            var roombeds = db.Room.Select(r => r.numberofbeds).OrderBy(r => r).Distinct().ToList();
            foreach (var bed in roombeds)
            {
                bedsDropDownList.Items.Add(new ListItem(bed.ToString(), bed.ToString()));
            }
            bedsDropDownList.DataBind();
            //prices drop down list
            DropDownList3.Items.Add(new ListItem(PriceRange1, PriceRange1));
            DropDownList3.Items.Add(new ListItem(PriceRange2, PriceRange2));
            DropDownList3.Items.Add(new ListItem(PriceRange3, PriceRange3));
            //events
            sizeDropDownList.SelectedIndexChanged += SizeDropDownList_SelectedIndexChanged;
            bedsDropDownList.SelectedIndexChanged += BedsDropDownList_SelectedIndexChanged;
            DropDownList3.SelectedIndexChanged += DropDownList3_SelectedIndexChanged;
        }
        protected void Page_Load(object sender, EventArgs e)
        {



            //Kan tidligest Booke i dag
            CheckInValidator.MinimumValue = DateTime.Now.ToString("yyyy-MM-dd");
          
      
            //Tidligeste du kan sjekke ut er dagen etter i dag
            CheckOutValidator.MinimumValue = DateTime.Now.AddDays(1).ToString("yyyy-MM-dd");
        

            
        }


        private void SizeDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedSize = sizeDropDownList.SelectedValue;
        }
        private void BedsDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedBeds = int.Parse(bedsDropDownList.SelectedValue);
        }
        private void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedPriceRange = DropDownList3.SelectedValue;
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
            var selectedRooms = from room in db.Room
                                where room.size == SelectedSize
                                select room;

                GridView1.DataSource = selectedRooms.ToList();
                GridView1.DataBind();   
            

        }

        protected void BookRoomButton_Click(object sender, EventArgs e)
        {

        }
    }
}