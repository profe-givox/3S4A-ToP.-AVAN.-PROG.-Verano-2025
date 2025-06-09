namespace MathQuiz
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
            components = new System.ComponentModel.Container();
            lblTimer = new Label();
            lblTime = new Label();
            lblPlusLeft = new Label();
            lblPlusRight = new Label();
            label2 = new Label();
            label3 = new Label();
            nudSumar = new NumericUpDown();
            nudDifference = new NumericUpDown();
            label1 = new Label();
            label4 = new Label();
            lblMinusRigthLabel = new Label();
            lblMinusLeftLabel = new Label();
            nudProduct = new NumericUpDown();
            label5 = new Label();
            label6 = new Label();
            lbltimesRigthLabel = new Label();
            lblTimesLeftLabel = new Label();
            nudDivision = new NumericUpDown();
            label9 = new Label();
            label10 = new Label();
            lblDividedRigthLabel = new Label();
            lblDividedLeftLabel = new Label();
            btnStart = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)nudSumar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudDifference).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudDivision).BeginInit();
            SuspendLayout();
            // 
            // lblTimer
            // 
            lblTimer.BorderStyle = BorderStyle.FixedSingle;
            lblTimer.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTimer.Location = new Point(266, 16);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(200, 41);
            lblTimer.TabIndex = 0;
            lblTimer.Text = "label1";
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Segoe UI", 15F);
            lblTime.Location = new Point(110, 16);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(140, 41);
            lblTime.TabIndex = 1;
            lblTime.Text = "Time Left";
            // 
            // lblPlusLeft
            // 
            lblPlusLeft.Font = new Font("Segoe UI", 18F);
            lblPlusLeft.Location = new Point(50, 75);
            lblPlusLeft.Name = "lblPlusLeft";
            lblPlusLeft.Size = new Size(60, 50);
            lblPlusLeft.TabIndex = 2;
            lblPlusLeft.Text = "?";
            lblPlusLeft.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPlusRight
            // 
            lblPlusRight.Font = new Font("Segoe UI", 18F);
            lblPlusRight.Location = new Point(182, 75);
            lblPlusRight.Name = "lblPlusRight";
            lblPlusRight.Size = new Size(60, 50);
            lblPlusRight.TabIndex = 3;
            lblPlusRight.Text = "?";
            lblPlusRight.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 18F);
            label2.Location = new Point(116, 75);
            label2.Name = "label2";
            label2.Size = new Size(60, 50);
            label2.TabIndex = 4;
            label2.Text = "+";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 18F);
            label3.Location = new Point(248, 75);
            label3.Name = "label3";
            label3.Size = new Size(60, 50);
            label3.TabIndex = 5;
            label3.Text = "=";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nudSumar
            // 
            nudSumar.Font = new Font("Segoe UI", 18F);
            nudSumar.Location = new Point(314, 75);
            nudSumar.MaximumSize = new Size(100, 0);
            nudSumar.Name = "nudSumar";
            nudSumar.Size = new Size(100, 55);
            nudSumar.TabIndex = 1;
            nudSumar.ValueChanged += nudSumar_ValueChanged;
            nudSumar.Enter += nudSumar_Enter;
            // 
            // nudDifference
            // 
            nudDifference.Font = new Font("Segoe UI", 18F);
            nudDifference.Location = new Point(314, 145);
            nudDifference.MaximumSize = new Size(100, 0);
            nudDifference.Name = "nudDifference";
            nudDifference.Size = new Size(100, 55);
            nudDifference.TabIndex = 2;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(248, 145);
            label1.Name = "label1";
            label1.Size = new Size(60, 50);
            label1.TabIndex = 10;
            label1.Text = "=";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 18F);
            label4.Location = new Point(116, 145);
            label4.Name = "label4";
            label4.Size = new Size(60, 50);
            label4.TabIndex = 9;
            label4.Text = "-";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMinusRigthLabel
            // 
            lblMinusRigthLabel.Font = new Font("Segoe UI", 18F);
            lblMinusRigthLabel.Location = new Point(182, 145);
            lblMinusRigthLabel.Name = "lblMinusRigthLabel";
            lblMinusRigthLabel.Size = new Size(60, 50);
            lblMinusRigthLabel.TabIndex = 8;
            lblMinusRigthLabel.Text = "?";
            lblMinusRigthLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMinusLeftLabel
            // 
            lblMinusLeftLabel.Font = new Font("Segoe UI", 18F);
            lblMinusLeftLabel.Location = new Point(50, 145);
            lblMinusLeftLabel.Name = "lblMinusLeftLabel";
            lblMinusLeftLabel.Size = new Size(60, 50);
            lblMinusLeftLabel.TabIndex = 7;
            lblMinusLeftLabel.Text = "?";
            lblMinusLeftLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nudProduct
            // 
            nudProduct.Font = new Font("Segoe UI", 18F);
            nudProduct.Location = new Point(314, 212);
            nudProduct.MaximumSize = new Size(100, 0);
            nudProduct.Name = "nudProduct";
            nudProduct.Size = new Size(100, 55);
            nudProduct.TabIndex = 3;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 18F);
            label5.Location = new Point(248, 212);
            label5.Name = "label5";
            label5.Size = new Size(60, 50);
            label5.TabIndex = 15;
            label5.Text = "=";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 18F);
            label6.Location = new Point(116, 212);
            label6.Name = "label6";
            label6.Size = new Size(60, 50);
            label6.TabIndex = 14;
            label6.Text = "*";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbltimesRigthLabel
            // 
            lbltimesRigthLabel.Font = new Font("Segoe UI", 18F);
            lbltimesRigthLabel.Location = new Point(182, 212);
            lbltimesRigthLabel.Name = "lbltimesRigthLabel";
            lbltimesRigthLabel.Size = new Size(60, 50);
            lbltimesRigthLabel.TabIndex = 13;
            lbltimesRigthLabel.Text = "?";
            lbltimesRigthLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTimesLeftLabel
            // 
            lblTimesLeftLabel.Font = new Font("Segoe UI", 18F);
            lblTimesLeftLabel.Location = new Point(50, 212);
            lblTimesLeftLabel.Name = "lblTimesLeftLabel";
            lblTimesLeftLabel.Size = new Size(60, 50);
            lblTimesLeftLabel.TabIndex = 12;
            lblTimesLeftLabel.Text = "?";
            lblTimesLeftLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nudDivision
            // 
            nudDivision.Font = new Font("Segoe UI", 18F);
            nudDivision.Location = new Point(314, 275);
            nudDivision.MaximumSize = new Size(100, 0);
            nudDivision.Name = "nudDivision";
            nudDivision.Size = new Size(100, 55);
            nudDivision.TabIndex = 4;
            // 
            // label9
            // 
            label9.Font = new Font("Segoe UI", 18F);
            label9.Location = new Point(248, 275);
            label9.Name = "label9";
            label9.Size = new Size(60, 50);
            label9.TabIndex = 20;
            label9.Text = "=";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.Font = new Font("Segoe UI", 18F);
            label10.Location = new Point(116, 275);
            label10.Name = "label10";
            label10.Size = new Size(60, 50);
            label10.TabIndex = 19;
            label10.Text = "/";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDividedRigthLabel
            // 
            lblDividedRigthLabel.Font = new Font("Segoe UI", 18F);
            lblDividedRigthLabel.Location = new Point(182, 275);
            lblDividedRigthLabel.Name = "lblDividedRigthLabel";
            lblDividedRigthLabel.Size = new Size(60, 50);
            lblDividedRigthLabel.TabIndex = 18;
            lblDividedRigthLabel.Text = "?";
            lblDividedRigthLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDividedLeftLabel
            // 
            lblDividedLeftLabel.Font = new Font("Segoe UI", 18F);
            lblDividedLeftLabel.Location = new Point(50, 275);
            lblDividedLeftLabel.Name = "lblDividedLeftLabel";
            lblDividedLeftLabel.Size = new Size(60, 50);
            lblDividedLeftLabel.TabIndex = 17;
            lblDividedLeftLabel.Text = "?";
            lblDividedLeftLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnStart
            // 
            btnStart.AutoSize = true;
            btnStart.Font = new Font("Segoe UI", 14F);
            btnStart.Location = new Point(160, 356);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(112, 48);
            btnStart.TabIndex = 0;
            btnStart.Text = "Iniciar";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 402);
            Controls.Add(nudSumar);
            Controls.Add(btnStart);
            Controls.Add(nudDivision);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(lblDividedRigthLabel);
            Controls.Add(lblDividedLeftLabel);
            Controls.Add(nudProduct);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(lbltimesRigthLabel);
            Controls.Add(lblTimesLeftLabel);
            Controls.Add(nudDifference);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(lblMinusRigthLabel);
            Controls.Add(lblMinusLeftLabel);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblPlusRight);
            Controls.Add(lblPlusLeft);
            Controls.Add(lblTime);
            Controls.Add(lblTimer);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Math Quiz";
            ((System.ComponentModel.ISupportInitialize)nudSumar).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudDifference).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudDivision).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTimer;
        private Label lblTime;
        private Label lblPlusLeft;
        private Label lblPlusRight;
        private Label label2;
        private Label label3;
        private NumericUpDown nudSumar;
        private NumericUpDown nudDifference;
        private Label label1;
        private Label label4;
        private Label lblMinusRigthLabel;
        private Label lblMinusLeftLabel;
        private NumericUpDown nudProduct;
        private Label label5;
        private Label label6;
        private Label lbltimesRigthLabel;
        private Label lblTimesLeftLabel;
        private NumericUpDown nudDivision;
        private Label label9;
        private Label label10;
        private Label lblDividedRigthLabel;
        private Label lblDividedLeftLabel;
        private Button btnStart;
        private System.Windows.Forms.Timer timer1;
    }
}
