USE `materialLocation` ;


-- -----------------------------------------------------
-- insertion in table categories
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
-- -----------------------------------------------------

INSERT INTO `types` VALUES 
(1,1,'visserie'),
(2,1,'boulonnerie'),
(3,5,''),
(4,1,''),
(5,1,''),
(6,5,''),
(7,5,''),
(8,2,'machines de transport'),
(9,2,'machines de levage'),
(10,7,'clés à molette'),
(11,7,'clés à cliquet'),
(12,2,'machine de forage'),
(13,2,'usine de mélange'),
(14,2,'machine pour aplanir'),
(15,1,'outils de bûcheron'),
(16,1,'outils de jardinage'),
(17,1,`outils d'entretien`),
(18,1,'outils de nettoyage'),
(19,5,'casques'),
(20,5,'gilets'),
;

-- -----------------------------------------------------
-- insertion in table objects
-- -----------------------------------------------------
INSERT INTO `objects` VALUES 
(1,'pelle'),
(2,'clé à molette'),
(3,'casque'),
(4,'pelle carrée'),
(5,'brouette'),
(6,'gilet de sécurité'),
(7,'casque anti-bruit'),
(8,'pelleteuse'),
(9,'dameuse'),