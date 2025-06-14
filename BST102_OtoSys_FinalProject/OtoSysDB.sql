-- ===============================================
-- !!! ÖNEMLİ UYARI !!!
-- Bu script, SQL Server Management Studio (SSMS) gibi araçlarda çalıştırılmak üzere hazırlanmıştır.
-- Her "GO" bloğu, komut ayırıcı olarak kullanılır ve ayrı ayrı çalıştırılmalıdır.
-- Lütfen scripti adım adım çalıştırın. Aksi takdirde hata alabilirsiniz.
-- ===============================================

-- ===========================
--   VERİTABANI OLUŞTURMA
-- ===========================

USE master;

CREATE DATABASE OtoSysDB;

USE OtoSysDB;
GO

-- ===========================
--   ARAÇ Tablosu OLUŞTURMA
-- ===========================

CREATE TABLE dbo.Arac (
    AracId INT IDENTITY(1000,2) PRIMARY KEY,
    UretimSeriNo  AS ('TRM1PRT' + RIGHT('00000' + CAST(AracId AS VARCHAR(5)), 5)) PERSISTED,
    Tur NVARCHAR(50) NOT NULL,
    Marka NVARCHAR(100) NOT NULL,
    Model NVARCHAR(100) NOT NULL,
    UretimBaslangicTarihi DATE NOT NULL,
    UretimBitisTarihi DATE NULL,
    MaliyetTutari DECIMAL(18,2) NOT NULL,
    SatisDurumu INT NOT NULL DEFAULT 1 CHECK (SatisDurumu IN (0, 1)), -- Enum şekinde olması için 1 satışda, 0 satıldı olarak düzenlendi.
    UretimAdedi INT NOT NULL DEFAULT 0
);
GO
-- Tür için kontrol kısıtı
ALTER TABLE dbo.Arac
ADD CONSTRAINT CHK_Tur_Tipi
CHECK (Tur IN (
    'SUV', 'Sedan', 'Hatchback', 'Pick-up', 'Coupe', 'Cabrio',
    'Minivan', 'MPV', 'Station Wagon', 'Panelvan', 'Kamyonet'
));
GO

-- ===========================
--   ÖRNEK VERİLERİ EKLEME
-- ===========================

INSERT INTO dbo.Arac (Tur, Marka, Model, UretimBaslangicTarihi, UretimBitisTarihi, MaliyetTutari, SatisDurumu, UretimAdedi)
VALUES
('MPV', 'Opel', 'Astra', '2018-07-01', '2020-09-25', 1372817, 0, 1487),
('Pick-up', 'Hyundai', 'Tucson', '2017-01-01', '2017-08-28', 1102567, 1, 977),
('MPV', 'Nissan', 'Qashqai', '2019-11-01', NULL, 896878, 0, 1085),
('Pick-up', 'Mazda', 'CX-5', '2024-07-01', '2025-04-21', 834253, 1, 790),
('SUV', 'Ford', 'Focus', '2024-02-01', '2024-08-20', 1007101, 1, 1493),
('Minivan', 'BMW', 'X5', '2019-11-01', '2021-10-27', 696301, 1, 280),
('Coupe', 'Skoda', 'Superb', '2017-02-01', '2019-01-31', 870091, 1, 663),
('Cabrio', 'Ford', 'Focus', '2022-04-01', '2024-04-27', 1496188, 1, 1463),
('Cabrio', 'Fiat', 'Egea', '2022-06-01', NULL, 1146751, 0, 543),
('Hatchback', 'Fiat', 'Egea', '2016-08-01', '2017-09-08', 1036841, 0, 1044),
('Sedan', 'Mazda', 'CX-5', '2023-09-01', '2025-11-21', 1491016, 1, 983),
('SUV', 'Jeep', 'Renegade', '2018-01-01', NULL, 757258, 0, 217),
('Cabrio', 'Jeep', 'Renegade', '2023-09-01', '2025-12-25', 901792, 1, 553),
('Sedan', 'Mazda', 'CX-5', '2022-10-01', '2024-09-18', 1130351, 0, 672),
('MPV', 'Mazda', 'CX-5', '2024-06-01', '2026-06-17', 1408122, 0, 142),
('Sedan', 'Nissan', 'Qashqai', '2019-11-01', '2020-09-10', 645723, 0, 353),
('Pick-up', 'Citroen', 'C4', '2019-02-01', NULL, 775389, 0, 1178),
('Cabrio', 'Toyota', 'RAV4', '2018-01-01', '2019-03-01', 1009169, 1, 903),
('Panelvan', 'Mitsubishi', 'L200', '2019-02-01', NULL, 636261, 1, 1029),
('Kamyonet', 'Mazda', 'CX-5', '2021-06-01', '2023-05-21', 1176822, 0, 123),
('Hatchback', 'Peugeot', '3008', '2024-04-01', NULL, 1417589, 1, 1034),
('Kamyonet', 'Honda', 'Civic', '2021-05-01', NULL, 1154115, 0, 269),
('MPV', 'Mercedes-Benz', 'C200', '2016-07-01', '2018-01-30', 1318509, 0, 1084),
('MPV', 'Nissan', 'Qashqai', '2017-07-01', '2018-03-10', 957771, 0, 1110),
('Pick-up', 'Ford', 'Focus', '2017-04-01', NULL, 1284760, 0, 1331),
('Hatchback', 'Subaru', 'Forester', '2022-06-01', '2023-04-16', 1212769, 1, 254),
('Panelvan', 'Citroen', 'C4', '2023-11-01', '2024-08-08', 998382, 1, 338),
('Station Wagon', 'Mercedes-Benz', 'C200', '2024-04-01', '2026-08-24', 1388037, 0, 923),
('Coupe', 'Citroen', 'C4', '2020-03-01', NULL, 1134190, 0, 1232),
('SUV', 'Citroen', 'C4', '2021-02-01', '2023-07-12', 817772, 0, 1205),
('SUV', 'Volkswagen', 'Golf', '2024-05-01', '2026-01-25', 1249860, 0, 682),
('Pick-up', 'Mitsubishi', 'L200', '2022-06-01', '2023-05-26', 761521, 0, 810),
('Panelvan', 'Renault', 'Clio', '2024-04-01', NULL, 1073032, 1, 401),
('Cabrio', 'Jeep', 'Renegade', '2016-03-01', NULL, 761096, 1, 1192),
('Pick-up', 'Mitsubishi', 'L200', '2017-11-01', '2019-03-03', 1391897, 0, 673);
GO
-- Sonuçları göster
SELECT * FROM dbo.Arac;
GO
