CREATE DATABASE BTL_QLKT
GO 
USE BTL_QLKT
GO 
CREATE TABLE tblKhoa
(
	sMaKhoa VARCHAR(12),
	sTenKhoa NVARCHAR(50),
	dNgayThanhLap DATETIME,

	CONSTRAINT PK_Khoa PRIMARY KEY(sMaKhoa)
)
GO
ALTER TABLE dbo.tblKhoa  ADD CONSTRAINT CK_NgayThanhLapKhoa CHECK(dNgayThanhLap <= GETDATE())
GO 
CREATE TABLE tblLop
(
	sMaLop VARCHAR(12),
	iSiSo INT,
	sTenLop NVARCHAR(50),
	sMaKhoa VARCHAR(12),

	CONSTRAINT PK_Lop PRIMARY KEY(sMaLop),
	CONSTRAINT FK_Lop_Khoa FOREIGN KEY(sMaKhoa) REFERENCES dbo.tblKhoa(sMaKhoa)
)
GO
ALTER TABLE dbo.tblLop ADD CONSTRAINT CK_SiSo CHECK(iSiSo <= 100)
GO 
CREATE TABLE tblSinhVien
(
	sMaSV VARCHAR(12),
	sHoTen NVARCHAR(50),
	dNgaySinh DATETIME,
	sGioiTinh NVARCHAR(8),
	sDiaChi NVARCHAR(50),
	sMail VARCHAR(30),
	sSDT VARCHAR(12),
	sMaLop VARCHAR(12),
	sMaKhoa VARCHAR(12),
	
	CONSTRAINT PK_SV PRIMARY KEY(sMaSV),
	CONSTRAINT FK_SV_Lop FOREIGN KEY(sMaLop) REFERENCES dbo.tblLop(sMaLop),
	CONSTRAINT FK_SV_Khoa FOREIGN KEY(sMaKhoa) REFERENCES dbo.tblKhoa(sMaKhoa)
)

GO
ALTER TABLE dbo.tblSinhVien ADD CONSTRAINT CK_GioiTinh CHECK(sGioiTinh = N'Nam' OR sGioiTinh = N'Nữ')
ALTER TABLE dbo.tblSinhVien ADD CONSTRAINT CK_NgaySinhSV CHECK(dNgaySinh <= GETDATE())
GO
CREATE TABLE tblKhenThuong
(
	sMaKT VARCHAR(12),
	dNgayLap DATETIME,
	sTenKT NVARCHAR(50),
	sHocKy NVARCHAR(20),
	sNamHoc VARCHAR(15),
	sMaKhoa VARCHAR(12),

	CONSTRAINT PK_KhenThuong PRIMARY KEY(sMaKT),
	CONSTRAINT FK_KT_Khoa FOREIGN KEY(sMaKhoa) REFERENCES dbo.tblKhoa(sMaKhoa)
)
GO
CREATE TABLE tblSV_KT 
(
	sMaKT VARCHAR(12),
	sMaSV VARCHAR(12),
	iSoTC INT,
	fDiemTB FLOAT,
	fDiemRL FLOAT,

	CONSTRAINT PK_SV_KT PRIMARY KEY(sMaKT, sMaSV),
	CONSTRAINT FK_SVKT_KT FOREIGN KEY(sMaKT) REFERENCES dbo.tblKhenThuong(sMaKT),
	CONSTRAINT FK_SVKT_SV FOREIGN KEY(sMaSV) REFERENCES dbo.tblSinhVien(sMaSV)
)
GO

