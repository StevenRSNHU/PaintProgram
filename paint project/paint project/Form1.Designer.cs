namespace paint_project
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.ShapeCBox = new System.Windows.Forms.ComboBox();
            this.PickBtn = new System.Windows.Forms.Button();
            this.RLabel = new System.Windows.Forms.Label();
            this.GLabel = new System.Windows.Forms.Label();
            this.BLabel = new System.Windows.Forms.Label();
            this.RTextBox = new System.Windows.Forms.TextBox();
            this.GTextBox = new System.Windows.Forms.TextBox();
            this.BTextBox = new System.Windows.Forms.TextBox();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.SizeLabel1 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(692, 553);
            this.panel1.TabIndex = 0;
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(795, 12);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(75, 23);
            this.ClearBtn.TabIndex = 1;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            // 
            // ShapeCBox
            // 
            this.ShapeCBox.FormattingEnabled = true;
            this.ShapeCBox.Location = new System.Drawing.Point(707, 76);
            this.ShapeCBox.Name = "ShapeCBox";
            this.ShapeCBox.Size = new System.Drawing.Size(77, 24);
            this.ShapeCBox.TabIndex = 2;
            this.ShapeCBox.Text = "shape?";
            this.ShapeCBox.SelectedIndexChanged += new System.EventHandler(this.ShapeCBox_SelectedIndexChanged);
            // 
            // PickBtn
            // 
            this.PickBtn.Location = new System.Drawing.Point(713, 45);
            this.PickBtn.Name = "PickBtn";
            this.PickBtn.Size = new System.Drawing.Size(70, 22);
            this.PickBtn.TabIndex = 3;
            this.PickBtn.Text = "Pick";
            this.PickBtn.UseVisualStyleBackColor = true;
            // 
            // RLabel
            // 
            this.RLabel.AutoSize = true;
            this.RLabel.Location = new System.Drawing.Point(712, 149);
            this.RLabel.Name = "RLabel";
            this.RLabel.Size = new System.Drawing.Size(18, 17);
            this.RLabel.TabIndex = 4;
            this.RLabel.Text = "R";
            // 
            // GLabel
            // 
            this.GLabel.AutoSize = true;
            this.GLabel.Location = new System.Drawing.Point(764, 149);
            this.GLabel.Name = "GLabel";
            this.GLabel.Size = new System.Drawing.Size(19, 17);
            this.GLabel.TabIndex = 5;
            this.GLabel.Text = "G";
            // 
            // BLabel
            // 
            this.BLabel.AutoSize = true;
            this.BLabel.Location = new System.Drawing.Point(829, 149);
            this.BLabel.Name = "BLabel";
            this.BLabel.Size = new System.Drawing.Size(17, 17);
            this.BLabel.TabIndex = 6;
            this.BLabel.Text = "B";
            this.BLabel.Click += new System.EventHandler(this.BLabel_Click);
            // 
            // RTextBox
            // 
            this.RTextBox.Location = new System.Drawing.Point(701, 184);
            this.RTextBox.Name = "RTextBox";
            this.RTextBox.Size = new System.Drawing.Size(36, 22);
            this.RTextBox.TabIndex = 7;
            this.RTextBox.Text = "0";
            this.RTextBox.TextChanged += new System.EventHandler(this.RTextBox_TextChanged);
            // 
            // GTextBox
            // 
            this.GTextBox.Location = new System.Drawing.Point(758, 184);
            this.GTextBox.Name = "GTextBox";
            this.GTextBox.Size = new System.Drawing.Size(36, 22);
            this.GTextBox.TabIndex = 8;
            this.GTextBox.Text = "0";
            this.GTextBox.TextChanged += new System.EventHandler(this.GTextBox_TextChanged);
            // 
            // BTextBox
            // 
            this.BTextBox.Location = new System.Drawing.Point(819, 184);
            this.BTextBox.Name = "BTextBox";
            this.BTextBox.Size = new System.Drawing.Size(36, 22);
            this.BTextBox.TabIndex = 9;
            this.BTextBox.Text = "0";
            this.BTextBox.TextChanged += new System.EventHandler(this.BTextBox_TextChanged);
            // 
            // CreateBtn
            // 
            this.CreateBtn.Location = new System.Drawing.Point(737, 431);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(95, 39);
            this.CreateBtn.TabIndex = 10;
            this.CreateBtn.Text = "Create";
            this.CreateBtn.UseVisualStyleBackColor = true;
            // 
            // SizeLabel1
            // 
            this.SizeLabel1.AutoSize = true;
            this.SizeLabel1.Location = new System.Drawing.Point(755, 265);
            this.SizeLabel1.Name = "SizeLabel1";
            this.SizeLabel1.Size = new System.Drawing.Size(47, 17);
            this.SizeLabel1.TabIndex = 11;
            this.SizeLabel1.Text = "Size 1";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(27, 16);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(94, 21);
            this.radioButton1.TabIndex = 14;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Small Size";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioButton3);
            this.panel2.Controls.Add(this.radioButton2);
            this.panel2.Controls.Add(this.radioButton1);
            this.panel2.Location = new System.Drawing.Point(709, 285);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(160, 146);
            this.panel2.TabIndex = 15;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(27, 57);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(109, 21);
            this.radioButton2.TabIndex = 15;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Medium SIze";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(27, 107);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(97, 21);
            this.radioButton3.TabIndex = 16;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Large Size";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.SizeLabel1);
            this.Controls.Add(this.CreateBtn);
            this.Controls.Add(this.BTextBox);
            this.Controls.Add(this.GTextBox);
            this.Controls.Add(this.RTextBox);
            this.Controls.Add(this.BLabel);
            this.Controls.Add(this.GLabel);
            this.Controls.Add(this.RLabel);
            this.Controls.Add(this.PickBtn);
            this.Controls.Add(this.ShapeCBox);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.ComboBox ShapeCBox;
        private System.Windows.Forms.Button PickBtn;
        private System.Windows.Forms.Label RLabel;
        private System.Windows.Forms.Label GLabel;
        private System.Windows.Forms.Label BLabel;
        private System.Windows.Forms.TextBox RTextBox;
        private System.Windows.Forms.TextBox GTextBox;
        private System.Windows.Forms.TextBox BTextBox;
        private System.Windows.Forms.Button CreateBtn;
        private System.Windows.Forms.Label SizeLabel1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}

