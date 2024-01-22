namespace barkod
{
    partial class AdminUrunIslemleri
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
            this.dgProduct = new System.Windows.Forms.DataGridView();
            this.btnMW = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tboxProductBarcode = new System.Windows.Forms.TextBox();
            this.tboxProductPrice = new System.Windows.Forms.TextBox();
            this.tboxProductName = new System.Windows.Forms.TextBox();
            this.cmbBoxCategory = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblSelectedID = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.btnBaslat = new System.Windows.Forms.Button();
            this.cmbKamera = new System.Windows.Forms.ComboBox();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgProduct)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgProduct
            // 
            this.dgProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProduct.Location = new System.Drawing.Point(48, 12);
            this.dgProduct.Name = "dgProduct";
            this.dgProduct.RowHeadersWidth = 51;
            this.dgProduct.RowTemplate.Height = 24;
            this.dgProduct.Size = new System.Drawing.Size(864, 234);
            this.dgProduct.TabIndex = 0;
            this.dgProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProduct_CellContentClick);
            this.dgProduct.SelectionChanged += new System.EventHandler(this.dgProduct_SelectionChanged);
            // 
            // btnMW
            // 
            this.btnMW.Location = new System.Drawing.Point(729, 268);
            this.btnMW.Name = "btnMW";
            this.btnMW.Size = new System.Drawing.Size(183, 70);
            this.btnMW.TabIndex = 2;
            this.btnMW.Text = "Ana Ekrana Dön ";
            this.btnMW.UseVisualStyleBackColor = true;
            this.btnMW.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tboxProductBarcode);
            this.groupBox1.Controls.Add(this.tboxProductPrice);
            this.groupBox1.Controls.Add(this.tboxProductName);
            this.groupBox1.Controls.Add(this.cmbBoxCategory);
            this.groupBox1.Location = new System.Drawing.Point(48, 252);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 323);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Ekle ";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(63, 262);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(151, 46);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Ürünü Ekle";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ürün Barkodu Giriniz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ürün Fiyatı Giriniz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ürün Kategorisi Seçiniz";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ürün adı giriniz";
            // 
            // tboxProductBarcode
            // 
            this.tboxProductBarcode.Location = new System.Drawing.Point(21, 214);
            this.tboxProductBarcode.Name = "tboxProductBarcode";
            this.tboxProductBarcode.Size = new System.Drawing.Size(125, 22);
            this.tboxProductBarcode.TabIndex = 3;
            // 
            // tboxProductPrice
            // 
            this.tboxProductPrice.Location = new System.Drawing.Point(21, 155);
            this.tboxProductPrice.Name = "tboxProductPrice";
            this.tboxProductPrice.Size = new System.Drawing.Size(125, 22);
            this.tboxProductPrice.TabIndex = 2;
            // 
            // tboxProductName
            // 
            this.tboxProductName.Location = new System.Drawing.Point(21, 99);
            this.tboxProductName.Name = "tboxProductName";
            this.tboxProductName.Size = new System.Drawing.Size(125, 22);
            this.tboxProductName.TabIndex = 1;
            // 
            // cmbBoxCategory
            // 
            this.cmbBoxCategory.FormattingEnabled = true;
            this.cmbBoxCategory.Location = new System.Drawing.Point(21, 40);
            this.cmbBoxCategory.Name = "cmbBoxCategory";
            this.cmbBoxCategory.Size = new System.Drawing.Size(227, 24);
            this.cmbBoxCategory.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblSelectedID);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Location = new System.Drawing.Point(377, 252);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(233, 323);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürün Sil ";
            // 
            // lblSelectedID
            // 
            this.lblSelectedID.AutoSize = true;
            this.lblSelectedID.Location = new System.Drawing.Point(93, 80);
            this.lblSelectedID.Name = "lblSelectedID";
            this.lblSelectedID.Size = new System.Drawing.Size(0, 16);
            this.lblSelectedID.TabIndex = 2;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(42, 163);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(149, 81);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Ürünü Sil ";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(1058, 354);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(555, 22);
            this.txtBarcode.TabIndex = 8;
            // 
            // btnBaslat
            // 
            this.btnBaslat.Location = new System.Drawing.Point(1058, 382);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(186, 49);
            this.btnBaslat.TabIndex = 7;
            this.btnBaslat.Text = "Başlat";
            this.btnBaslat.UseVisualStyleBackColor = true;
            // 
            // cmbKamera
            // 
            this.cmbKamera.FormattingEnabled = true;
            this.cmbKamera.Location = new System.Drawing.Point(1058, 28);
            this.cmbKamera.Name = "cmbKamera";
            this.cmbKamera.Size = new System.Drawing.Size(555, 24);
            this.cmbKamera.TabIndex = 6;
            // 
            // PictureBox1
            // 
            this.PictureBox1.Location = new System.Drawing.Point(1070, 59);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(667, 289);
            this.PictureBox1.TabIndex = 5;
            this.PictureBox1.TabStop = false;
            // 
            // AdminUrunIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1760, 587);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.btnBaslat);
            this.Controls.Add(this.cmbKamera);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnMW);
            this.Controls.Add(this.dgProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AdminUrunIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.AdminUrunIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgProduct)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgProduct;
        private System.Windows.Forms.Button btnMW;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbBoxCategory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxProductBarcode;
        private System.Windows.Forms.TextBox tboxProductPrice;
        private System.Windows.Forms.TextBox tboxProductName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblSelectedID;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Button btnBaslat;
        private System.Windows.Forms.ComboBox cmbKamera;
        private System.Windows.Forms.PictureBox PictureBox1;
    }
}