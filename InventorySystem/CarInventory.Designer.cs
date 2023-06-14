namespace InventorySystem
{
    partial class CarInventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarInventory));
            panel1 = new Panel();
            button1 = new Button();
            nameIdTB = new TextBox();
            label9 = new Label();
            label1 = new Label();
            carIdTB = new TextBox();
            label8 = new Label();
            carYearTB = new TextBox();
            label7 = new Label();
            carPriceTB = new TextBox();
            label6 = new Label();
            carColorTB = new TextBox();
            label5 = new Label();
            carModelTB = new TextBox();
            carBrandTB = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            carNameTB = new TextBox();
            carStatusTB = new TextBox();
            carPic = new PictureBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)carPic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(nameIdTB);
            panel1.Controls.Add(label9);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(705, 62);
            panel1.TabIndex = 36;
            // 
            // button1
            // 
            button1.Location = new Point(579, 28);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 38;
            button1.Text = "search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // nameIdTB
            // 
            nameIdTB.ForeColor = SystemColors.ScrollBar;
            nameIdTB.Location = new Point(406, 28);
            nameIdTB.Multiline = true;
            nameIdTB.Name = "nameIdTB";
            nameIdTB.Size = new Size(167, 23);
            nameIdTB.TabIndex = 37;
            nameIdTB.TextChanged += textBox9_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Bahnschrift", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.Azure;
            label9.Location = new Point(55, 9);
            label9.Name = "label9";
            label9.Size = new Size(231, 42);
            label9.TabIndex = 37;
            label9.Text = "Car Inventory";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(55, 75);
            label1.Name = "label1";
            label1.Size = new Size(61, 18);
            label1.TabIndex = 51;
            label1.Text = "Car Id:";
            // 
            // carIdTB
            // 
            carIdTB.Location = new Point(55, 97);
            carIdTB.Name = "carIdTB";
            carIdTB.Size = new Size(125, 23);
            carIdTB.TabIndex = 50;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(195, 246);
            label8.Name = "label8";
            label8.Size = new Size(98, 18);
            label8.TabIndex = 49;
            label8.Text = "Car Status:";
            // 
            // carYearTB
            // 
            carYearTB.Location = new Point(55, 267);
            carYearTB.Name = "carYearTB";
            carYearTB.Size = new Size(125, 23);
            carYearTB.TabIndex = 48;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(55, 246);
            label7.Name = "label7";
            label7.Size = new Size(83, 18);
            label7.TabIndex = 47;
            label7.Text = "Car Year:";
            // 
            // carPriceTB
            // 
            carPriceTB.Location = new Point(195, 211);
            carPriceTB.Name = "carPriceTB";
            carPriceTB.Size = new Size(125, 23);
            carPriceTB.TabIndex = 46;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(195, 189);
            label6.Name = "label6";
            label6.Size = new Size(88, 18);
            label6.TabIndex = 45;
            label6.Text = "Car Price:";
            // 
            // carColorTB
            // 
            carColorTB.Location = new Point(195, 154);
            carColorTB.Name = "carColorTB";
            carColorTB.Size = new Size(125, 23);
            carColorTB.TabIndex = 44;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(195, 132);
            label5.Name = "label5";
            label5.Size = new Size(89, 18);
            label5.TabIndex = 43;
            label5.Text = "Car Color:";
            // 
            // carModelTB
            // 
            carModelTB.Location = new Point(195, 97);
            carModelTB.Name = "carModelTB";
            carModelTB.Size = new Size(125, 23);
            carModelTB.TabIndex = 42;
            // 
            // carBrandTB
            // 
            carBrandTB.Location = new Point(55, 211);
            carBrandTB.Name = "carBrandTB";
            carBrandTB.Size = new Size(125, 23);
            carBrandTB.TabIndex = 41;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(195, 75);
            label4.Name = "label4";
            label4.Size = new Size(93, 18);
            label4.TabIndex = 40;
            label4.Text = "Car Model:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(55, 189);
            label3.Name = "label3";
            label3.Size = new Size(95, 18);
            label3.TabIndex = 39;
            label3.Text = "Car Brand:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(55, 132);
            label2.Name = "label2";
            label2.Size = new Size(92, 18);
            label2.TabIndex = 38;
            label2.Text = "Car Name:";
            // 
            // carNameTB
            // 
            carNameTB.Location = new Point(55, 154);
            carNameTB.Name = "carNameTB";
            carNameTB.Size = new Size(125, 23);
            carNameTB.TabIndex = 37;
            // 
            // carStatusTB
            // 
            carStatusTB.Location = new Point(195, 267);
            carStatusTB.Name = "carStatusTB";
            carStatusTB.Size = new Size(125, 23);
            carStatusTB.TabIndex = 52;
            // 
            // carPic
            // 
            carPic.BackColor = Color.DarkSlateGray;
            carPic.Location = new Point(406, 86);
            carPic.Name = "carPic";
            carPic.Size = new Size(248, 215);
            carPic.SizeMode = PictureBoxSizeMode.Zoom;
            carPic.TabIndex = 53;
            carPic.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(6, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(52, 31);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 54;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // CarInventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(705, 365);
            Controls.Add(carPic);
            Controls.Add(carStatusTB);
            Controls.Add(label1);
            Controls.Add(carIdTB);
            Controls.Add(label8);
            Controls.Add(carYearTB);
            Controls.Add(label7);
            Controls.Add(carPriceTB);
            Controls.Add(label6);
            Controls.Add(carColorTB);
            Controls.Add(label5);
            Controls.Add(carModelTB);
            Controls.Add(carBrandTB);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(carNameTB);
            Controls.Add(panel1);
            Name = "CarInventory";
            Text = "CarInventory";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)carPic).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Label label9;
        private TextBox nameIdTB;
        private Label label1;
        private TextBox carIdTB;
        private Label label8;
        private TextBox carYearTB;
        private Label label7;
        private TextBox carPriceTB;
        private Label label6;
        private TextBox carColorTB;
        private Label label5;
        private TextBox carModelTB;
        private TextBox carBrandTB;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox carNameTB;
        private TextBox carStatusTB;
        private Button button1;
        private PictureBox carPic;
        private PictureBox pictureBox1;
    }
}