namespace Maintance_App
{
    public partial class RolleVindu : Form
    {
        public bool cleaningButtonPressed { get; set; } = false;
        public bool serviceButtonPressed { get; set; } = false;
        public bool maintananceButtonPressed { get; set; } = false;
        public RolleVindu()
        {
            InitializeComponent();
        }

        private void cleaningButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            HovedVindu hovedVindu = new HovedVindu(cleaningButtonPressed: true, serviceButtonPressed: false, maintananceButtonPressed: false);
            hovedVindu.Show();


        }

        private void ServiceButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            HovedVindu hovedVindu = new HovedVindu(cleaningButtonPressed: false, serviceButtonPressed: true, maintananceButtonPressed: false);
            hovedVindu.Show();

        }

        private void maintanceButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            HovedVindu hovedVindu = new HovedVindu(cleaningButtonPressed: false, serviceButtonPressed: false, maintananceButtonPressed: true);
            hovedVindu.Show();

        }
    }
}
