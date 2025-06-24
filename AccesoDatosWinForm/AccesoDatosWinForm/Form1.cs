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
            var conn = new AccesoDatosMySql("localhost", "nwind",
                "root", "700r", 3306);

            //var resukt = conn.ejecutarSentencia(
            //    "INSERT INTO categories (categoryname, description) " +
            //    "VALUES ('Anime', 'Los comics japoneses')"
            //    );

            var prmts = new Dictionary<string, object>();
            prmts.Add("@category", "Nueva categoria");
            prmts.Add("@description", "Nueva descripcion de la categoria");
            var resukt = conn.ejecutarSentencia(
                "INSERT INTO categories (categoryname, description) " +
                "VALUES (@category, @description)"
                ,
                prmts
                );



            MessageBox.Show($"Filas afectas {resukt}");


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var ad = new AccesoDatosMySql("localhost", "nwind",
                "root", "700r", 3306);

            var pars = new Dictionary<string, object>();
            pars.Add("@filto", "C%"); // Filtrar por categorias que empiezan con A
            var res = ad.ejecutarQuery(
                "SELECT * FROM categories where categoryname like @filto",
                pars
                );

            if (res.HasRows)
            {
                while (res.Read())
                {
                    //MessageBox.Show(res.GetString(1));
                    //MessageBox.Show($"{res.GetInt32(0)} - {res.GetString(1)}");
                    //cboCAtegory.Items.Add(res.GetString(1));
                    cboCAtegory.Items.Add($"{res.GetInt32(0)} - {res.GetString(1)}");
                }
            }
            else
            {
                MessageBox.Show("No hay datos en la consulta");
            }


            cargarProducts();
        }

        private void cargarProducts()
        {
            //var ad = new AccesoDatosMySql("localhost", "nwind",
            //    "root", "700r", 3306);
            //var dt = ad.queryTable(
            //    "SELECT * FROM products",
            //    null
            //    );
            //dgv.DataSource = dt;

            using (var ad = new AccesoDatosMySql(
                "localhost", "nwind",
                "root", "700r", 3306
                ))
            {
                var dt = ad.queryTable(
                "SELECT * FROM products",
                null
                );
                dgv.DataSource = dt;
            }

            
        }

        private async void btnSaveAsync_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Insertando...");

            var conn = new AccesoDatosMySql("localhost", "nwind",
                "root", "700r", 3306);

            //var resukt = conn.ejecutarSentencia(
            //    "INSERT INTO categories (categoryname, description) " +
            //    "VALUES ('Anime', 'Los comics japoneses')"
            //    );

            var prmts = new Dictionary<string, object>();
            prmts.Add("@category", "Catagoria Async ");
            prmts.Add("@description", "descripcion de la categoria async");
            var resukt = await conn.ejecutarSentenciaAsync(
                "INSERT INTO categories (categoryname, description) " +
                "VALUES (@category, @description)"
                ,
                prmts
                );

            MessageBox.Show($"Filas afectas asyncronas {resukt}");
        }
    }
}
