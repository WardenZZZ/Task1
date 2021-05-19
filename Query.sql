CREATE TABLE Product ( 
	id int primary key,
	"Name" text
	);
CREATE TABLE Category (
	id int primary key,
	"Name" text
	);
CREATE TABLE ProductCategory (
	ProductId int foreign key references Product(id),
	CategoryId int foreign key references Category(id)
	);
INSERT INTO Product VALUES
	(1, '��������'),
	(2, '�����'),
	(3, '���������� �������'),
	(4, '�������');
INSERT INTO Category VALUES
	(1, '������������ ������'),
	(2, '������������� �������'),
	(3, '������� �����');
INSERT INTO ProductCategory VALUES
	(1, 1),
	(2, 1),
	(3,	3);
SELECT prdct.Name as '�������� ��������', ctgr.Name as '��������� ��������'
FROM Product prdct
LEFT JOIN ProductCategory prdctCtgr
ON prdct.id = prdctCtgr.ProductId
LEFT JOIN Category ctgr
ON prdctCtgr.CategoryId = ctgr.id
