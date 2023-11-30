-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1:3306
-- Tiempo de generación: 28-11-2023 a las 22:53:02
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
  `P_U` int DEFAULT NULL,
  PRIMARY KEY (`ID_Producto`,`ID_Venta`),
  KEY `ID_Venta` (`ID_Venta`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Volcado de datos para la tabla `asignado`
--

INSERT INTO `asignado` (`ID_Producto`, `ID_Venta`, `Cantidad`, `P_U`) VALUES
(1, 2, 1, 500),
(1, 8, 2, 500),
(2, 1, 2, 1490),
(2, 5, 1, 1490),
(2, 9, 2, 1490),
(6, 4, 1, 5900),
(6, 7, 1, 5900),
(8, 4, 1, 90),
(8, 6, 5, 90),
(8, 10, 6, 90),
(9, 3, 1, 1540);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `categoria`
--

DROP TABLE IF EXISTS `categoria`;
CREATE TABLE IF NOT EXISTS `categoria` (
  `ID_Categoria` int NOT NULL AUTO_INCREMENT,
  `Descripcion` varchar(30) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `Nombre` varchar(30) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `visible` tinyint DEFAULT '1',
  PRIMARY KEY (`ID_Categoria`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Volcado de datos para la tabla `categoria`
--

INSERT INTO `categoria` (`ID_Categoria`, `Descripcion`, `Nombre`, `visible`) VALUES
(1, '', 'Proteina', 1),
(2, '', 'Creatina', 1),
(3, '', 'Quemador de grasa', 1),
(4, 'Botella entrenamiento', 'Shaker', 1),
(5, '', 'Vitaminas', 1),
(6, '', 'Pre-entrenamiento', 1),
(7, '', 'Colagenos', 1),
(8, '', 'Energizantes', 1),
(9, '', 'Ganadores de peso', 1);

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
  `CI` varchar(8) DEFAULT NULL,
  PRIMARY KEY (`ID_Cliente`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Volcado de datos para la tabla `cliente`
--

INSERT INTO `cliente` (`ID_Cliente`, `Nombre`, `Email`, `Telefono`, `Direccion`, `Visible`, `CI`) VALUES
(1, 'Emiliano Lattuada', 'emjuan1234@gmail.com', '092475431', '', '1.0', '56665153'),
(2, 'Francisco Rangoni', '', '091234567', '', '1.0', '54435157'),
(3, 'Luis Monchietti', '', '092348735', 'Av. Barbieri 262', '1.0', '56665159'),
(4, 'Rodrigo Peyro', '', '092574431', '', '1.0', '56645453'),
(5, 'Facundo Bisio', NULL, '091475433', '', '1.0', '35665155'),
(6, 'Mariano Bondar', '', '093978465', '', '1.0', '35022346'),
(7, 'Omar Gutierrez', 'gutiomar19@gmail.com', '098985756', 'Vilardebo 150', '1.0', '57775453'),
(8, 'Fernanda Rodrigues', '', '099503000', '', '1.0', '55665163'),
(9, 'Thiago Suarez', '', '097756345', 'Rivera 742', '1.0', '33045382');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `ingresos`
--

DROP TABLE IF EXISTS `ingresos`;
CREATE TABLE IF NOT EXISTS `ingresos` (
  `ID_Ingreso` int NOT NULL AUTO_INCREMENT,
  `Cantidad` int DEFAULT NULL,
  `Fecha_Ingreso` date DEFAULT NULL,
  `ID_Producto` int DEFAULT NULL,
  PRIMARY KEY (`ID_Ingreso`),
  KEY `ingresos_ibfk_1` (`ID_Producto`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Volcado de datos para la tabla `ingresos`
--

INSERT INTO `ingresos` (`ID_Ingreso`, `Cantidad`, `Fecha_Ingreso`, `ID_Producto`) VALUES
(1, 5, '2023-11-28', 5);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `pagos`
--

DROP TABLE IF EXISTS `pagos`;
CREATE TABLE IF NOT EXISTS `pagos` (
  `Recibo` int NOT NULL AUTO_INCREMENT,
  `Fecha_Pagos` date DEFAULT NULL,
  `Monto` int DEFAULT NULL,
  `ID_Venta` int DEFAULT NULL,
  PRIMARY KEY (`Recibo`),
  KEY `ID_Venta` (`ID_Venta`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Volcado de datos para la tabla `pagos`
--

INSERT INTO `pagos` (`Recibo`, `Fecha_Pagos`, `Monto`, `ID_Venta`) VALUES
(1, '2023-11-01', 2980, 1),
(2, '2023-11-28', 500, 2),
(3, '2023-11-28', 385, 3),
(4, '2023-10-05', 1490, 5),
(5, '2023-01-28', 450, 6),
(6, '2023-11-28', 5900, 7),
(7, '2023-11-28', 1000, 8),
(8, '2023-11-28', 2980, 9),
(9, '2023-11-26', 540, 10);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `producto`
--

DROP TABLE IF EXISTS `producto`;
CREATE TABLE IF NOT EXISTS `producto` (
  `ID_Producto` int NOT NULL AUTO_INCREMENT,
  `Precio` int DEFAULT NULL,
  `Cantidad` int DEFAULT NULL,
  `Nombre` varchar(50) DEFAULT NULL,
  `ID_Categoria` int DEFAULT NULL,
  `visible` tinyint(1) NOT NULL DEFAULT '1',
  PRIMARY KEY (`ID_Producto`),
  KEY `fk_producto_categoria` (`ID_Categoria`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Volcado de datos para la tabla `producto`
--

INSERT INTO `producto` (`ID_Producto`, `Precio`, `Cantidad`, `Nombre`, `ID_Categoria`, `visible`) VALUES
(1, 500, 22, 'Mutant Mass 0.5kg', 9, 1),
(2, 1490, 10, 'Premium Whey Protein 1kg', 1, 1),
(3, 690, 5, 'FIX1 Colageno Hidrolizado 200gr', 7, 1),
(4, 450, 5, 'Animal Pak 44 Paks', 5, 1),
(5, 190, 55, 'Drink Mix 1kg', 8, 1),
(6, 5900, 11, 'Whey Protein 3kg', 1, 1),
(7, 1050, 33, 'Universal Creatina Monohidratada 200g', 2, 1),
(8, 90, 42, 'Strong Barrita de proteina Frutos Secos', 1, 1),
(9, 1540, 1000, 'Whey Protein Sylab 800gr Vainilla', 1, 1);

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
  `codigo` varchar(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `email` varchar(40) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `Visible` tinyint(1) NOT NULL DEFAULT '1',
  PRIMARY KEY (`ID_Usuario`),
  UNIQUE KEY `NombreUsuario` (`NombreUsuario`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Volcado de datos para la tabla `usuarios`
--

INSERT INTO `usuarios` (`ID_Usuario`, `NombreUsuario`, `Contraseña`, `Rol`, `codigo`, `email`, `Visible`) VALUES
(1, 'nicosuple', '8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918', 'Admin', '499147', '5dxuruguay@gmail.com', 1),
(2, 'emisuple', '0baff97ff722b0be472c1ff5a1edabf7cefb089d0575794975c3007989327efa', 'Empleado', '215028', 'emjuan1234@gmail.com', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `venta`
--

DROP TABLE IF EXISTS `venta`;
CREATE TABLE IF NOT EXISTS `venta` (
  `ID_Venta` int NOT NULL AUTO_INCREMENT,
  `Total` int DEFAULT NULL,
  `Fecha_Venta` date DEFAULT NULL,
  `Tipo` varchar(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `Saldo` int DEFAULT NULL,
  `ID_Cliente` int DEFAULT NULL,
  `Cuotas` int DEFAULT NULL,
  `devuelto` tinyint NOT NULL DEFAULT '1',
  PRIMARY KEY (`ID_Venta`),
  KEY `venta_ibfk_1` (`ID_Cliente`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Volcado de datos para la tabla `venta`
--

INSERT INTO `venta` (`ID_Venta`, `Total`, `Fecha_Venta`, `Tipo`, `Saldo`, `ID_Cliente`, `Cuotas`, `devuelto`) VALUES
(1, 2980, '2023-11-01', 'Contado', 0, 5, 0, 1),
(2, 500, '2023-11-28', 'Contado', 0, 7, 0, 1),
(3, 1540, '2023-11-28', 'Cuotas', 0, 8, 0, 0),
(4, 5990, '2023-11-14', 'Cuotas', 0, 9, 0, 0),
(5, 1490, '2023-10-05', 'Contado', 0, 6, 0, 1),
(6, 450, '2023-01-28', 'Contado', 0, 2, 0, 0),
(7, 5900, '2023-11-28', 'Contado', 0, 3, 0, 1),
(8, 1000, '2023-11-28', 'Contado', 0, 2, 0, 1),
(9, 2980, '2023-11-28', 'Contado', 0, 5, 0, 1),
(10, 540, '2023-11-26', 'Contado', 0, 5, 0, 1);

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
-- Filtros para la tabla `producto`
--
ALTER TABLE `producto`
  ADD CONSTRAINT `fk_producto_categoria` FOREIGN KEY (`ID_Categoria`) REFERENCES `categoria` (`ID_Categoria`);

--
-- Filtros para la tabla `venta`
--
ALTER TABLE `venta`
  ADD CONSTRAINT `venta_ibfk_1` FOREIGN KEY (`ID_Cliente`) REFERENCES `cliente` (`ID_Cliente`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
