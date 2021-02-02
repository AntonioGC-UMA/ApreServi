-- MySQL dump 10.13  Distrib 8.0.23, for Win64 (x86_64)
--
-- Host: ingreq2021-mysql.cobadwnzalab.eu-central-1.rds.amazonaws.com    Database: apsgrupo04
-- ------------------------------------------------------
-- Server version	8.0.20

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
SET @MYSQLDUMP_TEMP_LOG_BIN = @@SESSION.SQL_LOG_BIN;
SET @@SESSION.SQL_LOG_BIN= 0;

--
-- GTID state at the beginning of the backup 
--

SET @@GLOBAL.GTID_PURGED=/*!80000 '+'*/ '';

--
-- Table structure for table `Actividad`
--

DROP TABLE IF EXISTS `Actividad`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8 */;
CREATE TABLE `Actividad` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nombre` varchar(65) NOT NULL,
  `descripcion` mediumtext NOT NULL,
  `fechaInicio` date NOT NULL,
  `fechaFin` date NOT NULL,
  `propietario` varchar(16) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `FK_Actividad_idx` (`propietario`),
  CONSTRAINT `FK_Actividad` FOREIGN KEY (`propietario`) REFERENCES `Usuario` (`nombreUsuario`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `Archivo`
--

DROP TABLE IF EXISTS `Archivo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8 */;
CREATE TABLE `Archivo` (
  `nombre` varchar(60) NOT NULL,
  `idCurso` int NOT NULL,
  `informacion` longblob NOT NULL,
  PRIMARY KEY (`nombre`,`idCurso`),
  KEY `FK1_Archivo_idx` (`idCurso`),
  CONSTRAINT `FK1_Archivo` FOREIGN KEY (`idCurso`) REFERENCES `Curso` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `Bloqueado`
--

DROP TABLE IF EXISTS `Bloqueado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8 */;
CREATE TABLE `Bloqueado` (
  `bloqueador` varchar(16) NOT NULL,
  `bloqueado` varchar(16) NOT NULL,
  PRIMARY KEY (`bloqueador`,`bloqueado`),
  KEY `FK2_Bloqueado_idx` (`bloqueado`),
  CONSTRAINT `FK1_Bloqueado` FOREIGN KEY (`bloqueador`) REFERENCES `Usuario` (`nombreUsuario`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `FK2_Bloqueado` FOREIGN KEY (`bloqueado`) REFERENCES `Usuario` (`nombreUsuario`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `Conversacion`
--

DROP TABLE IF EXISTS `Conversacion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8 */;
CREATE TABLE `Conversacion` (
  `usuario1` varchar(16) NOT NULL,
  `usuario2` varchar(16) NOT NULL,
  `cuerpo` mediumtext NOT NULL,
  PRIMARY KEY (`usuario1`,`usuario2`),
  KEY `FK_Emisor_idx` (`usuario1`),
  KEY `FK_Receptor_idx` (`usuario2`),
  CONSTRAINT `FK1_Conversacion` FOREIGN KEY (`usuario1`) REFERENCES `Usuario` (`nombreUsuario`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `FK2_Conversacion` FOREIGN KEY (`usuario2`) REFERENCES `Usuario` (`nombreUsuario`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `Curso`
--

DROP TABLE IF EXISTS `Curso`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8 */;
CREATE TABLE `Curso` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nombre` varchar(65) NOT NULL,
  `descripcion` mediumtext NOT NULL,
  `fechaInicio` date NOT NULL,
  `fechaFin` date NOT NULL,
  `propietario` varchar(16) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `FK_Curso_idx` (`propietario`),
  CONSTRAINT `FK_Curso` FOREIGN KEY (`propietario`) REFERENCES `Usuario` (`nombreUsuario`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=41 DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `Foro`
--

DROP TABLE IF EXISTS `Foro`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8 */;
CREATE TABLE `Foro` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nombre` varchar(45) NOT NULL,
  `descripcion` tinytext,
  `categoria` int DEFAULT NULL,
  `idCurso` int DEFAULT NULL,
  `idActividad` int DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `FK_ForoCurso_idx` (`idCurso`),
  KEY `FK_ForoActividad_idx` (`idActividad`),
  CONSTRAINT `FK_ForoActividad` FOREIGN KEY (`idActividad`) REFERENCES `Actividad` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `FK_ForoCurso` FOREIGN KEY (`idCurso`) REFERENCES `Curso` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=94 DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `ImagenPerfil`
--

DROP TABLE IF EXISTS `ImagenPerfil`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8 */;
CREATE TABLE `ImagenPerfil` (
  `nombreUsuario` varchar(16) NOT NULL,
  `imagen` mediumblob NOT NULL,
  PRIMARY KEY (`nombreUsuario`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `Inscripcion`
--

DROP TABLE IF EXISTS `Inscripcion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8 */;
CREATE TABLE `Inscripcion` (
  `idInscripcion` int NOT NULL AUTO_INCREMENT,
  `nombreUsuario` varchar(16) NOT NULL,
  `idActividad` int NOT NULL,
  PRIMARY KEY (`idInscripcion`),
  UNIQUE KEY `UQ_Inscripcion` (`nombreUsuario`,`idActividad`) /*!80000 INVISIBLE */,
  KEY `FK1_Inscripcion_idx` (`idActividad`),
  KEY `FK2_Inscripcion_idx` (`nombreUsuario`),
  CONSTRAINT `FK1_Inscripcion` FOREIGN KEY (`idActividad`) REFERENCES `Actividad` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `FK2_Inscripcion` FOREIGN KEY (`nombreUsuario`) REFERENCES `Usuario` (`nombreUsuario`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=20 DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `Matricula`
--

DROP TABLE IF EXISTS `Matricula`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8 */;
CREATE TABLE `Matricula` (
  `nombreUsuario` varchar(16) NOT NULL,
  `idCurso` int NOT NULL,
  PRIMARY KEY (`nombreUsuario`,`idCurso`),
  KEY `FK_Matricula_idx` (`idCurso`),
  CONSTRAINT `FK1_Matricula` FOREIGN KEY (`idCurso`) REFERENCES `Curso` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `FK2_Matricula` FOREIGN KEY (`nombreUsuario`) REFERENCES `Usuario` (`nombreUsuario`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `Noticia`
--

DROP TABLE IF EXISTS `Noticia`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8 */;
CREATE TABLE `Noticia` (
  `id` int NOT NULL AUTO_INCREMENT,
  `titular` varchar(255) NOT NULL,
  `cuerpo` mediumtext NOT NULL,
  `imagen` mediumblob NOT NULL,
  `fechaPublicacion` timestamp NOT NULL,
  `autor` varchar(16) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `FK_Noticia_idx` (`autor`),
  CONSTRAINT `FK_Noticia` FOREIGN KEY (`autor`) REFERENCES `Usuario` (`nombreUsuario`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `ONG`
--

DROP TABLE IF EXISTS `ONG`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8 */;
CREATE TABLE `ONG` (
  `idONG` int NOT NULL AUTO_INCREMENT,
  `nombreUsuario` varchar(16) NOT NULL,
  PRIMARY KEY (`idONG`),
  UNIQUE KEY `nombreUsuario_UNIQUE` (`nombreUsuario`),
  CONSTRAINT `fk1` FOREIGN KEY (`nombreUsuario`) REFERENCES `Usuario` (`nombreUsuario`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `Opcion`
--

DROP TABLE IF EXISTS `Opcion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8 */;
CREATE TABLE `Opcion` (
  `idOpcion` int NOT NULL,
  `idTest` int NOT NULL,
  `numPregunta` int NOT NULL,
  `nombre` varchar(45) NOT NULL,
  PRIMARY KEY (`idOpcion`,`idTest`,`numPregunta`),
  KEY `FK1_Opcion_idx` (`idTest`,`numPregunta`),
  CONSTRAINT `FK1_Opcion` FOREIGN KEY (`idTest`, `numPregunta`) REFERENCES `Pregunta` (`idTest`, `numeroPregunta`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `Post`
--

DROP TABLE IF EXISTS `Post`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8 */;
CREATE TABLE `Post` (
  `idPost` int NOT NULL AUTO_INCREMENT,
  `autor` varchar(45) NOT NULL,
  `contenido` mediumtext NOT NULL,
  `idForo` int NOT NULL,
  PRIMARY KEY (`idPost`,`idForo`),
  KEY `FK_Post_idx` (`idForo`),
  KEY `FK2_Post_idx` (`autor`),
  CONSTRAINT `FK1_Post` FOREIGN KEY (`autor`) REFERENCES `Usuario` (`nombreUsuario`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `FK2_Post` FOREIGN KEY (`idForo`) REFERENCES `Foro` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=63 DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `Pregunta`
--

DROP TABLE IF EXISTS `Pregunta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8 */;
CREATE TABLE `Pregunta` (
  `numeroPregunta` int NOT NULL,
  `idTest` int NOT NULL,
  `enunciado` varchar(255) NOT NULL,
  `opcionCorrecta` int NOT NULL,
  PRIMARY KEY (`numeroPregunta`,`idTest`),
  KEY `FK1_Pregunta_idx` (`idTest`),
  CONSTRAINT `FK1_Pregunta` FOREIGN KEY (`idTest`) REFERENCES `Test` (`idTest`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `Profesor`
--

DROP TABLE IF EXISTS `Profesor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8 */;
CREATE TABLE `Profesor` (
  `idProfesor` int NOT NULL AUTO_INCREMENT,
  `nombreUsuario` varchar(16) NOT NULL,
  PRIMARY KEY (`idProfesor`),
  UNIQUE KEY `nombreUsuario_UNIQUE` (`nombreUsuario`),
  CONSTRAINT `FK1_Profesor` FOREIGN KEY (`nombreUsuario`) REFERENCES `Usuario` (`nombreUsuario`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `Puntuacion`
--

DROP TABLE IF EXISTS `Puntuacion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8 */;
CREATE TABLE `Puntuacion` (
  `nombreUsuario` varchar(16) NOT NULL,
  `idTest` int NOT NULL,
  `nota` double NOT NULL,
  PRIMARY KEY (`nombreUsuario`,`idTest`),
  KEY `FK2_Puntuacion_idx` (`idTest`),
  CONSTRAINT `FK1_Puntuacion` FOREIGN KEY (`nombreUsuario`) REFERENCES `Usuario` (`nombreUsuario`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `FK2_Puntuacion` FOREIGN KEY (`idTest`) REFERENCES `Test` (`idTest`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `Test`
--

DROP TABLE IF EXISTS `Test`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8 */;
CREATE TABLE `Test` (
  `idTest` int NOT NULL AUTO_INCREMENT,
  `idCurso` int NOT NULL,
  `nombre` varchar(45) NOT NULL,
  PRIMARY KEY (`idTest`),
  UNIQUE KEY `nombre_UNIQUE` (`nombre`,`idCurso`),
  KEY `FK1_Test_idx` (`idCurso`),
  CONSTRAINT `FK1_Test` FOREIGN KEY (`idCurso`) REFERENCES `Curso` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `Usuario`
--

DROP TABLE IF EXISTS `Usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8 */;
CREATE TABLE `Usuario` (
  `nombreUsuario` varchar(16) NOT NULL,
  `email` varchar(50) NOT NULL,
  `contraseña` varchar(32) NOT NULL,
  `nombre` varchar(50) NOT NULL,
  `apellidos` varchar(50) NOT NULL,
  `admin` tinyint NOT NULL,
  PRIMARY KEY (`nombreUsuario`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;
SET @@SESSION.SQL_LOG_BIN = @MYSQLDUMP_TEMP_LOG_BIN;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-02-02 21:03:31
