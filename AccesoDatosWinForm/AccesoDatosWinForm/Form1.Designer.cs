namespace AccesoDatosWinForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnGuardar = new Button();
            cboCAtegory = new ComboBox();
            dgv = new DataGridView();
            btnSaveAsync = new Button();
            txtName = new TextBox();
            txtDescrip = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(654, 354);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(112, 34);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // cboCAtegory
            // 
            cboCAtegory.FormattingEnabled = true;
            cboCAtegory.Location = new Point(12, 12);
            cboCAtegory.Name = "cboCAtegory";
            cboCAtegory.Size = new Size(337, 33);
            cboCAtegory.TabIndex = 1;
            // 
            // dgv
            // 
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(12, 51);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 62;
            dgv.Size = new Size(520, 238);
            dgv.TabIndex = 2;
            // 
            // btnSaveAsync
            // 
            btnSaveAsync.Location = new Point(588, 394);
            btnSaveAsync.Name = "btnSaveAsync";
            btnSaveAsync.Size = new Size(185, 34);
            btnSaveAsync.TabIndex = 3;
            btnSaveAsync.Text = "Guardar Async";
            btnSaveAsync.UseVisualStyleBackColor = true;
            btnSaveAsync.Click += btnSaveAsync_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(12, 323);
            txtName.Name = "txtName";
            txtName.Size = new Size(337, 31);
            txtName.TabIndex = 4;
            // 
            // txtDescrip
            // 
            txtDescrip.Location = new Point(12, 373);
            txtDescrip.Name = "txtDescrip";
            txtDescrip.Size = new Size(520, 31);
            txtDescrip.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtDescrip);
            Controls.Add(txtName);
            Controls.Add(btnSaveAsync);
            Controls.Add(dgv);
            Controls.Add(cboCAtegory);
            Controls.Add(btnGuardar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardar;
        private ComboBox cboCAtegory;
        private DataGridView dgv;
        private Button btnSaveAsync;
        private TextBox txtName;
        private TextBox txtDescrip;
    }
}
