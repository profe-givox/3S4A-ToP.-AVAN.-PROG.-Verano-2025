using Serilog;

namespace LibreriasDesarrolladores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Your program here...
                const string name = "Serilog";
                Log.Information("Hello, {Name}!", name);
                throw new InvalidOperationException("Oops...");
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Unhandled exception");
            }
            finally
            {
                Log.CloseAndFlush(); // ensure all logs written before app exits
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
