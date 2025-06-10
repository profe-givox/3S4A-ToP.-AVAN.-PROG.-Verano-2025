namespace CustomControlProject
{
    partial class ClerableTextBox
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            txtValue = new TextBox();
            btnClear = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(3, 5);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(59, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "label1";
            // 
            // txtValue
            // 
            txtValue.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtValue.Location = new Point(3, 23);
            txtValue.Name = "txtValue";
            txtValue.Size = new Size(148, 31);
            txtValue.TabIndex = 1;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClear.Location = new Point(157, 23);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(31, 23);
            btnClear.TabIndex = 2;
            btnClear.Text = "↺";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // ClerableTextBox
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnClear);
            Controls.Add(txtValue);
            Controls.Add(lblTitle);
            MinimumSize = new Size(84, 53);
            Name = "ClerableTextBox";
            Size = new Size(191, 53);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private TextBox txtValue;
        private Button btnClear;
    }
}
