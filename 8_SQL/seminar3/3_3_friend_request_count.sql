/*
 * Сколько заявок в друзья в каждом статусе? (таблица friend_requests) [GROUP BY]
 */

  SELECT
         status AS 'request_status',
         COUNT(*) AS 'status_count'
    FROM friend_requests
GROUP BY status
ORDER BY status;
