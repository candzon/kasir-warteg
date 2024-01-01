-- --------------------------------------------------------
-- Host:                         localhost
-- Server version:               8.0.30 - MySQL Community Server - GPL
-- Server OS:                    Win64
-- HeidiSQL Version:             12.4.0.6659
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

-- Dumping structure for table db_kasir.detail_transaksi
CREATE TABLE IF NOT EXISTS `detail_transaksi` (
  `id_transaksi` char(6) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `id_paket` char(6) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `harga` int DEFAULT NULL,
  `jumlah` tinyint DEFAULT NULL,
  `total_harga` int DEFAULT NULL,
  KEY `FK_detail_transaksi_paket_makanan` (`id_paket`),
  KEY `FK_detail_transaksi_transaksi` (`id_transaksi`),
  CONSTRAINT `FK_detail_transaksi_paket_makanan` FOREIGN KEY (`id_paket`) REFERENCES `paket_makanan` (`id_paket`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `FK_detail_transaksi_transaksi` FOREIGN KEY (`id_transaksi`) REFERENCES `transaksi` (`id_transaksi`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Dumping data for table db_kasir.detail_transaksi: ~1 rows (approximately)
REPLACE INTO `detail_transaksi` (`id_transaksi`, `id_paket`, `harga`, `jumlah`, `total_harga`) VALUES
	('1', 'PKT003', 25000, 2, 50000);

-- Dumping structure for table db_kasir.kasir
CREATE TABLE IF NOT EXISTS `kasir` (
  `id_kasir` char(6) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `username` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `password` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `nama_kasir` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `role` int DEFAULT NULL,
  PRIMARY KEY (`id_kasir`),
  KEY `role` (`role`),
  CONSTRAINT `FK_kasir_tb_role` FOREIGN KEY (`role`) REFERENCES `tb_role` (`id_role`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Dumping data for table db_kasir.kasir: ~2 rows (approximately)
REPLACE INTO `kasir` (`id_kasir`, `username`, `password`, `nama_kasir`, `role`) VALUES
	('KSR001', 'irsad', 'irsad', 'Irsadul Asyrof', 1),
	('KSR002', 'budi', '12345', 'Budi', 2);

-- Dumping structure for table db_kasir.paket_makanan
CREATE TABLE IF NOT EXISTS `paket_makanan` (
  `id_paket` char(6) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `nama_paket` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT 'Pilih',
  `keterangan` varchar(100) DEFAULT NULL,
  `harga` int DEFAULT NULL,
  PRIMARY KEY (`id_paket`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Dumping data for table db_kasir.paket_makanan: ~5 rows (approximately)
REPLACE INTO `paket_makanan` (`id_paket`, `nama_paket`, `keterangan`, `harga`) VALUES
	('PKT001', 'PAKET CEBAN', 'nasi, telor, air putih/teh tawar', 10000),
	('PKT002', 'PAKET MABEL', 'nasi, sayur, telor, usus, orek, es teh manis', 15000),
	('PKT003', 'PAKET KENYANG', 'extra nasi, telor, extra usus, sayur, es teh manis', 25000),
	('PKT004', 'PAKET GOKIL', 'extra nasi, telor, extra usus, ayam goreng,  sayur, es teh manis', 38000),
	('PKT005', 'PAKET ANJAYY', 'extra nasi, telor, extra usus, ayam goreng,  sayur, es teh manis', 40000);

-- Dumping structure for table db_kasir.tb_role
CREATE TABLE IF NOT EXISTS `tb_role` (
  `id_role` int NOT NULL AUTO_INCREMENT,
  `nama_role` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`id_role`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Dumping data for table db_kasir.tb_role: ~2 rows (approximately)
REPLACE INTO `tb_role` (`id_role`, `nama_role`) VALUES
	(1, 'Kasir'),
	(2, 'HRD');

-- Dumping structure for table db_kasir.transaksi
CREATE TABLE IF NOT EXISTS `transaksi` (
  `id_transaksi` char(5) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `id_kasir` char(6) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `tanggal` datetime NOT NULL,
  PRIMARY KEY (`id_transaksi`),
  KEY `FK_transaksi_kasir` (`id_kasir`),
  CONSTRAINT `FK_transaksi_kasir` FOREIGN KEY (`id_kasir`) REFERENCES `kasir` (`id_kasir`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Dumping data for table db_kasir.transaksi: ~1 rows (approximately)
REPLACE INTO `transaksi` (`id_transaksi`, `id_kasir`, `tanggal`) VALUES
	('1', 'KSR001', '2023-06-12 13:47:40');

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
