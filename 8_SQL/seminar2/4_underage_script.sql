/*
 * Написать скрипт, отмечающий несовершеннолетних пользователей 
 * как неактивных (поле is_active = true). 
 * При необходимости предварительно добавить такое поле
 * в таблицу profiles со значением по умолчанию = false (или 0) (ALTER TABLE + UPDATE)
 */
USE vk;
ALTER TABLE profiles 
 ADD COLUMN is_active BIT NOT NULL DEFAULT 0;

UPDATE profiles
   SET is_active = 0
 WHERE DATE_ADD(`birthday`, INTERVAL 18 YEAR) > CURDATE();