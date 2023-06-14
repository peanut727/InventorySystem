namespace InventorySystem
{
    partial class customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(customer));
            label11 = new Label();
            ciDeditTB = new TextBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label10 = new Label();
            button3 = new Button();
            button2 = new Button();
            label9 = new Label();
            idTB = new TextBox();
            button1 = new Button();
            addressTB = new TextBox();
            label7 = new Label();
            label5 = new Label();
            ageTB = new TextBox();
            phoneTB = new TextBox();
            label4 = new Label();
            label3 = new Label();
            delID = new TextBox();
            label2 = new Label();
            label1 = new Label();
            nameTB = new TextBox();
            carDGV = new DataGridView();
            cDOB = new DateTimePicker();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)carDGV).BeginInit();
            SuspendLayout();
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(695, 424);
            label11.Name = "label11";
            label11.Size = new Size(30, 18);
            label11.TabIndex = 52;
            label11.Text = "ID:";
            // 
            // ciDeditTB
            // 
            ciDeditTB.Location = new Point(695, 445);
            ciDeditTB.Name = "ciDeditTB";
            ciDeditTB.Size = new Size(103, 23);
            ciDeditTB.TabIndex = 51;
            ciDeditTB.TextChanged += ciDeditTB_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label10);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1056, 62);
            panel1.TabIndex = 50;
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
            label10.Size = new Size(383, 42);
            label10.TabIndex = 38;
            label10.Text = "Customer Management";
            // 
            // button3
            // 
            button3.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(777, 313);
            button3.Name = "button3";
            button3.Size = new Size(125, 34);
            button3.TabIndex = 48;
            button3.Text = "Add";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(893, 474);
            button2.Name = "button2";
            button2.Size = new Size(103, 34);
            button2.TabIndex = 47;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(682, 91);
            label9.Name = "label9";
            label9.Size = new Size(30, 18);
            label9.TabIndex = 46;
            label9.Text = "ID:";
            // 
            // idTB
            // 
            idTB.Location = new Point(682, 113);
            idTB.Name = "idTB";
            idTB.Size = new Size(125, 23);
            idTB.TabIndex = 45;
            // 
            // button1
            // 
            button1.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(695, 474);
            button1.Name = "button1";
            button1.Size = new Size(103, 34);
            button1.TabIndex = 44;
            button1.Text = "Edit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // addressTB
            // 
            addressTB.Location = new Point(822, 224);
            addressTB.Multiline = true;
            addressTB.Name = "addressTB";
            addressTB.Size = new Size(191, 71);
            addressTB.TabIndex = 42;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(822, 202);
            label7.Name = "label7";
            label7.Size = new Size(80, 18);
            label7.TabIndex = 41;
            label7.Text = "Address:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(822, 145);
            label5.Name = "label5";
            label5.Size = new Size(113, 18);
            label5.TabIndex = 37;
            label5.Text = "Date of Birth:";
            // 
            // ageTB
            // 
            ageTB.Location = new Point(822, 113);
            ageTB.Name = "ageTB";
            ageTB.Size = new Size(125, 23);
            ageTB.TabIndex = 36;
            // 
            // phoneTB
            // 
            phoneTB.Location = new Point(682, 224);
            phoneTB.Name = "phoneTB";
            phoneTB.Size = new Size(125, 23);
            phoneTB.TabIndex = 35;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(822, 91);
            label4.Name = "label4";
            label4.Size = new Size(45, 18);
            label4.TabIndex = 34;
            label4.Text = "Age:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(682, 202);
            label3.Name = "label3";
            label3.Size = new Size(64, 18);
            label3.TabIndex = 33;
            label3.Text = "Phone:";
            // 
            // delID
            // 
            delID.Location = new Point(893, 445);
            delID.Name = "delID";
            delID.Size = new Size(103, 23);
            delID.TabIndex = 32;
            delID.TextChanged += delID_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(893, 424);
            label2.Name = "label2";
            label2.Size = new Size(30, 18);
            label2.TabIndex = 31;
            label2.Text = "ID:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(682, 145);
            label1.Name = "label1";
            label1.Size = new Size(59, 18);
            label1.TabIndex = 30;
            label1.Text = "Name:";
            // 
            // nameTB
            // 
            nameTB.Location = new Point(682, 167);
            nameTB.Name = "nameTB";
            nameTB.Size = new Size(125, 23);
            nameTB.TabIndex = 29;
            // 
            // carDGV
            // 
            carDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            carDGV.Location = new Point(12, 83);
            carDGV.Name = "carDGV";
            carDGV.RowTemplate.Height = 25;
            carDGV.Size = new Size(621, 550);
            carDGV.TabIndex = 28;
            // 
            // cDOB
            // 
            cDOB.Location = new Point(822, 167);
            cDOB.Name = "cDOB";
            cDOB.Size = new Size(191, 23);
            cDOB.TabIndex = 53;
            // 
            // customer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1056, 662);
            Controls.Add(cDOB);
            Controls.Add(label11);
            Controls.Add(ciDeditTB);
            Controls.Add(panel1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label9);
            Controls.Add(idTB);
            Controls.Add(button1);
            Controls.Add(addressTB);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(ageTB);
            Controls.Add(phoneTB);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(delID);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(nameTB);
            Controls.Add(carDGV);
            Name = "customer";
            Text = "customer";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)carDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label11;
        private TextBox ciDeditTB;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label10;
        private Button button3;
        private Button button2;
        private Label label9;
        private TextBox idTB;
        private Button button1;
        private TextBox addressTB;
        private Label label7;
        private Label label5;
        private TextBox ageTB;
        private TextBox phoneTB;
        private Label label4;
        private Label label3;
        private TextBox delID;
        private Label label2;
        private Label label1;
        private TextBox nameTB;
        private DataGridView carDGV;
        private DateTimePicker cDOB;
    }
}