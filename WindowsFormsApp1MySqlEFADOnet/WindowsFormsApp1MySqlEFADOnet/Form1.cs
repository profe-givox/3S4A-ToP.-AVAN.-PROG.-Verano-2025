using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1MySqlEFADOnet
{
    public partial class Form1 : Form
    {
        worldEntities we;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            we = new worldEntities();
            cityBindingSource.DataSource = we.city.ToList();
        }

        private void cityBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            we.SaveChanges();
        }
    }
}
