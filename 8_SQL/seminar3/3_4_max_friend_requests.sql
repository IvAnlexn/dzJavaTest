/* Выведите номер пользователя, который отправил больше всех заявок в друзья
 * (таблица friend_requests) [LIMIT].
 */

  SELECT
         initiator_user_id AS 'max_friend_requests_user_number',
         COUNT(*) AS 'friend_requests_qnt'
    FROM friend_requests
GROUP BY initiator_user_id
ORDER BY 'friend_requests_qnt' DESC
   LIMIT 1;
