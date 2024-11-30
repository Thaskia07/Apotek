using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apotek.Controller
{
    internal class Validasi
    {
        // Validasi ID: tidak boleh kosong dan hanya 1 angka
        public static bool ValidasiId(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("ID tidak boleh kosong.", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // ID harus terdiri dari hanya 1 digit angka
            if (!Regex.IsMatch(id, @"^\d{1}$"))
            {
                MessageBox.Show("ID harus berupa 1 angka.", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        // Validasi Username: panjang 3-20 karakter, hanya huruf, angka, atau _ dan .
        public static bool ValidasiUsername(string username)
        {
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Username tidak boleh kosong.", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Username dapat berisi huruf, angka, titik, atau garis bawah, dan panjangnya antara 3-20 karakter
            if (!Regex.IsMatch(username, @"^[a-zA-Z0-9._]{3,20}$"))
            {
                MessageBox.Show("Username harus terdiri dari 3-20 karakter, hanya huruf, angka, titik atau garis bawah.", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        // Validasi Password: minimal 6 karakter, mengandung huruf besar, huruf kecil, dan angka
        public static bool ValidasiPassword(string pass)
        {
            if (string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Password tidak boleh kosong.", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Password harus minimal 6 karakter, mengandung minimal 1 huruf besar, 1 huruf kecil dan 1 angka
            if (!Regex.IsMatch(pass, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[A-Za-z\d]{6,}$"))
            {
                MessageBox.Show("Password harus minimal 6 karakter, mengandung huruf besar, huruf kecil, dan angka.", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        // Simulasi data ID stok yang sudah ada (seharusnya didapatkan dari database)
        private static List<string> existingIds = new List<string> { "A123", "B456", "C789" };

        // Validasi ID Stok Obat
        public static bool ValidasiIdStok(string idStok)
        {
            if (string.IsNullOrEmpty(idStok))
            {
                MessageBox.Show("ID Stok tidak boleh kosong.", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!Regex.IsMatch(idStok, @"^[A-Za-z0-9]{1,5}$"))
            {
                MessageBox.Show("ID Stok hanya boleh terdiri dari angka atau huruf, dan panjangnya antara 1 hingga 5 karakter.", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (IsIdStokAlreadyExists(idStok))
            {
                MessageBox.Show("ID Stok sudah ada, harap gunakan ID yang berbeda.", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        // Memeriksa apakah ID stok sudah ada di database
        private static bool IsIdStokAlreadyExists(string idStok)
        {
            // Simulasi pemeriksaan data
            return existingIds.Contains(idStok);
        }

        // Validasi Nama Obat
        public static bool ValidasiNamaObat(string namaObat)
        {
            if (string.IsNullOrEmpty(namaObat))
            {
                MessageBox.Show("Nama Obat tidak boleh kosong.", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Nama obat hanya boleh terdiri dari huruf dan spasi, dan panjangnya antara 3 hingga 20 karakter
            if (!Regex.IsMatch(namaObat, @"^[A-Za-z\s]{3,20}$"))
            {
                MessageBox.Show("Nama Obat hanya boleh terdiri dari huruf dan spasi, dan panjangnya antara 3 hingga 20 karakter.", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Pastikan nama obat tidak mengandung angka
            if (Regex.IsMatch(namaObat, @"\d"))
            {
                MessageBox.Show("Nama Obat tidak boleh mengandung angka.", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        // Validasi Kategori
        public static bool ValidasiKategori(string kategori)
        {
            if (string.IsNullOrEmpty(kategori))
            {
                MessageBox.Show("Kategori tidak boleh kosong.", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Kategori dapat berupa huruf, angka, spasi, dan tanda hubung, tetapi tidak boleh lebih dari 15 karakter
            if (!Regex.IsMatch(kategori, @"^[A-Za-z0-9\s-]{1,15}$"))
            {
                MessageBox.Show("Kategori hanya boleh terdiri dari huruf, angka, spasi, dan tanda hubung, dengan maksimal 15 karakter.", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        // Validasi Jumlah
        public static bool ValidasiJumlah(string jumlahText)
        {
            if (string.IsNullOrEmpty(jumlahText))
            {
                MessageBox.Show("Jumlah tidak boleh kosong.", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Jumlah harus berupa angka positif antara 1 dan 1000
            if (!int.TryParse(jumlahText, out int jumlah) || jumlah <= 0 || jumlah > 1000)
            {
                MessageBox.Show("Jumlah harus berupa angka positif antara 1 dan 1000.", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        // Validasi Harga
        public static bool ValidasiHarga(string hargaText)
        {
            if (string.IsNullOrEmpty(hargaText))
            {
                MessageBox.Show("Harga tidak boleh kosong.", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Harga harus berupa angka positif dalam rentang 100 hingga 1.000.000
            if (!decimal.TryParse(hargaText, out decimal harga) || harga < 100 || harga > 1000000)
            {
                MessageBox.Show("Harga harus berupa angka positif antara 100 dan 1.000.000.", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        // Validasi ID Pasien: Tidak boleh kosong, panjang 6 karakter alfanumerik
        public static bool ValidasiIdPasien(string idPasien)
        {
            if (string.IsNullOrEmpty(idPasien))
            {
                MessageBox.Show("ID Pasien tidak boleh kosong.", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // ID harus terdiri dari alfanumerik dan panjang tepat 6 karakter
            if (!Regex.IsMatch(idPasien, @"^[a-zA-Z0-9]{4}$"))
            {
                MessageBox.Show("ID Pasien harus terdiri dari 4 karakter alfanumerik.", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Pastikan ID tidak sudah digunakan (simulasi pengecekan database)
            if (IsIdPasienAlreadyExists(idPasien))
            {
                MessageBox.Show("ID Pasien sudah terdaftar, harap gunakan ID yang berbeda.", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        // Simulasi pengecekan apakah ID Pasien sudah ada
        private static bool IsIdPasienAlreadyExists(string idPasien)
        {
            // Cek ID Pasien dalam database atau koleksi
            // Misalnya ID yang sudah ada: "P001", "P002", "P003"
            string[] existingIds = { "P001", "P002", "P003" };
            return Array.Exists(existingIds, id => id == idPasien);
        }

        // Validasi Nama Pasien: Tidak boleh kosong, hanya huruf dan spasi, panjang 3-50 karakter
        public static bool ValidasiNamaPasien(string namaPasien)
        {
            if (string.IsNullOrEmpty(namaPasien))
            {
                MessageBox.Show("Nama Pasien tidak boleh kosong.", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Nama hanya boleh huruf dan spasi, panjang antara 3 hingga 15 karakter
            if (!Regex.IsMatch(namaPasien, @"^[a-zA-Z\s]{3,15}$"))
            {
                MessageBox.Show("Nama Pasien hanya boleh terdiri dari huruf dan spasi, dengan panjang antara 3 hingga 15 karakter.", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
       
        // Validasi Telepon: Hanya angka, panjang antara 10 dan 15 digit
        public static bool ValidasiTelepon(string telepon)
        {
            if (string.IsNullOrEmpty(telepon))
            {
                MessageBox.Show("Nomor Telepon tidak boleh kosong.", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Telepon harus terdiri dari angka dan panjang antara 10 hingga 15 digit
            if (!Regex.IsMatch(telepon, @"^\d{10,13}$"))
            {
                MessageBox.Show("Nomor Telepon harus terdiri dari angka dan memiliki panjang antara 10 hingga 15 digit.", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        public static bool ValidasiAlamat(string alamat)
        {
            // Mengecek jika alamat kosong
            if (string.IsNullOrEmpty(alamat))
            {
                MessageBox.Show("Alamat tidak boleh kosong.", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Alamat harus panjang minimal 10 karakter
            if (alamat.Length < 5)
            {
                MessageBox.Show("Alamat harus memiliki panjang minimal 5 karakter.", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validasi karakter yang tidak diinginkan (hanya huruf, angka, dan spasi)
            foreach (char c in alamat)
            {
                if (!Char.IsLetterOrDigit(c) && !Char.IsWhiteSpace(c) && !IsAllowedPunctuation(c))
                {
                    MessageBox.Show("Alamat mengandung karakter yang tidak diizinkan.", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            return true;
        }

        // Fungsi untuk mengecek apakah karakter termasuk tanda baca yang diperbolehkan
        private static bool IsAllowedPunctuation(char c)
        {
            // Daftar tanda baca yang diperbolehkan, bisa ditambahkan sesuai kebutuhan
            char[] allowedPunctuation = { '.', ',', '-', '/', '&' };

            foreach (char p in allowedPunctuation)
            {
                if (c == p) return true;
            }
            return false;
        }



        public static bool ValidasiIdResep(string idResep)
        {
            // Regex untuk 1 huruf diikuti oleh 3 angka (misalnya: A123)
            string pattern = @"^[A-Za-z]{1}\d{3}$";

            if (string.IsNullOrEmpty(idResep))
            {
                MessageBox.Show("ID Resep tidak boleh kosong.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Cek apakah ID Resep sesuai dengan pola
            if (!Regex.IsMatch(idResep, pattern))
            {
                MessageBox.Show("ID Resep harus terdiri dari 1 huruf diikuti dengan 3 angka (misalnya: A123).", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        // Validasi Tanggal Resep: format yyyy-MM-dd dan tidak lebih dari hari ini
        public static bool ValidasiTanggalResep(string tanggalResep)
        {
            if (string.IsNullOrEmpty(tanggalResep))
            {
                MessageBox.Show("Tanggal Resep tidak boleh kosong.", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validasi format tanggal
            DateTime tanggal;
            if (!DateTime.TryParseExact(tanggalResep, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out tanggal))
            {
                MessageBox.Show("Format Tanggal Resep tidak valid. Gunakan format yyyy-MM-dd.", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validasi jika tanggal lebih dari hari ini
            if (tanggal > DateTime.Today)
            {
                MessageBox.Show("Tanggal Resep tidak bisa lebih dari hari ini.", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }


        public static bool ValidasiStok(string stokText)
        {
            // Cek apakah input kosong
            if (string.IsNullOrEmpty(stokText))
            {
                MessageBox.Show("Stok tidak boleh kosong.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Cek apakah input berupa angka
            int stok;
            if (!int.TryParse(stokText, out stok))
            {
                MessageBox.Show("Stok harus berupa angka.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Cek apakah stok lebih besar dari 0
            if (stok <= 0)
            {
                MessageBox.Show("Stok harus lebih besar dari 0.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        
        public static bool ValidasiTanggalMasuk(string tanggalMasuk)
        {
            // Cek jika input kosong
            if (string.IsNullOrWhiteSpace(tanggalMasuk))
            {
                MessageBox.Show("Tanggal masuk harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Cek jika format tidak valid atau di masa depan
            if (!DateTime.TryParse(tanggalMasuk, out DateTime tanggal) || tanggal > DateTime.Now)
            {
                MessageBox.Show("Tanggal masuk tidak valid atau di masa depan!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true; // Validasi berhasil
        }
        public static bool ValidasiIdKaryawan(string idKaryawan)
        {
            // Jika input kosong
            if (string.IsNullOrWhiteSpace(idKaryawan))
            {
                MessageBox.Show("ID Karyawan tidak boleh kosong!",
                                "Input Tidak Valid",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return false;
            }

            // Jika panjang input lebih dari 4 karakter
            if (idKaryawan.Length != 4)
            {
                MessageBox.Show("ID Karyawan harus terdiri dari 1 huruf diikuti 3 angka (total 4 karakter)! Contoh: A123",
                                "Input Tidak Valid",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return false;
            }

            // Regex untuk memeriksa format ID
            string pattern = @"^[A-Za-z][0-9]{3}$";
            if (!Regex.IsMatch(idKaryawan, pattern))
            {
                MessageBox.Show("Format ID Karyawan salah! ID harus dimulai dengan 1 huruf diikuti oleh 3 angka. Contoh: A123",
                                "Input Tidak Valid",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return false;
            }

            // Jika validasi berhasil
            return true;
        }

       
        public static bool ValidasiNamaKaryawan(string namaKaryawan)
        {
            // Cek apakah input kosong
            if (string.IsNullOrWhiteSpace(namaKaryawan))
            {
                MessageBox.Show("Nama karyawan tidak boleh kosong!",
                                "Input Tidak Valid",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return false;
            }

            // Cek panjang nama (contoh: minimal 3 karakter, maksimal 50 karakter)
            if (namaKaryawan.Length < 3 || namaKaryawan.Length > 50)
            {
                MessageBox.Show("Nama karyawan harus terdiri dari 3 hingga 50 karakter!",
                                "Input Tidak Valid",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return false;
            }

            // Cek apakah nama hanya mengandung huruf dan spasi
            string pattern = @"^[A-Za-z\s]+$";
            if (!Regex.IsMatch(namaKaryawan, pattern))
            {
                MessageBox.Show("Nama karyawan hanya boleh mengandung huruf dan spasi!",
                                "Input Tidak Valid",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return false;
            }

            // Cek apakah ada spasi ganda atau spasi di awal/akhir
            if (namaKaryawan.Contains("  ") || namaKaryawan.StartsWith(" ") || namaKaryawan.EndsWith(" "))
            {
                MessageBox.Show("Nama karyawan tidak boleh mengandung spasi ganda atau spasi di awal/akhir!",
                                "Input Tidak Valid",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return false;
            }

            // Opsional: Format nama menjadi huruf kapital di awal setiap kata
            namaKaryawan = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(namaKaryawan.ToLower());

            // Jika validasi berhasil
            return true;
        }


        public static bool ValidasiJabatan(string jabatan)
        {
            // Cek apakah input kosong
            if (string.IsNullOrWhiteSpace(jabatan))
            {
                MessageBox.Show("Jabatan tidak boleh kosong!",
                                "Input Tidak Valid",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return false;
            }

            // Cek panjang jabatan (contoh: minimal 3 karakter, maksimal 30 karakter)
            if (jabatan.Length < 3 || jabatan.Length > 30)
            {
                MessageBox.Show("Jabatan harus terdiri dari 3 hingga 30 karakter!",
                                "Input Tidak Valid",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return false;
            }

            // Cek apakah jabatan hanya mengandung huruf dan spasi
            string pattern = @"^[A-Za-z\s]+$";
            if (!Regex.IsMatch(jabatan, pattern))
            {
                MessageBox.Show("Jabatan hanya boleh mengandung huruf dan spasi!",
                                "Input Tidak Valid",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return false;
            }

            // Cek apakah ada spasi ganda atau spasi di awal/akhir
            if (jabatan.Contains("  ") || jabatan.StartsWith(" ") || jabatan.EndsWith(" "))
            {
                MessageBox.Show("Jabatan tidak boleh mengandung spasi ganda atau spasi di awal/akhir!",
                                "Input Tidak Valid",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return false;
            }

            // Opsional: Jika ada daftar jabatan yang diperbolehkan
            string[] daftarJabatan = { "Manager", "Supervisor", "Staff", "Intern" };
            if (!Array.Exists(daftarJabatan, x => x.Equals(jabatan, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show($"Jabatan \"{jabatan}\" tidak valid! Pilih dari: {string.Join(", ", daftarJabatan)}",
                                "Input Tidak Valid",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return false;
            }

            // Jika semua validasi berhasil
            return true;
        }

        public static bool ValidasiGaji(string gajiText)
        {
            if (string.IsNullOrWhiteSpace(gajiText))
            {
                MessageBox.Show("Gaji tidak boleh kosong.", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!decimal.TryParse(gajiText, out decimal gaji) || gaji <= 0)
            {
                MessageBox.Show("Gaji harus berupa angka positif.", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }



        // Validasi Tanggal Penjualan
        public bool ValidasiTanggalPenjualan(DateTime tanggal)
        {
            // Pastikan tanggal tidak kosong
            if (tanggal == null)
            {
                MessageBox.Show("Tanggal penjualan tidak boleh kosong.", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Pastikan tanggal penjualan tidak lebih dari hari ini
            if (tanggal > DateTime.Now)
            {
                MessageBox.Show("Tanggal penjualan tidak boleh lebih dari tanggal hari ini.", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        public bool ValidasiIdPenjualan(string idPenjualan)
        {
            if (string.IsNullOrWhiteSpace(idPenjualan))
            {
                MessageBox.Show("ID Penjualan tidak boleh kosong.", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(idPenjualan, @"^[A-Za-z]{2}\d{3}$"))
            {
                MessageBox.Show("ID Penjualan harus terdiri dari 2 huruf di depan dan 3 angka di belakang (misalnya AB123).", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }



        // Validasi Total Transaksi
        public bool ValidasiTotalTransaksi(decimal totalTransaksi)
        {
            // Pastikan total transaksi lebih besar dari 0
            if (totalTransaksi <= 0)
            {
                MessageBox.Show("Total transaksi harus lebih besar dari 0.", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validasi bahwa total transaksi berada dalam rentang yang wajar (misalnya 1 sampai 1.000.000)
            if (totalTransaksi > 1000000)  // Sesuaikan dengan kisaran yang wajar di sistem Anda
            {
                MessageBox.Show("Total transaksi tidak boleh lebih dari 1.000.000.", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Pastikan total transaksi memiliki format desimal yang tepat (maksimal dua angka desimal)
            if (totalTransaksi % 0.01m != 0)
            {
                MessageBox.Show("Total transaksi harus menggunakan dua angka desimal yang valid.", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        public static bool ValidasiSubtotal(string subtotal)
        {
            if (string.IsNullOrWhiteSpace(subtotal))
            {
                MessageBox.Show("Subtotal tidak boleh kosong!", "Validasi Subtotal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!decimal.TryParse(subtotal, out decimal parsedSubtotal) || parsedSubtotal <= 0)
            {
                MessageBox.Show("Subtotal harus berupa angka desimal positif!", "Validasi Subtotal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        public static bool ValidasiIdDetailPenjualan(string idDetailPenjualan)
        {
            // Cek apakah kosong
            if (string.IsNullOrWhiteSpace(idDetailPenjualan))
            {
                MessageBox.Show("ID Detail Penjualan tidak boleh kosong!",
                                "Validasi Gagal",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return false;
            }

            // Pastikan input hanya angka (menggunakan regex)
            if (!Regex.IsMatch(idDetailPenjualan, @"^\d+$"))
            {
                MessageBox.Show("ID Detail Penjualan hanya boleh terdiri dari angka!",
                                "Validasi Gagal",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
    }

}

