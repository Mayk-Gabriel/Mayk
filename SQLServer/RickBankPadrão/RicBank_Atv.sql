-- Item 0
DROP TABLE #Contas

-- Item 1
CREATE TABLE #Contas(
						Id INT,
						IdCliente INT,
						IdAgencia INT,
						Numero VARCHAR(20),
						Tipo CHAR(1),
						Saldo DECIMAL(15,2),
						Situacao VARCHAR(20),
						DataAbertura DATETIME,
						SaldoMediaAgencia DECIMAL(15,2)
					)

-- Item 2
INSERT INTO #Contas (Id, IdCliente, IdAgencia, Numero, Tipo, Saldo, Situacao, DataAbertura)
	SELECT	Id, 
			IdCliente, 
			IdAgencia, 
			Numero, 
			Tipo, 
			Saldo, 
			Situacao, 
			DataAbertura

		FROM Conta

-- Item 3
SELECT *
	FROM #Contas

-- Item 4

DELETE #Contas
	
-- Item 5

INSERT INTO #Contas (Id, IdCliente, IdAgencia, Numero, Tipo, Saldo, Situacao, DataAbertura, SaldoMediaAgencia)
	SELECT	Id, 
			IdCliente, 
			IdAgencia, 
			Numero, 
			Tipo, 
			Saldo, 
			Situacao, 
			DataAbertura,
			(SELECT AVG(Saldo) AS Media
				FROM Conta as co2 
				WHERE co2.IdAgencia = co1.IdAgencia
				GROUP BY co2.IdAgencia)
		FROM Conta as co1;

-- Item 6

SELECT C.Saldo,
		SaldoMediaAgencia
	FROM #Contas C
ORDER BY C.Saldo ASC

-- Item 7

DELETE FROM #Contas
WHERE Id = (SELECT MIN(Id)
				FROM #Contas)

-- Item 8 

SELECT C.Saldo
	FROM #Contas C
ORDER BY C.Saldo ASC

-- Item 9

SELECT	*
	FROM #Contas C
WHERE Saldo > SaldoMediaAgencia
ORDER BY Saldo DESC

