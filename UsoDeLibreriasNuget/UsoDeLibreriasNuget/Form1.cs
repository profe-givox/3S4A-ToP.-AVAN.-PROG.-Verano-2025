using Newtonsoft.Json;

namespace UsoDeLibreriasNuget
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSerializar_Click(object sender, EventArgs e)
        {
            string json = accountToJson(
                    new Account {
                        name = txtName.Text,
                        email = txtEmail.Text,
                        DOB = dtpDOB.Value
                    }
                );
            lblSerializar.Text = json;
        }

        private string accountToJson(Account account)
        {
            // Serializar el objeto Account a JSON
            return Newtonsoft.Json.JsonConvert.SerializeObject(account);
        }
    }
}
