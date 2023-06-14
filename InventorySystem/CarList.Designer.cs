namespace InventorySystem
{
    partial class CarList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarList));
            carDGV = new DataGridView();
            carNameTB = new TextBox();
            label1 = new Label();
            label2 = new Label();
            CIDTB = new TextBox();
            label3 = new Label();
            label4 = new Label();
            carBrandTB = new TextBox();
            carModelTB = new TextBox();
            carColorTB = new TextBox();
            label5 = new Label();
            carPriceTB = new TextBox();
            label6 = new Label();
            carYearTB = new TextBox();
            label7 = new Label();
            label8 = new Label();
            button1 = new Button();
            label9 = new Label();
            carIdTB = new TextBox();
            button2 = new Button();
            button3 = new Button();
            carStatusTB = new ComboBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label10 = new Label();
            carPicB = new PictureBox();
            button4 = new Button();
            ciDeditTB = new TextBox();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)carDGV).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)carPicB).BeginInit();
            SuspendLayout();
            // 
            // carDGV
            // 
            carDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            carDGV.Location = new Point(12, 68);
            carDGV.Name = "carDGV";
            carDGV.RowTemplate.Height = 25;
            carDGV.Size = new Size(839, 550);
            carDGV.TabIndex = 0;
            
            // 
            // carNameTB
            // 
            carNameTB.Location = new Point(860, 160);
            carNameTB.Name = "carNameTB";
            carNameTB.Size = new Size(125, 23);
            carNameTB.TabIndex = 1;
            
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(860, 138);
            label1.Name = "label1";
            label1.Size = new Size(92, 18);
            label1.TabIndex = 2;
            label1.Text = "Car Name:";
           
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(882, 474);
            label2.Name = "label2";
            label2.Size = new Size(61, 18);
            label2.TabIndex = 3;
            label2.Text = "Car Id:";
          
            // 
            // CIDTB
            // 
            CIDTB.Location = new Point(882, 496);
            CIDTB.Name = "CIDTB";
            CIDTB.Size = new Size(256, 23);
            CIDTB.TabIndex = 4;
            
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(860, 195);
            label3.Name = "label3";
            label3.Size = new Size(95, 18);
            label3.TabIndex = 5;
            label3.Text = "Car Brand:";
            
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(1000, 90);
            label4.Name = "label4";
            label4.Size = new Size(93, 18);
            label4.TabIndex = 6;
            label4.Text = "Car Model:";
           
            // 
            // carBrandTB
            // 
            carBrandTB.Location = new Point(860, 217);
            carBrandTB.Name = "carBrandTB";
            carBrandTB.Size = new Size(125, 23);
            carBrandTB.TabIndex = 7;
            
            // 
            // carModelTB
            // 
            carModelTB.Location = new Point(1000, 112);
            carModelTB.Name = "carModelTB";
            carModelTB.Size = new Size(125, 23);
            carModelTB.TabIndex = 8;
            
            // 
            // carColorTB
            // 
            carColorTB.Location = new Point(1000, 160);
            carColorTB.Name = "carColorTB";
            carColorTB.Size = new Size(125, 23);
            carColorTB.TabIndex = 10;
            
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(1000, 138);
            label5.Name = "label5";
            label5.Size = new Size(89, 18);
            label5.TabIndex = 9;
            label5.Text = "Car Color:";
            
            // 
            // carPriceTB
            // 
            carPriceTB.Location = new Point(1000, 217);
            carPriceTB.Name = "carPriceTB";
            carPriceTB.Size = new Size(125, 23);
            carPriceTB.TabIndex = 12;
            
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(1000, 195);
            label6.Name = "label6";
            label6.Size = new Size(88, 18);
            label6.TabIndex = 11;
            label6.Text = "Car Price:";
           
            // 
            // carYearTB
            // 
            carYearTB.Location = new Point(860, 275);
            carYearTB.Name = "carYearTB";
            carYearTB.Size = new Size(125, 23);
            carYearTB.TabIndex = 14;
            
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(860, 253);
            label7.Name = "label7";
            label7.Size = new Size(83, 18);
            label7.TabIndex = 13;
            label7.Text = "Car Year:";
            
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(1000, 253);
            label8.Name = "label8";
            label8.Size = new Size(98, 18);
            label8.TabIndex = 15;
            label8.Text = "Car Status:";
            
            // 
            // button1
            // 
            button1.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(882, 432);
            button1.Name = "button1";
            button1.Size = new Size(256, 34);
            button1.TabIndex = 17;
            button1.Text = "Edit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(860, 90);
            label9.Name = "label9";
            label9.Size = new Size(61, 18);
            label9.TabIndex = 19;
            label9.Text = "Car Id:";
            
            // 
            // carIdTB
            // 
            carIdTB.Location = new Point(860, 112);
            carIdTB.Name = "carIdTB";
            carIdTB.Size = new Size(125, 23);
            carIdTB.TabIndex = 18;
            
            // 
            // button2
            // 
            button2.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(882, 525);
            button2.Name = "button2";
            button2.Size = new Size(256, 34);
            button2.TabIndex = 20;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(938, 314);
            button3.Name = "button3";
            button3.Size = new Size(125, 34);
            button3.TabIndex = 21;
            button3.Text = "Add";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // carStatusTB
            // 
            carStatusTB.FormattingEnabled = true;
            carStatusTB.Items.AddRange(new object[] { "Available", "Not Available", "Bought" });
            carStatusTB.Location = new Point(1000, 274);
            carStatusTB.Name = "carStatusTB";
            carStatusTB.Size = new Size(125, 23);
            carStatusTB.TabIndex = 22;
            
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label10);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1448, 62);
            panel1.TabIndex = 23;
            
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(6, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(52, 31);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 55;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Bahnschrift", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.Azure;
            label10.Location = new Point(54, 9);
            label10.Name = "label10";
            label10.Size = new Size(378, 42);
            label10.TabIndex = 38;
            label10.Text = "Inventory Management";
            // 
            // carPicB
            // 
            carPicB.BackColor = Color.DarkSlateGray;
            carPicB.Location = new Point(1207, 90);
            carPicB.Name = "carPicB";
            carPicB.Size = new Size(210, 185);
            carPicB.SizeMode = PictureBoxSizeMode.Zoom;
            carPicB.TabIndex = 24;
            carPicB.TabStop = false;
            // 
            // button4
            // 
            button4.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(1255, 281);
            button4.Name = "button4";
            button4.Size = new Size(125, 34);
            button4.TabIndex = 25;
            button4.Text = "Add";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // ciDeditTB
            // 
            ciDeditTB.Location = new Point(882, 403);
            ciDeditTB.Name = "ciDeditTB";
            ciDeditTB.Size = new Size(256, 23);
            ciDeditTB.TabIndex = 26;
            ciDeditTB.TextChanged += ciDeditTB_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(882, 382);
            label11.Name = "label11";
            label11.Size = new Size(61, 18);
            label11.TabIndex = 27;
            label11.Text = "Car Id:";
            
            // 
            // CarList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1448, 630);
            Controls.Add(label11);
            Controls.Add(ciDeditTB);
            Controls.Add(button4);
            Controls.Add(carPicB);
            Controls.Add(panel1);
            Controls.Add(carStatusTB);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label9);
            Controls.Add(carIdTB);
            Controls.Add(button1);
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
            Controls.Add(CIDTB);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(carNameTB);
            Controls.Add(carDGV);
            Name = "CarList";
            Text = "CarList";
            ((System.ComponentModel.ISupportInitialize)carDGV).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)carPicB).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView carDGV;
        private TextBox carNameTB;
        private Label label1;
        private Label label2;
        private TextBox CIDTB;
        private Label label3;
        private Label label4;
        private TextBox carBrandTB;
        private TextBox carModelTB;
        private TextBox carColorTB;
        private Label label5;
        private TextBox carPriceTB;
        private Label label6;
        private TextBox carYearTB;
        private Label label7;
        private Label label8;
        private Button button1;
        private Label label9;
        private TextBox carIdTB;
        private Button button2;
        private Button button3;
        private ComboBox carStatusTB;
        private Panel panel1;
        private Label label10;
        private PictureBox carPicB;
        private Button button4;
        private PictureBox pictureBox1;
        private TextBox ciDeditTB;
        private Label label11;
    }
}