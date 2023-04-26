//using FrontDesk.Models;
using FrontDesk.Models;
using System.Linq;
using System.Windows;

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
            bAdd.Click += bAdd_Click;
            //bDelete.Click += bDelete_Click;
        }

        private void bAdd_Click(object sender, RoutedEventArgs e)
        {
            Reservation r = new Reservation()
            {
                FromDate = fromdatetextbox.Text,
                ToDate = todatetextbox.Text,
                Room = int.Parse(roomtextbox.Text),
                Person = int.Parse(userTextBox.Text)
            };

            // Associate the reservation with the selected room
            //int roomNumber = int.Parse(roomcombobox.SelectedValue.ToString());
            //Room room = Datacontext.Rooms.FirstOrDefault(r => r.Roomnumber == roomNumber);
            //if (room != null)
            //{
            //    Datacontext.Reservations.Add(r);
            //    Datacontext.SaveChanges();
            //    idtextbox.Text = fromdatetextbox.Text = todatetextbox.Text = roomtextbox.Text = userTextBox.Text = "";
            //}




            //}

            //    private void bDelete_Click(object sender, RoutedEventArgs e)
            //    {
            //        int id = int.Parse(idtextbox.Text);
            //        Reservation r = Datacontext.Reservations.Where(r => r.Id == id).First();

            //        if (r != null)
            //        {
            //            Datacontext.Reservations.Remove(r);
            //            Datacontext.SaveChanges();

            //        }

            //        idtextbox.Text = fromdatetextbox.Text = todatetextbox.Text = roomtextbox.Text = userTextBox.Text = "";

            //    }

        }
    }
}
