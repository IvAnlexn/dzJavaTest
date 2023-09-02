-- 1. Создайте представление с произвольным SELECT-запросом из прошлых уроков [CREATE VIEW]
CREATE VIEW users_communities_count AS
     SELECT u.id, u.firstname, u.lastname, COUNT(c.community_id) AS communities_per_user
       FROM users AS u
  LEFT JOIN users_communities AS c ON u.id = c.user_id
   GROUP BY u.id
   ORDER BY communities_per_user DESC;

-- 2. Выведите данные, используя написанное представление [SELECT]
SELECT *
  FROM users_communities_count;

-- 3. Удалите представление [DROP VIEW]
DROP VIEW users_communities_count;

/*
4. Сколько новостей (записей в таблице media) у каждого пользователя?
Вывести поля: news_count (количество новостей),
user_id (номер пользователя), user_email (email пользователя).
Попробовать решить с помощью CTE или с помощью обычного JOIN.
*/

-- Решение с помощью JOIN
  SELECT u.id, u.email, COUNT(m.id) AS news_count
    FROM users AS u
    JOIN media AS m ON u.id = m.user_id
GROUP BY u.id
ORDER BY u.id ASC;

-- Решение с помощью CTE
WITH media_count AS (
	  SELECT user_id, COUNT(id) AS cnt
	    FROM media
	GROUP BY user_id
)
  SELECT m.user_id, u.email, m.cnt
    FROM media_count AS m
    JOIN users AS u ON u.id = m.user_id
ORDER BY m.user_id ASC;
