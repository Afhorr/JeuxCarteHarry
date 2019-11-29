CREATE DATABASE IF NOT EXISTS `jeuharrypotter` /*!40100 DEFAULT CHARACTER SET utf8 */ ;

USE `jeuharrypotter`;
-- MySQL dump 10.13  Distrib 5.6.17, for Win32 (x86)
--
-- Host: localhost    Database: jeuharrypotter
-- ------------------------------------------------------
-- Server version	5.5.40

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

DROP TABLE IF EXISTS `cartes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cartes` (
  `idCarte` int(11) NOT NULL AUTO_INCREMENT,
  `identifiant` varchar(10) NOT NULL,
  `nomCarte` varchar(100) NOT NULL,
  `pointsMin` int(11) DEFAULT '0',
  `pointsMax` int(11) DEFAULT '0',
  `pointsDefense` int(11) DEFAULT '0',
  `nomAntidote` varchar(45) NOT NULL,
  `pointsAntidote` int(11) DEFAULT '0',
  `categorieCarte` int(11) NOT NULL,
  PRIMARY KEY (`idCarte`)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

DROP TABLE IF EXISTS `categories`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `categories` (
  `idCategorie` int(11) NOT NULL AUTO_INCREMENT,
  `nomCategorie` varchar(45) NOT NULL,
  `description` varchar(75) DEFAULT NULL,
  PRIMARY KEY (`idCategorie`)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

DROP TABLE IF EXISTS `joueurs`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `joueurs` (
  `idJoueur` int(11) NOT NULL AUTO_INCREMENT,
  `prenom` varchar(45) NOT NULL,
  `pointsJoueur` int(11) DEFAULT '0',
  `idMaison` int(11) NOT NULL,
  PRIMARY KEY (`idJoueur`)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

DROP TABLE IF EXISTS `maisons`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `maisons` (
  `idMaison` int(11) NOT NULL AUTO_INCREMENT,
  `nomMaison` varchar(45) NOT NULL,
  `couleur` varchar(45) NOT NULL,
  `fantome` varchar(45) NOT NULL,
  PRIMARY KEY (`idMaison`)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

LOCK TABLES `maisons` WRITE;
/*!40000 ALTER TABLE `maisons` DISABLE KEYS */;
INSERT INTO `maisons` (`nomMaison`,`couleur`,`fantome`) VALUES ('Gryffondor','rouge','Nick Quasi sans tête');
INSERT INTO `maisons` (`nomMaison`,`couleur`,`fantome`) VALUES ('Poufsouffle','jaune','Moine Gras');
INSERT INTO `maisons` (`nomMaison`,`couleur`,`fantome`) VALUES ('Serdaigle','bleu','Dame Grise');
INSERT INTO `maisons` (`nomMaison`,`couleur`,`fantome`) VALUES ('Serpentard','vert','Baron sanglant');
/*!40000 ALTER TABLE `maisons` ENABLE KEYS */;
UNLOCK TABLES;

LOCK TABLES `joueurs` WRITE;
/*!40000 ALTER TABLE `joueurs` DISABLE KEYS */;
INSERT INTO `joueurs` (`prenom`,`pointsJoueur`,`idMaison`) VALUES ('Katie Bell',0,1);
INSERT INTO `joueurs` (`prenom`,`pointsJoueur`,`idMaison`) VALUES ('Lavande Brown',0,1);
INSERT INTO `joueurs` (`prenom`,`pointsJoueur`,`idMaison`) VALUES ('Sirius Black',0,1);
INSERT INTO `joueurs` (`prenom`,`pointsJoueur`,`idMaison`) VALUES ('Colin Crivey',0,1);
INSERT INTO `joueurs` (`prenom`,`pointsJoueur`,`idMaison`) VALUES ('Olivier Dubois',0,1);
INSERT INTO `joueurs` (`prenom`,`pointsJoueur`,`idMaison`) VALUES ('Albus Dumbledore',0,1);
INSERT INTO `joueurs` (`prenom`,`pointsJoueur`,`idMaison`) VALUES ('Seamus Dumbledore',0,1);
INSERT INTO `joueurs` (`prenom`,`pointsJoueur`,`idMaison`) VALUES ('Hermione Dumbledore',0,1);
INSERT INTO `joueurs` (`prenom`,`pointsJoueur`,`idMaison`) VALUES ('Rubeus Hagrid',0,1);
INSERT INTO `joueurs` (`prenom`,`pointsJoueur`,`idMaison`) VALUES ('Angelina Johnson',0,1);
INSERT INTO `joueurs` (`prenom`,`pointsJoueur`,`idMaison`) VALUES (' Lee Jordan',0,1);
INSERT INTO `joueurs` (`prenom`,`pointsJoueur`,`idMaison`) VALUES ('Neville Londubat',0,1);
INSERT INTO `joueurs` (`prenom`,`pointsJoueur`,`idMaison`) VALUES ('Remus Lupin',0,1);
INSERT INTO `joueurs` (`prenom`,`pointsJoueur`,`idMaison`) VALUES ('Minerva McGonagall',0,1);
INSERT INTO `joueurs` (`prenom`,`pointsJoueur`,`idMaison`) VALUES ('Peter Pettigrow',0,1);
INSERT INTO `joueurs` (`prenom`,`pointsJoueur`,`idMaison`) VALUES ('Harry Potter',0,1);
INSERT INTO `joueurs` (`prenom`,`pointsJoueur`,`idMaison`) VALUES ('James Potter',0,1);
INSERT INTO `joueurs` (`prenom`,`pointsJoueur`,`idMaison`) VALUES ('Lily Potter',0,1);
INSERT INTO `joueurs` (`prenom`,`pointsJoueur`,`idMaison`) VALUES ('Dean Thomas',0,1);
INSERT INTO `joueurs` (`prenom`,`pointsJoueur`,`idMaison`) VALUES ('Arthur Weasley',0,1);
INSERT INTO `joueurs` (`prenom`,`pointsJoueur`,`idMaison`) VALUES ('Bill Weasley',0,1);
INSERT INTO `joueurs` (`prenom`,`pointsJoueur`,`idMaison`) VALUES ('Charlie Weasley',0,1);
INSERT INTO `joueurs` (`prenom`,`pointsJoueur`,`idMaison`) VALUES ('Fred Weasley',0,1);
INSERT INTO `joueurs` (`prenom`,`pointsJoueur`,`idMaison`) VALUES ('George Weasley',0,1);
INSERT INTO `joueurs` (`prenom`,`pointsJoueur`,`idMaison`) VALUES ('Ginny Weasley',0,1);
INSERT INTO `joueurs` (`prenom`,`pointsJoueur`,`idMaison`) VALUES ('Molly Weasley',0,1);
INSERT INTO `joueurs` (`prenom`,`pointsJoueur`,`idMaison`) VALUES ('Percy Weasley',0,1);
INSERT INTO `joueurs` (`prenom`,`pointsJoueur`,`idMaison`) VALUES ('Ron Weasley',0,1);
INSERT INTO `joueurs` (`prenom`,`pointsJoueur`,`idMaison`) VALUES ('Phineas Black',0,4);
INSERT INTO `joueurs` (`prenom`,`pointsJoueur`,`idMaison`) VALUES ('Regulus Black',0,4);
INSERT INTO `joueurs` (`prenom`,`pointsJoueur`,`idMaison`) VALUES ('Vncent Crabbe',0,4);
INSERT INTO `joueurs` (`prenom`,`pointsJoueur`,`idMaison`) VALUES ('Marcus Flint',0,4);
INSERT INTO `joueurs` (`prenom`,`pointsJoueur`,`idMaison`) VALUES ('Gregory Goyle',0,4);
INSERT INTO `joueurs` (`prenom`,`pointsJoueur`,`idMaison`) VALUES ('Tom Jedusor',0,4);
INSERT INTO `joueurs` (`prenom`,`pointsJoueur`,`idMaison`) VALUES ('Bellatrix Lestrange',0,4);
INSERT INTO `joueurs` (`prenom`,`pointsJoueur`,`idMaison`) VALUES ('Lucius Malefoy',0,4);
INSERT INTO `joueurs` (`prenom`,`pointsJoueur`,`idMaison`) VALUES ('Narcissa Malefoy',0,4);
INSERT INTO `joueurs` (`prenom`,`pointsJoueur`,`idMaison`) VALUES ('Drago Malefoy',0,4);
INSERT INTO `joueurs` (`prenom`,`pointsJoueur`,`idMaison`) VALUES ('Dolores Ombrage',0,4);
INSERT INTO `joueurs` (`prenom`,`pointsJoueur`,`idMaison`) VALUES ('Pansy Parkinson',0,4);
INSERT INTO `joueurs` (`prenom`,`pointsJoueur`,`idMaison`) VALUES ('Severus Rogue',0,4);
INSERT INTO `joueurs` (`prenom`,`pointsJoueur`,`idMaison`) VALUES ('Horace Slughorn',0,4);
INSERT INTO `joueurs` (`prenom`,`pointsJoueur`,`idMaison`) VALUES ('Hannah Abbot',0,2);
INSERT INTO `joueurs` (`prenom`,`pointsJoueur`,`idMaison`) VALUES ('Susan Bones',0,2);
INSERT INTO `joueurs` (`prenom`,`pointsJoueur`,`idMaison`) VALUES ('Pomona Chourave',0,2);
INSERT INTO `joueurs` (`prenom`,`pointsJoueur`,`idMaison`) VALUES ('Cedric Diggory',0,2);
INSERT INTO `joueurs` (`prenom`,`pointsJoueur`,`idMaison`) VALUES ('Justin Finch-Fletchley',0,2);
INSERT INTO `joueurs` (`prenom`,`pointsJoueur`,`idMaison`) VALUES ('Ernie Macmillan',0,2);
INSERT INTO `joueurs` (`prenom`,`pointsJoueur`,`idMaison`) VALUES ('Zacharia Smith',0,2);
INSERT INTO `joueurs` (`prenom`,`pointsJoueur`,`idMaison`) VALUES ('Nymphadora Tonks',0,2);
INSERT INTO `joueurs` (`prenom`,`pointsJoueur`,`idMaison`) VALUES ('Cho Chang',0,3);
INSERT INTO `joueurs` (`prenom`,`pointsJoueur`,`idMaison`) VALUES ('Michael Corner',0,3);
INSERT INTO `joueurs` (`prenom`,`pointsJoueur`,`idMaison`) VALUES ('Penelope Dauclaire',0,3);
INSERT INTO `joueurs` (`prenom`,`pointsJoueur`,`idMaison`) VALUES ('Filius Flitwick',0,3);
INSERT INTO `joueurs` (`prenom`,`pointsJoueur`,`idMaison`) VALUES ('Mimi Geignarde',0,3);
INSERT INTO `joueurs` (`prenom`,`pointsJoueur`,`idMaison`) VALUES ('Gilderoy Lockhart',0,3);
INSERT INTO `joueurs` (`prenom`,`pointsJoueur`,`idMaison`) VALUES ('Luna Lovegood',0,3);
INSERT INTO `joueurs` (`prenom`,`pointsJoueur`,`idMaison`) VALUES ('Padma Patil',0,3);
INSERT INTO `joueurs` (`prenom`,`pointsJoueur`,`idMaison`) VALUES ('Sibylle Trelawney',0,3);
/*!40000 ALTER TABLE `joueurs` ENABLE KEYS */;
UNLOCK TABLES;

LOCK TABLES `categories` WRITE;
/*!40000 ALTER TABLE `categories` DISABLE KEYS */;
INSERT INTO `categories` (`nomCategorie`,`description`) VALUES ('potion','tout ce qui peut se préparer dans un chaudron');
INSERT INTO `categories` (`nomCategorie`,`description`) VALUES ('sortilège','effectué à l\'aide d\'une baguette magique');
INSERT INTO `categories` (`nomCategorie`,`description`) VALUES ('confiserie','se mange');
INSERT INTO `categories` (`nomCategorie`,`description`) VALUES ('objet','est visible, peut appartenir à quelqu\'un, peut être manipulé');
INSERT INTO `categories` (`nomCategorie`,`description`) VALUES ('autre','tout ce qui n\'entre pas dans les autres catégorie');
/*!40000 ALTER TABLE `categories` ENABLE KEYS */;
UNLOCK TABLES;

LOCK TABLES `cartes` WRITE;
/*!40000 ALTER TABLE `cartes` DISABLE KEYS */;
INSERT INTO `cartes` (`identifiant`,`nomCarte`,`pointsMin`,`pointsMax`,`pointsDefense`,`nomAntidote`,`pointsAntidote`,`categorieCarte`) VALUES ('CA10','berlingot de fievre',2,5,0,'tylenol',1,3);
INSERT INTO `cartes` (`identifiant`,`nomCarte`,`pointsMin`,`pointsMax`,`pointsDefense`,`nomAntidote`,`pointsAntidote`,`categorieCarte`) VALUES ('CA11','boite a flemme',1,4,0,'à même le bonbon',1,3);
INSERT INTO `cartes` (`identifiant`,`nomCarte`,`pointsMin`,`pointsMax`,`pointsDefense`,`nomAntidote`,`pointsAntidote`,`categorieCarte`) VALUES ('CA12','bonbon explosif',1,3,0,'anti-explosion',2,3);
INSERT INTO `cartes` (`identifiant`,`nomCarte`,`pointsMin`,`pointsMax`,`pointsDefense`,`nomAntidote`,`pointsAntidote`,`categorieCarte`) VALUES ('CA13','dragee surprise de Bertie Crochu',1,4,0,'bonne dragée',1,3);
INSERT INTO `cartes` (`identifiant`,`nomCarte`,`pointsMin`,`pointsMax`,`pointsDefense`,`nomAntidote`,`pointsAntidote`,`categorieCarte`) VALUES ('CA20','nougat neansang',1,4,0,'mouchoir',1,3);
INSERT INTO `cartes` (`identifiant`,`nomCarte`,`pointsMin`,`pointsMax`,`pointsDefense`,`nomAntidote`,`pointsAntidote`,`categorieCarte`) VALUES ('CA21','pastille de gerbe',2,6,0,'anti mal de coeur',2,3);
INSERT INTO `cartes` (`identifiant`,`nomCarte`,`pointsMin`,`pointsMax`,`pointsDefense`,`nomAntidote`,`pointsAntidote`,`categorieCarte`) VALUES ('CA22','petit-four tourndeloeil',2,6,0,'anti évanouissement',2,3);
INSERT INTO `cartes` (`identifiant`,`nomCarte`,`pointsMin`,`pointsMax`,`pointsDefense`,`nomAntidote`,`pointsAntidote`,`categorieCarte`) VALUES ('CA31','praline longue langue',1,4,0,'praline langue normale',1,3);
INSERT INTO `cartes` (`identifiant`,`nomCarte`,`pointsMin`,`pointsMax`,`pointsDefense`,`nomAntidote`,`pointsAntidote`,`categorieCarte`) VALUES ('OA101','cognard fou',12,15,0,'armure',5,4);
INSERT INTO `cartes` (`identifiant`,`nomCarte`,`pointsMin`,`pointsMax`,`pointsDefense`,`nomAntidote`,`pointsAntidote`,`categorieCarte`) VALUES ('OA102','collier d\'opale',10,15,0,'gants',5,4);
INSERT INTO `cartes` (`identifiant`,`nomCarte`,`pointsMin`,`pointsMax`,`pointsDefense`,`nomAntidote`,`pointsAntidote`,`categorieCarte`) VALUES ('OA107','saule cogneur',8,15,0,'scie à chaine',3,4);
INSERT INTO `cartes` (`identifiant`,`nomCarte`,`pointsMin`,`pointsMax`,`pointsDefense`,`nomAntidote`,`pointsAntidote`,`categorieCarte`) VALUES ('OA14','feuxfous fuseboum',4,8,0,'eau',2,4);
INSERT INTO `cartes` (`identifiant`,`nomCarte`,`pointsMin`,`pointsMax`,`pointsDefense`,`nomAntidote`,`pointsAntidote`,`categorieCarte`) VALUES ('OA15','leurre explosif',2,6,0,'eau',2,4);
INSERT INTO `cartes` (`identifiant`,`nomCarte`,`pointsMin`,`pointsMax`,`pointsDefense`,`nomAntidote`,`pointsAntidote`,`categorieCarte`) VALUES ('OA19','marecage portable',1,4,0,'terre',1,4);
INSERT INTO `cartes` (`identifiant`,`nomCarte`,`pointsMin`,`pointsMax`,`pointsDefense`,`nomAntidote`,`pointsAntidote`,`categorieCarte`) VALUES ('OA26','plume a papotte',1,4,0,'silencieux',1,4);
INSERT INTO `cartes` (`identifiant`,`nomCarte`,`pointsMin`,`pointsMax`,`pointsDefense`,`nomAntidote`,`pointsAntidote`,`categorieCarte`) VALUES ('OA30','poudre d\'obscurite',5,10,0,'lumière',2,4);
INSERT INTO `cartes` (`identifiant`,`nomCarte`,`pointsMin`,`pointsMax`,`pointsDefense`,`nomAntidote`,`pointsAntidote`,`categorieCarte`) VALUES ('OA34','mandragore',2,6,0,'bouchons',2,4);
INSERT INTO `cartes` (`identifiant`,`nomCarte`,`pointsMin`,`pointsMax`,`pointsDefense`,`nomAntidote`,`pointsAntidote`,`categorieCarte`) VALUES ('OD100','cape d\'invisibilité',0,0,8,'cape visibilité',2,4);
INSERT INTO `cartes` (`identifiant`,`nomCarte`,`pointsMin`,`pointsMax`,`pointsDefense`,`nomAntidote`,`pointsAntidote`,`categorieCarte`) VALUES ('OD101','épée de gryffondor',0,0,7,'bouclier',2,4);
INSERT INTO `cartes` (`identifiant`,`nomCarte`,`pointsMin`,`pointsMax`,`pointsDefense`,`nomAntidote`,`pointsAntidote`,`categorieCarte`) VALUES ('OD11','cape bouclier',0,0,5,'anti bouclier',2,4);
INSERT INTO `cartes` (`identifiant`,`nomCarte`,`pointsMin`,`pointsMax`,`pointsDefense`,`nomAntidote`,`pointsAntidote`,`categorieCarte`) VALUES ('OD12','carte du maraudeur',0,0,5,'anti gps',2,4);
INSERT INTO `cartes` (`identifiant`,`nomCarte`,`pointsMin`,`pointsMax`,`pointsDefense`,`nomAntidote`,`pointsAntidote`,`categorieCarte`) VALUES ('OD13','chapeau bouclier',0,0,3,'casquette',1,4);
INSERT INTO `cartes` (`identifiant`,`nomCarte`,`pointsMin`,`pointsMax`,`pointsDefense`,`nomAntidote`,`pointsAntidote`,`categorieCarte`) VALUES ('OD20','oreille a rallonge',0,0,1,'ciseau',1,4);
INSERT INTO `cartes` (`identifiant`,`nomCarte`,`pointsMin`,`pointsMax`,`pointsDefense`,`nomAntidote`,`pointsAntidote`,`categorieCarte`) VALUES ('OD28','scrutocsope',0,0,3,'anti magie noire',1,4);
INSERT INTO `cartes` (`identifiant`,`nomCarte`,`pointsMin`,`pointsMax`,`pointsDefense`,`nomAntidote`,`pointsAntidote`,`categorieCarte`) VALUES ('PA106','Véritasérum',8,15,0,'potion pour rendre muet',3,1);
INSERT INTO `cartes` (`identifiant`,`nomCarte`,`pointsMin`,`pointsMax`,`pointsDefense`,`nomAntidote`,`pointsAntidote`,`categorieCarte`) VALUES ('PA108','philtre de Mort Vivante',8,14,0,'philtre de vie',3,1);
INSERT INTO `cartes` (`identifiant`,`nomCarte`,`pointsMin`,`pointsMax`,`pointsDefense`,`nomAntidote`,`pointsAntidote`,`categorieCarte`) VALUES ('PA23','philtre d\'amour',2,6,0,'anti philtre',1,1);
INSERT INTO `cartes` (`identifiant`,`nomCarte`,`pointsMin`,`pointsMax`,`pointsDefense`,`nomAntidote`,`pointsAntidote`,`categorieCarte`) VALUES ('PA24','philtre d\'embrouille',4,8,0,'philtre de réflexion',1,1);
INSERT INTO `cartes` (`identifiant`,`nomCarte`,`pointsMin`,`pointsMax`,`pointsDefense`,`nomAntidote`,`pointsAntidote`,`categorieCarte`) VALUES ('PA25','philtre de confusion',5,10,0,'philtre de réflexion',3,1);
INSERT INTO `cartes` (`identifiant`,`nomCarte`,`pointsMin`,`pointsMax`,`pointsDefense`,`nomAntidote`,`pointsAntidote`,`categorieCarte`) VALUES ('PA27','potion d\'amnésie',3,8,0,'potion de souvenirs',2,1);
INSERT INTO `cartes` (`identifiant`,`nomCarte`,`pointsMin`,`pointsMax`,`pointsDefense`,`nomAntidote`,`pointsAntidote`,`categorieCarte`) VALUES ('PA28','potion de babillage',1,4,0,'potion pour dromir',1,1);
INSERT INTO `cartes` (`identifiant`,`nomCarte`,`pointsMin`,`pointsMax`,`pointsDefense`,`nomAntidote`,`pointsAntidote`,`categorieCarte`) VALUES ('PA29','potion d\'enflure',2,6,0,'potion pour maigrir',1,1);
INSERT INTO `cartes` (`identifiant`,`nomCarte`,`pointsMin`,`pointsMax`,`pointsDefense`,`nomAntidote`,`pointsAntidote`,`categorieCarte`) VALUES ('PA35','décoction hoqueteuse',2,5,0,'anti hoquet',1,1);
INSERT INTO `cartes` (`identifiant`,`nomCarte`,`pointsMin`,`pointsMax`,`pointsDefense`,`nomAntidote`,`pointsAntidote`,`categorieCarte`) VALUES ('PA36','mélange malveillant',6,10,0,'mélange bienveillant',2,1);
INSERT INTO `cartes` (`identifiant`,`nomCarte`,`pointsMin`,`pointsMax`,`pointsDefense`,`nomAntidote`,`pointsAntidote`,`categorieCarte`) VALUES ('PA37','poison pernicieux',6,10,0,'anti poison',2,1);
INSERT INTO `cartes` (`identifiant`,`nomCarte`,`pointsMin`,`pointsMax`,`pointsDefense`,`nomAntidote`,`pointsAntidote`,`categorieCarte`) VALUES ('PA38','potion de ratatinage',2,10,0,'potion taille normale',1,1);
INSERT INTO `cartes` (`identifiant`,`nomCarte`,`pointsMin`,`pointsMax`,`pointsDefense`,`nomAntidote`,`pointsAntidote`,`categorieCarte`) VALUES ('PA39','potion de vieillissement',4,10,0,'potion pour rajeunir',2,1);
INSERT INTO `cartes` (`identifiant`,`nomCarte`,`pointsMin`,`pointsMax`,`pointsDefense`,`nomAntidote`,`pointsAntidote`,`categorieCarte`) VALUES ('PD104','philtre éternel',0,0,9,'philtre de vie normal',2,1);
INSERT INTO `cartes` (`identifiant`,`nomCarte`,`pointsMin`,`pointsMax`,`pointsDefense`,`nomAntidote`,`pointsAntidote`,`categorieCarte`) VALUES ('PD105','solution de force',0,0,8,'solution d\'affaiblissement',2,1);
INSERT INTO `cartes` (`identifiant`,`nomCarte`,`pointsMin`,`pointsMax`,`pointsDefense`,`nomAntidote`,`pointsAntidote`,`categorieCarte`) VALUES ('PD15','essence de Murlap',0,0,2,'anti guérison',1,1);
INSERT INTO `cartes` (`identifiant`,`nomCarte`,`pointsMin`,`pointsMax`,`pointsDefense`,`nomAntidote`,`pointsAntidote`,`categorieCarte`) VALUES ('PD16','Felix Felicis',0,0,3,'sort de malchance',1,1);
INSERT INTO `cartes` (`identifiant`,`nomCarte`,`pointsMin`,`pointsMax`,`pointsDefense`,`nomAntidote`,`pointsAntidote`,`categorieCarte`) VALUES ('PD21','philtre de paix',0,0,6,'guerre',1,1);
INSERT INTO `cartes` (`identifiant`,`nomCarte`,`pointsMin`,`pointsMax`,`pointsDefense`,`nomAntidote`,`pointsAntidote`,`categorieCarte`) VALUES ('PD22','polynectar',0,0,5,'anti nectar',2,1);
INSERT INTO `cartes` (`identifiant`,`nomCarte`,`pointsMin`,`pointsMax`,`pointsDefense`,`nomAntidote`,`pointsAntidote`,`categorieCarte`) VALUES ('PD23','potion de mémoire',0,0,4,'potion amnésique',2,1);
INSERT INTO `cartes` (`identifiant`,`nomCarte`,`pointsMin`,`pointsMax`,`pointsDefense`,`nomAntidote`,`pointsAntidote`,`categorieCarte`) VALUES ('PD24','potion d\'haleine de chien',0,0,3,'bonne haleine',1,1);
INSERT INTO `cartes` (`identifiant`,`nomCarte`,`pointsMin`,`pointsMax`,`pointsDefense`,`nomAntidote`,`pointsAntidote`,`categorieCarte`) VALUES ('PD25','potion oculus',0,0,3,'potion aveugle',1,1);
INSERT INTO `cartes` (`identifiant`,`nomCarte`,`pointsMin`,`pointsMax`,`pointsDefense`,`nomAntidote`,`pointsAntidote`,`categorieCarte`) VALUES ('PD27','remontant de Pomfresh',0,0,2,'anti remontant',1,1);
INSERT INTO `cartes` (`identifiant`,`nomCarte`,`pointsMin`,`pointsMax`,`pointsDefense`,`nomAntidote`,`pointsAntidote`,`categorieCarte`) VALUES ('PD29','sortilège de lévitation',0,0,3,'sortilège 2 pied sur terre',1,2);
INSERT INTO `cartes` (`identifiant`,`nomCarte`,`pointsMin`,`pointsMax`,`pointsDefense`,`nomAntidote`,`pointsAntidote`,`categorieCarte`) VALUES ('SA100','avada kedavra',15,20,0,'fontaine de jouvence',10,2);
INSERT INTO `cartes` (`identifiant`,`nomCarte`,`pointsMin`,`pointsMax`,`pointsDefense`,`nomAntidote`,`pointsAntidote`,`categorieCarte`) VALUES ('SA103','endoloris',12,18,0,'anti douleur',5,2);
INSERT INTO `cartes` (`identifiant`,`nomCarte`,`pointsMin`,`pointsMax`,`pointsDefense`,`nomAntidote`,`pointsAntidote`,`categorieCarte`) VALUES ('SA105','impero',10,15,0,'sortilège de surdité',4,2);
INSERT INTO `cartes` (`identifiant`,`nomCarte`,`pointsMin`,`pointsMax`,`pointsDefense`,`nomAntidote`,`pointsAntidote`,`categorieCarte`) VALUES ('SA16','maléfice cuisant',3,8,0,'anti maléfice',1,2);
INSERT INTO `cartes` (`identifiant`,`nomCarte`,`pointsMin`,`pointsMax`,`pointsDefense`,`nomAntidote`,`pointsAntidote`,`categorieCarte`) VALUES ('SA17','maléfice de catapultage',5,10,0,'anti catapulte',3,2);
INSERT INTO `cartes` (`identifiant`,`nomCarte`,`pointsMin`,`pointsMax`,`pointsDefense`,`nomAntidote`,`pointsAntidote`,`categorieCarte`) VALUES ('SA18','maléfice de jambencoton',1,4,0,'jambe en bois',1,2);
INSERT INTO `cartes` (`identifiant`,`nomCarte`,`pointsMin`,`pointsMax`,`pointsDefense`,`nomAntidote`,`pointsAntidote`,`categorieCarte`) VALUES ('SA32','reve eveille',4,9,0,'réalité',3,2);
INSERT INTO `cartes` (`identifiant`,`nomCarte`,`pointsMin`,`pointsMax`,`pointsDefense`,`nomAntidote`,`pointsAntidote`,`categorieCarte`) VALUES ('SA33','sortilège d\'amnésie',5,10,0,'souvenirs',2,2);
INSERT INTO `cartes` (`identifiant`,`nomCarte`,`pointsMin`,`pointsMax`,`pointsDefense`,`nomAntidote`,`pointsAntidote`,`categorieCarte`) VALUES ('SD10','accio',0,0,4,'colle',1,2);
INSERT INTO `cartes` (`identifiant`,`nomCarte`,`pointsMin`,`pointsMax`,`pointsDefense`,`nomAntidote`,`pointsAntidote`,`categorieCarte`) VALUES ('SD102','expelliarmus',0,0,8,'attache',2,2);
INSERT INTO `cartes` (`identifiant`,`nomCarte`,`pointsMin`,`pointsMax`,`pointsDefense`,`nomAntidote`,`pointsAntidote`,`categorieCarte`) VALUES ('SD103','patronus',0,0,10,'anti patronus',3,2);
INSERT INTO `cartes` (`identifiant`,`nomCarte`,`pointsMin`,`pointsMax`,`pointsDefense`,`nomAntidote`,`pointsAntidote`,`categorieCarte`) VALUES ('SD106','sortilège de désarmement',0,0,9,'armée',3,2);
INSERT INTO `cartes` (`identifiant`,`nomCarte`,`pointsMin`,`pointsMax`,`pointsDefense`,`nomAntidote`,`pointsAntidote`,`categorieCarte`) VALUES ('SD107','stupefix',0,0,10,'anti stupéfix',2,2);
INSERT INTO `cartes` (`identifiant`,`nomCarte`,`pointsMin`,`pointsMax`,`pointsDefense`,`nomAntidote`,`pointsAntidote`,`categorieCarte`) VALUES ('SD14','charme du bouclier',0,0,6,'épée',2,2);
INSERT INTO `cartes` (`identifiant`,`nomCarte`,`pointsMin`,`pointsMax`,`pointsDefense`,`nomAntidote`,`pointsAntidote`,`categorieCarte`) VALUES ('SD17','maléfice d\'aveuglement',0,0,2,'noirceur',1,2);
INSERT INTO `cartes` (`identifiant`,`nomCarte`,`pointsMin`,`pointsMax`,`pointsDefense`,`nomAntidote`,`pointsAntidote`,`categorieCarte`) VALUES ('SD18','maléfice de glu perpétuelle',0,0,3,'anti glu',1,2);
INSERT INTO `cartes` (`identifiant`,`nomCarte`,`pointsMin`,`pointsMax`,`pointsDefense`,`nomAntidote`,`pointsAntidote`,`categorieCarte`) VALUES ('SD19','maléfice d\'entrave',0,0,5,'anti entrave',2,2);
INSERT INTO `cartes` (`identifiant`,`nomCarte`,`pointsMin`,`pointsMax`,`pointsDefense`,`nomAntidote`,`pointsAntidote`,`categorieCarte`) VALUES ('SD26','reducto',0,0,3,'agrandissement',1,2);
INSERT INTO `cartes` (`identifiant`,`nomCarte`,`pointsMin`,`pointsMax`,`pointsDefense`,`nomAntidote`,`pointsAntidote`,`categorieCarte`) VALUES ('SD30','sortilège du repoustout',0,0,5,'attire tout',2,2);
/*!40000 ALTER TABLE `cartes` ENABLE KEYS */;
UNLOCK TABLES;