INSERT INTO dbo.tblKhoa
(
    sMaKhoa,
    sTenKhoa,
    dNgayThanhLap
)
VALUES
(   'CNTT',   -- sMaKhoa - varchar(12)
    N'Công nghệ thông tin', -- sTenKhoa - nvarchar(50)
    '19930313'  -- dNgayThanhLap - datetime
),
(   'NNA',   -- sMaKhoa - varchar(12)
    N'Ngôn ngữ Anh', -- sTenKhoa - nvarchar(50)
    '19950425'  -- dNgayThanhLap - datetime
),
(   'QTKD',   -- sMaKhoa - varchar(12)
    N'Quản trị kinh doanh', -- sTenKhoa - nvarchar(50)
    '19950425'  -- dNgayThanhLap - datetime
),
(   'TCNH',   -- sMaKhoa - varchar(12)
    N'Tài chính ngân hàng', -- sTenKhoa - nvarchar(50)
    '19930123'  -- dNgayThanhLap - datetime
),
(   'LKT',   -- sMaKhoa - varchar(12)
    N'Luật kinh tế', -- sTenKhoa - nvarchar(50)
    '19960323'  -- dNgayThanhLap - datetime
),
(   'LQT',   -- sMaKhoa - varchar(12)
    N'Luật quốc tế', -- sTenKhoa - nvarchar(50)
    '19940812'  -- dNgayThanhLap - datetime
)
GO
INSERT INTO dbo.tblLop
(
    sMaLop,
    iSiSo,
    sTenLop,
    sMaKhoa
)
VALUES
(   '21A1',   -- sMaLop - varchar(12)
    40, -- iSiSo - int
    N'2110A01', -- sTenLop - nvarchar(50)
    'CNTT'  -- sMaKhoa - varchar(12)
),
(   '21B2',   -- sMaLop - varchar(12)
    41, -- iSiSo - int
    N'2110B02', -- sTenLop - nvarchar(50)
    'NNA'  -- sMaKhoa - varchar(12)
),
(   '21C3',   -- sMaLop - varchar(12)
    42, -- iSiSo - int
    N'2110C03', -- sTenLop - nvarchar(50)
    'QTKD'  -- sMaKhoa - varchar(12)
),
(   '21D4',   -- sMaLop - varchar(12)
    43, -- iSiSo - int
    N'2110D04', -- sTenLop - nvarchar(50)
    'TCNH'  -- sMaKhoa - varchar(12)
),
(   '21G5',   -- sMaLop - varchar(12)
    44, -- iSiSo - int
    N'2110G05', -- sTenLop - nvarchar(50)
    'LKT'  -- sMaKhoa - varchar(12)
),
(   '21AH6',   -- sMaLop - varchar(12)
    40, -- iSiSo - int
    N'2110H06', -- sTenLop - nvarchar(50)
    'LQT'  -- sMaKhoa - varchar(12)
)
GO
insert into tblKhenThuong(sMaKT,dNgayLap,sTenKT,sHocKy,sNamHoc,sMaKhoa)
values ('01','20221215',N'Đạt giải Nhất trong kì thi Olympic Tin học','I','2022-2023','CNTT')
insert into tblKhenThuong(sMaKT,dNgayLap,sTenKT,sHocKy,sNamHoc,sMaKhoa)
values ('02','20221005',N'Đạt giải Nhất trong kì thi Olympic Tiếng Anh','II','2021-2022','NNA')
insert into tblKhenThuong(sMaKT,dNgayLap,sTenKT,sHocKy,sNamHoc,sMaKhoa)
values ('03','20220505',N'Có thành tích học tậpvà rèn luyện tốt','II','2021-2022','QTKD')
insert into tblKhenThuong(sMaKT,dNgayLap,sTenKT,sHocKy,sNamHoc,sMaKhoa)
values ('04','20221012',N'Có thành tích học tậpvà rèn luyện tốt','I','2022-2023','TCNH')
insert into tblKhenThuong(sMaKT,dNgayLap,sTenKT,sHocKy,sNamHoc,sMaKhoa)
values ('05','20221130',N'Có thành tích học tậpvà rèn luyện tốt','I','2022-2023','LKT')
insert into tblKhenThuong(sMaKT,dNgayLap,sTenKT,sHocKy,sNamHoc,sMaKhoa)
values ('06','20220525',N'Đạt giải Nhì trong kì thi Olympic Tiếng Anh','II','2021-2022','LQT')

go
insert into tblSinhVien(sMaSV,sHoTen,dNgaySinh,sGioiTinh,sDiaChi,sMail,sSDT,sMaLop,sMaKHoa)
values ('211',N'Nguyễn Văn Dương','20031203',N'Nam',N'Đường 1, Quận Hai Bà Trưng, Thành phố Hà Nội','vanduong@gmail.com','0965440658','21A1','CNTT')
insert into tblSinhVien(sMaSV,sHoTen,dNgaySinh,sGioiTinh,sDiaChi,sMail,sSDT,sMaLop,sMaKHoa)
values ('212',N'Nguyễn Trung Hùng','20031203',N'Nam',N'Đường 2,Quận Hoàn Kiếm,Thành phố Hà Nội','hungtrung@gmail.com','0956638373','21B2','LKT')
insert into tblSinhVien(sMaSV,sHoTen,dNgaySinh,sGioiTinh,sDiaChi,sMail,sSDT,sMaLop,sMaKHoa)
values ('213',N'Nguyễn Thị An','20030318',N'Nữ',N'Đường 3,Quận Hoàng Mai,Thành phố Hà Nội','nguyenan@gmail.com','0345693048','21C3','LQT')
insert into tblSinhVien(sMaSV,sHoTen,dNgaySinh,sGioiTinh,sDiaChi,sMail,sSDT,sMaLop,sMaKHoa)
values ('214',N'Nguyễn Văn Dương','20030312',N'Nam',N'Đường 1,Quận Hai Bà Trưng,Thành phố Hà Nội','minhvan@gmail.com','0354443746','21D4','NNA')
insert into tblSinhVien(sMaSV,sHoTen,dNgaySinh,sGioiTinh,sDiaChi,sMail,sSDT,sMaLop,sMaKHoa)
values ('215',N'Trần Văn Thành','20030322',N'Nam',N'Đường 5,Quận Thanh Xuân,Thành phố Hà Nội','thanhvan@gmail.com','0956440659','21G5','QTKD')
insert into tblSinhVien(sMaSV,sHoTen,dNgaySinh,sGioiTinh,sDiaChi,sMail,sSDT,sMaLop,sMaKHoa)
values ('216',N'Phan Anh Vũ','20030916',N'Nữ',N'Đường 6,Quận Thanh Xuân,Thành phố Hà Nội','pavzz@gmail.com','0911112233','21AH6','TCNH')
go

go
insert into tblSV_KT(sMaKT,sMaSV,iSoTC,fDiemTB,fDiemRL)
values ('01','211',50,9.0,88)
insert into tblSV_KT(sMaKT,sMaSV,iSoTC,fDiemTB,fDiemRL)
values ('02','212',47,8.7,82)
insert into tblSV_KT(sMaKT,sMaSV,iSoTC,fDiemTB,fDiemRL)
values ('03','213',45,8.5,85)
insert into tblSV_KT(sMaKT,sMaSV,iSoTC,fDiemTB,fDiemRL)
values ('04','214',45,9.2,81)
insert into tblSV_KT(sMaKT,sMaSV,iSoTC,fDiemTB,fDiemRL)
values ('05','215',44,8.6,86)
insert into tblSV_KT(sMaKT,sMaSV,iSoTC,fDiemTB,fDiemRL)
values ('06','216',48,8.2,90)

