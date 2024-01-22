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
using AForge.Video.DirectShow;
using AForge.Video.DirectShow;
using ZXing;

namespace barkod
{
    public partial class AdminUrunIslemleri : Form
    {
        public AdminUrunIslemleri()
        {
            InitializeComponent();
        }

        public  void LoadProducts()
        {
            SqlCommand commandList = new SqlCommand("Select ProductID,ProductPrice,ProductName,ProductBarcode,CategoryName from TableProduct inner join TableCategory on TableProduct.ProductCategory = TableCategory.CategoryID", sqlConnectionClass.connect);

            sqlConnectionClass.CheckConnection(sqlConnectionClass.connect);

            SqlDataAdapter da = new SqlDataAdapter(commandList);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dgProduct.DataSource = dt;
        }

        public void LoadCategories() 
        {
            SqlCommand commandLoadCategories = new SqlCommand("Select * from TableCategory",sqlConnectionClass.connect);

            sqlConnectionClass.CheckConnection(sqlConnectionClass.connect);

            
            cmbBoxCategory.DisplayMember = "CategoryName";

            cmbBoxCategory.ValueMember = "CategoryID";

            SqlDataAdapter daLoadCategories = new SqlDataAdapter(commandLoadCategories);
      
            DataTable  dtLoadCategories = new DataTable();
            
            daLoadCategories.Fill(dtLoadCategories);

            cmbBoxCategory.DataSource = dtLoadCategories;
                
                }
       


        private void AdminUrunIslemleri_Load(object sender, EventArgs e)
        {
          LoadProducts();
            LoadCategories();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 newForm = new Form1();
            newForm.Show();
        }

       
        private void dgProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            SqlCommand commandAdd = new SqlCommand(" Insert into TableProduct (ProductName,ProductCategory,ProductPrice,ProductBarcode) values (@pname,@pcategory,@pprice,@pbarcode)",sqlConnectionClass.connect);

            sqlConnectionClass.CheckConnection(sqlConnectionClass.connect);

            commandAdd.Parameters.AddWithValue("@pname", tboxProductName.Text);
            commandAdd.Parameters.AddWithValue("@pcategory",Convert.ToInt32(cmbBoxCategory.SelectedValue));
            commandAdd.Parameters.AddWithValue("@pprice",tboxProductPrice.Text);
            commandAdd.Parameters.AddWithValue("@pbarcode",tboxProductBarcode.Text);

            commandAdd.ExecuteNonQuery();


            IncreaseCategoryCount();    
            LoadProducts();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand commandDelete = new SqlCommand("Delete from TableProduct where ProductID=@pid ",sqlConnectionClass.connect);

            sqlConnectionClass.CheckConnection(sqlConnectionClass.connect);

            commandDelete.Parameters.AddWithValue("@pid", Convert.ToInt32 (Convert.ToInt32(SelectedID)));

            commandDelete.ExecuteNonQuery();

            DecreaseCategoryCount();

            LoadProducts();

            MessageBox.Show("Ürün Başarıyla Silindi");

        }

        string SelectedID;
        private void dgProduct_SelectionChanged(object sender, EventArgs e)
        {
            if(dgProduct.CurrentRow== null)
            {

            }
            else
            {
                SelectedID = dgProduct.CurrentRow.Cells["ProductID"].Value.ToString();
                lblSelectedID.Text = SelectedID;
            }

        }
        public  void IncreaseCategoryCount()
        {
            SqlCommand commandIncrease = new SqlCommand("update TableCategory set CategoryCount+=1 where CategoryID=@pid",sqlConnectionClass.connect);
        
            sqlConnectionClass.CheckConnection (sqlConnectionClass.connect);

            commandIncrease.Parameters.AddWithValue("@pid", Convert.ToInt32(cmbBoxCategory.SelectedValue));

            commandIncrease.ExecuteNonQuery();
        }

        public void DecreaseCategoryCount()
        {
            SqlCommand commandIncrease = new SqlCommand("update TableCategory set CategoryCount-=1 where CategoryID=@pid", sqlConnectionClass.connect);

            sqlConnectionClass.CheckConnection(sqlConnectionClass.connect);

            commandIncrease.Parameters.AddWithValue("@pid", Convert.ToInt32(cmbBoxCategory.SelectedValue));

            commandIncrease.ExecuteNonQuery();
        }



       
            
        
    }
}
