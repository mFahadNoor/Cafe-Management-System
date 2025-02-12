--create database CafeSystem;
use CafeSystem;

create table userCustomer(
	id INT PRIMARY KEY IDENTITY(1,1),
	name varchar(255),
	username varchar(255),
	pass varchar(255),
	hasCard int default 0
)
create table userAdmin(
	id INT PRIMARY KEY IDENTITY(1,1),
	name varchar(255),
	username varchar(255),
	pass varchar(255)
)
create table userGuest(
	id INT PRIMARY KEY IDENTITY(1,1),
	name varchar(255),
)
CREATE TABLE Category (
    id INT PRIMARY KEY,
    description VARCHAR(255) UNIQUE NOT NULL
);
create table inventory(
	id int primary key,
	admin_id int,
	location varchar(255),
	foreign key (admin_id) references userAdmin(id)
)
CREATE TABLE item (
    id INT PRIMARY KEY identity(1,1),
    name VARCHAR(255) NOT NULL,
    quantity INT NOT NULL,
    price DECIMAL(10, 2) NOT NULL,
    category_id INT,
	inventory_id int,
    FOREIGN KEY (category_id) REFERENCES Category(id),
	FOREIGN KEY (inventory_id) REFERENCES inventory(id)
);
create table Cart(
	id int Primary Key Identity(1,1),
	customer_id INT,
	guest_id int,
	isPaid int default 0,
    FOREIGN KEY (guest_id) REFERENCES userGuest(id),
	FOREIGN KEY (customer_id) REFERENCES userCustomer(id)
);
create table TableInfo(
	id int primary key,
	capacity int,
	isAvailable int, --1 = true, 0 = false
	customer_id int,
	foreign key (customer_id) references userCustomer(id)
)
create table item_cart(
	id int identity(1,1) primary key,
	item_id int,
	item_name varchar(255),
	cart_id int,
    quantity INT,
	foreign key (item_id) references item(id),
	foreign key (cart_id) references cart(id),
)
create table purchaseHistory(
	id int primary key identity(1,1),
	cart_id int,
	customer_id int,
	table_id int,
	foreign key (item_cart_id) references item_cart(id),
	foreign key (customer_id) references usercustomer(id),
	foreign key (table_id) references tableInfo(id)
)
create table CreditCard(
	customer_id int primary key,
	pin int,
	number int,
	expiry varchar(50),
	foreign key (customer_id) references usercustomer(id)
)



-- Insert sample data into Category table
INSERT INTO userAdmin(name, username, pass) VALUES ('admin', 'admn', 'a');
insert into Cart(customer_id, isPaid) values(1, 0);
Insert into userCustomer(name, username, pass) VALUES ('hassan', 'hasun', 'h');
insert into inventory(id, admin_id, location) VALUES (1, 1, 'Maldives');
INSERT INTO Category (id, description) VALUES
	(1, 'Coffee'),
	(2, 'Tea'),
	(3, 'Pastry'),
	(4, 'Sandwiches'),
	(5, 'Smoothies'),
	(6, 'Salads');
-- Insert sample data into item table
INSERT INTO item (name, quantity, price, category_id, inventory_id) VALUES
	('Espresso',20 , 2.50, 1, 1),
    ('Cappuccino', 30, 3.00, 1, 1),
    ('Latte', 40, 3.50, 1, 1),
    ('Americano', 100, 3.00, 1, 1),
    ('Mocha', 40, 4.00, 1, 1),
	('Green Tea', 50, 2.00, 2, 1),
    ('Black Tea', 60, 2.00, 2, 1),
    ('Earl Grey', 130, 2.50, 2, 1),
    ('Chai Tea', 50, 3.00, 2, 1),
    ('Herbal Tea', 90, 2.50, 2, 1),
	('Croissant', 100, 2.00, 3, 1),
    ('Muffin', 120, 2.50, 3, 1),
    ('Danish', 300, 2.50, 3, 1),
    ('Scone', 130, 2.00, 3, 1),
    ('Cinnamon Roll', 150, 3.00, 3, 1),
	('Turkey Sandwich', 30, 6.50, 4, 1),
    ('BLT Sandwich', 60, 7.00, 4, 1),
    ('Vegetarian Sandwich', 20, 6.00, 4, 1),
    ('Chicken Salad Sandwich', 50, 7.50, 4, 1),
    ('Club Sandwich', 70, 8.00, 4, 1),
	('Strawberry Banana Smoothie', 50, 5.50, 5, 1),
    ('Mango Pineapple Smoothie', 50, 6.00, 5, 1),
    ('Berry Blast Smoothie', 90, 5.50, 5, 1),
    ('Green Detox Smoothie', 80, 6.50, 5, 1),
    ('Tropical Paradise Smoothie', 70, 6.00, 5, 1),
	('Caesar Salad', 100, 8.50, 6, 1),
    ('Greek Salad', 110, 9.00, 6, 1),
    ('Cobb Salad', 120, 9.50, 6, 1),
    ('Chef Salad', 70, 8.00, 6, 1),
    ('Caprese Salad', 140, 7.50, 6, 1);
