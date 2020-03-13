﻿namespace paint_project
{
    partial class DrawingProgram
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
            this.DrawingPanel = new System.Windows.Forms.Panel();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ShapeBox = new System.Windows.Forms.ComboBox();
            this.PickShapeButton = new System.Windows.Forms.Button();
            this.RLabel = new System.Windows.Forms.Label();
            this.GreenLabel = new System.Windows.Forms.Label();
            this.BlueLabel = new System.Windows.Forms.Label();
            this.RedTextBox = new System.Windows.Forms.TextBox();
            this.GreenTextBox = new System.Windows.Forms.TextBox();
            this.BlueTextBox = new System.Windows.Forms.TextBox();
            this.CreateButton = new System.Windows.Forms.Button();
            this.SizeLabel = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.SelectionPanel = new System.Windows.Forms.Panel();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.SelectionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DrawingPanel
            // 
            this.DrawingPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.DrawingPanel.Location = new System.Drawing.Point(3, 2);
            this.DrawingPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DrawingPanel.Name = "DrawingPanel";
            this.DrawingPanel.Size = new System.Drawing.Size(667, 492);
            this.DrawingPanel.TabIndex = 0;
            this.DrawingPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawingPanel_Paint);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(767, 272);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(76, 39);
            this.ClearButton.TabIndex = 1;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ShapeBox
            // 
            this.ShapeBox.FormattingEnabled = true;
            this.ShapeBox.Items.AddRange(new object[] {
            "Rectangle",
            "Circle",
            "Square"});
            this.ShapeBox.Location = new System.Drawing.Point(685, 7);
            this.ShapeBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ShapeBox.Name = "ShapeBox";
            this.ShapeBox.Size = new System.Drawing.Size(77, 24);
            this.ShapeBox.TabIndex = 2;
            this.ShapeBox.Text = "Shape";
            this.ShapeBox.SelectedIndexChanged += new System.EventHandler(this.ShapeBox_SelectedIndexChanged);
            // 
            // PickShapeButton
            // 
            this.PickShapeButton.Location = new System.Drawing.Point(772, 7);
            this.PickShapeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PickShapeButton.Name = "PickShapeButton";
            this.PickShapeButton.Size = new System.Drawing.Size(69, 26);
            this.PickShapeButton.TabIndex = 3;
            this.PickShapeButton.Text = "Pick";
            this.PickShapeButton.UseVisualStyleBackColor = true;
            // 
            // RLabel
            // 
            this.RLabel.AutoSize = true;
            this.RLabel.Location = new System.Drawing.Point(696, 44);
            this.RLabel.Name = "RLabel";
            this.RLabel.Size = new System.Drawing.Size(18, 17);
            this.RLabel.TabIndex = 4;
            this.RLabel.Text = "R";
            // 
            // GreenLabel
            // 
            this.GreenLabel.AutoSize = true;
            this.GreenLabel.Location = new System.Drawing.Point(753, 44);
            this.GreenLabel.Name = "GreenLabel";
            this.GreenLabel.Size = new System.Drawing.Size(19, 17);
            this.GreenLabel.TabIndex = 5;
            this.GreenLabel.Text = "G";
            // 
            // BlueLabel
            // 
            this.BlueLabel.AutoSize = true;
            this.BlueLabel.Location = new System.Drawing.Point(811, 44);
            this.BlueLabel.Name = "BlueLabel";
            this.BlueLabel.Size = new System.Drawing.Size(17, 17);
            this.BlueLabel.TabIndex = 6;
            this.BlueLabel.Text = "B";
            this.BlueLabel.Click += new System.EventHandler(this.BLabel_Click);
            // 
            // RedTextBox
            // 
            this.RedTextBox.Location = new System.Drawing.Point(689, 63);
            this.RedTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RedTextBox.Name = "RedTextBox";
            this.RedTextBox.Size = new System.Drawing.Size(36, 22);
            this.RedTextBox.TabIndex = 7;
            this.RedTextBox.Text = "0";
            this.RedTextBox.TextChanged += new System.EventHandler(this.RTextBox_TextChanged);
            // 
            // GreenTextBox
            // 
            this.GreenTextBox.Location = new System.Drawing.Point(747, 63);
            this.GreenTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GreenTextBox.Name = "GreenTextBox";
            this.GreenTextBox.Size = new System.Drawing.Size(36, 22);
            this.GreenTextBox.TabIndex = 8;
            this.GreenTextBox.Text = "0";
            this.GreenTextBox.TextChanged += new System.EventHandler(this.GTextBox_TextChanged);
            // 
            // BlueTextBox
            // 
            this.BlueTextBox.Location = new System.Drawing.Point(804, 63);
            this.BlueTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BlueTextBox.Name = "BlueTextBox";
            this.BlueTextBox.Size = new System.Drawing.Size(36, 22);
            this.BlueTextBox.TabIndex = 9;
            this.BlueTextBox.Text = "0";
            this.BlueTextBox.TextChanged += new System.EventHandler(this.BTextBox_TextChanged);
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(683, 272);
            this.CreateButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(76, 39);
            this.CreateButton.TabIndex = 10;
            this.CreateButton.Text = "Create";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // SizeLabel
            // 
            this.SizeLabel.AutoSize = true;
            this.SizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SizeLabel.Location = new System.Drawing.Point(736, 94);
            this.SizeLabel.Name = "SizeLabel";
            this.SizeLabel.Size = new System.Drawing.Size(51, 25);
            this.SizeLabel.TabIndex = 11;
            this.SizeLabel.Text = "Size";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(27, 16);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(94, 21);
            this.radioButton1.TabIndex = 14;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Small Size";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // SelectionPanel
            // 
            this.SelectionPanel.Controls.Add(this.radioButton3);
            this.SelectionPanel.Controls.Add(this.radioButton2);
            this.SelectionPanel.Controls.Add(this.radioButton1);
            this.SelectionPanel.Location = new System.Drawing.Point(683, 121);
            this.SelectionPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SelectionPanel.Name = "SelectionPanel";
            this.SelectionPanel.Size = new System.Drawing.Size(160, 146);
            this.SelectionPanel.TabIndex = 15;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(27, 107);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(97, 21);
            this.radioButton3.TabIndex = 16;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Large Size";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(27, 62);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(109, 21);
            this.radioButton2.TabIndex = 15;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Medium SIze";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // DrawingProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 501);
            this.Controls.Add(this.SelectionPanel);
            this.Controls.Add(this.SizeLabel);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.BlueTextBox);
            this.Controls.Add(this.GreenTextBox);
            this.Controls.Add(this.RedTextBox);
            this.Controls.Add(this.BlueLabel);
            this.Controls.Add(this.GreenLabel);
            this.Controls.Add(this.RLabel);
            this.Controls.Add(this.PickShapeButton);
            this.Controls.Add(this.ShapeBox);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.DrawingPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DrawingProgram";
            this.Text = "DrawingProgram";
            this.Load += new System.EventHandler(this.DrawingProgram_Load);
            this.SelectionPanel.ResumeLayout(false);
            this.SelectionPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel DrawingPanel;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.ComboBox ShapeBox;
        private System.Windows.Forms.Button PickShapeButton;
        private System.Windows.Forms.Label RLabel;
        private System.Windows.Forms.Label GreenLabel;
        private System.Windows.Forms.Label BlueLabel;
        private System.Windows.Forms.TextBox RedTextBox;
        private System.Windows.Forms.TextBox GreenTextBox;
        private System.Windows.Forms.TextBox BlueTextBox;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Label SizeLabel;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Panel SelectionPanel;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}

