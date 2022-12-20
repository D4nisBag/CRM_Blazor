-- SQLite
PRAGMA foreign_keys=on;

CREATE TABLE Customers
(
    id INTEGER PRIMARY KEY AUTOINCREMENT,
    name TEXT NOT NULL,
    surname TEXT NOT NULL,
    lastname TEXT,
    email TEXT,
    phone_number TEXT,
    login TEXT,
    password TEXT
);

CREATE TABLE Orders
(
    id INTEGER PRIMARY KEY AUTOINCREMENT,
    order_name TEXT,
    dispatch_adress TEXT,
    target_adress TEXT,
    weight TEXT,
    sending_product TEXT,
    status TEXT DEFAULT 'opened',
    message TEXT,
    customer_id INTEGER NOT NULL,
    FOREIGN KEY (customer_id) REFERENCES Customers(id)
);

INSERT INTO Customers (id,name,surname,lastname,email,phone_number,login,password)
VAlUES
(1, 'Danis', 'Bagautdinov', 'Ilmasovitch', 'dan.daniskin@mail.ru', '+79375931382', 'dandaniskin', 'password'),
(2, 'Ivan', 'Ivanov', 'Ivanovitch', 'ivan.ivankin@mail.ru', '+79175532332', 'ivano', '123'),
(3, 'Petr', 'Petrov', 'Petrovitch', 'petya.clown@mail.ru', '+79375935355', 'petrisio', 'qwerty'),
(4, 'Dmitriy', 'Dimov', 'Clown', 'clown.privet@mail.ru', '+79812312561', 'dmetr', 'password'),
(5, 'Миша', 'Михайлов', 'Михайлович', 'test.mail@mail.ru', '+79375931382', 'm3hail', 'password'),
(6, 'Денис', 'Денисов', 'Денисович', 'nothing@mail.ru', '+79175532332', 'd3nis', '123'),
(7, 'Petr', 'Petrov', 'Petrovitch', 'petya.clown@mail.ru', '+79375935355', 'potrpirog', 'qwerty');

INSERT INTO Orders (id, order_name,dispatch_adress, target_adress, weight, sending_product, status, message, customer_id)
VAlUES
(1, 'Зявка на перевозку черепах', 'г.Казань, улица Пушкина, д.13', 'г.Казань, ул.Приозерная, д.2', '6 килограмма', '18 черепах', 'opened', 'Привет! хочу перевезти черепах к озеру!', '1'),
(2, 'Зявка на перевозку кошек', 'г.Казань, улица Пушкина, д.13', 'г.Казань, ул.Московская, д.16', '4 килограмма', '3 кошки', 'opened', 'Привет! хочу перевезти кошек к озеру!', '1'),
(3, 'Зявка на перевозку бетонной стены', 'г.Казань, улица Дружбы, д.13', 'г.Казань, ул.Свиньи, д.16', '200 килограмм', '1 бетонная стена', 'opened', 'Привет! хочу перевезти стену к своему дому!', '2');