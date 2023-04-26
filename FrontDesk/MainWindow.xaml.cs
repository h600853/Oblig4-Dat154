//using FrontDesk.Models;
using FrontDesk.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace FrontDesk
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private readonly MinDatabaseContext datacontext = new();

         LocalView<User> Users;
         LocalView<Reservation> Reservations;
         LocalView<Room> Rooms;
        

        public MainWindow()
        {
            InitializeComponent();

             Users = datacontext.Users.Local;

             Reservations = datacontext.Reservations.Local;

             Rooms = datacontext.Rooms.Local;

            datacontext.Reservations.Load();
            datacontext.Rooms.Load();
            datacontext.Users.Load();

            LoadReservations();
            //LoadRooms();


        }

        private void LoadReservations()
        {
            using (var context = new MinDatabaseContext())
            {
                var reservations = context.Reservations.Include(r => r.RoomNavigation).Include(r => r.PersonNavigation).ToList();

                reservationList.ItemsSource = reservations;
            




            }

            
        }

        //private void LoadRooms()
        //{
        //    using (var context = new MinDatabaseContext())
        //    {
        //        var rooms = context.Rooms.Select(r => r.roomnumber).ToList();
        //        reservationList.ItemsSource = rooms;
        //    }

        //}


        private void Button_Click(object sender, RoutedEventArgs e)
        {

              Editor ed = new(datacontext)
              {
                  Datacontext = datacontext
              };

              ed.Show();

              
        }

        public void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Your event handling code here
        }

        private void Search_Button_Click(object sender, RoutedEventArgs e)
        {
             reservationList.DataContext = Reservations.Where(r => r.Id.Equals(searchField.Text));
              
        }
    }
}
