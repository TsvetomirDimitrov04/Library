-- MySQL dump 10.13  Distrib 8.0.30, for Win64 (x86_64)
--
-- Host: localhost    Database: library
-- ------------------------------------------------------
-- Server version	8.0.30

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

--
-- Table structure for table `addstudent`
--

DROP TABLE IF EXISTS `addstudent`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `addstudent` (
  `id_student` int NOT NULL,
  `sname` varchar(250) NOT NULL,
  `enroll` varchar(250) DEFAULT NULL,
  `dep` varchar(250) NOT NULL,
  `sem` varchar(250) NOT NULL,
  `contact` bigint NOT NULL,
  `email` varchar(250) NOT NULL,
  PRIMARY KEY (`id_student`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `addstudent`
--

LOCK TABLES `addstudent` WRITE;
/*!40000 ALTER TABLE `addstudent` DISABLE KEYS */;
INSERT INTO `addstudent` VALUES (1,'Aiden','12','ads','abv',25,'ads');
/*!40000 ALTER TABLE `addstudent` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `irbook`
--

DROP TABLE IF EXISTS `irbook`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `irbook` (
  `id` int NOT NULL,
  `std_enroll` varchar(250) NOT NULL,
  `std_name` varchar(250) NOT NULL,
  `std_dep` varchar(250) NOT NULL,
  `std_sem` varchar(250) NOT NULL,
  `std_contact` bigint NOT NULL,
  `std_email` varchar(250) NOT NULL,
  `book_name` varchar(1250) NOT NULL,
  `book_issue_date` varchar(250) NOT NULL,
  `book_return_date` varchar(250) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `irbook`
--

LOCK TABLES `irbook` WRITE;
/*!40000 ALTER TABLE `irbook` DISABLE KEYS */;
INSERT INTO `irbook` VALUES (1,'12','12','ads','sd',25,'ads','xxxxxxx','14 април 2023 г.',NULL),(2,'12','12','ads','sd',25,'ads','wwwwwwwww','14 април 2023 г.','15 април 2023 г.');
/*!40000 ALTER TABLE `irbook` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `logintable`
--

DROP TABLE IF EXISTS `logintable`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `logintable` (
  `username` varchar(150) NOT NULL,
  `pass` varchar(150) NOT NULL,
  PRIMARY KEY (`username`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `logintable`
--

LOCK TABLES `logintable` WRITE;
/*!40000 ALTER TABLE `logintable` DISABLE KEYS */;
INSERT INTO `logintable` VALUES ('AAA','aaa'),('hi','hi'),('mim','okokokok'),('ss','ss'),('Test','Test'),('Tseti','pass'),('xx','xx');
/*!40000 ALTER TABLE `logintable` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `newbooks`
--

DROP TABLE IF EXISTS `newbooks`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `newbooks` (
  `id_book` int NOT NULL,
  `bName` varchar(250) NOT NULL,
  `bAuthor` varchar(250) NOT NULL,
  `bPubl` varchar(250) NOT NULL,
  `bPDate` varchar(250) NOT NULL,
  `bPrice` bigint NOT NULL,
  `bQuan` bigint NOT NULL,
  PRIMARY KEY (`id_book`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `newbooks`
--

LOCK TABLES `newbooks` WRITE;
/*!40000 ALTER TABLE `newbooks` DISABLE KEYS */;
INSERT INTO `newbooks` VALUES (1,'xxxxxxx','adad','ad','13 април 2023 г.',1,1),(2,'wwwwwwwww','adwd','sssss','13 април 2023 г.',1,1);
/*!40000 ALTER TABLE `newbooks` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-04-19  3:29:11
