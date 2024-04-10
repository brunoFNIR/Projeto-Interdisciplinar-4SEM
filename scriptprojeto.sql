create database VidracariaAgvan;

use VidracariaAgvan;

create table Agendamento(
id BIGINT NOT NULL AUTO_INCREMENT,
nome VARCHAR (255),
numero_celular VARCHAR (255),
endereco VARCHAR (255),
ordem_servico VARCHAR(255),
data_medicao DATE,
status_medicao ENUM ('Concluído', 'Pendente'),
data_instalacao DATE,
status_instalacao ENUM ('Concluído', 'Pendente'),
pagamento_total_concluido ENUM ('Sim', 'Não'),
valor_total DOUBLE,
primary key (id) 
);

create table Cliente(
id BIGINT NOT NULL AUTO_INCREMENT,
nome VARCHAR(255),
rg VARCHAR (255),
cpf VARCHAR (255),
data_nascimento DATE,
numero_celular VARCHAR (255),
endereco VARCHAR (255),
primary key (id)
);

create table Produto(
id BIGINT NOT NULL AUTO_INCREMENT,
produto VARCHAR(255),
tipo_produto VARCHAR (255),
quantidade INT,
fornecedor VARCHAR (255),
primary key (id)
);

INSERT INTO Agendamento VALUES (
null,
'Ronaldo da Silva',
'1199999 9999',
'Rua Marechal Deodoro, 105, Mooca',
'Instalação Porta de Vidro',
'2022-12-01',
'Concluído',
'2022-12-05',
'Concluído',
'Sim',
750
);

INSERT INTO Agendamento VALUES (
null,
'Endrick Carneiro',
'1198888 8888',
'Rua Turiassu, 105, Barra Funda',
'Instalação Janela a prova de som ',
'2022-11-05',
'Concluído',
'2022-11-20',
'Concluído',
'Sim',
2300
);

INSERT INTO Cliente VALUES(
null,
'Ronaldo da Silva',
'55.555.555.5',
'444.444.444.44',
'1969-05-20',
'1199999 9999',
'Rua Marechal Deodoro, 105, Mooca'
);

INSERT INTO Cliente VALUES(
null,
'Endrick Carneiroa',
'66.666.666.6',
'333.333.333.33',
'2000-07-16',
'1198888 8888',
'Rua Palestra Italia, 105, Vila Pompeia'
);

INSERT INTO Produto VALUES(
null,
'Porta de Vidro ',
'Vidro - 2,10 X 2,00',
5,
'Portas e Janelas LTDA'
);

INSERT INTO Produto VALUES(
null,
'Janela a prova de som',
'Vidro acústico - 1,20 X 1,20',
3,
'Portas e Janelas LTDA'
)