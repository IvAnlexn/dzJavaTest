/*
 * Написать скрипт, возвращающий список имен (только firstname) пользователей без повторений в алфавитном порядке. [ORDER BY]
 */
  SELECT DISTINCT firstname
    FROM users
ORDER BY firstname ASC;
