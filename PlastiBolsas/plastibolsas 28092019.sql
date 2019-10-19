-- phpMyAdmin SQL Dump
-- version 4.7.0
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 28-09-2019 a las 23:35:55
-- Versión del servidor: 10.1.25-MariaDB
-- Versión de PHP: 7.1.7

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `plastibolsas`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `catalogacion`
--

CREATE TABLE `catalogacion` (
  `id` int(11) UNSIGNED NOT NULL,
  `Gpo_prod` varchar(20) NOT NULL,
  `Id_familia` int(2) NOT NULL,
  `Id_categoria` int(2) NOT NULL,
  `Nom_categoria` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `catalogacion`
--

INSERT INTO `catalogacion` (`id`, `Gpo_prod`, `Id_familia`, `Id_categoria`, `Nom_categoria`) VALUES
(1, '1-1', 1, 1, 'CHAROLA'),
(2, '2-1', 2, 1, 'TERMICO'),
(3, '3-1', 3, 1, 'BOLSA P/BASURA'),
(4, '7-1', 7, 1, 'TRAPEADOR / ESCOBA'),
(5, '7-2', 7, 2, 'ACC. DE LAVADO'),
(6, '7-3', 7, 3, 'JABON LIQUIDO'),
(7, '3-2', 3, 2, 'CAMISETA'),
(8, '1-2', 1, 2, 'PLATO POZOLERO'),
(9, '3-3', 3, 3, 'ROLLO BOLSA'),
(10, '8-1', 8, 1, 'MESA'),
(11, '2-2', 2, 2, 'VASO NORMAL');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `catalogacion_familias`
--

CREATE TABLE `catalogacion_familias` (
  `id_familia` int(11) UNSIGNED NOT NULL,
  `nom_familia` text NOT NULL,
  `descripcion_fam` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `catalogacion_familias`
--

INSERT INTO `catalogacion_familias` (`id_familia`, `nom_familia`, `descripcion_fam`) VALUES
(1, 'PLATOS Y MOLDES', 'PLATOS, CHAROLAS, MOLDES Y CONTENEDORES'),
(2, 'VASOS', 'TERMICOS, PLASTICO, TAPAS'),
(3, 'BOLSAS', 'BOLSAS P/BASURA, CAMISETA, ROLLO'),
(7, 'LIMPIEZA', 'TRAPEADORES, JABON, SUAVIZANTE, ESCOBA, RECOJEDOR'),
(8, 'COCINA', 'PALILLOS, PAPEL ALUMINIO, PAPEL TOALLA');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `catalogo_productos`
--

CREATE TABLE `catalogo_productos` (
  `id` int(11) UNSIGNED NOT NULL,
  `codigo_barras` bigint(14) NOT NULL,
  `marca` int(4) DEFAULT NULL,
  `Modelo` text NOT NULL,
  `descripcion` text,
  `presentacion` int(4) DEFAULT NULL,
  `precio` decimal(5,2) DEFAULT NULL,
  `id_catalogacion` int(11) NOT NULL,
  `id_prov` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `catalogo_productos`
--

INSERT INTO `catalogo_productos` (`id`, `codigo_barras`, `marca`, `Modelo`, `descripcion`, `presentacion`, `precio`, `id_catalogacion`, `id_prov`) VALUES
(4, 7501133549748, 2, '#855', '#855 CHAROLA 16X10CM', 1, '12.50', 1, 1),
(5, 1100004155747, 3, 'TRN8-14', 'TRN8-14 PAQ VASOS TERMICOS #8 20PZAS', 1, '15.50', 2, 2),
(6, 7501791646482, 4, 'ECO17', 'ECO17 BOLSA P/BASURA  CHICA BIODEG', 2, '25.00', 3, 1),
(7, 7501022008171, 3, 'R81035', 'R81035 BOLSA CAMISETA EN ROLLO', 1, '7.50', 7, 2),
(8, 1752666001237, 1, 'ARM77', 'ARM77 PAQUETE VASOS TERMICO #12 14PZAS', 1, '14.70', 2, 1),
(9, 21136010541, 5, 'PO14-AS', 'PO14-AS PLATO HONDO #10 12PZAS', 1, '9.00', 8, 2),
(10, 7501064196935, 3, 'BC715T', 'BC715T BOLSA CELOFAN 7X15', 2, '8.50', 9, 1),
(11, 16240000000000, 2, '1636BRT', '1636BRT ROLLO DE BOLSA 16X36', 2, '16.00', 9, 2),
(12, 7503004624027, 6, 'CUALPA250', 'CUALPA250 PALILLO DENTAL REDONDO C/250', 1, '2.50', 10, 2),
(13, 1, 1, 'RB1636AMR', 'RB1636AMR BOLSA ROLLO 16X36', 2, '23.50', 9, 1),
(14, 2, 2, 'BN710T', 'BN710T ROLLO BOLSA 7X10', 2, '11.30', 9, 2),
(15, 7501952966442, 2, 'VP8', 'VP8 VASO POLIPRO NO. 8 16PZAS', 1, '4.70', 11, 3),
(16, 7501058628503, 1, 'VP20EU', 'VP20EU VASO POLIPRO NO. 20 EU 8PZAS', 1, '6.80', 11, 3),
(17, 7503000123043, 2, 'VP12EU', 'VP12EU VASO POLIPRO NO. 12 EU', 1, '8.10', 11, 4),
(18, 7501952966417, 2, '007 Reyma', '007 Reyma Charola Térmica 23X18', 1, '13.00', 1, 6),
(19, 7501644770012, 2, 'PT9C2D', 'PT9C2D CHAROLA 9 C/2 DIVISIONES', 1, '9.99', 1, 6),
(20, 7750670000604, 3, 'PT9D', 'PT9D CHAROLA #9 DIVISION 23X18', 1, '11.30', 1, 4),
(21, 7502237305185, 1, 'VT6', 'VT6 VASO TERMICO NO. 6 C/24', 1, '10.56', 2, 2),
(22, 621299005110, 1, 'VT1LT', 'VT1LT VASO TERMICO NO. 1 LITRO C/2', 1, '4.30', 2, 2),
(23, 7506198007928, 5, 'PH4', 'PH4 PLATO TERMICO No.PH4', 1, '8.95', 8, 8),
(24, 7501052472195, 2, 'PH8', 'PH8 PLATO TERMICO No.PH8', 1, '7.99', 8, 8),
(25, 610013, 7, 'EM125P', 'EM125P SERVILLETAS 125PZAS', 1, '14.30', 10, 12),
(26, 3, 8, '1T', '1T TRAPEADOR BCO', 1, '21.00', 4, 11),
(27, 4, 8, '1E', '1E ESCOBA BASE PLASTICO', 1, '19.90', 4, 11),
(28, 42339, 7, 'SB100P', 'SB100P Servilleta Blanca 10', 1, '14.55', 10, 12),
(29, 369412, 6, 'C20EB', 'C20EB BOLSA ECOLOGICA P/BASURA 20PZAS', 1, '18.99', 3, 1),
(30, 46340, 9, 'PA15M', 'PA15M PAPEL ALUMINIO 15 MTS', 1, '33.00', 10, 12),
(31, 5, 8, '1R', '1R RECOGEDOR DE PLASTICO', 1, '29.34', 4, 12);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cliente`
--

CREATE TABLE `cliente` (
  `idCliente` int(11) UNSIGNED NOT NULL,
  `Nombre` tinytext COLLATE latin1_general_ci NOT NULL,
  `Direccion` tinytext COLLATE latin1_general_ci NOT NULL,
  `Colonia` tinytext COLLATE latin1_general_ci NOT NULL,
  `Ciudad` tinytext COLLATE latin1_general_ci NOT NULL,
  `Codigo_postal` varchar(45) COLLATE latin1_general_ci NOT NULL,
  `telefono` varchar(45) COLLATE latin1_general_ci NOT NULL,
  `email` tinytext COLLATE latin1_general_ci,
  `rfc` varchar(20) COLLATE latin1_general_ci NOT NULL,
  `razon_social` varchar(115) COLLATE latin1_general_ci NOT NULL,
  `fecha_creacion` int(11) UNSIGNED NOT NULL,
  `fecha_actualizacion` int(11) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;

--
-- Volcado de datos para la tabla `cliente`
--

INSERT INTO `cliente` (`idCliente`, `Nombre`, `Direccion`, `Colonia`, `Ciudad`, `Codigo_postal`, `telefono`, `email`, `rfc`, `razon_social`, `fecha_creacion`, `fecha_actualizacion`) VALUES
(1, 'Cliente General', 'foo', 'foo', 'foo', '28000', '1234567894', '1234567894', 'ASD6544EREWT', 'Foo SA de CV', '2019-08-29 01:53:57', '2019-08-29 02:54:23'),
(2, 'Manuel Alejandro Lopez Santamaria', 'Enrique Castillo', 'Tabachinez', 'Colima', '28983', '3121222221', 'alejandro.lopez.santamaria@hotmail.com', 'LOMS891026Q16', 'Manuel Alejandro ', '2019-08-30 01:14:56', '2019-08-30 01:14:56'),
(3, 'Raul Cordoba Vazquez', 'Caritina Maldonado 1214', 'Tabachinez', 'Colima', '28983', '3121403709', 'rcordoba_v@hotmail.com', 'COV780504756', 'Raul Cordoba', '2019-08-30 01:17:22', '2019-08-30 01:17:22'),
(4, 'Jose Luis China Sotelo', 'Damazo Carrillo', 'Punta Diamante', 'Villa de Alvarez', '28897', '3121324273', 'j.luis.china@gmail.com', 'JLCS880817A58', 'Jose Luis China', '2019-08-30 01:19:58', '2019-08-30 01:19:58'),
(5, 'Alejandro Estrada Hernandez', 'Prisciliano Perez', 'Rancho Blanco', 'Villa de Alvarez', '28789', '3121311383', 'telematik_69@hotmail.com', 'AEHQ789447D47', 'Alejandro Estrada', '2019-08-30 01:22:13', '2019-08-30 01:22:13'),
(6, 'Grupo Arce', 'San Fernando 147', 'Centro', 'Colima', '28000', '31247985336', 'arce.grupo@hotmail.com', 'GARF78965Q34', 'Grupo Arce', '2019-08-30 01:23:18', '2019-08-30 01:23:18'),
(7, 'Alma Celia Ramos Corona', 'Antonio Rodriguez Hernandez 247', 'Centro', 'Colima', '14789', '3124579635', 'alma.ramos@hotmail.com', 'ACRC73256S47', 'Alma Ramos', '2019-08-30 01:25:02', '2019-08-30 01:25:02'),
(8, 'Tania Perez Duarte', 'Parque San Luis', 'Terminales', 'Manzanillo', '89785', '31256789087', 'tania.perez@gmail.com', 'TPDW1234E5', 'Tania Perez', '2019-08-30 01:26:28', '2019-08-30 01:26:28'),
(9, 'Manuel de la Mora Zarate', 'Casimiro Perez', 'Ponce de Leon', 'Morelia', '778965', '3121558979', 'manuel.delamora@yahoo.com', 'MMZE3456G087', 'Manuel Zarate', '2019-08-30 01:27:38', '2019-08-30 01:27:38'),
(10, 'Luis Alvarez Moreno', 'Castillos Ricos', 'La Comarca', 'Colima', '25896', '3123456788', 'luis.alvarez_lo@hotmail.com', 'LAME789652J45', 'Luis Alvarez', '2019-08-30 01:28:50', '2019-08-30 01:28:50'),
(11, 'Iram Morales Lopez', 'Lopez Doriga 4789', 'El yaqui', 'Guadalajara', '987456', '3125897896', 'iram_456@gmail.com', 'IMLW6543K34', 'Iram Morales', '2019-08-30 01:31:05', '2019-08-30 01:31:05'),
(12, 'Pedro Alcantar Iglesias', 'AV. MEXICO 23', 'CENTRO', 'MANZANILLO', '28200', '3121559067', 'pai_90@gmail.com', 'ALIP900204H78', 'DESECHABLES LA COSTA', '2019-08-30 03:21:59', '2019-08-30 03:21:59');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cuentas_pagar`
--

CREATE TABLE `cuentas_pagar` (
  `folio_factura` int(11) NOT NULL,
  `fecha_vencimiento` varchar(45) COLLATE latin1_general_ci DEFAULT NULL,
  `total` varchar(45) COLLATE latin1_general_ci DEFAULT NULL,
  `cuentas_pagadas` varchar(45) COLLATE latin1_general_ci DEFAULT NULL,
  `folio_pago` varchar(45) COLLATE latin1_general_ci DEFAULT NULL,
  `tipo_pago` varchar(45) COLLATE latin1_general_ci DEFAULT NULL,
  `id_proveedor` varchar(45) COLLATE latin1_general_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cuenta_cobrar`
--

CREATE TABLE `cuenta_cobrar` (
  `folio` int(11) UNSIGNED NOT NULL,
  `fecha_vencimiento` date DEFAULT NULL,
  `total` varchar(45) COLLATE latin1_general_ci DEFAULT NULL,
  `pagado` varchar(45) COLLATE latin1_general_ci DEFAULT NULL,
  `fecha_pago` date DEFAULT NULL,
  `id_cliente` varchar(45) COLLATE latin1_general_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalle_entrada`
--

CREATE TABLE `detalle_entrada` (
  `folio` int(11) UNSIGNED NOT NULL,
  `fecha` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `id_producto` varchar(45) COLLATE latin1_general_ci DEFAULT NULL,
  `precio` varchar(45) COLLATE latin1_general_ci DEFAULT NULL,
  `cantidad` varchar(45) COLLATE latin1_general_ci DEFAULT NULL,
  `proveedor` text COLLATE latin1_general_ci NOT NULL,
  `usuario` varchar(20) COLLATE latin1_general_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;

--
-- Volcado de datos para la tabla `detalle_entrada`
--

INSERT INTO `detalle_entrada` (`folio`, `fecha`, `id_producto`, `precio`, `cantidad`, `proveedor`, `usuario`) VALUES
(1, '2019-08-30 03:29:32', '1', '23.50', '100', 'Plastilina de colima', '1'),
(2, '2019-08-30 03:34:31', '1', '23.50', '100', 'Plastilina de colima', '1'),
(3, '2019-08-30 03:37:13', '2', '11.30', '100', 'Plastilina de colima', '1'),
(4, '2019-08-30 03:37:35', '2', '11.30', '50', 'Plastilina de colima', '1'),
(5, '2019-08-30 03:40:41', '16240000000000', '16.00', '132', 'ARTE EXPORTACION S.A. DE C.V.', '1'),
(6, '2019-08-30 04:04:09', '1100004155747', '15.50', '500', 'DISTRIBUIDORA Y COMERCIALIZADORA JAZ SA DE CV', '1'),
(7, '2019-08-30 04:04:37', '7501022008171', '7.50', '400', 'SUMINISTRO MY R SA DE CV', '1'),
(8, '2019-08-30 04:04:38', '7501791646482', '25.00', '147', 'AEDIFICANT, S.A. DE C.V.', '1'),
(9, '2019-08-30 04:05:02', '21136010541', '9.00', '800', 'ACEMAQ SA DE CV', '1'),
(10, '2019-08-30 04:05:34', '16240000000000', '16.00', '50', 'AUTOTRANSPORTES DE CARGA TRESGUERRAS, S.A. DE C.V. SUC. GUADALAJARA-JALISCO', '1'),
(11, '2019-08-30 04:05:36', '1752666001237', '14.70', '101', 'AGROVET, S.A. DE C.V.', '1'),
(12, '2019-08-30 04:06:19', '7501952966442', '4.70', '250', 'AEDIFICANT, S.A. DE C.V.', '1'),
(13, '2019-08-30 04:06:24', '7501064196935', '8.50', '87', 'ARTE EXPORTACION S.A. DE C.V.', '1'),
(14, '2019-08-30 04:06:55', '7503004624027', '2.50', '47', 'AEDIFICANT, S.A. DE C.V.', '1'),
(15, '2019-08-30 04:07:14', '7503000123043', '8.10', '350', 'AUTOEXPRESS ORIENTE, S.A. DE C.V.', '1'),
(16, '2019-08-30 04:07:33', '7501058628503', '6.80', '80', 'DISTRIBUIDORA Y COMERCIALIZADORA JAZ SA DE CV', '1'),
(17, '2019-08-30 04:07:36', '7501644770012', '9.99', '100', 'AGROVET, S.A. DE C.V.', '1'),
(18, '2019-08-30 04:08:01', '7501952966442', '4.70', '147', 'ARROW ELECTRONICS MÉXICO S.A. DE C.V.', '1'),
(19, '2019-08-30 04:08:04', '7502237305185', '10.56', '50', 'ACEROCABLES SA DE CV', '1'),
(20, '2019-08-30 04:08:27', '7750670000604', '11.30', '189', 'ACEMAQ SA DE CV', '1'),
(21, '2019-08-30 04:08:32', '7506198007928', '8.95', '450', 'AROMAS AUTOMOTRICES GUSTO, S.A. DE C.V.', '1'),
(22, '2019-08-30 04:08:48', '621299005110', '4.30', '97', 'SUMINISTRO MY R SA DE CV', '1'),
(23, '2019-08-30 04:08:57', '610013', '14.30', '60', 'ARTE EXPORTACION S.A. DE C.V.', '1'),
(24, '2019-08-30 04:09:11', '7501052472195', '7.99', '77', 'AEDIFICANT, S.A. DE C.V.', '1'),
(25, '2019-08-30 04:09:17', '4', '19.90', '67', 'ARTE EXPORTACION S.A. DE C.V.', '1'),
(26, '2019-08-30 04:09:37', '42339', '14.55', '60', 'AUTOTRANSPORTES DE CARGA TRESGUERRAS, S.A. DE C.V. SUC. GUADALAJARA-JALISCO', '1'),
(27, '2019-08-30 04:09:42', '3', '21.00', '49', 'ARROW ELECTRONICS MÉXICO S.A. DE C.V.', '1'),
(28, '2019-08-30 04:10:18', '42339', '14.55', '78', 'ARTE EXPORTACION S.A. DE C.V.', '1'),
(29, '2019-08-30 04:11:19', '46340', '33.00', '96', 'ACEMAQ SA DE CV', '1'),
(30, '2019-08-31 05:45:05', '5', '29.34', '32', 'AUTOTRANSPORTES DE CARGA TRESGUERRAS, S.A. DE C.V. SUC. GUADALAJARA-JALISCO', '1'),
(31, '2019-08-31 05:45:20', '4', '19.90', '25', 'AUTOTRANSPORTES DE CARGA TRESGUERRAS, S.A. DE C.V. SUC. GUADALAJARA-JALISCO', '1');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalle_salida`
--

CREATE TABLE `detalle_salida` (
  `folio_detalle` int(11) UNSIGNED NOT NULL,
  `id_producto` varchar(45) COLLATE latin1_general_ci DEFAULT NULL,
  `precio` varchar(45) COLLATE latin1_general_ci DEFAULT NULL,
  `cantidad` varchar(45) COLLATE latin1_general_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `documentos`
--

CREATE TABLE `documentos` (
  `id` int(11) UNSIGNED NOT NULL,
  `folio` int(11) UNSIGNED NOT NULL,
  `id_tipo_documento` int(11) NOT NULL,
  `id_cliente` int(11) NOT NULL,
  `nombre` varchar(255) NOT NULL,
  `vendedor` varchar(255) NOT NULL,
  `comentarios` text,
  `subtotal` decimal(5,2) NOT NULL,
  `iva` decimal(5,2) NOT NULL,
  `total` decimal(5,2) NOT NULL,
  `id_usuario` int(11) NOT NULL,
  `fecha_creacion` int(11) UNSIGNED NOT NULL,
  `fecha_actualizacion` int(11) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `documentos`
--

INSERT INTO `documentos` (`id`, `folio`, `id_tipo_documento`, `id_cliente`, `nombre`, `vendedor`, `comentarios`, `subtotal`, `iva`, `total`, `id_usuario`, `fecha_creacion`, `fecha_actualizacion`) VALUES
(1, 1, 2, 1, 'alejandro estrada hdz', 'lupita', 'Llevar a calle prisciliano perez zamora #1277, valle del sol a las 4pm', '751.49', '120.24', '871.72', 1, '2019-08-30 04:44:10', '2019-08-30 04:44:10'),
(2, 1, 1, 1, 'alejandro estrada hdz', 'lupita', 'Llevar a calle prisciliano perez zamora #1277, valle del sol a las 4pm', '751.49', '120.24', '871.72', 1, '2019-08-30 04:46:22', '2019-08-30 04:46:22'),
(3, 2, 1, 1, 'alejandro estrada hdz', 'lupita', 'Llevar a calle prisciliano perez zamora #1277, valle del sol a las 4pm', '751.49', '120.24', '871.72', 1, '2019-08-30 04:54:58', '2019-08-30 04:54:58'),
(4, 2, 2, 4, 'JOSE LUIS CHINA SOTELO', 'PEPE TOÑO', 'EL CLIENTE REALIZO COTIZACION', '95.91', '15.35', '98.20', 1, '2019-08-31 05:51:03', '2019-08-31 05:51:03'),
(5, 3, 2, 4, 'JOSE LUIS CHINA SOTELO', 'PEPE TOÑO', 'EL CLIENTE REALIZO COTIZACION', '95.91', '15.35', '98.20', 1, '2019-08-31 05:52:55', '2019-08-31 05:52:55'),
(6, 4, 2, 1, 'JOSE LUIS CHINA', 'PEPE TOÑO', '', '931.85', '149.10', '999.99', 1, '2019-08-31 12:26:53', '2019-08-31 12:26:53'),
(7, 5, 2, 1, 'JOSE LUIS CHINA SOTELO', 'PEPE TOÑO', '', '38.85', '6.22', '45.07', 1, '2019-08-31 12:31:22', '2019-08-31 12:31:22'),
(8, 6, 2, 1, 'JOSE LUIS CHINA', 'Ventas', '', '36.48', '5.84', '42.32', 1, '2019-08-31 12:35:13', '2019-08-31 12:35:13'),
(9, 7, 2, 1, 'JOSE LUIS CHINA SOTELO', 'PEPE TOÑO', '', '208.84', '33.41', '242.25', 1, '2019-08-31 12:54:13', '2019-08-31 12:54:13'),
(10, 8, 2, 4, 'JOSE LUIS CHINA SOTELO', 'VENDEDOR', 'taquerias el moreño', '999.99', '687.62', '999.99', 1, '2019-09-28 21:03:15', '2019-09-28 21:03:15'),
(11, 9, 2, 4, 'JOSE LUIS CHINA SOTELO', 'VENDEDOR', 'taquerias el moreño', '999.99', '687.62', '999.99', 1, '2019-09-28 21:03:27', '2019-09-28 21:03:27'),
(12, 10, 2, 4, 'JOSE LUIS CHINA', 'a', 'a', '843.00', '134.88', '977.88', 1, '2019-09-28 21:05:44', '2019-09-28 21:05:44'),
(13, 3, 1, 4, 'pedro', 'a', 'a', '16.37', '2.62', '18.99', 1, '2019-09-28 21:06:13', '2019-09-28 21:06:13');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `entradas`
--

CREATE TABLE `entradas` (
  `Folio` int(11) UNSIGNED NOT NULL,
  `fecha_entrada` date DEFAULT NULL,
  `id_proveedor` varchar(45) COLLATE latin1_general_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `estados_documento`
--

CREATE TABLE `estados_documento` (
  `id` int(11) UNSIGNED NOT NULL,
  `nombre` varchar(45) NOT NULL,
  `descripcion` varchar(255) DEFAULT NULL,
  `fecha_creacion` int(11) UNSIGNED NOT NULL,
  `fecha_actualizacion` int(11) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `historico_costos`
--

CREATE TABLE `historico_costos` (
  `id` int(11) UNSIGNED NOT NULL,
  `Id_Prov` int(11) NOT NULL,
  `id_catprod` int(11) NOT NULL,
  `precio_cto` decimal(5,2) NOT NULL,
  `fecha` int(11) UNSIGNED NOT NULL,
  `usuario` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `historico_costos`
--

INSERT INTO `historico_costos` (`id`, `Id_Prov`, `id_catprod`, `precio_cto`, `fecha`, `usuario`) VALUES
(1, 1, 6, '25.00', '2019-08-08 08:42:31', 0),
(2, 1, 7, '7.50', '2019-08-10 20:34:46', 0),
(6, 1, 1, '12.50', '2019-08-24 06:30:26', 0),
(7, 1, 1, '12.50', '2019-08-24 06:30:53', 0),
(8, 1, 2, '15.50', '2019-08-24 06:31:09', 0),
(9, 1, 8, '14.70', '2019-08-24 18:48:12', 0),
(10, 1, 4, '12.50', '2019-08-24 18:55:56', 0),
(11, 1, 6, '25.00', '2019-08-24 20:25:43', 0),
(12, 1, 9, '10.00', '2019-08-24 20:27:42', 0),
(13, 1, 10, '8.50', '2019-08-27 08:34:22', 1),
(14, 1, 9, '9.00', '2019-08-27 08:35:16', 1),
(15, 2, 7, '7.50', '2019-08-30 02:08:20', 1),
(16, 1, 8, '14.70', '2019-08-30 02:09:22', 1),
(17, 2, 5, '15.50', '2019-08-30 02:10:56', 1),
(18, 2, 9, '9.00', '2019-08-30 02:12:34', 1),
(19, 2, 9, '9.00', '2019-08-30 02:13:28', 1),
(20, 2, 11, '16.00', '2019-08-30 02:16:11', 1),
(21, 2, 12, '2.50', '2019-08-30 02:22:43', 1),
(22, 1, 12, '23.50', '2019-08-30 02:25:14', 1),
(23, 1, 10, '8.50', '2019-08-30 02:57:20', 1),
(24, 1, 10, '8.50', '2019-08-30 02:57:39', 1),
(25, 2, 12, '11.30', '2019-08-30 03:00:31', 1),
(26, 3, 15, '4.70', '2019-08-30 03:13:52', 1),
(27, 3, 15, '6.80', '2019-08-30 03:17:31', 1),
(28, 4, 15, '8.10', '2019-08-30 03:19:48', 1),
(29, 6, 15, '13.00', '2019-08-30 03:25:45', 1),
(30, 6, 15, '9.99', '2019-08-30 03:28:16', 1),
(31, 3, 15, '11.30', '2019-08-30 03:30:28', 1),
(32, 4, 20, '11.30', '2019-08-30 03:31:07', 1),
(33, 2, 15, '10.56', '2019-08-30 03:35:16', 1),
(34, 3, 15, '4.30', '2019-08-30 03:37:44', 1),
(35, 0, 22, '4.30', '2019-08-30 03:38:13', 1),
(36, 8, 15, '8.95', '2019-08-30 03:44:21', 1),
(37, 2, 22, '4.30', '2019-08-30 03:45:17', 1),
(38, 8, 15, '7.99', '2019-08-30 03:50:47', 1),
(39, 12, 25, '14.30', '2019-08-30 03:58:35', 1),
(40, 11, 26, '21.00', '2019-08-30 04:00:19', 1),
(41, 11, 27, '19.90', '2019-08-30 04:01:22', 1),
(42, 12, 28, '14.55', '2019-08-30 04:02:48', 1),
(43, 1, 26, '18.99', '2019-08-30 04:06:42', 1),
(44, 12, 30, '33.00', '2019-08-30 04:08:46', 1),
(45, 1, 4, '12.50', '2019-08-30 04:53:56', 1),
(46, 12, 31, '27.30', '2019-08-30 05:06:41', 1),
(47, 12, 31, '29.34', '2019-08-30 05:07:56', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `historico_preciopublico`
--

CREATE TABLE `historico_preciopublico` (
  `id` int(11) UNSIGNED NOT NULL,
  `id_catalogo` int(11) NOT NULL,
  `id_costo` int(11) NOT NULL,
  `p_publico` decimal(6,2) NOT NULL,
  `fecha` int(11) UNSIGNED NOT NULL,
  `id_usuario` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `historico_preciopublico`
--

INSERT INTO `historico_preciopublico` (`id`, `id_catalogo`, `id_costo`, `p_publico`, `fecha`, `id_usuario`) VALUES
(5, 5, 5, '27.59', '2019-08-24 18:59:14', 0),
(6, 5, 5, '27.59', '2019-08-24 18:59:20', 0),
(7, 5, 5, '29.91', '2019-08-24 18:59:53', 0),
(8, 9, 12, '16.60', '2019-08-24 20:50:45', 0),
(9, 5, 0, '29.91', '2019-08-27 07:17:24', 1),
(10, 10, 13, '14.11', '2019-08-27 08:37:08', 1),
(18, 14, 0, '18.76', '2019-08-30 04:29:00', 1),
(19, 14, 0, '20.00', '2019-08-30 04:29:24', 1),
(20, 26, 43, '30.00', '2019-08-30 04:30:33', 1),
(21, 14, 0, '20.11', '2019-08-30 04:34:20', 1),
(22, 28, 43, '30.00', '2019-08-30 04:58:01', 1),
(23, 30, 44, '47.85', '2019-08-30 04:58:33', 1),
(24, 25, 39, '19.45', '2019-08-30 04:59:00', 1),
(25, 9, 19, '19.45', '2019-08-30 04:59:25', 1),
(26, 22, 37, '19.45', '2019-08-30 05:00:02', 1),
(27, 5, 17, '22.48', '2019-08-30 05:00:24', 1),
(28, 8, 16, '22.48', '2019-08-30 05:00:50', 1),
(29, 7, 15, '10.20', '2019-08-30 05:01:09', 1),
(30, 7, 15, '10.20', '2019-08-30 05:01:33', 1),
(31, 16, 15, '10.20', '2019-08-30 05:01:56', 1),
(32, 10, 24, '12.33', '2019-08-30 05:02:33', 1),
(33, 19, 24, '12.33', '2019-08-30 05:02:49', 1),
(34, 6, 11, '41.50', '2019-08-30 05:03:06', 1),
(35, 18, 11, '18.85', '2019-08-30 05:03:28', 1),
(36, 21, 11, '16.37', '2019-08-30 05:03:46', 1),
(37, 11, 20, '21.00', '2019-08-30 05:03:57', 1),
(38, 17, 11, '16.37', '2019-08-30 05:04:05', 1),
(39, 12, 25, '16.37', '2019-08-30 05:04:20', 1),
(40, 20, 32, '17.51', '2019-08-30 05:04:24', 1),
(41, 23, 25, '16.37', '2019-08-30 05:04:37', 1),
(42, 31, 47, '68.07', '2019-08-31 05:41:44', 1),
(43, 24, 0, '16.86', '2019-09-28 21:05:03', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `inventario`
--

CREATE TABLE `inventario` (
  `codigo_barras` bigint(14) NOT NULL,
  `existencia` int(45) DEFAULT NULL,
  `maximo` int(45) DEFAULT NULL,
  `minimo` int(45) DEFAULT NULL,
  `reorden` varchar(45) COLLATE latin1_general_ci DEFAULT NULL,
  `activo` varchar(45) COLLATE latin1_general_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;

--
-- Volcado de datos para la tabla `inventario`
--

INSERT INTO `inventario` (`codigo_barras`, `existencia`, `maximo`, `minimo`, `reorden`, `activo`) VALUES
(1, 200, 0, 0, '', ''),
(2, 81, 0, 0, '', ''),
(3, 49, 0, 0, '', ''),
(4, 92, 0, 0, '', ''),
(5, 32, 0, 0, '', ''),
(42339, 138, 0, 0, '', ''),
(46340, 96, 0, 0, '', ''),
(610013, 60, 0, 0, '', ''),
(21136010541, 800, 0, 0, '', ''),
(621299005110, 97, 0, 0, '', ''),
(1100004155747, 488, 0, 0, '', ''),
(1752666001237, 101, 0, 0, '', ''),
(7501022008171, 400, 0, 0, '', ''),
(7501052472195, 77, 0, 0, '', ''),
(7501058628503, 80, 0, 0, '', ''),
(7501064196935, 51, 0, 0, '', ''),
(7501644770012, 100, 0, 0, '', ''),
(7501791646482, 147, 0, 0, '', ''),
(7501952966442, 397, 0, 0, '', ''),
(7502237305185, 50, 0, 0, '', ''),
(7503000123043, 350, 0, 0, '', ''),
(7503004624027, 47, 0, 0, '', ''),
(7506198007928, 450, 0, 0, '', ''),
(7750670000604, 189, 0, 0, '', ''),
(16240000000000, 182, 0, 0, '', '');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `lineas_documento`
--

CREATE TABLE `lineas_documento` (
  `id` int(11) UNSIGNED NOT NULL,
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
  `fecha_creacion` int(11) UNSIGNED NOT NULL,
  `fecha_actualizacion` int(11) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `lineas_documento`
--

INSERT INTO `lineas_documento` (`id`, `id_documento`, `id_tipo_documento`, `id_producto`, `cantidad`, `id_presentacion`, `precio`, `descuento`, `id_iva`, `subtotal`, `iva`, `total`, `fecha_creacion`, `fecha_actualizacion`) VALUES
(1, 1, 2, 5, '4.00', 1, '29.91', '0.00', 1, '119.64', '19.14', '138.78', '2019-08-30 04:44:10', '2019-08-30 04:44:10'),
(2, 1, 2, 14, '23.00', 2, '20.11', '0.00', 1, '462.53', '74.00', '536.53', '2019-08-30 04:44:10', '2019-08-30 04:44:10'),
(3, 1, 2, 10, '12.00', 2, '14.11', '0.00', 1, '169.32', '27.09', '196.41', '2019-08-30 04:44:10', '2019-08-30 04:44:10'),
(4, 2, 1, 5, '4.00', 1, '29.91', '7.00', 1, '119.64', '19.14', '138.78', '2019-08-30 04:46:22', '2019-08-30 04:46:22'),
(5, 2, 1, 14, '23.00', 2, '20.11', '7.00', 1, '462.53', '74.00', '536.53', '2019-08-30 04:46:22', '2019-08-30 04:46:22'),
(6, 2, 1, 10, '12.00', 2, '14.11', '7.00', 1, '169.32', '27.09', '196.41', '2019-08-30 04:46:22', '2019-08-30 04:46:22'),
(7, 3, 1, 5, '4.00', 1, '29.91', '7.00', 1, '119.64', '19.14', '138.78', '2019-08-30 04:54:58', '2019-08-30 04:54:58'),
(8, 3, 1, 14, '23.00', 2, '20.11', '7.00', 1, '462.53', '74.00', '536.53', '2019-08-30 04:54:58', '2019-08-30 04:54:58'),
(9, 3, 1, 10, '12.00', 2, '14.11', '7.00', 1, '169.32', '27.09', '196.41', '2019-08-30 04:54:58', '2019-08-30 04:54:58'),
(10, 4, 2, 12, '3.00', 1, '16.37', '0.00', 1, '49.11', '7.86', '56.97', '2019-08-31 05:51:03', '2019-08-31 05:51:03'),
(11, 5, 2, 12, '3.00', 1, '16.37', '0.00', 1, '49.11', '7.86', '56.97', '2019-08-31 05:52:55', '2019-08-31 05:52:55'),
(12, 6, 2, 12, '30.00', 1, '16.37', '0.00', 1, '491.10', '78.58', '569.68', '2019-08-31 12:26:53', '2019-08-31 12:26:53'),
(13, 7, 2, 12, '1.00', 1, '16.37', '0.00', 1, '16.37', '2.62', '18.99', '2019-08-31 12:31:22', '2019-08-31 12:31:22'),
(14, 8, 2, 12, '1.00', 1, '16.37', '0.00', 1, '16.37', '2.62', '18.99', '2019-08-31 12:35:13', '2019-08-31 12:35:13'),
(15, 9, 2, 12, '7.00', 1, '16.37', '0.00', 1, '114.59', '18.33', '132.92', '2019-08-31 12:54:13', '2019-08-31 12:54:13'),
(16, 10, 2, 11, '20.00', 2, '21.00', '0.00', 1, '420.00', '67.20', '487.20', '2019-09-28 21:03:15', '2019-09-28 21:03:15'),
(17, 11, 2, 11, '20.00', 2, '21.00', '0.00', 1, '420.00', '67.20', '487.20', '2019-09-28 21:03:27', '2019-09-28 21:03:27'),
(18, 12, 2, 24, '50.00', 1, '16.86', '0.00', 1, '843.00', '134.88', '977.88', '2019-09-28 21:05:44', '2019-09-28 21:05:44'),
(19, 13, 1, 23, '1.00', 1, '16.37', '0.00', 1, '16.37', '2.62', '18.99', '2019-09-28 21:06:13', '2019-09-28 21:06:13');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `marcas`
--

CREATE TABLE `marcas` (
  `id` int(11) UNSIGNED NOT NULL,
  `marca` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `marcas`
--

INSERT INTO `marcas` (`id`, `marca`) VALUES
(1, 'JAGUAR'),
(2, 'REYMA'),
(3, 'ECOSHELL'),
(4, 'PLAYTEX'),
(5, 'CLIM'),
(6, 'PINGUINO'),
(7, 'ECONOMAX'),
(8, 'ND'),
(9, 'REYNOLDS');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `modulos`
--

CREATE TABLE `modulos` (
  `id` int(11) UNSIGNED NOT NULL,
  `nombre` varchar(80) NOT NULL,
  `descripcion` varchar(80) NOT NULL,
  `tiene_secciones` tinyint(4) NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `modulos`
--

INSERT INTO `modulos` (`id`, `nombre`, `descripcion`, `tiene_secciones`) VALUES
(1, 'Usuarios', 'Modulo de usuarios del sistema', 0),
(2, 'Perfiles', 'Modulo de perfiles del sistema', 0),
(3, 'Clientes', 'Modulo de clientes del sistema', 1),
(4, 'Proveedores', 'Modulo de proveedores del sistema', 1),
(5, 'Productos', 'Modulo de productos del sistema', 1),
(6, 'Inventario', 'Modulo de inventario', 1),
(7, 'Ventas', 'Modulo de ventas', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `perfiles`
--

CREATE TABLE `perfiles` (
  `id` int(11) UNSIGNED NOT NULL,
  `nombre` varchar(80) NOT NULL,
  `descripcion` varchar(80) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `perfiles`
--

INSERT INTO `perfiles` (`id`, `nombre`, `descripcion`) VALUES
(1, 'Administrador', 'Administrador del sistema'),
(2, 'Ventas', 'Ventas en caja'),
(3, 'Almacenista', 'Encargados de almacen'),
(4, 'Compras', 'Encargado de compras');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `presentacion_prod`
--

CREATE TABLE `presentacion_prod` (
  `id_pp` int(11) UNSIGNED NOT NULL,
  `presentacion` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `presentacion_prod`
--

INSERT INTO `presentacion_prod` (`id_pp`, `presentacion`) VALUES
(1, 'PZA'),
(2, 'KG'),
(3, 'LTS');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `proveedor`
--

CREATE TABLE `proveedor` (
  `idProveedor` int(11) UNSIGNED NOT NULL,
  `Nombre` tinytext CHARACTER SET latin1 COLLATE latin1_general_ci,
  `Direccion` tinytext CHARACTER SET latin1 COLLATE latin1_general_ci,
  `Colonia` tinytext CHARACTER SET latin1 COLLATE latin1_general_ci,
  `Ciudad` tinytext CHARACTER SET latin1 COLLATE latin1_general_ci,
  `Codigo_postal` varchar(45) CHARACTER SET latin1 COLLATE latin1_general_ci DEFAULT NULL,
  `telefono` varchar(45) CHARACTER SET latin1 COLLATE latin1_general_ci DEFAULT NULL,
  `correo` tinytext CHARACTER SET latin1 COLLATE latin1_general_ci,
  `contacto` tinytext CHARACTER SET latin1 COLLATE latin1_general_ci
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `proveedor`
--

INSERT INTO `proveedor` (`idProveedor`, `Nombre`, `Direccion`, `Colonia`, `Ciudad`, `Codigo_postal`, `telefono`, `correo`, `contacto`) VALUES
(1, 'Plastilina de colima', 'Lauro villar #510', 'Hacienda el centenario', 'villa de alvarez', '28984', '3123085596', NULL, 'Juan Rivera'),
(2, 'DISTRIBUIDORA Y COMERCIALIZADORA JAZ SA DE CV', 'Cerrada del Agua 1, Los Reyes', 'Centro', 'Reyes Acaquilpan', '56400', '55 5855 8902', 'comercializadora-jaz.contacto@gmail.com', 'Ruiz martinez'),
(3, 'SUMINISTRO MY R SA DE CV', 'PLOMO No. 204', 'FIDEICOMISO CIUDAD INDUSTRIAL', 'TABASCO', '86010', '(044)9931407537', 'myr.contacto@gmail.com', 'Maria Gonzalez'),
(4, 'ACEMAQ SA DE CV', 'GONZALEZ GALLO No. 634', 'GONZALEZ GALLO', 'JALISCO', '44430', '(33 )37932400', 'acemaq@att.net.mx', 'Gregoria Maldonado'),
(5, 'AUTOTRANSPORTES DE CARGA TRESGUERRAS, S.A. DE C.V. SUC. GUADALAJARA-JALISCO', '1 No. 1375', 'GONZALEZ GALLO', 'GUADALAJARA', '44430', '(333 )8372870', 'aandrade@tresguerras.ocm.mx', 'Jose China'),
(6, 'AEDIFICANT, S.A. DE C.V.', 'SANTA RITA No. 60', 'JARDINES DE SAN IGNACIO', 'ZAPOPAN', '45040', '(33 )33434311', 'aedificant@hotmail.com', 'Alejandro Santamaria'),
(7, 'ARROW ELECTRONICS MÉXICO S.A. DE C.V.', 'AVIACION No. 3800', 'SAN JUAN DE OCOTAN', 'ZAPOPAN', '45019', '(0133)37773113', 'cgonzalez@arrowmx.com', 'Alejandro Estrada'),
(8, 'AUTOEXPRESS ORIENTE, S.A. DE C.V.', 'PEMEX No. 267 ', 'SAN PEDRITO', 'SAN PEDRO TLAQUEPAQUE', '45625', '(33 )600121', 'autoexpress.oriente@hotmail.com', 'Gerardo Lopez'),
(9, 'AGROVET, S.A. DE C.V.', 'JUAN DE LA BARRERA 3485', 'PARQUE INDUSTRIAL EL ALAMO', 'GUADALAJARA', '44490', '(33 )3670-1425 3670-6033', 'agrovet.ventas@hotmail.com', 'JOSE DE JESUS SUAREZ'),
(10, 'ACEROCABLES SA DE CV', 'LAZARO CARDENAS No. 1440', 'BARRIO ALTO', 'SAN PEDRO TLAQUEPAQUE', '45590', '(33 )31341234', 'aceroscables@gmail.com', 'Roberto Gomez'),
(11, 'AROMAS AUTOMOTRICES GUSTO, S.A. DE C.V.', 'CARDENAL No. 1029 ', 'MORELOS', 'GUADALAJARA', '44910', '(33 )3812-2959', 'info.aromas@aromasgusto.com', 'Carolina Reyes'),
(12, 'ARTE EXPORTACION S.A. DE C.V.', 'JUAREZ No. 20', 'TLAQUEPAQUE CENTRO', 'GUADALAJARA', '45500', '(33 )36359394', 'artxport@foreigner.class.udg.mx', 'JAZMIN LOPEZ MENDEZ');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `relacion_perfiles_modulos`
--

CREATE TABLE `relacion_perfiles_modulos` (
  `id` int(11) UNSIGNED NOT NULL,
  `id_perfil` int(11) NOT NULL,
  `id_modulo` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `relacion_perfiles_modulos`
--

INSERT INTO `relacion_perfiles_modulos` (`id`, `id_perfil`, `id_modulo`) VALUES
(7, 1, 7),
(32, 1, 1),
(33, 1, 2),
(34, 1, 3),
(35, 1, 4),
(36, 1, 5),
(37, 1, 6),
(40, 3, 6),
(41, 2, 7),
(42, 4, 4),
(43, 4, 5);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `relacion_perfiles_secciones`
--

CREATE TABLE `relacion_perfiles_secciones` (
  `id` int(11) UNSIGNED NOT NULL,
  `id_perfil` int(11) NOT NULL,
  `id_seccion` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `relacion_perfiles_secciones`
--

INSERT INTO `relacion_perfiles_secciones` (`id`, `id_perfil`, `id_seccion`) VALUES
(1, 1, 1),
(2, 1, 2),
(3, 1, 3),
(4, 1, 4),
(5, 1, 5),
(6, 1, 6);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `salidas`
--

CREATE TABLE `salidas` (
  `folio_salidas` int(11) UNSIGNED NOT NULL,
  `fecha_salida` date DEFAULT NULL,
  `id_cliente` varchar(45) COLLATE latin1_general_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `secciones`
--

CREATE TABLE `secciones` (
  `id` int(11) UNSIGNED NOT NULL,
  `nombre` varchar(80) NOT NULL,
  `descripcion` varchar(80) NOT NULL,
  `id_modulo` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `secciones`
--

INSERT INTO `secciones` (`id`, `nombre`, `descripcion`, `id_modulo`) VALUES
(1, 'Lista', 'Lista de clientes', 3),
(2, 'Crear', 'Crar Nuevo cliente', 3),
(3, 'Lista', 'Lista de proveedores', 4),
(4, 'Crear', 'Crear nuevo proveedor', 4),
(5, 'Lista', 'Lista de productos', 5),
(6, 'Crear', 'Crear nuevo producto', 5);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tipos_documento`
--

CREATE TABLE `tipos_documento` (
  `id` int(11) UNSIGNED NOT NULL,
  `nombre` varchar(45) NOT NULL,
  `descripcion` varchar(255) DEFAULT NULL,
  `fecha_creacion` int(11) UNSIGNED NOT NULL,
  `fecha_actualizacion` int(11) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tipos_documento`
--

INSERT INTO `tipos_documento` (`id`, `nombre`, `descripcion`, `fecha_creacion`, `fecha_actualizacion`) VALUES
(1, 'Nota', 'Nota de venta', '2019-08-23 21:47:16', '2019-08-23 21:47:16'),
(2, 'Orden', 'Orden de venta', '2019-08-23 21:47:16', '2019-08-23 21:47:16');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuarios`
--

CREATE TABLE `usuarios` (
  `id` int(11) UNSIGNED NOT NULL,
  `username` varchar(100) NOT NULL,
  `password` varchar(255) NOT NULL,
  `nombre` varchar(150) NOT NULL,
  `ap_paterno` varchar(100) NOT NULL,
  `ap_materno` varchar(100) DEFAULT NULL,
  `id_perfil` int(11) NOT NULL,
  `create` int(11) UNSIGNED NOT NULL,
  `updated` int(11) UNSIGNED NOT NULL,
  `estatus` tinyint(1) DEFAULT '1'
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COMMENT='Tabla de usuarios sistema plastitodo';

--
-- Volcado de datos para la tabla `usuarios`
--

INSERT INTO `usuarios` (`id`, `username`, `password`, `nombre`, `ap_paterno`, `ap_materno`, `id_perfil`, `create`, `updated`, `estatus`) VALUES
(1, 'admin', 'k0hALciYOS16DZX8tiCPXw==', 'Administrador', 'Plastitodo', NULL, 1, '2019-08-03 16:10:11', '2019-08-03 16:10:11', 1),
(2, 'AESTRADA', '5fAuwv60FYZVJujfo6Tv6w==', 'Alejandro', 'Estrada', 'Hernandez', 1, '2019-08-03 16:10:11', '2019-08-03 16:10:11', 1),
(3, 'ventas1', 'gnzLDuqKcGxMNKFokfhOew==', 'Caja 1', 'Ventas', ' ', 2, '2019-08-03 16:27:50', '2019-08-03 16:27:50', 1),
(4, 'cord', 'pf2tnef686BJKBK5y4GNhQ==', 'raul', 'cordova', 'vazquez', 3, '2019-08-03 17:45:00', '2019-08-03 17:45:00', 1);

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `catalogacion`
--
ALTER TABLE `catalogacion`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `catalogacion_familias`
--
ALTER TABLE `catalogacion_familias`
  ADD PRIMARY KEY (`id_familia`);

--
-- Indices de la tabla `catalogo_productos`
--
ALTER TABLE `catalogo_productos`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `cliente`
--
ALTER TABLE `cliente`
  ADD PRIMARY KEY (`idCliente`);

--
-- Indices de la tabla `cuentas_pagar`
--
ALTER TABLE `cuentas_pagar`
  ADD PRIMARY KEY (`folio_factura`);

--
-- Indices de la tabla `cuenta_cobrar`
--
ALTER TABLE `cuenta_cobrar`
  ADD PRIMARY KEY (`folio`);

--
-- Indices de la tabla `detalle_entrada`
--
ALTER TABLE `detalle_entrada`
  ADD PRIMARY KEY (`folio`);

--
-- Indices de la tabla `detalle_salida`
--
ALTER TABLE `detalle_salida`
  ADD PRIMARY KEY (`folio_detalle`);

--
-- Indices de la tabla `documentos`
--
ALTER TABLE `documentos`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `entradas`
--
ALTER TABLE `entradas`
  ADD PRIMARY KEY (`Folio`);

--
-- Indices de la tabla `estados_documento`
--
ALTER TABLE `estados_documento`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `historico_costos`
--
ALTER TABLE `historico_costos`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `historico_preciopublico`
--
ALTER TABLE `historico_preciopublico`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `inventario`
--
ALTER TABLE `inventario`
  ADD PRIMARY KEY (`codigo_barras`);

--
-- Indices de la tabla `lineas_documento`
--
ALTER TABLE `lineas_documento`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `marcas`
--
ALTER TABLE `marcas`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `modulos`
--
ALTER TABLE `modulos`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `perfiles`
--
ALTER TABLE `perfiles`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `presentacion_prod`
--
ALTER TABLE `presentacion_prod`
  ADD PRIMARY KEY (`id_pp`);

--
-- Indices de la tabla `proveedor`
--
ALTER TABLE `proveedor`
  ADD PRIMARY KEY (`idProveedor`);

--
-- Indices de la tabla `relacion_perfiles_modulos`
--
ALTER TABLE `relacion_perfiles_modulos`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `relacion_perfiles_secciones`
--
ALTER TABLE `relacion_perfiles_secciones`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `salidas`
--
ALTER TABLE `salidas`
  ADD PRIMARY KEY (`folio_salidas`);

--
-- Indices de la tabla `secciones`
--
ALTER TABLE `secciones`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `tipos_documento`
--
ALTER TABLE `tipos_documento`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `catalogacion`
--
ALTER TABLE `catalogacion`
  MODIFY `id` int(11) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;
--
-- AUTO_INCREMENT de la tabla `catalogacion_familias`
--
ALTER TABLE `catalogacion_familias`
  MODIFY `id_familia` int(11) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;
--
-- AUTO_INCREMENT de la tabla `catalogo_productos`
--
ALTER TABLE `catalogo_productos`
  MODIFY `id` int(11) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=32;
--
-- AUTO_INCREMENT de la tabla `cliente`
--
ALTER TABLE `cliente`
  MODIFY `idCliente` int(11) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;
--
-- AUTO_INCREMENT de la tabla `cuenta_cobrar`
--
ALTER TABLE `cuenta_cobrar`
  MODIFY `folio` int(11) UNSIGNED NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `detalle_entrada`
--
ALTER TABLE `detalle_entrada`
  MODIFY `folio` int(11) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=32;
--
-- AUTO_INCREMENT de la tabla `detalle_salida`
--
ALTER TABLE `detalle_salida`
  MODIFY `folio_detalle` int(11) UNSIGNED NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `documentos`
--
ALTER TABLE `documentos`
  MODIFY `id` int(11) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;
--
-- AUTO_INCREMENT de la tabla `entradas`
--
ALTER TABLE `entradas`
  MODIFY `Folio` int(11) UNSIGNED NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `estados_documento`
--
ALTER TABLE `estados_documento`
  MODIFY `id` int(11) UNSIGNED NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `historico_costos`
--
ALTER TABLE `historico_costos`
  MODIFY `id` int(11) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=48;
--
-- AUTO_INCREMENT de la tabla `historico_preciopublico`
--
ALTER TABLE `historico_preciopublico`
  MODIFY `id` int(11) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=44;
--
-- AUTO_INCREMENT de la tabla `lineas_documento`
--
ALTER TABLE `lineas_documento`
  MODIFY `id` int(11) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;
--
-- AUTO_INCREMENT de la tabla `marcas`
--
ALTER TABLE `marcas`
  MODIFY `id` int(11) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;
--
-- AUTO_INCREMENT de la tabla `modulos`
--
ALTER TABLE `modulos`
  MODIFY `id` int(11) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
--
-- AUTO_INCREMENT de la tabla `perfiles`
--
ALTER TABLE `perfiles`
  MODIFY `id` int(11) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT de la tabla `presentacion_prod`
--
ALTER TABLE `presentacion_prod`
  MODIFY `id_pp` int(11) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT de la tabla `proveedor`
--
ALTER TABLE `proveedor`
  MODIFY `idProveedor` int(11) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;
--
-- AUTO_INCREMENT de la tabla `relacion_perfiles_modulos`
--
ALTER TABLE `relacion_perfiles_modulos`
  MODIFY `id` int(11) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=44;
--
-- AUTO_INCREMENT de la tabla `relacion_perfiles_secciones`
--
ALTER TABLE `relacion_perfiles_secciones`
  MODIFY `id` int(11) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
--
-- AUTO_INCREMENT de la tabla `salidas`
--
ALTER TABLE `salidas`
  MODIFY `folio_salidas` int(11) UNSIGNED NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `secciones`
--
ALTER TABLE `secciones`
  MODIFY `id` int(11) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
--
-- AUTO_INCREMENT de la tabla `tipos_documento`
--
ALTER TABLE `tipos_documento`
  MODIFY `id` int(11) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  MODIFY `id` int(11) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
