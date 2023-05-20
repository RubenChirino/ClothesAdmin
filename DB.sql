
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

## TODO
CREATE TABLE `clothes_store`.`product` (
  `id` INT NOT NULL,
  `name` VARCHAR(45) NOT NULL,
  `image` VARCHAR(150) NULL,
  `description` VARCHAR(100) NOT NULL,
  `size` ENUM('seller', 'admin') NOT NULL DEFAULT 'seller',
  PRIMARY KEY (`id`),
  UNIQUE INDEX `name_UNIQUE` (`name` ASC),
  UNIQUE INDEX `email_UNIQUE` (`email` ASC)
);