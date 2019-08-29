-- phpMyAdmin SQL Dump
-- version 4.9.0.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 28-08-2019 a las 07:16:08
-- Versión del servidor: 10.3.16-MariaDB
-- Versión de PHP: 7.1.30

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
  `id` int(11) NOT NULL,
  `Gpo_prod` varchar(20) NOT NULL,
  `Id_familia` int(2) NOT NULL,
  `Id_categoria` int(2) NOT NULL,
  `Nom_categoria` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `catalogacion`
--


-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `catalogacion_familias`
--

CREATE TABLE `catalogacion_familias` (
  `id_familia` int(11) NOT NULL,
  `nom_familia` text NOT NULL,
  `descripcion_fam` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `catalogacion_familias`
--


-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `catalogo_productos`
--

CREATE TABLE `catalogo_productos` (
  `id` int(11) UNSIGNED NOT NULL,
  `codigo_barras` bigint(14) NOT NULL,
  `marca` int(4) DEFAULT NULL,
  `Modelo` text NOT NULL,
  `descripcion` text DEFAULT NULL,
  `presentacion` int(4) DEFAULT NULL,
  `precio` decimal(5,2) DEFAULT NULL,
  `id_catalogacion` int(11) NOT NULL,
  `id_prov` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `catalogo_productos`
--


-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cliente`
--

CREATE TABLE `cliente` (
  `idCliente` int(11) NOT NULL,
  `Nombre` tinytext COLLATE latin1_general_ci DEFAULT NULL,
  `Direccion` tinytext COLLATE latin1_general_ci DEFAULT NULL,
  `Colonia` tinytext COLLATE latin1_general_ci DEFAULT NULL,
  `Ciudad` tinytext COLLATE latin1_general_ci DEFAULT NULL,
  `Codigo_postal` varchar(45) COLLATE latin1_general_ci DEFAULT NULL,
  `telefono` varchar(45) COLLATE latin1_general_ci DEFAULT NULL,
  `email` tinytext COLLATE latin1_general_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;

--
-- Volcado de datos para la tabla `cliente`
--

INSERT INTO `cliente` (`idCliente`, `Nombre`, `Direccion`, `Colonia`, `Ciudad`, `Codigo_postal`, `telefono`, `email`) VALUES
(1, 'Cliente General', 'foo', 'foo', 'foo', '28000', '1234567894', 'test@foo.com');

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
  `folio` int(11) NOT NULL,
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
  `folio` int(11) NOT NULL,
  `fecha` timestamp NOT NULL DEFAULT current_timestamp(),
  `id_producto` varchar(45) COLLATE latin1_general_ci DEFAULT NULL,
  `precio` varchar(45) COLLATE latin1_general_ci DEFAULT NULL,
  `cantidad` varchar(45) COLLATE latin1_general_ci DEFAULT NULL,
  `proveedor` text COLLATE latin1_general_ci NOT NULL,
  `usuario` varchar(20) COLLATE latin1_general_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalle_salida`
--

CREATE TABLE `detalle_salida` (
  `folio_detalle` int(11) NOT NULL,
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
  `comentarios` text DEFAULT NULL,
  `subtotal` decimal(5,2) NOT NULL,
  `iva` decimal(5,2) NOT NULL,
  `total` decimal(5,2) NOT NULL,
  `id_usuario` int(11) NOT NULL,
  `fecha_creacion` timestamp NULL DEFAULT current_timestamp(),
  `fecha_actualizacion` timestamp NULL DEFAULT current_timestamp() ON UPDATE current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `entradas`
--

CREATE TABLE `entradas` (
  `Folio` int(11) NOT NULL,
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
  `fecha_creacion` timestamp NULL DEFAULT current_timestamp(),
  `fecha_actualizacion` timestamp NULL DEFAULT current_timestamp() ON UPDATE current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `historico_costos`
--

CREATE TABLE `historico_costos` (
  `id` int(11) NOT NULL,
  `Id_Prov` int(11) NOT NULL,
  `id_catprod` int(11) NOT NULL,
  `precio_cto` decimal(5,2) NOT NULL,
  `fecha` timestamp NOT NULL DEFAULT current_timestamp(),
  `usuario` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `historico_costos`
--


-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `historico_preciopublico`
--

CREATE TABLE `historico_preciopublico` (
  `id` int(11) NOT NULL,
  `id_catalogo` int(11) NOT NULL,
  `id_costo` int(11) NOT NULL,
  `p_publico` decimal(6,2) NOT NULL,
  `fecha` timestamp NOT NULL DEFAULT current_timestamp(),
  `id_usuario` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `historico_preciopublico`
--


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
  `fecha_creacion` timestamp NULL DEFAULT current_timestamp(),
  `fecha_actualizacion` timestamp NULL DEFAULT current_timestamp() ON UPDATE current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `marcas`
--

CREATE TABLE `marcas` (
  `id` int(11) NOT NULL,
  `marca` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `marcas`
--


-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `modulos`
--

CREATE TABLE `modulos` (
  `id` int(11) UNSIGNED NOT NULL,
  `nombre` varchar(80) NOT NULL,
  `descripcion` varchar(80) NOT NULL,
  `tiene_secciones` tinyint(4) NOT NULL DEFAULT 0
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
(1, 'Administrador', 'Administrador del sistema');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `presentacion_prod`
--

CREATE TABLE `presentacion_prod` (
  `id_pp` int(11) NOT NULL,
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
  `idProveedor` int(11) NOT NULL,
  `Nombre` tinytext CHARACTER SET latin1 COLLATE latin1_general_ci DEFAULT NULL,
  `Direccion` tinytext CHARACTER SET latin1 COLLATE latin1_general_ci DEFAULT NULL,
  `Colonia` tinytext CHARACTER SET latin1 COLLATE latin1_general_ci DEFAULT NULL,
  `Cuidad` tinytext CHARACTER SET latin1 COLLATE latin1_general_ci DEFAULT NULL,
  `Codigo_postal` varchar(45) CHARACTER SET latin1 COLLATE latin1_general_ci DEFAULT NULL,
  `telefono` varchar(45) CHARACTER SET latin1 COLLATE latin1_general_ci DEFAULT NULL,
  `correo` tinytext CHARACTER SET latin1 COLLATE latin1_general_ci DEFAULT NULL,
  `contacto` tinytext CHARACTER SET latin1 COLLATE latin1_general_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `proveedor`
--


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
(30, 3, 5),
(31, 3, 6),
(32, 1, 1),
(33, 1, 2),
(34, 1, 3),
(35, 1, 4),
(36, 1, 5),
(37, 1, 6),
(38, 3, 5);

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
(6, 1, 6),
(7, 1, 7);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `salidas`
--

CREATE TABLE `salidas` (
  `folio_salidas` int(11) NOT NULL,
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
(6, 'Crear', 'Crear nuevo producto', 5),
(7, 'Crear', 'Crear ventas', 5);


-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tipos_documento`
--

CREATE TABLE `tipos_documento` (
  `id` int(11) UNSIGNED NOT NULL,
  `nombre` varchar(45) NOT NULL,
  `descripcion` varchar(255) DEFAULT NULL,
  `fecha_creacion` timestamp NULL DEFAULT current_timestamp(),
  `fecha_actualizacion` timestamp NULL DEFAULT current_timestamp() ON UPDATE current_timestamp()
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
  `create` timestamp NULL DEFAULT current_timestamp(),
  `updated` timestamp NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  `estatus` tinyint(1) DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COMMENT='Tabla de usuarios sistema plastitodo';

--
-- Volcado de datos para la tabla `usuarios`
--

INSERT INTO `usuarios` (`id`, `username`, `password`, `nombre`, `ap_paterno`, `ap_materno`, `id_perfil`, `create`, `updated`, `estatus`) VALUES
(1, 'admin', 'k0hALciYOS16DZX8tiCPXw==', 'Administrador', 'Plastitodo', NULL, 1, '2019-08-03 16:10:11', '2019-08-03 16:10:11', 1);

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
-- AUTO_INCREMENT de la tabla `cliente`
--
ALTER TABLE `cliente`
  MODIFY `idCliente` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de la tabla `detalle_entrada`
--
ALTER TABLE `detalle_entrada`
  MODIFY `folio` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `estados_documento`
--
ALTER TABLE `estados_documento`
  MODIFY `id` int(11) UNSIGNED NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `modulos`
--
ALTER TABLE `modulos`
  MODIFY `id` int(11) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT de la tabla `perfiles`
--
ALTER TABLE `perfiles`
  MODIFY `id` int(11) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de la tabla `relacion_perfiles_modulos`
--
ALTER TABLE `relacion_perfiles_modulos`
  MODIFY `id` int(11) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=39;

--
-- AUTO_INCREMENT de la tabla `relacion_perfiles_secciones`
--
ALTER TABLE `relacion_perfiles_secciones`
  MODIFY `id` int(11) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

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
  MODIFY `id` int(11) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