-- TẠO VIEW
--1. Tạo view sinh viên khoa CNTT
CREATE VIEW vvSV_CNTT
AS
	SELECT sHoTen, sMaSV FROM dbo.tblSinhVien, dbo.tblLop
	WHERE dbo.tblLop.sMaLop = dbo.tblSinhVien.sMaLop AND dbo.tblLop.sMaKhoa = 'CNTT'

	select *from tblLop
--2. Cho biết tên lớp và số lượng sinh viên từng lớp
CREATE VIEW vvSV_SoSV_TenLop
AS 
	select sTenLop, COUNT(sMaSV) AS N'Số SV'
	FROM dbo.tblSinhVien, dbo.tblLop
	WHERE dbo.tblSinhVien.sMaLop = dbo.tblLop.sMaLop
	GROUP BY sTenLop, dbo.tblSinhVien.sMaLop

	UPDATE dbo.tblLop SET iSiSo = vvSV_SoSV_TenLop.[Số SV] FROM dbo.tblLop INNER JOIN vvSV_SoSV_TenLop ON vvSV_SoSV_TenLop.sTenLop = tblLop.sTenLop
SELECT * FROM dbo.tblLop
--3. Tạo view cho biết sinh viên khen thưởng có số tín chỉ cao nhất
CREATE VIEW vvSV_SoTCMax
AS
	SELECT sHoTen, iSoTC
	FROM dbo.tblSinhVien, dbo.tblSV_KT
	WHERE dbo.tblSinhVien.sMaSV = dbo.tblSV_KT.sMaSV
	AND iSoTC = (SELECT MAX(iSoTC)FROM dbo.tblSV_KT)

--4. Tạo view tính tổng số tín có sinh viên học lực giỏi trở lên 
CREATE VIEW vvSV_TongSoTC_Gioi
AS
	SELECT SUM(iSoTC) AS N'Tổng số TC'
	FROM dbo.tblSV_KT
	WHERE fDiemRL >= 8.0
--5. Tạo view cho biết tên, mã sinh viên được học bổng(DTB >= 8.0 và DRL >= 80)
CREATE VIEW vvSV_HocBong_Gioi
AS
	SELECT dbo.tblSV_KT.sMaSV, sHoTen
	FROM dbo.tblSV_KT, dbo.tblSinhVien
	WHERE dbo.tblSV_KT.sMaSV = dbo.tblSinhVien.sMaSV AND
    fDiemTB >= 8.0 AND fDiemRL >= 80
SELECT * FROM vvSV_HocBong_Gioi

--Tạo thủ tục
--1. Tạo thủ tục in ra những học sinh có mã lớp được nhập vào

CREATE PROC prSV_Lop (@lop varchar(12))
AS
BEGIN
	SELECT * FROM dbo.tblSinhVien
	WHERE sMaLop = @lop
END
GO 
EXEC prSV_Lop '21A1'

--2. Tạo thủ tục in ra thông tin khen thưởng của sinh viên có mã được nhập vào
CREATE PROC prSV_KT (@maSV varchar(12))
AS
BEGIN
	SELECT * FROM dbo.tblKhenThuong, dbo.tblSV_KT
	WHERE dbo.tblSV_KT.sMaKT = dbo.tblKhenThuong.sMaKT AND dbo.tblSV_KT.sMaSV = @maSV
END
GO 
EXEC prSV_KT '211'

--3. Tạo thủ tục đếm số sinh viên khen thưởng, tên lớp của mã lớp được nhập vào
CREATE PROC prSV_soSVKT (@maLop varchar(12))
AS 
BEGIN
	SELECT sTenLop, COUNT(sMaSV) AS N'Số SV'
	FROM dbo.tblSinhVien, dbo.tblLop
	WHERE dbo.tblLop.sMaLop = dbo.tblSinhVien.sMaLop AND dbo.tblLop.sMaLop = @maLop
	GROUP BY sTenLop
END
GO
EXEC prSV_soSVKT '21A1'

--4. Tạo thủ tục cho biết cho biết số tín chỉ cao nhất
CREATE PROC pr_soTCMax (@maxSoTC int OUTPUT)
AS
BEGIN
    SELECT @maxSoTC = MAX(iSoTC)
	FROM dbo.tblSV_KT
END
GO
DECLARE @maxTC  INT = 0
EXEC pr_soTCMax @maxTC OUTPUT
SELECT @maxTC AS MaxTC

--5. Tạo thủ tục cho biết điểm trung bình cao nhất của sinh viên
CREATE PROC prDiemTBMax (@maxDTB int OUTPUT)
AS
BEGIN
    SELECT @maxDTB = MAX(fDiemTB)
	FROM dbo.tblSV_KT
END
GO
DECLARE @maxDTB INT = 0
EXEC prDiemTBMax @maxDTB OUTPUT
SELECT @maxDTB AS N'Max điểm TB'




--TẠO FUNCTION
--1. Hàm đổi trả ngày ra thứ tương ứng
CREATE FUNCTION fThu (@dNgay datetime)
RETURNS nvarchar(10)
BEGIN
    DECLARE @ketqua NVARCHAR(10)
	SELECT @ketqua = CASE DATEPART("dw", @dNgay) WHEN 1 THEN N'Chủ nhật'
												 WHEN 2 THEN N'Thứ hai'
												 WHEN 3 THEN N'Thứ ba'
												 WHEN 4 THEN N'Thứ tư'
												 WHEN 5 THEN N'Thứ năm'
												 WHEN 6 THEN N'Thứ sáu'
												 ELSE N'Thứ bảy'
												 END
     RETURN @ketqua                                           
