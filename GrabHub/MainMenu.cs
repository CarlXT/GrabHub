namespace GrabHub
{
    public partial class MainMenu : Form
    {
        private static Boolean showed = false;
        public MainMenu()
        {
            InitializeComponent();
            if (showed)
            { 
                actionPanel.Show();
                btnExit.Show();
                mainPanel.Hide();
                btnExit.BringToFront();
            }

            showed = true;
        }

        private void welcomeMessage_Click(object sender, EventArgs e)
        {

        }

        private void mainbtn_Click(object sender, EventArgs e)
        {
            actionPanel.Show();
            btnExit.Show();
            mainPanel.Hide();
            btnExit.BringToFront();
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            mainPanel.Show();
            btnExit.Hide();
            actionPanel.Hide();
        }

        private void returnBtnAddPnl_Click(object sender, EventArgs e)
        {

        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        
        private void addBtn_Click(object sender, EventArgs e)
        {
            AddProduct add = new AddProduct();
            add.Owner = this; // Set MainMenu as the owner of AddProduct
            this.Hide();
            add.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