insert into TableInfo(id, capacity, isAvailable) values 
	(1, 5, 1),
	(2, 5, 1),
	(3, 5, 1),
	(4, 4, 1),
	(5, 2, 1),
	(6, 2, 1),
	(7, 2, 1),
	(8, 2, 1);

--==--Queries--==--
--number of items in each category bought by a customer
select count(i.name), cat.description from userCustomer uc
join Cart c on uc.id = c.customer_id
join item_cart ic on ic.cart_id = c.id
join item i on i.id = ic.item_id
join Category cat on cat.id = i.category_id
where uc.id = 1
group by cat.description
--get name of items bought by a customer
select i.name from usercustomer uc
join purchaseHistory uh on uc.id = uh.customer_id
join item_cart ic on uh.item_cart_id = ic.id
join item i on i.id = ic.item_id
group by i.name, i.id
having i.id = 1
--==3 table joins
--get number of items in a cart
select count(i.id), c.id from Cart c
join item_cart ic on c.id = ic.cart_id
join item i on i.id = ic.item_id
group by c.id
having c.id = 1
--which items are sold the most
select i.name, count(*) from item i
join item_cart ic on i.id = ic.item_id
join cart c on c.id = ic.cart_id
group by i.name, i.id
having i.id = 3
order by count(*) desc
--number of items bought by each customer
select uc.id, uc.name, count(ic.item_id) from userCustomer uc
join Cart c on c.customer_id = uc.id
join item_cart ic on ic.cart_id = c.id
group by uc.name, uc.id
having uc.id = 1
--==2 table joins
--number of carts of each customer, also represents how many orders a customer has made
select count(*) from userCustomer uc
join cart C on uc.id = c.customer_id
--number of items in a category
select cat.description, count(i.id) from Category cat
join item i on i.category_id = cat.id
group by cat.description
--number of items in an inventory
select inv.location, count(i.id) from inventory inv
join item i on i.inventory_id = inv.id
group by inv.location
--==nested subqueries
--number of inventories managed by each admin
select a.id,
    (select COUNT(inv.id) 
     from inventory inv 
     where a.id = inv.admin_id) as inventory_count
from userAdmin a;

--total stock available in category
select cat.description,
    (select SUM(i.quantity) 
     from item i 
     where i.category_id = cat.id) as total_quantity
from Category cat;
--total quantity of items in each cart
select c.id,
    (select SUM(ic.quantity) 
     from item_cart ic 
     where ic.cart_id = c.id) as total_quantity
from cart c;
--average price per category
select cat.description, 
    (select AVG(i.price) 
     from item i 
     where i.category_id = cat.id) as avg_price
from category cat;





CREATE PROCEDURE ApplyDiscount
    @CategoryId INT = NULL,
    @DiscountPercentage DECIMAL(10,2)
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE item
    SET price = price * (1 - @DiscountPercentage / 100)
    WHERE @CategoryId IS NULL OR category_id = @CategoryId;
END


CREATE VIEW InventoryView
AS
SELECT item.id AS ItemID, item.name AS ItemName, item.quantity AS Quantity,
       item.price AS Price, Category.description AS Category, inventory.location AS Location,
       userAdmin.name AS AdminName
FROM item
JOIN Category ON item.category_id = Category.id
JOIN inventory ON item.inventory_id = inventory.id
JOIN userAdmin ON inventory.admin_id = userAdmin.id;



CREATE VIEW ItemView
AS
SELECT i.id AS ItemID, i.name AS ItemName, i.quantity AS Quantity, i.price AS Price, c.description AS Category 
FROM item i 
JOIN Category c ON i.category_id = c.id;




CREATE VIEW PurchaseHistoryView
AS
SELECT 
    ph.id AS PurchaseID, 
    u.name AS CustomerName, 
    ic.item_name AS ItemName, 
    ic.quantity AS Quantity, 
    i.price AS Price, 
    c.description AS Category
FROM 
    purchaseHistory ph
full JOIN 
    item_cart ic ON ph.item_cart_id = ic.id
full JOIN 
    item i ON ic.item_id = i.id
full JOIN 
    Category c ON i.category_id = c.id
full JOIN
    userCustomer u ON ph.customer_id = u.id;

--Trigger to update customer's 'hasCard' attribute when user adds one
create trigger Update_hasCard
ON CreditCard
after insert, delete
as
begin
    declare @CustomerID INT;
    select @CustomerID = customer_id from inserted;

    from userCustomer
    set hasCard = CASE WHEN EXISTS (SELECT 1 FROM CreditCard WHERE customer_id = @CustomerID) THEN 1 ELSE 0 END
    where id = @CustomerID;
end;

--Trigger to prevent deletion of admin that currently manages some inventory
create trigger Prevent_Admin_Deletion
on userAdmin
instead of delete
as
begin
    SET NOCOUNT ON;
    declare @AdminID INT;
    select @AdminID = id FROM deleted;

    if not exists (select 1 from inventory where admin_id = @AdminID)
    begin
        DELETE FROM userAdmin WHERE id = @AdminID;
    end
    else
    begin
        RAISERROR ('Cannot delete admin user associated with inventory.', 16, 1);
    end
end;

