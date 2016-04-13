CREATE TABLE IF NOT EXISTS `videos` (
  `time` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `id` bigint(20) NOT NULL AUTO_INCREMENT,
  `camera_id` bigint(20) NOT NULL,
  `name` varchar(40) NOT NULL,
  `vurl` varchar(120) NOT NULL,
  PRIMARY KEY (`id`,`camera_id`),
  UNIQUE KEY `id` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf32 COLLATE=utf32_unicode_ci AUTO_INCREMENT=1 ;

ALTER TABLE  `videos` ADD FOREIGN KEY (  `camera_id` ) REFERENCES `hnh-db`.`cameras` (
`id`
) ON DELETE NO ACTION ON UPDATE CASCADE ;