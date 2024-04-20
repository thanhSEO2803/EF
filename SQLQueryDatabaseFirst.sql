create database DatabaseFirst
go
use DatabaseFirst

go
-- T?o b?ng Khoa
CREATE TABLE Khoa (
    MaKhoa INT PRIMARY KEY,
    TenKhoa NVARCHAR(MAX)
);

go
-- Thêm d? li?u m?u vào b?ng Khoa
INSERT INTO Khoa (MaKhoa, TenKhoa)
VALUES
    (1, 'CNTT'),
    (2, 'DT'),
    (3, 'CK');

go
-- T?o b?ng Lop
CREATE TABLE Lop (
    MaLop INT PRIMARY KEY,
    TenLop NVARCHAR(MAX)
);

go
-- Thêm d? li?u m?u vào b?ng Lop
INSERT INTO Lop (MaLop, TenLop)
VALUES
    (1, '21T3'),
    (2, '22T3'),
    (3, '22DT3'),
    (4, '23CK1');

go
-- T?o b?ng SinhVien
CREATE TABLE SinhVien (
    MaSinhVien INT PRIMARY KEY,
    HoTen NVARCHAR(MAX),
    Age INT,
    LopMaLop INT FOREIGN KEY REFERENCES Lop(MaLop),
    KhoaMaKhoa INT FOREIGN KEY REFERENCES Khoa(MaKhoa)
);

go
-- Thêm d? li?u m?u vào b?ng SinhVien
INSERT INTO SinhVien (MaSinhVien, HoTen, Age, LopMaLop, KhoaMaKhoa)
VALUES
    (1, 'Nguyen Van A', 20, 1, 1),
    (2, 'Nguyen Van E', 19, 2, 1),
    (3, 'Nguyen Van C', 22, 1, 1),
    (4, 'Tran Van B', 21, 2, 2),
    (5, 'Tran Van D', 21, 2, 2);