END
GO 
SELECT dbo.fThu('20030428')

--2. Cho biết sĩ số SV theo mã lớp 
CREATE FUNCTION iSiSoLop (@sMaLop varchar(12))
RETURNS int
BEGIN
    DECLARE @iRes INT
	SELECT @iRes = iSiSo FROM dbo.tblLop
	WHERE @sMaLop = sMaLop

	RETURN @iRes
END
GO 
SELECT dbo.iSiSoLop('21A1')

--3. Cho biết tên khoa của sinh viên có mã SV được nhập vào
CREATE FUNCTION sTenKhoaTheoMaSV (@sMaSV varchar(12))
RETURNS nvarchar(50)
BEGIN
    DECLARE @sRes NVARCHAR(50)

	SELECT @sRes = sTenKhoa 
	FROM dbo.tblSinhVien, dbo.tblKhoa
	WHERE dbo.tblKhoa.sMaKhoa = dbo.tblSinhVien.sMaKhoa AND sMaSV = @sMaSV

	RETURN @sRes
END
GO
SELECT dbo.sTenKhoaTheoMaSV ('211') AS N'Ten Khoa'


--4. Viết hàm đưa ra danh sách sinh viên có năm được nhập vào
CREATE FUNCTION DSSinhVienTheoNam (@iNam int)
RETURNS TABLE
AS
    RETURN (SELECT * FROM dbo.tblSinhVien WHERE YEAR(dNgaySinh) = @iNam)

GO 
SELECT * FROM DSSinhVienTheoNam(2003)

--5. Cho biết các lớp có trong khoa vơi tên khoa đươc nhập vào
CREATE FUNCTION DSLopTrongKhoa(@sTenKhoa nvarchar(50))
RETURNS TABLE
AS
	RETURN (SELECT sMaLop, sTenLop, iSiSo FROM dbo.tblLop INNER JOIN dbo.tblKhoa ON tblKhoa.sMaKhoa = tblLop.sMaKhoa
			WHERE sTenKhoa = @sTenKhoa)

GO
SELECT * FROM DSLopTrongKhoa(N'Công nghệ thông tin')





--TẠO TRIGGER 

--1. Tạo trigger tự động tăng số sinh viên tưng lớp 
CREATE TRIGGER  tangSV
ON tblSinhVien
AFTER INSERT 
AS
BEGIN
    DECLARE @sMaLop VARCHAR(12), @sMaSV VARCHAR(12)
	SELECT @sMaLop = sMaLop, @sMaSV = sMaSV FROM inserted  
	
	    IF EXISTS(SELECT * FROM dbo.tblLop WHERE sMaLop = @sMaLop)
		BEGIN
		    UPDATE dbo.tblLop SET iSiSo = iSiSo + 1
			WHERE sMaLop = @sMaLop
		END
		ELSE 
		BEGIN
		    RAISERROR(N'Mã phòng %s chưa tồn tại', 16, 10, @sMaLop)
			ROLLBACK TRAN
		END
END
--2. Tạo Trigger để tự động tăng Sĩ số lớp trong bảng tblLop mỗi khi thêm mới dữ liệu cho bảng tblSinhVien. Nếu Sĩ số lớp > 50 thì không thêm vào đưa ra cảnh báo
Create TRIGGER tg_themSV
ON tblSinhVien FOR INSERT
AS
BEGIN
	DECLARE @siso INT;
	SELECT @siso = dbo.tblLop.iSiSo
	FROM dbo.tblLop, Inserted
	WHERE Inserted.sMaLop = dbo.tblLop.sMaLop;

	IF @siso > 50
	BEGIN
		RAISERROR(N'Đã quá 50 sinh viên!', 16, 10)
		ROLLBACK TRANSACTION
	END
	ELSE
	BEGIN
		UPDATE dbo.tblLop
		SET iSiSo = iSiSo + 1
		FROM dbo.tblLop, Inserted
		WHERE Inserted.sMaLop = dbo.tblLop.sMaLop;	
	END
END

SELECT * FROM dbo.tblLop
SELECT * FROM dbo.tblSinhVien


--Kiểm Tra kết quả Trigger
INSERT INTO tblSinhVien(sMaSV,sHoTen,dNgaySinh,sGioiTinh,sDiaChi,sMail,sSDT,sMaLop,sMaKHoa)
VALUES ('217',N'Nguyễn Văn Đông','20031104',N'Nam',N'Đường 7, Quận Thanh Xuân, Thành phố Hà Nội','vandong@gmail.com','0965845200','21A1','CNTT')

SELECT * FROM dbo.tblLop
SELECT * FROM dbo.tblSinhVien

--3. Tạo Trigger để tự động giảm Sĩ số lớp trong bảng tblLop mỗi khi xóa dữ liệu trong bảng tblSinhVien
CREATE TRIGGER tg_xoaSV
ON dbo.tblSinhVien FOR DELETE
AS
BEGIN
	DECLARE @siso INT;
	SELECT @siso = dbo.tblLop.iSiSo
	FROM dbo.tblLop, Deleted
	WHERE Deleted.sMaLop = dbo.tblLop.sMaLop;

	IF EXISTS (	SELECT Deleted.sMaSV 
				FROM dbo.tblSV_KT, deleted
				WHERE Deleted.sMaSV = tblSV_KT.sMaSV)
		BEGIN
		    RAISERROR(N'Sinh viên đã tồn tại trong bảng tblSV_KT!', 16, 10)
			ROLLBACK TRANSACTION
		END
	ELSE
	BEGIN
	    UPDATE dbo.tblLop
		SET iSiSo = iSiSo - 1
		FROM dbo.tblLop, Deleted
		WHERE Deleted.sMaLop = dbo.tblLop.sMaLop;	
	END
