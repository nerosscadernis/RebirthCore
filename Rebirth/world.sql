/*
Navicat MySQL Data Transfer

Source Server         : localhost
Source Server Version : 50714
Source Host           : localhost:3306
Source Database       : world

Target Server Type    : MYSQL
Target Server Version : 50714
File Encoding         : 65001

Date: 2017-06-14 20:05:01
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for alliances
-- ----------------------------
DROP TABLE IF EXISTS `alliances`;
CREATE TABLE `alliances` (
  `Id` int(10) unsigned NOT NULL,
  `OwnerId` int(10) unsigned NOT NULL,
  `SymbolShape` int(10) unsigned NOT NULL,
  `SymbolColor` int(10) unsigned NOT NULL,
  `BackgroundShape` int(10) unsigned NOT NULL,
  `BackgroundColor` int(10) unsigned NOT NULL,
  `Emblem` int(10) unsigned NOT NULL,
  `Name` mediumtext NOT NULL,
  `Description` mediumtext NOT NULL,
  `Announcement` mediumtext NOT NULL,
  `DateChangeDescription` mediumtext NOT NULL,
  `DateChangeAnnouncement` mediumtext NOT NULL,
  `NameChangeDescription` mediumtext NOT NULL,
  `NameChangeAnnouncement` mediumtext NOT NULL,
  `Tag` mediumtext NOT NULL,
  `CreationDate` int(11) NOT NULL,
  `OwnerName` mediumtext NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of alliances
-- ----------------------------

-- ----------------------------
-- Table structure for bank_items
-- ----------------------------
DROP TABLE IF EXISTS `bank_items`;
CREATE TABLE `bank_items` (
  `Id` int(11) NOT NULL,
  `OwnerId` int(11) NOT NULL,
  `TemplateID` int(11) NOT NULL,
  `Quantity` int(11) NOT NULL,
  `EffectsCompress` longblob,
  PRIMARY KEY (`Id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of bank_items
-- ----------------------------

-- ----------------------------
-- Table structure for bank_kamas
-- ----------------------------
DROP TABLE IF EXISTS `bank_kamas`;
CREATE TABLE `bank_kamas` (
  `Id` int(11) NOT NULL,
  `AccountID` int(11) NOT NULL,
  `Kamas` int(11) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of bank_kamas
-- ----------------------------

-- ----------------------------
-- Table structure for characters
-- ----------------------------
DROP TABLE IF EXISTS `characters`;
CREATE TABLE `characters` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Infos` blob,
  `Look` blob,
  `Inventory` blob,
  `Stats` blob,
  `Guild` blob,
  `Jobs` blob,
  `Quests` blob,
  PRIMARY KEY (`Id`)
) ENGINE=MyISAM AUTO_INCREMENT=33 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of characters
-- ----------------------------
INSERT INTO `characters` VALUES ('32', 0x00000001000474657374000D5861736161682D4D75696365740000000000000000091400000156010000000008000000000000000100000000000000000000000000000000050C08030000000000004275C9C191E17000, 0x000500000001006532100000000200B5484E000000030035252600000004008233380000000500C3888B0001008C00020050084D0000000100, '', 0x00640006000300000000003700000000000000000000, '', 0x00120000001C00000000000000000000002400000000000000000000000B00000000000000000000004100000000000000000000000F00000000000000000000001A00000000000000000000003E00000000000000000000003000000000000000000000002900000000000000000000001000000000000000000000001B00000000000000000000000200000000000000000000003F00000000000000000000000D00000000000000000000001800000000000000000000003C00000000000000000000002C0000000000000000000000400000000000000000, 0x0000000100000000);

-- ----------------------------
-- Table structure for experiences
-- ----------------------------
DROP TABLE IF EXISTS `experiences`;
CREATE TABLE `experiences` (
  `Level` smallint(6) NOT NULL AUTO_INCREMENT,
  `CharacterExp` bigint(20) DEFAULT NULL,
  `GuildExp` bigint(20) DEFAULT NULL,
  `MountExp` bigint(20) DEFAULT NULL,
  `AlignmentHonor` smallint(5) unsigned DEFAULT NULL,
  `JobExp` bigint(20) DEFAULT NULL,
  PRIMARY KEY (`Level`)
) ENGINE=MyISAM AUTO_INCREMENT=201 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of experiences
-- ----------------------------
INSERT INTO `experiences` VALUES ('1', '0', '0', '0', '0', '0');
INSERT INTO `experiences` VALUES ('2', '110', '1100', '600', '500', '20');
INSERT INTO `experiences` VALUES ('3', '650', '6500', '1750', '1500', '60');
INSERT INTO `experiences` VALUES ('4', '1500', '15000', '2750', '3000', '120');
INSERT INTO `experiences` VALUES ('5', '2800', '28000', '4000', '5000', '200');
INSERT INTO `experiences` VALUES ('6', '4800', '48000', '5500', '7500', '300');
INSERT INTO `experiences` VALUES ('7', '7300', '73000', '7250', '10000', '420');
INSERT INTO `experiences` VALUES ('8', '10500', '105000', '9250', '12500', '560');
INSERT INTO `experiences` VALUES ('9', '14500', '145000', '11500', '15000', '720');
INSERT INTO `experiences` VALUES ('10', '19200', '192000', '14000', '17500', '900');
INSERT INTO `experiences` VALUES ('11', '25200', '252000', '16750', null, '1100');
INSERT INTO `experiences` VALUES ('12', '32600', '326000', '19750', null, '1320');
INSERT INTO `experiences` VALUES ('13', '41000', '410000', '23000', null, '1560');
INSERT INTO `experiences` VALUES ('14', '50500', '505000', '26500', null, '1820');
INSERT INTO `experiences` VALUES ('15', '61000', '610000', '30250', null, '2100');
INSERT INTO `experiences` VALUES ('16', '75000', '750000', '34250', null, '2400');
INSERT INTO `experiences` VALUES ('17', '91000', '910000', '38500', null, '2720');
INSERT INTO `experiences` VALUES ('18', '115000', '1150000', '43000', null, '3060');
INSERT INTO `experiences` VALUES ('19', '142000', '1420000', '47750', null, '3420');
INSERT INTO `experiences` VALUES ('20', '171000', '1710000', '52750', null, '3800');
INSERT INTO `experiences` VALUES ('21', '202000', '2020000', '58000', null, '4200');
INSERT INTO `experiences` VALUES ('22', '235000', '2350000', '63500', null, '4620');
INSERT INTO `experiences` VALUES ('23', '270000', '2700000', '69250', null, '5060');
INSERT INTO `experiences` VALUES ('24', '310000', '3100000', '75250', null, '5520');
INSERT INTO `experiences` VALUES ('25', '353000', '3530000', '81500', null, '6000');
INSERT INTO `experiences` VALUES ('26', '398500', '3985000', '88000', null, '6500');
INSERT INTO `experiences` VALUES ('27', '448000', '4480000', '94750', null, '7020');
INSERT INTO `experiences` VALUES ('28', '503000', '5030000', '101750', null, '7560');
INSERT INTO `experiences` VALUES ('29', '561000', '5610000', '109000', null, '8120');
INSERT INTO `experiences` VALUES ('30', '621600', '6216000', '116500', null, '8700');
INSERT INTO `experiences` VALUES ('31', '687000', '6870000', '124250', null, '9300');
INSERT INTO `experiences` VALUES ('32', '755000', '7550000', '132250', null, '9920');
INSERT INTO `experiences` VALUES ('33', '829000', '8290000', '140500', null, '10560');
INSERT INTO `experiences` VALUES ('34', '910000', '9100000', '149000', null, '11220');
INSERT INTO `experiences` VALUES ('35', '1000000', '10000000', '157750', null, '11900');
INSERT INTO `experiences` VALUES ('36', '1100000', '11000000', '166750', null, '12600');
INSERT INTO `experiences` VALUES ('37', '1240000', '12400000', '176000', null, '13320');
INSERT INTO `experiences` VALUES ('38', '1400000', '14000000', '185000', null, '14060');
INSERT INTO `experiences` VALUES ('39', '1580000', '15800000', '195500', null, '14820');
INSERT INTO `experiences` VALUES ('40', '1780000', '17800000', '205250', null, '15600');
INSERT INTO `experiences` VALUES ('41', '2000000', '20000000', '215500', null, '16400');
INSERT INTO `experiences` VALUES ('42', '2250000', '22500000', '226000', null, '17220');
INSERT INTO `experiences` VALUES ('43', '2530000', '25300000', '236750', null, '18060');
INSERT INTO `experiences` VALUES ('44', '2850000', '28500000', '247750', null, '18920');
INSERT INTO `experiences` VALUES ('45', '3200000', '32000000', '259000', null, '19800');
INSERT INTO `experiences` VALUES ('46', '3570000', '35700000', '270500', null, '20700');
INSERT INTO `experiences` VALUES ('47', '3960000', '39600000', '282250', null, '21620');
INSERT INTO `experiences` VALUES ('48', '4400000', '44000000', '294250', null, '22560');
INSERT INTO `experiences` VALUES ('49', '4860000', '48600000', '306500', null, '23520');
INSERT INTO `experiences` VALUES ('50', '5350000', '53500000', '319000', null, '24500');
INSERT INTO `experiences` VALUES ('51', '5860000', '58600000', '331750', null, '25500');
INSERT INTO `experiences` VALUES ('52', '6390000', '63900000', '344750', null, '26520');
INSERT INTO `experiences` VALUES ('53', '6950000', '69500000', '358000', null, '27560');
INSERT INTO `experiences` VALUES ('54', '7530000', '75300000', '371500', null, '28620');
INSERT INTO `experiences` VALUES ('55', '8130000', '81300000', '385250', null, '29700');
INSERT INTO `experiences` VALUES ('56', '8765100', '87651000', '399250', null, '30800');
INSERT INTO `experiences` VALUES ('57', '9420000', '94200000', '413500', null, '31920');
INSERT INTO `experiences` VALUES ('58', '10150000', '101500000', '428000', null, '33060');
INSERT INTO `experiences` VALUES ('59', '10894000', '108940000', '442750', null, '34220');
INSERT INTO `experiences` VALUES ('60', '11650000', '116500000', '457750', null, '35400');
INSERT INTO `experiences` VALUES ('61', '12450000', '124500000', '473000', null, '36600');
INSERT INTO `experiences` VALUES ('62', '13280000', '132800000', '488500', null, '37820');
INSERT INTO `experiences` VALUES ('63', '14130000', '141300000', '504250', null, '39060');
INSERT INTO `experiences` VALUES ('64', '15170000', '151700000', '520250', null, '40320');
INSERT INTO `experiences` VALUES ('65', '16251000', '162510000', '536500', null, '41600');
INSERT INTO `experiences` VALUES ('66', '17377000', '173770000', '553000', null, '42900');
INSERT INTO `experiences` VALUES ('67', '18553000', '185530000', '569750', null, '44220');
INSERT INTO `experiences` VALUES ('68', '19778000', '197780000', '586750', null, '45560');
INSERT INTO `experiences` VALUES ('69', '21055000', '210550000', '604000', null, '46920');
INSERT INTO `experiences` VALUES ('70', '22385000', '223850000', '621500', null, '48300');
INSERT INTO `experiences` VALUES ('71', '23529000', '235290000', '639250', null, '49700');
INSERT INTO `experiences` VALUES ('72', '25209000', '252090000', '657250', null, '51120');
INSERT INTO `experiences` VALUES ('73', '26707000', '267070000', '675500', null, '52560');
INSERT INTO `experiences` VALUES ('74', '28264000', '282640000', '694000', null, '54020');
INSERT INTO `experiences` VALUES ('75', '29882000', '298820000', '712750', null, '55500');
INSERT INTO `experiences` VALUES ('76', '31563000', '315630000', '731750', null, '57000');
INSERT INTO `experiences` VALUES ('77', '33307000', '333070000', '751000', null, '58520');
INSERT INTO `experiences` VALUES ('78', '35118000', '351180000', '770500', null, '60060');
INSERT INTO `experiences` VALUES ('79', '36997000', '369970000', '790250', null, '61620');
INSERT INTO `experiences` VALUES ('80', '38945000', '389450000', '810250', null, '63200');
INSERT INTO `experiences` VALUES ('81', '40965000', '409650000', '830500', null, '64800');
INSERT INTO `experiences` VALUES ('82', '43059000', '430590000', '851000', null, '66420');
INSERT INTO `experiences` VALUES ('83', '45229000', '452290000', '871750', null, '68060');
INSERT INTO `experiences` VALUES ('84', '47476000', '474760000', '892750', null, '69720');
INSERT INTO `experiences` VALUES ('85', '49803000', '498030000', '914000', null, '71400');
INSERT INTO `experiences` VALUES ('86', '52211000', '522110000', '935500', null, '73100');
INSERT INTO `experiences` VALUES ('87', '54704000', '547040000', '957250', null, '74820');
INSERT INTO `experiences` VALUES ('88', '57284000', '572840000', '979250', null, '76560');
INSERT INTO `experiences` VALUES ('89', '59952000', '599520000', '1001500', null, '78320');
INSERT INTO `experiences` VALUES ('90', '62712000', '627120000', '1024000', null, '80100');
INSERT INTO `experiences` VALUES ('91', '65565000', '655650000', '1046750', null, '81900');
INSERT INTO `experiences` VALUES ('92', '68514000', '685140000', '1069750', null, '83720');
INSERT INTO `experiences` VALUES ('93', '71561000', '715610000', '1093000', null, '85560');
INSERT INTO `experiences` VALUES ('94', '74710000', '747100000', '1116500', null, '87420');
INSERT INTO `experiences` VALUES ('95', '77963000', '779630000', '1140250', null, '89300');
INSERT INTO `experiences` VALUES ('96', '81323000', '813230000', '1164250', null, '91200');
INSERT INTO `experiences` VALUES ('97', '84792000', '847920000', '1188500', null, '93120');
INSERT INTO `experiences` VALUES ('98', '88374000', '883740000', '1213000', null, '95060');
INSERT INTO `experiences` VALUES ('99', '92071000', '920710000', '1237750', null, '97020');
INSERT INTO `experiences` VALUES ('100', '95886000', '958860000', '1262750', null, '99000');
INSERT INTO `experiences` VALUES ('101', '99823000', '998230000', null, null, '101000');
INSERT INTO `experiences` VALUES ('102', '103885000', '1038850000', null, null, '103020');
INSERT INTO `experiences` VALUES ('103', '108075000', '1080750000', null, null, '105060');
INSERT INTO `experiences` VALUES ('104', '112396000', '1123960000', null, null, '107120');
INSERT INTO `experiences` VALUES ('105', '116853000', '1168530000', null, null, '109200');
INSERT INTO `experiences` VALUES ('106', '121447000', '1214470000', null, null, '111300');
INSERT INTO `experiences` VALUES ('107', '126184000', '1261840000', null, null, '113420');
INSERT INTO `experiences` VALUES ('108', '131066000', '1310660000', null, null, '115560');
INSERT INTO `experiences` VALUES ('109', '136098000', '1360980000', null, null, '117720');
INSERT INTO `experiences` VALUES ('110', '141283000', '1412830000', null, null, '119900');
INSERT INTO `experiences` VALUES ('111', '146626000', '1466260000', null, null, '122100');
INSERT INTO `experiences` VALUES ('112', '152130000', '1521300000', null, null, '124320');
INSERT INTO `experiences` VALUES ('113', '157800000', '1578000000', null, null, '126560');
INSERT INTO `experiences` VALUES ('114', '163640000', '1636400000', null, null, '128820');
INSERT INTO `experiences` VALUES ('115', '169655000', '1696550000', null, null, '131100');
INSERT INTO `experiences` VALUES ('116', '175848000', '1758480000', null, null, '133400');
INSERT INTO `experiences` VALUES ('117', '182225000', '1822250000', null, null, '135720');
INSERT INTO `experiences` VALUES ('118', '188791000', '1887910000', null, null, '138060');
INSERT INTO `experiences` VALUES ('119', '195550000', '1955500000', null, null, '140420');
INSERT INTO `experiences` VALUES ('120', '202507000', '2025070000', null, null, '142800');
INSERT INTO `experiences` VALUES ('121', '209667000', '2096670000', null, null, '145200');
INSERT INTO `experiences` VALUES ('122', '217037000', '2170037000', null, null, '147620');
INSERT INTO `experiences` VALUES ('123', '224620000', '2246200000', null, null, '150060');
INSERT INTO `experiences` VALUES ('124', '232424000', '2324240000', null, null, '152520');
INSERT INTO `experiences` VALUES ('125', '240452000', '2404520000', null, null, '155000');
INSERT INTO `experiences` VALUES ('126', '248712000', '2487120000', null, null, '157500');
INSERT INTO `experiences` VALUES ('127', '257209000', '2572090000', null, null, '160020');
INSERT INTO `experiences` VALUES ('128', '265949000', '2659490000', null, null, '162560');
INSERT INTO `experiences` VALUES ('129', '274939000', '2749390000', null, null, '165120');
INSERT INTO `experiences` VALUES ('130', '284186000', '2841860000', null, null, '167700');
INSERT INTO `experiences` VALUES ('131', '293694000', '2936940000', null, null, '170300');
INSERT INTO `experiences` VALUES ('132', '303473000', '3034730000', null, null, '172920');
INSERT INTO `experiences` VALUES ('133', '313527000', '3135270000', null, null, '175560');
INSERT INTO `experiences` VALUES ('134', '323866000', '3236660000', null, null, '178220');
INSERT INTO `experiences` VALUES ('135', '334495000', '3344950000', null, null, '180900');
INSERT INTO `experiences` VALUES ('136', '345423000', '3454230000', null, null, '183600');
INSERT INTO `experiences` VALUES ('137', '356657000', '3566570000', null, null, '186320');
INSERT INTO `experiences` VALUES ('138', '368206000', '3682060000', null, null, '189060');
INSERT INTO `experiences` VALUES ('139', '380076000', '3800760000', null, null, '191820');
INSERT INTO `experiences` VALUES ('140', '392278000', '3922780000', null, null, '194600');
INSERT INTO `experiences` VALUES ('141', '404818000', '4048180000', null, null, '197400');
INSERT INTO `experiences` VALUES ('142', '417706000', '4177060000', null, null, '200220');
INSERT INTO `experiences` VALUES ('143', '430952000', '4309520000', null, null, '203060');
INSERT INTO `experiences` VALUES ('144', '444564000', '4445640000', null, null, '205920');
INSERT INTO `experiences` VALUES ('145', '458551000', '4585510000', null, null, '208800');
INSERT INTO `experiences` VALUES ('146', '472924000', '4729240000', null, null, '211700');
INSERT INTO `experiences` VALUES ('147', '487693000', '4876930000', null, null, '214620');
INSERT INTO `experiences` VALUES ('148', '502867000', '5028670000', null, null, '217560');
INSERT INTO `experiences` VALUES ('149', '518458000', '5184580000', null, null, '220520');
INSERT INTO `experiences` VALUES ('150', '534476000', '5344760000', null, null, '223500');
INSERT INTO `experiences` VALUES ('151', '502867000', '5510000000', null, null, '226500');
INSERT INTO `experiences` VALUES ('152', '567839000', '5678390000', null, null, '229520');
INSERT INTO `experiences` VALUES ('153', '585206000', '5852060000', null, null, '232560');
INSERT INTO `experiences` VALUES ('154', '603047000', '6030470000', null, null, '235620');
INSERT INTO `experiences` VALUES ('155', '621374000', '6213740000', null, null, '238700');
INSERT INTO `experiences` VALUES ('156', '640199000', '6401990000', null, null, '241800');
INSERT INTO `experiences` VALUES ('157', '659536000', '6595360000', null, null, '244920');
INSERT INTO `experiences` VALUES ('158', '679398000', '6793980000', null, null, '248060');
INSERT INTO `experiences` VALUES ('159', '699798000', '6997980000', null, null, '251220');
INSERT INTO `experiences` VALUES ('160', '720751000', '7207510000', null, null, '254400');
INSERT INTO `experiences` VALUES ('161', '742772000', '7422720000', null, null, '257600');
INSERT INTO `experiences` VALUES ('162', '764374000', '7643740000', null, null, '260820');
INSERT INTO `experiences` VALUES ('163', '787074000', '7870740000', null, null, '264060');
INSERT INTO `experiences` VALUES ('164', '810387000', '8103870000', null, null, '267320');
INSERT INTO `experiences` VALUES ('165', '834329000', '8343290000', null, null, '270600');
INSERT INTO `experiences` VALUES ('166', '858917000', '8589170000', null, null, '273900');
INSERT INTO `experiences` VALUES ('167', '884167000', '8841670000', null, null, '277220');
INSERT INTO `experiences` VALUES ('168', '910098000', '9100980000', null, null, '280560');
INSERT INTO `experiences` VALUES ('169', '936727000', '9367270000', null, null, '283920');
INSERT INTO `experiences` VALUES ('170', '964073000', '9640730000', null, null, '287300');
INSERT INTO `experiences` VALUES ('171', '992154000', '9921540000', null, null, '290700');
INSERT INTO `experiences` VALUES ('172', '1020991000', '10209910000', null, null, '294120');
INSERT INTO `experiences` VALUES ('173', '1050603000', '10506030000', null, null, '297560');
INSERT INTO `experiences` VALUES ('174', '1081010000', '10810100000', null, null, '301020');
INSERT INTO `experiences` VALUES ('175', '1112235000', '11122350000', null, null, '304500');
INSERT INTO `experiences` VALUES ('176', '1144298000', '11442980000', null, null, '308000');
INSERT INTO `experiences` VALUES ('177', '1177222000', '11772220000', null, null, '311520');
INSERT INTO `experiences` VALUES ('178', '1211030000', '12110300000', null, null, '315060');
INSERT INTO `experiences` VALUES ('179', '1245745000', '12457450000', null, null, '318620');
INSERT INTO `experiences` VALUES ('180', '1281393000', '12813930000', null, null, '322200');
INSERT INTO `experiences` VALUES ('181', '1317997000', '13179970000', null, null, '325800');
INSERT INTO `experiences` VALUES ('182', '1355584000', '13555840000', null, null, '329420');
INSERT INTO `experiences` VALUES ('183', '1404179000', '14041790000', null, null, '333060');
INSERT INTO `experiences` VALUES ('184', '1463811000', '14338110000', null, null, '336720');
INSERT INTO `experiences` VALUES ('185', '1534506000', '14745060000', null, null, '340400');
INSERT INTO `experiences` VALUES ('186', '1616294000', '15162940000', null, null, '344100');
INSERT INTO `experiences` VALUES ('187', '1709205000', '15592050000', null, null, '347820');
INSERT INTO `experiences` VALUES ('188', '1813267000', '16032670000', null, null, '351560');
INSERT INTO `experiences` VALUES ('189', '1928513000', '16485130000', null, null, '355320');
INSERT INTO `experiences` VALUES ('190', '2054975000', '16949750000', null, null, '359100');
INSERT INTO `experiences` VALUES ('191', '2192686000', '17426860000', null, null, '362900');
INSERT INTO `experiences` VALUES ('192', '2341679000', '17916460000', null, null, '366720');
INSERT INTO `experiences` VALUES ('193', '2501990000', '18419900000', null, null, '370560');
INSERT INTO `experiences` VALUES ('194', '2673655000', '18936550000', null, null, '374420');
INSERT INTO `experiences` VALUES ('195', '2856710000', '19467100000', null, null, '378300');
INSERT INTO `experiences` VALUES ('196', '3051194000', '20011940000', null, null, '382200');
INSERT INTO `experiences` VALUES ('197', '3257146000', '20571460000', null, null, '386120');
INSERT INTO `experiences` VALUES ('198', '3474606000', '21146060000', null, null, '390060');
INSERT INTO `experiences` VALUES ('199', '3703616000', '21736160000', null, null, '394020');
INSERT INTO `experiences` VALUES ('200', '5555424000', '22356230000', null, null, '398000');

-- ----------------------------
-- Table structure for guilds
-- ----------------------------
DROP TABLE IF EXISTS `guilds`;
CREATE TABLE `guilds` (
  `Id` int(10) unsigned NOT NULL,
  `OwnerId` int(10) unsigned NOT NULL,
  `SymbolShape` int(10) unsigned NOT NULL,
  `CreationDate` int(11) NOT NULL,
  `SymbolColor` int(10) unsigned NOT NULL,
  `BackgroundShape` int(10) unsigned NOT NULL,
  `BackgroundColor` int(10) unsigned NOT NULL,
  `Experience` bigint(20) NOT NULL,
  `Emblem` int(10) unsigned NOT NULL,
  `Name` mediumtext NOT NULL,
  `Description` mediumtext NOT NULL,
  `Announcement` mediumtext NOT NULL,
  `DateChangeDescription` mediumtext NOT NULL,
  `DateChangeAnnouncement` mediumtext NOT NULL,
  `NameChangeDescription` mediumtext NOT NULL,
  `NameChangeAnnouncement` mediumtext NOT NULL,
  `AllianceId` int(10) unsigned NOT NULL,
  `MaxPerco` tinyint(4) NOT NULL,
  `Pods` int(10) unsigned NOT NULL,
  `Prospecting` int(10) unsigned NOT NULL,
  `Wisdom` int(10) unsigned NOT NULL,
  `BoostPoints` int(10) unsigned NOT NULL,
  `SpellIds` mediumtext NOT NULL,
  `SpellLevel` mediumtext NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of guilds
-- ----------------------------

-- ----------------------------
-- Table structure for guild_members
-- ----------------------------
DROP TABLE IF EXISTS `guild_members`;
CREATE TABLE `guild_members` (
  `CharacterId` int(10) unsigned NOT NULL,
  `AccountId` int(10) unsigned NOT NULL,
  `GuildId` int(10) unsigned NOT NULL,
  `RankId` smallint(5) unsigned NOT NULL,
  `Rights` int(11) NOT NULL,
  `GivenExperience` bigint(20) NOT NULL,
  `GivenPercent` tinyint(4) NOT NULL,
  PRIMARY KEY (`CharacterId`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of guild_members
-- ----------------------------

-- ----------------------------
-- Table structure for hdv_item
-- ----------------------------
DROP TABLE IF EXISTS `hdv_item`;
CREATE TABLE `hdv_item` (
  `Id` int(11) NOT NULL,
  `OwnerId` int(11) NOT NULL,
  `TemplateId` int(10) unsigned NOT NULL,
  `TypeId` int(10) unsigned NOT NULL,
  `Stack` int(10) unsigned NOT NULL,
  `Price` int(10) unsigned NOT NULL,
  `IsSelled` tinyint(4) NOT NULL,
  `IsCancel` tinyint(4) NOT NULL,
  `UnsolDelaySTR` mediumtext NOT NULL,
  `AddDaySTR` mediumtext NOT NULL,
  `SerializedEffects` longblob,
  PRIMARY KEY (`Id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of hdv_item
-- ----------------------------

-- ----------------------------
-- Table structure for interactive_datas
-- ----------------------------
DROP TABLE IF EXISTS `interactive_datas`;
CREATE TABLE `interactive_datas` (
  `Id` int(11) NOT NULL,
  `Type` int(11) NOT NULL,
  `MapId` int(11) NOT NULL,
  `Data1` int(11) NOT NULL,
  `Data2` int(11) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of interactive_datas
-- ----------------------------
INSERT INTO `interactive_datas` VALUES ('465415', '1', '84673024', '83625984', '410');
INSERT INTO `interactive_datas` VALUES ('465429', '1', '84674563', '83886080', '270');
INSERT INTO `interactive_datas` VALUES ('465430', '1', '83886080', '84674563', '242');
INSERT INTO `interactive_datas` VALUES ('465428', '1', '84674563', '83888130', '386');
INSERT INTO `interactive_datas` VALUES ('464298', '1', '83888130', '83888132', '354');
INSERT INTO `interactive_datas` VALUES ('464299', '1', '83888132', '83888130', '382');
INSERT INTO `interactive_datas` VALUES ('465735', '1', '84674561', '122159617', '386');
INSERT INTO `interactive_datas` VALUES ('465422', '1', '84804097', '83887106', '457');
INSERT INTO `interactive_datas` VALUES ('465423', '1', '84804098', '83886086', '374');
INSERT INTO `interactive_datas` VALUES ('465443', '1', '84672519', '83628034', '381');
INSERT INTO `interactive_datas` VALUES ('489982', '1', '84672517', '83624964', '328');
INSERT INTO `interactive_datas` VALUES ('465405', '1', '84672514', '83363840', '339');
INSERT INTO `interactive_datas` VALUES ('465421', '1', '84672513', '83627008', '312');
INSERT INTO `interactive_datas` VALUES ('465609', '1', '84672512', '83892226', '402');
INSERT INTO `interactive_datas` VALUES ('465610', '1', '83892226', '83892228', '423');
INSERT INTO `interactive_datas` VALUES ('466104', '1', '83892228', '83892226', '325');
INSERT INTO `interactive_datas` VALUES ('465403', '1', '84672512', '83361792', '339');
INSERT INTO `interactive_datas` VALUES ('465416', '1', '84673536', '67371008', '452');
INSERT INTO `interactive_datas` VALUES ('465424', '1', '84673026', '83889152', '353');
INSERT INTO `interactive_datas` VALUES ('464126', '1', '83889152', '83889158', '414');
INSERT INTO `interactive_datas` VALUES ('464127', '1', '83889158', '83889152', '413');
INSERT INTO `interactive_datas` VALUES ('464106', '1', '83889152', '83889154', '231');
INSERT INTO `interactive_datas` VALUES ('464118', '1', '83889154', '83889156', '346');
INSERT INTO `interactive_datas` VALUES ('464119', '1', '83889156', '83889154', '374');
INSERT INTO `interactive_datas` VALUES ('464107', '1', '83889154', '83889152', '319');
INSERT INTO `interactive_datas` VALUES ('465438', '1', '84673030', '83891204', '388');
INSERT INTO `interactive_datas` VALUES ('465759', '1', '84673032', '83890184', '454');
INSERT INTO `interactive_datas` VALUES ('465802', '1', '83890184', '84673032', '207');
INSERT INTO `interactive_datas` VALUES ('489547', '1', '84674055', '83623940', '396');
INSERT INTO `interactive_datas` VALUES ('465439', '1', '84673542', '83629056', '397');
INSERT INTO `interactive_datas` VALUES ('465437', '1', '84673541', '83629058', '397');
INSERT INTO `interactive_datas` VALUES ('465440', '1', '84674566', '83887104', '382');
INSERT INTO `interactive_datas` VALUES ('465441', '1', '84675078', '83625986', '383');
INSERT INTO `interactive_datas` VALUES ('465426', '1', '84676098', '83624960', '354');
INSERT INTO `interactive_datas` VALUES ('465417', '1', '84675585', '83624962', '356');
INSERT INTO `interactive_datas` VALUES ('465425', '1', '84675074', '83628032', '382');
INSERT INTO `interactive_datas` VALUES ('465420', '1', '84673537', '83623936', '313');
INSERT INTO `interactive_datas` VALUES ('465442', '1', '84673543', '83890182', '386');
INSERT INTO `interactive_datas` VALUES ('464613', '1', '83890182', '83891206', '386');
INSERT INTO `interactive_datas` VALUES ('464614', '1', '83891206', '83890182', '326');
INSERT INTO `interactive_datas` VALUES ('489670', '1', '84673544', '83364864', '339');
INSERT INTO `interactive_datas` VALUES ('465404', '1', '84675589', '83362816', '339');
INSERT INTO `interactive_datas` VALUES ('465407', '1', '84675588', '83365888', '339');
INSERT INTO `interactive_datas` VALUES ('465432', '1', '84675076', '83886082', '400');
INSERT INTO `interactive_datas` VALUES ('464142', '1', '83886082', '83886084', '401');
INSERT INTO `interactive_datas` VALUES ('464143', '1', '83886084', '83886082', '413');
INSERT INTO `interactive_datas` VALUES ('465411', '1', '84675076', '83362818', '339');
INSERT INTO `interactive_datas` VALUES ('465410', '1', '84674564', '83363842', '339');
INSERT INTO `interactive_datas` VALUES ('478968', '1', '84676355', '83623938', '410');
INSERT INTO `interactive_datas` VALUES ('472245', '2', '84674562', '273', '0');
INSERT INTO `interactive_datas` VALUES ('489412', '2', '153878787', '420', '0');
INSERT INTO `interactive_datas` VALUES ('478958', '1', '84677377', '102236673', '536');
INSERT INTO `interactive_datas` VALUES ('479463', '3', '102237699', '120', '0');
INSERT INTO `interactive_datas` VALUES ('455475', '1', '5506050', '5508100', '312');
INSERT INTO `interactive_datas` VALUES ('455476', '1', '5508100', '5506050', '291');
INSERT INTO `interactive_datas` VALUES ('507245', '2', '5505032', '460', '0');
INSERT INTO `interactive_datas` VALUES ('507244', '2', '5505032', '459', '0');
INSERT INTO `interactive_datas` VALUES ('507243', '2', '5505032', '458', '0');
INSERT INTO `interactive_datas` VALUES ('507239', '2', '5505032', '457', '0');
INSERT INTO `interactive_datas` VALUES ('507240', '2', '5505032', '456', '0');
INSERT INTO `interactive_datas` VALUES ('507241', '2', '5505032', '455', '0');
INSERT INTO `interactive_datas` VALUES ('507242', '2', '5505032', '454', '0');
INSERT INTO `interactive_datas` VALUES ('507246', '2', '5505032', '453', '0');
INSERT INTO `interactive_datas` VALUES ('507247', '2', '5505032', '452', '0');
INSERT INTO `interactive_datas` VALUES ('450670', '3', '148281', '100', '0');
INSERT INTO `interactive_datas` VALUES ('462676', '1', '148281', '148281', '262');
INSERT INTO `interactive_datas` VALUES ('417169', '1', '148281', '148282', '539');
INSERT INTO `interactive_datas` VALUES ('415124', '1', '148282', '2883602', '464');
INSERT INTO `interactive_datas` VALUES ('462043', '2', '2883602', '241', '0');
INSERT INTO `interactive_datas` VALUES ('415752', '1', '148796', '3145732', '401');
INSERT INTO `interactive_datas` VALUES ('433928', '1', '148796', '3145732', '479');
INSERT INTO `interactive_datas` VALUES ('415753', '1', '148797', '3145733', '382');
INSERT INTO `interactive_datas` VALUES ('417469', '1', '148797', '3145736', '410');
INSERT INTO `interactive_datas` VALUES ('438157', '1', '3145736', '3146248', '285');
INSERT INTO `interactive_datas` VALUES ('438159', '1', '3146248', '3146760', '313');
INSERT INTO `interactive_datas` VALUES ('438158', '1', '3146760', '3146248', '368');
INSERT INTO `interactive_datas` VALUES ('438156', '1', '3146248', '3145736', '395');
INSERT INTO `interactive_datas` VALUES ('489663', '1', '149309', '2884633', '444');
INSERT INTO `interactive_datas` VALUES ('489662', '1', '2884633', '2883609', '387');
INSERT INTO `interactive_datas` VALUES ('489661', '1', '2883609', '2884631', '410');
INSERT INTO `interactive_datas` VALUES ('489641', '1', '2883609', '2884633', '269');
INSERT INTO `interactive_datas` VALUES ('416973', '1', '149305', '2883612', '397');
INSERT INTO `interactive_datas` VALUES ('438163', '1', '2883612', '2884124', '314');
INSERT INTO `interactive_datas` VALUES ('438165', '1', '2884124', '2884636', '314');
INSERT INTO `interactive_datas` VALUES ('438164', '1', '2884636', '2884124', '397');
INSERT INTO `interactive_datas` VALUES ('438162', '1', '2884124', '2883612', '382');
INSERT INTO `interactive_datas` VALUES ('438184', '1', '2883612', '149305', '527');
INSERT INTO `interactive_datas` VALUES ('415137', '1', '149812', '2884629', '396');
INSERT INTO `interactive_datas` VALUES ('435760', '1', '148790', '25035265', '191');
INSERT INTO `interactive_datas` VALUES ('435759', '1', '25035265', '148790', '423');
INSERT INTO `interactive_datas` VALUES ('415074', '1', '148278', '2883599', '436');
INSERT INTO `interactive_datas` VALUES ('415766', '1', '147764', '4719111', '396');
INSERT INTO `interactive_datas` VALUES ('455687', '1', '4719111', '4720135', '313');
INSERT INTO `interactive_datas` VALUES ('455930', '1', '4720135', '4719111', '352');
INSERT INTO `interactive_datas` VALUES ('416344', '1', '146226', '6291461', '397');
INSERT INTO `interactive_datas` VALUES ('416866', '3', '144690', '172', '0');
INSERT INTO `interactive_datas` VALUES ('435768', '1', '144690', '24907781', '234');
INSERT INTO `interactive_datas` VALUES ('435766', '1', '24907781', '144690', '288');
INSERT INTO `interactive_datas` VALUES ('430384', '1', '144698', '6554631', '451');
INSERT INTO `interactive_datas` VALUES ('435762', '1', '144700', '24908036', '124');
INSERT INTO `interactive_datas` VALUES ('416353', '1', '145213', '6554118', '423');
INSERT INTO `interactive_datas` VALUES ('294', '1', '6554118', '6554630', '315');
INSERT INTO `interactive_datas` VALUES ('292', '1', '6555142', '6554630', '382');
INSERT INTO `interactive_datas` VALUES ('438161', '1', '6554630', '6554118', '422');
INSERT INTO `interactive_datas` VALUES ('455691', '1', '6554118', '6553606', '397');
INSERT INTO `interactive_datas` VALUES ('455972', '1', '6553606', '6554118', '245');
INSERT INTO `interactive_datas` VALUES ('415069', '1', '145209', '7340551', '386');
INSERT INTO `interactive_datas` VALUES ('416369', '1', '145208', '7340549', '464');
INSERT INTO `interactive_datas` VALUES ('416370', '1', '145208', '7340549', '401');
INSERT INTO `interactive_datas` VALUES ('448040', '1', '145719', '7340038', '394');
INSERT INTO `interactive_datas` VALUES ('416390', '1', '146232', '7864327', '382');
INSERT INTO `interactive_datas` VALUES ('455692', '1', '7864327', '7864839', '341');
INSERT INTO `interactive_datas` VALUES ('382', '1', '7864839', '7864327', '352');
INSERT INTO `interactive_datas` VALUES ('416387', '1', '146233', '7864326', '415');
INSERT INTO `interactive_datas` VALUES ('416386', '1', '146233', '7864326', '424');
INSERT INTO `interactive_datas` VALUES ('416393', '1', '146234', '7864328', '410');
INSERT INTO `interactive_datas` VALUES ('455693', '1', '7864328', '7865352', '341');
INSERT INTO `interactive_datas` VALUES ('455694', '1', '7865352', '7864328', '366');
INSERT INTO `interactive_datas` VALUES ('453463', '1', '146237', '6816261', '442');
INSERT INTO `interactive_datas` VALUES ('453462', '1', '146237', '6816261', '436');
INSERT INTO `interactive_datas` VALUES ('433933', '1', '147254', '2883593', '410');
INSERT INTO `interactive_datas` VALUES ('433934', '1', '147254', '2884617', '410');
INSERT INTO `interactive_datas` VALUES ('477568', '2', '147766', '338', '0');
INSERT INTO `interactive_datas` VALUES ('415126', '1', '147767', '2883603', '437');
INSERT INTO `interactive_datas` VALUES ('455465', '1', '2883603', '2884627', '325');
INSERT INTO `interactive_datas` VALUES ('455914', '1', '2884627', '2883603', '366');
INSERT INTO `interactive_datas` VALUES ('415073', '1', '147769', '2884110', '492');
INSERT INTO `interactive_datas` VALUES ('455634', '3', '2884110', '129', '0');
INSERT INTO `interactive_datas` VALUES ('455635', '3', '2884110', '130', '0');
INSERT INTO `interactive_datas` VALUES ('455636', '3', '2884110', '185', '0');
INSERT INTO `interactive_datas` VALUES ('462055', '1', '2884110', '74186754', '415');
INSERT INTO `interactive_datas` VALUES ('462052', '1', '2884110', '4980738', '328');
INSERT INTO `interactive_datas` VALUES ('477569', '2', '147771', '337', '0');
INSERT INTO `interactive_datas` VALUES ('454040', '3', '3145736', '120', '0');
INSERT INTO `interactive_datas` VALUES ('437131', '1', '143372', '18350082', '238');
INSERT INTO `interactive_datas` VALUES ('500706', '1', '142088201', '39845888', '452');
INSERT INTO `interactive_datas` VALUES ('508892', '1', '139723779', '139993605', '514');
INSERT INTO `interactive_datas` VALUES ('485619', '1', '139723779', '139993611', '559');
INSERT INTO `interactive_datas` VALUES ('485620', '1', '139724805', '139993609', '423');
INSERT INTO `interactive_datas` VALUES ('509168', '1', '139993609', '139724805', '371');
INSERT INTO `interactive_datas` VALUES ('485635', '1', '139725314', '139992583', '518');
INSERT INTO `interactive_datas` VALUES ('485638', '1', '139724801', '139993607', '545');
INSERT INTO `interactive_datas` VALUES ('489396', '2', '153878787', '285', '0');
INSERT INTO `interactive_datas` VALUES ('489391', '2', '154010882', '286', '0');
INSERT INTO `interactive_datas` VALUES ('489392', '2', '154010624', '288', '0');
INSERT INTO `interactive_datas` VALUES ('489393', '2', '153879297', '278', '0');
INSERT INTO `interactive_datas` VALUES ('489389', '2', '153879301', '283', '0');
INSERT INTO `interactive_datas` VALUES ('489390', '2', '153880836', '289', '0');
INSERT INTO `interactive_datas` VALUES ('433918', '1', '144420', '13631488', '520');
INSERT INTO `interactive_datas` VALUES ('465427', '1', '84675587', '101716483', '509');
INSERT INTO `interactive_datas` VALUES ('476200', '1', '101715459', '101715461', '204');
INSERT INTO `interactive_datas` VALUES ('476188', '1', '101715461', '101715459', '208');
INSERT INTO `interactive_datas` VALUES ('476186', '1', '101714433', '101713409', '174');
INSERT INTO `interactive_datas` VALUES ('476185', '1', '101713409', '101714433', '184');
INSERT INTO `interactive_datas` VALUES ('465431', '1', '84673539', '83887110', '424');
INSERT INTO `interactive_datas` VALUES ('480310', '5', '106169344', '0', '0');
INSERT INTO `interactive_datas` VALUES ('433921', '1', '142888', '8912915', '397');
INSERT INTO `interactive_datas` VALUES ('415674', '1', '145447', '12058630', '410');
INSERT INTO `interactive_datas` VALUES ('415696', '1', '146467', '12845062', '397');
INSERT INTO `interactive_datas` VALUES ('415668', '1', '145952', '12320775', '437');
INSERT INTO `interactive_datas` VALUES ('415724', '1', '142884', '13893638', '397');
INSERT INTO `interactive_datas` VALUES ('455142', '1', '13893638', '13894150', '313');
INSERT INTO `interactive_datas` VALUES ('455143', '1', '13894150', '13893638', '352');
INSERT INTO `interactive_datas` VALUES ('455315', '1', '13893638', '142884', '382');
INSERT INTO `interactive_datas` VALUES ('415155', '1', '145444', '8912909', '424');
INSERT INTO `interactive_datas` VALUES ('455045', '1', '8912909', '8913933', '325');
INSERT INTO `interactive_datas` VALUES ('455926', '1', '8913933', '8912909', '366');
INSERT INTO `interactive_datas` VALUES ('415713', '1', '141858', '13369350', '353');
INSERT INTO `interactive_datas` VALUES ('415715', '1', '141346', '13369863', '386');
INSERT INTO `interactive_datas` VALUES ('415688', '1', '142880', '12582918', '369');
INSERT INTO `interactive_datas` VALUES ('433930', '1', '141351', '8913419', '382');
INSERT INTO `interactive_datas` VALUES ('415703', '1', '141864', '13107206', '359');
INSERT INTO `interactive_datas` VALUES ('415726', '1', '143396', '13893639', '382');
INSERT INTO `interactive_datas` VALUES ('455258', '1', '13893639', '13894151', '313');
INSERT INTO `interactive_datas` VALUES ('455317', '1', '13894151', '13893639', '352');
INSERT INTO `interactive_datas` VALUES ('419011', '1', '144934', '8912922', '506');
INSERT INTO `interactive_datas` VALUES ('455083', '1', '8912922', '11796482', '342');
INSERT INTO `interactive_datas` VALUES ('462059', '1', '8912922', '11796994', '511');
INSERT INTO `interactive_datas` VALUES ('462060', '1', '8912922', '11797506', '328');
INSERT INTO `interactive_datas` VALUES ('415664', '1', '145445', '8913941', '426');
INSERT INTO `interactive_datas` VALUES ('415351', '1', '144931', '8914959', '410');
INSERT INTO `interactive_datas` VALUES ('415350', '1', '144931', '8913935', '410');
INSERT INTO `interactive_datas` VALUES ('415349', '1', '144931', '8912911', '410');
INSERT INTO `interactive_datas` VALUES ('415659', '1', '144930', '8912916', '397');
INSERT INTO `interactive_datas` VALUES ('455069', '1', '8912916', '8913428', '298');
INSERT INTO `interactive_datas` VALUES ('455922', '1', '8913428', '8912916', '367');
INSERT INTO `interactive_datas` VALUES ('502335', '1', '13631488', '13632512', '366');
INSERT INTO `interactive_datas` VALUES ('455932', '1', '13632512', '13633536', '150');
INSERT INTO `interactive_datas` VALUES ('459377', '1', '13633536', '69994496', '394');
INSERT INTO `interactive_datas` VALUES ('459027', '1', '69994496', '13633536', '270');
INSERT INTO `interactive_datas` VALUES ('455369', '1', '13633536', '13632512', '319');
INSERT INTO `interactive_datas` VALUES ('455365', '1', '13632512', '13631488', '458');
INSERT INTO `interactive_datas` VALUES ('455373', '1', '13631488', '13634560', '325');
INSERT INTO `interactive_datas` VALUES ('455375', '1', '13634560', '13631490', '245');
INSERT INTO `interactive_datas` VALUES ('455381', '1', '13631490', '13633538', '276');
INSERT INTO `interactive_datas` VALUES ('455933', '1', '13633538', '13631490', '332');
INSERT INTO `interactive_datas` VALUES ('455934', '1', '13633538', '13631490', '332');
INSERT INTO `interactive_datas` VALUES ('455937', '1', '13631490', '13634560', '230');
INSERT INTO `interactive_datas` VALUES ('455938', '1', '13631490', '13634560', '230');
INSERT INTO `interactive_datas` VALUES ('455376', '1', '13634560', '13631490', '245');
INSERT INTO `interactive_datas` VALUES ('502347', '1', '13632524', '13633548', '261');
INSERT INTO `interactive_datas` VALUES ('502324', '1', '13633548', '13632524', '452');
INSERT INTO `interactive_datas` VALUES ('502323', '1', '13633548', '13632524', '437');
INSERT INTO `interactive_datas` VALUES ('502319', '1', '13632524', '13631500', '452');
INSERT INTO `interactive_datas` VALUES ('502336', '1', '13634560', '13631488', '76');
INSERT INTO `interactive_datas` VALUES ('455422', '1', '13631488', '144420', '262');
INSERT INTO `interactive_datas` VALUES ('415729', '1', '144420', '13631488', '477');
INSERT INTO `interactive_datas` VALUES ('415722', '1', '143395', '13894149', '450');
INSERT INTO `interactive_datas` VALUES ('415710', '1', '142375', '13107205', '451');
INSERT INTO `interactive_datas` VALUES ('450710', '1', '142367', '12583429', '452');
INSERT INTO `interactive_datas` VALUES ('415666', '1', '144425', '12058631', '465');
INSERT INTO `interactive_datas` VALUES ('433925', '1', '144418', '11273220', '465');
INSERT INTO `interactive_datas` VALUES ('455424', '1', '11273220', '11273218', '396');
INSERT INTO `interactive_datas` VALUES ('455445', '1', '11273218', '11273216', '396');
INSERT INTO `interactive_datas` VALUES ('455450', '1', '11274240', '11273216', '431');
INSERT INTO `interactive_datas` VALUES ('455451', '1', '11273216', '11272192', '459');
INSERT INTO `interactive_datas` VALUES ('455443', '1', '11273216', '11273218', '261');
INSERT INTO `interactive_datas` VALUES ('455444', '1', '11273218', '11272194', '459');
INSERT INTO `interactive_datas` VALUES ('455442', '1', '11274242', '11273218', '431');
INSERT INTO `interactive_datas` VALUES ('455386', '1', '11273218', '11273220', '261');
INSERT INTO `interactive_datas` VALUES ('455385', '1', '11274244', '11273220', '431');
INSERT INTO `interactive_datas` VALUES ('446260', '1', '144418', '11273220', '450');
INSERT INTO `interactive_datas` VALUES ('435747', '1', '145951', '28445445', '228');
INSERT INTO `interactive_datas` VALUES ('435756', '1', '28445445', '145951', '343');
INSERT INTO `interactive_datas` VALUES ('462675', '1', '145951', '145951', '197');
INSERT INTO `interactive_datas` VALUES ('435749', '1', '142879', '28312325', '134');
INSERT INTO `interactive_datas` VALUES ('435752', '1', '28312325', '142879', '543');
INSERT INTO `interactive_datas` VALUES ('435751', '1', '144425', '28444672', '212');
INSERT INTO `interactive_datas` VALUES ('435753', '1', '28444672', '144425', '63');
INSERT INTO `interactive_datas` VALUES ('435748', '1', '141862', '28312578', '226');
INSERT INTO `interactive_datas` VALUES ('435755', '1', '28312578', '141862', '105');
INSERT INTO `interactive_datas` VALUES ('415122', '1', '146229', '2884113', '369');
INSERT INTO `interactive_datas` VALUES ('415695', '1', '144700', '6553607', '395');
INSERT INTO `interactive_datas` VALUES ('455688', '1', '4719111', '4720135', '313');
INSERT INTO `interactive_datas` VALUES ('455929', '1', '4720135', '4719111', '352');
INSERT INTO `interactive_datas` VALUES ('455913', '1', '2884627', '2883603', '366');
INSERT INTO `interactive_datas` VALUES ('455466', '1', '2883603', '2884627', '325');
INSERT INTO `interactive_datas` VALUES ('416362', '1', '145725', '6815750', '424');
INSERT INTO `interactive_datas` VALUES ('462054', '1', '2884110', '4981762', '328');
INSERT INTO `interactive_datas` VALUES ('462053', '1', '2884110', '4981250', '511');
INSERT INTO `interactive_datas` VALUES ('433935', '1', '147254', '2885641', '410');
INSERT INTO `interactive_datas` VALUES ('415077', '1', '148279', '2883600', '411');
INSERT INTO `interactive_datas` VALUES ('455461', '1', '2883600', '2884624', '312');
INSERT INTO `interactive_datas` VALUES ('455629', '1', '2884624', '2883600', '282');
INSERT INTO `interactive_datas` VALUES ('455462', '1', '2883600', '2884624', '312');
INSERT INTO `interactive_datas` VALUES ('415740', '1', '148280', '5506048', '506');
INSERT INTO `interactive_datas` VALUES ('455477', '1', '5508100', '5506050', '291');
INSERT INTO `interactive_datas` VALUES ('455484', '1', '5506050', '5507074', '189');
INSERT INTO `interactive_datas` VALUES ('455485', '1', '5507074', '5506050', '257');
INSERT INTO `interactive_datas` VALUES ('455486', '1', '5507074', '5506050', '257');
INSERT INTO `interactive_datas` VALUES ('455473', '1', '5506050', '5505028', '204');
INSERT INTO `interactive_datas` VALUES ('455474', '1', '5505028', '5506050', '353');
INSERT INTO `interactive_datas` VALUES ('415764', '1', '148786', '4718598', '443');
INSERT INTO `interactive_datas` VALUES ('416400', '1', '145714', '6291462', '437');
INSERT INTO `interactive_datas` VALUES ('416402', '1', '145714', '6291462', '443');
INSERT INTO `interactive_datas` VALUES ('435765', '1', '148795', '24903939', '157');
INSERT INTO `interactive_datas` VALUES ('435764', '1', '24903939', '148795', '276');
INSERT INTO `interactive_datas` VALUES ('459992', '1', '68552193', '95683073', '472');
INSERT INTO `interactive_datas` VALUES ('471354', '1', '95683073', '95684097', '430');
INSERT INTO `interactive_datas` VALUES ('471358', '1', '95685121', '95684097', '395');
INSERT INTO `interactive_datas` VALUES ('471359', '1', '95685121', '95687169', '386');
INSERT INTO `interactive_datas` VALUES ('471360', '1', '95687169', '95686145', '465');
INSERT INTO `interactive_datas` VALUES ('471356', '1', '95686145', '95683075', '500');
INSERT INTO `interactive_datas` VALUES ('471362', '1', '95686145', '95685123', '438');
INSERT INTO `interactive_datas` VALUES ('471355', '1', '95684097', '95686145', '488');
INSERT INTO `interactive_datas` VALUES ('462678', '1', '68551682', '68551682', '249');
INSERT INTO `interactive_datas` VALUES ('472240', '1', '88082201', '17049600', '438');
INSERT INTO `interactive_datas` VALUES ('438236', '1', '17049600', '17049602', '438');
INSERT INTO `interactive_datas` VALUES ('460501', '1', '17049602', '17049604', '409');
INSERT INTO `interactive_datas` VALUES ('472900', '1', '88082200', '99093005', '384');
INSERT INTO `interactive_datas` VALUES ('472896', '1', '88081176', '99090953', '342');
INSERT INTO `interactive_datas` VALUES ('474848', '1', '99090953', '99091977', '414');
INSERT INTO `interactive_datas` VALUES ('474851', '1', '99094025', '99090953', '329');
INSERT INTO `interactive_datas` VALUES ('474849', '1', '99090953', '99093001', '317');
INSERT INTO `interactive_datas` VALUES ('474850', '1', '99093001', '99090953', '289');
INSERT INTO `interactive_datas` VALUES ('474872', '1', '99093001', '88081176', '171');
INSERT INTO `interactive_datas` VALUES ('472899', '1', '88081176', '99095049', '375');
INSERT INTO `interactive_datas` VALUES ('474853', '1', '99095049', '99094025', '402');
INSERT INTO `interactive_datas` VALUES ('472895', '1', '88080664', '99090945', '400');
INSERT INTO `interactive_datas` VALUES ('472892', '1', '88080665', '99092997', '371');
INSERT INTO `interactive_datas` VALUES ('474842', '1', '99092997', '99094021', '300');
INSERT INTO `interactive_datas` VALUES ('472893', '1', '88081177', '99095051', '397');
INSERT INTO `interactive_datas` VALUES ('474896', '1', '88212250', '99352590', '429');
INSERT INTO `interactive_datas` VALUES ('473018', '1', '88212250', '97255955', '479');
INSERT INTO `interactive_datas` VALUES ('473021', '1', '88212251', '4461569', '540');
INSERT INTO `interactive_datas` VALUES ('472732', '1', '88212763', '17048576', '441');
INSERT INTO `interactive_datas` VALUES ('460874', '1', '17048576', '17048578', '325');
INSERT INTO `interactive_datas` VALUES ('460877', '1', '17048582', '17048578', '455');
INSERT INTO `interactive_datas` VALUES ('460876', '1', '17048578', '17048580', '409');
INSERT INTO `interactive_datas` VALUES ('460878', '1', '17048582', '17048584', '371');
INSERT INTO `interactive_datas` VALUES ('460875', '1', '17048578', '17048576', '311');
INSERT INTO `interactive_datas` VALUES ('460873', '1', '17048576', '88212763', '304');
INSERT INTO `interactive_datas` VALUES ('472891', '1', '88213274', '99353612', '354');
INSERT INTO `interactive_datas` VALUES ('462674', '1', '88080666', '88080666', '348');
INSERT INTO `interactive_datas` VALUES ('472901', '1', '88212247', '99090957', '457');
INSERT INTO `interactive_datas` VALUES ('472949', '1', '88214295', '17046528', '374');
INSERT INTO `interactive_datas` VALUES ('472948', '1', '88214295', '17046528', '428');
INSERT INTO `interactive_datas` VALUES ('460427', '1', '17046528', '17046530', '430');
INSERT INTO `interactive_datas` VALUES ('460430', '1', '17046530', '17046532', '430');
INSERT INTO `interactive_datas` VALUES ('460431', '1', '17046532', '17046534', '459');
INSERT INTO `interactive_datas` VALUES ('460429', '1', '17046532', '17046530', '303');
INSERT INTO `interactive_datas` VALUES ('460428', '1', '17046530', '17046528', '289');
INSERT INTO `interactive_datas` VALUES ('472907', '1', '88212757', '99353610', '342');
INSERT INTO `interactive_datas` VALUES ('472910', '1', '88212757', '99354634', '357');
INSERT INTO `interactive_datas` VALUES ('472911', '1', '88212245', '99356672', '383');
INSERT INTO `interactive_datas` VALUES ('474873', '1', '99356672', '99357696', '318');
INSERT INTO `interactive_datas` VALUES ('474874', '1', '99357696', '99356672', '259');
INSERT INTO `interactive_datas` VALUES ('472918', '1', '88212244', '17044483', '437');
INSERT INTO `interactive_datas` VALUES ('460443', '1', '17044483', '17044481', '458');
INSERT INTO `interactive_datas` VALUES ('472917', '1', '88080660', '17047556', '411');
INSERT INTO `interactive_datas` VALUES ('460512', '1', '17047556', '17047552', '353');
INSERT INTO `interactive_datas` VALUES ('460509', '1', '17047554', '17047556', '414');
INSERT INTO `interactive_datas` VALUES ('460513', '1', '17047558', '17047554', '429');
INSERT INTO `interactive_datas` VALUES ('472916', '1', '88081684', '67373056', '256');
INSERT INTO `interactive_datas` VALUES ('458839', '1', '67112960', '67111936', '328');
INSERT INTO `interactive_datas` VALUES ('458833', '1', '67111936', '67110912', '438');
INSERT INTO `interactive_datas` VALUES ('458830', '1', '67110912', '67108864', '332');
INSERT INTO `interactive_datas` VALUES ('463968', '1', '82314240', '67108864', '409');
INSERT INTO `interactive_datas` VALUES ('458827', '1', '67108864', '67109888', '494');
INSERT INTO `interactive_datas` VALUES ('458828', '1', '67109888', '67108864', '338');
INSERT INTO `interactive_datas` VALUES ('458829', '1', '67109888', '67108864', '338');
INSERT INTO `interactive_datas` VALUES ('458832', '1', '67110912', '67111936', '352');
INSERT INTO `interactive_datas` VALUES ('458831', '1', '67110912', '67111936', '352');
INSERT INTO `interactive_datas` VALUES ('458837', '1', '67111936', '67112960', '187');
INSERT INTO `interactive_datas` VALUES ('458836', '1', '67111936', '67112960', '187');
INSERT INTO `interactive_datas` VALUES ('459858', '1', '67373056', '88081684', '205');
INSERT INTO `interactive_datas` VALUES ('483850', '1', '88082195', '121896964', '424');
INSERT INTO `interactive_datas` VALUES ('483851', '3', '121896964', '422', '0');
INSERT INTO `interactive_datas` VALUES ('476191', '1', '88082708', '101974016', '401');
INSERT INTO `interactive_datas` VALUES ('475639', '1', '101974016', '101975040', '304');
INSERT INTO `interactive_datas` VALUES ('475640', '1', '101975040', '101974016', '261');
INSERT INTO `interactive_datas` VALUES ('474869', '1', '88083220', '99094023', '452');
INSERT INTO `interactive_datas` VALUES ('472920', '1', '88084245', '17041411', '410');
INSERT INTO `interactive_datas` VALUES ('460535', '1', '17041411', '17041409', '443');
INSERT INTO `interactive_datas` VALUES ('460536', '1', '17041409', '17041413', '410');
INSERT INTO `interactive_datas` VALUES ('460537', '1', '17041409', '17041415', '401');
INSERT INTO `interactive_datas` VALUES ('472242', '1', '88083734', '17042432', '508');
INSERT INTO `interactive_datas` VALUES ('472244', '1', '88083734', '17042432', '324');
INSERT INTO `interactive_datas` VALUES ('463646', '1', '17042432', '17042436', '332');
INSERT INTO `interactive_datas` VALUES ('460463', '1', '17042436', '17042438', '351');
INSERT INTO `interactive_datas` VALUES ('460466', '1', '17042438', '17042434', '361');
INSERT INTO `interactive_datas` VALUES ('460469', '1', '17042434', '17042440', '386');
INSERT INTO `interactive_datas` VALUES ('460468', '1', '17042434', '17042438', '345');
INSERT INTO `interactive_datas` VALUES ('460465', '1', '17042438', '17042436', '427');
INSERT INTO `interactive_datas` VALUES ('460462', '1', '17042436', '17042432', '303');
INSERT INTO `interactive_datas` VALUES ('472880', '1', '68420616', '95423492', '425');
INSERT INTO `interactive_datas` VALUES ('472867', '1', '95423492', '96470786', '453');
INSERT INTO `interactive_datas` VALUES ('471494', '1', '96470786', '96470528', '481');
INSERT INTO `interactive_datas` VALUES ('471495', '1', '96470528', '96469504', '485');
INSERT INTO `interactive_datas` VALUES ('471496', '1', '96469504', '96469506', '345');
INSERT INTO `interactive_datas` VALUES ('471499', '1', '96471554', '96470530', '459');
INSERT INTO `interactive_datas` VALUES ('471500', '1', '96471554', '96471552', '404');
INSERT INTO `interactive_datas` VALUES ('471502', '1', '96471552', '96470528', '485');
INSERT INTO `interactive_datas` VALUES ('471501', '1', '96471552', '96471554', '374');
INSERT INTO `interactive_datas` VALUES ('471498', '1', '96470530', '96469506', '485');
INSERT INTO `interactive_datas` VALUES ('471497', '1', '96469506', '96469504', '374');
INSERT INTO `interactive_datas` VALUES ('472866', '1', '95423492', '68420616', '271');
INSERT INTO `interactive_datas` VALUES ('472927', '1', '88086290', '17043460', '396');
INSERT INTO `interactive_datas` VALUES ('460527', '1', '17043460', '17043458', '423');
INSERT INTO `interactive_datas` VALUES ('460529', '1', '17043458', '17043462', '409');
INSERT INTO `interactive_datas` VALUES ('460534', '1', '17043462', '17043458', '275');
INSERT INTO `interactive_datas` VALUES ('460532', '1', '17043458', '17043460', '304');
INSERT INTO `interactive_datas` VALUES ('460531', '1', '17043460', '88086290', '400');
INSERT INTO `interactive_datas` VALUES ('472928', '1', '88086290', '17043456', '276');
INSERT INTO `interactive_datas` VALUES ('460533', '1', '17043456', '88086290', '464');
INSERT INTO `interactive_datas` VALUES ('460524', '1', '17043456', '88086290', '428');
INSERT INTO `interactive_datas` VALUES ('472530', '1', '95422464', '91750915', '426');
INSERT INTO `interactive_datas` VALUES ('472554', '1', '91750915', '91750919', '301');
INSERT INTO `interactive_datas` VALUES ('472556', '1', '91750919', '91751943', '300');
INSERT INTO `interactive_datas` VALUES ('472557', '1', '91751943', '91750919', '368');
INSERT INTO `interactive_datas` VALUES ('472555', '1', '91750919', '91750915', '356');
INSERT INTO `interactive_datas` VALUES ('472522', '1', '91751939', '91750915', '428');
INSERT INTO `interactive_datas` VALUES ('472528', '1', '91752963', '91751939', '458');
INSERT INTO `interactive_datas` VALUES ('472529', '1', '91753987', '91752963', '458');
INSERT INTO `interactive_datas` VALUES ('483927', '1', '91753987', '91753991', '287');
INSERT INTO `interactive_datas` VALUES ('483928', '1', '91753991', '91753987', '343');
INSERT INTO `interactive_datas` VALUES ('472527', '1', '90708227', '91753987', '426');
INSERT INTO `interactive_datas` VALUES ('472649', '1', '90708226', '91752965', '414');
INSERT INTO `interactive_datas` VALUES ('508199', '1', '90708481', '170133510', '491');
INSERT INTO `interactive_datas` VALUES ('508130', '1', '170133510', '170133506', '261');
INSERT INTO `interactive_datas` VALUES ('508211', '1', '170133506', '170133504', '233');
INSERT INTO `interactive_datas` VALUES ('508224', '1', '170133504', '170132488', '470');
INSERT INTO `interactive_datas` VALUES ('508132', '1', '170133504', '169083904', '227');
INSERT INTO `interactive_datas` VALUES ('508406', '3', '168559616', '498', '0');
INSERT INTO `interactive_datas` VALUES ('508133', '1', '169083904', '170133504', '467');
INSERT INTO `interactive_datas` VALUES ('509179', '2', '170133504', '473', '0');
INSERT INTO `interactive_datas` VALUES ('508210', '1', '170133504', '170133506', '329');
INSERT INTO `interactive_datas` VALUES ('508131', '1', '170133506', '170133510', '225');
INSERT INTO `interactive_datas` VALUES ('508115', '1', '170133510', '170133512', '437');
INSERT INTO `interactive_datas` VALUES ('472523', '1', '90703872', '91753985', '481');
INSERT INTO `interactive_datas` VALUES ('488049', '1', '95420418', '148637187', '499');
INSERT INTO `interactive_datas` VALUES ('488050', '1', '148637187', '95420418', '160');
INSERT INTO `interactive_datas` VALUES ('481522', '1', '95421442', '115081729', '274');
INSERT INTO `interactive_datas` VALUES ('481519', '1', '115083777', '115081731', '499');
INSERT INTO `interactive_datas` VALUES ('472894', '1', '88213272', '99096069', '342');
INSERT INTO `interactive_datas` VALUES ('502572', '1', '88214297', '163053568', '122');
INSERT INTO `interactive_datas` VALUES ('502524', '1', '163054592', '163055618', '516');
INSERT INTO `interactive_datas` VALUES ('502526', '1', '163055361', '163053570', '506');
INSERT INTO `interactive_datas` VALUES ('502525', '1', '163054849', '163054594', '489');
INSERT INTO `interactive_datas` VALUES ('502573', '1', '163053568', '88214297', '301');
INSERT INTO `interactive_datas` VALUES ('472733', '1', '88080668', '17039360', '369');
INSERT INTO `interactive_datas` VALUES ('374108', '1', '17039360', '17039361', '229');
INSERT INTO `interactive_datas` VALUES ('374109', '1', '17039361', '17039362', '247');
INSERT INTO `interactive_datas` VALUES ('460386', '1', '17039362', '17039361', '291');
INSERT INTO `interactive_datas` VALUES ('373930', '1', '17039361', '17039360', '259');
INSERT INTO `interactive_datas` VALUES ('373808', '1', '17039360', '88080668', '333');
INSERT INTO `interactive_datas` VALUES ('472734', '1', '88080668', '17039360', '303');
INSERT INTO `interactive_datas` VALUES ('446250', '1', '262', '4461568', '321');
INSERT INTO `interactive_datas` VALUES ('459814', '1', '70778880', '69206274', '332');
INSERT INTO `interactive_datas` VALUES ('458993', '1', '69206274', '69207298', '352');
INSERT INTO `interactive_datas` VALUES ('459006', '1', '69207298', '69208322', '379');
INSERT INTO `interactive_datas` VALUES ('459007', '1', '69208322', '69209346', '374');
INSERT INTO `interactive_datas` VALUES ('459003', '1', '69209346', '69208064', '483');
INSERT INTO `interactive_datas` VALUES ('459004', '1', '69208064', '69207040', '298');
INSERT INTO `interactive_datas` VALUES ('459002', '1', '69207040', '69208064', '303');
INSERT INTO `interactive_datas` VALUES ('459008', '1', '69209346', '69208322', '227');
INSERT INTO `interactive_datas` VALUES ('458996', '1', '69208322', '69207298', '227');
INSERT INTO `interactive_datas` VALUES ('459001', '1', '69207298', '69209088', '298');
INSERT INTO `interactive_datas` VALUES ('459005', '1', '69209088', '69207298', '215');
INSERT INTO `interactive_datas` VALUES ('459009', '1', '69207298', '69206274', '135');
INSERT INTO `interactive_datas` VALUES ('458999', '1', '69206274', '69206016', '303');
INSERT INTO `interactive_datas` VALUES ('459000', '1', '69206016', '69206274', '242');
INSERT INTO `interactive_datas` VALUES ('459818', '1', '69206274', '70778880', '158');
INSERT INTO `interactive_datas` VALUES ('458843', '1', '67371008', '67372032', '241');
INSERT INTO `interactive_datas` VALUES ('458840', '1', '67372032', '67371008', '329');
INSERT INTO `interactive_datas` VALUES ('475660', '1', '84805890', '101450251', '452');
INSERT INTO `interactive_datas` VALUES ('476222', '1', '101450251', '101453321', '453');
INSERT INTO `interactive_datas` VALUES ('476216', '1', '101453321', '101452295', '438');
INSERT INTO `interactive_datas` VALUES ('476217', '1', '101453321', '101453319', '438');
INSERT INTO `interactive_datas` VALUES ('476218', '1', '101453321', '101450247', '438');
INSERT INTO `interactive_datas` VALUES ('476219', '1', '101453321', '101451265', '438');
INSERT INTO `interactive_datas` VALUES ('506013', '1', '165152262', '81788928', '479');
INSERT INTO `interactive_datas` VALUES ('463607', '1', '81788928', '81788930', '429');
INSERT INTO `interactive_datas` VALUES ('463606', '1', '81788928', '81789952', '437');
INSERT INTO `interactive_datas` VALUES ('503186', '1', '164496396', '130024961', '517');
INSERT INTO `interactive_datas` VALUES ('489318', '3', '153092354', '6', '0');
INSERT INTO `interactive_datas` VALUES ('472925', '1', '88082705', '99352580', '410');
INSERT INTO `interactive_datas` VALUES ('474877', '1', '99352580', '99353604', '273');
INSERT INTO `interactive_datas` VALUES ('474878', '1', '99353604', '99352580', '245');
INSERT INTO `interactive_datas` VALUES ('474879', '1', '99352580', '96338944', '259');
INSERT INTO `interactive_datas` VALUES ('473822', '1', '96338944', '99352580', '231');
INSERT INTO `interactive_datas` VALUES ('484182', '1', '88082698', '121767936', '285');
INSERT INTO `interactive_datas` VALUES ('484177', '1', '121767936', '121766912', '298');
INSERT INTO `interactive_datas` VALUES ('484173', '1', '121766912', '121634816', '212');
INSERT INTO `interactive_datas` VALUES ('443364', '1', '264', '106168320', '471');
INSERT INTO `interactive_datas` VALUES ('480308', '1', '106168320', '106169344', '457');
INSERT INTO `interactive_datas` VALUES ('484175', '1', '121634816', '121766912', '317');
INSERT INTO `interactive_datas` VALUES ('484178', '1', '121766912', '121767936', '430');
INSERT INTO `interactive_datas` VALUES ('484181', '1', '121767936', '88082698', '349');
INSERT INTO `interactive_datas` VALUES ('472924', '1', '88082191', '99352582', '415');
INSERT INTO `interactive_datas` VALUES ('481523', '1', '115081729', '95421442', '370');
INSERT INTO `interactive_datas` VALUES ('472526', '1', '90706432', '91750913', '385');
INSERT INTO `interactive_datas` VALUES ('472590', '1', '95420416', '91753989', '482');
INSERT INTO `interactive_datas` VALUES ('508395', '3', '168559620', '497', '0');
INSERT INTO `interactive_datas` VALUES ('454041', '1', '140316', '17826562', '172');
INSERT INTO `interactive_datas` VALUES ('435739', '1', '143896', '29884416', '198');
INSERT INTO `interactive_datas` VALUES ('446885', '1', '29884425', '142872', '143');
INSERT INTO `interactive_datas` VALUES ('435750', '1', '142872', '29884425', '150');
INSERT INTO `interactive_datas` VALUES ('473023', '1', '88213777', '41944064', '401');
INSERT INTO `interactive_datas` VALUES ('473006', '1', '88213774', '97259013', '402');
INSERT INTO `interactive_datas` VALUES ('472929', '1', '88212750', '17040384', '383');
INSERT INTO `interactive_datas` VALUES ('460549', '1', '17040384', '17040386', '395');
INSERT INTO `interactive_datas` VALUES ('460550', '1', '17040386', '17040388', '261');
INSERT INTO `interactive_datas` VALUES ('460551', '1', '17040388', '17040386', '373');
INSERT INTO `interactive_datas` VALUES ('460552', '1', '17040388', '17040390', '380');
INSERT INTO `interactive_datas` VALUES ('460553', '1', '17040390', '17040388', '351');
INSERT INTO `interactive_datas` VALUES ('474898', '1', '88087298', '99354638', '410');
INSERT INTO `interactive_datas` VALUES ('473824', '1', '88085250', '97256989', '480');
INSERT INTO `interactive_datas` VALUES ('473016', '1', '88087301', '38535168', '519');
INSERT INTO `interactive_datas` VALUES ('483041', '1', '88087305', '117440512', '365');
INSERT INTO `interactive_datas` VALUES ('483028', '1', '117440512', '117441536', '462');
INSERT INTO `interactive_datas` VALUES ('483030', '1', '117441536', '117442560', '449');
INSERT INTO `interactive_datas` VALUES ('483032', '1', '117442560', '117443584', '267');
INSERT INTO `interactive_datas` VALUES ('483034', '1', '117443584', '117440514', '421');
INSERT INTO `interactive_datas` VALUES ('483036', '1', '117440514', '117441538', '421');
INSERT INTO `interactive_datas` VALUES ('483038', '1', '117441538', '117442562', '423');
INSERT INTO `interactive_datas` VALUES ('483015', '1', '117442562', '117443586', '311');
INSERT INTO `interactive_datas` VALUES ('483013', '1', '117443586', '117444610', '509');
INSERT INTO `interactive_datas` VALUES ('482990', '1', '117444610', '118096384', '229');
INSERT INTO `interactive_datas` VALUES ('466330', '1', '88212480', '99355648', '414');
INSERT INTO `interactive_datas` VALUES ('466328', '1', '88080384', '99354628', '401');
INSERT INTO `interactive_datas` VALUES ('466852', '1', '88081408', '99354624', '410');
INSERT INTO `interactive_datas` VALUES ('466286', '1', '88080898', '99355652', '410');
INSERT INTO `interactive_datas` VALUES ('466333', '1', '88080902', '99356674', '383');
INSERT INTO `interactive_datas` VALUES ('466335', '1', '88081414', '99355658', '357');
INSERT INTO `interactive_datas` VALUES ('466334', '1', '88081414', '99352588', '354');
INSERT INTO `interactive_datas` VALUES ('472937', '1', '88081927', '99354630', '415');
INSERT INTO `interactive_datas` VALUES ('472936', '1', '88082438', '99352578', '317');
INSERT INTO `interactive_datas` VALUES ('460389', '1', '72619522', '30672658', '463');
INSERT INTO `interactive_datas` VALUES ('464084', '1', '72619011', '100925955', '354');
INSERT INTO `interactive_datas` VALUES ('464050', '1', '72619010', '100926977', '400');
INSERT INTO `interactive_datas` VALUES ('474900', '1', '100926977', '100928001', '313');
INSERT INTO `interactive_datas` VALUES ('474901', '1', '100928001', '100926977', '272');
INSERT INTO `interactive_datas` VALUES ('460437', '1', '72618499', '72222720', '451');
INSERT INTO `interactive_datas` VALUES ('460379', '1', '72222720', '72221696', '446');
INSERT INTO `interactive_datas` VALUES ('460444', '1', '72618499', '30671116', '439');
INSERT INTO `interactive_datas` VALUES ('472933', '1', '88080647', '99352584', '400');
INSERT INTO `interactive_datas` VALUES ('459993', '1', '68551681', '95685125', '437');
INSERT INTO `interactive_datas` VALUES ('488216', '1', '95686149', '95687173', '424');
INSERT INTO `interactive_datas` VALUES ('483317', '1', '95686149', '101713427', '256');
INSERT INTO `interactive_datas` VALUES ('476434', '1', '101713429', '3333', '230');
INSERT INTO `interactive_datas` VALUES ('438037', '1', '3333', '101713429', '381');
INSERT INTO `interactive_datas` VALUES ('476183', '1', '101713429', '101714453', '314');
INSERT INTO `interactive_datas` VALUES ('476184', '1', '101714453', '101713429', '332');
INSERT INTO `interactive_datas` VALUES ('446270', '1', '264', '4460546', '313');
INSERT INTO `interactive_datas` VALUES ('446271', '1', '4460546', '264', '339');
INSERT INTO `interactive_datas` VALUES ('446235', '1', '132359', '4456450', '403');
INSERT INTO `interactive_datas` VALUES ('446234', '1', '132359', '4456450', '380');
INSERT INTO `interactive_datas` VALUES ('446236', '1', '132870', '4459522', '437');
INSERT INTO `interactive_datas` VALUES ('446268', '1', '132357', '97255951', '347');
INSERT INTO `interactive_datas` VALUES ('473017', '1', '88213787', '97255951', '424');
INSERT INTO `interactive_datas` VALUES ('472864', '1', '96993793', '97259025', '303');
INSERT INTO `interactive_datas` VALUES ('472897', '1', '88081176', '99093001', '227');
INSERT INTO `interactive_datas` VALUES ('474852', '1', '99094025', '99095049', '289');
INSERT INTO `interactive_datas` VALUES ('474904', '1', '99095049', '99096073', '315');
INSERT INTO `interactive_datas` VALUES ('472914', '1', '88081173', '99356680', '412');
INSERT INTO `interactive_datas` VALUES ('474888', '1', '99356680', '99357704', '373');
INSERT INTO `interactive_datas` VALUES ('474889', '1', '99357704', '99356680', '298');
INSERT INTO `interactive_datas` VALUES ('472905', '1', '88081686', '17045504', '383');
INSERT INTO `interactive_datas` VALUES ('461692', '1', '17045504', '17045506', '397');
INSERT INTO `interactive_datas` VALUES ('461696', '1', '17045506', '17045508', '452');
INSERT INTO `interactive_datas` VALUES ('461694', '1', '17045508', '17045510', '396');
INSERT INTO `interactive_datas` VALUES ('472904', '1', '88082198', '99091969', '338');
INSERT INTO `interactive_datas` VALUES ('474825', '1', '99091969', '99092993', '227');
INSERT INTO `interactive_datas` VALUES ('474824', '1', '99091969', '99092993', '213');
INSERT INTO `interactive_datas` VALUES ('474823', '1', '99091969', '99094017', '414');
INSERT INTO `interactive_datas` VALUES ('474831', '1', '99094017', '99091969', '432');
INSERT INTO `interactive_datas` VALUES ('472902', '1', '88081687', '99353600', '410');
INSERT INTO `interactive_datas` VALUES ('472903', '1', '88082710', '99356682', '312');
INSERT INTO `interactive_datas` VALUES ('474891', '1', '99356682', '99357708', '356');
INSERT INTO `interactive_datas` VALUES ('474894', '1', '99357708', '99357706', '289');
INSERT INTO `interactive_datas` VALUES ('474895', '1', '99357706', '99357708', '329');
INSERT INTO `interactive_datas` VALUES ('472919', '1', '88083223', '99352586', '342');
INSERT INTO `interactive_datas` VALUES ('460467', '1', '17042434', '17042438', '345');
INSERT INTO `interactive_datas` VALUES ('460464', '1', '17042438', '17042436', '427');
INSERT INTO `interactive_datas` VALUES ('460461', '1', '17042436', '17042432', '303');
INSERT INTO `interactive_datas` VALUES ('474863', '1', '99093005', '99094029', '316');
INSERT INTO `interactive_datas` VALUES ('474864', '1', '99094029', '99093005', '359');
INSERT INTO `interactive_datas` VALUES ('460502', '1', '17049606', '17049604', '429');
INSERT INTO `interactive_datas` VALUES ('460387', '1', '17039362', '17039363', '242');
INSERT INTO `interactive_datas` VALUES ('460388', '1', '17039363', '17039362', '284');
INSERT INTO `interactive_datas` VALUES ('472731', '1', '88212763', '4456448', '429');
INSERT INTO `interactive_datas` VALUES ('489372', '1', '84674051', '154010883', '370');
INSERT INTO `interactive_datas` VALUES ('489377', '1', '84804104', '154010883', '370');
INSERT INTO `interactive_datas` VALUES ('489373', '1', '84804101', '154010883', '370');
INSERT INTO `interactive_datas` VALUES ('489348', '1', '84672515', '154010883', '370');
INSERT INTO `interactive_datas` VALUES ('489321', '1', '84673025', '154010883', '370');
INSERT INTO `interactive_datas` VALUES ('489322', '1', '84674048', '154010883', '370');
INSERT INTO `interactive_datas` VALUES ('489379', '1', '84673538', '154010883', '370');
INSERT INTO `interactive_datas` VALUES ('488060', '1', '84675073', '154010883', '370');
INSERT INTO `interactive_datas` VALUES ('489323', '1', '84676097', '154010883', '370');
INSERT INTO `interactive_datas` VALUES ('489336', '1', '84675586', '154010883', '370');
INSERT INTO `interactive_datas` VALUES ('489342', '1', '84675075', '154010883', '370');
INSERT INTO `interactive_datas` VALUES ('489344', '1', '84675590', '154010883', '370');
INSERT INTO `interactive_datas` VALUES ('489346', '1', '84676103', '154010883', '370');
INSERT INTO `interactive_datas` VALUES ('502530', '1', '84676102', '154010883', '370');
INSERT INTO `interactive_datas` VALUES ('489343', '1', '84676101', '154010883', '370');
INSERT INTO `interactive_datas` VALUES ('489378', '1', '84674054', '154010883', '370');
INSERT INTO `interactive_datas` VALUES ('481521', '6', '115081731', '0', '0');

-- ----------------------------
-- Table structure for items_sets
-- ----------------------------
DROP TABLE IF EXISTS `items_sets`;
CREATE TABLE `items_sets` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`Id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of items_sets
-- ----------------------------

-- ----------------------------
-- Table structure for item_average
-- ----------------------------
DROP TABLE IF EXISTS `item_average`;
CREATE TABLE `item_average` (
  `Id` int(11) NOT NULL,
  `BasePrice` int(11) NOT NULL,
  `Count` int(11) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of item_average
-- ----------------------------

-- ----------------------------
-- Table structure for maps_alternative
-- ----------------------------
DROP TABLE IF EXISTS `maps_alternative`;
CREATE TABLE `maps_alternative` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Enter` int(11) NOT NULL,
  `Direction` tinyint(4) NOT NULL,
  `Exit` int(11) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=MyISAM AUTO_INCREMENT=19 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of maps_alternative
-- ----------------------------

-- ----------------------------
-- Table structure for monster_dungeons
-- ----------------------------
DROP TABLE IF EXISTS `monster_dungeons`;
CREATE TABLE `monster_dungeons` (
  `MapID` int(11) NOT NULL,
  `MonstersCSV` mediumtext NOT NULL,
  PRIMARY KEY (`MapID`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of monster_dungeons
-- ----------------------------

-- ----------------------------
-- Table structure for monster_items
-- ----------------------------
DROP TABLE IF EXISTS `monster_items`;
CREATE TABLE `monster_items` (
  `Id` int(11) NOT NULL,
  `SubAreaId` int(11) NOT NULL,
  `TemplateID` int(11) NOT NULL,
  `Quantity` int(11) NOT NULL,
  `EffectsCompress` longblob,
  PRIMARY KEY (`Id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of monster_items
-- ----------------------------

-- ----------------------------
-- Table structure for mounts_effect
-- ----------------------------
DROP TABLE IF EXISTS `mounts_effect`;
CREATE TABLE `mounts_effect` (
  `Id` int(11) NOT NULL,
  `MountId` int(11) NOT NULL AUTO_INCREMENT,
  `FormatedEffects` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`MountId`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of mounts_effect
-- ----------------------------

-- ----------------------------
-- Table structure for npcs_actions
-- ----------------------------
DROP TABLE IF EXISTS `npcs_actions`;
CREATE TABLE `npcs_actions` (
  `Id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `NpcId` int(11) NOT NULL,
  `Type` mediumtext NOT NULL,
  `Condition` mediumtext,
  `Parameter0` mediumtext,
  `Parameter1` mediumtext,
  `Parameter2` mediumtext,
  `Parameter3` mediumtext,
  `Parameter4` mediumtext,
  `AdditionalParameters` mediumtext,
  PRIMARY KEY (`Id`)
) ENGINE=MyISAM AUTO_INCREMENT=56 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of npcs_actions
-- ----------------------------

-- ----------------------------
-- Table structure for npcs_items
-- ----------------------------
DROP TABLE IF EXISTS `npcs_items`;
CREATE TABLE `npcs_items` (
  `NpcShopId` int(11) NOT NULL,
  `CustomPrice` float(10,2) DEFAULT NULL,
  `BuyCriterion` mediumtext,
  `MaxStats` tinyint(4) NOT NULL,
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `ItemId` int(11) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=MyISAM AUTO_INCREMENT=758 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of npcs_items
-- ----------------------------

-- ----------------------------
-- Table structure for npcs_replies
-- ----------------------------
DROP TABLE IF EXISTS `npcs_replies`;
CREATE TABLE `npcs_replies` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Type` mediumtext NOT NULL,
  `ReplyId` int(11) NOT NULL,
  `MessageId` int(11) NOT NULL,
  `Criteria` mediumtext,
  `Parameter0` mediumtext,
  `Parameter1` mediumtext,
  `Parameter2` mediumtext,
  `Parameter3` mediumtext,
  `Parameter4` mediumtext,
  `AdditionalParameters` mediumtext,
  PRIMARY KEY (`Id`)
) ENGINE=MyISAM AUTO_INCREMENT=9 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of npcs_replies
-- ----------------------------

-- ----------------------------
-- Table structure for npcs_spawns
-- ----------------------------
DROP TABLE IF EXISTS `npcs_spawns`;
CREATE TABLE `npcs_spawns` (
  `Id` int(11) NOT NULL,
  `NpcId` int(11) NOT NULL,
  `MapId` int(11) NOT NULL,
  `CellId` int(11) NOT NULL,
  `Direction` int(11) NOT NULL,
  `LookAsString` mediumtext NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of npcs_spawns
-- ----------------------------

-- ----------------------------
-- Table structure for pets
-- ----------------------------
DROP TABLE IF EXISTS `pets`;
CREATE TABLE `pets` (
  `Id` int(11) NOT NULL,
  `Max` int(11) NOT NULL,
  `ItemString` mediumtext NOT NULL,
  `MonsterString` mediumtext NOT NULL,
  `TypeString` mediumtext NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of pets
-- ----------------------------

-- ----------------------------
-- Table structure for pets_copy
-- ----------------------------
DROP TABLE IF EXISTS `pets_copy`;
CREATE TABLE `pets_copy` (
  `Id` int(11) NOT NULL,
  `Max` int(11) NOT NULL,
  `ItemString` mediumtext NOT NULL,
  `MonsterString` mediumtext NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of pets_copy
-- ----------------------------

-- ----------------------------
-- Table structure for player_vendor
-- ----------------------------
DROP TABLE IF EXISTS `player_vendor`;
CREATE TABLE `player_vendor` (
  `Id` int(11) NOT NULL,
  `OwnerId` int(11) NOT NULL,
  `Items` longblob,
  PRIMARY KEY (`Id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of player_vendor
-- ----------------------------

-- ----------------------------
-- Table structure for prismes
-- ----------------------------
DROP TABLE IF EXISTS `prismes`;
CREATE TABLE `prismes` (
  `Id` int(10) unsigned NOT NULL,
  `AllianceId` int(10) unsigned NOT NULL,
  `MapId` int(11) NOT NULL,
  `CellId` int(11) NOT NULL,
  `CreatedDate` int(11) NOT NULL,
  `Saboted` tinyint(4) NOT NULL,
  `KillDate` int(11) NOT NULL,
  `LastTimeSlotModified` int(11) NOT NULL,
  `LastTimeSlotGuild` int(11) NOT NULL,
  `LastTimeSlotAuthorId` int(11) NOT NULL,
  `LastTimeSlotAuthorName` mediumtext NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of prismes
-- ----------------------------

-- ----------------------------
-- Table structure for triggermapfightrecords
-- ----------------------------
DROP TABLE IF EXISTS `triggermapfightrecords`;
CREATE TABLE `triggermapfightrecords` (
  `MapId` int(11) NOT NULL,
  `MapTo` int(11) NOT NULL,
  `CellID` int(11) NOT NULL,
  PRIMARY KEY (`MapId`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of triggermapfightrecords
-- ----------------------------

-- ----------------------------
-- Table structure for world_maps_triggers
-- ----------------------------
DROP TABLE IF EXISTS `world_maps_triggers`;
CREATE TABLE `world_maps_triggers` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Type` mediumtext NOT NULL,
  `CellId` smallint(6) NOT NULL,
  `MapId` int(11) NOT NULL,
  `TriggerType` int(11) NOT NULL,
  `Condition` mediumtext,
  `Parameter0` mediumtext,
  `Parameter1` mediumtext,
  `Parameter2` mediumtext,
  `Parameter3` mediumtext,
  `Parameter4` mediumtext,
  `AdditionalParameters` mediumtext,
  PRIMARY KEY (`Id`)
) ENGINE=MyISAM AUTO_INCREMENT=883 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of world_maps_triggers
-- ----------------------------
INSERT INTO `world_maps_triggers` VALUES ('2', 'Teleport', '427', '81527297', '0', null, '332', '80218116', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('3', 'Teleport', '341', '81529347', '0', null, '299', '80216578', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('4', 'Teleport', '316', '81528325', '0', null, '315', '80216066', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('5', 'Teleport', '316', '81527301', '0', null, '355', '80216066', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('6', 'Teleport', '344', '81529349', '0', null, '284', '80216064', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('7', 'Teleport', '424', '81527299', '0', null, '328', '80218626', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('8', 'Teleport', '438', '81527299', '0', null, '328', '80218626', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('9', 'Teleport', '311', '81528323', '0', null, '340', '81527299', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('10', 'Teleport', '395', '83628034', '0', null, '385', '84672519', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('11', 'Teleport', '401', '83890182', '0', null, '211', '84673543', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('12', 'Teleport', '352', '83364864', '0', null, '397', '84674055', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('13', 'Teleport', '361', '103547392', '0', null, '242', '84675590', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('14', 'Teleport', '397', '83625986', '0', null, '384', '84675078', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('15', 'Teleport', '382', '83625986', '0', null, '384', '84675078', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('16', 'Teleport', '396', '83887104', '0', null, '317', '84674566', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('17', 'Teleport', '410', '83629056', '0', null, '269', '84673542', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('18', 'Teleport', '402', '83891204', '0', null, '412', '84673030', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('19', 'Teleport', '410', '83629058', '0', null, '383', '84673541', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('20', 'Teleport', '429', '83892232', '0', null, '282', '84674053', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('21', 'Teleport', '366', '83890176', '0', null, '368', '84675077', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('22', 'Teleport', '443', '83890176', '0', null, '346', '84675077', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('23', 'Teleport', '352', '83362816', '0', null, '397', '84675589', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('24', 'Teleport', '352', '83363842', '0', null, '410', '84674564', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('25', 'Teleport', '352', '83362818', '0', null, '354', '84675076', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('26', 'Teleport', '352', '83365888', '0', null, '369', '84675588', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('27', 'Teleport', '522', '101716483', '0', null, '304', '84675587', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('28', 'Teleport', '401', '83888130', '0', null, '268', '84674563', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('29', 'Teleport', '437', '83887110', '0', null, '370', '84673539', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('30', 'Teleport', '352', '83363840', '0', null, '382', '84672514', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('31', 'Teleport', '367', '83889152', '0', null, '357', '84673026', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('32', 'Teleport', '352', '83365890', '0', null, '399', '84674050', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('33', 'Teleport', '396', '83628032', '0', null, '425', '84675074', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('34', 'Teleport', '369', '83624960', '0', null, '244', '84676098', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('35', 'Teleport', '355', '83624962', '0', null, '299', '84675585', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('36', 'Teleport', '370', '83624962', '0', null, '299', '84675585', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('37', 'Teleport', '326', '83623936', '0', null, '382', '84673537', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('38', 'Teleport', '325', '83627008', '0', null, '328', '84672513', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('39', 'Teleport', '471', '83887106', '0', null, '299', '84804097', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('40', 'Teleport', '458', '83887106', '0', null, '299', '84804097', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('41', 'Teleport', '352', '83361792', '0', null, '343', '84672512', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('42', 'Teleport', '424', '83625984', '0', null, '454', '84673024', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('43', 'Teleport', '465', '67371008', '0', null, '413', '84673536', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('44', 'Teleport', '451', '67371008', '0', null, '413', '84673536', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('45', 'Teleport', '424', '83623938', '0', null, '289', '84676355', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('117', 'Teleport', '350', '17042432', '0', null, '381', '88083734', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('46', 'Teleport', '536', '102236681', '0', null, '219', '84676358', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('47', 'Teleport', '171', '101716483', '0', null, '487', '101715459', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('48', 'Teleport', '501', '101715459', '0', null, '185', '101716483', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('49', 'Teleport', '462', '101715461', '0', null, '134', '101715463', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('50', 'Teleport', '477', '101715461', '0', null, '134', '101715463', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('51', 'Teleport', '121', '101715463', '0', null, '449', '101715461', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('52', 'Teleport', '135', '101715463', '0', null, '449', '101715461', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('53', 'Teleport', '458', '7077888', '0', null, '228', '264', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('54', 'Teleport', '269', '7077888', '0', null, '414', '7078912', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('55', 'Teleport', '429', '7078912', '0', null, '284', '7077888', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('56', 'Teleport', '417', '4456450', '0', null, '208', '132359', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('57', 'Teleport', '394', '4456450', '0', null, '314', '132359', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('58', 'Teleport', '511', '69208064', '0', null, '301', '69209346', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('59', 'Teleport', '382', '17039360', '0', null, '342', '88080668', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('60', 'Teleport', '397', '17039360', '0', null, '342', '88080668', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('61', 'Teleport', '335', '4461568', '0', null, '315', '262', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('62', 'Teleport', '349', '4461568', '0', null, '315', '262', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('63', 'Teleport', '363', '4461568', '0', null, '315', '262', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('64', 'Teleport', '456', '17048576', '0', null, '443', '88212763', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('65', 'Teleport', '469', '17048576', '0', null, '443', '88212763', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('66', 'Teleport', '423', '17048580', '0', null, '275', '17048578', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('67', 'Teleport', '437', '17048580', '0', null, '275', '17048578', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('68', 'Teleport', '469', '17048578', '0', null, '331', '17048582', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('69', 'Teleport', '456', '17048578', '0', null, '331', '17048582', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('70', 'Teleport', '385', '17048584', '0', null, '297', '17048582', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('71', 'Teleport', '369', '99353612', '0', null, '227', '88213274', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('72', 'Teleport', '478', '97255955', '0', null, '262', '88212250', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('73', 'Teleport', '492', '97255955', '0', null, '262', '88212250', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('74', 'Teleport', '512', '97255955', '0', null, '312', '97256979', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('75', 'Teleport', '297', '97256979', '0', null, '497', '97255955', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('76', 'Teleport', '443', '99352590', '0', null, '412', '88212250', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('77', 'Teleport', '386', '78905344', '0', null, '146', '78905350', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('78', 'Teleport', '395', '78905348', '0', null, '289', '78905344', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('79', 'Teleport', '333', '78905346', '0', null, '284', '78905344', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('80', 'Teleport', '384', '99092997', '0', null, '414', '88080665', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('81', 'Teleport', '314', '99094021', '0', null, '317', '99092997', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('82', 'Teleport', '328', '99094021', '0', null, '317', '99092997', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('83', 'Teleport', '410', '99095051', '0', null, '230', '88081177', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('84', 'Teleport', '344', '99090953', '0', null, '254', '99094025', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('85', 'Teleport', '355', '99090953', '0', null, '287', '88081176', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('86', 'Teleport', '429', '99091977', '0', null, '299', '99090953', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('87', 'Teleport', '471', '99090957', '0', null, '343', '88212247', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('88', 'Teleport', '458', '99090957', '0', null, '343', '88212247', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('89', 'Teleport', '355', '99096069', '0', null, '315', '88213272', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('90', 'Teleport', '442', '17046528', '0', null, '399', '88214295', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('91', 'Teleport', '388', '17046528', '0', null, '331', '88214295', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('92', 'Teleport', '473', '17046534', '0', null, '298', '17046532', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('93', 'Teleport', '355', '99090955', '0', null, '414', '88081174', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('94', 'Teleport', '370', '99090955', '0', null, '414', '88081174', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('95', 'Teleport', '397', '17045504', '0', null, '387', '88081686', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('96', 'Teleport', '411', '17045504', '0', null, '387', '88081686', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('97', 'Teleport', '410', '17045506', '0', null, '359', '17045504', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('98', 'Teleport', '465', '17045508', '0', null, '289', '17045506', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('99', 'Teleport', '395', '17045510', '0', null, '275', '17045508', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('100', 'Teleport', '409', '17045510', '0', null, '275', '17045508', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('101', 'Teleport', '424', '99353600', '0', null, '357', '88081687', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('102', 'Teleport', '351', '99091969', '0', null, '357', '88082198', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('123', 'Teleport', '370', '99352586', '0', null, '300', '88083223', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('122', 'Teleport', '355', '99352586', '0', null, '300', '88083223', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('105', 'Teleport', '312', '99356682', '0', null, '328', '88082710', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('106', 'Teleport', '342', '99357708', '0', null, '345', '99356682', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('107', 'Teleport', '548', '17042432', '0', null, '440', '88083734', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('108', 'Teleport', '535', '17042432', '0', null, '440', '88083734', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('109', 'Teleport', '549', '17042432', '0', null, '440', '88083734', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('110', 'Teleport', '536', '17042432', '0', null, '440', '88083734', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('111', 'Teleport', '550', '17042432', '0', null, '440', '88083734', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('112', 'Teleport', '280', '17042432', '0', null, '381', '88083734', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('113', 'Teleport', '294', '17042432', '0', null, '381', '88083734', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('114', 'Teleport', '308', '17042432', '0', null, '381', '88083734', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('115', 'Teleport', '322', '17042432', '0', null, '381', '88083734', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('116', 'Teleport', '336', '17042432', '0', null, '381', '88083734', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('1', 'Teleport', '358', '81529345', '0', null, '345', '80218116', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('118', 'Teleport', '364', '17042432', '0', null, '381', '88083734', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('119', 'Teleport', '378', '17042432', '0', null, '381', '88083734', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('120', 'Teleport', '392', '17042432', '0', null, '381', '88083734', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('121', 'Teleport', '401', '17042440', '0', null, '352', '17042434', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('124', 'Teleport', '424', '17041411', '0', null, '274', '88084245', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('125', 'Teleport', '458', '17041409', '0', null, '257', '17041411', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('126', 'Teleport', '424', '17041413', '0', null, '290', '17041409', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('127', 'Teleport', '415', '17041415', '0', null, '229', '17041409', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('128', 'Teleport', '452', '96470786', '0', null, '344', '95423492', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('129', 'Teleport', '466', '96470786', '0', null, '344', '95423492', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('130', 'Teleport', '494', '96470528', '0', null, '426', '96470786', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('131', 'Teleport', '499', '96470528', '0', null, '325', '96471552', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('132', 'Teleport', '473', '96470530', '0', null, '354', '96471554', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('133', 'Teleport', '487', '96470530', '0', null, '354', '96471554', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('134', 'Teleport', '499', '96469506', '0', null, '212', '96470530', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('135', 'Teleport', '499', '96469504', '0', null, '354', '96470528', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('136', 'Teleport', '372', '87821827', '0', null, '314', '68420615', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('137', 'Teleport', '386', '78909440', '0', null, '146', '78909446', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('138', 'Teleport', '409', '78909444', '0', null, '289', '78909440', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('139', 'Teleport', '333', '78909442', '0', null, '284', '78909440', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('140', 'Teleport', '414', '87820801', '0', null, '373', '68420099', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('141', 'Teleport', '436', '95685125', '0', null, '370', '68551681', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('142', 'Teleport', '451', '95685125', '0', null, '370', '68551681', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('143', 'Teleport', '465', '95685125', '0', null, '370', '68551681', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('144', 'Teleport', '443', '95685125', '0', null, '241', '95686149', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('145', 'Teleport', '487', '95683073', '0', null, '386', '68552193', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('146', 'Teleport', '473', '95683073', '0', null, '386', '68552193', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('147', 'Teleport', '458', '95684097', '0', null, '240', '95683073', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('148', 'Teleport', '444', '95684097', '0', null, '240', '95683073', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('149', 'Teleport', '516', '95686145', '0', null, '256', '95684097', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('150', 'Teleport', '502', '95686145', '0', null, '256', '95684097', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('151', 'Teleport', '528', '95683075', '0', null, '227', '95686145', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('152', 'Teleport', '515', '95683075', '0', null, '227', '95686145', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('153', 'Teleport', '410', '87819777', '0', null, '275', '68420611', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('154', 'Teleport', '465', '99094023', '0', null, '426', '88083220', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('155', 'Teleport', '429', '101974016', '0', null, '384', '88082708', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('156', 'Teleport', '415', '101974016', '0', null, '384', '88082708', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('242', 'Teleport', '485', '8912911', '0', null, '296', '8913935', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('159', 'Teleport', '386', '78905344', '0', null, '146', '78905350', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('160', 'Teleport', '395', '78905348', '0', null, '289', '78905344', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('161', 'Teleport', '333', '78905346', '0', null, '284', '78905344', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('162', 'Teleport', '451', '101450251', '0', null, '329', '84805890', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('163', 'Teleport', '465', '101450251', '0', null, '329', '84805890', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('164', 'Teleport', '466', '101453321', '0', null, '303', '101450251', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('165', 'Teleport', '437', '101451267', '0', null, '416', '101453321', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('166', 'Teleport', '452', '101451267', '0', null, '416', '101453321', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('167', 'Teleport', '437', '101450247', '0', null, '373', '101453321', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('168', 'Teleport', '452', '101450247', '0', null, '373', '101453321', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('169', 'Teleport', '437', '101453319', '0', null, '315', '101453321', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('170', 'Teleport', '452', '101453319', '0', null, '315', '101453321', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('171', 'Teleport', '437', '101452295', '0', null, '286', '101453321', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('172', 'Teleport', '452', '101452295', '0', null, '286', '101453321', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('173', 'Teleport', '478', '81788928', '0', null, '345', '138013', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('174', 'Teleport', '492', '81788928', '0', null, '345', '138013', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('175', 'Teleport', '443', '81788930', '0', null, '215', '81788928', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('176', 'Teleport', '430', '81788930', '0', null, '215', '81788928', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('177', 'Teleport', '436', '81789952', '0', null, '262', '81788928', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('178', 'Teleport', '465', '81789952', '0', null, '262', '81788928', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('179', 'Teleport', '531', '50331648', '0', null, '323', '135976', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('180', 'Teleport', '517', '50331648', '0', null, '323', '135976', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('181', 'Teleport', '503', '50331648', '0', null, '323', '135976', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('182', 'Teleport', '489', '50331648', '0', null, '323', '135976', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('183', 'Teleport', '475', '50331648', '0', null, '323', '135976', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('184', 'Teleport', '399', '41420800', '0', null, '236', '134440', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('237', 'Teleport', '329', '99096073', '0', null, '230', '99095049', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('238', 'Teleport', '424', '8129542', '0', null, '284', '12580', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('239', 'Teleport', '409', '8129542', '0', null, '284', '12580', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('240', 'Teleport', '480', '91753985', '0', null, '316', '90703872', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('241', 'Teleport', '494', '91753985', '0', null, '316', '90703872', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('191', 'Teleport', '451', '39845888', '0', null, '428', '144681', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('192', 'Teleport', '465', '39845888', '0', null, '428', '144681', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('236', 'Teleport', '376', '99095049', '0', null, '403', '88081176', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('235', 'Teleport', '389', '99095049', '0', null, '403', '88081176', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('195', 'Teleport', '409', '41418752', '0', null, '327', '143160', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('196', 'Teleport', '367', '50331650', '0', null, '382', '135974', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('197', 'Teleport', '430', '83627010', '0', null, '326', '84804355', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('198', 'Teleport', '397', '41157632', '0', null, '314', '133901', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('199', 'Teleport', '451', '4459522', '0', null, '330', '132870', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('200', 'Teleport', '257', '132360', '0', null, '386', '17051648', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('201', 'Teleport', '401', '17051648', '0', null, '271', '132360', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('202', 'Teleport', '414', '17051648', '0', null, '271', '132360', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('203', 'Teleport', '446', '17050626', '0', null, '270', '17051648', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('204', 'Teleport', '460', '17050626', '0', null, '270', '17051648', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('205', 'Teleport', '212', '99092993', '0', null, '282', '99091969', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('206', 'Teleport', '199', '99092993', '0', null, '268', '99091969', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('208', 'Teleport', '428', '99090945', '0', null, '325', '88080664', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('209', 'Teleport', '414', '99090945', '0', null, '325', '88080664', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('210', 'Teleport', '370', '99353610', '0', null, '268', '88212757', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('211', 'Teleport', '355', '99353610', '0', null, '268', '88212757', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('212', 'Teleport', '397', '99354634', '0', null, '331', '99353610', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('213', 'Teleport', '372', '99354634', '0', null, '218', '88212757', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('214', 'Teleport', '358', '99354634', '0', null, '218', '88212757', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('215', 'Teleport', '382', '99356672', '0', null, '301', '88212245', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('216', 'Teleport', '397', '99356672', '0', null, '301', '88212245', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('217', 'Teleport', '440', '99356680', '0', null, '401', '88081173', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('218', 'Teleport', '399', '99096067', '0', null, '289', '88082197', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('219', 'Teleport', '384', '99096067', '0', null, '289', '88082197', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('220', 'Teleport', '415', '99357700', '0', null, '327', '88084755', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('221', 'Teleport', '369', '99354636', '0', null, '274', '88212754', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('222', 'Teleport', '430', '99352582', '0', null, '326', '88082191', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('223', 'Teleport', '414', '99095047', '0', null, '357', '88082187', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('224', 'Teleport', '428', '99095047', '0', null, '357', '88082187', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('225', 'Teleport', '424', '99352576', '0', null, '358', '88082186', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('226', 'Teleport', '326', '99357702', '0', null, '271', '88081675', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('227', 'Teleport', '326', '99355650', '0', null, '244', '88080650', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('228', 'Teleport', '414', '99352584', '0', null, '369', '88080647', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('229', 'Teleport', '430', '99355654', '0', null, '343', '88083207', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('230', 'Teleport', '384', '99096071', '0', null, '302', '88084738', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('231', 'Teleport', '399', '99096071', '0', null, '302', '88084738', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('232', 'Teleport', '326', '99354626', '0', null, '259', '88087299', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('233', 'Teleport', '424', '99354638', '0', null, '359', '88087298', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('234', 'Teleport', '397', '76809732', '0', null, '214', '76288257', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('243', 'Teleport', '282', '8913935', '0', null, '470', '8912911', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('244', 'Teleport', '424', '8912911', '0', null, '175', '144931', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('245', 'Teleport', '409', '8912911', '0', null, '175', '144931', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('246', 'Teleport', '409', '8913935', '0', null, '218', '144931', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('247', 'Teleport', '424', '8913935', '0', null, '218', '144931', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('248', 'Teleport', '409', '8914959', '0', null, '262', '144931', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('249', 'Teleport', '424', '8914959', '0', null, '262', '144931', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('250', 'Teleport', '485', '8913935', '0', null, '296', '8914959', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('251', 'Teleport', '282', '8914959', '0', null, '470', '8913935', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('252', 'Teleport', '436', '24380418', '0', null, '247', '24379394', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('253', 'Teleport', '409', '24379394', '0', null, '355', '155157\r\n', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('254', 'Teleport', '424', '54534165', '0', null, '372', '54172457', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('255', 'Teleport', '409', '54534165', '0', null, '372', '54172457', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('256', 'Teleport', '485', '2883593', '0', null, '296', '2884617', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('257', 'Teleport', '424', '2883593', '0', null, '296', '147254', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('258', 'Teleport', '409', '2883593', '0', null, '296', '147254', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('259', 'Teleport', '282', '2884617', '0', null, '470', '2883593', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('260', 'Teleport', '409', '2884617', '0', null, '340', '147254', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('261', 'Teleport', '424', '2884617', '0', null, '340', '147254', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('262', 'Teleport', '485', '2884617', '0', null, '296', '2885641', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('263', 'Teleport', '282', '2885641', '0', null, '470', '2884617', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('264', 'Teleport', '424', '2885641', '0', null, '383', '147254', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('265', 'Teleport', '409', '2885641', '0', null, '383', '147254', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('507', 'Teleport', '410', '6291461', '0', null, '214', '146226', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('508', 'Teleport', '442', '91750917', '0', null, '244', '95424000', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('528', 'Teleport', '382', '12582918', '0', null, '270', '142880', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('269', 'Teleport', '157', '17826562', '0', null, '356', '140316', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('270', 'Teleport', '415', '3145738', '0', null, '200', '149309', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('271', 'Teleport', '410', '12845062', '0', null, '271', '146467 ', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('272', 'Teleport', '410', '84935175', '0', null, '330', '73400323', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('273', 'Teleport', '425', '84935175', '0', null, '330', '73400323', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('374', 'Teleport', '424', '3145736', '0', null, '188', '148797', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('375', 'Teleport', '396', '3145733', '0', null, '523', '148797', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('376', 'Teleport', '415', '3145732', '0', null, '285', '148796', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('377', 'Teleport', '492', '3145732', '0', null, '294', '148796', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('378', 'Teleport', '451', '4718600', '0', null, '304', '148787', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('379', 'Teleport', '506', '2884110', '0', null, '372', '147769', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('380', 'Teleport', '491', '2884110', '0', null, '372', '147769', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('381', 'Teleport', '430', '74186754', '0', null, '241', '2884110', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('382', 'Teleport', '539', '4981250', '0', null, '275', '2884110', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('383', 'Teleport', '436', '5505024', '0', null, '166', '5508102', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('384', 'Teleport', '431', '5505024', '0', null, '158', '5507072', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('385', 'Teleport', '144', '5507072', '0', null, '416', '5505024', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('386', 'Teleport', '208', '5507072', '0', null, '451', '5508096', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('387', 'Teleport', '464', '5508096', '0', null, '221', '5507072', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('388', 'Teleport', '220', '5505024', '0', null, '424', '5505026', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('389', 'Teleport', '437', '5505026', '0', null, '234', '5505024', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('390', 'Teleport', '213', '5505024', '0', null, '430', '5506050', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('391', 'Teleport', '444', '5506050', '0', null, '228', '5505024', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('392', 'Teleport', '495', '5507074', '0', null, '348', '5508098', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('393', 'Teleport', '334', '5508098', '0', null, '482', '5507074', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('394', 'Teleport', '472', '5508100', '0', null, '228', '5505030', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('395', 'Teleport', '486', '5508100', '0', null, '241', '5505030', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('396', 'Teleport', '227', '5505030', '0', null, '471', '5508100', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('397', 'Teleport', '213', '5505030', '0', null, '458', '5508100', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('398', 'Teleport', '459', '5505028', '0', null, '269', '5506054', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('399', 'Teleport', '255', '5506054', '0', null, '444', '5505028', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('400', 'Teleport', '409', '4719111', '0', null, '318', '147764', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('401', 'Teleport', '451', '6291462', '0', null, '258', '145714', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('402', 'Teleport', '458', '6291462', '0', null, '262', '145714', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('403', 'Teleport', '435', '6291463', '0', null, '246', '145202', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('404', 'Teleport', '382', '2884113', '0', null, '303', '146229', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('405', 'Teleport', '451', '2883603', '0', null, '301', '147767', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('406', 'Teleport', '479', '14155780', '0', null, '389', '148793', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('407', 'Teleport', '492', '14155780', '0', null, '389', '148793', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('408', 'Teleport', '477', '14155780', '0', null, '400', '148793', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('409', 'Teleport', '491', '14155780', '0', null, '400', '148793', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('410', 'Teleport', '459', '14155780', '0', null, '228', '14156804', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('411', 'Teleport', '445', '14155780', '0', null, '228', '14156804', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('412', 'Teleport', '424', '14158852', '0', null, '318', '14156804', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('413', 'Teleport', '438', '14158852', '0', null, '318', '14156804', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('414', 'Teleport', '424', '14156802', '0', null, '304', '14157824', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('415', 'Teleport', '438', '14156802', '0', null, '304', '14157824', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('416', 'Teleport', '460', '14158848', '0', null, '241', '14157824', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('417', 'Teleport', '473', '14158848', '0', null, '241', '14157824', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('418', 'Teleport', '445', '14155778', '0', null, '213', '14158848', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('419', 'Teleport', '459', '14155778', '0', null, '213', '14158848', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('420', 'Teleport', '424', '14155776', '0', null, '289', '14155778', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('421', 'Teleport', '438', '14155776', '0', null, '289', '14155778', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('422', 'Teleport', '473', '14155776', '0', null, '213', '14156800', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('423', 'Teleport', '460', '14155776', '0', null, '213', '14156800', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('424', 'Teleport', '460', '14156800', '0', null, '228', '14156802', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('425', 'Teleport', '473', '14156800', '0', null, '228', '14156802', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('426', 'Teleport', '459', '14157826', '0', null, '228', '14157828', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('427', 'Teleport', '445', '14157826', '0', null, '228', '14157828', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('428', 'Teleport', '438', '14157826', '0', null, '318', '14158850', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('429', 'Teleport', '453', '14157826', '0', null, '318', '14158850', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('430', 'Teleport', '445', '14157828', '0', null, '228', '14158852', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('431', 'Teleport', '459', '14157828', '0', null, '228', '14158852', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('432', 'Teleport', '445', '14158850', '0', null, '228', '14155780', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('433', 'Teleport', '459', '14158850', '0', null, '228', '14155780', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('434', 'Teleport', '445', '14157830', '0', null, '228', '14158854', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('435', 'Teleport', '459', '14157830', '0', null, '228', '14158854', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('436', 'Teleport', '424', '14156808', '0', null, '303', '14158854', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('437', 'Teleport', '438', '14156808', '0', null, '303', '14158854', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('438', 'Teleport', '445', '14155784', '0', null, '228', '14156808', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('439', 'Teleport', '459', '14155784', '0', null, '228', '14156808', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('440', 'Teleport', '445', '14155782', '0', null, '228', '14155784', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('441', 'Teleport', '459', '14155782', '0', null, '228', '14155784', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('442', 'Teleport', '424', '14155782', '0', null, '318', '14156806', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('443', 'Teleport', '409', '14155782', '0', null, '318', '14156806', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('444', 'Teleport', '445', '14156806', '0', null, '228', '14157830', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('445', 'Teleport', '459', '14156806', '0', null, '228', '14157830', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('446', 'Teleport', '445', '14158856', '0', null, '228', '14155786', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('447', 'Teleport', '459', '14158856', '0', null, '228', '14155786', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('448', 'Teleport', '424', '14157832', '0', null, '289', '14158856', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('449', 'Teleport', '438', '14157832', '0', null, '289', '14158856', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('450', 'Teleport', '445', '14157832', '0', null, '228', '14157834', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('451', 'Teleport', '459', '14157832', '0', null, '228', '14157834', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('452', 'Teleport', '445', '14157834', '0', null, '228', '14158858', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('453', 'Teleport', '459', '14157834', '0', null, '228', '14158858', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('454', 'Teleport', '438', '14158858', '0', null, '303', '14156810', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('455', 'Teleport', '453', '14158858', '0', null, '303', '14156810', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('456', 'Teleport', '445', '14155786', '0', null, '228', '14156810', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('457', 'Teleport', '459', '14155786', '0', null, '228', '14156810', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('458', 'Teleport', '478', '2883602', '0', null, '286', '148282', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('459', 'Teleport', '457', '6816261', '0', null, '468', '146237', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('460', 'Teleport', '450', '6816261', '0', null, '478', '146237', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('461', 'Teleport', '437', '6815750', '0', null, '143', '145725', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('462', 'Teleport', '396', '6554630', '0', null, '316', '6555142', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('463', 'Teleport', '410', '6554630', '0', null, '316', '6555142', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('464', 'Teleport', '450', '6554118', '0', null, '274', '145213', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('465', 'Teleport', '432', '6554118', '0', null, '308', '144701', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('466', 'Teleport', '408', '6553607', '0', null, '395', '144700', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('467', 'Teleport', '110', '24908036', '0', null, '440', '144700', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('468', 'Teleport', '464', '6554631', '0', null, '528', '144698', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('469', 'Teleport', '408', '7340038', '0', null, '510', '145719', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('470', 'Teleport', '478', '7340549', '0', null, '394', '145208', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('471', 'Teleport', '415', '7340549', '0', null, '398', '145208', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('472', 'Teleport', '464', '6554631', '0', null, '528', '144698', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('473', 'Teleport', '424', '7864328', '0', null, '366', '146234', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('474', 'Teleport', '437', '7864326', '0', null, '368', '146233', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('475', 'Teleport', '430', '7864326', '0', null, '372', '146233', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('476', 'Teleport', '396', '7864327', '0', null, '357', '146232', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('477', 'Teleport', '409', '2884629', '0', null, '353', '149812', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('478', 'Teleport', '451', '17044483', '0', null, '414', '88212244', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('479', 'Teleport', '465', '17044483', '0', null, '414', '88212244', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('480', 'Teleport', '436', '17044485', '0', null, '235', '17044483', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('481', 'Teleport', '459', '17044487', '0', null, '282', '17044485', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('482', 'Teleport', '472', '17044481', '0', null, '311', '17044483', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('483', 'Teleport', '410', '17047556', '0', null, '384', '88080660', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('484', 'Teleport', '425', '17047556', '0', null, '384', '88080660', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('485', 'Teleport', '352', '17047552', '0', null, '302', '17047556', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('486', 'Teleport', '367', '17047552', '0', null, '302', '17047556', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('487', 'Teleport', '415', '17047556', '0', null, '284', '17047554', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('488', 'Teleport', '429', '17047556', '0', null, '284', '17047554', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('489', 'Teleport', '423', '67108864', '0', null, '289', '82314240', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('490', 'Teleport', '347', '67108864', '0', null, '325', '67110912', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('491', 'Teleport', '452', '17049600', '0', null, '396', '88082201', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('492', 'Teleport', '452', '17049602', '0', null, '317', '17049600', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('493', 'Teleport', '423', '17049604', '0', null, '317', '17049602', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('494', 'Teleport', '439', '91753987', '0', null, '178', '90708227', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('495', 'Teleport', '454', '91753987', '0', null, '178', '90708227', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('496', 'Teleport', '472', '91752963', '0', null, '327', '91753987', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('497', 'Teleport', '459', '91752963', '0', null, '327', '91753987', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('498', 'Teleport', '472', '91751939', '0', null, '256', '91752963', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('499', 'Teleport', '459', '91751939', '0', null, '256', '91752963', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('500', 'Teleport', '442', '91750915', '0', null, '269', '91751939', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('501', 'Teleport', '429', '91750915', '0', null, '269', '91751939', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('502', 'Teleport', '439', '91750915', '0', null, '163', '95422464', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('503', 'Teleport', '454', '91750915', '0', null, '163', '95422464', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('504', 'Teleport', '360', '91751943', '0', null, '453', '91752967', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('505', 'Teleport', '466', '91752967', '0', null, '374', '91751943', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('506', 'Teleport', '481', '91752967', '0', null, '374', '91751943', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('509', 'Teleport', '429', '91750917', '0', null, '244', '95424000', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('510', 'Teleport', '443', '91752961', '0', null, '218', '95422466', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('511', 'Teleport', '430', '91752961', '0', null, '218', '95422466', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('512', 'Teleport', '424', '91751937', '0', null, '290', '90704385', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('513', 'Teleport', '442', '91751941', '0', null, '268', '90704896', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('514', 'Teleport', '429', '91751941', '0', null, '268', '90704896', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('515', 'Teleport', '400', '91750913', '0', null, '201', '90706432', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('516', 'Teleport', '386', '91750913', '0', null, '201', '90706432', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('517', 'Teleport', '495', '91753989', '0', null, '346', '95420416', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('518', 'Teleport', '510', '91753989', '0', null, '346', '95420416', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('519', 'Teleport', '382', '84935177', '0', null, '317', '73402375', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('520', 'Teleport', '424', '99355652', '0', null, '415', '88080898', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('521', 'Teleport', '415', '99354628', '0', null, '285', '88080384', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('522', 'Teleport', '429', '99355648', '0', null, '326', '88212480', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('523', 'Teleport', '424', '99354624', '0', null, '274', '88081408', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('524', 'Teleport', '442', '91752965', '0', null, '228', '90708226', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('525', 'Teleport', '429', '91752965', '0', null, '228', '90708226', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('527', 'Teleport', '410', '8912915', '0', null, '415', '142888', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('526', 'Teleport', '401', '7340551', '0', null, '355', '145209', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('529', 'Teleport', '410', '13893638', '0', null, '397', '142884', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('577', 'Teleport', '367', '13369350', '0', null, '215', '141858', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('578', 'Teleport', '401', '13369863', '0', null, '346', '141346', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('579', 'Teleport', '396', '8913419', '0', null, '499', '141351', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('580', 'Teleport', '374', '13107206', '0', null, '427', '141864', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('581', 'Teleport', '396', '13893639', '0', null, '261', '143396', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('582', 'Teleport', '424', '12058630', '0', null, '341', '145447', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('583', 'Teleport', '519', '8912922', '0', null, '344', '144934', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('584', 'Teleport', '505', '8912922', '0', null, '344', '144934', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('585', 'Teleport', '539', '11796994', '0', null, '289', '8912922', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('586', 'Teleport', '430', '74187778', '0', '', '268', '8912922', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('587', 'Teleport', '382', '8127494', '0', null, '401', '13603', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('588', 'Teleport', '368', '8127494', '0', null, '401', '13603', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('589', 'Teleport', '397', '17040384', '0', null, '355', '88212750', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('590', 'Teleport', '408', '17040386', '0', null, '302', '17040384', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('591', 'Teleport', '490', '13631488', '0', null, '204', '144420', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('592', 'Teleport', '534', '13631488', '0', null, '262', '144420', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('600', 'Teleport', '148', '80219654', '0', null, '334', '80740865', null, null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('601', 'Teleport', '321', '80740865', '0', null, '134', '80219654', null, null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('602', 'Teleport', '459', '80741889', '0', null, '156', '80740865', '1', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('603', 'Teleport', '165', '54175536', '0', null, '284', '55053312', '3', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('604', 'Teleport', '400', '122159617', '0', null, '312', '84674561', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('605', 'Teleport', '0', '0', '0', '', '397', '83623938', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('606', 'Teleport', '263', '102236673', '0', '', '492', '102237697', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('607', 'Teleport', '137', '102237697', '0', '', '535', '102238721', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('608', 'Teleport', '306', '102238721', '0', '', '506', '102239745', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('609', 'Teleport', '361', '102239745', '0', '', '520', '102236675', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('610', 'Teleport', '534', '102236675', '0', '', '375', '102239745', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('611', 'Teleport', '144', '102239745', '0', '', '430', '102237699', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('612', 'Teleport', '444', '102237699', '0', '', '158', '102239745', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('613', 'Teleport', '519', '102239745', '0', '', '320', '102238721', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('614', 'Teleport', '548', '102238721', '0', '', '151', '102237697', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('615', 'Teleport', '506', '102237697', '0', '', '276', '102236673', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('616', 'Teleport', '535', '102236673', '0', '', '372', '84677377', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('617', 'Teleport', '548', '84676608', '0', '', '359', '5506048', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('618', 'Teleport', '215', '5506050', '0', '', '458', '5505032', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('619', 'Teleport', '256', '5505032', '0', '', '445', '5506056', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('620', 'Teleport', '277', '5506056', '0', '', '481', '5507080', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('621', 'Teleport', '292', '5507080', '0', '', '481', '5508104', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('622', 'Teleport', '495', '5508104', '0', '', '306', '5507080', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('623', 'Teleport', '495', '5507080', '0', '', '292', '5506056', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('624', 'Teleport', '459', '5506056', '0', '', '269', '5505032', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('625', 'Teleport', '458', '5505032', '0', '', '215', '5506050', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('626', 'Teleport', '519', '5506048', '0', '', '356', '148280', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('627', 'Teleport', '424', '2884631', '0', '', '318', '2883609', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('628', 'Teleport', '472', '2884633', '0', '', '200', '149309', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('629', 'Teleport', '464', '2883599', '0', '', '164', '148278', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('630', 'Teleport', '65', '146233', '0', '', '549', '146234', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('631', 'Teleport', '319', '7864328', '0', '', '467', '7864840', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('632', 'Teleport', '481', '7864840', '0', '', '332', '7864328', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('633', 'Teleport', '493', '84673536', '0', '', '370', '13631488', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('635', 'Teleport', '226', '101715459', '0', '', '541', '101714435', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('636', 'Teleport', '117', '101714435', '0', '', '528', '101714433', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('637', 'Teleport', '543', '101714433', '0', '', '131', '101714435', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('638', 'Teleport', '555', '101714435', '0', '', '240', '101715459', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('639', 'Teleport', '324', '84675074', '0', '', '315', '84674563', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('641', 'Teleport', '231', '142888', '0', '', '210', '145447', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('642', 'Teleport', '225', '145447', '0', '', '184', '146467', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('643', 'Teleport', '198', '146467', '0', '', '253', '145952', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('644', 'Teleport', '451', '12320775', '0', '', '455', '145952', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('645', 'Teleport', '253', '145952', '0', '', '419', '142884', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('646', 'Teleport', '404', '142884', '0', '', '223', '145444', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('647', 'Teleport', '437', '8912909', '0', '', '355', '145444', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('648', 'Teleport', '237', '145444', '0', '', '273', '141858', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('649', 'Teleport', '259', '141858', '0', '', '535', '141346', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('650', 'Teleport', '521', '141346', '0', '', '239', '142880', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('651', 'Teleport', '239', '142880', '0', '', '189', '141351', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('652', 'Teleport', '204', '141351', '0', '', '386', '141864', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('653', 'Teleport', '82', '141864', '0', '', '158', '143396', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('654', 'Teleport', '158', '143396', '0', '', '171', '144934', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('655', 'Teleport', '4', '144934', '0', '', '488', '145445', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('656', 'Teleport', '439', '8913941', '0', '', '329', '145445', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('657', 'Teleport', '483', '145445', '0', '', '116', '144931', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('658', 'Teleport', '331', '144931', '0', '', '430', '144930', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('659', 'Teleport', '410', '8912916', '0', '', '400', '144930', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('660', 'Teleport', '414', '144930', '0', '', '264', '13631488', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('661', 'Teleport', '241', '13634560', '0', '', '415', '13631500', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('662', 'Teleport', '465', '13631500', '0', '', '221', '13632524', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('663', 'Teleport', '214', '13633548', '0', '', '457', '13634572', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('664', 'Teleport', '471', '13634572', '0', '', '229', '13633548', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('665', 'Teleport', '228', '13633548', '0', '', '470', '13634572', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('666', 'Teleport', '485', '13634572', '0', '', '242', '13633548', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('667', 'Teleport', '430', '13631500', '0', '', '256', '13634560', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('668', 'Teleport', '264', '13631488', '0', '', '157', '144932', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('669', 'Teleport', '264', '144932', '0', '', '253', '145952', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('670', 'Teleport', '478', '13894149', '0', '', '484', '143395', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('671', 'Teleport', '463', '13894149', '0', '', '484', '143395', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('672', 'Teleport', '500', '143395', '0', '', '132', '142375', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('673', 'Teleport', '464', '13107205', '0', '', '246', '142375', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('674', 'Teleport', '132', '142375', '0', '', '346', '142367', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('675', 'Teleport', '465', '12583429', '0', '', '328', '142367', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('676', 'Teleport', '345', '142367', '0', '', '319', '144425', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('677', 'Teleport', '479', '12058631', '0', '', '179', '144425', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('678', 'Teleport', '291', '144425', '0', '', '319', '144419', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('680', 'Teleport', '445', '11273216', '0', '', '227', '11274240', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('681', 'Teleport', '459', '11273216', '0', '', '227', '11274240', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('682', 'Teleport', '473', '11272192', '0', '', '213', '11273216', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('683', 'Teleport', '487', '11272192', '0', '', '213', '11273216', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('684', 'Teleport', '473', '11272194', '0', '', '213', '11273218', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('685', 'Teleport', '487', '11272194', '0', '', '213', '11273218', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('686', 'Teleport', '459', '11273218', '0', '', '227', '11274242', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('687', 'Teleport', '445', '11273218', '0', '', '227', '11274242', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('688', 'Teleport', '445', '11273220', '0', '', '227', '11274244', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('689', 'Teleport', '459', '11273220', '0', '', '227', '11274244', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('690', 'Teleport', '466', '11273220', '0', '', '355', '144418', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('691', 'Teleport', '480', '11273220', '0', '', '355', '144418', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('692', 'Teleport', '478', '11273220', '0', '', '351', '144418', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('693', 'Teleport', '463', '11273220', '0', '', '351', '144418', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('694', 'Teleport', '407', '11273220', '0', '', '267', '144418', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('695', 'Teleport', '394', '11273220', '0', '', '267', '144418', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('696', 'Teleport', '21', '144418', '0', '', '253', '145952', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('697', 'Teleport', '413', '142880', '0', '', '319', '144425', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('698', 'Teleport', '183', '141863', '0', '', '319', '144419', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('701', 'Teleport', '228', '146229', '0', '', '128', '148797', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('702', 'Teleport', '367', '148797', '0', '', '541', '144700', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('704', 'Teleport', '303', '147764', '0', '', '428', '146234', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('705', 'Teleport', '400', '146234', '0', '', '257', '147767', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('706', 'Teleport', '537', '147767', '0', '', '285', '145719', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('707', 'Teleport', '285', '145719', '0', '', '287', '145209', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('708', 'Teleport', '287', '145209', '0', '', '275', '146226', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('709', 'Teleport', '260', '146226', '0', '', '234', '149812', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('710', 'Teleport', '260', '149812', '0', '', '302', '147764', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('711', 'Teleport', '439', '147764', '0', '', '234', '149812', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('712', 'Teleport', '234', '149812', '0', '', '149', '145725', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('713', 'Teleport', '162', '145725', '0', '', '193', '146232', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('714', 'Teleport', '241', '146232', '0', '', '202', '147769', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('715', 'Teleport', '424', '147769', '0', '', '537', '148282', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('716', 'Teleport', '524', '148282', '0', '', '445', '147254', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('717', 'Teleport', '386', '147254', '0', '', '213', '148278', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('718', 'Teleport', '450', '2883599', '0', '', '164', '148278', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('719', 'Teleport', '213', '148278', '0', '', '263', '148279', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('720', 'Teleport', '425', '2883600', '0', '', '219', '148279', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('721', 'Teleport', '248', '148279', '0', '', '389', '5506048', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('722', 'Teleport', '229', '5506050', '0', '', '458', '5505032', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('723', 'Teleport', '269', '5505032', '0', '', '459', '5506056', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('724', 'Teleport', '292', '5506056', '0', '', '495', '5507080', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('725', 'Teleport', '481', '5507080', '0', '', '277', '5506056', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('726', 'Teleport', '361', '5506048', '0', '', '387', '146233', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('727', 'Teleport', '359', '146233', '0', '', '470', '148796', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('728', 'Teleport', '470', '148796', '0', '', '359', '146237', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('729', 'Teleport', '206', '146237', '0', '', '247', '148786', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('730', 'Teleport', '458', '4718598', '0', '', '357', '148786', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('731', 'Teleport', '391', '148786', '0', '', '442', '144698', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('732', 'Teleport', '457', '144698', '0', '', '275', '145208', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('733', 'Teleport', '410', '145208', '0', '', '303', '145714', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('734', 'Teleport', '426', '145714', '0', '', '208', '148283', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('735', 'Teleport', '250', '148283', '0', '', '303', '145714', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('736', 'Teleport', '303', '145714', '0', '', '241', '148278', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('737', 'Teleport', '240', '148278', '0', '', '541', '144700', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('739', 'Teleport', '429', '146741', '0', '', '155', '147768', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('741', 'Teleport', '408', '95684097', '0', '', '232', '95685121', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('742', 'Teleport', '394', '95684097', '0', '', '232', '95685121', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('743', 'Teleport', '401', '95687169', '0', '', '283', '95685121', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('744', 'Teleport', '479', '95686145', '0', '', '318', '95687169', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('745', 'Teleport', '452', '95685123', '0', '', '291', '95686145', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('746', 'Teleport', '437', '95685123', '0', '', '291', '95686145', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('747', 'Teleport', '398', '99093005', '0', '', '318', '88082200', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('748', 'Teleport', '383', '99093005', '0', '', '318', '88082200', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('749', 'Teleport', '248', '97256979', '0', '', '465', '97258003', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('750', 'Teleport', '228', '97258003', '0', '', '500', '97259027', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('751', 'Teleport', '194', '97259027', '0', '', '409', '97260051', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('752', 'Teleport', '423', '97260051', '0', '', '208', '97259027', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('753', 'Teleport', '267', '97259027', '0', '', '484', '97261075', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('754', 'Teleport', '498', '97261075', '0', '', '282', '97259027', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('755', 'Teleport', '515', '97259027', '0', '', '242', '97258003', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('756', 'Teleport', '479', '97258003', '0', '', '262', '97256979', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('757', 'Teleport', '443', '17047554', '0', '', '366', '17047558', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('758', 'Teleport', '430', '17047554', '0', '', '366', '17047558', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('759', 'Teleport', '205', '67373056', '0', '', '311', '67112960', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('760', 'Teleport', '173', '67112960', '0', '', '445', '67373056', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('761', 'Teleport', '423', '121896964', '0', '', '373', '88082195', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('762', 'Teleport', '437', '121896964', '0', '', '373', '88082195', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('763', 'Teleport', '505', '170133510', '0', '', '259', '90708481', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('764', 'Teleport', '485', '170132488', '0', '', '368', '170133504', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('765', 'Teleport', '498', '170132488', '0', '', '368', '170133504', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('766', 'Teleport', '465', '170133512', '0', '', '208', '170133510', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('767', 'Teleport', '519', '170133510', '0', '', '259', '90708481', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('768', 'Teleport', '183', '115082753', '0', '', '474', '115083777', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('770', 'Teleport', '332', '70778880', '0', '', '315', '84674563', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('771', 'Teleport', '316', '84805890', '0', '', '452', '101450251', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('772', 'Teleport', '452', '101451265', '0', '', '416', '101453321', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('773', 'Teleport', '437', '101451265', '0', '', '416', '101453321', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('774', 'Teleport', '331', '130024961', '0', '', '312', '130025985', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('775', 'Teleport', '297', '130025985', '0', '', '345', '130024961', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('776', 'Teleport', '312', '130024961', '0', '', '515', '130024963', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('777', 'Teleport', '480', '130024963', '0', '', '261', '130025987', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('778', 'Teleport', '228', '130025987', '0', '', '515', '130023937', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('779', 'Teleport', '493', '130023937', '0', '', '507', '130155009', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('780', 'Teleport', '493', '130155009', '0', '', '507', '130023937', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('781', 'Teleport', '486', '130023937', '0', '', '257', '130025987', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('782', 'Teleport', '247', '130025987', '0', '', '507', '130024963', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('783', 'Teleport', '486', '130024963', '0', '', '326', '130024961', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('784', 'Teleport', '304', '130025985', '0', '', '522', '130023939', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('785', 'Teleport', '493', '130023939', '0', '', '318', '130025985', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('786', 'Teleport', '545', '130024961', '0', '', '344', '164496396', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('787', 'Teleport', '472', '165282827', '0', '', '370', '13631488', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('790', 'Teleport', '424', '99352580', '0', '', '343', '88082705', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('791', 'Teleport', '308', '121634816', '0', '', '222', '121635840', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('792', 'Teleport', '425', '121635840', '0', '', '332', '67371008', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('793', 'Teleport', '553', '84674565', '0', '', '20', '84674566', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('794', 'Teleport', '486', '106168320', '0', '', '228', '264', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('795', 'Teleport', '242', '70778880', '0', '', '370', '13631488', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('796', 'Teleport', '316', '88083210', '0', '', '340', '121766912', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('799', 'Teleport', '451', '170133512', '0', '', '208', '170133510', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('800', 'Teleport', '519', '168559618', '0', '', '370', '13631488', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('801', 'Teleport', '183', '29884416', '0', '', '187', '143896', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('802', 'Teleport', '282', '29884416', '0', '', '248', '29884428', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('803', 'Teleport', '235', '29884428', '0', '', '268', '29884416', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('804', 'Teleport', '347', '29884416', '0', '', '449', '29885952', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('805', 'Teleport', '432', '29885952', '0', '', '170', '29887491', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('806', 'Teleport', '474', '29887491', '0', '', '170', '29884422', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('807', 'Teleport', '155', '29884422', '0', '', '460', '29887491', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('808', 'Teleport', '155', '29887491', '0', '', '417', '29885952', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('809', 'Teleport', '113', '29885952', '0', '', '460', '29884419', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('810', 'Teleport', '155', '29884419', '0', '', '474', '29885955', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('811', 'Teleport', '489', '29885955', '0', '', '170', '29884419', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('812', 'Teleport', '474', '29884419', '0', '', '127', '29885952', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('813', 'Teleport', '138', '29885952', '0', '', '449', '29885958', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('814', 'Teleport', '462', '29885958', '0', '', '152', '29885952', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('815', 'Teleport', '462', '29885952', '0', '', '360', '29884416', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('816', 'Teleport', '152', '29885958', '0', '', '449', '29887494', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('817', 'Teleport', '462', '29887494', '0', '', '165', '29885958', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('818', 'Teleport', '113', '29887494', '0', '', '460', '29885961', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('819', 'Teleport', '474', '29885961', '0', '', '127', '29887494', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('820', 'Teleport', '155', '29885961', '0', '', '460', '29887497', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('821', 'Teleport', '474', '29887497', '0', '', '170', '29885961', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('822', 'Teleport', '138', '29887494', '0', '', '449', '29884425', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('823', 'Teleport', '462', '29884425', '0', '', '152', '29887494', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('824', 'Teleport', '197', '142872', '0', '', '370', '13631488', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('825', 'Teleport', '415', '41944064', '0', '', '242', '88213777', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('826', 'Teleport', '335', '88212749', '0', '', '335', '88213261', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('827', 'Teleport', '416', '97259013', '0', '', '382', '88213774', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('828', 'Teleport', '403', '97259013', '0', '', '382', '88213774', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('829', 'Teleport', '276', '97259013', '0', '', '505', '97256967', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('830', 'Teleport', '194', '97256967', '0', '', '437', '97260039', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('831', 'Teleport', '241', '97260039', '0', '', '444', '97261063', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('832', 'Teleport', '296', '97261063', '0', '', '402', '97255945', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('833', 'Teleport', '213', '97255945', '0', '', '386', '97256969', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('834', 'Teleport', '401', '97256969', '0', '', '228', '97255945', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('835', 'Teleport', '332', '97255945', '0', '', '341', '97260041', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('836', 'Teleport', '354', '97260041', '0', '', '346', '97255945', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('837', 'Teleport', '416', '97255945', '0', '', '311', '97261063', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('838', 'Teleport', '331', '97261063', '0', '', '423', '97259017', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('839', 'Teleport', '436', '97259017', '0', '', '345', '97261063', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('840', 'Teleport', '459', '97261063', '0', '', '256', '97260039', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('841', 'Teleport', '262', '97260039', '0', '', '523', '97257993', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('842', 'Teleport', '122', '97257993', '0', '', '465', '97261065', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('843', 'Teleport', '213', '97261065', '0', '', '486', '97255947', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('844', 'Teleport', '199', '97255947', '0', '', '489', '97256971', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('845', 'Teleport', '239', '97256971', '0', '', '359', '97257995', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('846', 'Teleport', '374', '97257995', '0', '', '254', '97256971', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('847', 'Teleport', '234', '97256971', '0', '', '508', '97261067', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('848', 'Teleport', '521', '97261067', '0', '', '247', '97256971', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('849', 'Teleport', '503', '97256971', '0', '', '213', '97255947', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('850', 'Teleport', '500', '97255947', '0', '', '228', '97261065', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('851', 'Teleport', '236', '97261065', '0', '', '425', '97259019', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('852', 'Teleport', '276', '97259019', '0', '', '437', '97260043', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('853', 'Teleport', '451', '97260043', '0', '', '290', '97259019', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('854', 'Teleport', '438', '97259019', '0', '', '249', '97261065', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('855', 'Teleport', '479', '97261065', '0', '', '135', '97257993', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('856', 'Teleport', '537', '97257993', '0', '', '275', '97260039', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('857', 'Teleport', '451', '97260039', '0', '', '208', '97256967', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('858', 'Teleport', '229', '97256967', '0', '', '290', '97259013', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('859', 'Teleport', '258', '97259013', '0', '', '415', '97260037', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('860', 'Teleport', '352', '97260037', '0', '', '443', '97261061', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('861', 'Teleport', '284', '97261061', '0', '', '388', '97255943', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('862', 'Teleport', '403', '97255943', '0', '', '298', '97261061', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('863', 'Teleport', '290', '97261061', '0', '', '437', '97259015', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('864', 'Teleport', '451', '97259015', '0', '', '303', '97261061', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('865', 'Teleport', '458', '97261061', '0', '', '367', '97260037', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('866', 'Teleport', '303', '97260037', '0', '', '451', '97257991', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('867', 'Teleport', '464', '97257991', '0', '', '317', '97260037', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('868', 'Teleport', '430', '97260037', '0', '', '272', '97259013', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('869', 'Teleport', '494', '97259013', '0', '', '339', '97257989', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('870', 'Teleport', '324', '97257989', '0', '', '480', '97259013', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('871', 'Teleport', '497', '88212750', '0', '', '370', '13631488', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('872', 'Teleport', '493', '97256989', '0', '', '221', '88085250', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('873', 'Teleport', '479', '97256989', '0', '', '221', '88085250', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('874', 'Teleport', '533', '38535168', '0', '', '303', '88087301', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('875', 'Teleport', '344', '88087302', '0', '', '332', '67371008', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('876', 'Teleport', '410', '67371008', '0', '', '370', '13631488', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('877', 'Teleport', '201', '117965057', '0', '', '332', '67371008', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('878', 'Teleport', '201', '67371008', '0', '', '370', '13631488', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('879', 'Teleport', '441', '88087299', '0', '', '332', '67371008', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('880', 'Teleport', '500', '115081731', '0', null, '201', '115083777', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('881', 'Teleport', '514', '115081731', '0', null, '214', '115083777', '60', null, null, null);
INSERT INTO `world_maps_triggers` VALUES ('882', 'Teleport', '471', '106169344', '0', null, '312', '106168320', '60', null, null, null);
SET FOREIGN_KEY_CHECKS=1;
