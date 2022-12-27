-- -- SQLite
PRAGMA foreign_keys=on;

-- CREATE TABLE Customers
-- (
--     id INTEGER PRIMARY KEY AUTOINCREMENT,
--     name TEXT NOT NULL,
--     surname TEXT NOT NULL,
--     lastname TEXT,
--     email TEXT,
--     phone_number TEXT,
--     login TEXT,
--     password TEXT
-- );

-- CREATE TABLE Orders
-- (
--     id INTEGER PRIMARY KEY AUTOINCREMENT,
--     order_name TEXT,
--     dispatch_adress TEXT,
--     target_adress TEXT,
--     weight TEXT,
--     sending_product TEXT,
--     status TEXT DEFAULT 'opened',
--     message TEXT,
--     customer_id INTEGER NOT NULL,
--     FOREIGN KEY (customer_id) REFERENCES Customers(id)
-- );

-- INSERT INTO Customers (id,name,surname,lastname,email,phone_number,login,password)
-- VAlUES
-- (1, 'Danis', 'Bagautdinov', 'Ilmasovitch', 'dan.daniskin@mail.ru', '+79375931382', 'dandaniskin', 'password'),
-- (2, 'Ivan', 'Ivanov', 'Ivanovitch', 'ivan.ivankin@mail.ru', '+79175532332', 'ivano', '123'),
-- (3, 'Petr', 'Petrov', 'Petrovitch', 'petya.clown@mail.ru', '+79375935355', 'petrisio', 'qwerty'),
-- (4, 'Dmitriy', 'Dimov', 'Clown', 'clown.privet@mail.ru', '+79812312561', 'dmetr', 'password'),
-- (5, 'Миша', 'Михайлов', 'Михайлович', 'test.mail@mail.ru', '+79375931382', 'm3hail', 'password'),
-- (6, 'Денис', 'Денисов', 'Денисович', 'nothing@mail.ru', '+79175532332', 'd3nis', '123'),
-- (7, 'Petr', 'Petrov', 'Petrovitch', 'petya.clown@mail.ru', '+79375935355', 'potrpirog', 'qwerty');

