-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1:3306
-- Tiempo de generación: 06-11-2023 a las 20:56:58
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
(1, 4, 1, 100),
(1, 5, 1, 100),
(1, 6, 1, 100),
(1, 13, 1, 100),
(1, 15, 1, 100),
(1, 17, 2, 100),
(1, 20, 3, 100),
(1, 26, 1, 100),
(1, 33, 2, 100),
(10, 3, 4, 0),
(10, 6, 2, 3434),
(10, 10, 4, 3434),
(10, 12, 2, 3434),
(10, 14, 1, 3434),
(10, 18, 2, 3434),
(10, 27, 1, 3434),
(10, 32, 4, 3434),
(20, 3, 1, 0),
(20, 4, 1, 150),
(20, 6, 1, 150),
(20, 7, 8, 150),
(20, 8, 1, 150),
(20, 9, 5, 150),
(20, 11, 3, 150),
(20, 16, 2, 150),
(20, 19, 10, 150),
(20, 22, 2, 150),
(20, 25, 30, 150),
(20, 31, 10, 150),
(20, 34, 5, 155),
(20, 35, 5, 155),
(23, 21, 30, 2),
(24, 23, 6, 3000),
(24, 24, 4, 3000),
(24, 28, 2, 3000),
(24, 29, 1, 3000),
(24, 30, 1, 3000),
(24, 34, 1, 3000),
(26, 35, 3, 2);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `categoria`
--

DROP TABLE IF EXISTS `categoria`;
CREATE TABLE IF NOT EXISTS `categoria` (
  `ID_Categoria` int NOT NULL AUTO_INCREMENT,
  `Descripcion` varchar(30) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `Nombre` varchar(30) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  PRIMARY KEY (`ID_Categoria`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Volcado de datos para la tabla `categoria`
--

INSERT INTO `categoria` (`ID_Categoria`, `Descripcion`, `Nombre`) VALUES
(8, 'Expira el 10/10', 'Quemador de grasas'),
(9, NULL, 'Vitaminas'),
(10, NULL, 'Proteina en polvo'),
(11, NULL, 'Barrita proteica'),
(12, NULL, 'Creatina'),
(13, '', 'Pure vitaminico'),
(14, '', 'Pure nutritivo manzanilla'),
(15, '', 'aloz'),
(16, '', 'papaya depo');

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
(1, 'Ramon figueroa', 'hola@gmail.com', '5848345', '4', '1.0'),
(2, 'Emii lattuada morales', '44934@gmail.com', '09999999', 'AGRACIADA 440', '0.0'),
(3, 'Nico Bonini 23', '45', '22323', '34', '0.0'),
(4, 'hola prueba', '', '33434', '545', '0.0'),
(5, 'emiii', '', '55', '', '0.0'),
(6, '546', '', '67', '', '1.0'),
(7, 'Emiliano Lattuada Morales', 'emjuan1234@gmail.com', '092475431', 'Agraciada 440', '1.0'),
(8, '1231232', '', '343435445', '34545', '0.0'),
(9, 'Ana Pérez\r\n', 'ana.perez@gmail.com', '092475431', 'Calle Montevideo 123', '0.0'),
(10, 'Luis Rodríguez Riquelme', 'luis.rodriguez@outlook.com', '0987534', 'Avenida Uruguay 456', '1.0'),
(11, 'María Silva ', 'maria.silva@gmail.com', '099345678', 'Plaza Independencia 789', '0.0'),
(12, 'Diego López Moreira', 'diego.lopez@outlook.com', '099456789', 'Calle Colonia 234', '1.0'),
(13, 'Pedro Peyro ', 'valentina.fernandez@gmail.com', '099567890', 'Avenida Rivera 567', '0.0'),
(14, 'Andrés González', 'andres.gonzalez@outlook.com', '099678901', 'Rambla Sur 890', '1.0'),
(15, 'Sofía Morales', 'sofia.perez@gmail.com', '099789012', 'Calle Artigas 1234', '1.0'),
(16, 'Juan Rodríguez', 'juan.rodriguez@outlook.com', '099890123', 'Plaza Cagancha 345', '1.0'),
(17, 'Lucas Suárez', ' lucas.suarez@gmail.com', '099901234', 'Avenida 18 de Julio 678', '1.0'),
(18, 'Valeria Pereira rodolfo', 'valeria.pereira@outlook.com', '099012345', 'Rambla Mahatma Gandhi 901', '1.0'),
(19, 'Santiago López', 'santiago.lopez@gmail.com', '099112233', 'Calle Montevideo 456', '1.0'),
(20, 'Laura Pérez', 'laura.perez@outlook.com', '099223344', 'Avenida Uruguay 789', '1.0'),
(21, 'Mateo Rodríguez', 'mateo.rodriguez@gmail.com', '099334455', 'Plaza Independencia 1011', '1.0'),
(22, 'Camila Silva', 'camila.silva@outlook.com', '099445566', 'Calle Colonia 567', '0.0'),
(23, 'Martín Fernández', 'martin.fernandez@gmail.com', '099556677', 'Avenida Rivera 1234', '1.0'),
(24, 'Antonia González', 'antonia.gonzalez@outlook.com', '099667788', 'Rambla Sur 345', '1.0'),
(25, 'Nicolás Pérez', 'nicolas2.perez@gmail.com', '099778899', 'Calle Artigas 678', '1.0'),
(26, 'Valentina Suárez', 'valentina.suarez@outlook.com', '099889900', 'Plaza Cagancha 890', '1.0'),
(27, 'Pablo Rodríguez', 'pablo.rodriguez@gmail.com', '099990011', 'Avenida 18 de Julio 234', '1.0'),
(28, 'Lucía Pereira', 'lucia.pereira@outlook.com', '099001122', 'Rambla Mahatma Gandhi 567', '1.0'),
(29, 'Carlos Martínez', 'carlos.martinez@gmail.com', '099112233', 'Calle Montevideo 567', '1.0'),
(30, 'Ana Rodríguez', 'ana.rodriguez@outlook.com', '099223344', 'Avenida Uruguay 1011', '0.0'),
(31, 'Andrés López', 'andres.lopez@gmail.com', '099112233', 'Calle Montevideo 1011', '0.0'),
(32, '3', '5@gmail.con', '3', '4', '0.0'),
(33, 'Alejandro Vasco', 'l23@gmail.com', '23994394', 'Agaciad 4040', '1.0'),
(34, 'hhh', '232324@gmail.com', '23344', '223@gmail.com', '1.0'),
(35, 'pedro manuel', '23234@gmail.com', '233434', '23243', '1.0');

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
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Volcado de datos para la tabla `ingresos`
--

INSERT INTO `ingresos` (`ID_Ingreso`, `Cantidad`, `Fecha_Ingreso`, `ID_Producto`) VALUES
(1, 10, '2023-09-28', 1),
(2, 3, '2023-09-09', 1),
(3, 1, '2023-09-19', 10),
(4, 4, '2023-10-03', 14),
(5, 6, '2023-10-23', 24);

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
) ENGINE=InnoDB AUTO_INCREMENT=27 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Volcado de datos para la tabla `pagos`
--

INSERT INTO `pagos` (`Recibo`, `Fecha_Pagos`, `Monto`, `ID_Venta`) VALUES
(1, '2023-10-19', 0, 3),
(2, '2023-10-19', 250, 4),
(3, '2023-10-05', 100, 5),
(4, '2023-10-19', 7418, 6),
(5, '2023-10-20', 1200, 7),
(6, '2023-10-19', 150, 8),
(7, '2023-10-19', 750, 9),
(8, '2023-10-19', 450, 11),
(9, '2023-10-19', 6868, 12),
(10, '2023-10-19', 100, 13),
(11, '2023-10-19', 3434, 14),
(12, '2023-10-19', 100, 15),
(13, '2023-10-19', 1500, 19),
(14, '2023-10-20', 300, 20),
(15, '2023-10-20', 60, 21),
(16, '2023-10-21', 300, 22),
(17, '2023-10-21', 18000, 23),
(18, '2023-10-23', 12000, 24),
(19, '2023-10-23', 4500, 25),
(20, '2023-10-23', 100, 26),
(21, '2023-10-23', 3434, 27),
(22, '2023-10-23', 6000, 28),
(23, '2023-10-23', 3000, 29),
(24, '2023-10-23', 3000, 30),
(25, '2023-10-26', 13736, 32),
(26, '2023-10-26', 3775, 34);

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
  KEY `ID_Categoria` (`ID_Categoria`)
) ENGINE=InnoDB AUTO_INCREMENT=29 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Volcado de datos para la tabla `producto`
--

