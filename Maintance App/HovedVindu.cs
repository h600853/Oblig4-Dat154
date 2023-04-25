using Maintance_App.Models;

namespace Maintance_App
{
    public partial class HovedVindu : Form
    {

        public MinDatabaseContext context = new MinDatabaseContext();
        private bool cleaningButtonPressed;
        private bool serviceButtonPressed;
        private bool maintananceButtonPressed;
        public HovedVindu(bool cleaningButtonPressed, bool serviceButtonPressed, bool maintananceButtonPressed)
        {
            InitializeComponent();
            this.serviceButtonPressed = serviceButtonPressed;
            this.cleaningButtonPressed = cleaningButtonPressed;
            this.maintananceButtonPressed = maintananceButtonPressed;
            tasksGridView.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);

        }

        private void HovedVindu_Load(object sender, EventArgs e)
        {




            //Display service Tasks when service button is pressed

            if (serviceButtonPressed)
            {
                List<Service> serviceTasks = context.Services.ToList();
                tasksGridView.DataSource = serviceTasks;
                tasksGridView.Columns.Remove("RoomNavigation");

            }

            //Display maintenance Tasks when maintanance button is pressed
            if (maintananceButtonPressed)
            {
                List<Maintenance> maintenanceTasks = context.Maintenances.ToList();
                tasksGridView.DataSource = maintenanceTasks;
                tasksGridView.Columns.Remove("RoomNavigation");

            }


            //Display cleaning Tasks when cleaning button is pressed
            if (cleaningButtonPressed)
            {
                List<Cleaning> cleaningTasks = context.Cleanings.ToList();
                tasksGridView.DataSource = cleaningTasks;
                tasksGridView.Columns.Remove("RoomNavigation");

            }

        }

        //Redirecter deg til AddandRemoveTask.cs når du trykker på knappen
        private void addOrDelete_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddandRemoveTask addorRemoveTask = new AddandRemoveTask();
            addorRemoveTask.Show();

        }

        //Redirecter deg til EditStatus.cs når du trykker på knappen
        private void editStatusButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditStatus editStatus = new EditStatus();
            editStatus.Show();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //For å resize bredden til kolonnene ved endring av vindusstørrelse
        private void hovedVindu_SizeChanged(object sender, EventArgs e)
        {

            int width = tasksGridView.Width;
            int columnWidth = width / 4;
            tasksGridView.Columns["Id"].Width = columnWidth;
            tasksGridView.Columns["Request"].Width = columnWidth;
            tasksGridView.Columns["Status"].Width = columnWidth;
            tasksGridView.Columns["Room"].Width = columnWidth;
        }
    }
}