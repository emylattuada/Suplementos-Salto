-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1:3306
-- Tiempo de generación: 30-08-2023 a las 19:42:58
-- Versión del servidor: 8.0.32
-- Versión de PHP: 8.0.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `suple`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `asignado`
--

DROP TABLE IF EXISTS `asignado`;
CREATE TABLE IF NOT EXISTS `asignado` (
  `ID_Producto` int NOT NULL,
  `ID_Venta` int NOT NULL,
  `Cantidad` int DEFAULT NULL,
  `P_U` decimal(10,2) DEFAULT NULL,
  PRIMARY KEY (`ID_Producto`,`ID_Venta`),
  KEY `ID_Venta` (`ID_Venta`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `categoria`
--

DROP TABLE IF EXISTS `categoria`;
CREATE TABLE IF NOT EXISTS `categoria` (
  `ID_Categoria` int NOT NULL AUTO_INCREMENT,
  `Descripcion` varchar(100) DEFAULT NULL,
  `Nombre` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`ID_Categoria`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Volcado de datos para la tabla `categoria`
--

INSERT INTO `categoria` (`ID_Categoria`, `Descripcion`, `Nombre`) VALUES
(1, 'Suplemento de vainilla\r\n', 'WHEY PROTEIN'),
(2, '', 'WHEY PROTEIN 2'),
(3, 'En polvo', 'PROTEINA'),
(5, '', 'Quemadores'),
(6, '', 'Prueba'),
(7, '', 'Prueba2\r\nPrueba2');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cliente`
--

DROP TABLE IF EXISTS `cliente`;
CREATE TABLE IF NOT EXISTS `cliente` (
  `ID_Cliente` int NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(50) DEFAULT NULL,
  `Email` varchar(50) DEFAULT NULL,
  `Telefono` varchar(20) DEFAULT NULL,
  `Direccion` varchar(100) DEFAULT NULL,
  `Visible` decimal(2,1) DEFAULT '1.0',
  PRIMARY KEY (`ID_Cliente`)
) ;

--
-- Volcado de datos para la tabla `cliente`
--

INSERT INTO `cliente` (`ID_Cliente`, `Nombre`, `Email`, `Telefono`, `Direccion`, `Visible`) VALUES
(1, 'Ramon figueroa', 'hola@gmail.com', '5848345', '4', '0.0'),
(2, 'Emii lattuada morales', '44934@gmail.com', '09999999', 'AGRACIADA 440', '0.0'),
(3, 'Nico Bonini 23', '45', '22323', '34', '0.0'),
(4, 'hola prueba', '', '33434', '545', '0.0'),
(5, 'emiii', '', '55', '', '0.0'),
(6, '546', '', '67', '', '0.0'),
(7, 'Emiliano Lattuada Morales', 'emjuan1234@gmail.com', '092475431', 'Agraciada 440', '1.0');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `ingresos`
--

DROP TABLE IF EXISTS `ingresos`;
CREATE TABLE IF NOT EXISTS `ingresos` (
  `ID_Ingreso` int NOT NULL,
  `Cantidad` int DEFAULT NULL,
  `Fecha_Ingreso` date DEFAULT NULL,
  `ID_Producto` int DEFAULT NULL,
  PRIMARY KEY (`ID_Ingreso`),
  KEY `ingresos_ibfk_1` (`ID_Producto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `pagos`
--

DROP TABLE IF EXISTS `pagos`;
CREATE TABLE IF NOT EXISTS `pagos` (
  `Recibo` varchar(50) NOT NULL,
  `Fecha_Pagos` date DEFAULT NULL,
  `Monto` decimal(10,2) DEFAULT NULL,
  `ID_Venta` int DEFAULT NULL,
  PRIMARY KEY (`Recibo`),
  KEY `ID_Venta` (`ID_Venta`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `producto`
--

DROP TABLE IF EXISTS `producto`;
CREATE TABLE IF NOT EXISTS `producto` (
  `ID_Producto` int NOT NULL AUTO_INCREMENT,
  `Precio` decimal(10,2) DEFAULT NULL,
  `Cantidad` int DEFAULT NULL,
  `Nombre` varchar(50) DEFAULT NULL,
  `ID_Categoria` int DEFAULT NULL,
  PRIMARY KEY (`ID_Producto`),
  KEY `ID_Categoria` (`ID_Categoria`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Volcado de datos para la tabla `producto`
--

INSERT INTO `producto` (`ID_Producto`, `Precio`, `Cantidad`, `Nombre`, `ID_Categoria`) VALUES
(1, '100.00', 10, 'Suplex', -1),
(2, '100.00', 10, 'Suplex pastilla', -1),
(3, '2000.00', 10, 'Nutriti', 3),
(4, '4.00', 5, '323', 6),
(5, '3900.00', 90, 'Prueba tiku', 1),
(6, '999.00', 1000, 'Tuki', 3),
(7, '900.00', 1000, 'Prueba con imagen', 5),
(8, '50.00', 1, 'Agua tonica', 6),
(9, '23.00', 4, 'jiahsdjkahd', 1),
(10, '3434.00', 23, '23434', 3),
(11, '400.00', 2, 'foda', 2),
(12, '23.00', 3, '545', 3);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuarios`
--

DROP TABLE IF EXISTS `usuarios`;
CREATE TABLE IF NOT EXISTS `usuarios` (
  `ID_Usuario` int NOT NULL AUTO_INCREMENT,
  `NombreUsuario` varchar(50) DEFAULT NULL,
  `Contraseña` varchar(100) DEFAULT NULL,
  `Rol` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`ID_Usuario`),
  UNIQUE KEY `NombreUsuario` (`NombreUsuario`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Volcado de datos para la tabla `usuarios`
--

INSERT INTO `usuarios` (`ID_Usuario`, `NombreUsuario`, `Contraseña`, `Rol`) VALUES
(1, 'nicosuple', 'admin', 'admin'),
(2, 'empleadosuple', 'empleado', 'empleado');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `venta`
--

DROP TABLE IF EXISTS `venta`;
CREATE TABLE IF NOT EXISTS `venta` (
  `ID_Venta` int NOT NULL,
  `Total` decimal(10,2) DEFAULT NULL,
  `Fecha_Venta` date DEFAULT NULL,
  `Tipo` varchar(50) DEFAULT NULL,
  `Saldo` decimal(10,2) DEFAULT NULL,
  `ID_Cliente` int DEFAULT NULL,
  PRIMARY KEY (`ID_Venta`),
  KEY `venta_ibfk_1` (`ID_Cliente`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `asignado`
--
ALTER TABLE `asignado`
  ADD CONSTRAINT `asignado_ibfk_1` FOREIGN KEY (`ID_Producto`) REFERENCES `producto` (`ID_Producto`),
  ADD CONSTRAINT `asignado_ibfk_2` FOREIGN KEY (`ID_Venta`) REFERENCES `venta` (`ID_Venta`);

--
-- Filtros para la tabla `ingresos`
--
ALTER TABLE `ingresos`
  ADD CONSTRAINT `ingresos_ibfk_1` FOREIGN KEY (`ID_Producto`) REFERENCES `producto` (`ID_Producto`);

--
-- Filtros para la tabla `pagos`
--
ALTER TABLE `pagos`
  ADD CONSTRAINT `pagos_ibfk_1` FOREIGN KEY (`ID_Venta`) REFERENCES `venta` (`ID_Venta`);

--
-- Filtros para la tabla `venta`
--
ALTER TABLE `venta`
  ADD CONSTRAINT `venta_ibfk_1` FOREIGN KEY (`ID_Cliente`) REFERENCES `cliente` (`ID_Cliente`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
