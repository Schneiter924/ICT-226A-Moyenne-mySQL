SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

CREATE SCHEMA IF NOT EXISTS `Eleves` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci ;
USE `Eleves` ;

-- -----------------------------------------------------
-- Table `Eleves`.`Eleve`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `Eleves`.`Eleve` (
  `idEleve` INT NOT NULL ,
  `Nom` VARCHAR(60) NOT NULL ,
  `Prenom` VARCHAR(60) NOT NULL ,
  `Moyenne` DECIMAL NOT NULL ,
  PRIMARY KEY (`idEleve`) )
ENGINE = INNODB;


-- -----------------------------------------------------
-- Table `Eleves`.`note`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `Eleves`.`note` (
  `idnote` INT NOT NULL ,
  `note` DECIMAL NOT NULL ,
  `Fk_Eleve` INT NOT NULL ,
  PRIMARY KEY (`idnote`, `Fk_Eleve`) ,
  INDEX `fk_note_Eleve_idx` (`Fk_Eleve` ASC) ,
  CONSTRAINT `fk_note_Eleve`
    FOREIGN KEY (`Fk_Eleve` )
    REFERENCES `Eleves`.`Eleve` (`idEleve` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = INNODB;

USE `Eleves` ;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
