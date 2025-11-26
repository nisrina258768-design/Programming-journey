using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projek_Akhir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        
        }

        private void SimpanData_Click(object sender, EventArgs e)
        {
            // Mengecek apakah textbox kosong
            string pesanError = "";

            if (string.IsNullOrEmpty(NamaPeminjam.Text))
            {
                pesanError += "Nama Peminjam harus diisi!\n";
            }
            if (string.IsNullOrEmpty(IDAnggota.Text))
            {
                pesanError += "ID Anggota harus diisi!\n";
            }
            if (Jurusan.SelectedItem == null)
            {
                pesanError += "Jurusan harus dipilih!\n";
            }
            if (string.IsNullOrEmpty(JudulBuku.Text))
            {
                pesanError += "Judul Buku harus diisi!\n";
            }
            if (string.IsNullOrEmpty(Pengarang.Text))
            {
                pesanError += "Pengarang harus diisi!\n";
            }
            if (JenisBuku.SelectedItem == null)
            {
                pesanError += "Jenis Buku harus dipilih!\n";
            }

            if (pesanError != "")
            {
                MessageBox.Show("ERROR\n\n" + pesanError, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }




            // Mengambil Data
            string nama = NamaPeminjam.Text;
            string id = IDAnggota.Text;
            string jurusan = Jurusan.SelectedItem?.ToString() ?? "";
            string tglPinjam = TglPinjam.Value.ToString("dd/MM/yyyy");
            string tglKembali = TglKembali.Value.ToString("dd/MM/yyyy");

            string judulBuku = JudulBuku.Text;
            string pengarang = Pengarang.Text;
            string jenisBuku = JenisBuku.Text;
            int jumlahBuku = (int)JumlahBuku.Value;
            bool sudahKartu = SudahKartu.Checked;
            bool kondisiBuku = KondisiBuku.Checked;

            // Menampilkan Data
            string infoPeminjaman = $"Nama Peminjam: {nama}\n" +
                                    $"ID Anggota: {id}\n" +
                                    $"Jurusan: {jurusan}\n" +
                                    $"Tanggal Pinjam: {tglPinjam}\n" +
                                    $"Tanggal Kembali: {tglKembali}\n\n" +
                                    $"Judul Buku: {judulBuku}\n" +
                                    $"Pengarang: {pengarang}\n" +
                                    $"Jenis Buku: {jenisBuku}\n" +
                                    $"Jumlah Buku: {jumlahBuku}\n" +
                                    $"Sudah menunjukkan kartu anggota: {sudahKartu}\n" +
                                    $"Buku dalam kondisi baik: {kondisiBuku}";

            InformasiPeminjaman.Text = infoPeminjaman;

        }

        private void HapusData_Click(object sender, EventArgs e)
        {
            // Mengosongkan Data
            NamaPeminjam.Clear();
            IDAnggota.Clear();
            Jurusan.SelectedIndex = -1;
            TglPinjam.Value = DateTime.Today;
            TglKembali.Value = DateTime.Today;
            JudulBuku.Clear();
            Pengarang.Clear();
            JenisBuku.SelectedIndex = -1;
            JumlahBuku.Value = 1;
            SudahKartu.Checked = false;
            KondisiBuku.Checked = false;

            // Mengosongkan isi Informasi Peminjaman
            InformasiPeminjaman.Clear();

        }

        private void Keluar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
