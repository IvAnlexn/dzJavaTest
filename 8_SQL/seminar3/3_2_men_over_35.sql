/*
 * Выведите количество мужчин старше 35 лет [COUNT].
 */

SELECT COUNT(*) AS 'men over 35'
  FROM profiles
 WHERE gender LIKE 'm'
	     AND (birthday + INTERVAL 35 YEAR) < NOW();
