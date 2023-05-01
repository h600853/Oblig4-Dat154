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

        private void RolleVindu_Load(object sender, EventArgs e)
        {
            selectRoleLabel.Font = new Font("Arial", 16, FontStyle.Bold);
            selectRoleLabel.Location = new Point(250, 100);






        }


        //For å holde knappene og labelen i midten av vinduet
        private void RolleVindu_SizeChanged(object sender, EventArgs e)
        {


            int width = this.Width / 2;
            int height = this.Height / 2;
            rolleVinduPanel.Location = new Point(width - rolleVinduPanel.Width / 2, height - rolleVinduPanel.Height / 2);
        }

        private void rolleVinduPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
