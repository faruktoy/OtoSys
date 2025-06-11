CREATE DATABASE OtoSysDB

USE OtoSysDB

CREATE TABLE Arac (
    AracId INT PRIMARY KEY IDENTITY(1,1), -- Otomatik artan, benzersiz kimlik numarasý
    SaseNo AS ('VWTRM' + RIGHT('00000' + CAST(AracId AS VARCHAR(5)), 5)) PERSISTED, -- Otomatik Saþe numarasý üreten alan
    Tur NVARCHAR(50) NOT NULL, -- SUV/Sedan gibi araç türü için metin alaný
    Marka NVARCHAR(100) NOT NULL, -- Araç markasý için metin alaný
    Model NVARCHAR(100) NOT NULL, -- Araç modeli için metin alaný
    UretimBaslangicTarihi DATE NOT NULL, -- Üretim baþlangýcý için sadece tarih tutan alan
    UretimBitisTarihi DATE NULL, -- Üretim bitiþi için tarih alaný, boþ olabilir
    MaliyetTutari DECIMAL(18, 2) NOT NULL, -- Maliyet için ondalýklý sayý alaný (örn: 150000.50)
    SatisDurumu NVARCHAR(20) NOT NULL DEFAULT 'Satýs_Aktif' CHECK (SatisDurumu IN ('Satýs_Pasif', 'Satýs_Aktif')) -- Sadece 'Satýldý' veya 'Satýlacak' deðerini alabilir
)

SELECT * FROM Arac

ALTER TABLE Arac
ADD UretimAdedi INT NOT NULL DEFAULT 0;

ALTER TABLE Arac
ADD CONSTRAINT CHK_Tur_Tipi
CHECK (Tur IN (
    'SUV', 'Sedan', 'Hatchback', 'Pick-up', 'Coupe', 'Cabrio',
    'Minivan', 'MPV', 'Station Wagon', 'Panelvan', 'Kamyonet'
))

SELECT name 
FROM sys.check_constraints 
WHERE parent_object_id = OBJECT_ID('Arac');

ALTER TABLE Arac DROP CONSTRAINT CK__Arac__SatisDurum__5DCAEF64; 

ALTER TABLE Arac
ADD CONSTRAINT CHK_SatisDurumu
CHECK (SatisDurumu IN ('Satýldý', 'Satýlacak'));

INSERT INTO Arac (Tur, Marka, Model, UretimBaslangicTarihi, UretimBitisTarihi, MaliyetTutari, SatisDurumu, UretimAdedi) VALUES
('SUV', 'Toyota', 'RAV4', '2020-01-01', '2022-12-31', 850000.00, 'Satýldý', 1200),
('Sedan', 'Honda', 'Accord', '2019-05-15', '2021-11-30', 780000.00, 'Satýldý', 950),
('Hatchback', 'Volkswagen', 'Golf', '2021-03-01', NULL, 695000.00, 'Satýlacak', 500),
('Pick-up', 'Ford', 'Ranger', '2022-07-01', NULL, 925000.00, 'Satýlacak', 430),
('Cabrio', 'BMW', 'Z4', '2018-04-10', '2020-09-20', 1230000.00, 'Satýldý', 150),
('Coupe', 'Mercedes-Benz', 'C200 Coupe', '2020-06-05', '2023-01-15', 1100000.00, 'Satýldý', 310),
('Minivan', 'Renault', 'Scenic', '2017-08-01', '2020-12-31', 625000.00, 'Satýldý', 800),
('MPV', 'Citroen', 'Berlingo', '2023-01-01', NULL, 710000.00, 'Satýlacak', 200),
('Station Wagon', 'Skoda', 'Octavia Combi', '2019-02-14', '2022-06-30', 770000.00, 'Satýldý', 420),
('Panelvan', 'Fiat', 'Doblo', '2018-01-01', '2021-01-01', 500000.00, 'Satýldý', 1500),
('Kamyonet', 'Isuzu', 'D-Max', '2019-06-01', '2022-05-01', 870000.00, 'Satýldý', 600),
('SUV', 'Peugeot', '3008', '2021-09-01', NULL, 815000.00, 'Satýlacak', 480),
('Sedan', 'Hyundai', 'Elantra', '2020-01-01', NULL, 690000.00, 'Satýlacak', 750),
('Hatchback', 'Ford', 'Focus', '2022-02-01', NULL, 740000.00, 'Satýlacak', 670),
('SUV', 'Dacia', 'Duster', '2018-05-10', '2020-10-15', 615000.00, 'Satýldý', 1100),
('Coupe', 'Audi', 'A5', '2019-03-20', '2021-07-30', 1180000.00, 'Satýldý', 275),
('Cabrio', 'Mini', 'Convertible', '2020-04-01', NULL, 1025000.00, 'Satýlacak', 90),
('Station Wagon', 'Opel', 'Insignia Sports Tourer', '2017-09-15', '2019-12-01', 695000.00, 'Satýldý', 380),
('Minivan', 'Volkswagen', 'Touran', '2016-03-01', '2019-07-31', 655000.00, 'Satýldý', 420),
('Pick-up', 'Mitsubishi', 'L200', '2021-01-01', NULL, 945000.00, 'Satýlacak', 390),
('MPV', 'Peugeot', 'Rifter', '2020-10-01', NULL, 720000.00, 'Satýlacak', 310),
('Panelvan', 'Citroen', 'Jumpy', '2019-04-01', '2023-02-01', 630000.00, 'Satýldý', 950),
('Hatchback', 'Kia', 'Ceed', '2018-08-01', '2021-01-31', 675000.00, 'Satýldý', 710),
('SUV', 'Jeep', 'Renegade', '2022-05-01', NULL, 980000.00, 'Satýlacak', 250),
('Sedan', 'Skoda', 'Superb', '2021-07-01', NULL, 890000.00, 'Satýlacak', 440);


-- Tablo oluþturma scripti
USE OtoSysDB;

-- Eðer tablo varsa:
SCRIPT Arac