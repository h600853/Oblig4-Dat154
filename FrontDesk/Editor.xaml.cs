//using FrontDesk.Models;
using FrontDesk.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Linq;
using System.Windows;

namespace FrontDesk
{
    /// <summary>
    /// Interaction logic for Editor.xaml
    /// </summary>
    public partial class Editor : Window
    {
        private MainWindow mainwindow;

        public MinDatabaseContext datacontext { get; set; }

        public Editor(MainWindow mainwindow, MinDatabaseContext datacontext)
        {
            InitializeComponent();
            bAdd.Click += BAdd_Click;
            BDelete.Click += BDelete_Click;
            this.mainwindow = mainwindow;
            this.datacontext = datacontext;
        }

        private void BAdd_Click(object sender, RoutedEventArgs e)
        {
    //        int newId = Enumerable.Range(1, int.MaxValue)
    //.Except(datacontext.Reservations.Select(r => r.Id))
    //.FirstOrDefault();

    //        Reservation r = new Reservation();
    //        {
    //            FromDate = fromdatetextbox.Text,
    //            ToDate = todatetextbox.Text,
    //            Room = int.Parse(roomtextbox.Text),
    //            Person = int.Parse(userTextBox.Text)
    //        };

    //        int roomNumber = int.Parse(roomcombobox.SelectedValue.ToString());
    //        Room room = Datacontext.Rooms.FirstOrDefault(r => r.Roomnumber == roomNumber);
    //        if (room != null)
    //        {
    //            Datacontext.Reservations.Add(r);
    //            Datacontext.SaveChanges();
    //            idtextbox.Text = fromdatetextbox.Text = todatetextbox.Text = roomtextbox.Text = userTextBox.Text = "";
    //        }




    //        //}



       }
        private void BDelete_Click(object sender, RoutedEventArgs e)
        {
            int id = int.Parse(idtextbox.Text);
            Reservation r = datacontext.Reservations.Where(r => r.Id == id).First();
           
            

            if (r != null)
            {
                datacontext.Reservations.Remove(r);

                datacontext.SaveChanges();
                
                mainwindow.refreshMain();
                mainwindow.UpdateLayout();

                

            }

            idtextbox.Text = fromdatetextbox.Text = todatetextbox.Text = roomtextbox.Text = userTextBox.Text = "";

        }
    }
}
