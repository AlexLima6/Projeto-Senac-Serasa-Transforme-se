CREATE DATABASE projetointegrador;
USE projetointegrador;
 
CREATE TABLE tb_clientes(
    id_clientes int auto_increment,
    nome varchar(50),
    email varchar(50),
    senha varchar(20),
    endereco varchar(100),
    primary key (id_clientes)
);
SELECT * FROM tb_clientes;
SELECT nome AS "Cliente" FROM tb_clientes;
 
CREATE TABLE tb_categoria(
	id_categoria int auto_increment,
	nome varchar(20),
	primary key (id_categoria)
);
select * from tb_categoria;
drop table tb_categoria;
drop table tb_produtos;
INSERT INTO tb_categoria(nome) VALUES
("Pães"),
("Recheios"),
("Queijos"),
("Saladas"),
("Molhos"),
("Bebidas"),
("Batatas"),
("Complementos");
 

CREATE TABLE tb_produtos(
    id_produtos int auto_increment,
    nome varchar(20),
    descricao varchar(100),
    valor decimal(6, 2),
    url_imagem varchar (150),
    blob_image mediumblob,
	id_categoria int,
    foreign key (id_categoria) references tb_categoria(id_categoria),
    primary key (id_produtos)
);
 
INSERT INTO tb_produtos(nome, valor, url_imagem, id_categoria) VALUES
("Ciabatta", 4.50, "https://raw.githubusercontent.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/refs/heads/main/imagensprojetointegrador/P%C3%A3o%20Ciabatta.jpg", 1),
("Pão Italiano", 2.00, "https://raw.githubusercontent.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/refs/heads/main/imagensprojetointegrador/Pao%20Italiano.jpg", 1),
("Pão Parmesão", 5.00, "https://raw.githubusercontent.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/refs/heads/main/imagensprojetointegrador/Pao%20Parmesao.jpg", 1),
("Baguete", 4.50, "https://raw.githubusercontent.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/refs/heads/main/imagensprojetointegrador/Pao%20baguete.jpg", 1);
 
INSERT INTO tb_produtos(nome, valor, url_imagem, id_categoria) VALUES
("Frango Teriyaki", 6.00, "https://raw.githubusercontent.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/refs/heads/main/imagensprojetointegrador/Chicken%20teriyaki.jpg", 2),
("Carne Moída", 6.00, "https://raw.githubusercontent.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/refs/heads/main/imagensprojetointegrador/carne-moida.jpg", 2),
("Churrasco", 12.00 ,"https://raw.githubusercontent.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/refs/heads/main/imagensprojetointegrador/Bife%20churrasco.jpg", 2),
("Bife de Peixe", 8.00, "https://raw.githubusercontent.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/refs/heads/main/imagensprojetointegrador/file%20de%20peixe%20empanado.jpg", 2);
("Peixe empanado", 10.00, "https://raw.githubusercontent.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/refs/heads/main/imagensprojetointegrador/peixe%20empanado.jpg, 2")
	
INSERT INTO tb_produtos(nome, valor, url_imagem, id_categoria) VALUES
("Cheddar", 6.00, "https://raw.githubusercontent.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/refs/heads/main/imagensprojetointegrador/chedar.jpg", 3),
("Gouda", 5.00, "https://raw.githubusercontent.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/refs/heads/main/imagensprojetointegrador/Gouda.jpg", 3),
("Prato", 4.00, "https://raw.githubusercontent.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/refs/heads/main/imagensprojetointegrador/Queijo-prato.png", 3),
("Mussarela", 3.50, "https://raw.githubusercontent.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/refs/heads/main/imagensprojetointegrador/queijo-mussarela.jpg", 3);
 
select * from tb_categoria;
update tb_produto set descricao = " " where id_produto > 0;
INSERT INTO tb_produtos(nome, valor, url_imagem, id_categoria) VALUES
("Alface", 2.00, "https://terraadubada.com.br/wp-content/uploads/2023/10/Alface-Crespa-Organico-510x510.jpg", 4),
("Tomate", 1.50, "https://raw.githubusercontent.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/refs/heads/main/imagensfaltando/Tomate.jpg", 4),
("Cebola", 2.50, "https://raw.githubusercontent.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/refs/heads/main/imagensprojetointegrador/cebola%20roxa.jpg", 4),
("Picles", 3.00, "https://raw.githubusercontent.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/refs/heads/main/imagensprojetointegrador/picles.jpg", 4),
 
