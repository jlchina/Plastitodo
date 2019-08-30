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
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `catalogacion`
--

LOCK TABLES `catalogacion` WRITE;
/*!40000 ALTER TABLE `catalogacion` DISABLE KEYS */;
INSERT INTO `catalogacion` VALUES (1,'1-1',1,1,'CHAROLA'),(2,'2-1',2,1,'TERMICO'),(3,'3-1',3,1,'BOLSA P/BASURA');
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
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `catalogacion_familias`
--

LOCK TABLES `catalogacion_familias` WRITE;
/*!40000 ALTER TABLE `catalogacion_familias` DISABLE KEYS */;
INSERT INTO `catalogacion_familias` VALUES (1,'PLATOS Y MOLDES','PLATOS, CHAROLAS, MOLDES Y CONTENEDORES'),(2,'VASOS','TERMICOS, PLASTICO, TAPAS'),(3,'BOLSAS','BOLSAS P/BASURA, CAMISETA, ROLLO');
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
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `catalogo_productos`
--

LOCK TABLES `catalogo_productos` WRITE;
/*!40000 ALTER TABLE `catalogo_productos` DISABLE KEYS */;
INSERT INTO `catalogo_productos` VALUES (4,7501133549748,2,'#855','#855 CHAROLA 16X10CM',1,12.50,1,1),(5,1100004155747,3,'600ML','600ML TOPOCHICO AGUA MINERAL',1,15.50,2,1),(6,7501791646482,4,'ECO17','ECO17 BOLSA P/BASURA  CHICA BIODEG',2,25.00,3,1),(7,7501022008171,3,'355ML','355ML MINI LATA PEPSI',1,7.50,2,1),(8,1752666001237,3,'ARM77','ARM77 TOPOCHICO 2LTS NR AGUA MINERAL',1,14.70,2,1),(9,21136010541,3,'20.3FLOZ','20.3FLOZ AGUA MINERAL 600 ML',1,9.00,2,1),(10,7501064196935,3,'NME355','NME355 NEGRA MODELO ESPECIAL LATA 355ML',1,8.50,2,1);
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
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cliente`
--

LOCK TABLES `cliente` WRITE;
/*!40000 ALTER TABLE `cliente` DISABLE KEYS */;
INSERT INTO `cliente` VALUES (1,'Cliente General','foo','foo','foo','28000','1234567894','1234567894','ASD6544EREWT','Foo SA de CV','2019-08-29 01:53:57','2019-08-29 02:54:23');
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
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detalle_entrada`
--

LOCK TABLES `detalle_entrada` WRITE;
/*!40000 ALTER TABLE `detalle_entrada` DISABLE KEYS */;
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
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `documentos`
--

LOCK TABLES `documentos` WRITE;
/*!40000 ALTER TABLE `documentos` DISABLE KEYS */;
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
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `historico_costos`
--

LOCK TABLES `historico_costos` WRITE;
/*!40000 ALTER TABLE `historico_costos` DISABLE KEYS */;
INSERT INTO `historico_costos` VALUES (1,1,6,25.00,'2019-08-08 08:42:31',0),(2,1,7,7.50,'2019-08-10 20:34:46',0),(3,0,2,15.50,'2019-08-24 06:29:35',0),(4,0,2,15.50,'2019-08-24 06:29:51',0),(5,0,0,12.50,'2019-08-24 06:30:04',0),(6,1,1,12.50,'2019-08-24 06:30:26',0),(7,1,1,12.50,'2019-08-24 06:30:53',0),(8,1,2,15.50,'2019-08-24 06:31:09',0),(9,1,8,14.70,'2019-08-24 18:48:12',0),(10,1,4,12.50,'2019-08-24 18:55:56',0),(11,1,6,25.00,'2019-08-24 20:25:43',0),(12,1,9,10.00,'2019-08-24 20:27:42',0),(13,1,10,8.50,'2019-08-27 08:34:22',1),(14,1,9,9.00,'2019-08-27 08:35:16',1);
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
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `historico_preciopublico`
--

LOCK TABLES `historico_preciopublico` WRITE;
/*!40000 ALTER TABLE `historico_preciopublico` DISABLE KEYS */;
INSERT INTO `historico_preciopublico` VALUES (1,4,0,22.25,'2019-08-24 06:53:15',0),(2,4,0,22.25,'2019-08-24 06:53:16',0),(3,4,0,22.25,'2019-08-24 06:53:16',0),(4,4,0,22.25,'2019-08-24 06:53:16',0),(5,5,5,27.59,'2019-08-24 18:59:14',0),(6,5,5,27.59,'2019-08-24 18:59:20',0),(7,5,5,29.91,'2019-08-24 18:59:53',0),(8,9,12,16.60,'2019-08-24 20:50:45',0),(9,5,0,29.91,'2019-08-27 07:17:24',1),(10,10,13,14.11,'2019-08-27 08:37:08',1);
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
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `lineas_documento`
--

LOCK TABLES `lineas_documento` WRITE;
/*!40000 ALTER TABLE `lineas_documento` DISABLE KEYS */;
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
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `marcas`
--

LOCK TABLES `marcas` WRITE;
/*!40000 ALTER TABLE `marcas` DISABLE KEYS */;
INSERT INTO `marcas` VALUES (1,'JAGUAR'),(2,'REYMA'),(3,'TOPOCHICO'),(4,'PLAYTEX');
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
  `Cuidad` tinytext CHARACTER SET latin1 COLLATE latin1_general_ci DEFAULT NULL,
  `Codigo_postal` varchar(45) CHARACTER SET latin1 COLLATE latin1_general_ci DEFAULT NULL,
  `telefono` varchar(45) CHARACTER SET latin1 COLLATE latin1_general_ci DEFAULT NULL,
  `correo` tinytext CHARACTER SET latin1 COLLATE latin1_general_ci DEFAULT NULL,
  `contacto` tinytext CHARACTER SET latin1 COLLATE latin1_general_ci DEFAULT NULL,
  PRIMARY KEY (`idProveedor`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `proveedor`
--

LOCK TABLES `proveedor` WRITE;
/*!40000 ALTER TABLE `proveedor` DISABLE KEYS */;
INSERT INTO `proveedor` VALUES (1,'Plastichupes de colima','Lauro villar #510','Hacienda el centenario','villa de alvarez','28984','3123085596',NULL,'Juan Rivera');
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

-- Dump completed on 2019-08-29 19:33:28
