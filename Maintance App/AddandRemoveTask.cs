using Maintance_App.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maintance_App
{
    public partial class AddandRemoveTask : Form
    {
        MinDatabaseContext dx;
        int id = 0;
        int roomnumber = 0;
        String request = "";
        String category = "";
        public AddandRemoveTask()
        {
            InitializeComponent();
            comboBox1.Items.Add("Cleaning");
            comboBox1.Items.Add("Maintenance");
            comboBox1.Items.Add("Service");
            dx = new MinDatabaseContext();
        }
        private void AddandRemoveTask_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        //Add
        private void button1_Click(object sender, EventArgs e)
        {
            //add task to database
            switch (category)
            {
                case "Cleaning":
                    if (request != "" && roomnumber != 0)
                    {
                        Cleaning ct = new Cleaning();
                        ct.Room = roomnumber;
                        ct.Status = "New";
                        ct.Request = request;
                        dx.Cleanings.Add(ct);
                        dx.SaveChanges();
                    }
                    break;
                case "Maintenance":
                    if (request != "" && roomnumber != 0)
                    {
                        Maintenance mt = new Maintenance();
                        mt.Room = roomnumber;
                        mt.Status = "New";
                        mt.Request = request;
                        dx.Maintenances.Add(mt);
                        dx.SaveChanges();
                    }
                    break;
                case "Service":
                    if (request != "" && roomnumber != 0)
                    {
                        Service st = new Service();
                        st.Room = roomnumber;
                        st.Status = "New";
                        st.Request = request;
                        dx.Services.Add(st);
                        dx.SaveChanges();
                    }
                    break;
                default:
                    break;

            }

        }
        //Remove
        private void button2_Click(object sender, EventArgs e)
        {
            //Remove task from database with id 
            switch (category)
            {
                case "Cleaning":
                    if(id != 0)
                    {

                    Cleaning? ct = dx.Cleanings.Find(id);
                    if (ct != null)
                    {
                        dx.Cleanings.Remove(ct);
                        dx.SaveChanges();
                    }
                    }
                    break;
                case "Maintenance":
                    if (id != 0)
                    {
                    Maintenance? mt = dx.Maintenances.Find(id);
                    if (mt != null)
                    {
                        dx.Maintenances.Remove(mt);
                        dx.SaveChanges();
                    }
                    }
                    break;
                case "Service":
                    if(id != 0)
                    {

                    Service? st = dx.Services.Find(id);
                    if (st != null)
                    {
                        dx.Services.Remove(st);
                        dx.SaveChanges();
                    }
                    }
                    break;
                default:
                    break;
            }

        }
        //Select Task
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            category = comboBox1.Text;
        }
        //Task Description
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            request = richTextBox1.Text;
        }
        //Id
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            id = int.Parse(textBox1.Text);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        //Roomnumber
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            roomnumber = int.Parse(textBox2.Text);
        }
    }
}
