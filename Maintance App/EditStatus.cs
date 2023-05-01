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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Maintance_App
{
    public partial class EditStatus : Form
    {
        readonly MinDatabaseContext dx;
        String taskStatus = "";
        String selectTask = "";
        int id = 0;
        public EditStatus()
        {
            InitializeComponent();
            comboBox1.Items.Add("Not done");
            comboBox1.Items.Add("In progress");
            comboBox1.Items.Add("Done");

            comboBox2.Items.Add("Cleaning");
            comboBox2.Items.Add("Maintenance");
            comboBox2.Items.Add("Service");

            dx = new MinDatabaseContext();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //burde mest sannsynlig ha en søk for id hvor en sjekket om id eksisterte i databasen
            if (textBox1.Text != "")
            {
                id = int.Parse(textBox1.Text);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            taskStatus = textBox1.Text;
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            //add to databae
            switch (selectTask)
            {
                case "Cleaning":
                    var cleaning = dx.Cleanings.Where(c => c.Id == id).FirstOrDefault();
                    cleaning.Status = comboBox1.Text;
                    dx.SaveChanges();
                    comboBox1.SelectedIndex = -1;
                    comboBox2.SelectedIndex = -1;
                    break;
                case "Maintenance":
                    var maintenance = dx.Maintenances.Where(c => c.Id == id).FirstOrDefault();
                    maintenance.Status = comboBox1.Text;
                    dx.SaveChanges();
                    comboBox1.SelectedIndex = -1;
                    comboBox2.SelectedIndex = -1;
                    break;
                case "Service":
                    var service = dx.Services.Where(c => c.Id == id).FirstOrDefault();
                    service.Status = comboBox1.Text;
                    dx.SaveChanges();
                    comboBox1.SelectedIndex = -1;
                    comboBox2.SelectedIndex = -1;

                    break;
                default: // if no category is selected 
                    textBox1.Text = "";
                    comboBox1.SelectedIndex = -1;
                    break;
            }
        }

        private void EditStatus_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            selectTask = comboBox2.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
