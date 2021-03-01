-- -----------------------------------------------------
-- project : materialLocation
-- filename : insertData
-- author : Paola Costa
-- version : 1.0
-- -----------------------------------------------------
USE `materialLocation` ;


-- -----------------------------------------------------
-- insertion in table roles
-- column : id, name
-- -----------------------------------------------------
INSERT INTO `roles` VALUES 
(1,'client'),
(2,'employé'),
(3,'administrateur')
;


-- -----------------------------------------------------
-- insertion in table categories
-- column : id, name
-- -----------------------------------------------------
INSERT INTO `categories` VALUES 
(1,'outils'),
(2,'machines'),
(5,'équipements de protection'),
(6,'divers'),
(7,'clés')
;


-- -----------------------------------------------------
-- insertion in table types
-- column : id, category_id, name
-- -----------------------------------------------------
INSERT INTO `types` VALUES 
(1,6,'visserie & boulonnerie'),
(2,6,'matériel de fêtes'),
(3,5,'outils de gestion'),
(4,2,'machines agricoles'),
(5,6,'conteneurs'),
(6,5,'matériel de signalisation'),
(7,6,'matériel pour échafaudage'),
(8,2,'machines de transport'),
(9,2,'machines de levage'),
(10,7,'clés à molette'),
(11,7,'clés à cliquet'),
(12,2,'machine de forage'),
(13,2,'usine de mélange'),
(14,2,'machine pour aplanir'),
(15,1,'outils de bûcheron'),
(16,1,'outils de jardinage'),
(17,1,'outils d\'entretien'),
(18,1,'outils de nettoyage'),
(19,5,'casques'),
(20,5,'gilets')
;


-- -----------------------------------------------------
-- insertion in table persons
-- column : id, role_id, firstname, lastname, birthdate, mail
-- -----------------------------------------------------
INSERT INTO `persons` VALUES 
(1,1,'Ann','Esthésie', '1990-08-02','ann.esthesie@gmail.com'),
(2,1,'Jean','Valjean', '1930-12-24','jean.valjean@gmail.com'),
(3,1,'Ellie','Minateur', '2000-08-30','ellie.minateur@gmail.com'),
(4,2,'Yann','Garuga', '1990-08-02','yann.garuga@gmail.com'),
(5,3,'Clarie','Fication', '1980-06-12','clarie.fication@gmail.com'),
(6,1,'Hans','Heur', '1975-01-01','hans.heur@gmail.com')
;


-- -----------------------------------------------------
-- insertion in table objects
-- column : id, type_id, adder_id, name, description, dateAdded, state, remark
-- -----------------------------------------------------
INSERT INTO `objects` (`id`, `type_id`, `adder_id`, `name`, `description`, `dateAdded`,`remark`
) VALUES 
(1, 16, 4,'pelle','pelle classique pour creuser des trous', '2020-01-01','manche abîmé'),
(4, 14, 5,'dameuse LS2059','dameuse 6m, jaune', '2020-01-01','peinture écaillée sur rétroviseur droit'),
(7, 3, 5,'ordinateur portable Dell1450','ordinateur de bureautique', '2020-01-01','manche abîmé'),
(8, 16, 4,'pelle','pelle classique pour creuser des trous', '2020-01-01','manche abîmé'),
(9, 16, 4,'pelle','pelle classique pour creuser des trous', '2020-01-01','manche abîmé')
;

INSERT INTO `objects` (`id`, `type_id`, `adder_id`, `name`, `description`, `dateAdded`) VALUES 
(2, 20, 4,'gilet de sécurité jaune','gilet du sécurité de couleur jaune, taille XL', '2020-01-01'),
(3, 4, 4,'tracteur JDX1020','tracteur john deer, modèle X, octobre 2020, vert', '2020-01-01'),
(5, 12, 5,'foreuse','foreuse 10m, noire', '2020-01-01'),
(6, 2, 4,'chapiteau de fête','chapiteau rond, diamètre 12m, poteaux fournis avec, hauteur sous plafond 4m', '2020-01-01')
;
-- -----------------------------------------------------
-- insertion in table locations
-- column : id, object_id, locator_id, employee_id, beginDateLocation, endDateLocation, effectiveReturnDate
-- -----------------------------------------------------
INSERT INTO `locations` VALUES 
(1, 2, 1,4,'2020-01-01', '2020-03-01','2020-03-01')
;


INSERT INTO `locations` (`id`, `object_id`, `locator_id`, `employee_id`,`beginDateLocation`, `endDateLocation`) VALUES 
(2, 6, 3,4,'2020-01-01', '2020-03-01')
;