("Maionese", 3.00, "https://raw.githubusercontent.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/refs/heads/main/imagensprojetointegrador/maionese.jpg", 5),
("Molho Tártaro", 4.00, "https://raw.githubusercontent.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/refs/heads/main/imagensfaltando/Molho%20Tartaro%20(1).jpg", 5),
("Ketchup", 3.00, "https://raw.githubusercontent.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/refs/heads/main/imagensprojetointegrador/ketchup.jpg", 5),
("Mostarda", 3.00,"https://raw.githubusercontent.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/refs/heads/main/imagensprojetointegrador/Molho-mostarda.jpg", 5),
("Molho Verde", 4.50, "https://raw.githubusercontent.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/refs/heads/main/imagensprojetointegrador/molho%20verde.jpg", 5),
 
("Coca Cola", 4.00, "https://raw.githubusercontent.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/refs/heads/main/imagensfaltando/Coca%20Cola.png", 6),
("Coca Cola Zero", 5.00, "https://raw.githubusercontent.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/refs/heads/main/imagensprojetointegrador/Coca%20Zero.png", 6),
("Fanta Uva", 2.00, "https://raw.githubusercontent.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/refs/heads/main/imagensprojetointegrador/Fanta%20Uva.jpg", 6),
("Fanta Laranja", 2.00, "https://raw.githubusercontent.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/refs/heads/main/imagensfaltando/1990-refrigerante-fanta-laranja-lata-220ml.jpg", 6),
("Pepsi", 1.50, "https://raw.githubusercontent.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/refs/heads/main/imagensprojetointegrador/Pepsi.jpg", 6),
("Sprite", 1.50, "https://raw.githubusercontent.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/refs/heads/main/imagensprojetointegrador/Sprite.jpg", 6),
("Guaraná", 3.00, "https://raw.githubusercontent.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/refs/heads/main/imagensprojetointegrador/Guarana.png", 6),
 
("Crinke", 2.50, "https://raw.githubusercontent.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/refs/heads/main/imagensprojetointegrador/Crinkle.jpg", 7),
("Rustica", 3.50, "https://hirotafood.com.br/wp-content/uploads/2019/12/batata-rustica-1.jpg", 7),
("Palito", 2.00, "https://raw.githubusercontent.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/refs/heads/main/imagensfaltando/Batata%20Palito.png", 7),
 
("Bacon", 5.00, "https://raw.githubusercontent.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/refs/heads/main/imagensprojetointegrador/Bacon.jpg", 8),
("Bacon Bovino", 5.50, "https://raw.githubusercontent.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/refs/heads/main/imagensprojetointegrador/bacon%20bovino.jpg", 8),
("Pastrame", 6.00, "https://raw.githubusercontent.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/refs/heads/main/imagensprojetointegrador/Pastrami.jpg", 8);
 
SELECT * FROM tb_produtos;
SELECT * FROM tb_categoria;
SELECT * FROM tb_clientes;
 
SELECT tb_produtos.*, tb_categoria.nome AS 'nome_categoria'

FROM tb_produtos INNER JOIN tb_categoria ON tb_categoria.id_categoria = 
tb_produtos.id_categoria;
 
SELECT tb_produtos.*, tb_categoria.nome AS 'nome_categoria' FROM tb_produtos INNER JOIN tb_categoria ON tb_categoria.id_categoria = tb_produtos.id_categoria;
 
/*SELECT * FROM tb_produtos
INNER JOIN tb_produtos ON tb_categoria.id_produtos =
tb_produtos.id_produtos;*/
 
CREATE TABLE tb_delivery(
	id_nota int auto_increment,
    nome varchar (20),
    id_produtos int auto_increment,
    endereco varchar (7),
    preço decimal (3, 2),
    primary key (id_nota),
    foreign key (id_produtos) references tb_produtos(id_produtos)
);
 
CREATE TABLE tb_nota(
	id_cliente int auto_increment,
	nome varchar(20),
	telefone varchar(11),
	endereco varchar (7),
	Pedido varchar (22),
	id_pedido int auto_increment,
	horário datetime (4),
	id_cliente int auto_increment,
	Produto varchar(50),
	id_produto int auto_increment, 
	nome varchar(20),
	descrição varchar (50),
	preço decimal (3, 2),
	id_pedido int auto_increment,
	id_produto int auto_increment,
	quantidade varchar (1),
	subtotal decimal (3,2),
    primary key (id_cliente),
    primary key (id_pedido)
    
    )
    
    
    
    
    
