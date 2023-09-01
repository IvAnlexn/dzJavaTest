-- В этом домашнем задании для опеделения максимального колличества по агрегированному столбцу
-- я испльзую ORDER BY DESC и LIMIT 1. Как еще можно найти максимальное значение по агрегированному столбцу?
--
--
--
-- 1. Подсчитать количество групп (сообществ), в которые вступил каждый пользователь.
USE vk;
SELECT u.id, u.firstname, u.lastname, COUNT(c.community_id) AS communities_per_user
FROM users AS u
LEFT JOIN users_communities AS c ON u.id = c.user_id
GROUP BY u.id
ORDER BY communities_per_user DESC;

-- 2. Подсчитать количество пользователей в каждом сообществе.
SELECT c.name, COUNT(uc.user_id) AS users_per_communities
FROM communities AS c
LEFT JOIN users_communities AS uc ON c.id = uc.community_id
GROUP BY c.id
ORDER BY users_per_communities DESC;

-- 3. Пусть задан некоторый пользователь.
-- Из всех пользователей соц. сети найдите человека,
-- который больше всех общался с выбранным пользователем (написал ему сообщений).
SELECT firstname, lastname, COUNT(m.id) AS messages_sent
FROM messages AS m
LEFT JOIN users AS u ON from_user_id = u.id
WHERE to_user_id = 1
GROUP BY from_user_id
ORDER BY messages_sent DESC
LIMIT 1;

-- 4. Подсчитать общее количество лайков, которые получили пользователи младше 18 лет.
SELECT COUNT(l.id) AS total_likes
FROM likes AS l
JOIN profiles AS p ON l.user_id = p.user_id
WHERE (p.birthday + INTERVAL 18 YEAR) > NOW();

-- 5. Определить кто больше поставил лайков (всего): мужчины или женщины.
SELECT p.gender AS gender, COUNT(l.id) AS total_likes
FROM likes AS l
JOIN profiles AS p ON l.user_id = p.user_id
GROUP BY gender
ORDER BY total_likes DESC
LIMIT 1;
