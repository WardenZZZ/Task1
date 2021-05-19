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
	(1, 'Карамель'),
	(2, 'Зефир'),
	(3, 'Стиральный порошок'),
	(4, 'Колбаса');
INSERT INTO Category VALUES
	(1, 'Кондитерские товары'),
	(2, 'Хлебобулочные изделия'),
	(3, 'Бытовая химия');
INSERT INTO ProductCategory VALUES
	(1, 1),
	(2, 1),
	(3,	3);
SELECT prdct.Name as 'Название продукта', ctgr.Name as 'Категория продукта'
FROM Product prdct
LEFT JOIN ProductCategory prdctCtgr
ON prdct.id = prdctCtgr.ProductId
LEFT JOIN Category ctgr
ON prdctCtgr.CategoryId = ctgr.id
