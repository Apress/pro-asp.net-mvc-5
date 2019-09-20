SET IDENTITY_INSERT Products ON;

insert Products (ProductID, Name, Description, Price, Category)
values
(1, 'P1', 'Product 1', '10.00', 'Clothing'),
(2, 'P2', 'Product 2', '20.00', 'Shoes'),
(3, 'P3', 'Product 3', '30.00', 'Other');

SET IDENTITY_INSERT Products OFF;