END

SELECT * FROM dbo.tblLop
SELECT * FROM dbo.tblSinhVien
SELECT * FROM dbo.tblSV_KT

--Kiểm tra kết quả Trigger 
DELETE FROM tblSinhVien
WHERE sMaSV = '217' AND sMaLop = '21A1';

--4. Tạo Trigger kiểm soát ngày lập KT phải sau ngày thành lập Khoa
CREATE TRIGGER tg_CheckNgayLap
ON dbo.tblKhenThuong FOR INSERT
AS
BEGIN
	DECLARE @NL DATETIME, @NLK DATETIME;
	SELECT @NL = dbo.tblKhenThuong.dNgayLap, @NLK = dbo.tblKhoa.dNgayThanhLap
	FROM dbo.tblKhoa, dbo.tblKhenThuong, Inserted
	WHERE Inserted.sMaKhoa = dbo.tblKhoa.sMaKhoa
	AND	Inserted.sMaKT = dbo.tblKhenThuong.sMaKT
	AND dbo.tblKhenThuong.sMaKhoa = dbo.tblKhoa.sMaKhoa;

	IF @NLK > @NL
	BEGIN
		RAISERROR(N'Ngày lập KT phải sau Ngày thành lập Khoa !', 16, 10)
		ROLLBACK TRANSACTION
	END
END
 
SELECT * FROM dbo.tblKhenThuong
SELECT * FROM dbo.tblKhoa

--Kiểm tra kết quả Trigger
INSERT INTO tblKhenThuong(sMaKT,dNgayLap,sTenKT,sHocKy,sNamHoc,sMaKhoa)
VALUES ('07','19921215',N'Đạt giải Nhì trong kì thi Olympic Tin học','I','2022-2023','CNTT')

--5. Tạo Trigger kiểm soát Sinh Viên phải ít nhất 18 tuổi
CREATE TRIGGER tg_Checktuoi
ON dbo.tblSinhVien FOR INSERT, UPDATE
AS
BEGIN
    DECLARE @NS DATETIME
	SELECT @NS = dNgaySinh
	FROM INSERTED

	IF (YEAR(GETDATE()) - YEAR(@NS) < 18)
	BEGIN
	    RAISERROR(N'Sinh Viên phải ít nhất 18 tuổi !', 16, 10)
		ROLLBACK TRANSACTION
	END
END

SELECT * FROM dbo.tblSinhVien
SELECT * FROM dbo.tblLop

--Kiểm tra Trigger
INSERT INTO dbo.tblSinhVien
(
    sMaSV,
    sHoTen,
    dNgaySinh,
    sGioiTinh,
    sDiaChi,
    sMail,
    sSDT,
    sMaLop,
    sMaKhoa
)
VALUES
(   '217',        -- sMaSV - varchar(12)
    N'Vũ Hậu',       -- sHoTen - nvarchar(50)
    GETDATE(), -- dNgaySinh - datetime
    N'Nam',       -- sGioiTinh - nvarchar(8)
    N'Hà Nam',       -- sDiaChi - nvarchar(50)
    'VH@gmail.com',        -- sMail - varchar(30)
    '069853255',        -- sSDT - varchar(12)
    '21G5',        -- sMaLop - varchar(12)
    'QTKD'         -- sMaKhoa - varchar(12)
    )



--Tạo login và user 
CREATE LOGIN HoangVietAnh
WITH PASSWORD = 'vanh28',
DEFAULT_DATABASE = BTL_QLKT
GO 
CREATE USER HoangVietAnh
FOR LOGIN HoangVietAnh


CREATE LOGIN TranVanMinhHoang
WITH PASSWORD = '1234',
DEFAULT_DATABASE = BTL_QLKT
GO 
CREATE USER TranVanMinhHoang
FOR LOGIN TranVanMinhHoang


CREATE LOGIN DangTrongVuong
WITH PASSWORD = '1234',
DEFAULT_DATABASE = BTL_QLKT
GO 
CREATE USER DangTrongVuong
FOR LOGIN DangTrongVuong


CREATE LOGIN NguyenThanhDuc
WITH PASSWORD = '1234',
DEFAULT_DATABASE = BTL_QLKT
GO 
CREATE USER NguyenThanhDuc
FOR LOGIN NguyenThanhDuc

--Phân quyền
--1. Cấp quyền cho người dùng HoangVietAnh thực thi tất cả trên bảng tblSinhVienuong
GRANT ALL PRIVILEGES
ON dbo.tblSinhVien
TO HoangVietAnh

--2. Cấp quyền cho người dùng TranVanMinhHoang tạo bảng, khung nhìn, thủ tục
GRANT CREATE TABLE, CREATE VIEW, CREATE PROCEDURE
TO TranVanMinhHoang

--3. Cấp quyền cho người dùng DangTrongVuong quền insert, update, delete trên bảng tblLop
GRANT DELETE, INSERT, UPDATE
ON dbo.tblLop
TO DangTrongVuong

