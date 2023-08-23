/* Задание 2
 * Написать скрипт, добавляющий в созданную БД vk 2-3 новые таблицы
 * (с перечнем полей, указанием индексов и внешних ключей) (CREATE TABLE)
 */
USE vk;
DROP TABLE IF EXISTS post_types;
CREATE TABLE post_types(
	       id SERIAL,
	post_type ENUM('post', 'article', 'audio', 'video', 'photo', 'gallery')
);

DROP TABLE IF EXISTS user_posts;
CREATE TABLE user_posts(
	     post_id SERIAL,
	     user_id BIGINT UNSIGNED NOT NULL,
	  created_at DATETIME DEFAULT NOW(),
	  updated_at DATETIME DEFAULT CURRENT_TIMESTAMP,
	post_type_id BIGINT UNSIGNED NOT NULL,
	        body TEXT,
	
	FOREIGN KEY(user_id) REFERENCES users(id),
	FOREIGN KEY(post_type_id) REFERENCES post_types(id)
);

DROP TABLE IF EXISTS post_attachments;
CREATE TABLE post_attachments(
	 post_id BIGINT UNSIGNED NOT NULL,
	media_id BIGINT UNSIGNED,
	
	PRIMARY KEY (post_id, media_id),

	FOREIGN KEY (post_id) REFERENCES user_posts(post_id),
	FOREIGN KEY (media_id) REFERENCES media(id)
);