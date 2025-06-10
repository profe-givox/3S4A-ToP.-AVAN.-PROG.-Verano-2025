using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControlProject
{
    [DefaultEvent(nameof(TextChanged))]
    public partial class ClerableTextBox : UserControl
    {
        public ClerableTextBox()
        {
            InitializeComponent();
        }

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public new string Title {
            get => lblTitle.Text;
            set => lblTitle.Text = value;
        }

        [Browsable(true)]
        public new event EventHandler? TextChanged
        {
            add => txtValue.TextChanged += value;
            remove => txtValue.TextChanged -= value;
        }

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public new string Text
        {
            get => txtValue.Text;
            set => txtValue.Text = value;
        }

        private void btnClear_Click(object sender, EventArgs e) => Text = string.Empty;

        
    }
}
