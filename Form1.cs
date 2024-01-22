using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video.DirectShow;
using ZXing;
using System.Data.SqlClient;
using barkod.Classes;


namespace barkod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        FilterInfoCollection Cihazlar;
        VideoCaptureDevice kameram;

        private void btnCategory_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminKategoriIslemlerics categoryPage =new AdminKategoriIslemlerics();
            categoryPage.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminUrunIslemleri productPage = new AdminUrunIslemleri();
            productPage.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Cihazlar = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            foreach(FilterInfo cihaz in Cihazlar)
            {
                cmbKamera.Items.Add(cihaz.Name);
            }

            cmbKamera.SelectedIndex = 0;

        }

        double sun = 0;
        double price= 0;
        string temp_barcode = "";
        
        public static double FindProductPrice (string barcode)
        {
            SqlCommand command = new SqlCommand("Select ProductPrice from TableProduct where ProductBarcode=@p1",sqlConnectionClass.connect);
            sqlConnectionClass.CheckConnection(sqlConnectionClass.connect);

            commandFindProductPrice.Parameters.AddWithValue("@p1", barcode);

            SqlDataReader dr =commanFindProductPrice.ExecuteReader();
            double price = 0;
            while (dr.Read())
            {
                price = Convert.ToDouble(dr[0]);
            }
            return price;
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            kameram = new VideoCaptureDevice(Cihazlar[cmbKamera.SelectedIndex].MonikerString);

            kameram.NewFrame += VideoCaptureDevice_NewFrame;
            kameram.Start();

        }

        private void VideoCaptureDevice_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            Bitmap GoruntulenenBarkod = (Bitmap)eventArgs.Frame.Clone();

            BarcodeReader okuyucu = new BarcodeReader();
            //BarcodeReader okuyucu = new BarcodeReader { AutoRotate = true, TryInverted = true };

            var sonuc = okuyucu.Decode(GoruntulenenBarkod);

            if(sonuc != null)
            {
                txtBarcode.Invoke(new MethodInvoker(delegate ()
                {
                    

                    if (temp_barcode==sonuc.ToString())
                    {

                    }
                    else {                     
                            temp_barcode = sonuc.ToString();
                            txtBarcode.Text = sonuc.ToString();
                            double price = FindProductPrice(sonuc.ToString());
                            sun += price;
                            richTextBox1.Text = sun.ToString();   
                        
                        
                    }

                   
                }
                )); 
            }

            PictureBox1.Image=GoruntulenenBarkod;

        }

        private void Form1_formClosing(object sendeer ,FormClosingEventArgs e)
        {
            if (kameram != null)
            {
                if(kameram.IsRunning)
                {
                    kameram.Stop();
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            sun = 0;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            sun += price;
            richTextBox1.Text = sun.ToString();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            sun -= price;
            richTextBox1.Text = sun.ToString();
        }
    }
}
