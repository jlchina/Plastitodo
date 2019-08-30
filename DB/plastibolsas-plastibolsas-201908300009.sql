-- MySQL dump 10.13  Distrib 5.5.62, for Win64 (AMD64)
--
-- Host: localhost    Database: plastibolsas
-- ------------------------------------------------------
-- Server version	5.5.5-10.3.16-MariaDB

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `catalogacion`
--

DROP TABLE IF EXISTS `catalogacion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `catalogacion` (
  `id` int(11) unsigned NOT NULL AUTO_INCREMENT,
  `Gpo_prod` varchar(20) NOT NULL,
  `Id_familia` int(2) NOT NULL,
  `Id_categoria` int(2) NOT NULL,
  `Nom_categoria` text NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `catalogacion`
--

LOCK TABLES `catalogacion` WRITE;
/*!40000 ALTER TABLE `catalogacion` DISABLE KEYS */;
INSERT INTO `catalogacion` VALUES (1,'1-1',1,1,'CHAROLA'),(2,'2-1',2,1,'TERMICO'),(3,'3-1',3,1,'BOLSA P/BASURA'),(4,'7-1',7,1,'TRAPEADOR / ESCOBA'),(5,'7-2',7,2,'ACC. DE LAVADO'),(6,'7-3',7,3,'JABON LIQUIDO'),(7,'3-2',3,2,'CAMISETA'),(8,'1-2',1,2,'PLATO POZOLERO'),(9,'3-3',3,3,'ROLLO BOLSA'),(10,'8-1',8,1,'MESA'),(11,'2-2',2,2,'VASO NORMAL');
/*!40000 ALTER TABLE `catalogacion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `catalogacion_familias`
--

