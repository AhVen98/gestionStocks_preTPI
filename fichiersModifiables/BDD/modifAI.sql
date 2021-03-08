-- MySQL Workbench Synchronization
-- Generated: 2021-03-08 12:20
-- Model: New Model
-- Version: 1.0
-- Project: Name of the project
-- Author: Paola.COSTA

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

ALTER SCHEMA `materiallocation`  DEFAULT CHARACTER SET utf8  DEFAULT COLLATE utf8_general_ci ;

ALTER TABLE `materiallocation`.`objects` 
DROP FOREIGN KEY `fk_objects_persons1`;

ALTER TABLE `materiallocation`.`types` 
DROP FOREIGN KEY `fk_types_categories1`;

ALTER TABLE `materiallocation`.`persons` 
DROP FOREIGN KEY `fk_persons_roles`;

ALTER TABLE `materiallocation`.`locations` 
DROP FOREIGN KEY `fk_locations_objects1`,
DROP FOREIGN KEY `fk_locations_persons1`,
DROP FOREIGN KEY `fk_locations_persons2`;

ALTER TABLE `materiallocation`.`objects` 
CHARACTER SET = utf8 , COLLATE = utf8_general_ci ,
DROP COLUMN `adder_id`,
DROP COLUMN `type_id`,
CHANGE COLUMN `id` `id` INT(11) NOT NULL AUTO_INCREMENT ,
CHANGE COLUMN `state` `state` VARCHAR(45) NOT NULL ,
ADD COLUMN `type_id` INT(11) NOT NULL AFTER `id`,
ADD COLUMN `adder_id` INT(11) NULL DEFAULT NULL AFTER `type_id`,
ADD INDEX `fk_objects_types1_idx` (`type_id` ASC),
ADD INDEX `fk_objects_persons1_idx` (`adder_id` ASC),
DROP INDEX `fk_objects_persons1_idx` ,
DROP INDEX `fk_objects_types1_idx` ;

ALTER TABLE `materiallocation`.`types` 
CHARACTER SET = utf8 , COLLATE = utf8_general_ci ,
DROP COLUMN `category_id`,
CHANGE COLUMN `id` `id` INT(11) NOT NULL AUTO_INCREMENT ,
ADD COLUMN `category_id` INT(11) NOT NULL AFTER `id`,
ADD INDEX `fk_types_categories1_idx` (`category_id` ASC),
DROP INDEX `fk_types_categories1_idx` ;

ALTER TABLE `materiallocation`.`categories` 
CHARACTER SET = utf8 , COLLATE = utf8_general_ci ,
CHANGE COLUMN `id` `id` INT(11) NOT NULL AUTO_INCREMENT ;

ALTER TABLE `materiallocation`.`persons` 
CHARACTER SET = utf8 , COLLATE = utf8_general_ci ,
DROP COLUMN `role_id`,
CHANGE COLUMN `id` `id` INT(11) NOT NULL AUTO_INCREMENT ,
ADD COLUMN `role_id` INT(11) NOT NULL AFTER `id`,
ADD INDEX `fk_persons_roles_idx` (`role_id` ASC),
DROP INDEX `fk_persons_roles_idx` ;

ALTER TABLE `materiallocation`.`roles` 
CHARACTER SET = utf8 , COLLATE = utf8_general_ci ,
CHANGE COLUMN `id` `id` INT(11) NOT NULL AUTO_INCREMENT ;

ALTER TABLE `materiallocation`.`locations` 
CHARACTER SET = utf8 , COLLATE = utf8_general_ci ,
DROP COLUMN `employee_id`,
DROP COLUMN `locator_id`,
DROP COLUMN `object_id`,
CHANGE COLUMN `id` `id` INT(11) NOT NULL AUTO_INCREMENT ,
ADD COLUMN `object_id` INT(11) NOT NULL AFTER `id`,
ADD COLUMN `locator_id` INT(11) NOT NULL AFTER `object_id`,
ADD INDEX `fk_locations_objects1_idx` (`object_id` ASC),
ADD INDEX `fk_locations_persons1_idx` (`locator_id` ASC),
ADD INDEX `fk_locations_persons2_idx` (`employee_id` ASC),
DROP INDEX `fk_locations_persons2_idx` ,
DROP INDEX `fk_locations_persons1_idx` ,
DROP INDEX `fk_locations_objects1_idx` ;

ALTER TABLE `materiallocation`.`objects` 
DROP FOREIGN KEY `fk_objects_types1`;

ALTER TABLE `materiallocation`.`objects` ADD CONSTRAINT `fk_objects_types1`
  FOREIGN KEY (`type_id`)
  REFERENCES `materiallocation`.`types` (`id`)
  ON DELETE RESTRICT
  ON UPDATE RESTRICT,
ADD CONSTRAINT `fk_objects_persons1`
  FOREIGN KEY (`adder_id`)
  REFERENCES `materiallocation`.`persons` (`id`)
  ON DELETE SET NULL
  ON UPDATE SET NULL;

ALTER TABLE `materiallocation`.`types` 
ADD CONSTRAINT `fk_types_categories1`
  FOREIGN KEY (`category_id`)
  REFERENCES `materiallocation`.`categories` (`id`)
  ON DELETE NO ACTION
  ON UPDATE NO ACTION;

ALTER TABLE `materiallocation`.`persons` 
ADD CONSTRAINT `fk_persons_roles`
  FOREIGN KEY (`role_id`)
  REFERENCES `materiallocation`.`roles` (`id`)
  ON DELETE RESTRICT
  ON UPDATE RESTRICT;

ALTER TABLE `materiallocation`.`locations` 
ADD CONSTRAINT `fk_locations_objects1`
  FOREIGN KEY (`object_id`)
  REFERENCES `materiallocation`.`objects` (`id`)
  ON DELETE RESTRICT
  ON UPDATE RESTRICT,
ADD CONSTRAINT `fk_locations_persons1`
  FOREIGN KEY (`locator_id`)
  REFERENCES `materiallocation`.`persons` (`id`)
  ON DELETE RESTRICT
  ON UPDATE RESTRICT,
ADD CONSTRAINT `fk_locations_persons2`
  FOREIGN KEY (`employee_id`)
  REFERENCES `materiallocation`.`persons` (`id`)
  ON DELETE SET NULL
  ON UPDATE SET NULL;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
