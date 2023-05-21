
CREATE SCHEMA `clothes_store`;

CREATE TABLE `clothes_store`.`user` (
  `id` INT NOT NULL,
  `name` VARCHAR(45) NOT NULL,
  `password` VARCHAR(150) NULL,
  `email` VARCHAR(100) NOT NULL,
  `role` ENUM('seller', 'admin') NOT NULL DEFAULT 'seller',
  PRIMARY KEY (`id`),
  UNIQUE INDEX `name_UNIQUE` (`name` ASC),
  UNIQUE INDEX `email_UNIQUE` (`email` ASC)
);

CREATE TABLE `clothes_store`.`product` (
  `id` INT NOT NULL,
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