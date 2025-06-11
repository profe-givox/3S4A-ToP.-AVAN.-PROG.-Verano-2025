namespace UsoDeLibreriasNuget
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
            txtName = new TextBox();
            txtEmail = new TextBox();
            dtpDOB = new DateTimePicker();
            btnSerializar = new Button();
            lblSerializar = new Label();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(12, 67);
            txtName.Name = "txtName";
            txtName.Size = new Size(150, 31);
            txtName.TabIndex = 0;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(12, 104);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(150, 31);
            txtEmail.TabIndex = 1;
            // 
            // dtpDOB
            // 
            dtpDOB.Location = new Point(12, 141);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(300, 31);
            dtpDOB.TabIndex = 2;
            // 
            // btnSerializar
            // 
            btnSerializar.Location = new Point(12, 197);
            btnSerializar.Name = "btnSerializar";
            btnSerializar.Size = new Size(112, 34);
            btnSerializar.TabIndex = 3;
            btnSerializar.Text = "To JSON";
            btnSerializar.UseVisualStyleBackColor = true;
            btnSerializar.Click += btnSerializar_Click;
            // 
            // lblSerializar
            // 
            lblSerializar.Location = new Point(443, 94);
            lblSerializar.Name = "lblSerializar";
            lblSerializar.Size = new Size(316, 268);
            lblSerializar.TabIndex = 4;
            lblSerializar.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblSerializar);
            Controls.Add(btnSerializar);
            Controls.Add(dtpDOB);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtEmail;
        private DateTimePicker dtpDOB;
        private Button btnSerializar;
        private Label lblSerializar;
    }
}
