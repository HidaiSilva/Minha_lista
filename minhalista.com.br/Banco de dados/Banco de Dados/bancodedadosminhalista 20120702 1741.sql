-- MySQL Administrator dump 1.4
--
-- ------------------------------------------------------
-- Server version	5.5.18


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


--
-- Create schema minhalista
--

CREATE DATABASE IF NOT EXISTS minhalista;
USE minhalista;

--
-- Definition of table `categoria`
--

DROP TABLE IF EXISTS `categoria`;
CREATE TABLE `categoria` (
  `ID_Categoria` int(11) NOT NULL AUTO_INCREMENT,
  `Tipo_Categoria` varchar(50) NOT NULL,
  `ID_Departamento` int(10) NOT NULL,
  PRIMARY KEY (`ID_Categoria`),
  KEY `FK_Departamento_Categoria` (`ID_Departamento`),
  CONSTRAINT `FK_Departamento_Categoria` FOREIGN KEY (`ID_Departamento`) REFERENCES `departamento` (`ID_departamento`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `categoria`
--

/*!40000 ALTER TABLE `categoria` DISABLE KEYS */;
INSERT INTO `categoria` (`ID_Categoria`,`Tipo_Categoria`,`ID_Departamento`) VALUES 
 (1,'Sabonetes',1),
 (2,'Shampoo',1),
 (3,'Fraldas',1),
 (4,'Manteigas',2),
 (5,'Iogurtes',2),
 (6,'Queijos',2),
 (7,'Chocolates',3),
 (8,'Cereais',3),
 (9,'Balas',3),
 (10,'Lasanhas',4),
 (11,'Pizzas',4);
/*!40000 ALTER TABLE `categoria` ENABLE KEYS */;


--
-- Definition of table `cliente`
--

DROP TABLE IF EXISTS `cliente`;
CREATE TABLE `cliente` (
  `ID_Cliente` int(11) NOT NULL AUTO_INCREMENT,
  `Nome_Cliente` varchar(150) NOT NULL,
  `CPF` varchar(20) NOT NULL,
  `Endereco` varchar(50) NOT NULL,
  `Telefone` varchar(20) NOT NULL,
  `Email` varchar(100) NOT NULL,
  `Senha` varchar(8) NOT NULL,
  `Telcelular` varchar(20) NOT NULL,
  `Bairro` varchar(40) NOT NULL,
  `CEP` varchar(45) NOT NULL,
  `NumeroR` int(6) NOT NULL,
  `Cidade` varchar(50) NOT NULL,
  PRIMARY KEY (`ID_Cliente`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `cliente`
--

/*!40000 ALTER TABLE `cliente` DISABLE KEYS */;
INSERT INTO `cliente` (`ID_Cliente`,`Nome_Cliente`,`CPF`,`Endereco`,`Telefone`,`Email`,`Senha`,`Telcelular`,`Bairro`,`CEP`,`NumeroR`,`Cidade`) VALUES 
 (1,'Thiago Ferraz Abravanel','12345678906','Avenida doutor joÆo guilhermino','01239532411','thiago@hotmail.com','00001111','01297589076','centro','12345000',1,'sÆo jos‚ dos campos'),
 (2,'Luara Aparecida Santos','12345678903','Avenida doutor jos‚ longo','01239532198','luara@hotmail.com','00002222','01294873622','centro','12987564',76,'sÆo jos‚ dos campos'),
 (3,'Janaina Almeida Campos','12345678903','Rua elza davila','39532421','janaina@hotmail.com','00004444','01297564738','centro','12345098',987,'sÆo jos‚ dos campos'),
 (4,'Jos‚ Carlos Cunha','12345678903','Rua eugenio bonadio','39532421','jose@hotmail.com','00005555','01297864532','centro','12890345',12,'sÆo jos‚ dos campos'),
 (5,'Maria Costa Cunha','12345678903','Rua eugenio bonadio','39532421','mariac@hotmail.com','00006666','01297864532','centro','12890345',12,'sÆo jos‚ dos campos'),
 (6,'Camila Pitanga Costa','12345678906','Avenida doutor nelson davila','01239532411','thiago@hotmail.com','00007777','01297567276','centro','12345321',234,'sÆo jos‚ dos campos'),
 (7,'Karina Souza Fred‚rik','12345678903','Avenida doutor juscelino kubtheck','012395324211','karina@hotmail.com','00008888','01294873622','vila industrial','12981212',36,'sÆo jos‚ dos campos'),
 (8,'Carlos Almeida Raimundo','12345678903','Avenida francisco paes','01239546732','carlos@hotmail.com','00001010','01297564738','centro','12345098',987,'sÆo jos‚ dos campos'),
 (9,'Jos‚ Maria Ferrero','12345678903','Rua eugenio bonadio','01239532421','jose@hotmail.com','00001212','012978609872','centro','12890546',12,'sÆo jos‚ dos campos'),
 (10,'josmar Olimpio Cunha','12345678903','Rua das flores','01239532421','josmar@hotmail.com','00011313','01297890872','centro','1289009',12,'sÆo jos‚ dos campos'),
 (11,'Tarsizio Meira','12345678906','Avenida brasil','012395129011','tarsizio@hotmail.com','00001414','01297586847','jardim paulista','12345897',32,'sÆo jos‚ dos campos'),
 (12,'Maria Freitas de Costalarga','12345678903','Avenida adromeda','01239532421198','maria@hotmail.com','00001515','01294873622','centro','12987564',98,'sÆo jos‚ dos campos'),
 (13,'Janaina Almeida Campos','12345678903','Rua joaquim matarazo pinheiros','0123978862421','janaina@hotmail.com','00001717','01297568956','centro','12345098',1934,'sÆo jos‚ dos campos'),
 (14,'Claudio Eduardo Silva','12345678903','Rua marechal cassino ricardo','01239532421','claudio@hotmail.com','00001818','01297864532','jardim aquarios','12890345',2456,'sÆo jos‚ dos campos'),
 (15,'Maria Claudia Silveira','12345678903','Avenida madre tereza','01239532421','maria@hotmail.com','00001919','01297789032','centro','12890345',1209,'sÆo jos‚ dos campos'),
 (16,'Fernanda Brasleme Neves','12345678906','Avenida da blomelias','01239456798','fernanda@hotmail.com','00002020','01297561122','centro','12347899',2312,'sÆo jos‚ dos campos'),
 (17,'Carlos Magno de Souza','12345678903','Avenida rui barbosa','01239098760','karina@hotmail.com','00002121','01294879988','vista verde','12981212',36,'sÆo jos‚ dos campos'),
 (18,'Pamela Aparecida Rodrigues','12345678903','Avenida francisco paes','01239546732','carlos@hotmail.com','00001010','01297564738','centro','1234567432',987,'sÆo jos‚ dos campos'),
 (19,'Leonardo Ferrera','12345678903','Rua eugenio bonadio','01239532421','pamela@hotmail.com','00001212','012978609872','centro','12898976',78,'sÆo jos‚ dos campos'),
 (20,'Joice Pascoali Vieira','12345678903','Rua das artes','01239532421','joice@hotmail.com','00011313','01297890872','vila rubi','12678998',45,'sÆo jos‚ dos campos');
/*!40000 ALTER TABLE `cliente` ENABLE KEYS */;


--
-- Definition of table `departamento`
--

DROP TABLE IF EXISTS `departamento`;
CREATE TABLE `departamento` (
  `ID_Departamento` int(10) NOT NULL AUTO_INCREMENT,
  `Nome_Departamento` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`ID_Departamento`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `departamento`
--

/*!40000 ALTER TABLE `departamento` DISABLE KEYS */;
INSERT INTO `departamento` (`ID_Departamento`,`Nome_Departamento`) VALUES 
 (1,'Higiene'),
 (2,'Lacticinios'),
 (3,'Doces'),
 (4,'Massas');
/*!40000 ALTER TABLE `departamento` ENABLE KEYS */;


--
-- Definition of table `fornecedor`
--

DROP TABLE IF EXISTS `fornecedor`;
CREATE TABLE `fornecedor` (
  `ID_Fornecedor` int(11) NOT NULL AUTO_INCREMENT,
  `Nome_Fornecedor` varchar(100) NOT NULL,
  `Endereco` varchar(50) NOT NULL,
  `CNPJ` varchar(45) NOT NULL,
  `NumeroR` int(6) NOT NULL,
  `Bairro` varchar(20) NOT NULL,
  `Cidade` varchar(50) NOT NULL,
  PRIMARY KEY (`ID_Fornecedor`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `fornecedor`
--

/*!40000 ALTER TABLE `fornecedor` DISABLE KEYS */;
INSERT INTO `fornecedor` (`ID_Fornecedor`,`Nome_Fornecedor`,`Endereco`,`CNPJ`,`NumeroR`,`Bairro`,`Cidade`) VALUES 
 (1,'WalMart','Av. Andr“meda ','23212694000120',227,'Jardim Sat‚lite','SÆo Jos‚ dos Campos'),
 (2,'Carrefour','Av. Deputado Benedito Matarazzo','23212694000122',5701,'Jardim Aquarius','SÆo Jos‚ dos Campos'),
 (3,'Extra','Avenida Jorge Zarur','23212694000120',100,'Jardim Apolo','SÆo Jos‚ dos Campos');
/*!40000 ALTER TABLE `fornecedor` ENABLE KEYS */;


--
-- Definition of table `funcionario`
--

DROP TABLE IF EXISTS `funcionario`;
CREATE TABLE `funcionario` (
  `ID_Funcionario` int(10) NOT NULL AUTO_INCREMENT,
  `Nome_Funcionario` varchar(150) NOT NULL,
  `Senha` varchar(8) NOT NULL,
  `Telefone` varchar(20) NOT NULL,
  `Email` varchar(100) NOT NULL,
  PRIMARY KEY (`ID_Funcionario`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `funcionario`
--

/*!40000 ALTER TABLE `funcionario` DISABLE KEYS */;
INSERT INTO `funcionario` (`ID_Funcionario`,`Nome_Funcionario`,`Senha`,`Telefone`,`Email`) VALUES 
 (1,'Anderson Aparecido Raimundo','123456','39349823','maria@minhalista.com'),
 (2,'Rafael Silva Pereira','123456','39348756','jorge@minhalista.com'),
 (3,'Marcos Jovino','123456','39906547','claudio@minhalista.com'),
 (4,'Marcus Vinicios','123456','39234567','fabiana@minhalista.com'),
 (5,'Miqueias Hidai','123456','39785640','camila@minhalista.com'),
 (6,'Jorge Fernando Costantino','123456','39537890','jorgef@minhalista.com'),
 (7,'Josevam Cunha Lima','123456','3953745','josevam@minhalista.com'),
 (8,'Alberto Leite da Costa','123456','39518934','alberto@minhalista.com'),
 (9,'Gabriel Souza Vieira','123456','39475892','gabriel@minhalista.com'),
 (10,'Nadir Pimentel','123456','39458712','nadir@minhalista.com');
/*!40000 ALTER TABLE `funcionario` ENABLE KEYS */;


--
-- Definition of table `historico_item`
--

DROP TABLE IF EXISTS `historico_item`;
CREATE TABLE `historico_item` (
  `ID_Historico_Item` int(10) NOT NULL AUTO_INCREMENT,
  `ID_Item` int(10) NOT NULL,
  `ID_Fornecedor` int(10) NOT NULL,
  `ID_Produto` int(10) NOT NULL,
  `Preco` decimal(5,2) NOT NULL,
  `Disponibilidade` char(4) NOT NULL,
  `Data_Ultima_alteracao` date NOT NULL,
  `Quantidade` int(10) NOT NULL,
  PRIMARY KEY (`ID_Historico_Item`),
  KEY `FK_Produto_historico_item` (`ID_Produto`),
  CONSTRAINT `FK_Produto_historico_item` FOREIGN KEY (`ID_Produto`) REFERENCES `produto` (`ID_produto`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `historico_item`
--

/*!40000 ALTER TABLE `historico_item` DISABLE KEYS */;
/*!40000 ALTER TABLE `historico_item` ENABLE KEYS */;


--
-- Definition of table `historico_pedido`
--

DROP TABLE IF EXISTS `historico_pedido`;
CREATE TABLE `historico_pedido` (
  `ID_Historico_Pedido` int(11) NOT NULL AUTO_INCREMENT,
  `ID_Pedido` int(10) NOT NULL,
  `Data_Entrada` date NOT NULL,
  `Horario_Entrada` time NOT NULL,
  `Operadora` varchar(40) NOT NULL,
  `Forma_pagamento` varchar(40) NOT NULL,
  `Data_Saida` date NOT NULL,
  `Horario_Saida` time NOT NULL,
  `Status_Pedio` varchar(20) NOT NULL,
  `ID_Funcionario` int(10) NOT NULL,
  `ID_Cliente` int(10) NOT NULL,
  `ID_Item` int(10) NOT NULL,
  PRIMARY KEY (`ID_Historico_Pedido`),
  KEY `FK_Pedido_historico_pedido` (`ID_Pedido`),
  CONSTRAINT `FK_Pedido_historico_pedido` FOREIGN KEY (`ID_Pedido`) REFERENCES `pedido` (`ID_pedido`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `historico_pedido`
--

/*!40000 ALTER TABLE `historico_pedido` DISABLE KEYS */;
/*!40000 ALTER TABLE `historico_pedido` ENABLE KEYS */;


--
-- Definition of table `item`
--

DROP TABLE IF EXISTS `item`;
CREATE TABLE `item` (
  `ID_Item` int(10) NOT NULL AUTO_INCREMENT,
  `ID_Fornecedor` int(10) NOT NULL,
  `ID_Produto` int(10) NOT NULL,
  `Preco` decimal(5,0) NOT NULL,
  `Disponibilidade` char(1) NOT NULL,
  `Data_Ultima_Alteraçao` date NOT NULL,
  `Quantidade` int(10) NOT NULL,
  PRIMARY KEY (`ID_Item`),
  KEY `FK_Fornecedor_Item` (`ID_Fornecedor`),
  KEY `FK_Produto_item` (`ID_Produto`),
  CONSTRAINT `FK_Fornecedor_Item` FOREIGN KEY (`ID_Fornecedor`) REFERENCES `fornecedor` (`ID_Fornecedor`),
  CONSTRAINT `FK_Produto_item` FOREIGN KEY (`ID_Produto`) REFERENCES `produto` (`ID_produto`)
) ENGINE=InnoDB AUTO_INCREMENT=100 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `item`
--

/*!40000 ALTER TABLE `item` DISABLE KEYS */;
INSERT INTO `item` (`ID_Item`,`ID_Fornecedor`,`ID_Produto`,`Preco`,`Disponibilidade`,`Data_Ultima_Alteraçao`,`Quantidade`) VALUES 
 (1,1,1,'2','s','2012-06-30',10),
 (2,2,1,'2','s','2012-06-30',10),
 (3,3,1,'2','s','2012-06-30',10),
 (4,1,2,'2','s','2012-06-30',10),
 (5,2,2,'2','s','2012-06-30',10),
 (6,3,2,'2','s','2012-06-30',10),
 (7,1,3,'2','s','2012-06-30',10),
 (8,2,3,'2','s','2012-06-30',10),
 (9,3,3,'2','s','2012-06-30',10),
 (10,1,4,'2','s','2012-06-30',10),
 (11,2,4,'2','s','2012-06-30',10),
 (12,3,4,'2','s','2012-06-30',10),
 (13,1,5,'1','s','2012-06-30',10),
 (14,2,5,'1','s','2012-06-30',10),
 (15,3,5,'1','s','2012-06-30',10),
 (16,1,6,'4','s','2012-06-30',10),
 (17,2,6,'4','s','2012-06-30',10),
 (18,3,6,'4','s','2012-06-30',10),
 (19,1,7,'2','s','2012-06-30',10),
 (20,2,7,'2','s','2012-06-30',10),
 (21,3,7,'2','s','2012-06-30',10),
 (22,1,8,'3','s','2012-06-30',10),
 (23,2,8,'3','s','2012-06-30',10),
 (24,3,8,'3','s','2012-06-30',10),
 (25,1,9,'4','s','2012-06-30',10),
 (26,2,9,'5','s','2012-06-30',10),
 (27,3,9,'6','s','2012-06-30',10),
 (28,1,10,'1','s','2012-06-30',10),
 (29,2,10,'2','s','2012-06-30',10),
 (30,3,10,'1','s','2012-06-03',10),
 (31,1,11,'5','s','2012-06-30',10),
 (32,2,11,'1','s','2012-06-30',10),
 (33,3,11,'2','s','2012-06-30',10),
 (34,1,12,'3','s','2012-06-30',10),
 (35,2,12,'2','s','2012-06-30',10),
 (36,3,12,'2','s','2012-06-30',10),
 (37,1,13,'3','s','2012-06-30',10),
 (38,2,13,'1','s','2012-06-30',10),
 (39,3,13,'2','s','2012-06-30',10),
 (40,1,14,'2','s','2012-06-30',10),
 (41,2,14,'2','s','2012-06-30',10),
 (42,3,14,'2','s','2012-06-30',10),
 (43,1,15,'2','s','2012-06-30',10),
 (44,2,15,'2','s','2012-06-30',10),
 (45,3,15,'2','s','2012-06-30',10),
 (46,1,16,'2','s','2012-06-30',10),
 (47,2,16,'2','s','2012-06-30',10),
 (48,3,16,'2','s','2012-06-30',10),
 (49,1,17,'2','s','2012-06-30',10),
 (50,2,17,'2','s','2012-06-30',10),
 (51,3,17,'2','s','2012-06-30',10),
 (52,1,18,'1','s','2012-06-30',10),
 (53,2,18,'1','s','2012-06-30',10),
 (54,3,18,'1','s','2012-06-30',10),
 (55,1,19,'4','s','2012-06-30',10),
 (56,2,19,'4','s','2012-06-30',10),
 (57,3,19,'4','s','2012-06-30',10),
 (58,1,20,'2','s','2012-06-30',10),
 (59,2,20,'2','s','2012-06-30',10),
 (60,3,20,'2','s','2012-06-30',10),
 (61,1,21,'3','s','2012-06-30',10),
 (62,2,21,'3','s','2012-06-30',10),
 (63,3,21,'3','s','2012-06-30',10),
 (64,1,22,'4','s','2012-06-30',10),
 (65,2,22,'5','s','2012-06-30',10),
 (66,3,22,'6','s','2012-06-30',10),
 (67,1,23,'1','s','2012-06-30',10),
 (68,2,23,'2','s','2012-06-30',10),
 (69,3,23,'1','s','2012-06-03',10),
 (70,1,24,'5','s','2012-06-30',10),
 (71,2,24,'1','s','2012-06-30',10),
 (72,3,24,'2','s','2012-06-30',10),
 (73,1,25,'3','s','2012-06-30',10),
 (74,2,25,'2','s','2012-06-30',10),
 (75,3,25,'2','s','2012-06-30',10),
 (76,1,26,'3','s','2012-06-30',10),
 (77,2,26,'1','s','2012-06-30',10),
 (78,3,26,'2','s','2012-06-30',10),
 (79,1,27,'1','s','2012-06-30',10),
 (80,2,27,'2','s','2012-06-30',10),
 (81,3,27,'1','s','2012-06-03',10),
 (82,1,28,'5','s','2012-06-30',10),
 (83,2,28,'1','s','2012-06-30',10),
 (84,3,28,'2','s','2012-06-30',10),
 (85,1,29,'3','s','2012-06-30',10),
 (86,2,29,'2','s','2012-06-30',10),
 (87,3,29,'2','s','2012-06-30',10),
 (88,1,30,'3','s','2012-06-30',10),
 (89,2,30,'1','s','2012-06-30',10),
 (90,3,30,'2','s','2012-06-30',10),
 (91,1,31,'3','s','2012-06-30',10),
 (92,2,31,'1','s','2012-06-30',10),
 (93,3,31,'2','s','2012-06-30',10),
 (94,1,32,'3','s','2012-06-30',10),
 (95,2,32,'1','s','2012-06-30',10),
 (96,3,32,'2','s','2012-06-30',10),
 (97,1,33,'3','s','2012-06-30',10),
 (98,2,33,'1','s','2012-06-30',10),
 (99,3,33,'2','s','2012-06-30',10);
/*!40000 ALTER TABLE `item` ENABLE KEYS */;


--
-- Definition of table `pedido`
--

DROP TABLE IF EXISTS `pedido`;
CREATE TABLE `pedido` (
  `ID_Pedido` int(11) NOT NULL AUTO_INCREMENT,
  `Data_Entrada` date NOT NULL,
  `Horario_Entrada` time NOT NULL,
  `Operadora` varchar(20) NOT NULL,
  `Forma_Pagamento` varchar(10) NOT NULL,
  `Data_Saida` date NOT NULL,
  `Horario_Saida` time NOT NULL,
  `Status_Pedido` varchar(40) NOT NULL,
  `ID_Funcionario` int(10) DEFAULT NULL,
  `ID_Cliente` int(10) NOT NULL,
  `ID_Item` int(10) NOT NULL,
  PRIMARY KEY (`ID_Pedido`),
  KEY `FK_Funcionario_pedido` (`ID_Funcionario`),
  KEY `FK_Cliente_pedido` (`ID_Cliente`),
  KEY `FK_Item_pedido` (`ID_Item`),
  CONSTRAINT `FK_Cliente_pedido` FOREIGN KEY (`ID_Cliente`) REFERENCES `cliente` (`ID_Cliente`),
  CONSTRAINT `FK_Funcionario_pedido` FOREIGN KEY (`ID_Funcionario`) REFERENCES `funcionario` (`ID_Funcionario`),
  CONSTRAINT `FK_Item_pedido` FOREIGN KEY (`ID_Item`) REFERENCES `item` (`ID_Item`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `pedido`
--

/*!40000 ALTER TABLE `pedido` DISABLE KEYS */;
INSERT INTO `pedido` (`ID_Pedido`,`Data_Entrada`,`Horario_Entrada`,`Operadora`,`Forma_Pagamento`,`Data_Saida`,`Horario_Saida`,`Status_Pedido`,`ID_Funcionario`,`ID_Cliente`,`ID_Item`) VALUES 
 (1,'2012-01-01','13:00:00','matercard','cartÆo','2012-02-03','14:00:00','aberto',1,1,3),
 (2,'2012-02-02','14:00:00','visa','cartÆo','2012-02-04','15:00:00','fechado',2,2,2),
 (3,'2012-02-03','13:00:00','credsistem','cartÆo','2012-02-05','14:00:00','fechado',1,3,3),
 (4,'2012-02-04','14:00:00','credcard','cartÆo','2012-02-06','15:00:00','aberto',2,3,4),
 (5,'2012-02-05','14:00:00','credcard','cartÆo','2012-02-07','15:00:00','fechado',4,5,5),
 (6,'2012-02-06','13:00:00','visa','cartÆo','2012-02-08','14:00:00','aberto',1,8,6),
 (7,'2012-02-07','14:00:00','visa','cartÆo','2012-02-09','15:00:00','fechado',2,7,7),
 (8,'2012-02-09','13:00:00','mastercard','cartÆo','2012-02-10','14:00:00','aberto',1,8,8),
 (9,'2012-02-09','14:00:00','visa','cartÆo','2012-02-11','15:00:00','aberto',3,3,9),
 (10,'2012-02-10','14:00:00','credsistem','cartÆo','2012-02-12','15:00:00','fechado',2,10,10),
 (11,'2012-01-01','13:00:00','matercard','cartÆo','2012-02-03','14:00:00','aberto',1,1,11),
 (12,'2012-02-02','14:00:00','visa','cartÆo','2012-02-04','15:00:00','fechado',2,2,12),
 (13,'2012-02-03','13:00:00','credsistem','cartÆo','2012-02-05','14:00:00','fechado',1,3,13),
 (14,'2012-02-04','14:00:00','credcard','cartÆo','2012-02-06','15:00:00','aberto',2,3,14),
 (15,'2012-02-05','14:00:00','credcard','cartÆo','2012-02-07','15:00:00','fechado',4,5,15),
 (16,'2012-02-06','13:00:00','visa','cartÆo','2012-02-08','14:00:00','aberto',1,8,16),
 (17,'2012-02-07','14:00:00','paypal','cartÆo','2012-02-09','15:00:00','fechado',2,7,17),
 (18,'2012-02-09','13:00:00','mastercard','cartÆo','2012-02-10','14:00:00','aberto',1,8,18),
 (19,'2012-02-09','14:00:00','visa','cartÆo','2012-02-11','15:00:00','aberto',3,3,19),
 (20,'2012-02-10','14:00:00','credsistem','cartÆo','2012-02-12','15:00:00','fechado',2,10,20);
/*!40000 ALTER TABLE `pedido` ENABLE KEYS */;


--
-- Definition of table `produto`
--

DROP TABLE IF EXISTS `produto`;
CREATE TABLE `produto` (
  `ID_Produto` int(10) NOT NULL AUTO_INCREMENT,
  `Nome_Produto` varchar(100) NOT NULL,
  `Marca` varchar(30) NOT NULL,
  `Imagem` varchar(300) NOT NULL,
  `ID_Categoria` int(10) NOT NULL,
  PRIMARY KEY (`ID_Produto`),
  KEY `FK_Categoria_produto` (`ID_Categoria`),
  CONSTRAINT `FK_Categoria_produto` FOREIGN KEY (`ID_Categoria`) REFERENCES `categoria` (`ID_Categoria`)
) ENGINE=InnoDB AUTO_INCREMENT=34 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `produto`
--

/*!40000 ALTER TABLE `produto` DISABLE KEYS */;
INSERT INTO `produto` (`ID_Produto`,`Nome_Produto`,`Marca`,`Imagem`,`ID_Categoria`) VALUES 
 (1,'Sabonete Senador cacau 30g','Senador','F:\\projeto software\\MinhaLista2\\Imagens\\Inverno.jpg',1),
 (2,'Sabonete Francis Leite 30g','Francis','F:\\projeto software\\MinhaLista2\\Imagens\\login.bmp',1),
 (3,'Sabonete JhONSON BABY 30g','Jhonson','F:\\projeto software\\MinhaLista2\\Imagens\\Inverno.jpg',1),
 (4,'Shampoo Barbie Morango 180ml','Barbie','F:\\projeto software\\MinhaLista2\\Imagens\\login.bmp',2),
 (5,'Shampoo Tremesse pessego 190ml','Tremesse','F:\\projeto software\\MinhaLista2\\Imagens\\Inverno.jpg',2),
 (6,'Shampoo e condicionador Niele GOLD 180ml GOLD 180ml','Niele','F:\\projeto software\\MinhaLista2\\Imagens\\login.bmp',2),
 (7,'Fralda Pampers 10 unidades','Pampers','F:\\projeto software\\MinhaLista2\\Imagens\\login.bmp',3),
 (8,'Frauda Geriatrica PJ 5 unidades','PJ','F:\\projeto software\\MinhaLista2\\Imagens\\login.bmp',3),
 (9,'Frauda Weebo 7 unidad','Weebo','F:\\projeto software\\MinhaLista2\\Imagens\\login.bmp',3),
 (10,'Manteiga Qualita 180g','Qualita','F:\\projeto software\\MinhaLista2\\Imagens\\login.bmp',4),
 (11,'Manteiga Branca Qualita 200g','Qualita','F:\\projeto software\\MinhaLista2\\Imagens\\login.bmp',4),
 (12,'Manteiga Presidente 180g','Presidente','F:\\projeto software\\MinhaLista2\\Imagens\\login.bmp',4),
 (13,'Yakult 6 unidades','Yakult','F:\\projeto software\\MinhaLista2\\Imagens\\login.bmp',5),
 (14,'Iorgute mamao Vigor 500ml','Vigor','F:\\projeto software\\MinhaLista2\\Imagens\\login.bmp',5),
 (15,'Iorgute Qualita Morango','Qualita','F:\\projeto software\\MinhaLista2\\Imagens\\login.bmp',5),
 (16,'Queijo Purissimo 300g','Purissimo','F:\\projeto software\\MinhaLista2\\Imagens\\login.bmp',6),
 (17,'Queijo Minas Qualita 100g','Qualita','F:\\projeto software\\MinhaLista2\\Imagens\\login.bmp',6),
 (18,'Queijo Gorgonzola TG 100g','TG','F:\\projeto software\\MinhaLista2\\Imagens\\login.bmp',6),
 (19,'Ferrero Roche 3 unidades','Ferrero Roche','F:\\projeto software\\MinhaLista2\\Imagens\\login.bmp',7),
 (20,'Bombom Alpino Nestle 208g','Nestle','link',7),
 (21,'Nescau Ball Nestle 120g','Nestle','link',7),
 (22,'Barra de Cereal Nutri 60g','Nutri','link',8),
 (23,'Barra de Cereal Trio 25g','Trio','link',8),
 (24,'Cereal em Barra TQHS 25g','TQHS ','link',8),
 (25,'Balas de Morango JP 60g','JP','link',9),
 (26,'Balas 7Belo 200g','7Belo','F:\\projeto software\\MinhaLista2\\Imagens\\login.bmp',9),
 (27,'Bala de goma Fini 300g','Fini','F:\\projeto software\\MinhaLista2\\Imagens\\login.bmp',9),
 (28,'Lasanha Bolonhesa PerdigÆo 500g','PerdigÆo','link',10),
 (29,'Lasanha seara frango com vegetais 500g','Seara','link',10),
 (30,'Lasanha Sadia Bolonhesa com Milho 519g','Sadia','link',10),
 (31,'Pizza Portuguesa Sadia 480g','Sadia','F:\\projeto software\\MinhaLista2\\Imagens\\login.bmp',11),
 (32,'Pizza Mussarela Sadia 480g','Sadia','link',11),
 (33,'Pizza Diet DR Oatker 390g','DR Oatker','F:\\projeto software\\MinhaLista2\\Imagens\\login.bmp',11);
/*!40000 ALTER TABLE `produto` ENABLE KEYS */;


--
-- Definition of table `responsavel`
--

DROP TABLE IF EXISTS `responsavel`;
CREATE TABLE `responsavel` (
  `ID_Responsavel` int(10) NOT NULL AUTO_INCREMENT,
  `Nome_Responsave` varchar(150) NOT NULL,
  `Cargo` varchar(100) NOT NULL,
  `CPF` varchar(20) NOT NULL,
  `Telefone` varchar(20) NOT NULL,
  `Email` varchar(100) NOT NULL,
  `ID_Fornecedor` int(10) NOT NULL,
  PRIMARY KEY (`ID_Responsavel`),
  KEY `FK_Fornecedor_responsavel` (`ID_Fornecedor`),
  CONSTRAINT `FK_Fornecedor_responsavel` FOREIGN KEY (`ID_Fornecedor`) REFERENCES `fornecedor` (`ID_Fornecedor`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `responsavel`
--

/*!40000 ALTER TABLE `responsavel` DISABLE KEYS */;
INSERT INTO `responsavel` (`ID_Responsavel`,`Nome_Responsave`,`Cargo`,`CPF`,`Telefone`,`Email`,`ID_Fornecedor`) VALUES 
 (1,'Carlos Rodrigues Oliveira','Gerente geral','12345678908','39562213','carlosoliveirasjc@walmart.com',1),
 (2,'Jos‚ Alcantara dos Santos','Gerente de vendas','12345678909','39235261','josealcansjc@walmart.com',1),
 (3,'Regiane Alves da Silva','Supervisora de vendas','12345678909','39530203','regianesilvawalsjc@Walmart.com',1),
 (4,'Jessica Campos Pimentel','Gerente geral','12345678908','39216398','jessicapimentelsjc@carrefour.com',2),
 (5,'Mario Pereira da Silva','Gerente de vendas','12345678909','39457612','mariopersjc@carrefour.com',2),
 (6,'Fabio Gomes Junior','Supervisor de vendas','12345678908','39082313','fabiojuniorsjc@carrefour.com',2),
 (7,'Wagner Aparecido de Camargo','Gerente geral','12345678909','39590452','wagnercamargosjc@extra.com',3),
 (8,'Rodrigo Costa Machado','Gerente de vendas','12345678908','39530213','rodrigocosta@extra.com',3),
 (9,'Camila Ferreira Hyochica','Supervisora de vendas','12345678909','3970211','regiane@extra.com',3);
/*!40000 ALTER TABLE `responsavel` ENABLE KEYS */;




/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
