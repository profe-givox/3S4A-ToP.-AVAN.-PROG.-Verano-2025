using AccesoDatosWinForm.data;

namespace AccesoDatosWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var conn = new AccesoDatosMySql("localhost","nwind",
                "root", "700r", 3306);

            var resukt = conn.ejecutarSentencia(
                "INSERT INTO categories (categoryname, description) " +
                "VALUES ('Anime', 'Los comics japoneses')"
                );

            MessageBox.Show($"Filas afectas {resukt}");


        }
    }
}