--4. Cấp quyền cho người dùng NguyenThanhDuc quyền select, references trên bảng tblKhoa
GRANT SELECT, REFERENCES
ON dbo.tblKhoa
TO NguyenThanhDuc


CREATE TABLE tblSinhVienNu
(
	sMaSV VARCHAR(12) PRIMARY KEY,
	sHoTen NVARCHAR(50),
	dNgaySinh DATETIME,
	sGioiTinh NVARCHAR(8),
	sDiaChi NVARCHAR(50),
	sMail VARCHAR(30),
	sSDT VARCHAR(12), 
	sMaLop VARCHAR(12)
)


--Phân tán dữ liệu

GRANT ALL
ON tblSinhVienNam
TO PhanTan

--1. Phân tán ngang sinh viên theo sinh viên nữ và sinh viên nam

CREATE SYNONYM SVNam FOR dbo.tblSinhVienNam
CREATE SYNONYM SVNu FOR LINK.BTL_QLKT.dbo.tblSinhVienNu

INSERT INTO SVNu SELECT * FROM dbo.tblSinhVien WHERE sGioiTinh = N'Nữ'
INSERT INTO SVNam SELECT * FROM dbo.tblSinhVien WHERE sGioiTinh = N'Nam'

--2. Phân tán dọc Khen thưởng sang 2 bảng
--tblChiTietKT(sMaKT, dNgayLap, sTenKT)
--tblNamKT(sMakT, sHocKy, sNamHoc, sMaKhoa)

CREATE TABLE tblChiTietKT
(
	sMaKT VARCHAR(12) PRIMARY KEY,
	dNgayLap DATETIME,
	sTenKT NVARCHAR(50)
)
GRANT ALL
ON dbo.tblChiTietKT
TO PhanTan


CREATE SYNONYM ChiTietKT FOR dbo.tblChiTietKT
CREATE SYNONYM NamKT FOR LINK.BTL_QLKT.dbo.tblNamKT

INSERT INTO ChiTietKT SELECT sMaKT, dNgayLap, sTenKT FROM dbo.tblKhenThuong
INSERT INTO NamKT SELECT sMaKT, sHocKy, sNamHoc, sMaKhoa FROM dbo.tblKhenThuong


CREATE VIEW vv_SVNamVaNu
AS
	SELECT * FROM SVNam
	UNION
	SELECT * FROM SVNu

SELECT * FROM vv_SVNamVaNu

CREATE VIEW vv_KhenThuong
AS
	SELECT * FROM ChiTietKT, NamKT
	WHERE ChiTietKT.sMaKT = NamKT.sMaKT

GO 
SELECT * FROM dbo.tblSinhVien




--1
CREATE PROC prDSLop(@sTenKhoa nvarchar(50))
AS
BEGIN
    SELECT dbo.tblLop.sMaLop, sTenLop, COUNT(dbo.tblSinhVien.sMaSV) AS [So luong SV]
	FROM dbo.tblLop, dbo.tblSinhVien, dbo.tblKhoa
	WHERE dbo.tblLop.sMaLop = dbo.tblSinhVien.sMaLop AND dbo.tblLop.sMaKhoa = dbo.tblKhoa.sMaKhoa
	AND dbo.tblKhoa.sTenKhoa = @sTenKhoa -- 'Công nghệ thông tin'
	GROUP BY dbo.tblLop.sMaLop, sTenLop
END


--2
ALTER TABLE dbo.tblKhoa
ADD iSoLop INT 
GO
UPDATE dbo.tblKhoa SET iSoLop =a.dem FROM (SELECT COUNT(sMaLop) AS dem FROM dbo.tblLop GROUP BY sMaLop) AS a

GO 
CREATE TRIGGER tg_02TangSLLop
ON tblLop 
FOR INSERT, DELETE
AS 
BEGIN
    DECLARE @sMaKhoaThem VARCHAR(12) = NULL, @sMaKhoaXoa VARCHAR(12) = NULL 
	IF EXISTS (SELECT * FROM Inserted)
		SELECT @sMaKhoaThem = sMaKhoa FROM Inserted
	IF EXISTS (SELECT * FROM Deleted)
	SELECT @sMaKhoaXoa = sMaKhoa FROM Deleted

	IF(@sMaKhoaThem IS NOT NULL)
		UPDATE dbo.tblKhoa SET iSoLop = iSoLop + 1 WHERE sMaKhoa = @sMaKhoaThem
	IF(@sMaKhoaXoa IS NOT NULL)
		UPDATE dbo.tblKhoa SET iSoLop = iSoLop - 1 WHERE sMaKhoa = @sMaKhoaXoa
END


CREATE PROC pr_SelectTaiKhoan
AS
	SELECT sMaDangNhap, sTenDangNhap, sPassword FROM tblTaiKhoan

GO
CREATE PROC pr_ChangePassword(@sMaDangNhap VARCHAR(12), @sNewPassword VARCHAR(50))
AS
	UPDATE dbo.tblTaiKhoan SET sPassword = @sNewPassword WHERE sMaDangNhap = @sMaDangNhap

GO
CREATE PROC pr_SelectedSV
AS
	SELECT sMaSV, sHoTen, dNgaySinh, sGioiTinh, sDiaChi, sMail, sSDT, sMaLop FROM tblSinhVien

GO	
CREATE PROC pr_SelectedSVKT
AS
	SELECT dbo.tblSinhVien.sMaSV, sHoTen, dNgaySinh, sGioiTinh, sDiaChi, sMail, sSDT, sMaLop FROM dbo.tblSinhVien INNER JOIN dbo.tblSV_KT on dbo.tblSinhVien.sMaSV = dbo.tblSV_KT.sMaSV

