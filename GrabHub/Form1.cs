namespace GrabHub
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void welcomeMessage_Click(object sender, EventArgs e)
        {

        }

        private void mainbtn_Click(object sender, EventArgs e)
        {
            actionPanel.Show();
            mainPanel.Hide();

        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            mainPanel.Show();
            actionPanel.Hide();
        }
    }
}
