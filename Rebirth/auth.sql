/*
Navicat MySQL Data Transfer

Source Server         : localhost
Source Server Version : 50714
Source Host           : localhost:3306
Source Database       : auth

Target Server Type    : MYSQL
Target Server Version : 50714
File Encoding         : 65001

Date: 2017-06-14 20:04:53
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for accounts
-- ----------------------------
DROP TABLE IF EXISTS `accounts`;
CREATE TABLE `accounts` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Login` mediumtext NOT NULL,
  `Password` mediumtext NOT NULL,
  `Mail` mediumtext NOT NULL,
  `Nickname` mediumtext NOT NULL,
  `Role` int(11) NOT NULL,
  `SecretQuestion` mediumtext NOT NULL,
  `SecretAnswer` mediumtext NOT NULL,
  `BanReason` mediumtext,
  `Ticket` mediumtext,
  `LastServer` int(11) DEFAULT NULL,
  `LastIp` mediumtext,
  `LastDate` mediumtext,
  `ShopPoints` int(11) DEFAULT NULL,
  `EventPoints` int(11) DEFAULT NULL,
  `AesKey` longblob,
  `HeureVote` mediumtext,
  PRIMARY KEY (`Id`)
) ENGINE=MyISAM AUTO_INCREMENT=1649 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of accounts
-- ----------------------------
INSERT INTO `accounts` VALUES ('1', 'test', '098f6bcd4621d373cade4e832627b4f6', 'test', 'test', '4', 'test', 'test', null, null, '0', '127.0.0.1', null, '0', '0', null, null);

-- ----------------------------
-- Table structure for news
-- ----------------------------
DROP TABLE IF EXISTS `news`;
CREATE TABLE `news` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `author` text NOT NULL,
  `category` text NOT NULL,
  `content` text NOT NULL,
  `date` text NOT NULL,
  `img` text NOT NULL,
  `title` text NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of news
-- ----------------------------

-- ----------------------------
-- Table structure for servers
-- ----------------------------
DROP TABLE IF EXISTS `servers`;
CREATE TABLE `servers` (
  `Id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `Name` mediumtext NOT NULL,
  `Ip` mediumtext NOT NULL,
  `Port` int(10) unsigned NOT NULL,
  `Type` int(10) unsigned NOT NULL,
  `State` int(11) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=MyISAM AUTO_INCREMENT=26 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of servers
-- ----------------------------
INSERT INTO `servers` VALUES ('1', 'Jiva', '127.0.0.1', '5555', '1', '1');

-- ----------------------------
-- Table structure for shop_categories
-- ----------------------------
DROP TABLE IF EXISTS `shop_categories`;
CREATE TABLE `shop_categories` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `key` mediumtext NOT NULL,
  `displayMod` mediumtext NOT NULL,
  `description` mediumtext NOT NULL,
  `image` mediumtext NOT NULL,
  `name` mediumtext NOT NULL,
  `childCSV` mediumtext NOT NULL,
  `itemCSV` mediumtext NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of shop_categories
-- ----------------------------

-- ----------------------------
-- Table structure for shop_gondolearticles
-- ----------------------------
DROP TABLE IF EXISTS `shop_gondolearticles`;
CREATE TABLE `shop_gondolearticles` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `itemCSV` mediumtext NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of shop_gondolearticles
-- ----------------------------

-- ----------------------------
-- Table structure for shop_hightlight
-- ----------------------------
DROP TABLE IF EXISTS `shop_hightlight`;
CREATE TABLE `shop_hightlight` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` mediumtext NOT NULL,
  `description` mediumtext NOT NULL,
  `link` mediumtext NOT NULL,
  `type` mediumtext NOT NULL,
  `mode` mediumtext NOT NULL,
  `img208` mediumtext NOT NULL,
  `img288` mediumtext NOT NULL,
  `img590` mediumtext NOT NULL,
  `img667` mediumtext NOT NULL,
  `img396` mediumtext NOT NULL,
  `img420` mediumtext NOT NULL,
  `img950` mediumtext NOT NULL,
  `ext_id` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of shop_hightlight
-- ----------------------------

-- ----------------------------
-- Table structure for shop_items
-- ----------------------------
DROP TABLE IF EXISTS `shop_items`;
CREATE TABLE `shop_items` (
  `id` int(11) NOT NULL,
  `key` mediumtext NOT NULL,
  `name` mediumtext NOT NULL,
  `subtitle` mediumtext NOT NULL,
  `description` mediumtext NOT NULL,
  `startdate` mediumtext NOT NULL,
  `enddate` mediumtext NOT NULL,
  `stock` mediumtext NOT NULL,
  `price` mediumtext NOT NULL,
  `original_price` mediumtext NOT NULL,
  `currency` mediumtext NOT NULL,
  `metasCSV` mediumtext NOT NULL,
  `mediasCSV` mediumtext NOT NULL,
  `refCSV` mediumtext NOT NULL,
  `image70` mediumtext NOT NULL,
  `image200` mediumtext NOT NULL,
  `image590` mediumtext NOT NULL,
  `Categorie` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of shop_items
-- ----------------------------

-- ----------------------------
-- Table structure for shop_medias
-- ----------------------------
DROP TABLE IF EXISTS `shop_medias`;
CREATE TABLE `shop_medias` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `key` mediumtext NOT NULL,
  `lang` mediumtext NOT NULL,
  `type` mediumtext NOT NULL,
  `param` mediumtext NOT NULL,
  `order` mediumtext NOT NULL,
  `url` mediumtext NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=4169 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of shop_medias
-- ----------------------------

-- ----------------------------
-- Table structure for shop_metas
-- ----------------------------
DROP TABLE IF EXISTS `shop_metas`;
CREATE TABLE `shop_metas` (
  `id` int(11) NOT NULL,
  `name` mediumtext NOT NULL,
  `key` mediumtext NOT NULL,
  `metasCSV` mediumtext NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of shop_metas
-- ----------------------------

-- ----------------------------
-- Table structure for shop_ref
-- ----------------------------
DROP TABLE IF EXISTS `shop_ref`;
CREATE TABLE `shop_ref` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `image` mediumtext NOT NULL,
  `type` mediumtext NOT NULL,
  `quantity` mediumtext NOT NULL,
  `free` mediumtext NOT NULL,
  `name` mediumtext NOT NULL,
  `description` mediumtext NOT NULL,
  `contentCSV` mediumtext NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of shop_ref
-- ----------------------------

-- ----------------------------
-- Table structure for shop_ref_content
-- ----------------------------
DROP TABLE IF EXISTS `shop_ref_content`;
CREATE TABLE `shop_ref_content` (
  `id` int(11) NOT NULL,
  `name` mediumtext NOT NULL,
  `description` mediumtext NOT NULL,
  `image` mediumtext NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of shop_ref_content
-- ----------------------------

-- ----------------------------
-- Table structure for shop_sous_categories
-- ----------------------------
DROP TABLE IF EXISTS `shop_sous_categories`;
CREATE TABLE `shop_sous_categories` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `key` mediumtext NOT NULL,
  `displayMod` mediumtext NOT NULL,
  `description` mediumtext NOT NULL,
  `image` mediumtext NOT NULL,
  `name` mediumtext NOT NULL,
  `childCSV` mediumtext NOT NULL,
  `itemsCSV` mediumtext NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=43 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of shop_sous_categories
-- ----------------------------

-- ----------------------------
-- Table structure for worlds_characters
-- ----------------------------
DROP TABLE IF EXISTS `worlds_characters`;
CREATE TABLE `worlds_characters` (
  `Id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `Count` int(11) NOT NULL,
  `AccountId` int(11) NOT NULL,
  `ServerId` int(11) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=MyISAM AUTO_INCREMENT=388 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of worlds_characters
-- ----------------------------
INSERT INTO `worlds_characters` VALUES ('387', '1', '1', '1');
SET FOREIGN_KEY_CHECKS=1;
