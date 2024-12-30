use projetoloja;
CREATE TABLE `usuario` (
	`id` INT NOT NULL AUTO_INCREMENT,
	`nome` VARCHAR(200) NOT NULL,
	`username` VARCHAR(64) NOT NULL UNIQUE,
	`senha` VARCHAR(64) NOT NULL,
	`cargo` VARCHAR(32) NOT NULL,
	PRIMARY KEY (`id`)
);

CREATE TABLE `produto` (
	`id` INT NOT NULL AUTO_INCREMENT,
	`nome` VARCHAR(64) NOT NULL,
	`descricao` TEXT NOT NULL,
	`preco` FLOAT NOT NULL,
	`quantidade_estoque` INT NOT NULL,
	`categoria_id` INT NOT NULL,
	`fornecedor_id` INT NOT NULL,
	`tamanho` INT NOT NULL,
	PRIMARY KEY (`id`)
);

CREATE TABLE `fornecedor` (
	`id` INT NOT NULL AUTO_INCREMENT,
	`nome` VARCHAR(200) NOT NULL UNIQUE,
	`cnpj` VARCHAR(18) NOT NULL UNIQUE,
	`contato_empresa` TEXT(200) NOT NULL,
	`representante` TEXT(200) NOT NULL,
	`telefone` VARCHAR(200) NOT NULL,
	`endereco` VARCHAR(200) NOT NULL,
	`email` VARCHAR(200) NOT NULL,
	PRIMARY KEY (`id`)
);

CREATE TABLE `categoria` (
	`id` INT NOT NULL AUTO_INCREMENT,
	`nome` VARCHAR(32) NOT NULL,
	PRIMARY KEY (`id`)
);

CREATE TABLE `venda` (
	`id` INT NOT NULL AUTO_INCREMENT,
	`usuario_id` INT NOT NULL,
	`data` DATETIME NOT NULL,
	`valor_total` FLOAT NOT NULL,
	`desconto` FLOAT NOT NULL,
	PRIMARY KEY (`id`)
);

CREATE TABLE `itens_venda` (
	`id` INT NOT NULL AUTO_INCREMENT,
	`venda_id` INT NOT NULL,
	`prorduto_id` INT NOT NULL,
	`quantidade` INT NOT NULL,
	PRIMARY KEY (`id`)
);

ALTER TABLE `produto` ADD CONSTRAINT `produto_fk0` FOREIGN KEY (`categoria_id`) REFERENCES `categoria`(`id`);

ALTER TABLE `produto` ADD CONSTRAINT `produto_fk1` FOREIGN KEY (`fornecedor_id`) REFERENCES `fornecedor`(`id`);

ALTER TABLE `venda` ADD CONSTRAINT `venda_fk0` FOREIGN KEY (`usuario_id`) REFERENCES `usuario`(`id`);

ALTER TABLE `itens_venda` ADD CONSTRAINT `itens_venda_fk0` FOREIGN KEY (`venda_id`) REFERENCES `venda`(`id`);

ALTER TABLE `itens_venda` ADD CONSTRAINT `itens_venda_fk1` FOREIGN KEY (`prorduto_id`) REFERENCES `produto`(`id`);






