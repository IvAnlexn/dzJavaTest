/*
 * Заполнить 2 таблицы БД vk данными (по 10 записей в каждой таблице) (INSERT)
 */
USE vk;
INSERT INTO `users` (firstname, lastname, email, phone) 
     VALUES
     	('Petr', 'Petrov', 'pp@example.com', '78123452453'),
     	('Ivan', 'Ivanov', 'ii@example.com', '78123423957'),
     	('Elena', 'Kuznetsova', 'ek@example.com', '78122342521'),
     	('Denis', 'Denisov', 'dd@example.com', '78124892345'),
     	('Mark', 'Markov', 'mm@example.com', '78128024829'),
     	('Stepan', 'Stepanov', 'ss@example.com', '78128729572'),
     	('Afon', 'Afonov', 'aa@example.com', '78125025392'),
     	('Grigoriy', 'Grigoriev', 'gg@example.com', '78135384659'),
     	('Maria', 'Lukina', 'ml@example.com', '78135830275'),
     	('Natalia', 'Suvorova', 'ns@example.com', '78135037502');
     	
 INSERT INTO `profiles` (`user_id`, `gender`, `birthday`, `hometown`)
 	  VALUES
 	  	(1, 'm', '2001-12-13', 'Kaluga'),
 	  	(2, 'm', '2002-06-06', 'Moscow'),
 	  	(3, 'w', '1988-09-01', 'Saint-Petersburg'),
 	  	(4, 'm', '2010-01-01', 'Moscow'),
 	  	(5, 'm', '2005-03-08', 'Novosibirsk'),
 	  	(6, 'm', '1967-12-06', 'Vladivostok'),
 	  	(7, 'm', '2008-04-20', 'Omsk'),
 	  	(8, 'm', '2010-10-10', 'Perm'),
 	  	(9, 'w', '1997-05-12', 'Pskov'),
 	  	(10, 'w', '2002-11-11', 'Sochi');