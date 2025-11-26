namespace Projek_Akhir
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Judul = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.KondisiBuku = new System.Windows.Forms.CheckBox();
            this.SudahKartu = new System.Windows.Forms.CheckBox();
            this.JumlahBuku = new System.Windows.Forms.NumericUpDown();
            this.JmlBuku = new System.Windows.Forms.Label();
            this.JenisBuku = new System.Windows.Forms.ComboBox();
            this.Jenis = new System.Windows.Forms.Label();
            this.Pengarang = new System.Windows.Forms.TextBox();
            this.Pngrng = new System.Windows.Forms.Label();
            this.JudulBuku = new System.Windows.Forms.TextBox();
            this.JudulB = new System.Windows.Forms.Label();
            this.DataBuku = new System.Windows.Forms.Label();
            this.TglKembali = new System.Windows.Forms.DateTimePicker();
            this.TglPinjam = new System.Windows.Forms.DateTimePicker();
            this.Jurusan = new System.Windows.Forms.ComboBox();
            this.IDAnggota = new System.Windows.Forms.TextBox();
            this.NamaPeminjam = new System.Windows.Forms.TextBox();
            this.TglK = new System.Windows.Forms.Label();
            this.TglP = new System.Windows.Forms.Label();
            this.Jrsn = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.Nama = new System.Windows.Forms.Label();
            this.DataPeminjam = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.InformasiPeminjaman = new System.Windows.Forms.RichTextBox();
            this.IformasiP = new System.Windows.Forms.Label();
            this.SimpanData = new System.Windows.Forms.Button();
            this.HapusData = new System.Windows.Forms.Button();
            this.Keluar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.JumlahBuku)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Judul
            // 
            this.Judul.AutoSize = true;
            this.Judul.Location = new System.Drawing.Point(349, 29);
            this.Judul.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Judul.Name = "Judul";
            this.Judul.Size = new System.Drawing.Size(329, 25);
            this.Judul.TabIndex = 0;
            this.Judul.Text = "PERPUSTAKAAN LENTERA LITERASI";
            this.Judul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.MistyRose;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(269, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.KondisiBuku);
            this.groupBox1.Controls.Add(this.SudahKartu);
            this.groupBox1.Controls.Add(this.JumlahBuku);
            this.groupBox1.Controls.Add(this.JmlBuku);
            this.groupBox1.Controls.Add(this.JenisBuku);
            this.groupBox1.Controls.Add(this.Jenis);
            this.groupBox1.Controls.Add(this.Pengarang);
            this.groupBox1.Controls.Add(this.Pngrng);
            this.groupBox1.Controls.Add(this.JudulBuku);
            this.groupBox1.Controls.Add(this.JudulB);
            this.groupBox1.Controls.Add(this.DataBuku);
            this.groupBox1.Controls.Add(this.TglKembali);
            this.groupBox1.Controls.Add(this.TglPinjam);
            this.groupBox1.Controls.Add(this.Jurusan);
            this.groupBox1.Controls.Add(this.IDAnggota);
            this.groupBox1.Controls.Add(this.NamaPeminjam);
            this.groupBox1.Controls.Add(this.TglK);
            this.groupBox1.Controls.Add(this.TglP);
            this.groupBox1.Controls.Add(this.Jrsn);
            this.groupBox1.Controls.Add(this.ID);
            this.groupBox1.Controls.Add(this.Nama);
            this.groupBox1.Controls.Add(this.DataPeminjam);
            this.groupBox1.Location = new System.Drawing.Point(12, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(901, 254);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // KondisiBuku
            // 
            this.KondisiBuku.AutoSize = true;
            this.KondisiBuku.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KondisiBuku.ForeColor = System.Drawing.Color.Black;
            this.KondisiBuku.Location = new System.Drawing.Point(473, 214);
            this.KondisiBuku.Name = "KondisiBuku";
            this.KondisiBuku.Size = new System.Drawing.Size(189, 24);
            this.KondisiBuku.TabIndex = 21;
            this.KondisiBuku.Text = "Buku dalam kondisi baik";
            this.KondisiBuku.UseVisualStyleBackColor = true;
            // 
            // SudahKartu
            // 
            this.SudahKartu.AutoSize = true;
            this.SudahKartu.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SudahKartu.ForeColor = System.Drawing.Color.Black;
            this.SudahKartu.Location = new System.Drawing.Point(473, 189);
            this.SudahKartu.Name = "SudahKartu";
            this.SudahKartu.Size = new System.Drawing.Size(257, 24);
            this.SudahKartu.TabIndex = 20;
            this.SudahKartu.Text = "Sudah menunjukkan kartu anggota";
            this.SudahKartu.UseVisualStyleBackColor = true;
            // 
            // JumlahBuku
            // 
            this.JumlahBuku.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JumlahBuku.Location = new System.Drawing.Point(740, 153);
            this.JumlahBuku.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.JumlahBuku.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.JumlahBuku.Name = "JumlahBuku";
            this.JumlahBuku.Size = new System.Drawing.Size(120, 27);
            this.JumlahBuku.TabIndex = 19;
            this.JumlahBuku.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // JmlBuku
            // 
            this.JmlBuku.AutoSize = true;
            this.JmlBuku.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JmlBuku.ForeColor = System.Drawing.Color.Black;
            this.JmlBuku.Location = new System.Drawing.Point(469, 155);
            this.JmlBuku.Name = "JmlBuku";
            this.JmlBuku.Size = new System.Drawing.Size(91, 20);
            this.JmlBuku.TabIndex = 18;
            this.JmlBuku.Text = "Jumlah Buku";
            // 
            // JenisBuku
            // 
            this.JenisBuku.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.JenisBuku.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JenisBuku.FormattingEnabled = true;
            this.JenisBuku.Items.AddRange(new object[] {
            "Buku Fiksi",
            "Buku Nonfiksi",
            "Buku Pelajaran",
            "Buku Referensi",
            "Buku Panduan",
            "Buku Sastra",
            ""});
            this.JenisBuku.Location = new System.Drawing.Point(566, 119);
            this.JenisBuku.Name = "JenisBuku";
            this.JenisBuku.Size = new System.Drawing.Size(294, 28);
            this.JenisBuku.TabIndex = 17;
            // 
            // Jenis
            // 
            this.Jenis.AutoSize = true;
            this.Jenis.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Jenis.ForeColor = System.Drawing.Color.Black;
            this.Jenis.Location = new System.Drawing.Point(469, 122);
            this.Jenis.Name = "Jenis";
            this.Jenis.Size = new System.Drawing.Size(76, 20);
            this.Jenis.TabIndex = 16;
            this.Jenis.Text = "Jenis Buku";
            // 
            // Pengarang
            // 
            this.Pengarang.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pengarang.Location = new System.Drawing.Point(566, 86);
            this.Pengarang.Name = "Pengarang";
            this.Pengarang.Size = new System.Drawing.Size(294, 27);
            this.Pengarang.TabIndex = 15;
            // 
            // Pngrng
            // 
            this.Pngrng.AutoSize = true;
            this.Pngrng.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pngrng.ForeColor = System.Drawing.Color.Black;
            this.Pngrng.Location = new System.Drawing.Point(469, 89);
            this.Pngrng.Name = "Pngrng";
            this.Pngrng.Size = new System.Drawing.Size(79, 20);
            this.Pngrng.TabIndex = 14;
            this.Pngrng.Text = "Pengarang";
            // 
            // JudulBuku
            // 
            this.JudulBuku.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JudulBuku.Location = new System.Drawing.Point(566, 53);
            this.JudulBuku.Name = "JudulBuku";
            this.JudulBuku.Size = new System.Drawing.Size(294, 27);
            this.JudulBuku.TabIndex = 13;
            // 
            // JudulB
            // 
            this.JudulB.AutoSize = true;
            this.JudulB.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JudulB.ForeColor = System.Drawing.Color.Black;
            this.JudulB.Location = new System.Drawing.Point(469, 56);
            this.JudulB.Name = "JudulB";
            this.JudulB.Size = new System.Drawing.Size(79, 20);
            this.JudulB.TabIndex = 12;
            this.JudulB.Text = "Judul Buku";
            // 
            // DataBuku
            // 
            this.DataBuku.AutoSize = true;
            this.DataBuku.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataBuku.Location = new System.Drawing.Point(468, 14);
            this.DataBuku.Name = "DataBuku";
            this.DataBuku.Size = new System.Drawing.Size(105, 25);
            this.DataBuku.TabIndex = 11;
            this.DataBuku.Text = "Data Buku";
            // 
            // TglKembali
            // 
            this.TglKembali.CalendarFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TglKembali.CustomFormat = "dd/MM/yyyy";
            this.TglKembali.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TglKembali.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TglKembali.Location = new System.Drawing.Point(132, 186);
            this.TglKembali.Name = "TglKembali";
            this.TglKembali.Size = new System.Drawing.Size(294, 27);
            this.TglKembali.TabIndex = 10;
            // 
            // TglPinjam
            // 
            this.TglPinjam.CalendarFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TglPinjam.CustomFormat = "dd/MM/yyyy";
            this.TglPinjam.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TglPinjam.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TglPinjam.Location = new System.Drawing.Point(132, 153);
            this.TglPinjam.Name = "TglPinjam";
            this.TglPinjam.Size = new System.Drawing.Size(294, 27);
            this.TglPinjam.TabIndex = 9;
            // 
            // Jurusan
            // 
            this.Jurusan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Jurusan.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Jurusan.FormattingEnabled = true;
            this.Jurusan.Items.AddRange(new object[] {
            "Teknik Otomotif",
            "Teknik Mesin",
            "Teknik Elektronika",
            "Teknik Ketenagalistrikan",
            "Rekayasa Perangkat Lunak",
            ""});
            this.Jurusan.Location = new System.Drawing.Point(132, 119);
            this.Jurusan.Name = "Jurusan";
            this.Jurusan.Size = new System.Drawing.Size(294, 28);
            this.Jurusan.TabIndex = 8;
            // 
            // IDAnggota
            // 
            this.IDAnggota.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDAnggota.Location = new System.Drawing.Point(132, 86);
            this.IDAnggota.Name = "IDAnggota";
            this.IDAnggota.Size = new System.Drawing.Size(294, 27);
            this.IDAnggota.TabIndex = 7;
            // 
            // NamaPeminjam
            // 
            this.NamaPeminjam.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NamaPeminjam.Location = new System.Drawing.Point(132, 53);
            this.NamaPeminjam.Name = "NamaPeminjam";
            this.NamaPeminjam.Size = new System.Drawing.Size(294, 27);
            this.NamaPeminjam.TabIndex = 6;
            // 
            // TglK
            // 
            this.TglK.AutoSize = true;
            this.TglK.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TglK.ForeColor = System.Drawing.Color.Black;
            this.TglK.Location = new System.Drawing.Point(8, 191);
            this.TglK.Name = "TglK";
            this.TglK.Size = new System.Drawing.Size(120, 20);
            this.TglK.TabIndex = 5;
            this.TglK.Text = "Tanggal Kembali";
            // 
            // TglP
            // 
            this.TglP.AutoSize = true;
            this.TglP.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TglP.ForeColor = System.Drawing.Color.Black;
            this.TglP.Location = new System.Drawing.Point(8, 155);
            this.TglP.Name = "TglP";
            this.TglP.Size = new System.Drawing.Size(110, 20);
            this.TglP.TabIndex = 4;
            this.TglP.Text = "Tanggal Pinjam";
            // 
            // Jrsn
            // 
            this.Jrsn.AutoSize = true;
            this.Jrsn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Jrsn.ForeColor = System.Drawing.Color.Black;
            this.Jrsn.Location = new System.Drawing.Point(8, 122);
            this.Jrsn.Name = "Jrsn";
            this.Jrsn.Size = new System.Drawing.Size(57, 20);
            this.Jrsn.TabIndex = 3;
            this.Jrsn.Text = "Jurusan";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.ForeColor = System.Drawing.Color.Black;
            this.ID.Location = new System.Drawing.Point(8, 89);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(86, 20);
            this.ID.TabIndex = 2;
            this.ID.Text = "ID Anggota";
            // 
            // Nama
            // 
            this.Nama.AutoSize = true;
            this.Nama.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nama.ForeColor = System.Drawing.Color.Black;
            this.Nama.Location = new System.Drawing.Point(8, 56);
            this.Nama.Name = "Nama";
            this.Nama.Size = new System.Drawing.Size(118, 20);
            this.Nama.TabIndex = 1;
            this.Nama.Text = "Nama Peminjam";
            // 
            // DataPeminjam
            // 
            this.DataPeminjam.AutoSize = true;
            this.DataPeminjam.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataPeminjam.Location = new System.Drawing.Point(6, 14);
            this.DataPeminjam.Name = "DataPeminjam";
            this.DataPeminjam.Size = new System.Drawing.Size(145, 25);
            this.DataPeminjam.TabIndex = 0;
            this.DataPeminjam.Text = "Data Peminjam";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.InformasiPeminjaman);
            this.groupBox2.Controls.Add(this.IformasiP);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(12, 339);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(901, 139);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // InformasiPeminjaman
            // 
            this.InformasiPeminjaman.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InformasiPeminjaman.Location = new System.Drawing.Point(12, 39);
            this.InformasiPeminjaman.Name = "InformasiPeminjaman";
            this.InformasiPeminjaman.Size = new System.Drawing.Size(883, 87);
            this.InformasiPeminjaman.TabIndex = 13;
            this.InformasiPeminjaman.Text = "";
            // 
            // IformasiP
            // 
            this.IformasiP.AutoSize = true;
            this.IformasiP.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IformasiP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.IformasiP.Location = new System.Drawing.Point(6, 11);
            this.IformasiP.Name = "IformasiP";
            this.IformasiP.Size = new System.Drawing.Size(211, 25);
            this.IformasiP.TabIndex = 12;
            this.IformasiP.Text = "Informasi Peminjaman";
            // 
            // SimpanData
            // 
            this.SimpanData.AutoSize = true;
            this.SimpanData.BackColor = System.Drawing.Color.White;
            this.SimpanData.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SimpanData.ForeColor = System.Drawing.Color.Black;
            this.SimpanData.Location = new System.Drawing.Point(580, 484);
            this.SimpanData.Name = "SimpanData";
            this.SimpanData.Size = new System.Drawing.Size(105, 30);
            this.SimpanData.TabIndex = 4;
            this.SimpanData.Text = "Simpan Data";
            this.SimpanData.UseVisualStyleBackColor = false;
            this.SimpanData.Click += new System.EventHandler(this.SimpanData_Click);
            // 
            // HapusData
            // 
            this.HapusData.AutoSize = true;
            this.HapusData.BackColor = System.Drawing.Color.White;
            this.HapusData.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HapusData.ForeColor = System.Drawing.Color.Black;
            this.HapusData.Location = new System.Drawing.Point(691, 484);
            this.HapusData.Name = "HapusData";
            this.HapusData.Size = new System.Drawing.Size(105, 30);
            this.HapusData.TabIndex = 5;
            this.HapusData.Text = "Hapus Data";
            this.HapusData.UseVisualStyleBackColor = false;
            this.HapusData.Click += new System.EventHandler(this.HapusData_Click);
            // 
            // Keluar
            // 
            this.Keluar.AutoSize = true;
            this.Keluar.BackColor = System.Drawing.Color.White;
            this.Keluar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Keluar.ForeColor = System.Drawing.Color.Black;
            this.Keluar.Location = new System.Drawing.Point(802, 484);
            this.Keluar.Name = "Keluar";
            this.Keluar.Size = new System.Drawing.Size(105, 30);
            this.Keluar.TabIndex = 6;
            this.Keluar.Text = "Keluar";
            this.Keluar.UseVisualStyleBackColor = false;
            this.Keluar.Click += new System.EventHandler(this.Keluar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(925, 518);
            this.Controls.Add(this.Keluar);
            this.Controls.Add(this.HapusData);
            this.Controls.Add(this.SimpanData);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Judul);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.JumlahBuku)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Judul;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Nama;
        private System.Windows.Forms.Label DataPeminjam;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label Jrsn;
        private System.Windows.Forms.TextBox IDAnggota;
        private System.Windows.Forms.TextBox NamaPeminjam;
        private System.Windows.Forms.Label TglK;
        private System.Windows.Forms.Label TglP;
        private System.Windows.Forms.ComboBox Jurusan;
        private System.Windows.Forms.DateTimePicker TglPinjam;
        private System.Windows.Forms.DateTimePicker TglKembali;
        private System.Windows.Forms.Label DataBuku;
        private System.Windows.Forms.Label JudulB;
        private System.Windows.Forms.TextBox JudulBuku;
        private System.Windows.Forms.ComboBox JenisBuku;
        private System.Windows.Forms.Label Jenis;
        private System.Windows.Forms.TextBox Pengarang;
        private System.Windows.Forms.Label Pngrng;
        private System.Windows.Forms.CheckBox SudahKartu;
        private System.Windows.Forms.NumericUpDown JumlahBuku;
        private System.Windows.Forms.Label JmlBuku;
        private System.Windows.Forms.CheckBox KondisiBuku;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label IformasiP;
        private System.Windows.Forms.RichTextBox InformasiPeminjaman;
        private System.Windows.Forms.Button SimpanData;
        private System.Windows.Forms.Button HapusData;
        private System.Windows.Forms.Button Keluar;
    }
}

