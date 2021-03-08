-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

-- -----------------------------------------------------
-- Schema materialLocation
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema materialLocation
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `materialLocation` DEFAULT CHARACTER SET utf8 ;
USE `materialLocation` ;

-- -----------------------------------------------------
-- Table `materialLocation`.`categories`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `materialLocation`.`categories` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(30) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `id_UNIQUE` (`id` ASC),
  UNIQUE INDEX `name_UNIQUE` (`name` ASC))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `materialLocation`.`types`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `materialLocation`.`types` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `category_id` INT NOT NULL,
  `name` VARCHAR(30) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `id_UNIQUE` (`id` ASC),
  UNIQUE INDEX `name_UNIQUE` (`name` ASC),
  INDEX `fk_types_categories1_idx` (`category_id` ASC),
  CONSTRAINT `fk_types_categories1`
    FOREIGN KEY (`category_id`)
    REFERENCES `materialLocation`.`categories` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `materialLocation`.`roles`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `materialLocation`.`roles` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `id_UNIQUE` (`id` ASC),
  UNIQUE INDEX `name_UNIQUE` (`name` ASC))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `materialLocation`.`persons`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `materialLocation`.`persons` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `role_id` INT NOT NULL,
  `firstname` VARCHAR(45) NOT NULL,
  `lastname` VARCHAR(45) NOT NULL,
  `birthdate` DATE NOT NULL,
  `mail` VARCHAR(60) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `id_UNIQUE` (`id` ASC),
  INDEX `fk_persons_roles_idx` (`role_id` ASC),
  UNIQUE INDEX `person_UNIQUE` (`firstname` ASC, `lastname` ASC, `birthdate` ASC),
  CONSTRAINT `fk_persons_roles`
    FOREIGN KEY (`role_id`)
    REFERENCES `materialLocation`.`roles` (`id`)
    ON DELETE RESTRICT
    ON UPDATE RESTRICT)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `materialLocation`.`objects`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `materialLocation`.`objects` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `type_id` INT NOT NULL,
  `adder_id` INT NULL,
  `name` VARCHAR(45) NOT NULL,
  `description` VARCHAR(200) NOT NULL,
  `dateAdded` DATE NOT NULL,
  `state` VARCHAR(45) NOT NULL,
  `remark` VARCHAR(50) NULL,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `id_UNIQUE` (`id` ASC),
  INDEX `fk_objects_types1_idx` (`type_id` ASC),
  INDEX `fk_objects_persons1_idx` (`adder_id` ASC),
  CONSTRAINT `fk_objects_types1`
    FOREIGN KEY (`type_id`)
    REFERENCES `materialLocation`.`types` (`id`)
    ON DELETE RESTRICT
    ON UPDATE RESTRICT,
  CONSTRAINT `fk_objects_persons1`
    FOREIGN KEY (`adder_id`)
    REFERENCES `materialLocation`.`persons` (`id`)
    ON DELETE SET NULL
    ON UPDATE SET NULL)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `materialLocation`.`locations`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `materialLocation`.`locations` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `object_id` INT NOT NULL,
  `locator_id` INT NOT NULL,
  `employee_id` INT NULL,
  `beginDateLocation` DATE NOT NULL,
  `endDateLocation` DATE NOT NULL,
  `effectiveReturnDate` DATE NULL,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `id_UNIQUE` (`id` ASC),
  INDEX `fk_locations_objects1_idx` (`object_id` ASC),
  INDEX `fk_locations_persons1_idx` (`locator_id` ASC),
  INDEX `fk_locations_persons2_idx` (`employee_id` ASC),
  CONSTRAINT `fk_locations_objects1`
    FOREIGN KEY (`object_id`)
    REFERENCES `materialLocation`.`objects` (`id`)
    ON DELETE RESTRICT
    ON UPDATE RESTRICT,
  CONSTRAINT `fk_locations_persons1`
    FOREIGN KEY (`locator_id`)
    REFERENCES `materialLocation`.`persons` (`id`)
    ON DELETE RESTRICT
    ON UPDATE RESTRICT,
  CONSTRAINT `fk_locations_persons2`
    FOREIGN KEY (`employee_id`)
    REFERENCES `materialLocation`.`persons` (`id`)
    ON DELETE SET NULL
    ON UPDATE SET NULL)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
