using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using barkod.Classes;


namespace barkod
{
    public partial class AdminKategoriIslemlerics : Form
    {
        public AdminKategoriIslemlerics()
        {
            InitializeComponent();
        }

        public void LoadCategories()
        {
         SqlCommand commandListCategories = new SqlCommand("Select * from TableCategory", sqlConnectionClass.connect);

            sqlConnectionClass.CheckConnection(sqlConnectionClass.connect);

            SqlDataAdapter da = new SqlDataAdapter(commandListCategories);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }
        private void AdminKategoriIslemlerics_Load(object sender, EventArgs e)
        {
            LoadCategories();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            SqlCommand commandAddCategory = new SqlCommand("Insert into TableCategory (CategoryName) values(@name)", sqlConnectionClass.connect);

            sqlConnectionClass.CheckConnection(sqlConnectionClass.connect);

            commandAddCategory.Parameters.AddWithValue("@name", tboxCategoryName.Text);

            commandAddCategory.ExecuteNonQuery();

            LoadCategories();
                
        }

        string SelectedID;
        private void btnCategoryDelete_Click(object sender, EventArgs e)
        {
            SqlCommand commandDelete = new SqlCommand("Delete from TableCategory where CategoryID=@pid",sqlConnectionClass.connect);

            sqlConnectionClass.CheckConnection (sqlConnectionClass.connect);

            commandDelete.Parameters.AddWithValue("@pid",Convert.ToInt32(SelectedID));

            commandDelete.ExecuteNonQuery();

            LoadCategories();

            MessageBox.Show("Veri Başarıyla Silindi ");
        }
        
        private void dataGridView1_SeletionChanged(object sender, EventArgs e)
        {
            SelectedID = dataGridView1.CurrentRow.Cells["CategoryID"].Value.ToString();
            lblSlectedID.Text = SelectedID;
        }

        private void btnMW_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 newForm = new Form1();
            newForm.Show();
        }
    }
}
