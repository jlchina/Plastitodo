-- MySQL dump 10.13  Distrib 8.0.16, for Win64 (x86_64)
--
-- Host: localhost    Database: pv-plasticos
-- ------------------------------------------------------
-- Server version	8.0.16

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
 SET NAMES utf8 ;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `usuarios`
--

DROP TABLE IF EXISTS `usuarios`;
CREATE TABLE `usuarios` (
  `id` INT(11) UNSIGNED NOT NULL AUTO_INCREMENT,
  `username` VARCHAR(100) NOT NULL,
  `password` VARCHAR(255) NOT NULL,
  `nombre` VARCHAR(150) NOT NULL,
  `ap_paterno` VARCHAR(100) NOT NULL,
  `ap_materno` VARCHAR(100) NULL,
  PRIMARY KEY (`id`))
COMMENT = 'Tabla de usuarios sistema plastitodo';

INSERT INTO `usuarios` (`username`,`password`,`nombre`,`ap_paterno`) VALUES ('admin','k0hALciYOS16DZX8tiCPXw==','Administrador','Plastitodo')

--
-- Table structure for table `catalogo_productos`
--

DROP TABLE IF EXISTS `catalogo_productos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `catalogo_productos` (
  `codigo_barras` int(11) NOT NULL,
  `descripcion` text,
  `presentacion` text,
  `precio` varchar(45) DEFAULT NULL,
  `marca` tinytext,
  PRIMARY KEY (`codigo_barras`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `catalogo_productos`
--

LOCK TABLES `catalogo_productos` WRITE;
/*!40000 ALTER TABLE `catalogo_productos` DISABLE KEYS */;
/*!40000 ALTER TABLE `catalogo_productos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cliente`
--

DROP TABLE IF EXISTS `cliente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `cliente` (
  `idCliente` int(11) NOT NULL,
  `Nombre` tinytext,
  `Direccion` tinytext,
  `Colonia` tinytext,
  `Cuidad` tinytext,
  `Codigo_postal` varchar(45) DEFAULT NULL,
  `telefono` varchar(45) DEFAULT NULL,
  `email` tinytext,
  PRIMARY KEY (`idCliente`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cliente`
--

LOCK TABLES `cliente` WRITE;
/*!40000 ALTER TABLE `cliente` DISABLE KEYS */;
/*!40000 ALTER TABLE `cliente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cuenta_cobrar`
--

DROP TABLE IF EXISTS `cuenta_cobrar`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `cuenta_cobrar` (
  `folio` int(11) NOT NULL,
  `fecha_vencimiento` date DEFAULT NULL,
  `total` varchar(45) DEFAULT NULL,
  `pagado` varchar(45) DEFAULT NULL,
  `fecha_pago` date DEFAULT NULL,
  `id_cliente` varchar(45) DEFAULT NULL,
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
 SET character_set_client = latin1 ;
CREATE TABLE `cuentas_pagar` (
  `folio_factura` int(11) NOT NULL,
  `fecha_vencimiento` varchar(45) DEFAULT NULL,
  `total` varchar(45) DEFAULT NULL,
  `cuentas_pagadas` varchar(45) DEFAULT NULL,
  `folio_pago` varchar(45) DEFAULT NULL,
  `tipo_pago` varchar(45) DEFAULT NULL,
  `id_proveedor` varchar(45) DEFAULT NULL,
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
 SET character_set_client = latin1 ;
CREATE TABLE `detalle_entrada` (
  `folio` int(11) NOT NULL,
  `id_producto` varchar(45) DEFAULT NULL,
  `costo` varchar(45) DEFAULT NULL,
  `cantidad` varchar(45) DEFAULT NULL,
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
 SET character_set_client = latin1 ;
CREATE TABLE `detalle_salida` (
  `folio_detalle` int(11) NOT NULL,
  `id_producto` varchar(45) DEFAULT NULL,
  `precio` varchar(45) DEFAULT NULL,
  `cantidad` varchar(45) DEFAULT NULL,
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
-- Table structure for table `entradas`
--

DROP TABLE IF EXISTS `entradas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = latin1 ;
CREATE TABLE `entradas` (
  `Folio` int(11) NOT NULL,
  `fecha_entrada` date DEFAULT NULL,
  `id_proveedor` varchar(45) DEFAULT NULL,
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
-- Table structure for table `inventario`
--

DROP TABLE IF EXISTS `inventario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = latin1 ;
CREATE TABLE `inventario` (
  `codigo_barras` int(11) NOT NULL,
  `existencia` varchar(45) DEFAULT NULL,
  `maximo` varchar(45) DEFAULT NULL,
  `minimo` varchar(45) DEFAULT NULL,
  `reorden` varchar(45) DEFAULT NULL,
  `activo` varchar(45) DEFAULT NULL,
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
-- Table structure for table `proveedor`
--

DROP TABLE IF EXISTS `proveedor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = latin1 ;
CREATE TABLE `proveedor` (
  `idProveedor` int(11) NOT NULL,
  `Nombre` tinytext,
  `Direccion` tinytext,
  `Colonia` tinytext,
  `Cuidad` tinytext,
  `Codigo_postal` varchar(45) DEFAULT NULL,
  `telefono` varchar(45) DEFAULT NULL,
  `correo` tinytext,
  `contacto` tinytext,
  PRIMARY KEY (`idProveedor`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `proveedor`
--

LOCK TABLES `proveedor` WRITE;
/*!40000 ALTER TABLE `proveedor` DISABLE KEYS */;
/*!40000 ALTER TABLE `proveedor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `salidas`
--

DROP TABLE IF EXISTS `salidas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = latin1 ;
CREATE TABLE `salidas` (
  `folio_salidas` int(11) NOT NULL,
  `fecha_salida` date DEFAULT NULL,
  `id_cliente` varchar(45) DEFAULT NULL,
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
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-06-29 12:09:20
