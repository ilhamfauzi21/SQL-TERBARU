namespace SQL_TERBARU
{
    partial class Form4
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
            this.cbxNama = new System.Windows.Forms.Label();
            this.txtNIM1 = new System.Windows.Forms.Label();
            this.cbxStatusMahasiswa = new System.Windows.Forms.Label();
            this.cbxTahunMasuk = new System.Windows.Forms.Label();
            this.cbMahasiswa = new System.Windows.Forms.ComboBox();
            this.cbStatusMahasiswa = new System.Windows.Forms.ComboBox();
            this.cbTahunMasuk = new System.Windows.Forms.ComboBox();
            this.txtNim = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(203, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(360, 237);
            this.dataGridView1.TabIndex = 0;
            // 
            // cbxNama
            // 
            this.cbxNama.AutoSize = true;
            this.cbxNama.Location = new System.Drawing.Point(144, 276);
            this.cbxNama.Name = "cbxNama";
            this.cbxNama.Size = new System.Drawing.Size(134, 20);
            this.cbxNama.TabIndex = 1;
            this.cbxNama.Text = "Nama Mahasiswa";
            // 
            // txtNIM1
            // 
            this.txtNIM1.AutoSize = true;
            this.txtNIM1.Location = new System.Drawing.Point(144, 321);
            this.txtNIM1.Name = "txtNIM1";
            this.txtNIM1.Size = new System.Drawing.Size(183, 20);
            this.txtNIM1.TabIndex = 2;
            this.txtNIM1.Text = "Nomer Induk Mahasiswa";
            this.txtNIM1.Click += new System.EventHandler(this.label2_Click);
            // 
            // cbxStatusMahasiswa
            // 
            this.cbxStatusMahasiswa.AutoSize = true;
            this.cbxStatusMahasiswa.Location = new System.Drawing.Point(144, 358);
            this.cbxStatusMahasiswa.Name = "cbxStatusMahasiswa";
            this.cbxStatusMahasiswa.Size = new System.Drawing.Size(131, 20);
            this.cbxStatusMahasiswa.TabIndex = 3;
            this.cbxStatusMahasiswa.Text = "Status Mahasiwa";
            this.cbxStatusMahasiswa.Click += new System.EventHandler(this.label3_Click);
            // 
            // cbxTahunMasuk
            // 
            this.cbxTahunMasuk.AutoSize = true;
            this.cbxTahunMasuk.Location = new System.Drawing.Point(144, 393);
            this.cbxTahunMasuk.Name = "cbxTahunMasuk";
            this.cbxTahunMasuk.Size = new System.Drawing.Size(105, 20);
            this.cbxTahunMasuk.TabIndex = 4;
            this.cbxTahunMasuk.Text = "Tahun Masuk";
            this.cbxTahunMasuk.Click += new System.EventHandler(this.label4_Click);
            // 
            // cbMahasiswa
            // 
            this.cbMahasiswa.FormattingEnabled = true;
            this.cbMahasiswa.Location = new System.Drawing.Point(329, 276);
            this.cbMahasiswa.Name = "cbMahasiswa";
            this.cbMahasiswa.Size = new System.Drawing.Size(131, 28);
            this.cbMahasiswa.TabIndex = 5;
            // 
            // cbStatusMahasiswa
            // 
            this.cbStatusMahasiswa.FormattingEnabled = true;
            this.cbStatusMahasiswa.Location = new System.Drawing.Point(329, 350);
            this.cbStatusMahasiswa.Name = "cbStatusMahasiswa";
            this.cbStatusMahasiswa.Size = new System.Drawing.Size(145, 28);
            this.cbStatusMahasiswa.TabIndex = 14;
            this.cbStatusMahasiswa.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // cbTahunMasuk
            // 
            this.cbTahunMasuk.FormattingEnabled = true;
            this.cbTahunMasuk.Location = new System.Drawing.Point(329, 393);
            this.cbTahunMasuk.Name = "cbTahunMasuk";
            this.cbTahunMasuk.Size = new System.Drawing.Size(145, 28);
            this.cbTahunMasuk.TabIndex = 15;
            this.cbTahunMasuk.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // txtNim
            // 
            this.txtNim.AutoSize = true;
            this.txtNim.Location = new System.Drawing.Point(325, 321);
            this.txtNim.Name = "txtNim";
            this.txtNim.Size = new System.Drawing.Size(55, 20);
            this.txtNim.TabIndex = 16;
            this.txtNim.Text = "txtNIM";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(613, 21);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 17;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(500, 281);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(500, 333);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(500, 376);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 25);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.txtNim);
            this.Controls.Add(this.cbTahunMasuk);
            this.Controls.Add(this.cbStatusMahasiswa);
            this.Controls.Add(this.cbMahasiswa);
            this.Controls.Add(this.cbxTahunMasuk);
            this.Controls.Add(this.cbxStatusMahasiswa);
            this.Controls.Add(this.txtNIM1);
            this.Controls.Add(this.cbxNama);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form4";
            this.Text = "Data Mahasiswa";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label cbxNama;
        private System.Windows.Forms.Label txtNIM1;
        private System.Windows.Forms.Label cbxStatusMahasiswa;
        private System.Windows.Forms.Label cbxTahunMasuk;
        private System.Windows.Forms.ComboBox cbMahasiswa;
        private System.Windows.Forms.ComboBox cbStatusMahasiswa;
        private System.Windows.Forms.ComboBox cbTahunMasuk;
        private System.Windows.Forms.Label txtNim;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
    }
}