DROP TABLE IF EXISTS `catalogacion_familias`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `catalogacion_familias` (
  `id_familia` int(11) unsigned NOT NULL AUTO_INCREMENT,
  `nom_familia` text NOT NULL,
  `descripcion_fam` text NOT NULL,
  PRIMARY KEY (`id_familia`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `catalogacion_familias`
--

LOCK TABLES `catalogacion_familias` WRITE;
/*!40000 ALTER TABLE `catalogacion_familias` DISABLE KEYS */;
INSERT INTO `catalogacion_familias` VALUES (1,'PLATOS Y MOLDES','PLATOS, CHAROLAS, MOLDES Y CONTENEDORES'),(2,'VASOS','TERMICOS, PLASTICO, TAPAS'),(3,'BOLSAS','BOLSAS P/BASURA, CAMISETA, ROLLO'),(7,'LIMPIEZA','TRAPEADORES, JABON, SUAVIZANTE, ESCOBA, RECOJEDOR'),(8,'COCINA','PALILLOS, PAPEL ALUMINIO, PAPEL TOALLA');
/*!40000 ALTER TABLE `catalogacion_familias` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `catalogo_productos`
--

DROP TABLE IF EXISTS `catalogo_productos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `catalogo_productos` (
  `id` int(11) unsigned NOT NULL AUTO_INCREMENT,
  `codigo_barras` bigint(14) NOT NULL,
  `marca` int(4) DEFAULT NULL,
  `Modelo` text NOT NULL,
  `descripcion` text DEFAULT NULL,
  `presentacion` int(4) DEFAULT NULL,
  `precio` decimal(5,2) DEFAULT NULL,
  `id_catalogacion` int(11) NOT NULL,
  `id_prov` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=32 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `catalogo_productos`
--

LOCK TABLES `catalogo_productos` WRITE;
/*!40000 ALTER TABLE `catalogo_productos` DISABLE KEYS */;
INSERT INTO `catalogo_productos` VALUES (4,7501133549748,2,'#855','#855 CHAROLA 16X10CM',1,12.50,1,1),(5,1100004155747,3,'TRN8-14','TRN8-14 PAQ VASOS TERMICOS #8 20PZAS',1,15.50,2,2),(6,7501791646482,4,'ECO17','ECO17 BOLSA P/BASURA  CHICA BIODEG',2,25.00,3,1),(7,7501022008171,3,'R81035','R81035 BOLSA CAMISETA EN ROLLO',1,7.50,7,2),(8,1752666001237,1,'ARM77','ARM77 PAQUETE VASOS TERMICO #12 14PZAS',1,14.70,2,1),(9,21136010541,5,'PO14-AS','PO14-AS PLATO HONDO #10 12PZAS',1,9.00,8,2),(10,7501064196935,3,'BC715T','BC715T BOLSA CELOFAN 7X15',2,8.50,9,1),(11,16240000000000,2,'1636BRT','1636BRT ROLLO DE BOLSA 16X36',2,16.00,9,2),(12,7503004624027,6,'CUALPA250','CUALPA250 PALILLO DENTAL REDONDO C/250',1,2.50,10,2),(13,1,1,'RB1636AMR','RB1636AMR BOLSA ROLLO 16X36',2,23.50,9,1),(14,2,2,'BN710T','BN710T ROLLO BOLSA 7X10',2,11.30,9,2),(15,7501952966442,2,'VP8','VP8 VASO POLIPRO NO. 8 16PZAS',1,4.70,11,3),(16,7501058628503,1,'VP20EU','VP20EU VASO POLIPRO NO. 20 EU 8PZAS',1,6.80,11,3),(17,7503000123043,2,'VP12EU','VP12EU VASO POLIPRO NO. 12 EU',1,8.10,11,4),(18,7501952966442,2,'007 Reyma','007 Reyma Charola Térmica 23X18',1,13.00,1,6),(19,7501644770012,2,'PT9C2D','PT9C2D CHAROLA 9 C/2 DIVISIONES',1,9.99,1,6),(20,7750670000604,3,'PT9D','PT9D CHAROLA #9 DIVISION 23X18',1,11.30,1,4),(21,7502237305185,1,'VT6','VT6 VASO TERMICO NO. 6 C/24',1,10.56,2,2),(22,621299005110,1,'VT1LT','VT1LT VASO TERMICO NO. 1 LITRO C/2',1,4.30,2,2),(23,7506198007928,5,'PH4','PH4 PLATO TERMICO No.PH4',1,8.95,8,8),(24,7501052472195,2,'PH8','PH8 PLATO TERMICO No.PH8',1,7.99,8,8),(25,610013,7,'EM125P','EM125P SERVILLETAS 125PZAS',1,14.30,10,12),(26,3,8,'1T','1T TRAPEADOR BCO',1,21.00,4,11),(27,4,8,'1E','1E ESCOBA BASE PLASTICO',1,19.90,4,11),(28,42339,7,'SB100P','SB100P Servilleta Blanca 10',1,14.55,10,12),(29,369412,6,'C20EB','C20EB BOLSA ECOLOGICA P/BASURA 20PZAS',1,18.99,3,1),(30,46340,9,'PA15M','PA15M PAPEL ALUMINIO 15 MTS',1,33.00,10,12),(31,5,8,'1R','1R RECOGEDOR DE PLASTICO',1,29.34,4,12);
/*!40000 ALTER TABLE `catalogo_productos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cliente`
--

DROP TABLE IF EXISTS `cliente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cliente` (
  `idCliente` int(11) unsigned NOT NULL AUTO_INCREMENT,
  `Nombre` tinytext COLLATE latin1_general_ci NOT NULL,
  `Direccion` tinytext COLLATE latin1_general_ci NOT NULL,
  `Colonia` tinytext COLLATE latin1_general_ci NOT NULL,
  `Ciudad` tinytext COLLATE latin1_general_ci NOT NULL,
  `Codigo_postal` varchar(45) COLLATE latin1_general_ci NOT NULL,
  `telefono` varchar(45) COLLATE latin1_general_ci NOT NULL,
  `email` tinytext COLLATE latin1_general_ci DEFAULT NULL,
  `rfc` varchar(20) COLLATE latin1_general_ci NOT NULL,
  `razon_social` varchar(115) COLLATE latin1_general_ci NOT NULL,
  `fecha_creacion` timestamp NULL DEFAULT current_timestamp(),
  `fecha_actualizacion` timestamp NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  PRIMARY KEY (`idCliente`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cliente`
--

LOCK TABLES `cliente` WRITE;
/*!40000 ALTER TABLE `cliente` DISABLE KEYS */;
INSERT INTO `cliente` VALUES (1,'Cliente General','foo','foo','foo','28000','1234567894','1234567894','ASD6544EREWT','Foo SA de CV','2019-08-29 01:53:57','2019-08-29 02:54:23'),(2,'Manuel Alejandro Lopez Santamaria','Enrique Castillo','Tabachinez','Colima','28983','3121222221','alejandro.lopez.santamaria@hotmail.com','LOMS891026Q16','Manuel Alejandro ','2019-08-30 01:14:56','2019-08-30 01:14:56'),(3,'Raul Cordoba Vazquez','Caritina Maldonado 1214','Tabachinez','Colima','28983','3121403709','rcordoba_v@hotmail.com','COV780504756','Raul Cordoba','2019-08-30 01:17:22','2019-08-30 01:17:22'),(4,'Jose Luis China Sotelo','Damazo Carrillo','Punta Diamante','Villa de Alvarez','28897','3121324273','j.luis.china@gmail.com','JLCS880817A58','Jose Luis China','2019-08-30 01:19:58','2019-08-30 01:19:58'),(5,'Alejandro Estrada Hernandez','Prisciliano Perez','Rancho Blanco','Villa de Alvarez','28789','3121311383','telematik_69@hotmail.com','AEHQ789447D47','Alejandro Estrada','2019-08-30 01:22:13','2019-08-30 01:22:13'),(6,'Grupo Arce','San Fernando 147','Centro','Colima','28000','31247985336','arce.grupo@hotmail.com','GARF78965Q34','Grupo Arce','2019-08-30 01:23:18','2019-08-30 01:23:18'),(7,'Alma Celia Ramos Corona','Antonio Rodriguez Hernandez 247','Centro','Colima','14789','3124579635','alma.ramos@hotmail.com','ACRC73256S47','Alma Ramos','2019-08-30 01:25:02','2019-08-30 01:25:02'),(8,'Tania Perez Duarte','Parque San Luis','Terminales','Manzanillo','89785','31256789087','tania.perez@gmail.com','TPDW1234E5','Tania Perez','2019-08-30 01:26:28','2019-08-30 01:26:28'),(9,'Manuel de la Mora Zarate','Casimiro Perez','Ponce de Leon','Morelia','778965','3121558979','manuel.delamora@yahoo.com','MMZE3456G087','Manuel Zarate','2019-08-30 01:27:38','2019-08-30 01:27:38'),(10,'Luis Alvarez Moreno','Castillos Ricos','La Comarca','Colima','25896','3123456788','luis.alvarez_lo@hotmail.com','LAME789652J45','Luis Alvarez','2019-08-30 01:28:50','2019-08-30 01:28:50'),(11,'Iram Morales Lopez','Lopez Doriga 4789','El yaqui','Guadalajara','987456','3125897896','iram_456@gmail.com','IMLW6543K34','Iram Morales','2019-08-30 01:31:05','2019-08-30 01:31:05'),(12,'Pedro Alcantar Iglesias','AV. MEXICO 23','CENTRO','MANZANILLO','28200','3121559067','pai_90@gmail.com','ALIP900204H78','DESECHABLES LA COSTA','2019-08-30 03:21:59','2019-08-30 03:21:59');
/*!40000 ALTER TABLE `cliente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cuenta_cobrar`
--

DROP TABLE IF EXISTS `cuenta_cobrar`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cuenta_cobrar` (
  `folio` int(11) unsigned NOT NULL AUTO_INCREMENT,
  `fecha_vencimiento` date DEFAULT NULL,
  `total` varchar(45) COLLATE latin1_general_ci DEFAULT NULL,
  `pagado` varchar(45) COLLATE latin1_general_ci DEFAULT NULL,
  `fecha_pago` date DEFAULT NULL,
  `id_cliente` varchar(45) COLLATE latin1_general_ci DEFAULT NULL,
  PRIMARY KEY (`folio`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cuenta_cobrar`
--

LOCK TABLES `cuenta_cobrar` WRITE;
/*!40000 ALTER TABLE `cuenta_cobrar` DISABLE KEYS */;
/*!40000 ALTER TABLE `cuenta_cobrar` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cuentas_pagar`
--

DROP TABLE IF EXISTS `cuentas_pagar`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cuentas_pagar` (
  `folio_factura` int(11) NOT NULL,
  `fecha_vencimiento` varchar(45) COLLATE latin1_general_ci DEFAULT NULL,
  `total` varchar(45) COLLATE latin1_general_ci DEFAULT NULL,
  `cuentas_pagadas` varchar(45) COLLATE latin1_general_ci DEFAULT NULL,
  `folio_pago` varchar(45) COLLATE latin1_general_ci DEFAULT NULL,
  `tipo_pago` varchar(45) COLLATE latin1_general_ci DEFAULT NULL,
  `id_proveedor` varchar(45) COLLATE latin1_general_ci DEFAULT NULL,
  PRIMARY KEY (`folio_factura`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cuentas_pagar`
--

LOCK TABLES `cuentas_pagar` WRITE;
/*!40000 ALTER TABLE `cuentas_pagar` DISABLE KEYS */;
/*!40000 ALTER TABLE `cuentas_pagar` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `detalle_entrada`
--

DROP TABLE IF EXISTS `detalle_entrada`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `detalle_entrada` (
  `folio` int(11) unsigned NOT NULL AUTO_INCREMENT,
  `fecha` timestamp NOT NULL DEFAULT current_timestamp(),
  `id_producto` varchar(45) COLLATE latin1_general_ci DEFAULT NULL,
  `precio` varchar(45) COLLATE latin1_general_ci DEFAULT NULL,
  `cantidad` varchar(45) COLLATE latin1_general_ci DEFAULT NULL,
  `proveedor` text COLLATE latin1_general_ci NOT NULL,
  `usuario` varchar(20) COLLATE latin1_general_ci NOT NULL,
  PRIMARY KEY (`folio`)
) ENGINE=InnoDB AUTO_INCREMENT=30 DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detalle_entrada`
--

LOCK TABLES `detalle_entrada` WRITE;
/*!40000 ALTER TABLE `detalle_entrada` DISABLE KEYS */;
INSERT INTO `detalle_entrada` VALUES (1,'2019-08-30 03:29:32','1','23.50','100','Plastilina de colima','1'),(2,'2019-08-30 03:34:31','1','23.50','100','Plastilina de colima','1'),(3,'2019-08-30 03:37:13','2','11.30','100','Plastilina de colima','1'),(4,'2019-08-30 03:37:35','2','11.30','50','Plastilina de colima','1'),(5,'2019-08-30 03:40:41','16240000000000','16.00','132','ARTE EXPORTACION S.A. DE C.V.','1'),(6,'2019-08-30 04:04:09','1100004155747','15.50','500','DISTRIBUIDORA Y COMERCIALIZADORA JAZ SA DE CV','1'),(7,'2019-08-30 04:04:37','7501022008171','7.50','400','SUMINISTRO MY R SA DE CV','1'),(8,'2019-08-30 04:04:38','7501791646482','25.00','147','AEDIFICANT, S.A. DE C.V.','1'),(9,'2019-08-30 04:05:02','21136010541','9.00','800','ACEMAQ SA DE CV','1'),(10,'2019-08-30 04:05:34','16240000000000','16.00','50','AUTOTRANSPORTES DE CARGA TRESGUERRAS, S.A. DE C.V. SUC. GUADALAJARA-JALISCO','1'),(11,'2019-08-30 04:05:36','1752666001237','14.70','101','AGROVET, S.A. DE C.V.','1'),(12,'2019-08-30 04:06:19','7501952966442','4.70','250','AEDIFICANT, S.A. DE C.V.','1'),(13,'2019-08-30 04:06:24','7501064196935','8.50','87','ARTE EXPORTACION S.A. DE C.V.','1'),(14,'2019-08-30 04:06:55','7503004624027','2.50','47','AEDIFICANT, S.A. DE C.V.','1'),(15,'2019-08-30 04:07:14','7503000123043','8.10','350','AUTOEXPRESS ORIENTE, S.A. DE C.V.','1'),(16,'2019-08-30 04:07:33','7501058628503','6.80','80','DISTRIBUIDORA Y COMERCIALIZADORA JAZ SA DE CV','1'),(17,'2019-08-30 04:07:36','7501644770012','9.99','100','AGROVET, S.A. DE C.V.','1'),(18,'2019-08-30 04:08:01','7501952966442','4.70','147','ARROW ELECTRONICS MÉXICO S.A. DE C.V.','1'),(19,'2019-08-30 04:08:04','7502237305185','10.56','50','ACEROCABLES SA DE CV','1'),(20,'2019-08-30 04:08:27','7750670000604','11.30','189','ACEMAQ SA DE CV','1'),(21,'2019-08-30 04:08:32','7506198007928','8.95','450','AROMAS AUTOMOTRICES GUSTO, S.A. DE C.V.','1'),(22,'2019-08-30 04:08:48','621299005110','4.30','97','SUMINISTRO MY R SA DE CV','1'),(23,'2019-08-30 04:08:57','610013','14.30','60','ARTE EXPORTACION S.A. DE C.V.','1'),(24,'2019-08-30 04:09:11','7501052472195','7.99','77','AEDIFICANT, S.A. DE C.V.','1'),(25,'2019-08-30 04:09:17','4','19.90','67','ARTE EXPORTACION S.A. DE C.V.','1'),(26,'2019-08-30 04:09:37','42339','14.55','60','AUTOTRANSPORTES DE CARGA TRESGUERRAS, S.A. DE C.V. SUC. GUADALAJARA-JALISCO','1'),(27,'2019-08-30 04:09:42','3','21.00','49','ARROW ELECTRONICS MÉXICO S.A. DE C.V.','1'),(28,'2019-08-30 04:10:18','42339','14.55','78','ARTE EXPORTACION S.A. DE C.V.','1'),(29,'2019-08-30 04:11:19','46340','33.00','96','ACEMAQ SA DE CV','1');
/*!40000 ALTER TABLE `detalle_entrada` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `detalle_salida`
--

DROP TABLE IF EXISTS `detalle_salida`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `detalle_salida` (
  `folio_detalle` int(11) unsigned NOT NULL AUTO_INCREMENT,
  `id_producto` varchar(45) COLLATE latin1_general_ci DEFAULT NULL,
  `precio` varchar(45) COLLATE latin1_general_ci DEFAULT NULL,
  `cantidad` varchar(45) COLLATE latin1_general_ci DEFAULT NULL,
  PRIMARY KEY (`folio_detalle`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detalle_salida`
--

LOCK TABLES `detalle_salida` WRITE;
/*!40000 ALTER TABLE `detalle_salida` DISABLE KEYS */;
/*!40000 ALTER TABLE `detalle_salida` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `documentos`
--

DROP TABLE IF EXISTS `documentos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `documentos` (
  `id` int(11) unsigned NOT NULL AUTO_INCREMENT,
  `folio` int(11) unsigned NOT NULL,
  `id_tipo_documento` int(11) NOT NULL,
  `id_cliente` int(11) NOT NULL,
  `nombre` varchar(255) NOT NULL,
  `vendedor` varchar(255) NOT NULL,
  `comentarios` text DEFAULT NULL,
  `subtotal` decimal(5,2) NOT NULL,
  `iva` decimal(5,2) NOT NULL,
  `total` decimal(5,2) NOT NULL,
  `id_usuario` int(11) NOT NULL,
  `fecha_creacion` timestamp NULL DEFAULT current_timestamp(),
  `fecha_actualizacion` timestamp NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `documentos`
--

LOCK TABLES `documentos` WRITE;
/*!40000 ALTER TABLE `documentos` DISABLE KEYS */;
INSERT INTO `documentos` VALUES (1,1,2,1,'alejandro estrada hdz','lupita','Llevar a calle prisciliano perez zamora #1277, valle del sol a las 4pm',751.49,120.24,871.72,1,'2019-08-30 04:44:10','2019-08-30 04:44:10'),(2,1,1,1,'alejandro estrada hdz','lupita','Llevar a calle prisciliano perez zamora #1277, valle del sol a las 4pm',751.49,120.24,871.72,1,'2019-08-30 04:46:22','2019-08-30 04:46:22'),(3,2,1,1,'alejandro estrada hdz','lupita','Llevar a calle prisciliano perez zamora #1277, valle del sol a las 4pm',751.49,120.24,871.72,1,'2019-08-30 04:54:58','2019-08-30 04:54:58');
/*!40000 ALTER TABLE `documentos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `entradas`
--

DROP TABLE IF EXISTS `entradas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `entradas` (
  `Folio` int(11) unsigned NOT NULL AUTO_INCREMENT,
  `fecha_entrada` date DEFAULT NULL,
  `id_proveedor` varchar(45) COLLATE latin1_general_ci DEFAULT NULL,
  PRIMARY KEY (`Folio`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `entradas`
--

LOCK TABLES `entradas` WRITE;
/*!40000 ALTER TABLE `entradas` DISABLE KEYS */;
/*!40000 ALTER TABLE `entradas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `estados_documento`
--

DROP TABLE IF EXISTS `estados_documento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `estados_documento` (
  `id` int(11) unsigned NOT NULL AUTO_INCREMENT,
  `nombre` varchar(45) NOT NULL,
  `descripcion` varchar(255) DEFAULT NULL,
  `fecha_creacion` timestamp NULL DEFAULT current_timestamp(),
  `fecha_actualizacion` timestamp NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `estados_documento`
--

LOCK TABLES `estados_documento` WRITE;
/*!40000 ALTER TABLE `estados_documento` DISABLE KEYS */;
/*!40000 ALTER TABLE `estados_documento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `historico_costos`
--

DROP TABLE IF EXISTS `historico_costos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `historico_costos` (
  `id` int(11) unsigned NOT NULL AUTO_INCREMENT,
  `Id_Prov` int(11) NOT NULL,
  `id_catprod` int(11) NOT NULL,
  `precio_cto` decimal(5,2) NOT NULL,
  `fecha` timestamp NOT NULL DEFAULT current_timestamp(),
  `usuario` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=48 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `historico_costos`
--

LOCK TABLES `historico_costos` WRITE;
/*!40000 ALTER TABLE `historico_costos` DISABLE KEYS */;
INSERT INTO `historico_costos` VALUES (1,1,6,25.00,'2019-08-08 08:42:31',0),(2,1,7,7.50,'2019-08-10 20:34:46',0),(6,1,1,12.50,'2019-08-24 06:30:26',0),(7,1,1,12.50,'2019-08-24 06:30:53',0),(8,1,2,15.50,'2019-08-24 06:31:09',0),(9,1,8,14.70,'2019-08-24 18:48:12',0),(10,1,4,12.50,'2019-08-24 18:55:56',0),(11,1,6,25.00,'2019-08-24 20:25:43',0),(12,1,9,10.00,'2019-08-24 20:27:42',0),(13,1,10,8.50,'2019-08-27 08:34:22',1),(14,1,9,9.00,'2019-08-27 08:35:16',1),(15,2,7,7.50,'2019-08-30 02:08:20',1),(16,1,8,14.70,'2019-08-30 02:09:22',1),(17,2,5,15.50,'2019-08-30 02:10:56',1),(18,2,9,9.00,'2019-08-30 02:12:34',1),(19,2,9,9.00,'2019-08-30 02:13:28',1),(20,2,11,16.00,'2019-08-30 02:16:11',1),(21,2,12,2.50,'2019-08-30 02:22:43',1),(22,1,12,23.50,'2019-08-30 02:25:14',1),(23,1,10,8.50,'2019-08-30 02:57:20',1),(24,1,10,8.50,'2019-08-30 02:57:39',1),(25,2,12,11.30,'2019-08-30 03:00:31',1),(26,3,15,4.70,'2019-08-30 03:13:52',1),(27,3,15,6.80,'2019-08-30 03:17:31',1),(28,4,15,8.10,'2019-08-30 03:19:48',1),(29,6,15,13.00,'2019-08-30 03:25:45',1),(30,6,15,9.99,'2019-08-30 03:28:16',1),(31,3,15,11.30,'2019-08-30 03:30:28',1),(32,4,20,11.30,'2019-08-30 03:31:07',1),(33,2,15,10.56,'2019-08-30 03:35:16',1),(34,3,15,4.30,'2019-08-30 03:37:44',1),(35,0,22,4.30,'2019-08-30 03:38:13',1),(36,8,15,8.95,'2019-08-30 03:44:21',1),(37,2,22,4.30,'2019-08-30 03:45:17',1),(38,8,15,7.99,'2019-08-30 03:50:47',1),(39,12,25,14.30,'2019-08-30 03:58:35',1),(40,11,26,21.00,'2019-08-30 04:00:19',1),(41,11,27,19.90,'2019-08-30 04:01:22',1),(42,12,28,14.55,'2019-08-30 04:02:48',1),(43,1,26,18.99,'2019-08-30 04:06:42',1),(44,12,30,33.00,'2019-08-30 04:08:46',1),(45,1,4,12.50,'2019-08-30 04:53:56',1),(46,12,31,27.30,'2019-08-30 05:06:41',1),(47,12,31,29.34,'2019-08-30 05:07:56',1);
/*!40000 ALTER TABLE `historico_costos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `historico_preciopublico`
--

DROP TABLE IF EXISTS `historico_preciopublico`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `historico_preciopublico` (
  `id` int(11) unsigned NOT NULL AUTO_INCREMENT,
  `id_catalogo` int(11) NOT NULL,
  `id_costo` int(11) NOT NULL,
  `p_publico` decimal(6,2) NOT NULL,
  `fecha` timestamp NOT NULL DEFAULT current_timestamp(),
  `id_usuario` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=42 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `historico_preciopublico`
--

LOCK TABLES `historico_preciopublico` WRITE;
/*!40000 ALTER TABLE `historico_preciopublico` DISABLE KEYS */;
INSERT INTO `historico_preciopublico` VALUES (1,4,0,22.25,'2019-08-24 06:53:15',0),(2,4,0,22.25,'2019-08-24 06:53:16',0),(3,4,0,22.25,'2019-08-24 06:53:16',0),(4,4,0,22.25,'2019-08-24 06:53:16',0),(5,5,5,27.59,'2019-08-24 18:59:14',0),(6,5,5,27.59,'2019-08-24 18:59:20',0),(7,5,5,29.91,'2019-08-24 18:59:53',0),(8,9,12,16.60,'2019-08-24 20:50:45',0),(9,5,0,29.91,'2019-08-27 07:17:24',1),(10,10,13,14.11,'2019-08-27 08:37:08',1),(18,14,0,18.76,'2019-08-30 04:29:00',1),(19,14,0,20.00,'2019-08-30 04:29:24',1),(20,26,43,30.00,'2019-08-30 04:30:33',1),(21,14,0,20.11,'2019-08-30 04:34:20',1),(22,28,43,30.00,'2019-08-30 04:58:01',1),(23,30,44,47.85,'2019-08-30 04:58:33',1),(24,25,39,19.45,'2019-08-30 04:59:00',1),(25,9,19,19.45,'2019-08-30 04:59:25',1),(26,22,37,19.45,'2019-08-30 05:00:02',1),(27,5,17,22.48,'2019-08-30 05:00:24',1),(28,8,16,22.48,'2019-08-30 05:00:50',1),(29,7,15,10.20,'2019-08-30 05:01:09',1),(30,7,15,10.20,'2019-08-30 05:01:33',1),(31,16,15,10.20,'2019-08-30 05:01:56',1),(32,10,24,12.33,'2019-08-30 05:02:33',1),(33,19,24,12.33,'2019-08-30 05:02:49',1),(34,6,11,41.50,'2019-08-30 05:03:06',1),(35,18,11,18.85,'2019-08-30 05:03:28',1),(36,21,11,16.37,'2019-08-30 05:03:46',1),(37,11,20,21.00,'2019-08-30 05:03:57',1),(38,17,11,16.37,'2019-08-30 05:04:05',1),(39,12,25,16.37,'2019-08-30 05:04:20',1),(40,20,32,17.51,'2019-08-30 05:04:24',1),(41,23,25,16.37,'2019-08-30 05:04:37',1);
/*!40000 ALTER TABLE `historico_preciopublico` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `inventario`
--

DROP TABLE IF EXISTS `inventario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `inventario` (
  `codigo_barras` bigint(14) NOT NULL,
  `existencia` int(45) DEFAULT NULL,
  `maximo` int(45) DEFAULT NULL,
  `minimo` int(45) DEFAULT NULL,
  `reorden` varchar(45) COLLATE latin1_general_ci DEFAULT NULL,
  `activo` varchar(45) COLLATE latin1_general_ci DEFAULT NULL,
  PRIMARY KEY (`codigo_barras`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `inventario`
--

LOCK TABLES `inventario` WRITE;
/*!40000 ALTER TABLE `inventario` DISABLE KEYS */;
INSERT INTO `inventario` VALUES (1,200,0,0,'',''),(2,81,0,0,'',''),(3,49,0,0,'',''),(4,67,0,0,'',''),(42339,138,0,0,'',''),(46340,96,0,0,'',''),(610013,60,0,0,'',''),(21136010541,800,0,0,'',''),(621299005110,97,0,0,'',''),(1100004155747,488,0,0,'',''),(1752666001237,101,0,0,'',''),(7501022008171,400,0,0,'',''),(7501052472195,77,0,0,'',''),(7501058628503,80,0,0,'',''),(7501064196935,51,0,0,'',''),(7501644770012,100,0,0,'',''),(7501791646482,147,0,0,'',''),(7501952966442,397,0,0,'',''),(7502237305185,50,0,0,'',''),(7503000123043,350,0,0,'',''),(7503004624027,47,0,0,'',''),(7506198007928,450,0,0,'',''),(7750670000604,189,0,0,'',''),(16240000000000,182,0,0,'','');
/*!40000 ALTER TABLE `inventario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `lineas_documento`
--

DROP TABLE IF EXISTS `lineas_documento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `lineas_documento` (
  `id` int(11) unsigned NOT NULL AUTO_INCREMENT,
  `id_documento` int(11) NOT NULL,
  `id_tipo_documento` int(11) NOT NULL,
  `id_producto` int(11) NOT NULL,
  `cantidad` decimal(5,2) NOT NULL,
  `id_presentacion` int(11) NOT NULL,
  `precio` decimal(5,2) NOT NULL,
  `descuento` decimal(5,2) NOT NULL,
  `id_iva` int(11) NOT NULL,
  `subtotal` decimal(5,2) NOT NULL,
  `iva` decimal(5,2) NOT NULL,
  `total` decimal(5,2) NOT NULL,
  `fecha_creacion` timestamp NULL DEFAULT current_timestamp(),
  `fecha_actualizacion` timestamp NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `lineas_documento`
--

LOCK TABLES `lineas_documento` WRITE;
/*!40000 ALTER TABLE `lineas_documento` DISABLE KEYS */;
INSERT INTO `lineas_documento` VALUES (1,1,2,5,4.00,1,29.91,0.00,1,119.64,19.14,138.78,'2019-08-30 04:44:10','2019-08-30 04:44:10'),(2,1,2,14,23.00,2,20.11,0.00,1,462.53,74.00,536.53,'2019-08-30 04:44:10','2019-08-30 04:44:10'),(3,1,2,10,12.00,2,14.11,0.00,1,169.32,27.09,196.41,'2019-08-30 04:44:10','2019-08-30 04:44:10'),(4,2,1,5,4.00,1,29.91,7.00,1,119.64,19.14,138.78,'2019-08-30 04:46:22','2019-08-30 04:46:22'),(5,2,1,14,23.00,2,20.11,7.00,1,462.53,74.00,536.53,'2019-08-30 04:46:22','2019-08-30 04:46:22'),(6,2,1,10,12.00,2,14.11,7.00,1,169.32,27.09,196.41,'2019-08-30 04:46:22','2019-08-30 04:46:22'),(7,3,1,5,4.00,1,29.91,7.00,1,119.64,19.14,138.78,'2019-08-30 04:54:58','2019-08-30 04:54:58'),(8,3,1,14,23.00,2,20.11,7.00,1,462.53,74.00,536.53,'2019-08-30 04:54:58','2019-08-30 04:54:58'),(9,3,1,10,12.00,2,14.11,7.00,1,169.32,27.09,196.41,'2019-08-30 04:54:58','2019-08-30 04:54:58');
/*!40000 ALTER TABLE `lineas_documento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `marcas`
--

DROP TABLE IF EXISTS `marcas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `marcas` (
  `id` int(11) unsigned NOT NULL AUTO_INCREMENT,
  `marca` text NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `marcas`
--

LOCK TABLES `marcas` WRITE;
/*!40000 ALTER TABLE `marcas` DISABLE KEYS */;
INSERT INTO `marcas` VALUES (1,'JAGUAR'),(2,'REYMA'),(3,'ECOSHELL'),(4,'PLAYTEX'),(5,'CLIM'),(6,'PINGUINO'),(7,'ECONOMAX'),(8,'ND'),(9,'REYNOLDS');
/*!40000 ALTER TABLE `marcas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `modulos`
--

DROP TABLE IF EXISTS `modulos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `modulos` (
  `id` int(11) unsigned NOT NULL AUTO_INCREMENT,
  `nombre` varchar(80) NOT NULL,
  `descripcion` varchar(80) NOT NULL,
  `tiene_secciones` tinyint(4) NOT NULL DEFAULT 0,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `modulos`
--

LOCK TABLES `modulos` WRITE;
/*!40000 ALTER TABLE `modulos` DISABLE KEYS */;
INSERT INTO `modulos` VALUES (1,'Usuarios','Modulo de usuarios del sistema',0),(2,'Perfiles','Modulo de perfiles del sistema',0),(3,'Clientes','Modulo de clientes del sistema',1),(4,'Proveedores','Modulo de proveedores del sistema',1),(5,'Productos','Modulo de productos del sistema',1),(6,'Inventario','Modulo de inventario',1),(7,'Ventas','Modulo de ventas',1);
/*!40000 ALTER TABLE `modulos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `perfiles`
--

DROP TABLE IF EXISTS `perfiles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `perfiles` (
  `id` int(11) unsigned NOT NULL AUTO_INCREMENT,
  `nombre` varchar(80) NOT NULL,
  `descripcion` varchar(80) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `perfiles`
--

LOCK TABLES `perfiles` WRITE;
/*!40000 ALTER TABLE `perfiles` DISABLE KEYS */;
INSERT INTO `perfiles` VALUES (1,'Administrador','Administrador del sistema'),(2,'Ventas','Ventas en caja'),(3,'Almacenista','Encargados de almacen'),(4,'Compras','Encargado de compras');
/*!40000 ALTER TABLE `perfiles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `presentacion_prod`
--

DROP TABLE IF EXISTS `presentacion_prod`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `presentacion_prod` (
  `id_pp` int(11) unsigned NOT NULL AUTO_INCREMENT,
  `presentacion` text NOT NULL,
  PRIMARY KEY (`id_pp`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `presentacion_prod`
--

LOCK TABLES `presentacion_prod` WRITE;
/*!40000 ALTER TABLE `presentacion_prod` DISABLE KEYS */;
INSERT INTO `presentacion_prod` VALUES (1,'PZA'),(2,'KG'),(3,'LTS');
/*!40000 ALTER TABLE `presentacion_prod` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `proveedor`
--

DROP TABLE IF EXISTS `proveedor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `proveedor` (
  `idProveedor` int(11) unsigned NOT NULL AUTO_INCREMENT,
  `Nombre` tinytext CHARACTER SET latin1 COLLATE latin1_general_ci DEFAULT NULL,
  `Direccion` tinytext CHARACTER SET latin1 COLLATE latin1_general_ci DEFAULT NULL,
  `Colonia` tinytext CHARACTER SET latin1 COLLATE latin1_general_ci DEFAULT NULL,
  `Ciudad` tinytext CHARACTER SET latin1 COLLATE latin1_general_ci DEFAULT NULL,
  `Codigo_postal` varchar(45) CHARACTER SET latin1 COLLATE latin1_general_ci DEFAULT NULL,
  `telefono` varchar(45) CHARACTER SET latin1 COLLATE latin1_general_ci DEFAULT NULL,
  `correo` tinytext CHARACTER SET latin1 COLLATE latin1_general_ci DEFAULT NULL,
  `contacto` tinytext CHARACTER SET latin1 COLLATE latin1_general_ci DEFAULT NULL,
  PRIMARY KEY (`idProveedor`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `proveedor`
--

LOCK TABLES `proveedor` WRITE;
/*!40000 ALTER TABLE `proveedor` DISABLE KEYS */;
INSERT INTO `proveedor` VALUES (1,'Plastilina de colima','Lauro villar #510','Hacienda el centenario','villa de alvarez','28984','3123085596',NULL,'Juan Rivera'),(2,'DISTRIBUIDORA Y COMERCIALIZADORA JAZ SA DE CV','Cerrada del Agua 1, Los Reyes','Centro','Reyes Acaquilpan','56400','55 5855 8902','comercializadora-jaz.contacto@gmail.com','Ruiz martinez'),(3,'SUMINISTRO MY R SA DE CV','PLOMO No. 204','FIDEICOMISO CIUDAD INDUSTRIAL','TABASCO','86010','(044)9931407537','myr.contacto@gmail.com','Maria Gonzalez'),(4,'ACEMAQ SA DE CV','GONZALEZ GALLO No. 634','GONZALEZ GALLO','JALISCO','44430','(33 )37932400','acemaq@att.net.mx','Gregoria Maldonado'),(5,'AUTOTRANSPORTES DE CARGA TRESGUERRAS, S.A. DE C.V. SUC. GUADALAJARA-JALISCO','1 No. 1375','GONZALEZ GALLO','GUADALAJARA','44430','(333 )8372870','aandrade@tresguerras.ocm.mx','Jose China'),(6,'AEDIFICANT, S.A. DE C.V.','SANTA RITA No. 60','JARDINES DE SAN IGNACIO','ZAPOPAN','45040','(33 )33434311','aedificant@hotmail.com','Alejandro Santamaria'),(7,'ARROW ELECTRONICS MÉXICO S.A. DE C.V.','AVIACION No. 3800','SAN JUAN DE OCOTAN','ZAPOPAN','45019','(0133)37773113','cgonzalez@arrowmx.com','Alejandro Estrada'),(8,'AUTOEXPRESS ORIENTE, S.A. DE C.V.','PEMEX No. 267 ','SAN PEDRITO','SAN PEDRO TLAQUEPAQUE','45625','(33 )600121','autoexpress.oriente@hotmail.com','Gerardo Lopez'),(9,'AGROVET, S.A. DE C.V.','JUAN DE LA BARRERA 3485','PARQUE INDUSTRIAL EL ALAMO','GUADALAJARA','44490','(33 )3670-1425 3670-6033','agrovet.ventas@hotmail.com','JOSE DE JESUS SUAREZ'),(10,'ACEROCABLES SA DE CV','LAZARO CARDENAS No. 1440','BARRIO ALTO','SAN PEDRO TLAQUEPAQUE','45590','(33 )31341234','aceroscables@gmail.com','Roberto Gomez'),(11,'AROMAS AUTOMOTRICES GUSTO, S.A. DE C.V.','CARDENAL No. 1029 ','MORELOS','GUADALAJARA','44910','(33 )3812-2959','info.aromas@aromasgusto.com','Carolina Reyes'),(12,'ARTE EXPORTACION S.A. DE C.V.','JUAREZ No. 20','TLAQUEPAQUE CENTRO','GUADALAJARA','45500','(33 )36359394','artxport@foreigner.class.udg.mx','JAZMIN LOPEZ MENDEZ');
/*!40000 ALTER TABLE `proveedor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `relacion_perfiles_modulos`
--

DROP TABLE IF EXISTS `relacion_perfiles_modulos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `relacion_perfiles_modulos` (
  `id` int(11) unsigned NOT NULL AUTO_INCREMENT,
  `id_perfil` int(11) NOT NULL,
  `id_modulo` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=44 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `relacion_perfiles_modulos`
--

LOCK TABLES `relacion_perfiles_modulos` WRITE;
/*!40000 ALTER TABLE `relacion_perfiles_modulos` DISABLE KEYS */;
INSERT INTO `relacion_perfiles_modulos` VALUES (7,1,7),(32,1,1),(33,1,2),(34,1,3),(35,1,4),(36,1,5),(37,1,6),(40,3,6),(41,2,7),(42,4,4),(43,4,5);
/*!40000 ALTER TABLE `relacion_perfiles_modulos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `relacion_perfiles_secciones`
--

DROP TABLE IF EXISTS `relacion_perfiles_secciones`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `relacion_perfiles_secciones` (
  `id` int(11) unsigned NOT NULL AUTO_INCREMENT,
  `id_perfil` int(11) NOT NULL,
  `id_seccion` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `relacion_perfiles_secciones`
--

LOCK TABLES `relacion_perfiles_secciones` WRITE;
/*!40000 ALTER TABLE `relacion_perfiles_secciones` DISABLE KEYS */;
INSERT INTO `relacion_perfiles_secciones` VALUES (1,1,1),(2,1,2),(3,1,3),(4,1,4),(5,1,5),(6,1,6);
/*!40000 ALTER TABLE `relacion_perfiles_secciones` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `salidas`
--

DROP TABLE IF EXISTS `salidas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `salidas` (
  `folio_salidas` int(11) unsigned NOT NULL AUTO_INCREMENT,
  `fecha_salida` date DEFAULT NULL,
  `id_cliente` varchar(45) COLLATE latin1_general_ci DEFAULT NULL,
  PRIMARY KEY (`folio_salidas`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `salidas`
--

LOCK TABLES `salidas` WRITE;
/*!40000 ALTER TABLE `salidas` DISABLE KEYS */;
/*!40000 ALTER TABLE `salidas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `secciones`
--

DROP TABLE IF EXISTS `secciones`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `secciones` (
  `id` int(11) unsigned NOT NULL AUTO_INCREMENT,
  `nombre` varchar(80) NOT NULL,
  `descripcion` varchar(80) NOT NULL,
  `id_modulo` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `secciones`
--

LOCK TABLES `secciones` WRITE;
/*!40000 ALTER TABLE `secciones` DISABLE KEYS */;
INSERT INTO `secciones` VALUES (1,'Lista','Lista de clientes',3),(2,'Crear','Crar Nuevo cliente',3),(3,'Lista','Lista de proveedores',4),(4,'Crear','Crear nuevo proveedor',4),(5,'Lista','Lista de productos',5),(6,'Crear','Crear nuevo producto',5);
/*!40000 ALTER TABLE `secciones` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tipos_documento`
--

DROP TABLE IF EXISTS `tipos_documento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tipos_documento` (
  `id` int(11) unsigned NOT NULL AUTO_INCREMENT,
  `nombre` varchar(45) NOT NULL,
  `descripcion` varchar(255) DEFAULT NULL,
  `fecha_creacion` timestamp NULL DEFAULT current_timestamp(),
  `fecha_actualizacion` timestamp NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tipos_documento`
--

LOCK TABLES `tipos_documento` WRITE;
/*!40000 ALTER TABLE `tipos_documento` DISABLE KEYS */;
INSERT INTO `tipos_documento` VALUES (1,'Nota','Nota de venta','2019-08-23 21:47:16','2019-08-23 21:47:16'),(2,'Orden','Orden de venta','2019-08-23 21:47:16','2019-08-23 21:47:16');
/*!40000 ALTER TABLE `tipos_documento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuarios`
--

DROP TABLE IF EXISTS `usuarios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `usuarios` (
  `id` int(11) unsigned NOT NULL AUTO_INCREMENT,
  `username` varchar(100) NOT NULL,
  `password` varchar(255) NOT NULL,
  `nombre` varchar(150) NOT NULL,
  `ap_paterno` varchar(100) NOT NULL,
  `ap_materno` varchar(100) DEFAULT NULL,
  `id_perfil` int(11) NOT NULL,
  `create` timestamp NULL DEFAULT current_timestamp(),
  `updated` timestamp NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  `estatus` tinyint(1) DEFAULT 1,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1 COMMENT='Tabla de usuarios sistema plastitodo';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuarios`
--

LOCK TABLES `usuarios` WRITE;
/*!40000 ALTER TABLE `usuarios` DISABLE KEYS */;
INSERT INTO `usuarios` VALUES (1,'admin','k0hALciYOS16DZX8tiCPXw==','Administrador','Plastitodo',NULL,1,'2019-08-03 16:10:11','2019-08-03 16:10:11',1),(2,'AESTRADA','5fAuwv60FYZVJujfo6Tv6w==','Alejandro','Estrada','Hernandez',1,'2019-08-03 16:10:11','2019-08-03 16:10:11',1),(3,'ventas1','gnzLDuqKcGxMNKFokfhOew==','Caja 1','Ventas',' ',2,'2019-08-03 16:27:50','2019-08-03 16:27:50',1),(4,'cord','pf2tnef686BJKBK5y4GNhQ==','raul','cordova','vazquez',3,'2019-08-03 17:45:00','2019-08-03 17:45:00',1);
/*!40000 ALTER TABLE `usuarios` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping routines for database 'plastibolsas'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-08-30  0:09:04
