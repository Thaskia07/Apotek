CREATE DATABASE apotek_nakii;
USE apotek_nakii;

CREATE TABLE ADMIN (
    id CHAR(10) PRIMARY KEY, 
    username VARCHAR(50) NOT NULL,
    PASSWORD VARCHAR(50) NOT NULL 
);

CREATE TABLE stok_obat (
    id_obat VARCHAR(10) PRIMARY KEY,
    nama_obat VARCHAR(100) NOT NULL,
    kategori VARCHAR(50) NOT NULL,
    jumlah INT NOT NULL,
    harga DECIMAL(10, 2) NOT NULL
);

-- Tabel PASIEN untuk menyimpan data pasien yang datang untuk resep obat
CREATE TABLE pasien (
    id_pasien VARCHAR(10) PRIMARY KEY,
    nama_pasien VARCHAR(100) NOT NULL,
    alamat VARCHAR(255),
    telepon VARCHAR(20)
);

-- Tabel RESEP_OBAT untuk mencatat resep obat yang diberikan oleh dokter
CREATE TABLE resep_obat (
    id_resep VARCHAR(10) PRIMARY KEY,
    id_pasien VARCHAR(10),
    tanggal_resep DATE NOT NULL,
    FOREIGN KEY (id_pasien) REFERENCES pasien(id_pasien)
);

-- Tabel DETAIL_RESEP untuk menyimpan detail obat yang diresepkan pada setiap resep
CREATE TABLE detail_resep (
    id_detail INT AUTO_INCREMENT PRIMARY KEY,
    id_resep VARCHAR(10),
    id_obat VARCHAR(10),
    jumlah INT NOT NULL,
    dosis VARCHAR(50),
    FOREIGN KEY (id_resep) REFERENCES resep_obat(id_resep),
    FOREIGN KEY (id_obat) REFERENCES stok_obat(id_obat)
);

-- Tabel karyawan untuk menyimpan data karyawan
CREATE TABLE karyawan (
    id_karyawan VARCHAR(10) PRIMARY KEY, -- ID unik untuk karyawan
    nama_karyawan VARCHAR(100) NOT NULL, -- Nama lengkap karyawan
    jabatan VARCHAR(50) NOT NULL, -- Jabatan dalam organisasi
    alamat_karyawan VARCHAR(255), -- Alamat karyawan
    telepon_karyawan VARCHAR(20), -- Nomor telepon karyawan
    gaji DECIMAL(15, 2) NOT NULL, -- Gaji karyawan
    tanggal_masuk DATE NOT NULL -- Tanggal masuk kerja
);

-- Tabel PENJUALAN untuk mencatat transaksi penjualan
CREATE TABLE penjualan (
    id_penjualan VARCHAR(10) PRIMARY KEY, -- ID unik untuk setiap transaksi penjualan
    tanggal_penjualan DATE NOT NULL, -- Tanggal transaksi
    id_karyawan VARCHAR(10), -- ID karyawan yang menangani penjualan
    total_transaksi DECIMAL(15, 2) NOT NULL, -- Total keseluruhan transaksi
    FOREIGN KEY (id_karyawan) REFERENCES karyawan(id_karyawan) -- Relasi ke tabel karyawan
);

-- Tabel DETAIL_PENJUALAN untuk menyimpan detail barang yang dijual dalam transaksi
CREATE TABLE detail_penjualan (
    id_detail_penjualan INT AUTO_INCREMENT PRIMARY KEY, -- ID unik untuk setiap detail penjualan
    id_penjualan VARCHAR(10), -- ID transaksi penjualan
    id_obat VARCHAR(10), -- ID obat yang dijual
    jumlah INT NOT NULL, -- Jumlah barang yang dijual
    subtotal DECIMAL(15, 2) NOT NULL, -- Harga total untuk barang tersebut
    FOREIGN KEY (id_penjualan) REFERENCES penjualan(id_penjualan), -- Relasi ke tabel penjualan
    FOREIGN KEY (id_obat) REFERENCES stok_obat(id_obat) -- Relasi ke tabel stok obat
);


INSERT INTO stok_obat (id_obat, nama_obat, kategori, jumlah, harga)
VALUES 
('OB001', 'Paracetamol', 'Analgesik', 100, 5000),
('OB002', 'Amoxicillin', 'Antibiotik', 50, 10000);

INSERT INTO pasien (id_pasien, nama_pasien, alamat, telepon) VALUES
('P001', 'John Doe', 'Jl. Merdeka No. 1', '08123456789'),
('P002', 'Jane Smith', 'Jl. Sejahtera No. 3', '08223456789');

-- Menambah resep obat
INSERT INTO resep_obat (id_resep, id_pasien, tanggal_resep) VALUES
('R001', 'P001', '2024-11-23'),
('R002', 'P002', '2024-11-22');

-- Menambah detail resep obat
INSERT INTO detail_resep (id_resep, id_obat, jumlah, dosis) VALUES
('R001', 'OB001', 2, '3x sehari'),
('R001', 'OB002', 1, '2x sehari'),
('R002', 'OB001', 1, '2x sehari');


-- Contoh data karyawan
INSERT INTO karyawan (id_karyawan, nama_karyawan, jabatan, alamat_karyawan, telepon_karyawan, gaji, tanggal_masuk)
VALUES
('K001', 'Andi Saputra', 'Apoteker', 'Jl. Sudirman No. 10', '081234567890', 5000000.00, '2020-01-10'),
('K002', 'Rina Melati', 'Kasir', 'Jl. Merdeka No. 20', '082345678901', 3500000.00, '2021-05-15'),
('K003', 'Budi Santoso', 'Gudang', 'Jl. Mawar No. 15', '083456789012', 3000000.00, '2022-03-01'),
('K004', 'Siti Aminah', 'Admin', 'Jl. Anggrek No. 25', '084567890123', 4000000.00, '2023-02-20');

-- Contoh data penjualan
INSERT INTO penjualan (id_penjualan, tanggal_penjualan, id_karyawan, total_transaksi) VALUES
('PJ001', '2024-11-24', 'K001', 15000),
('PJ002', '2024-11-24', 'K002', 10000);

-- Contoh detail penjualan
INSERT INTO detail_penjualan (id_penjualan, id_obat, jumlah, subtotal) VALUES
('PJ001', 'OB001', 2, 10000), -- 2 Paracetamol @5000
('PJ001', 'OB002', 1, 5000), -- 1 Amoxicillin @5000
('PJ002', 'OB001', 2, 10000); -- 2 Paracetamol @5000

DELIMITER //

CREATE TRIGGER KurangiStokSetelahPenjualan
AFTER INSERT ON detail_penjualan
FOR EACH ROW
BEGIN
    -- Kurangi stok obat sesuai dengan jumlah yang dijual
    UPDATE stok_obat
    SET jumlah = jumlah - NEW.jumlah
    WHERE id_obat = NEW.id_obat;

    -- Jika stok kurang dari 0, kembalikan stok dan tampilkan pesan error
    IF (SELECT jumlah FROM stok_obat WHERE id_obat = NEW.id_obat) < 0 THEN
        SIGNAL SQLSTATE '45000'
        SET MESSAGE_TEXT = 'Stok obat tidak mencukupi untuk penjualan.';
    END IF;
END //

DELIMITER ;





