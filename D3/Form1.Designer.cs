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
            DGV = new DataGridView();
            groupBox1 = new GroupBox();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            Catagory_comboBox = new ComboBox();
            Quantity_Input = new TextBox();
            Price_Input = new TextBox();
            Name_Input = new TextBox();
            Show_Button = new Button();
            Search_Button = new Button();
            Destroy_Button = new Button();
            Delete_Product_Button = new Button();
            null4 = new Label();
            null3 = new Label();
            null2 = new Label();
            null1 = new Label();
            Add_Product_Button = new Button();
            Export_Button = new Button();
            Import_Button = new Button();
            Sell_Button = new Button();
            Quantity = new Label();
            label5 = new Label();
            Catagory = new Label();
            Name = new Label();
            Price = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)DGV).BeginInit();
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
            // DGV
            // 
            DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV.Location = new Point(373, 61);
            DGV.Name = "DGV";
            DGV.Size = new Size(477, 399);
            DGV.TabIndex = 1;
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
            groupBox1.Controls.Add(Show_Button);
            groupBox1.Controls.Add(Search_Button);
            groupBox1.Controls.Add(Destroy_Button);
            groupBox1.Controls.Add(Delete_Product_Button);
            groupBox1.Controls.Add(null4);
            groupBox1.Controls.Add(null3);
            groupBox1.Controls.Add(null2);
            groupBox1.Controls.Add(null1);
            groupBox1.Controls.Add(Add_Product_Button);
            groupBox1.Controls.Add(Export_Button);
            groupBox1.Controls.Add(Import_Button);
            groupBox1.Controls.Add(Sell_Button);
            groupBox1.Controls.Add(Quantity);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(Catagory);
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
            // Show_Button
            // 
            Show_Button.Location = new Point(158, 355);
            Show_Button.Name = "Show_Button";
            Show_Button.Size = new Size(110, 23);
            Show_Button.TabIndex = 19;
            Show_Button.Text = "แสดงสินค้าทั้งหมด";
            Show_Button.UseVisualStyleBackColor = true;
            // 
            // Search_Button
            // 
            Search_Button.Location = new Point(6, 355);
            Search_Button.Name = "Search_Button";
            Search_Button.Size = new Size(118, 23);
            Search_Button.TabIndex = 18;
            Search_Button.Text = "ค้นหา";
            Search_Button.UseVisualStyleBackColor = true;
            // 
            // Destroy_Button
            // 
            Destroy_Button.Location = new Point(158, 313);
            Destroy_Button.Name = "Destroy_Button";
            Destroy_Button.Size = new Size(75, 23);
            Destroy_Button.TabIndex = 17;
            Destroy_Button.Text = "ล้าง";
            Destroy_Button.UseVisualStyleBackColor = true;
            // 
            // Delete_Product_Button
            // 
            Delete_Product_Button.Location = new Point(6, 313);
            Delete_Product_Button.Name = "Delete_Product_Button";
            Delete_Product_Button.Size = new Size(75, 23);
            Delete_Product_Button.TabIndex = 16;
            Delete_Product_Button.Text = "ลบสินค้า";
            Delete_Product_Button.UseVisualStyleBackColor = true;
            // 
            // null4
            // 
            null4.AutoSize = true;
            null4.Location = new Point(87, 275);
            null4.Name = "null4";
            null4.Size = new Size(37, 15);
            null4.TabIndex = 15;
            null4.Text = "จำนวน";
            // 
            // null3
            // 
            null3.AutoSize = true;
            null3.Location = new Point(87, 237);
            null3.Name = "null3";
            null3.Size = new Size(37, 15);
            null3.TabIndex = 14;
            null3.Text = "จำนวน";
            // 
            // null2
            // 
            null2.AutoSize = true;
            null2.Location = new Point(87, 197);
            null2.Name = "null2";
            null2.Size = new Size(37, 15);
            null2.TabIndex = 13;
            null2.Text = "จำนวน";
            // 
            // null1
            // 
            null1.AutoSize = true;
            null1.Location = new Point(87, 157);
            null1.Name = "null1";
            null1.Size = new Size(37, 15);
            null1.TabIndex = 12;
            null1.Text = "จำนวน";
            // 
            // Add_Product_Button
            // 
            Add_Product_Button.Location = new Point(6, 271);
            Add_Product_Button.Name = "Add_Product_Button";
            Add_Product_Button.Size = new Size(75, 23);
            Add_Product_Button.TabIndex = 11;
            Add_Product_Button.Text = "เพิ่มสินค้า";
            Add_Product_Button.UseVisualStyleBackColor = true;
            // 
            // Export_Button
            // 
            Export_Button.Location = new Point(6, 233);
            Export_Button.Name = "Export_Button";
            Export_Button.Size = new Size(75, 23);
            Export_Button.TabIndex = 10;
            Export_Button.Text = "ส่งออก";
            Export_Button.UseVisualStyleBackColor = true;
            // 
            // Import_Button
            // 
            Import_Button.Location = new Point(6, 193);
            Import_Button.Name = "Import_Button";
            Import_Button.Size = new Size(75, 23);
            Import_Button.TabIndex = 9;
            Import_Button.Text = "นำเข้า";
            Import_Button.UseVisualStyleBackColor = true;
            // 
            // Sell_Button
            // 
            Sell_Button.Location = new Point(6, 153);
            Sell_Button.Name = "Sell_Button";
            Sell_Button.Size = new Size(75, 23);
            Sell_Button.TabIndex = 8;
            Sell_Button.Text = "ขาย";
            Sell_Button.UseVisualStyleBackColor = true;
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
            // Catagory
            // 
            Catagory.AutoSize = true;
            Catagory.Location = new Point(6, 63);
            Catagory.Name = "Catagory";
            Catagory.Size = new Size(40, 15);
            Catagory.TabIndex = 4;
            Catagory.Text = "ประเภท";
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
            // button1
            // 
            button1.Location = new Point(18, 466);
            button1.Name = "button1";
            button1.Size = new Size(262, 55);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(902, 533);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(DGV);
            Controls.Add(Title);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)DGV).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private DataGridView DGV;
        private GroupBox groupBox1;
        private Label label5;
        private Label Price;
        private Label Catagory;
        private Label Name;
        private Label Quantity;
        private Button Add_Product_Button;
        private Button Export_Button;
        private Button Import_Button;
        private Button Sell_Button;
        private Button Show_Button;
        private Button Search_Button;
        private Button Destroy_Button;
        private Button Delete_Product_Button;
        private Label null4;
        private Label null3;
        private Label null2;
        private Label null1;
        private TextBox textBox5;
        private TextBox textBox4;
        private ComboBox Catagory_comboBox;
        private TextBox Quantity_Input;
        private TextBox Price_Input;
        private TextBox Name_Input;
        private TextBox textBox7;
        private TextBox textBox6;
        private Button button1;
    }
}
