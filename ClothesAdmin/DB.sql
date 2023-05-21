
CREATE SCHEMA `clothes_store`;

CREATE TABLE `clothes_store`.`user` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(45) NOT NULL,
  `password` VARCHAR(150) NULL,
  `email` VARCHAR(100) NOT NULL,
  `role` ENUM('seller', 'admin') NOT NULL DEFAULT 'seller',
  PRIMARY KEY (`id`),
  UNIQUE INDEX `name_UNIQUE` (`name` ASC),
  UNIQUE INDEX `email_UNIQUE` (`email` ASC)
);

CREATE TABLE `clothes_store`.`product` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(100) NOT NULL,
  `image` TEXT NOT NULL,
  `description` VARCHAR(150) NOT NULL,
  `stock` INT(11) NOT NULL,
  `price` DECIMAL(32,0) NOT NULL,
  `color` VARCHAR(45) NOT NULL,
  `size` ENUM('XS', 'S', 'M', 'L', 'XL', 'XXL', 'XXXL') NOT NULL,
  `categorie` ENUM('casual', 'elegant', 'formal', 'office') NOT NULL,
  PRIMARY KEY (`id`)
);

CREATE TABLE `clothes_store`.`client` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `dni` VARCHAR(45) NOT NULL,
  `email` VARCHAR(45) NULL,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `dni_UNIQUE` (`dni` ASC),
  UNIQUE INDEX `email_UNIQUE` (`email` ASC)
);

CREATE TABLE `clothes_store`.`sale` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `total` DECIMAL NULL,
  `id_user` INT NULL,
  `id_product` INT NULL,
  `id_client` INT NULL,
  PRIMARY KEY (`id`),
  CONSTRAINT `id_user`
    FOREIGN KEY (`id_user`)
    REFERENCES `clothes_store`.`user` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `id_product`
    FOREIGN KEY (`id_product`)
    REFERENCES `clothes_store`.`product` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION),
  CONSTRAINT `id_client`
    FOREIGN KEY (`id_client`)
    REFERENCES `clothes_store`.`client` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);