INSERT INTO `producto` (`ID_Producto`, `Precio`, `Cantidad`, `Nombre`, `ID_Categoria`, `visible`) VALUES
(1, 100, 16, 'Suplex', -1, 1),
(10, 3434, 19, '23434', 3, 1),
(14, 2450, 14, 'WHEY chocolate', 12, 1),
(19, 1505, 50, 'SupleMax Chocolate Supremo', 12, 1),
(20, 155, 50, 'Actimel deportivo vainilla', 8, 1),
(21, 3, 1, 'prieba', 9, 1),
(22, 3, 2, 'test2', 8, 1),
(23, 2, 10, 'test', 9, 0),
(24, 3000, 0, 'Creatina bully', 12, 1),
(25, 250, 6, 'Nutela prote', 10, 1),
(26, 2, 0, 'pancho nutri', 8, 1),
(27, 1, 3, '34345', 15, 1),
(28, 1599, 11, 'papaya', 16, 0);

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
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Volcado de datos para la tabla `usuarios`
--

INSERT INTO `usuarios` (`ID_Usuario`, `NombreUsuario`, `Contraseña`, `Rol`, `codigo`, `email`, `Visible`) VALUES
(1, 'nicosuple', '8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918', 'Admin', '432418', '5dxuruguay@gmail.com', 1),
(4, 'empleadosuple2', 'b460b1982188f11d175f60ed670027e1afdd16558919fe47023ecd38329e0b7f', 'Empleado', '120701', 'empleado@gmail.com', 0),
(6, 'Prueba2', '03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4', 'Empleado', '852038', '5dx@gmail.com', 0),
(7, 'Emi', 'c0509a487a18b003ba05e505419ebb63e57a29158073e381f57160b5c5b86426', 'Empleado', '708759', '4dx@gmail.com', 1),
(8, 'test', '9f86d081884c7d659a2feaa0c55ad015a3bf4f1b2b0b822cd15d6c15b0f00a08', 'Empleado', '360394', 'test@gmail.com', 1),
(9, 'hola', 'b221d9dbb083a7f33428d7c2a3c3198ae925614d70210e28716ccaa7cd4ddb79', 'Empleado', '879836', 'hola@gmail.com', 1),
(10, 'emyru', '3891f13300b85e89d403504b4c26abe3adf5f39420a2d111059423cb25b33b86', 'Empleado', '478356', 'emjuan1234@gmail.com', 1),
(12, 'emi2', '1ef62013f28e97f69579402dfd1c1b01fa5a9344987edf0ba14a8c717931a274', 'Empleado', '454404', '5dxuruguayv4@gmail.com', 1),
(13, 'manu', '445c06f8335048bf3af883b047f79163c70083de3874e79ba1f7e621e0073579', 'Empleado', '278058', 'manuelaguilaracevedo2003@gmail.com', 1);

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
  `visible` tinyint(1) NOT NULL DEFAULT '1',
  PRIMARY KEY (`ID_Venta`),
  KEY `venta_ibfk_1` (`ID_Cliente`)
) ENGINE=InnoDB AUTO_INCREMENT=36 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Volcado de datos para la tabla `venta`
--

