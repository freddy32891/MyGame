

CREATE USER mygameusr@localhost identified by 'mygamepswd';


CREATE USER admin@localhost identified by 'admin';

CREATE DATABASE mygame
    DEFAULT CHARACTER SET utf8
    DEFAULT COLLATE utf8_general_ci;

GRANT INSERT, UPDATE, DELETE, SELECT ON mygame.* TO mygameusr@localhost;
GRANT INSERT, UPDATE, DELETE, SELECT ON mygame.* TO admin@localhost;

USE mygame;


CREATE TABLE user (
    user_id INTEGER (6) AUTO_INCREMENT,
    mail VARCHAR (50) NOT NULL UNIQUE,
    password VARCHAR(20) NOT NULL,
    name VARCHAR (15) DEFAULT 'player',
    role VARCHAR(10) DEFAULT 'player',
    trophies INTEGER (10) DEFAULT 0,
    highest_trophies INTEGER (10) DEFAULT 0,
    level INTEGER (2) DEFAULT 1,
    experience INTEGER (5) DEFAULT 0,
    PRIMARY KEY (user_id)
);


CREATE TABLE matches (
    match_id INTEGER (6) AUTO_INCREMENT,
    date DATETIME (0) NOT NULL,
    PRIMARY KEY(match_id)
);

CREATE TABLE shield (
    shield_id INTEGER (6) AUTO_INCREMENT,
    name VARCHAR (15) NOT NULL UNIQUE,
    defense_points INTEGER (4),
    quality VARCHAR (15),
    cost INTEGER (4),
    PRIMARY KEY(shield_id)
);

CREATE TABLE weapon (
    weapon_id INTEGER (6) AUTO_INCREMENT,
    name VARCHAR (15) NOT NULL UNIQUE,
    damage INTEGER (4),
    effectiveness INTEGER (3),
    quality VARCHAR (15),
    cost INTEGER (4),
    PRIMARY KEY(weapon_id)
);

CREATE TABLE usermatch(
    match_id INTEGER (6),
    user_id INTEGER (6),
    rounds_winned INTEGER (1),
    winned BOOLEAN,
    PRIMARY KEY(match_id, user_id)
);


CREATE TABLE usershield(
    user_id INTEGER (6),
    shield_id INTEGER (6),
    PRIMARY KEY(user_id, shield_id)
);

CREATE TABLE userweapon(
    user_id INTEGER (6),
    weapon_id INTEGER (6),
    PRIMARY KEY(user_id, weapon_id) 
);

CREATE TABLE userfriend(
    user_id INTEGER (6),
    friend_id INTEGER (6),
    PRIMARY KEY(user_id, friend_id)
);



ALTER TABLE usershield ADD FOREIGN KEY (user_id)
REFERENCES user(user_id)
	ON DELETE CASCADE ON UPDATE CASCADE;

ALTER TABLE userweapon ADD FOREIGN KEY (user_id)
REFERENCES user(user_id)
	ON DELETE CASCADE ON UPDATE CASCADE;
 
ALTER TABLE usermatch ADD FOREIGN KEY (user_id)
REFERENCES user(user_id)
	ON DELETE CASCADE ON UPDATE CASCADE;

ALTER TABLE usermatch ADD FOREIGN KEY (match_id)
REFERENCES matches(match_id)
	ON DELETE CASCADE ON UPDATE CASCADE;

ALTER TABLE userfriend ADD FOREIGN KEY (user_id)
REFERENCES user(user_id)
	ON DELETE CASCADE ON UPDATE CASCADE;

ALTER TABLE userfriend ADD FOREIGN KEY (friend_id)
REFERENCES user(user_id)
	ON DELETE CASCADE ON UPDATE CASCADE;

ALTER TABLE usershield ADD FOREIGN KEY (shield_id)
REFERENCES shield(shield_id)
	ON DELETE CASCADE ON UPDATE CASCADE;

ALTER TABLE userweapon ADD FOREIGN KEY (weapon_id)
REFERENCES weapon(weapon_id)
	ON DELETE CASCADE ON UPDATE CASCADE;


INSERT INTO user (mail, password, name, role, trophies, highest_trophies, level, experience) values 
('freddyachata@gmail.com', '1234567890', 'Freddy', 'Player',987, 998, 9, 234),
('pablito@gmail.com', 'asdfghjkl', 'Pablo', 'Player',367,432,3,123),
('pepe@gmail.com', '123456789', 'Pepe', 'Player',109,212,2,111),
('admin@admin.com', 'admin12345', 'Administrator', 'Admin',56,78,1,98),
('rosa@gmail.com', '123456789','Rosa', 'Player',107,122,3,267),
('maria@gmail.com', '123456789', 'Maria', 'Player',289,292,5,634),
('juan@gmail.com', 'adminjuan123', 'Juan', 'Player',1558,1754,10, 999),
('carla@gmail.com', '1234567890','Carla', 'Player',238,253,6,767);


