GRANT ALL PRIVILEGES ON * . * TO 'dbuser'@'%';
FLUSH PRIVILEGES;
CREATE DATABASE IF NOT EXISTS blockbuster CHARACTER SET utf8 COLLATE utf8_general_ci;
use blockbuster;
DROP TABLE IF EXISTS `customer`;
CREATE TABLE `customer` (
  `id` varchar(40) COLLATE utf8_unicode_ci NOT NULL,
  `email` varchar(60) COLLATE utf8_unicode_ci NOT NULL,
  `password` varchar(60) COLLATE utf8_unicode_ci NOT NULL,
  `first_name` varchar(40) COLLATE utf8_unicode_ci NOT NULL,
  `last_name` varchar(40) COLLATE utf8_unicode_ci NOT NULL,
  `created_at` timestamp DEFAULT CURRENT_TIMESTAMP,
  `updated_at` timestamp DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`),
  UNIQUE KEY `email` (`email`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;