INSERT INTO `venta` (`ID_Venta`, `Total`, `Fecha_Venta`, `Tipo`, `Saldo`, `ID_Cliente`, `Cuotas`, `visible`) VALUES
(1, 0, '2023-10-19', 'Cuotas', 0, 7, 0, 1),
(2, 100, '2023-10-19', 'Cuotas', 100, 7, 4, 1),
(3, 0, '2023-10-19', 'Contado', 0, 7, 0, 1),
(4, 250, '2023-10-19', 'Contado', 0, 15, 0, 0),
(5, 100, '2023-10-05', 'Contado', 0, 16, 0, 0),
(6, 7418, '2023-10-19', 'Contado', 0, 10, 0, 0),
(7, 1200, '2023-10-20', 'Contado', 0, 29, 0, 1),
(8, 150, '2023-10-19', 'Contado', 0, 10, 0, 1),
(9, 750, '2023-10-19', 'Contado', 0, 7, 0, 1),
(10, 13736, '2023-10-19', 'Cuotas', 311, 14, 12, 1),
(11, 450, '2023-10-19', 'Contado', 2885, 14, 0, 1),
(12, 6868, '2023-10-19', 'Contado', 6868, 7, 0, 1),
(13, 100, '2023-10-19', 'Contado', 0, 17, 0, 1),
(14, 3434, '2023-10-19', 'Contado', 0, 10, 0, 1),
(15, 100, '2023-10-19', 'Contado', 300, 7, 0, 1),
(16, 300, '2023-10-19', 'Cuotas', 258, 26, 2, 1),
(17, 300, '2023-10-19', 'Cuotas', 6181, 12, 2, 1),
(18, 6868, '2023-10-19', 'Cuotas', 1350, 7, 3, 1),
(19, 1500, '2023-10-19', 'Contado', 0, 23, 0, 1),
(20, 300, '2023-10-20', 'Contado', 0, 7, 0, 1),
(21, 60, '2023-10-20', 'Contado', 300, 14, 0, 1),
(22, 300, '2023-10-21', 'Contado', 17100, 33, 0, 1),
(23, 18000, '2023-10-21', 'Contado', 18000, 7, 0, 1),
(24, 12000, '2023-10-23', 'Contado', 4275, 12, 0, 1),
(25, 4500, '2023-10-23', 'Contado', 98, 7, 0, 1),
(26, 100, '2023-10-23', 'Contado', 100, 7, 0, 1),
(27, 3434, '2023-10-23', 'Contado', 0, 7, 0, 1),
(28, 6000, '2023-10-23', 'Contado', 2400, 19, 0, 1),
(29, 3000, '2023-10-23', 'Contado', 2850, 14, 0, 1),
(30, 3000, '2023-10-23', 'Contado', 1350, 12, 0, 1),
(31, 1500, '2023-10-23', 'Cuotas', 13324, 20, 12, 1),
(32, 13736, '2023-10-26', 'Contado', 13736, 16, 0, 1),
(33, 200, '2023-10-26', 'Cuotas', 200, 7, 2, 1),
(34, 3775, '2023-10-26', 'Contado', 0, 7, 0, 1),
(35, 781, '2023-11-02', 'Cuotas', 781, 35, 12, 1);

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
-- Filtros para la tabla `venta`
--
ALTER TABLE `venta`
  ADD CONSTRAINT `venta_ibfk_1` FOREIGN KEY (`ID_Cliente`) REFERENCES `cliente` (`ID_Cliente`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
