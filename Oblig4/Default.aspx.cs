using System;
using System.Collections.Generic;
using System.Linq;
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
        String SelectedSize = "";
        int SelectedBeds = 0;
        String selectedPriceRange = "";
        String selectedcheckin = "";
        String selectedcheckout = "";
        List<Reservations> reservations = new List<Reservations>();


        protected void Page_Init(object sender, EventArgs e)
        {

            CheckInValidator.MinimumValue = DateTime.Now.ToString("yyyy-MM-dd");


            //Tidligeste du kan sjekke ut er dagen etter i dag
            CheckOutValidator.MinimumValue = DateTime.Now.AddDays(1).ToString("yyyy-MM-dd");
            var rooms = db.Room.Where(r => r.Available == true).OrderBy(r => r.roomnumber).ToList();
            GridView1.DataSource = db.Room.Local;
            GridView1.DataBind();

            //size drop down list
            var roomsize = db.Room.Select(r => r.size).OrderBy(r => r).Distinct().ToList();
            roomsize.Reverse();
            sizeDropDownList.Items.Clear();
            sizeDropDownList.Items.Add("");
            foreach (var size in roomsize)
            {
                sizeDropDownList.Items.Add(new ListItem(size, size));
            }
            sizeDropDownList.DataBind();
            //beds drop down list
            var roombeds = db.Room.Select(r => r.numberofbeds).OrderBy(r => r).Distinct().ToList();
            bedsDropDownList.Items.Add("");
            foreach (var bed in roombeds)
            {
                bedsDropDownList.Items.Add(new ListItem(bed.ToString(), bed.ToString()));
            }
            bedsDropDownList.DataBind();
            //prices drop down list
            DropDownList3.Items.Add("");
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
            //check if user is logged in
            if (Session["username"] == null)
            {
                Response.Redirect("~/Login.aspx");
            }
        

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
            selectedcheckin = checkInTextBox.Text;
            Validate();
        }

        protected void tilDatoTekstBox_TextChanged(object sender, EventArgs e)
        {
            selectedcheckout = checkOutTextBox.Text;    
            Validate();
        }

        protected void SearchButton_Click(object sender, EventArgs e)
        {
            if (SelectedBeds != 0 && selectedPriceRange != "" && SelectedSize != "" && selectedcheckin != "" && selectedcheckout!= "")
            {

                int minPrice = int.Parse(selectedPriceRange.Split('-')[0]);
                int maxPrice = int.Parse(selectedPriceRange.Split('-')[1]);

           


                var selectedRooms = from room in db.Room
                                    where room.size == SelectedSize
                                    where room.numberofbeds == SelectedBeds
                                    where room.price >= minPrice
                                    where room.price <= maxPrice
                                    where room.Available == true
                                    select room;



                GridView1.DataSource = selectedRooms;
                GridView1.DataBind();

                bedsDropDownList.SelectedIndex = 0;
                sizeDropDownList.SelectedIndex = 0;
                DropDownList3.SelectedIndex = 0;
            }


        }


        public Boolean RoomNumberExsist(int roomNr)
        {
            var room = db.Room.Where(r => r.roomnumber == roomNr).FirstOrDefault();
            if (room != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        protected void BookRoomButton_Click(object sender, EventArgs e)
        {
            var roomnumber = int.Parse(RoomTextBox.Text);
            string username = (string)Session["username"];
            string password = (string)Session["password"];
            if (RoomNumberExsist(roomnumber))
            {
                //get user from username and passord 
                var user = db.Users.Where(u => u.username == username && u.password == password).FirstOrDefault();
          
                //make a new reservation
                Reservations reservation = new Reservations();
                reservation.FromDate = checkInTextBox.Text;
                reservation.ToDate = checkOutTextBox.Text;
                reservation.Room = int.Parse(RoomTextBox.Text);
                reservation.Person = user.id;
                //save in session
                List<Oblig4.Reservations> reservations = (List<Oblig4.Reservations>)Session["reservations"];
                if (reservations == null)
                {
               
                    reservations = new List<Oblig4.Reservations>();
                }

                reservations.Add(reservation);           
                Session["reservations"] = reservations;
                
                
                //save in database
                db.Reservations.Add(reservation);
                db.SaveChanges();
                //update room to unavailable
            var room = db.Room.Where(r => r.roomnumber == roomnumber).FirstOrDefault();
                room.Available = false;
                db.SaveChanges();
                //clear search fields
                checkInTextBox.Text = "";
                checkOutTextBox.Text = "";
                 RoomTextBox.Text = "";   
                //update gridview
                var availableRooms = db.Room.Where(r => r.Available == true).ToList();
                GridView1.DataSource = availableRooms;
                GridView1.DataBind();
                errorMessage.Visible = false;
            }
            else
            {
                errorMessage.Visible = true;
            }
        }


    }


}