go 

create proc pr_SelectLop
as
	select * from tblLop

go
create proc pr_DeleteSV(@sMaSV varchar(12))
as 
	if EXISTS(SELECT * FROM dbo.tblSV_KT WHERE sMaSV = @sMaSV)
	BEGIN
	    DELETE FROM dbo.tblSV_KT WHERE sMaSV = @sMaSV
		DELETE FROM dbo.tblSinhVien WHERE sMaSV = @sMaSV
	END
	ELSE
	BEGIN
	    DELETE FROM dbo.tblSinhVien WHERE sMaSV = @sMaSV
	END

GO 
CREATE PROC pr_InsertSV(@sMaSV VARCHAR(12), @sHoTen NVARCHAR(50), @dNgaySinh DATETIME, 
@sGioiTinh NVARCHAR(8), @sDiaChi NVARCHAR(50), @sMail VARCHAR(30), @sSDT VARCHAR(12), @sMaLop VARCHAR(12))
AS
	IF NOT EXISTS(SELECT * FROM dbo.tblSinhVien WHERE sMaSV = @sMaSV)
	BEGIN
	    INSERT INTO dbo.tblSinhVien
	    (
	        sMaSV,
	        sHoTen,
	        dNgaySinh,
	        sGioiTinh,
	        sDiaChi,
	        sMail,
	        sSDT,
	        sMaLop
	    )
	    VALUES
	    (   @sMaSV,   -- sMaSV - varchar(12)
	        @sHoTen, -- sHoTen - nvarchar(50)
	        @dNgaySinh, -- dNgaySinh - datetime
	        @sGioiTinh, -- sGioiTinh - nvarchar(8)
	        @sDiaChi, -- sDiaChi - nvarchar(50)
	        @sMail, -- sMail - varchar(30)
	        @sSDT, -- sSDT - varchar(12)
	        @sMaLop  -- sMaLop - varchar(12)
	        )
	END
	ELSE
	BEGIN
	    RAISERROR(N'Mã sinh viên không được trùng lặp !!!', 16, 10)
	END
GO 
CREATE PROC pr_UpdateSV(@sMaSV VARCHAR(12), @sHoTen NVARCHAR(50), @dNgaySinh DATETIME, 
@sGioiTinh NVARCHAR(8), @sDiaChi NVARCHAR(50), @sMail VARCHAR(30), @sSDT VARCHAR(12), @sMaLop VARCHAR(12))
AS
BEGIN
    UPDATE dbo.tblSinhVien SET sHoTen = @sHoTen, dNgaySinh = @dNgaySinh, sGioiTinh = @sGioiTinh, sDiaChi = @sDiaChi, sMail = @sMail, sMaLop = @sMaLop
	WHERE sMaSV = @sMaSV
END
GO 

CREATE PROC pr_SelectMaSV
AS
	SELECT sMaSV FROM dbo.tblSinhVien
GO
CREATE PROC pr_SelectMaKT
AS
	SELECT sMaKT FROM dbo.tblKhenThuong
GO
CREATE PROC pr_SelectSVKT
AS
	SELECT sMaKT, sMaSV, iSoTC, fDiemTB, fDiemRL FROM dbo.tblSV_KT

GO
CREATE PROC pr_SelectKhoa
AS
	SELECT sMaKhoa, sTenKhoa, dNgayThanhLap FROM dbo.tblKhoa 

GO
create proc pr_DeleteKhoa(@sMaKhoa varchar(12))
as 
	if EXISTS(SELECT * FROM dbo.tblKhoa WHERE sMaKhoa = @sMaKhoa)
	BEGIN
	    DELETE FROM dbo.tblKhoa WHERE sMaKhoa = @sMaKhoa
	END
GO 
CREATE PROC pr_InsertKhoa(@sMaKhoa VARCHAR(12), @sTenKhoa nvarchar(50), @dNgayThanhLap datetime)
AS
	IF NOT EXISTS(SELECT * FROM dbo.tblKhoa WHERE sMaKhoa = @sMaKhoa)
	BEGIN
	    INSERT INTO dbo.tblKhoa
	    (
	        sMaKhoa,
			sTenKhoa,
			dNgayThanhLap
	    )
	    VALUES
	    (   @sMaKhoa,   
	        @sTenKhoa,
			@dNgayThanhLap
	    )
	END
	ELSE
	BEGIN
	    RAISERROR(N'Mã khoa không được trùng lặp !!!', 16, 10)
	END
GO 
CREATE PROC pr_UpdateKhoa(@sMaKhoa varchar(12), @sTenKhoa nvarchar(50), @dNgayThanhLap datetime)
AS
BEGIN
    UPDATE dbo.tblKhoa SET sMaKhoa = @sMaKhoa, sTenKhoa = @sTenKhoa, dNgayThanhLap = @dNgayThanhLap
	WHERE sMaKhoa = @sMaKhoa
END
GO 

create proc pr_DeleteLop(@sMaLop varchar(12))
as 
	if EXISTS(SELECT * FROM dbo.tblLop WHERE sMaLop = @sMaLop)
	BEGIN
	    DELETE FROM dbo.tblLop WHERE sMaLop = @sMaLop
	END
