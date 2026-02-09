using System;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace D3
{
    public partial class Form1 : Form
    {
        private readonly string connString = "Data Source=db/database.db;Version=3;";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                CheckAndCreateDatabase();
                LoadUserData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error โหลดฟอร์ม: {ex.Message}", "ข้อผิดพลาด",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CheckAndCreateDatabase()
        {
            try
            {
                const string dbPath = "db/database.db";
                Directory.CreateDirectory(Path.GetDirectoryName(dbPath) ?? string.Empty);

                if (!File.Exists(dbPath))
                {
                    SQLiteConnection.CreateFile(dbPath);
                    using var conn = new SQLiteConnection(connString);
                    conn.Open();

                    const string createTableSQL = """
                        CREATE TABLE userData (
                            userId INTEGER PRIMARY KEY AUTOINCREMENT,
                            name TEXT NOT NULL,
                            password TEXT NOT NULL,
                            catagory TEXT,
                            price INTEGER,
                            quantity INTEGER
                        )
                        """;

                    const string sampleDataSQL = """
                        INSERT INTO userData (name, catagory, price, quantity) 
                        VALUES ('guitar', 'เครื่องสาย', '15,000', '1')
                        """;

                    using var cmd = new SQLiteCommand(createTableSQL, conn);
                    cmd.ExecuteNonQuery();

                    using var cmd2 = new SQLiteCommand(sampleDataSQL, conn);
                    cmd2.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error สร้างฐานข้อมูล: {ex.Message}", "ข้อผิดพลาด",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadUserData()
        {
            try
            {
                const string loadSQL = "SELECT * FROM userData ORDER BY userId";
                using var conn = new SQLiteConnection(connString);
                using var adapter = new SQLiteDataAdapter(loadSQL, conn);

                var table = new DataTable();
                adapter.Fill(table);
                DGV.DataSource = table;

                DGV.RowHeadersVisible = false;
                AutoSizeColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error โหลดข้อมูล: {ex.Message}", "ข้อผิดพลาด",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AutoSizeColumns()
        {
            foreach (DataGridViewColumn col in DGV.Columns)
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void ClearTextBoxes()
        {
            try
            {
                Name_Input.Clear();
                Catagory_comboBox.Clear();
                Price_Input.Clear();
                Quantity_Input.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error ล้างข้อมูล: {ex.Message}", "ข้อผิดพลาด",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}