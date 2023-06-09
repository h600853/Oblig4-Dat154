﻿//using FrontDesk.Models;
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


        }

        private void LoadReservations()
        {
            using (var context = new MinDatabaseContext())
            {
                var reservations = context.Reservations.ToList();
                reservationList.ItemsSource = reservations;
            }
        }


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
            var reservations = datacontext.Reservations.Where(r => r.Id.Equals(int.Parse(searchField.Text))).ToList();
            reservationList.ItemsSource = reservations;
            searchField.Text = "";
        }
        //Refresh
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            LoadReservations();
        }
    }
}
