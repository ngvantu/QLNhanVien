INSERT INTO employees (FullName, Birthday, Identity, ImageID, IsUsed, Role) VALUES 
('Tú', '1997-12-29', '123456', 'abc', true, 'admin'),
('Hiệp', '1997-1-1', '123456', 'abc', true, 'employee'),
('Nhân Viên', '1997-2-2', '123456', 'abc', true, 'employee');
select * from employees;

INSERT INTO typetickets (TypeName, Price) VALUES
('Người lớn', 100000),
('Trẻ em', 50000);

select * from typetickets;

INSERT INTO customers (FullName,Birthday,Email,PhoneNumber,Identity) VALUES
('Abc', '2000-1-1', 'abc@gmail.com', '123456', '123');
INSERT INTO cards (CusID,TypeID,IsUsed) VALUES 
(1, 1, 1);

select * from cards