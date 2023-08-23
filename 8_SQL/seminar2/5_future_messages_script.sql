/*
 * Написать скрипт, удаляющий сообщения «из будущего» (дата позже сегодняшней) (DELETE)
 */
USE vk;

DELETE FROM messages
      WHERE created_at > CURDATE();