INSERT INTO weapon (name, damage, effectiveness, quality, cost) values
('AK-47', 200, 80, 'silver', 400),
('MP5', '150', 90, 'bronze', 300),
('AK-117',175,85,'gold', 500),
('FRANCO-883', 500, 45, 'silver',300 ),
('UZI-45',75 ,98,'gold',150);


INSERT INTO shield (name, defense_points, quality, cost) values 
('shield-83', 100, 'silver', 80),
('shield-37', 25, 'bronze', 20),
('shield-89', 500, 'gold', 400),
('shield-92', 1000, 'gold', 650);


INSERT INTO usershield (user_id, shield_id) values 
(1,1),
(1,2),
(1,3),
(2,1),
(2,2),
(2,3),
(3,1),
(3,2),
(3,3),
(4,1),
(4,2),
(4,3),
(5,1),
(5,2),
(5,3),
(5,4),
(6,1),
(6,2),
(6,3),
(6,4),
(7,1),
(7,2),
(7,3),
(7,4),
(8,1),
(8,2),
(8,3),
(8,4);

INSERT INTO userweapon (user_id, weapon_id) values
(1,1),
(1,2),
(1,3),
(1,4),
(1,5),
(2,1),
(2,2),
(2,3),
(2,4),
(3,1),
(3,2),
(3,3),
(3,5),
(4,1),
(4,2),
(4,3),
(4,4),
(5,1),
(5,2),
(5,3),
(5,4),
(6,1),
(6,2),
(6,3),
(6,4),
(7,1),
(7,2),
(7,3),
(7,4),
(7,5),
(8,1),
(8,2),
(8,3),
(8,4);

INSERT INTO userfriend(user_id, friend_id) values (8,1),
(1,2),
(1,3),
(1,5),
(1,6),
(1,7),
(1,8),
(2,1),
(3,1),
(5,1),
(4,3),
(4,1),
(5,2),
(3,4),
(1,4),
(2,5),
(6,1),
(7,1),
(7,2),
(2,7),
(7,3),
(3,7),
(7,4),
(4,7),
(6,2),
(2,6),
(6,3),
(3,6),
(6,4),
(4,6);

INSERT INTO `matches` (`date`) VALUES ("2020-12-16 09:01:38"),("2020-04-09 07:25:40"),("2020-12-29 13:36:47"),("2020-04-04 12:40:59"),("2019-08-24 04:12:10"),("2020-11-29 01:29:34"),("2021-02-09 20:02:57"),("2021-08-13 00:09:05"),("2020-12-03 05:08:51"),("2020-08-01 23:42:45");

INSERT INTO `matches` (`date`) VALUES ("2020-10-15 07:00:06"),("2019-08-06 09:37:33"),("2019-08-14 23:17:11"),("2021-12-31 10:06:25"),("2019-10-05 02:37:46"),("2018-12-06 06:19:58"),("2022-02-16 15:56:19"),("2020-09-13 09:19:39"),("2020-07-17 19:17:04"),("2020-04-27 13:25:15");


INSERT INTO `usermatch` (`match_id`,`user_id`,`rounds_winned`,`winned`) VALUES 
(1,7,2,true),(1,6,1,false),
(2,6,1,false),(2,7,2,true),
(3,4,1,false),(3,5,2,true),
(4,3,2,true),(4,5,1,false),
(5,5,1,false),(5,3,2,true),
(6,7,1,false),(6,1,2,true),
(7,3,2,true),(7,1,1,false),
(8,2,2,true),(8,5,1,false),
(9,2,2,true),(9,4,1,false),
(10,1,2,true),(10,3,1,false);

INSERT INTO `usermatch` (`match_id`,`user_id`,`rounds_winned`,`winned`) VALUES 
(11,1,3,true),(11,6,0,false),
(12,4,1,false),(12,7,2,true),
(13,3,3,true),(13,8,0,false),
(14,1,1,false),(14,8,2,true),
(15,7,1,false),(15,1,2,true),
(16,3,2,true),(16,1,1,false),
(17,1,2,true),(17,5,1,false),
(18,2,2,true),(18,4,1,false),
(19,4,0,false),(19,5,3,true),
(20,3,2,true),(20,5,1,false);

