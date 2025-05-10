CREATE DATABASE projetointegrador;
USE projetointegrador;
 
CREATE TABLE tb_clientes(
    	id_clientes int auto_increment,
    	nome varchar(50),
    	email varchar(50),
    	senha varchar(20),
    	endereco varchar(8),
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
("Baguete", 4.50, "https://raw.githubusercontent.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/refs/heads/main/imagensprojetointegrador/Pao%20baguete.jpg", 1),

("Frango Teriyaki", 6.00, "https://raw.githubusercontent.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/refs/heads/main/imagensprojetointegrador/Chicken%20teriyaki.jpg", 2),
("Frango Grelhado", 6.00,"https://github.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/blob/main/imagensprojetointegrador/Frango%20grelhado.jpeg", 2),
("Peito de Peru", 5.00,"https://github.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/blob/main/imagensprojetointegrador/Peito%20de%20Peru.jpeg", 2),
("Presunto", 4.00,"https://github.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/blob/main/imagensprojetointegrador/Presunto.jpeg", 2),
("Carne Moída", 6.00, "https://raw.githubusercontent.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/refs/heads/main/imagensprojetointegrador/carne-moida.jpg", 2),
("Carne Desfiada", 8.50,"https://github.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/blob/main/imagensprojetointegrador/Presunto.jpeg", 2),
("Churrasco", 8.00 ,"https://raw.githubusercontent.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/refs/heads/main/imagensprojetointegrador/Bife%20churrasco.jpg", 2),
("Bife de Peixe", 8.00, "https://raw.githubusercontent.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/refs/heads/main/imagensprojetointegrador/file%20de%20peixe%20empanado.jpg", 2),
("Peixe empanado", 10.00, "https://raw.githubusercontent.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/refs/heads/main/imagensprojetointegrador/peixe%20empanado.jpg, 2"),
("Atum", 8.00,"https://github.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/blob/main/imagensprojetointegrador/Atum.jpeg", 2)
("Salmão defumado", 9.00,"https://github.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/blob/main/imagensprojetointegrador/Salm%C3%A3o.jpeg", 2),
("Camarão", 7.50,"https://github.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/blob/main/imagensprojetointegrador/Camar%C3%A3o.jpg", 2),
("Falafel", 6.00,"https://github.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/blob/main/imagensprojetointegrador/Falafel.jpeg", 2),
("Tofu Grelhado", 6.50,"https://github.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/blob/main/imagensprojetointegrador/Tofu%20Grelhado.jpeg", 2),

("Cheddar", 6.00, "https://raw.githubusercontent.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/refs/heads/main/imagensprojetointegrador/chedar.jpg", 3),
("Gouda", 5.00, "https://raw.githubusercontent.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/refs/heads/main/imagensprojetointegrador/Gouda.jpg", 3),
("Prato", 4.00, "https://raw.githubusercontent.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/refs/heads/main/imagensprojetointegrador/Queijo-prato.png", 3),
("Mussarela", 3.50, "https://raw.githubusercontent.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/refs/heads/main/imagensprojetointegrador/queijo-mussarela.jpg", 3),
("Provolone", 2.00,"https://github.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/blob/main/imagensprojetointegrador/Provolone.jpeg", 3),
("Emmental", 3.50,"https://github.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/blob/main/imagensprojetointegrador/Emmental.jpg", 3),
("Parmesão", 4.00,"https://github.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/blob/main/imagensprojetointegrador/Parmes%C3%A3o.jpeg", 3),
("Brie", 5.00,"https://github.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/blob/main/imagensprojetointegrador/Brie.jpg", 3),
("Queijo Minas", 3.00,"https://github.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/blob/main/imagensprojetointegrador/Queijo%20minas.jpeg", 3),
("Camembert", 6.00,"https://github.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/blob/main/imagensprojetointegrador/Camembert.jpeg", 3),
("Queijo Coalho", 4.00,"https://github.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/blob/main/imagensprojetointegrador/Queijo%20Coalho.jpeg", 3),
("Ricota", 3.50,"https://github.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/blob/main/imagensprojetointegrador/Ricota.jpeg", 3),
("Roquefort", 5.00,"https://github.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/blob/main/imagensprojetointegrador/Roquefort.jpeg", 3),
("Cream Cheese", 2.50,"https://github.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/blob/main/imagensprojetointegrador/Cream%20cheese.jpeg", 3),
("Gorgonzola", 2.00,"https://github.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/blob/main/imagensprojetointegrador/Gorgonzola.jpeg", 3),
("Queijo de Cabra", 4.50,"https://github.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/blob/main/imagensprojetointegrador/Queijo%20de%20Cabra.jpeg", 3),
("Edam", 4.00,"https://github.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/blob/main/imagensprojetointegrador/Edam.jpg", 3),
("Gruyère", 5.00,"https://github.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/blob/main/imagensprojetointegrador/gruyere.png", 3),
("Queijo Reino", 3.50,"https://github.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/blob/main/imagensprojetointegrador/Reino.jpeg", 3),
("Havarti", 6.00,"https://github.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/blob/main/imagensprojetointegrador/Havarti.jpeg", 3),
	
("Alface", 2.00, "https://terraadubada.com.br/wp-content/uploads/2023/10/Alface-Crespa-Organico-510x510.jpg", 4),
("Tomate", 1.50, "https://raw.githubusercontent.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/refs/heads/main/imagensfaltando/Tomate.jpg", 4),
("Cebola", 2.50, "https://raw.githubusercontent.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/refs/heads/main/imagensprojetointegrador/cebola%20roxa.jpg", 4),
("Picles", 3.00, "https://raw.githubusercontent.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/refs/heads/main/imagensprojetointegrador/picles.jpg", 4),
("Salada de Abacate, Tomate e Cebola", 4.00,"https://github.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/blob/main/imagensprojetointegrador/Salada%20de%20Abacate%2C%20Tomate%2C%20Cebola.jpg", 4)
("Salada de Brotos com Molho Oriental", 4.50,"https://github.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/blob/main/imagensprojetointegrador/Salada%20de%20Brotos%20com%20Molho%20Oriental.jpeg", 4)
("Salada Grega", 4.50,"https://github.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/blob/main/imagensprojetointegrador/Salda%20Grega%20Jpeg.jpeg", 4)
("Salada Caprese", 5.00,"https://github.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/blob/main/imagensprojetointegrador/Salada%20Caprese.jpg", 4)
	
("Maionese", 3.00, "https://raw.githubusercontent.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/refs/heads/main/imagensprojetointegrador/maionese.jpg", 5),
("Molho Tártaro", 4.00, "https://raw.githubusercontent.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/refs/heads/main/imagensfaltando/Molho%20Tartaro%20(1).jpg", 5),
("Ketchup", 3.00, "https://raw.githubusercontent.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/refs/heads/main/imagensprojetointegrador/ketchup.jpg", 5),
("Mostarda", 3.00,"https://raw.githubusercontent.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/refs/heads/main/imagensprojetointegrador/Molho-mostarda.jpg", 5),
("Molho Verde", 4.50, "https://raw.githubusercontent.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/refs/heads/main/imagensprojetointegrador/molho%20verde.jpg", 5),
("Molho de Iorgute", 4.50,"https://github.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/blob/main/imagensprojetointegrador/molho%20de%20Iogurte.jpeg", 5)
("Molho Verde", 4.00,"https://github.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/blob/main/imagensprojetointegrador/molho%20verde.jpg", 5)
("Molho de Alho", 4.50,"https://github.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/blob/main/imagensprojetointegrador/Molho%20de%20Alho.jpg", 5)
("Molho Vinagrete", 3.50,"https://github.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/blob/main/imagensprojetointegrador/Vinagrete.jpeg", 5)
("Molho de Limão com Iogurte", 6.00,"https://github.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/blob/main/imagensprojetointegrador/Molho%20de%20Lim%C3%A3o%20com%20Iogurte.jpg", 5)
("Molho de Mostarda e Mel", 5.50,"https://github.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/blob/main/imagensprojetointegrador/Molho%20de%20Mostarda%20e%20Mel.jpeg", 5)
	
("Coca Cola", 5.00, "https://raw.githubusercontent.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/refs/heads/main/imagensfaltando/Coca%20Cola.png", 6),
("Coca Cola Zero", 5.00 "https://raw.githubusercontent.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/refs/heads/main/imagensprojetointegrador/Coca%20Zero.png", 6),
("Fanta Uva", 4.00, "https://raw.githubusercontent.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/refs/heads/main/imagensprojetointegrador/Fanta%20Uva.jpg", 6),
("Fanta Laranja", 4.00, "https://raw.githubusercontent.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/refs/heads/main/imagensfaltando/1990-refrigerante-fanta-laranja-lata-220ml.jpg", 6),
("Pepsi", 3.00, "https://raw.githubusercontent.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/refs/heads/main/imagensprojetointegrador/Pepsi.jpg", 6),
("Sprite", 3.00, "https://raw.githubusercontent.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/refs/heads/main/imagensprojetointegrador/Sprite.jpg", 6),
("Guaraná", 3.00, "https://raw.githubusercontent.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/refs/heads/main/imagensprojetointegrador/Guarana.png", 6),
("Água com Gás e Limão", 3.00,"https://github.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/blob/main/imagensprojetointegrador/Agua%20com%20G%C3%A1s%20e%20Lim%C3%A3o.jpeg",6),
("Chá Gelado", 4.00,"https://github.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/blob/main/imagensprojetointegrador/Ch%C3%A1%20gelado.jpg", 6),
		
("Suco de Laranja", 2.50,"https://github.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/blob/main/imagensprojetointegrador/Suco%20de%20Laranja.jpeg", 6),
("Suco de maçã", 2.00,"https://github.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/blob/main/imagensprojetointegrador/Suco%20de%20Ma%C3%A7%C3%A3%20Jpeg.jpeg", 6),
("Suco de Uva", 2.00,"https://github.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/blob/main/imagensprojetointegrador/Suco%20de%20Uva.jpeg", 6),
("Suco de Abacaxi", 2.00,"https://github.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/blob/main/imagensprojetointegrador/Suco%20de%20Abacaxi.jpeg", 6),
("Suco de Manga", 2.00,"https://github.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/blob/main/imagensprojetointegrador/Suco%20de%20Manga.jpeg", 6),
("Suco de Morango", 2.00,"https://github.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/blob/main/imagensprojetointegrador/Suco%20de%20Morango.jpeg", 6),
("Suco de Limão", 2.00,"https://github.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/blob/main/imagensprojetointegrador/Suco%20de%20Lim%C3%A3o.jpeg", 6),
("Suco de Goiaba", 2.00,"https://github.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/blob/main/imagensprojetointegrador/Suco%20de%20Goiaba.jpg", 6),
("Suco de Maracujá", 2.00,"https://github.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/blob/main/imagensprojetointegrador/Suco%20de%20Maracuj%C3%A1.jpeg", 6),
("Suco de Acerola", 2.00,"https://github.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/blob/main/imagensprojetointegrador/Suco%20de%20Acerola.jpeg", 6),
("Suco de Caju", 2.00,"https://github.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/blob/main/imagensprojetointegrador/Suco%20de%20Caju%20Jpeg.jpg", 6),
("Suco de Pêssego", 2.00,"https://github.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/blob/main/imagensprojetointegrador/Suco%20de%20Pessego.jpeg", 6),
("Suco de Melancia", 2.00,"https://github.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/blob/main/imagensprojetointegrador/Suco%20de%20Melancia%20jpeg.jpeg", 6),
		
("Batata Crinke", 2.50, "https://raw.githubusercontent.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/refs/heads/main/imagensprojetointegrador/Crinkle.jpg", 7),
("Batata Rustica", 3.50, "https://hirotafood.com.br/wp-content/uploads/2019/12/batata-rustica-1.jpg", 7),
("Batata Rústica com Ervas", 4.00,"https://github.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/blob/main/imagensprojetointegrador/Rustica%20com%20ervas.png", 7),
("Batata com Cheddar e Bacon", 4.00,"https://github.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/blob/main/imagensprojetointegrador/Cheddar%20e%20Bacon.jpeg", 7),
("Batata Smile", 4.00,"https://github.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/blob/main/imagensprojetointegrador/Batata%20Smile.jpg", 7),
("Batata Palito", 2.00, "https://raw.githubusercontent.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/refs/heads/main/imagensfaltando/Batata%20Palito.png", 7),
 
("Bacon", 5.00, "https://raw.githubusercontent.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/refs/heads/main/imagensprojetointegrador/Bacon.jpg", 8),
("Bacon Bovino", 5.50, "https://raw.githubusercontent.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/refs/heads/main/imagensprojetointegrador/bacon%20bovino.jpg", 8),
("Pastrame", 6.00, "https://raw.githubusercontent.com/AlexLima6/Projeto-Senac-Serasa-Transforme-se/refs/heads/main/imagensprojetointegrador/Pastrami.jpg", 8);

select * from tb_categoria;
update tb_produto set descricao = " " where id_produto > 0;

/*INSERT INTO tb_produtos(nome, valor, url_imagem, id_categoria) VALUES
	("Teste", 00.00, "Teste", 0)*/
 
SELECT * FROM tb_produtos;
SELECT * FROM tb_categoria;
SELECT * FROM tb_clientes;
 
SELECT tb_produtos.*, tb_categoria.nome AS 'nome_categoria'

FROM tb_produtos INNER JOIN tb_categoria ON tb_categoria.id_categoria = 
tb_produtos.id_categoria;
 
SELECT tb_produtos.*, tb_categoria.nome AS 'nome_categoria' FROM tb_produtos INNER JOIN tb_categoria ON tb_categoria.id_categoria = tb_produtos.id_categoria;
 
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
    
    
    
    
    
