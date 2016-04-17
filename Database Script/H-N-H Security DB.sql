DROP DATABASE `hnh-db`;
CREATE DATABASE `hnh-db`;
USE `hnh-db`;

CREATE TABLE IF NOT EXISTS `users` (
  `id` bigint(20) NOT NULL AUTO_INCREMENT,
  `username` varchar(20) NOT NULL,
  `name` varchar(40) NOT NULL,
  `password` varchar(40) NOT NULL,
  `email` varchar(160) NOT NULL,
  `accountType` varchar(10)  NOT NULL DEFAULT 'Home Owner',
  `address` varchar(120) DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `id` (`id`,`username`),
  UNIQUE KEY `username` (`username`),
  UNIQUE KEY `email` (`email`)
) ENGINE=InnoDB DEFAULT CHARSET=utf32 COLLATE=utf32_unicode_ci AUTO_INCREMENT=1 ;

CREATE TABLE IF NOT EXISTS `floor_plans` (
  `id` bigint(20) NOT NULL AUTO_INCREMENT,
  `userid` bigint(20) NOT NULL,
  `name` varchar(40) NOT NULL,
  `picture` varchar(120) DEFAULT NULL,
  PRIMARY KEY (`id`,`userid`),
  UNIQUE KEY `id` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf32 COLLATE=utf32_unicode_ci AUTO_INCREMENT=1 ;
/*
The sensor id will not auto increment
the sensor id will be a unique value
given to the sensor by the administrator
the server will use this value to find the sensor
upon user request
*/
CREATE TABLE IF NOT EXISTS `sensors` (
  `id` bigint(20) NOT NULL,
  `floor_plan_id` bigint(20) NOT NULL,
  `name` varchar(40) NOT NULL,
  `type` varchar(40) DEFAULT NULL,
  `floor_plan_xpos` int(11) DEFAULT NULL,
  `floor_plan_ypos` int(11) DEFAULT NULL,
  `enabled` tinyint(1) NOT NULL DEFAULT '1',
  PRIMARY KEY (`id`,`floor_plan_id`),
  UNIQUE KEY `id` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf32 COLLATE=utf32_unicode_ci;

CREATE TABLE IF NOT EXISTS `lights` (
  `id` bigint(20) NOT NULL AUTO_INCREMENT,
  `floor_plan_id` bigint(20) NOT NULL,
  `name` varchar(40) NOT NULL,
  `floor_plan_xpos` int(11) DEFAULT NULL,
  `floor_plan_ypos` int(11) DEFAULT NULL,
  `ison` tinyint(1) NOT NULL DEFAULT '0',
  PRIMARY KEY (`id`,`floor_plan_id`),
  UNIQUE KEY `id` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf32 COLLATE=utf32_unicode_ci AUTO_INCREMENT=1 ;

CREATE TABLE IF NOT EXISTS `cameras` (
  `id` bigint(20) NOT NULL AUTO_INCREMENT,
  `floor_plan_id` bigint(20) NOT NULL,
  `name` varchar(40) NOT NULL,
  `floor_plan_xpos` int(11) DEFAULT NULL,
  `floor_plan_ypos` int(11) DEFAULT NULL,
  `recording` tinyint(1) NOT NULL DEFAULT '0',
  `enabled` tinyint(1) NOT NULL DEFAULT '1',
  PRIMARY KEY (`id`,`floor_plan_id`),
  UNIQUE KEY `id` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf32 COLLATE=utf32_unicode_ci AUTO_INCREMENT=1 ;

CREATE TABLE IF NOT EXISTS `rooms` (
  `id` bigint(20) NOT NULL AUTO_INCREMENT,
  `floor_plan_id` bigint(20) NOT NULL,
  `name` varchar(40) NOT NULL,
  `floor_plan_xpos` int(11) DEFAULT NULL,
  `floor_plan_ypos` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`,`floor_plan_id`),
  UNIQUE KEY `id` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf32 COLLATE=utf32_unicode_ci AUTO_INCREMENT=1 ;

CREATE TABLE IF NOT EXISTS `videos` (
  `time` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `id` bigint(20) NOT NULL AUTO_INCREMENT,
  `camera_id` bigint(20) NOT NULL,
  `name` varchar(40) NOT NULL,
  `vurl` varchar(120) NOT NULL,
  PRIMARY KEY (`id`,`camera_id`),
  UNIQUE KEY `id` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf32 COLLATE=utf32_unicode_ci AUTO_INCREMENT=1 ;


ALTER TABLE  `floor_plans` ADD FOREIGN KEY (  `userid` ) REFERENCES  `hnh-db`.`users` (
`id`
) ON DELETE CASCADE ON UPDATE CASCADE ;

ALTER TABLE  `videos` ADD FOREIGN KEY (  `camera_id` ) REFERENCES `hnh-db`.`cameras` (
`id`
) ON DELETE NO ACTION ON UPDATE CASCADE ;

ALTER TABLE  `sensors` ADD FOREIGN KEY (  `floor_plan_id` ) REFERENCES `hnh-db`.`floor_plans` (
`id`
) ON DELETE CASCADE ON UPDATE CASCADE ;

ALTER TABLE  `lights` ADD FOREIGN KEY (  `floor_plan_id` ) REFERENCES `hnh-db`.`floor_plans` (
`id`
) ON DELETE CASCADE ON UPDATE CASCADE ;

ALTER TABLE  `cameras` ADD FOREIGN KEY (  `floor_plan_id` ) REFERENCES `hnh-db`.`floor_plans` (
`id`
) ON DELETE CASCADE ON UPDATE CASCADE ;

ALTER TABLE  `rooms` ADD FOREIGN KEY (  `floor_plan_id` ) REFERENCES `hnh-db`.`floor_plans` (
`id`
) ON DELETE CASCADE ON UPDATE CASCADE ;


INSERT INTO `hnh-db`.`users` (`id`, `username`, `name`, `email`,`password`, `accountType`) VALUES ('1', 'root', 'root', 'emanuelp7@hnh.com','themainrootuseisthebose', 'admin');
INSERT INTO `hnh-db`.`users` (`username`, `name`, `email`,`password`) VALUES ('emanuelp7', 'Emanual Peters', 'root@hnh.com','1234567');
INSERT INTO `hnh-db`.`floor_plans` (`id`, `userid`, `name`, `picture`) VALUES ('1', '1', 'global', 'none');