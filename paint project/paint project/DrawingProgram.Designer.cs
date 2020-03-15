namespace paint_project
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
            this.RLabel = new System.Windows.Forms.Label();
            this.GreenLabel = new System.Windows.Forms.Label();
            this.BlueLabel = new System.Windows.Forms.Label();
            this.RedTextBox = new System.Windows.Forms.TextBox();
            this.GreenTextBox = new System.Windows.Forms.TextBox();
            this.BlueTextBox = new System.Windows.Forms.TextBox();
            this.CreateButton = new System.Windows.Forms.Button();
            this.OriginCoordinateLabel = new System.Windows.Forms.Label();
            this.XCoordinatesTextBox = new System.Windows.Forms.TextBox();
            this.YCoordinatesTextBox = new System.Windows.Forms.TextBox();
            this.YCoordinatesLabel = new System.Windows.Forms.Label();
            this.XCoordinatesLabel = new System.Windows.Forms.Label();
            this.RadiusLabel = new System.Windows.Forms.Label();
            this.RadiusTextBox_Circle = new System.Windows.Forms.TextBox();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.WidthTextBox_Square = new System.Windows.Forms.TextBox();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.HeightTextBox_Rectangle = new System.Windows.Forms.TextBox();
            this.WidthTextBox_Rectangle = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DrawingPanel
            // 
            this.DrawingPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.DrawingPanel.Location = new System.Drawing.Point(2, 2);
            this.DrawingPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DrawingPanel.Name = "DrawingPanel";
            this.DrawingPanel.Size = new System.Drawing.Size(500, 400);
            this.DrawingPanel.TabIndex = 0;
            this.DrawingPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawingPanel_Paint);
            this.DrawingPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DrawingPanel_MouseDown);
            this.DrawingPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DrawingPanel_MouseMove);
            this.DrawingPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DrawingPanel_MouseUp);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(574, 181);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(57, 32);
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
            "Square",
            "Circle"});
            this.ShapeBox.Location = new System.Drawing.Point(517, 11);
            this.ShapeBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ShapeBox.Name = "ShapeBox";
            this.ShapeBox.Size = new System.Drawing.Size(111, 21);
            this.ShapeBox.TabIndex = 2;
            this.ShapeBox.Text = "Shape";
            this.ShapeBox.SelectedIndexChanged += new System.EventHandler(this.ShapeBox_SelectedIndexChanged);
            // 
            // RLabel
            // 
            this.RLabel.AutoSize = true;
            this.RLabel.Location = new System.Drawing.Point(522, 36);
            this.RLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RLabel.Name = "RLabel";
            this.RLabel.Size = new System.Drawing.Size(15, 13);
            this.RLabel.TabIndex = 4;
            this.RLabel.Text = "R";
            // 
            // GreenLabel
            // 
            this.GreenLabel.AutoSize = true;
            this.GreenLabel.Location = new System.Drawing.Point(565, 36);
            this.GreenLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GreenLabel.Name = "GreenLabel";
            this.GreenLabel.Size = new System.Drawing.Size(15, 13);
            this.GreenLabel.TabIndex = 5;
            this.GreenLabel.Text = "G";
            // 
            // BlueLabel
            // 
            this.BlueLabel.AutoSize = true;
            this.BlueLabel.Location = new System.Drawing.Point(608, 36);
            this.BlueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BlueLabel.Name = "BlueLabel";
            this.BlueLabel.Size = new System.Drawing.Size(14, 13);
            this.BlueLabel.TabIndex = 6;
            this.BlueLabel.Text = "B";
            // 
            // RedTextBox
            // 
            this.RedTextBox.Location = new System.Drawing.Point(517, 51);
            this.RedTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RedTextBox.Name = "RedTextBox";
            this.RedTextBox.Size = new System.Drawing.Size(28, 20);
            this.RedTextBox.TabIndex = 7;
            this.RedTextBox.TextChanged += new System.EventHandler(this.RTextBox_TextChanged);
            // 
            // GreenTextBox
            // 
            this.GreenTextBox.Location = new System.Drawing.Point(560, 51);
            this.GreenTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GreenTextBox.Name = "GreenTextBox";
            this.GreenTextBox.Size = new System.Drawing.Size(28, 20);
            this.GreenTextBox.TabIndex = 8;
            this.GreenTextBox.TextChanged += new System.EventHandler(this.GTextBox_TextChanged);
            // 
            // BlueTextBox
            // 
            this.BlueTextBox.Location = new System.Drawing.Point(603, 51);
            this.BlueTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BlueTextBox.Name = "BlueTextBox";
            this.BlueTextBox.Size = new System.Drawing.Size(28, 20);
            this.BlueTextBox.TabIndex = 9;
            this.BlueTextBox.TextChanged += new System.EventHandler(this.BTextBox_TextChanged);
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(511, 181);
            this.CreateButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(57, 32);
            this.CreateButton.TabIndex = 10;
            this.CreateButton.Text = "Create";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // OriginCoordinateLabel
            // 
            this.OriginCoordinateLabel.AutoSize = true;
            this.OriginCoordinateLabel.Location = new System.Drawing.Point(528, 83);
            this.OriginCoordinateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.OriginCoordinateLabel.Name = "OriginCoordinateLabel";
            this.OriginCoordinateLabel.Size = new System.Drawing.Size(93, 13);
            this.OriginCoordinateLabel.TabIndex = 11;
            this.OriginCoordinateLabel.Text = "Origin Coordinates";
            // 
            // XCoordinatesTextBox
            // 
            this.XCoordinatesTextBox.Location = new System.Drawing.Point(546, 98);
            this.XCoordinatesTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.XCoordinatesTextBox.Name = "XCoordinatesTextBox";
            this.XCoordinatesTextBox.Size = new System.Drawing.Size(22, 20);
            this.XCoordinatesTextBox.TabIndex = 12;
            this.XCoordinatesTextBox.TextChanged += new System.EventHandler(this.XCoordinate_TextChanged);
            // 
            // YCoordinatesTextBox
            // 
            this.YCoordinatesTextBox.Location = new System.Drawing.Point(588, 98);
            this.YCoordinatesTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.YCoordinatesTextBox.Name = "YCoordinatesTextBox";
            this.YCoordinatesTextBox.Size = new System.Drawing.Size(22, 20);
            this.YCoordinatesTextBox.TabIndex = 13;
            this.YCoordinatesTextBox.TextChanged += new System.EventHandler(this.YCoordinate_TextChanged);
            // 
            // YCoordinatesLabel
            // 
            this.YCoordinatesLabel.AutoSize = true;
            this.YCoordinatesLabel.Location = new System.Drawing.Point(570, 102);
            this.YCoordinatesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.YCoordinatesLabel.Name = "YCoordinatesLabel";
            this.YCoordinatesLabel.Size = new System.Drawing.Size(14, 13);
            this.YCoordinatesLabel.TabIndex = 14;
            this.YCoordinatesLabel.Text = "Y";
            // 
            // XCoordinatesLabel
            // 
            this.XCoordinatesLabel.AutoSize = true;
            this.XCoordinatesLabel.Location = new System.Drawing.Point(528, 102);
            this.XCoordinatesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.XCoordinatesLabel.Name = "XCoordinatesLabel";
            this.XCoordinatesLabel.Size = new System.Drawing.Size(14, 13);
            this.XCoordinatesLabel.TabIndex = 15;
            this.XCoordinatesLabel.Text = "X";
            // 
            // RadiusLabel
            // 
            this.RadiusLabel.AutoSize = true;
            this.RadiusLabel.Location = new System.Drawing.Point(537, 136);
            this.RadiusLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RadiusLabel.Name = "RadiusLabel";
            this.RadiusLabel.Size = new System.Drawing.Size(40, 13);
            this.RadiusLabel.TabIndex = 16;
            this.RadiusLabel.Text = "Radius";
            this.RadiusLabel.Visible = false;
            // 
            // RadiusTextBox_Circle
            // 
            this.RadiusTextBox_Circle.Location = new System.Drawing.Point(588, 133);
            this.RadiusTextBox_Circle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RadiusTextBox_Circle.Name = "RadiusTextBox_Circle";
            this.RadiusTextBox_Circle.Size = new System.Drawing.Size(22, 20);
            this.RadiusTextBox_Circle.TabIndex = 17;
            this.RadiusTextBox_Circle.Visible = false;
            this.RadiusTextBox_Circle.TextChanged += new System.EventHandler(this.CircleRadius_TextChanged);
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Location = new System.Drawing.Point(540, 136);
            this.WidthLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(35, 13);
            this.WidthLabel.TabIndex = 18;
            this.WidthLabel.Text = "Width";
            this.WidthLabel.Visible = false;
            // 
            // WidthTextBox_Square
            // 
            this.WidthTextBox_Square.Location = new System.Drawing.Point(588, 133);
            this.WidthTextBox_Square.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.WidthTextBox_Square.Name = "WidthTextBox_Square";
            this.WidthTextBox_Square.Size = new System.Drawing.Size(22, 20);
            this.WidthTextBox_Square.TabIndex = 19;
            this.WidthTextBox_Square.Visible = false;
            this.WidthTextBox_Square.TextChanged += new System.EventHandler(this.SquareWidth_TextChanged);
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Location = new System.Drawing.Point(538, 160);
            this.HeightLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(38, 13);
            this.HeightLabel.TabIndex = 20;
            this.HeightLabel.Text = "Height";
            this.HeightLabel.Visible = false;
            // 
            // HeightTextBox_Rectangle
            // 
            this.HeightTextBox_Rectangle.Location = new System.Drawing.Point(588, 157);
            this.HeightTextBox_Rectangle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.HeightTextBox_Rectangle.Name = "HeightTextBox_Rectangle";
            this.HeightTextBox_Rectangle.Size = new System.Drawing.Size(22, 20);
            this.HeightTextBox_Rectangle.TabIndex = 21;
            this.HeightTextBox_Rectangle.Visible = false;
            this.HeightTextBox_Rectangle.TextChanged += new System.EventHandler(this.RactangleHeight_TextChanged);
            // 
            // WidthTextBox_Rectangle
            // 
            this.WidthTextBox_Rectangle.Location = new System.Drawing.Point(588, 133);
            this.WidthTextBox_Rectangle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.WidthTextBox_Rectangle.Name = "WidthTextBox_Rectangle";
            this.WidthTextBox_Rectangle.Size = new System.Drawing.Size(22, 20);
            this.WidthTextBox_Rectangle.TabIndex = 22;
            this.WidthTextBox_Rectangle.Visible = false;
            this.WidthTextBox_Rectangle.TextChanged += new System.EventHandler(this.ReactangleWidth_TextChanged);
            // 
            // DrawingProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 405);
            this.Controls.Add(this.WidthTextBox_Rectangle);
            this.Controls.Add(this.HeightTextBox_Rectangle);
            this.Controls.Add(this.HeightLabel);
            this.Controls.Add(this.WidthTextBox_Square);
            this.Controls.Add(this.WidthLabel);
            this.Controls.Add(this.RadiusTextBox_Circle);
            this.Controls.Add(this.RadiusLabel);
            this.Controls.Add(this.XCoordinatesLabel);
            this.Controls.Add(this.YCoordinatesLabel);
            this.Controls.Add(this.YCoordinatesTextBox);
            this.Controls.Add(this.XCoordinatesTextBox);
            this.Controls.Add(this.OriginCoordinateLabel);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.BlueTextBox);
            this.Controls.Add(this.GreenTextBox);
            this.Controls.Add(this.RedTextBox);
            this.Controls.Add(this.BlueLabel);
            this.Controls.Add(this.GreenLabel);
            this.Controls.Add(this.RLabel);
            this.Controls.Add(this.ShapeBox);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.DrawingPanel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DrawingProgram";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DrawingProgram";
            this.Load += new System.EventHandler(this.DrawingProgram_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel DrawingPanel;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.ComboBox ShapeBox;
        private System.Windows.Forms.Label RLabel;
        private System.Windows.Forms.Label GreenLabel;
        private System.Windows.Forms.Label BlueLabel;
        private System.Windows.Forms.TextBox RedTextBox;
        private System.Windows.Forms.TextBox GreenTextBox;
        private System.Windows.Forms.TextBox BlueTextBox;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Label OriginCoordinateLabel;
        private System.Windows.Forms.TextBox XCoordinatesTextBox;
        private System.Windows.Forms.TextBox YCoordinatesTextBox;
        private System.Windows.Forms.Label YCoordinatesLabel;
        private System.Windows.Forms.Label XCoordinatesLabel;
        private System.Windows.Forms.Label RadiusLabel;
        private System.Windows.Forms.TextBox RadiusTextBox_Circle;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.TextBox WidthTextBox_Square;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.TextBox HeightTextBox_Rectangle;
        private System.Windows.Forms.TextBox WidthTextBox_Rectangle;
    }
}

