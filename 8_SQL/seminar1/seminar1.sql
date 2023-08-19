-- Урок 1. Установка СУБД, подключение к БД, просмотр и создание таблиц
/* Задача 1
Создайте таблицу с мобильными телефонами, используя графический интерфейс. Необходимые поля таблицы: product_name (название товара), manufacturer (производитель), product_count (количество), price (цена). Заполните БД произвольными данными.
*/
-- создание таблиц
CREATE TABLE `geekbrains`.`mobile_phones` (
  `id_mobile_phones` INT NOT NULL AUTO_INCREMENT,
  `product_name` VARCHAR(100) NOT NULL,
  `manufacturer` VARCHAR(100) NOT NULL,
  `product_count` INT NULL,
  `price` INT NULL,
  PRIMARY KEY (`id_mobile_phones`));
-- наполнение нужными данными
INSERT INTO mobile_phones (product_name, manufacturer, product_count, price)
VALUES 
	('iphone1', 'apple', 1, 999),
	('galaxy3', 'samsung', 100, 899),
	('pixel2', 'google', 50, 959),
	('miphone8', 'xiaomi', 200, 499);

/* Задача 2
Напишите SELECT-запрос, который выводит название товара, производителя и цену для товаров, количество которых превышает 2
*/
-- создание таблиц
CREATE TABLE `geekbrains`.`mobile_phones` (
  `id_mobile_phones` INT NOT NULL AUTO_INCREMENT,
  `product_name` VARCHAR(100) NOT NULL,
  `manufacturer` VARCHAR(100) NOT NULL,
  `product_count` INT NULL,
  `price` INT NULL,
  PRIMARY KEY (`id_mobile_phones`));
-- наполнение нужными данными
INSERT INTO mobile_phones (product_name, manufacturer, product_count, price)
VALUES 
	('iphone1', 'apple', 1, 999),
	('galaxy3', 'samsung', 100, 899),
	('pixel2', 'google', 50, 959),
	('miphone8', 'xiaomi', 200, 499);
-- выборки данных
SELECT product_name, manufacturer, price FROM mobile_phones
WHERE product_count > 2;

/* Задача 3
Выведите SELECT-запросом весь ассортимент товаров марки “Samsung”.
*/
-- создание таблиц
CREATE TABLE `geekbrains`.`mobile_phones` (
  `id_mobile_phones` INT NOT NULL AUTO_INCREMENT,
  `product_name` VARCHAR(100) NOT NULL,
  `manufacturer` VARCHAR(100) NOT NULL,
  `product_count` INT NULL,
  `price` INT NULL,
  PRIMARY KEY (`id_mobile_phones`));
-- наполнение нужными данными
INSERT INTO mobile_phones (product_name, manufacturer, product_count, price)
VALUES 
	('iphone1', 'apple', 1, 999),
	('galaxy3', 'samsung', 100, 899),
	('pixel2', 'google', 50, 959),
	('miphone8', 'xiaomi', 200, 499);
-- выборки данных
SELECT * FROM mobile_phones
WHERE manufacturer = 'samsung';

/* Задача 4
С помощью SELECT-запроса с оператором LIKE / REGEXP найти:
4.1.* Товары, в которых есть упоминание "Iphone"
4.2.* Товары, в которых есть упоминание "Samsung"
4.3.* Товары, в названии которых есть ЦИФРЫ
4.4.* Товары, в названии которых есть ЦИФРА "8"
*/
-- создание таблиц
CREATE TABLE `geekbrains`.`mobile_phones` (
  `id_mobile_phones` INT NOT NULL AUTO_INCREMENT,
  `product_name` VARCHAR(100) NOT NULL,
  `manufacturer` VARCHAR(100) NOT NULL,
  `product_count` INT NULL,
  `price` INT NULL,
  PRIMARY KEY (`id_mobile_phones`));
-- наполнение нужными данными
INSERT INTO mobile_phones (product_name, manufacturer, product_count, price)
VALUES 
	('iphone1', 'apple', 1, 999),
	('galaxy3', 'samsung', 100, 899),
	('pixel2', 'google', 50, 959),
	('miphone8', 'xiaomi', 200, 499);
-- выборки данных
-- Товары, в которых есть упоминание "Iphone"
SELECT * FROM mobile_phones
WHERE product_name LIKE '%iphone%';
-- Товары, в которых есть упоминание "Samsung"
SELECT * FROM mobile_phones
WHERE manufacturer REGEXP '.*samsung.*';
-- Товары, в названии которых есть ЦИФРЫ
SELECT * FROM mobile_phones
WHERE product_name REGEXP '[0-9]';
-- Товары, в названии которых есть ЦИФРА "8"
SELECT * FROM mobile_phones
WHERE product_name REGEXP '8';
  