GO 
CREATE PROC pr_InsertLop(@sMaLop varchar(12), @iSiSo int, @sTenLop nvarchar(50), @sMaKhoa varchar(12))
AS
	IF NOT EXISTS(SELECT * FROM dbo.tblLop WHERE sMaLop = @sMaLop)
	BEGIN
	    INSERT INTO dbo.tblLop
	    (
	        sMaLop,
			iSiSo,
			sTenLop,
			sMaKhoa
	    )
	    VALUES
	    (   
			@sMaLop,
			@iSiSo,
			@sTenLop,
			@sMaKhoa
	    )
	END
	ELSE
	BEGIN
	    RAISERROR(N'Mã lớp không được trùng lặp !!!', 16, 10)
	END
GO 
CREATE PROC pr_UpdateLop(@sMaLop varchar(12), @sTenLop nvarchar(50), @sMaKhoa varchar(12))
AS
BEGIN
    UPDATE dbo.tblLop SET sMaLop = @sMaLop, sTenLop = @sTenLop, sMaKhoa = @sMaKhoa
	WHERE sMaLop = @sMaLop
END
GO 

CREATE PROC pr_InsertSVKT(@sMaKT VARCHAR(12), @sMaSV VARCHAR(12), @iSoTC int, @fDiemTB float, @fDiemRL float)
AS
	INSERT INTO dbo.tblSV_KT
	(
	    sMaKT,
	    sMaSV,
	    iSoTC,
	    fDiemTB,
	    fDiemRL
	)
	VALUES
	(   @sMaKT,   -- sMaKT - varchar(12)
	    @sMaSV,   -- sMaSV - varchar(12)
	    @iSoTC, -- iSoTC - int
	    @fDiemTB, -- fDiemTB - float
	    @fDiemRL  -- fDiemRL - float
	    )

GO
CREATE PROC pr_UpdateSVKT(@sMaKT VARCHAR(12), @sMaSV VARCHAR(12), @iSoTC int, @fDiemTB float, @fDiemRL float)
AS
	UPDATE dbo.tblSV_KT SET iSoTC = @iSoTC, fDiemRL = @fDiemRL, fDiemTB = @fDiemTB WHERE sMaSV = @sMaSV AND sMaKT = @sMaKT

GO
CREATE PROC pr_DeleteSVKT(@sMaKT VARCHAR(12), @sMaSV VARCHAR(12))
AS
BEGIN
    DELETE dbo.tblSV_KT WHERE sMaKT = @sMaKT AND sMaSV = @sMaSV
END

GO
CREATE PROC pr_SelectMaKhoa
AS
	SELECT sMaKhoa FROM dbo.tblKhoa

GO
CREATE PROC pr_SelectKT
AS
	SELECT sMaKT, sTenKT, dNgayLap, sHocKy, sNamHoc, sMaKhoa FROM dbo.tblKhenThuong

GO
CREATE PROC pr_InsertKT(@sMaKT VARCHAR(12), @dNgayLap datetime, @sTenKT NVARCHAR(50), @sHocKy NVARCHAR(50), @sNamHoc VARCHAR(15), @sMaKhoa VARCHAR(12))
AS
BEGIN
    INSERT INTO dbo.tblKhenThuong
    (
        sMaKT,
        dNgayLap,
        sTenKT,
        sHocKy,
        sNamHoc,
        sMaKhoa
    )
    VALUES
    (   @sMaKT,   -- sMaKT - varchar(12)
        @dNgayLap, -- dNgayLap - datetime
        @sTenKT, -- sTenKT - nvarchar(50)
        @sHocKy, -- sHocKy - nvarchar(20)
        @sNamHoc, -- sNamHoc - varchar(15)
        @sMaKhoa  -- sMaKhoa - varchar(12)
        )
END
go
CREATE PROC pr_UpdateKT(@sMaKT VARCHAR(12), @dNgayLap datetime, @sTenKT nvarchar(50), @sHocKy nvarchar(20), sNamHoc varchar(15))
AS
	UPDATE dbo.tblKhenThuong SET  WHERE sMaKT = @sMaKT


GO
CREATE PROC pr_SelectBaoCaoSVKT
AS
BEGIN
    SELECT sMaSV, sTenLop, sHoTen, dNgaySinh, fDiemTB, sTenLop, fDiemRL FROM dbo.tblSinhVien, dbo.tblLop, dbo.tblSV_KT
	WHERE dbo.tblSinhVien.sMaLop = tblLop.sMaLop 
END

CREATE TABLE tblTaiKhoan
(
	sMaDangNhap VARCHAR(50) PRIMARY KEY,
	sTenDangNhap VARCHAR(50),
	sPassword NVARCHAR(50)
)
drop table tblTaiKhoan
insert into tblTaiKhoan(sMaDangNhap, sTenDangNhap, sPassword)
values ('01','abc','123')


CREATE PROC pr_KhenThuongCuaSV(@sMaSV VARCHAR(12))
as
	SELECT dbo.tblSinhVien.sMaSV, dbo.tblSinhVien.sHoTen, dbo.tblSinhVien.dNgaySinh, dbo.tblSV_KT.iSoTC, dbo.tblSV_KT.fDiemTB, dbo.tblSV_KT.fDiemRL, dbo.tblKhenThuong.sTenKT
	FROM dbo.tblSinhVien,dbo.tblSV_KT, dbo.tblKhenThuong
	WHERE dbo.tblSV_KT.sMaSV = @sMaSV AND  dbo.tblSinhVien.sMaSV = dbo.tblSV_KT.sMaSV AND dbo.tblKhenThuong.sMaKT = dbo.tblSV_KT.sMaKT