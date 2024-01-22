namespace barkod
{
    partial class AdminKategoriIslemlerics
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tboxCategoryName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCategoryDelete = new System.Windows.Forms.Button();
            this.lblSlectedID = new System.Windows.Forms.Label();
            this.btnMW = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(905, 243);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SeletionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddCategory);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tboxCategoryName);
            this.groupBox1.Location = new System.Drawing.Point(241, 277);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 237);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kategori Ekle";
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Location = new System.Drawing.Point(38, 138);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(124, 58);
            this.btnAddCategory.TabIndex = 2;
            this.btnAddCategory.Text = "Kategori Ekle";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kategori Adını Giriniz";
            // 
            // tboxCategoryName
            // 
            this.tboxCategoryName.Location = new System.Drawing.Point(17, 90);
            this.tboxCategoryName.Name = "tboxCategoryName";
            this.tboxCategoryName.Size = new System.Drawing.Size(177, 22);
            this.tboxCategoryName.TabIndex = 0;
            this.tboxCategoryName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCategoryDelete);
            this.groupBox2.Controls.Add(this.lblSlectedID);
            this.groupBox2.Location = new System.Drawing.Point(550, 277);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 237);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kategori Sil";
            // 
            // btnCategoryDelete
            // 
            this.btnCategoryDelete.Location = new System.Drawing.Point(38, 123);
            this.btnCategoryDelete.Name = "btnCategoryDelete";
            this.btnCategoryDelete.Size = new System.Drawing.Size(124, 88);
            this.btnCategoryDelete.TabIndex = 2;
            this.btnCategoryDelete.Text = "Kategori  Sil ";
            this.btnCategoryDelete.UseVisualStyleBackColor = true;
            this.btnCategoryDelete.Click += new System.EventHandler(this.btnCategoryDelete_Click);
            // 
            // lblSlectedID
            // 
            this.lblSlectedID.AutoSize = true;
            this.lblSlectedID.Location = new System.Drawing.Point(35, 44);
            this.lblSlectedID.Name = "lblSlectedID";
            this.lblSlectedID.Size = new System.Drawing.Size(0, 16);
            this.lblSlectedID.TabIndex = 1;
            // 
            // btnMW
            // 
            this.btnMW.Location = new System.Drawing.Point(32, 304);
            this.btnMW.Name = "btnMW";
            this.btnMW.Size = new System.Drawing.Size(127, 68);
            this.btnMW.TabIndex = 3;
            this.btnMW.Text = "Ana Ekrana Dön ";
            this.btnMW.UseVisualStyleBackColor = true;
            this.btnMW.Click += new System.EventHandler(this.btnMW_Click);
            // 
            // AdminKategoriIslemlerics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(929, 526);
            this.Controls.Add(this.btnMW);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "AdminKategoriIslemlerics";
            this.Text = "AdminKategoriIslemlerics";
            this.Load += new System.EventHandler(this.AdminKategoriIslemlerics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxCategoryName;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCategoryDelete;
        private System.Windows.Forms.Label lblSlectedID;
        private System.Windows.Forms.Button btnMW;
    }
}