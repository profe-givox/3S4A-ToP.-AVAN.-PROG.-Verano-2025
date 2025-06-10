namespace CustomControlProject
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
            ctlFirstName = new ClerableTextBox();
            ctlLastName = new ClerableTextBox();
            lblFullName = new Label();
            SuspendLayout();
            // 
            // ctlFirstName
            // 
            ctlFirstName.Location = new Point(12, 12);
            ctlFirstName.MinimumSize = new Size(84, 53);
            ctlFirstName.Name = "ctlFirstName";
            ctlFirstName.Size = new Size(286, 80);
            ctlFirstName.TabIndex = 0;
            ctlFirstName.Title = "First name";
            ctlFirstName.TextChanged += ctlFirstName_TextChanged;
            // 
            // ctlLastName
            // 
            ctlLastName.Location = new Point(12, 98);
            ctlLastName.MinimumSize = new Size(84, 53);
            ctlLastName.Name = "ctlLastName";
            ctlLastName.Size = new Size(286, 80);
            ctlLastName.TabIndex = 1;
            ctlLastName.Title = "Last name";
            ctlLastName.TextChanged += ctlLastName_TextChanged_1;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(12, 405);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(59, 25);
            lblFullName.TabIndex = 2;
            lblFullName.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 439);
            Controls.Add(lblFullName);
            Controls.Add(ctlLastName);
            Controls.Add(ctlFirstName);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ClerableTextBox ctlFirstName;
        private ClerableTextBox ctlLastName;
        private Label lblFullName;
    }
}
