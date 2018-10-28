-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 28-10-2018 a las 03:44:11
-- Versión del servidor: 10.1.19-MariaDB
-- Versión de PHP: 7.0.13

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `mibodegaoxxo`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `deposito`
--

CREATE TABLE `deposito` (
  `idDeposito` int(11) NOT NULL,
  `fechaDeposito` varchar(25) NOT NULL,
  `nombreUsuarioDeposito` varchar(50) NOT NULL,
  `banco` varchar(50) NOT NULL,
  `numeroCuenta` varchar(20) NOT NULL,
  `monto` int(9) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `producto`
--

CREATE TABLE `producto` (
  `codigoIdProducto` int(11) NOT NULL,
  `descripcion` varchar(100) NOT NULL,
  `precio` int(9) NOT NULL,
  `fechaCaducidad` varchar(25) NOT NULL,
  `existencia` int(9) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `producto`
--

INSERT INTO `producto` (`codigoIdProducto`, `descripcion`, `precio`, `fechaCaducidad`, `existencia`) VALUES
(7501456, 'Tequila gran centenario 750ml', 270, '2020/12/28', 3),
(7505642, 'vino tinto reservado merlot 750ml', 120, '2020/12/26', 3),
(75045654, 'trident 4s 20g', 2, '2021/1/4', 50);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `proveedor`
--

CREATE TABLE `proveedor` (
  `idProveedor` int(11) NOT NULL,
  `nombre` varchar(50) NOT NULL,
  `apellidoPaterno` varchar(50) NOT NULL,
  `apellidoMaterno` varchar(50) NOT NULL,
  `nombreEmpresa` varchar(100) NOT NULL,
  `rfcEmpresa` varchar(20) NOT NULL,
  `telefono` varchar(12) NOT NULL,
  `correo` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `proveedor`
--

INSERT INTO `proveedor` (`idProveedor`, `nombre`, `apellidoPaterno`, `apellidoMaterno`, `nombreEmpresa`, `rfcEmpresa`, `telefono`, `correo`) VALUES
(1, 'pepe', 'pecas', 'pica', 'papas', 'pepepecas', '234443332', 'pepe@correo.com');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuario`
--

CREATE TABLE `usuario` (
  `idUsuario` int(11) NOT NULL,
  `nombre` varchar(50) NOT NULL,
  `apellidoPaterno` varchar(50) NOT NULL,
  `apellidoMaterno` varchar(50) NOT NULL,
  `fechaNacimiento` varchar(25) NOT NULL,
  `correo` varchar(100) NOT NULL,
  `telefono` varchar(20) NOT NULL,
  `contraseña` varchar(50) NOT NULL,
  `puesto` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `usuario`
--

INSERT INTO `usuario` (`idUsuario`, `nombre`, `apellidoPaterno`, `apellidoMaterno`, `fechaNacimiento`, `correo`, `telefono`, `contraseña`, `puesto`) VALUES
(1, 'carlos', 'mora', 'contreras', '1993/12/26', 'carlos.mora@alumnos.udg.mx', '36497409', 'wesker1993', 'Supervisor'),
(2, 'Luis', 'Garcia', 'Rodriguez', '1993/8/14', 'luis.garcia@gmail.com', '36497458', 'pollo21', 'Comisionista'),
(3, 'Jose', 'Enciso', 'Villa', '1996/10/2', 'jose.angel10@gmail.com', '36598740', 'emo10', 'Empleado');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `venta`
--

CREATE TABLE `venta` (
  `folioIdVenta` int(11) NOT NULL,
  `fechaDeVenta` varchar(25) NOT NULL,
  `nombreDelUsuarioVenta` varchar(50) NOT NULL,
  `ventaTotal` decimal(6,2) NOT NULL,
  `dineroRecibido` decimal(6,2) NOT NULL,
  `cambio` decimal(6,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `venta`
--

INSERT INTO `venta` (`folioIdVenta`, `fechaDeVenta`, `nombreDelUsuarioVenta`, `ventaTotal`, `dineroRecibido`, `cambio`) VALUES
(1, '2018/10/19', 'luis', '270.00', '300.00', '30.00'),
(2, '2018/10/19', 'luis', '270.00', '300.00', '30.00'),
(3, '2018/10/19', 'luis', '1052.00', '1060.00', '8.00'),
(4, '2018/10/19', 'jose', '2.00', '10.00', '8.00'),
(5, '2018/10/19', 'jose', '270.00', '500.00', '230.00');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `deposito`
--
ALTER TABLE `deposito`
  ADD PRIMARY KEY (`idDeposito`);

--
-- Indices de la tabla `producto`
--
ALTER TABLE `producto`
  ADD PRIMARY KEY (`codigoIdProducto`);

--
-- Indices de la tabla `proveedor`
--
ALTER TABLE `proveedor`
  ADD PRIMARY KEY (`idProveedor`);

--
-- Indices de la tabla `usuario`
--
ALTER TABLE `usuario`
  ADD PRIMARY KEY (`idUsuario`);

--
-- Indices de la tabla `venta`
--
ALTER TABLE `venta`
  ADD PRIMARY KEY (`folioIdVenta`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `deposito`
--
ALTER TABLE `deposito`
  MODIFY `idDeposito` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `proveedor`
--
ALTER TABLE `proveedor`
  MODIFY `idProveedor` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT de la tabla `usuario`
--
ALTER TABLE `usuario`
  MODIFY `idUsuario` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT de la tabla `venta`
--
ALTER TABLE `venta`
  MODIFY `folioIdVenta` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
