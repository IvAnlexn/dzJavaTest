/*
 * Выведите названия и номера групп, имена которых состоят из 5 символов [LIKE].
 */

SELECT id AS 'community_id', name AS 'community_name'
  FROM communities
 WHERE name LIKE '_____';
