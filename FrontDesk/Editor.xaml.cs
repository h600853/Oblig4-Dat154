//using FrontDesk.Models;
using FrontDesk.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FrontDesk
{
    /// <summary>
    /// Interaction logic for Editor.xaml
    /// </summary>
    public partial class Editor : Window
    {
      
        public MinDatabaseContext Datacontext { get; set; }

         public Editor(MinDatabaseContext datacontext)
         {
            InitializeComponent();
         }
         
        private void bAdd_Click(object sender, RoutedEventArgs e)
        {
             Reservation r = new Reservation()
             {
                 Id = int.Parse(idtextbox.Text),
                 FromDate = fromdatetextbox.Text,
                 ToDate = todatetextbox.Text,
                 Room = int.Parse(roomtextbox.Text)
             };

            // Associate the reservation with the selected room
            int roomNumber = int.Parse(roomcombobox.SelectedValue.ToString());
            Room room = Datacontext.Rooms.FirstOrDefault(r => r.roomnumber == roomNumber);
            if (room != null)
            {
                room.Reservations.Add(r);
            }

            Datacontext.Add(r);
             Datacontext.SaveChanges();

            idtextbox.Text = fromdatetextbox.Text = todatetextbox.Text = roomtextbox.Text = "";
            roomcombobox.SelectedIndex = -1;

        }

        private void bDelete_Click(object sender, RoutedEventArgs e)
        {
            int id = int.Parse(idtextbox.Text);
             Reservation r = Datacontext.Reservations.Where(r => r.Id == id).First();

             if(r != null)
             {
                 Datacontext.Reservations.Remove(r);
                 Datacontext.SaveChanges();

             }

             idtextbox.Text = fromdatetextbox.Text = todatetextbox.Text = roomtextbox.Text = "";
            
        }

    }
}
