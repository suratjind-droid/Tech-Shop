namespace D3
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
            Title = new Label();
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            Catagory_comboBox = new ComboBox();
            Quantity_Input = new TextBox();
            Price_Input = new TextBox();
            Name_Input = new TextBox();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            Quantity = new Label();
            label5 = new Label();
            catagory = new Label();
            Name = new Label();
            Price = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Leelawadee UI", 20F);
            Title.Location = new Point(12, 9);
            Title.Name = "Title";
            Title.Size = new Size(152, 37);
            Title.TabIndex = 0;
            Title.Text = "Music store";
            Title.Click += label1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(373, 61);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(477, 399);
            dataGridView1.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox7);
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(Catagory_comboBox);
            groupBox1.Controls.Add(Quantity_Input);
            groupBox1.Controls.Add(Price_Input);
            groupBox1.Controls.Add(Name_Input);
            groupBox1.Controls.Add(button8);
            groupBox1.Controls.Add(button7);
            groupBox1.Controls.Add(button6);
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(Quantity);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(catagory);
            groupBox1.Controls.Add(Name);
            groupBox1.Controls.Add(Price);
            groupBox1.Location = new Point(12, 61);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(283, 399);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "ข้อมูลสินค้า";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(130, 272);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(103, 23);
            textBox7.TabIndex = 27;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(130, 233);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(103, 23);
            textBox6.TabIndex = 26;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(130, 194);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(103, 23);
            textBox5.TabIndex = 25;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(130, 154);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(103, 23);
            textBox4.TabIndex = 24;
            // 
            // Catagory_comboBox
            // 
            Catagory_comboBox.FormattingEnabled = true;
            Catagory_comboBox.Items.AddRange(new object[] { "เครื่องสาย", "เครื่องเป่าลมไม้", "เครื่องเป่าลมทองเหลือง", "เครื่องกระทบ", "เครื่องลิ่มนิ้ว" });
            Catagory_comboBox.Location = new Point(74, 58);
            Catagory_comboBox.Name = "Catagory_comboBox";
            Catagory_comboBox.Size = new Size(148, 23);
            Catagory_comboBox.TabIndex = 23;
            // 
            // Quantity_Input
            // 
            Quantity_Input.Location = new Point(74, 122);
            Quantity_Input.Name = "Quantity_Input";
            Quantity_Input.Size = new Size(148, 23);
            Quantity_Input.TabIndex = 22;
            // 
            // Price_Input
            // 
            Price_Input.Location = new Point(74, 90);
            Price_Input.Name = "Price_Input";
            Price_Input.Size = new Size(148, 23);
            Price_Input.TabIndex = 21;
            Price_Input.TextChanged += textBox2_TextChanged;
            // 
            // Name_Input
            // 
            Name_Input.Location = new Point(74, 29);
            Name_Input.Name = "Name_Input";
            Name_Input.Size = new Size(148, 23);
            Name_Input.TabIndex = 20;
            Name_Input.Enter += label1_Click;
            // 
            // button8
            // 
            button8.Location = new Point(158, 355);
            button8.Name = "button8";
            button8.Size = new Size(110, 23);
            button8.TabIndex = 19;
            button8.Text = "แสดงสินค้าทั้งหมด";
            button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(6, 355);
            button7.Name = "button7";
            button7.Size = new Size(118, 23);
            button7.TabIndex = 18;
            button7.Text = "ค้นหา";
            button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(158, 313);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 17;
            button6.Text = "ล้าง";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(6, 313);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 16;
            button5.Text = "ลบสินค้า";
            button5.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(87, 275);
            label10.Name = "label10";
            label10.Size = new Size(37, 15);
            label10.TabIndex = 15;
            label10.Text = "จำนวน";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(87, 237);
            label9.Name = "label9";
            label9.Size = new Size(37, 15);
            label9.TabIndex = 14;
            label9.Text = "จำนวน";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(87, 197);
            label8.Name = "label8";
            label8.Size = new Size(37, 15);
            label8.TabIndex = 13;
            label8.Text = "จำนวน";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(87, 157);
            label7.Name = "label7";
            label7.Size = new Size(37, 15);
            label7.TabIndex = 12;
            label7.Text = "จำนวน";
            // 
            // button4
            // 
            button4.Location = new Point(6, 271);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 11;
            button4.Text = "เพิ่มสินค้า";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(6, 233);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 10;
            button3.Text = "ส่งออก";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(6, 193);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 9;
            button2.Text = "นำเข้า";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(6, 153);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "ขาย";
            button1.UseVisualStyleBackColor = true;
            // 
            // Quantity
            // 
            Quantity.AutoSize = true;
            Quantity.Location = new Point(6, 125);
            Quantity.Name = "Quantity";
            Quantity.Size = new Size(62, 15);
            Quantity.TabIndex = 7;
            Quantity.Text = "จำนวนสินค้า";
            Quantity.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 125);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 6;
            // 
            // catagory
            // 
            catagory.AutoSize = true;
            catagory.Location = new Point(6, 63);
            catagory.Name = "catagory";
            catagory.Size = new Size(40, 15);
            catagory.TabIndex = 4;
            catagory.Text = "ประเภท";
            // 
            // Name
            // 
            Name.AutoSize = true;
            Name.Location = new Point(6, 32);
            Name.Name = "Name";
            Name.Size = new Size(45, 15);
            Name.TabIndex = 3;
            Name.Text = "ชื่อสินค้า";
            // 
            // Price
            // 
            Price.AutoSize = true;
            Price.Location = new Point(6, 93);
            Price.Name = "Price";
            Price.Size = new Size(29, 15);
            Price.TabIndex = 5;
            Price.Text = "ราคา";
            Price.Click += label4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(902, 533);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(Title);
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Label label5;
        private Label Price;
        private Label catagory;
        private Label Name;
        private Label Quantity;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private TextBox textBox5;
        private TextBox textBox4;
        private ComboBox Catagory_comboBox;
        private TextBox Quantity_Input;
        private TextBox Price_Input;
        private TextBox Name_Input;
        private TextBox textBox7;
        private TextBox textBox6;
    }
}
