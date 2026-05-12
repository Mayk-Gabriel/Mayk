
CREATE TABLE Cliente(
	Id INT IDENTITY,
	Nome VARCHAR (100) NOT NULL,
	Cpf CHAR (11) NOT NULL,
	Datanascimento DATE NOT NULL,
	Datacadastro DATETIME NOT NULL,
	Email VARCHAR (100) NOT NULL,

	CONSTRAINT ID PRIMARY KEY (Id)
);

CREATE TABLE Agencia (
						Id INT IDENTITY,
						NumeroAgencia VARCHAR (100) NOT NULL,
						NomeAgencia VARCHAR (100) NOT NULL,
						DataCadastro DATE NOT NULL,

						CONSTRAINT Id_Agencia PRIMARY KEY (Id)
                     );

CREATE TABLE Tipo (
					IdTipo INT,
					Nome VARCHAR (100)

					CONSTRAINT Id_Tipo PRIMARY KEY (IdTipo)
					)

INSERT INTO Tipo (IdTipo, Nome)
	VALUES (1, 'DebitoAltomatico'), (2, 'Cartão de Credito'), (3, 'Tranferencia '), (4, 'Agencia'), (5, 'Internete'), (6, 'PIX')


CREATE TABLE Conta (
					Id INT,
					IdCliente INT,
					IdAgencia INT NOT NULL,
					Numero INT NOT NULL,
					Datacadastro DATE NOT NULL,

					CONSTRAINT Id_Conta PRIMARY KEY (Id),
					CONSTRAINT FK_IdCliente FOREIGN KEY (IdCliente) REFERENCES CLiente (Id),
					CONSTRAINT FK_IdAgencia FOREIGN KEY (IdAgencia) REFERENCES Agencia (Id),
					)

CREATE TABLE Saldo (
					Id INT,
					IdConta INT NOT NULL,
					DataSaldo DATE NOT NULL,
					SaldoInicial DECIMAL (10,2) NOT NULL,
					Cretito DECIMAL (10, 2) NOT NULL,
					Debito DECIMAL (10, 2) NOT NULL

					CONSTRAINT Id_Saldo PRIMARY KEY (Id),
					CONSTRAINT FK_IdConta FOREIGN KEY (IdConta) REFERENCES Conta (Id)
					)

CREATE TABLE Lancamento (
						Id INT,
						DataLancamento DATE NOT NULL,
						Historico VARCHAR (200) NOT NULL,
						DEBCRE DECIMAL (10,2) NOT NULL,
						Valor DECIMAL (10,2) NOT NULL,

						CONSTRAINT Id_Lancamento PRIMARY KEY (Id)
						)


INSERT INTO Agencia (NumeroAgencia, NomeAgencia, DataCadastro)
	VALUES 
	( 1, 'Agencia Centro', '2020-01-02'),
	( 2, 'Agencia Manaira', '2021-02-02');

INSERT INTO Cliente (Nome, Cpf, Datanascimento, Datacadastro, Email)
	VALUES 
	('Mike Gabriel', '90282746321', '2003-02-02', '2020-03-06', 'mike@gmail.com'),
	('Bruno Lima', '12837409543', '2004-09-01', '2022-09-02', 'bruna@gmail.com'),
	('Carla Sousa', '33333333333', '1999-07-13', '2019-08-04','caela@gmail.com'),
	('Diego Alves', '44444444444', '1996-09-30', '2022-09-02', 'diego@gmail.com'),
	('Ana Costa', '11111111111', '1998-02-10', '2020-03-06', 'ana@gmail.com');


SELECT *
	FROM Saldo

INSERT INTO Conta (Id, IdCliente, IdAgencia, Numero, Datacadastro)
	VALUES 
	(1, 1, 1, 1000, GETDATE()),
	(2, 1, 2, 1001, GETDATE()),
	(3, 2, 1, 1002, GETDATE()),
	(4, 2, 2, 1002, GETDATE()),
	(5, 3, 1, 1003, GETDATE()),
	(6, 3, 2, 1003, GETDATE()),
	(7, 4, 1, 1004, GETDATE()),
	(8, 5, 1, 1005, GETDATE()),
	(9, 5, 2, 1006, GETDATE());
	

INSERT INTO Saldo (Id, IdConta, DataSaldo, SaldoInicial, Cretito, Debito)
	VALUES 
	(1, 1, GETDATE(), 0, 0, 0),
	(2, 2, GETDATE(), 0, 0, 0),
	(3, 3, GETDATE(), 0, 0, 0),
	(4, 4, GETDATE(), 0, 0, 0),
	(5, 5, GETDATE(), 0, 0, 0),
	(6, 6, GETDATE(), 0, 0, 0),
	(7, 7, GETDATE(), 0, 0, 0),
	(8, 8, GETDATE(), 0, 0, 0);

Ipar crsia dua 
pareds uma

criar scripr que incluam laçamento e atualizem saldo 30 lançamento
procidure