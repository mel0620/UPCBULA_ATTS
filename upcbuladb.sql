/*
Navicat MySQL Data Transfer

Source Server         : MySQL5
Source Server Version : 50513
Source Host           : localhost:3306
Source Database       : upcbuladb

Target Server Type    : MYSQL
Target Server Version : 50513
File Encoding         : 65001

Date: 2017-03-22 10:34:39
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `attendance`
-- ----------------------------
DROP TABLE IF EXISTS `attendance`;
CREATE TABLE `attendance` (
  `a_id` int(4) NOT NULL AUTO_INCREMENT,
  `a_date` varchar(100) DEFAULT NULL,
  `a_time` varchar(50) DEFAULT NULL,
  `fname` varchar(45) DEFAULT NULL,
  `lname` varchar(45) DEFAULT NULL,
  `department` varchar(45) DEFAULT NULL,
  `event` varchar(45) DEFAULT NULL,
  `visitor` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`a_id`)
) ENGINE=InnoDB AUTO_INCREMENT=90 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of attendance
-- ----------------------------
INSERT INTO `attendance` VALUES ('88', '2017/03/05', '06:16 PM', 'Rommel', 'Cuneta', 'Youth', 'SUNDAY SERVICE', null);
INSERT INTO `attendance` VALUES ('89', '2017/03/05', '06:16 PM', 'DGKN', 'PNP', 'Men', 'SUNDAY SERVICE', 'Visitor');

-- ----------------------------
-- Table structure for `members`
-- ----------------------------
DROP TABLE IF EXISTS `members`;
CREATE TABLE `members` (
  `m_id` varchar(4) NOT NULL,
  `fname` varchar(45) DEFAULT NULL,
  `mname` varchar(45) DEFAULT NULL,
  `lname` varchar(45) DEFAULT NULL,
  `dob` date DEFAULT NULL,
  `datebaptized` date DEFAULT NULL,
  `address` varchar(255) DEFAULT NULL,
  `department` varchar(45) DEFAULT NULL,
  `ministry` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`m_id`),
  UNIQUE KEY `MemID_UNIQUE` (`m_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of members
-- ----------------------------
INSERT INTO `members` VALUES ('0002', 'Jerusah Lenn', 'Berdin', 'Dela Torre', null, null, 'San Ramon', 'Children', null);
INSERT INTO `members` VALUES ('0003', 'Richelle', null, 'Cometa', null, null, 'San Ramon', 'Children', 'Musician');
INSERT INTO `members` VALUES ('0004', 'John Jeriv', 'Berdin', 'Dela Torre', null, null, 'San Ramon', 'Children', 'Musician');
INSERT INTO `members` VALUES ('0005', 'Jeboy', 'Derdin', 'Dela Torre', null, null, 'San Ramon', 'Children', 'Musician');
INSERT INTO `members` VALUES ('0006', 'Beny', null, 'Ramos', null, null, 'San Agustin', 'Men', null);
INSERT INTO `members` VALUES ('0007', 'Danilo', null, 'Secillano', null, null, 'San Ramon', 'Men', null);
INSERT INTO `members` VALUES ('0008', 'Sherly', null, 'Secillano', null, null, 'San Ramon', 'LA', null);
INSERT INTO `members` VALUES ('0011', 'Shine', null, 'Secillano', null, null, 'San Ramon', 'Children', null);
INSERT INTO `members` VALUES ('0012', 'Bernadette', null, 'Ramos', null, null, 'San Agustin', 'Youth', 'Song Leader');
INSERT INTO `members` VALUES ('0013', 'Ken Joshua', 'Cometa', 'Cuneta', '1999-06-17', '2009-04-09', 'San Ramon', 'Youth', 'Musician');
INSERT INTO `members` VALUES ('0014', 'Jessiebel', null, 'Dela Torre', null, null, 'San Ramon', 'Youth', null);
INSERT INTO `members` VALUES ('0016', 'Pony', null, 'Detal', null, null, 'San Agustin', 'Youth', 'Musician');
INSERT INTO `members` VALUES ('0017', 'Enggay', null, 'Detal', null, null, 'San Agustin', 'LA', null);
INSERT INTO `members` VALUES ('0018', 'Rowena', null, 'Detal', null, null, 'San Agustin', 'LA', null);
INSERT INTO `members` VALUES ('0019', 'Judith', null, 'Ramos', null, null, 'San Agustin', 'LA', null);
INSERT INTO `members` VALUES ('0020', 'Julie ann', null, 'Ramos', null, null, 'San Agustin', 'LA', null);
INSERT INTO `members` VALUES ('0021', 'Floreña', null, 'Esta', null, null, 'San Ramon', 'LA', null);
INSERT INTO `members` VALUES ('0022', 'Susa', null, 'Esta', null, null, 'San Ramon', 'Youth', null);
INSERT INTO `members` VALUES ('0023', 'Jaira', null, 'Hallare', null, null, 'San Ramon', 'Youth', null);
INSERT INTO `members` VALUES ('0024', 'Kim Sharmaine', 'Cometa', 'Cuneta', null, null, 'San Ramon', 'Youth', 'Musician/SL');
INSERT INTO `members` VALUES ('0025', 'Vincent', 'Nagales', 'Luzon', '1997-08-21', '2012-12-30', 'Bagumbayan', 'Youth', 'Musician');
INSERT INTO `members` VALUES ('0026', 'Christian', 'Nagales', 'Luzon', '1999-08-28', '2012-12-30', 'Bagumbayan', 'Youth', 'Musician');
INSERT INTO `members` VALUES ('0027', 'Joshua', 'Flores', 'Nagales', '1999-12-18', '2012-12-30', 'Bagumbayan', 'Youth', 'Musician');
INSERT INTO `members` VALUES ('0028', 'Emmanuel', null, 'Grampon', null, null, 'San Agustin', 'Men', null);
INSERT INTO `members` VALUES ('0029', 'Jenebiv', null, 'Tumbado', null, null, 'Casugad', 'LA', null);
INSERT INTO `members` VALUES ('0030', 'Aldrin', null, 'Tumbado', null, null, 'Casugad', 'Men', null);
INSERT INTO `members` VALUES ('0031', 'Roberto', null, 'Jaranilla', null, null, 'San Agustin', 'Youth', null);
INSERT INTO `members` VALUES ('0032', 'Tinang', null, 'Jaranilla', null, null, 'San Agustin', 'Youth', null);
INSERT INTO `members` VALUES ('0033', 'Grace', null, 'Jaranilla', null, null, 'San Agustin', 'Youth', null);
INSERT INTO `members` VALUES ('0034', 'Dita', null, 'Jaranilla', null, null, 'San Agustin', 'LA', null);
INSERT INTO `members` VALUES ('0035', 'Andrei', 'Estoque', 'Cometa', null, null, 'San Ramon', 'Children', 'Musician');
INSERT INTO `members` VALUES ('0036', 'Lando', null, 'Jaranilla', null, null, 'San Agustin', 'Men', null);
INSERT INTO `members` VALUES ('0037', 'Ysabelle', 'Cometa', 'Garcia', '2014-11-09', '2016-11-18', 'San Ramon', 'Children', 'None');
INSERT INTO `members` VALUES ('0039', 'Hannah Louise', 'Estoque', 'Cometa', null, null, 'San Ramon', 'Youth', 'Musician');
INSERT INTO `members` VALUES ('0040', 'Merly', 'Estoque', 'Cometa', null, null, 'San Ramon', 'LA', 'Church Secretary');
INSERT INTO `members` VALUES ('0041', 'Socorro', 'Deluana', 'Cometa', '2016-11-17', '2016-11-17', 'San Ramon', 'LA', '');
INSERT INTO `members` VALUES ('0042', 'Alex', 'Deluana', 'Cometa', null, null, 'San Ramon', 'Men', 'Pastor');
INSERT INTO `members` VALUES ('0043', 'Rhea', null, 'Cometa', null, null, 'San Ramon', 'Youth', 'Musician');
INSERT INTO `members` VALUES ('0620', 'Rommel', 'Cometa', 'Cuneta', '1997-06-20', '2009-04-09', 'San Ramon', 'Youth', 'Musician');
INSERT INTO `members` VALUES ('1109', 'Ysabelle', 'Garcia', 'Cometa', '2014-11-09', '2017-01-17', 'San Ramon', 'Children', 'None');
INSERT INTO `members` VALUES ('1224', 'Violeta', 'Berdin', 'Dela Torre', '2016-11-19', '2016-11-19', 'San Ramon', 'LA', 'Church Pastor');

-- ----------------------------
-- Table structure for `tithes`
-- ----------------------------
DROP TABLE IF EXISTS `tithes`;
CREATE TABLE `tithes` (
  `t_id` int(4) NOT NULL AUTO_INCREMENT,
  `t_date` varchar(100) DEFAULT NULL,
  `m_id` varchar(4) DEFAULT NULL,
  `name` varchar(45) DEFAULT NULL,
  `department` varchar(45) DEFAULT NULL,
  `tithes` decimal(10,2) DEFAULT NULL,
  `offering` decimal(10,2) DEFAULT NULL,
  `mpfchorsfcsoc` decimal(10,2) DEFAULT NULL,
  `sundayschool` decimal(10,2) DEFAULT NULL,
  `evangelism` decimal(10,2) DEFAULT NULL,
  `radio` decimal(10,2) DEFAULT NULL,
  `lot` decimal(10,2) DEFAULT NULL,
  `total` decimal(10,2) DEFAULT NULL,
  PRIMARY KEY (`t_id`),
  KEY `mid2` (`m_id`),
  CONSTRAINT `mid2` FOREIGN KEY (`m_id`) REFERENCES `members` (`m_id`)
) ENGINE=InnoDB AUTO_INCREMENT=73 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tithes
-- ----------------------------
INSERT INTO `tithes` VALUES ('72', '2016/11/22', '0620', 'Rommel Cuneta', 'Youth', '20.00', '20.00', '20.00', '20.00', '20.00', '20.00', '20.00', '140.00');

-- ----------------------------
-- Table structure for `user`
-- ----------------------------
DROP TABLE IF EXISTS `user`;
CREATE TABLE `user` (
  `uid` int(4) NOT NULL AUTO_INCREMENT,
  `username` varchar(50) DEFAULT NULL,
  `password` varchar(50) DEFAULT NULL,
  `usertype` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`uid`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of user
-- ----------------------------
INSERT INTO `user` VALUES ('1', 'mel20', '0620', 'developer');
INSERT INTO `user` VALUES ('2', 'rose', '1234', 'lasec');
INSERT INTO `user` VALUES ('3', 'bing2', 'bing2', 'youthpres');
INSERT INTO `user` VALUES ('4', 'pastora', 'pastora', 'pastor');
INSERT INTO `user` VALUES ('6', 'mel20', '1234', 'youthpres');

-- ----------------------------
-- Table structure for `youthfunds`
-- ----------------------------
DROP TABLE IF EXISTS `youthfunds`;
CREATE TABLE `youthfunds` (
  `y_id` int(4) NOT NULL AUTO_INCREMENT,
  `date` varchar(20) DEFAULT NULL,
  `name` varchar(255) DEFAULT NULL,
  `church_address` varchar(255) DEFAULT NULL,
  `amount` decimal(10,2) DEFAULT NULL,
  `description` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`y_id`)
) ENGINE=InnoDB AUTO_INCREMENT=28 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of youthfunds
-- ----------------------------
INSERT INTO `youthfunds` VALUES ('20', '2016/11/20', 'Rommel Cuneta', 'San Ramon', '20.00', 'Youth Camp');
INSERT INTO `youthfunds` VALUES ('21', '2016/11/20', 'Ken Joshua Cuneta', 'San Ramon', '30.00', 'Youth Camp');
INSERT INTO `youthfunds` VALUES ('22', '2016/11/27', 'Rommel Cuneta', 'San Ramon', '20.00', 'Youth Camp');
INSERT INTO `youthfunds` VALUES ('23', '2016/11/22', 'Vincent Luzon', 'Bagumbayan', '20.00', 'Youth Camp');
INSERT INTO `youthfunds` VALUES ('24', '2016/11/27', 'Vincent Luzon', 'Bagumbayan', '20.00', 'Youth Camp');
INSERT INTO `youthfunds` VALUES ('25', '2016/11/27', 'Christian Luzon', 'Bagumbayan', '10.00', 'Youth Camp');
INSERT INTO `youthfunds` VALUES ('26', '2017/01/17', 'Rommel Cuneta', 'San Ramon', '5.00', 'Youth Camp');
INSERT INTO `youthfunds` VALUES ('27', '2017/01/17', 'Bernadette Ramos', 'San Ramon', '20.00', 'Youth Camp');

-- ----------------------------
-- Table structure for `y_descriptions`
-- ----------------------------
DROP TABLE IF EXISTS `y_descriptions`;
CREATE TABLE `y_descriptions` (
  `desc_id` int(4) NOT NULL DEFAULT '0',
  `dec_name` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`desc_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of y_descriptions
-- ----------------------------

-- ----------------------------
-- View structure for `attend_view`
-- ----------------------------
DROP VIEW IF EXISTS `attend_view`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `attend_view` AS select `attendance`.`a_date` AS `DATE`,`attendance`.`a_time` AS `TIME`,concat(`attendance`.`fname`,' ',`attendance`.`lname`) AS `NAME`,`attendance`.`department` AS `DEPARTMENT`,`attendance`.`event` AS `SERVICE`,`attendance`.`visitor` AS `VISITOR` from `attendance` ;

-- ----------------------------
-- View structure for `hor`
-- ----------------------------
DROP VIEW IF EXISTS `hor`;
