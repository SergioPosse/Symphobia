/*
MySQL Data Transfer
Source Host: localhost
Source Database: sergioposse2
Target Host: localhost
Target Database: sergioposse2
Date: 19/06/2012 11:59:57 p.m.
*/

SET FOREIGN_KEY_CHECKS=0;
-- ----------------------------
-- Table structure for cliente
-- ----------------------------
DROP TABLE IF EXISTS `cliente`;
CREATE TABLE `cliente` (
  `clie_id` int(32) NOT NULL auto_increment,
  `clie_dni` int(32) default NULL,
  `clie_nomb` varchar(32) default NULL,
  `clie_apel` varchar(32) default NULL,
  `clie_tele` varchar(32) default NULL,
  `clie_domi` varchar(32) default NULL,
  `loca_id` int(32) default NULL,
  PRIMARY KEY  (`clie_id`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Table structure for compra
-- ----------------------------
DROP TABLE IF EXISTS `compra`;
CREATE TABLE `compra` (
  `comp_Id` int(32) NOT NULL auto_increment,
  `prod_id` int(32) NOT NULL,
  `comp_cant` int(32) NOT NULL,
  `comp_fech` date default NULL,
  `comp_impo` decimal(32,0) default NULL,
  `prov_id` int(32) default NULL,
  PRIMARY KEY  (`comp_Id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- ----------------------------
-- Table structure for detalleventa
-- ----------------------------
DROP TABLE IF EXISTS `detalleventa`;
CREATE TABLE `detalleventa` (
  `vent_id` int(32) NOT NULL,
  `prod_id` int(32) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- ----------------------------
-- Table structure for empresa
-- ----------------------------
DROP TABLE IF EXISTS `empresa`;
CREATE TABLE `empresa` (
  `emp_id` int(32) NOT NULL auto_increment,
  `emp_nomb` varchar(32) default NULL,
  `emp_CUIT` varchar(32) default NULL,
  `emp_tele` varchar(32) default NULL,
  `emp_dire` varchar(32) default NULL,
  PRIMARY KEY  (`emp_id`)
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Table structure for forma_pago
-- ----------------------------
DROP TABLE IF EXISTS `forma_pago`;
CREATE TABLE `forma_pago` (
  `form_pago_id` int(32) NOT NULL auto_increment,
  `form_pago_desc` varchar(32) NOT NULL,
  PRIMARY KEY  (`form_pago_id`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Table structure for instrumento
-- ----------------------------
DROP TABLE IF EXISTS `instrumento`;
CREATE TABLE `instrumento` (
  `inst_id` int(32) NOT NULL auto_increment,
  `inst_tipo` varchar(32) default NULL,
  PRIMARY KEY  (`inst_id`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Table structure for localidad
-- ----------------------------
DROP TABLE IF EXISTS `localidad`;
CREATE TABLE `localidad` (
  `loca_id` int(32) NOT NULL auto_increment,
  `loca_nomb` varchar(32) default NULL,
  PRIMARY KEY  (`loca_id`)
) ENGINE=MyISAM AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Table structure for marca
-- ----------------------------
DROP TABLE IF EXISTS `marca`;
CREATE TABLE `marca` (
  `marc_id` int(32) NOT NULL auto_increment,
  `marc_nomb` varchar(32) default NULL,
  PRIMARY KEY  (`marc_id`)
) ENGINE=MyISAM AUTO_INCREMENT=8 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Table structure for modelo
-- ----------------------------
DROP TABLE IF EXISTS `modelo`;
CREATE TABLE `modelo` (
  `mode_id` int(32) NOT NULL auto_increment,
  `mode_nomb` varchar(32) default NULL,
  `marc_id` int(32) NOT NULL,
  PRIMARY KEY  (`mode_id`)
) ENGINE=MyISAM AUTO_INCREMENT=8 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Table structure for producto
-- ----------------------------
DROP TABLE IF EXISTS `producto`;
CREATE TABLE `producto` (
  `prod_id` int(255) NOT NULL auto_increment COMMENT 'sf',
  `mode_id` int(32) default NULL,
  `inst_id` int(32) default NULL,
  `prod_gara` int(32) NOT NULL,
  `prod_prec` decimal(32,2) NOT NULL,
  `prod_stoc` int(32) default NULL,
  PRIMARY KEY  (`prod_id`)
) ENGINE=MyISAM AUTO_INCREMENT=9 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Table structure for proveedor
-- ----------------------------
DROP TABLE IF EXISTS `proveedor`;
CREATE TABLE `proveedor` (
  `prov_id` int(32) NOT NULL auto_increment,
  `prov_nomb` varchar(32) default NULL,
  `prov_tele` varchar(32) default NULL,
  `loc_id` int(32) NOT NULL,
  PRIMARY KEY  (`prov_id`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Table structure for venta
-- ----------------------------
DROP TABLE IF EXISTS `venta`;
CREATE TABLE `venta` (
  `vent_id` int(32) NOT NULL auto_increment,
  `clie_id` int(32) NOT NULL,
  `vent_impo` decimal(32,2) default NULL COMMENT 'importe final con IVA incluido',
  `vent_fech` date default NULL,
  `form_pago_id` int(32) default NULL,
  `emp_id` int(32) NOT NULL,
  `vent_tipo_fact` char(1) default NULL COMMENT 'si es A,B,C',
  PRIMARY KEY  (`vent_id`)
) ENGINE=MyISAM AUTO_INCREMENT=13 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records 
-- ----------------------------
INSERT INTO `cliente` VALUES ('1', '34567876', 'Jose', 'Perez', '4578698', 'Baigorria 2976', '1');
INSERT INTO `cliente` VALUES ('2', '33454323', 'Mariana', 'Dominguez', '3479790', 'Peru 765', '2');
INSERT INTO `detalleventa` VALUES ('1', '1');
INSERT INTO `detalleventa` VALUES ('1', '2');
INSERT INTO `detalleventa` VALUES ('1', '1');
INSERT INTO `detalleventa` VALUES ('1', '2');
INSERT INTO `detalleventa` VALUES ('12', '1');
INSERT INTO `detalleventa` VALUES ('12', '1');
INSERT INTO `empresa` VALUES ('1', 'SYMPHOBIA S.A', '20-34771269-7', '32584849720', 'Urquiza 1878');
INSERT INTO `forma_pago` VALUES ('1', 'Tarjeta de credito');
INSERT INTO `forma_pago` VALUES ('2', 'Efectivo');
INSERT INTO `forma_pago` VALUES ('3', 'Cheque');
INSERT INTO `instrumento` VALUES ('1', 'Guitarra');
INSERT INTO `instrumento` VALUES ('2', 'Teclado');
INSERT INTO `instrumento` VALUES ('3', 'Percusion');
INSERT INTO `instrumento` VALUES ('4', 'Accesorio');
INSERT INTO `localidad` VALUES ('1', 'Rio Cuarto');
INSERT INTO `localidad` VALUES ('2', 'Cordoba');
INSERT INTO `localidad` VALUES ('3', 'La Plata');
INSERT INTO `localidad` VALUES ('4', 'Rosario');
INSERT INTO `localidad` VALUES ('5', 'General Belgrano');
INSERT INTO `localidad` VALUES ('6', 'Villa Maria');
INSERT INTO `marca` VALUES ('1', 'Fender');
INSERT INTO `marca` VALUES ('2', 'Ibañez');
INSERT INTO `marca` VALUES ('3', 'Faim');
INSERT INTO `marca` VALUES ('4', 'Tama');
INSERT INTO `marca` VALUES ('5', 'BC Rich');
INSERT INTO `marca` VALUES ('6', 'Casio');
INSERT INTO `marca` VALUES ('7', 'Korg');
INSERT INTO `modelo` VALUES ('1', 'Squier', '1');
INSERT INTO `modelo` VALUES ('2', 'Lighting 3000', '6');
INSERT INTO `modelo` VALUES ('3', 'Pua 3mm', '1');
INSERT INTO `modelo` VALUES ('4', 'Correa Dragon', '1');
INSERT INTO `modelo` VALUES ('5', 'GIO', '2');
INSERT INTO `modelo` VALUES ('6', 'Drumkit Hell', '4');
INSERT INTO `modelo` VALUES ('7', 'Vintage', '4');
INSERT INTO `producto` VALUES ('1', '1', '1', '6', '578.00', '9');
INSERT INTO `producto` VALUES ('2', '1', '1', '0', '689.00', '8');
INSERT INTO `producto` VALUES ('3', '2', '2', '9', '766.22', '17');
INSERT INTO `producto` VALUES ('4', '3', '4', '7', '2.50', '235');
INSERT INTO `producto` VALUES ('5', '4', '4', '1', '48.00', '78');
INSERT INTO `producto` VALUES ('6', '5', '1', '12', '2900.20', '5');
INSERT INTO `producto` VALUES ('7', '6', '3', '24', '4600.00', '2');
INSERT INTO `producto` VALUES ('8', '7', '3', '12', '4230.99', '1');
INSERT INTO `proveedor` VALUES ('1', 'La Casa De La Viola', '4678950', '2');
INSERT INTO `proveedor` VALUES ('2', 'Teclados SUPER', '4667971', '3');
INSERT INTO `venta` VALUES ('1', '1', '1600.00', '2012-06-05', '1', '1', 'A');
INSERT INTO `venta` VALUES ('2', '2', '187.00', '2012-06-11', '2', '2', 'C');
INSERT INTO `venta` VALUES ('12', '1', '1156.00', '2012-06-19', '1', '1', 'C');
