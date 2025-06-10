namespace CustomControlProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            updateNameLabel();
        }

        private void updateNameLabel()
        {
            if (string.IsNullOrWhiteSpace(ctlFirstName.Text) || string.IsNullOrWhiteSpace(ctlLastName.Text))
            {
                lblFullName.Text = "Please fill out both the first and the last name.";
            }
            else
            {
                lblFullName.Text = $"Hello {ctlFirstName.Text} {ctlLastName.Text}. I hope ypu're having a good day.";
            }
        }

        private void ctlFirstName_TextChanged(object sender, EventArgs e)

           => updateNameLabel();


        
        private void ctlLastName_TextChanged_1(object sender, EventArgs e)
        {
            updateNameLabel();
        }
    }
}
