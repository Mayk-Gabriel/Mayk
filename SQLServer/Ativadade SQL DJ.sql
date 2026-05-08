/*2. JOINs básicos*/

/*	21. Liste o nome de cada animal junto com o nome do seu cliente/dono.*/

SELECT	C.Nome,
		A.Nome
	FROM Animal A
		JOIN Cliente C
			ON C.Id = A.IdCliente

/*22. Liste o nome do animal, a espécie e a raça.*/

SELECT  A.Nome,
		R.Nome,
		E.Nome
	FROM Animal A
		JOIN Raca R
			ON R.Id = A.IdRaca
		JOIN Especie E
			ON E.Id = R.IdEspecie
ORDER BY A.Nome

/*23. Liste todos os animais com seus respectivos donos, mesmo que algum dado relacionado esteja incompleto.*/

SELECT	C.Nome,
		A.Nome
	FROM Animal A
		JOIN Cliente C 
			ON C.Id = A.IdCliente
ORDER BY C.Nome

/*24. Liste todos os clientes e seus animais, incluindo clientes que ainda não têm animal cadastrado.*/

/*25. Liste os produtos junto com suas categorias.*/

SELECT	P.Nome,
		Cp.Nome
	FROM Produto P
		JOIN CategoriaProduto Cp
			ON Cp.Id = P.IdCategoriaProduto
ORDER BY P.Nome

/*26. Liste as vendas junto com o nome do cliente que realizou a compra.*/

SELECT	Cl.Nome,
		V.StatusVenda,
		V.ValorTotal
	FROM Venda V
		JOIN Cliente Cl 
			ON Cl.Id = V.IdCliente
ORDER BY Cl.Nome

/*27. Liste os pagamentos junto com a venda correspondente e o tipo de pagamento usado.*/

SELECT P.Valor,
		V.StatusVenda,
		Tp.Nome
	FROM Pagamento P
		JOIN TipoPagamento Tp 
			ON Tp.Id = P.IdTipoPagamento
		JOIN Venda V 
			ON V.Id = P.IdVenda

/*28. Liste os produtos vendidos em cada venda.*/

SELECT	P.Nome,
		V.StatusVenda,
		V.ValorTotal
	FROM VendaProduto Vp
		JOIN Venda V
			ON V.Id = Vp.IdVenda
		JOIN Produto P
			ON P.Id = Vp.IdProduto 
	WHERE V.StatusVenda = 'Paga'

/*29. Liste o nome do produto, quantidade vendida e valor unitário em cada item de venda.*/

SELECT	P.Nome,
		Vp.Quantidade,
		Vp.PrecoUnitario
	FROM VendaProduto Vp
		JOIN Venda V
			ON V.Id = Vp.IdVenda	
		JOIN Produto P
			ON P.Id = VP.IdProduto
ORDER BY P.Nome

/*30. Liste os serviços vendidos em cada venda.*/

SELECT	Tp.Nome,
		V.StatusVenda
	FROM VendaServico Vs
		JOIN Venda V 
			ON V.Id = Vs.IdVenda
		JOIN TipoServico Tp
			ON Tp.Id = Vs.IdTipoServico
ORDER BY Tp.Nome

/*31. Liste o nome do serviço, nome do cliente e data da venda.*/

SELECT	Ts.Nome,
		C.Nome,
		V.DataHora
	FROM VendaServico Vd
		JOIN TipoServico Ts
			ON Ts.Id = Vd.Id
		JOIN Venda V
			ON V.Id = Vd.IdVenda
		JOIN Cliente C
			ON C.Id = V.IdCliente
ORDER BY Ts.Nome

/*32. Liste os agendamentos com o nome do cliente, nome do animal e nome do funcionário responsável.*/

SELECT Agn.DataHoraAgendado,
		A.Nome,
		Cl.Nome,
		Fun.Nome
	FROM Agendamento Agn
		JOIN Animal A
			ON A.Id = Agn.IdAnimal
		JOIN Funcionario Fun
			ON Fun.Id = Agn.IdFuncionario
		JOIN Cliente Cl
			ON Cl.Id = A.IdCliente

/*33. Liste os funcionários e suas especialidades.*/

SELECT FUn.Nome,
		Ts.Nome
	FROM FuncionarioEspecialidade FunEs
		JOIN Funcionario Fun
			ON FUn.Id = FunEs.IdFuncionario
		JOIN TipoServico Ts
			ON Ts.Id = FunEs.IdTipoServico

/*34. Liste todos os funcionários, mesmo os que ainda não possuem especialidade cadastrada.*/

SELECT *
	FROM Funcionario

/*35. Liste todos os tipos de serviço e os funcionários especializados neles.*/

SELECT Ts.Nome,
		FUn.Nome
	FROM FuncionarioEspecialidade Fune
		JOIN Funcionario FUn
			ON Fun.Id = Fune.IdFuncionario
		JOIN TipoServico Ts
			ON Ts.Id = Fune.IdTipoServico

/*36. Liste os produtos e seus fornecedores.*/

SELECT	P.Nome,
		Fo.Nome
	FROM ProdutoFornecedor Pf
		JOIN Produto P
			ON P.Id = Pf.IdProduto
		JOIN Fornecedor Fo
			ON Fo.Id = Pf.IdFornecedor

/*37. Liste todos os fornecedores e os produtos que eles fornecem.*/

SELECT	Fo.Nome,
		P.Nome
	FROM ProdutoFornecedor Pf
		JOIN Fornecedor Fo
			On Fo.Id = Pf.IdFornecedor
		JOIN Produto P
			ON P.Id = Pf.IdProduto
ORDER BY Fo.Nome

/*38. Liste os produtos que possuem mais de um fornecedor.*/

SELECT P.Nome,
		Fo.Nome
	FROM ProdutoFornecedor Pf
		JOIN Produto P
			ON P.Id = Pf.IdProduto
		JOIN Fornecedor Fo
			ON Fo.Id = Pf.IdFornecedor

/*39. Liste os históricos de vacinação com o nome do animal e o nome do cliente.*/

SELECT	A.Nome,
		Cl.Nome,
		Hv.NomeVacina,
		Hv.ProximaDose
	FROM HistoricoVacina Hv
		JOIN Animal A
			ON A.Id = Hv.IdAnimal
		JOIN Cliente Cl
			ON Cl.Id = A.IdCliente

/*40. Liste as alergias de cada animal com o nome do animal e do dono.*/

SELECT	A.Nome,
		Cl.Nome,
		Aal.Descricao,
		Aal.Gravidade
	FROM AnimalAlergia Aal
		JOIN Animal A
			ON A.Id = Aal.IdAnimal
		JOIN Cliente Cl
			ON Cl.Id = A.IdCliente

/* 3. JOINs com filtros*/

/*41. Liste os animais da espécie `"Cachorro"`.*/

SELECT A.Nome,
		A.Sexo,
		A.Observacoes,
		E.Nome
	FROM Animal A
		JOIN Raca R
			ON R.Id = A.IdRaca
		JOIN Especie E
			ON E.Id = R.IdEspecie
	WHERE E.Nome = 'Cachorro'

/*42. Liste os animais da raça `"Poodle"`.*/

SELECT A.Nome,
		A.Sexo,
		A.Observacoes,
		R.Nome
	FROM Animal A
		JOIN Raca R
			ON R.Id = A.IdRaca
	WHERE R.Nome = 'Poodle'

/*43. Liste os clientes que possuem animais da espécie `"Gato"`.*/

SELECT A.Nome,
		A.Sexo,
		A.Observacoes,
		E.Nome
	FROM Animal A
		JOIN Raca R
			ON R.Id = A.IdRaca
		JOIN Especie E
			ON E.Id = R.IdEspecie
	WHERE E.Nome = 'Gato'

/*44. Liste os produtos da categoria `"Medicamento"`.*/

SELECT	P.Nome,
		Cap.Nome
	FROM Produto P
		JOIN CategoriaProduto Cap
			ON Cap.Id = P.IdCategoriaProduto
	WHERE Cap.Nome = 'Medicamento'

/*45. Liste as vendas feitas por um cliente específico.*/

SELECT C.Nome,
		V.DataHora,
		V.ValorTotal
	FROM Venda V
		JOIN Cliente C
			ON C.Id = V.IdCliente
	WHERE C.Nome = 'Carlos Alves'

/*46. Liste todos os pagamentos feitos com cartão de crédito.*/

SELECT V.StatusVenda,
		Tpag.Nome
	FROM Pagamento Pag
		JOIN TipoPagamento Tpag
			ON Tpag.Id = Pag.IdTipoPagamento
		JOIN Venda V
			ON V.Id = Pag.IdVenda
	WHERE Tpag.Nome = 'Cartao de Credito'


/*47. Liste os agendamentos de um funcionário específico.*/

SELECT	A.DataHoraRealizado,
		Fun.Nome
	FROM Agendamento A
		JOIN Funcionario Fun
			ON Fun.Id = A.IdFuncionario
	WHERE Fun.Nome = 'Nicolas Oliveira'


/*48. Liste os agendamentos de uma data específica mostrando cliente, animal e serviço.*/

SELECT	Cl.Nome,
		A.Nome,
		Tps.Nome,
		Ag.DataHoraAgendado
	FROM Agendamento Ag
		JOIN Animal A
			ON A.Id = Ag.IdAnimal
		JOIN Cliente Cl
			ON Cl.Id = A.IdCliente
		JOIN TipoServico Tps
			ON Tps.Id = Ag.IdTipoServico
	WHERE Ag.DataHoraAgendado = '2023-01-11 11:00:00.000'

/*49. Liste as vacinas aplicadas em animais de um cliente específico.*/

SELECT	Hv.DataAplicacao,
		Hv.NomeVacina,
		A.Nome,
		C.Nome
	FROM HistoricoVacina Hv
		JOIN Animal A
			ON A.Id = Hv.IdAnimal
		JOIN Cliente C
			ON C.Id = A.IdCliente
	WHERE C.Nome = 'Fernanda Nunes'

/*50. Liste os produtos vendidos em vendas acima de R$ 200,00.*/

SELECT	P.Nome,
		V.ValorTotal
	FROM VendaProduto Vp
		JOIN Venda V
			ON V.Id = Vp.IdVenda
		JOIN Produto P
			ON P.Id = Vp.IdProduto
	WHERE V.ValorTotal = '200.00'

/*51. Liste os serviços vendidos para animais da espécie `"Cachorro"`.*/

SELECT 
		Ts.Nome,
		A.Nome,
		E.Nome
	FROM VendaServico Vs
		JOIN Venda V 
			ON V.Id = Vs.IdVenda
		JOIN TipoServico Ts
			ON Ts.Id = Vs.IdTipoServico
		JOIN Animal A
			ON A.Id = Vs.IdAnimal
		JOIN Raca R 
			ON R.Id = A.IdRaca
		JOIN Especie E 
			ON E.Id = R.IdEspecie
	WHERE E.Nome = 'Cachorro'


/*52. Liste os fornecedores que fornecem produtos da categoria `"Ração"`.*/

SELECT 
		F.Nome,
		P.Nome,
		Cp.Nome
	FROM ProdutoFornecedor Pf
		JOIN Produto P
			ON P.Id = Pf.IdProduto
		JOIN Fornecedor F
			ON F.Id = Pf.IdFornecedor
		JOIN CategoriaProduto Cp
			ON Cp.Id = P.IdCategoriaProduto
	WHERE Cp.Nome LIKE '%Racao%'


/*53. Liste os funcionários especializados em `"Banho e Tosa"`.*/

SELECT  F.Nome,
		Ts.Nome
	FROM FuncionarioEspecialidade Fe
		JOIN Funcionario F
			ON F.Id = Fe.IdFuncionario
		JOIN TipoServico Ts
			ON Ts.Id = Fe.IdTipoServico
	WHERE Ts.Nome = 'Banho e Tosa'
ORDER BY F.Nome

-- 54. Liste as vendas de produto feitas em determinado mês.

SELECT 
		P.Nome,
		V.DataHora
	FROM VendaProduto Vp
		JOIN Venda V
			ON V.Id = Vp.IdVenda
		JOIN Produto P
			ON P.Id = Vp.IdProduto
	WHERE V.DataHora = '2022-01-14 00:00:00.000'
		

-- 55. Liste os clientes que compraram determinado produto.

SELECT	cl.Nome,
		p.Nome
	FROM VendaProduto AS vp
		JOIN Produto as p
			ON p.Id = vp.IdProduto
		JOIN Venda as v
			ON v.Id = vp.IdVenda
		JOIN Cliente as cl
			ON cl.Id = v.IdCliente
WHERE p.Nome = 'Racao Super Premium Filhote 10kg Var.102'

-- 56. Liste os animais que possuem alergias cadastradas.

SELECT	a.Nome, 
		al.Descricao
	FROM AnimalAlergia AS al
		JOIN Animal as a
			ON a.Id = al.IdAnimal

-- 57. Liste os animais que não possuem alergias cadastradas.

SELECT	a.Nome, 
		al.Descricao
	FROM AnimalAlergia AS al
		JOIN Animal as a
			ON a.Id = al.IdAnimal
	WHERE al.Descricao = NULL

-- 58. Liste os produtos que nunca foram vendidos.

SELECT	p.Nome,
		v.StatusVenda
	FROM VendaProduto AS vp
		JOIN Venda as v
			ON v.Id = vp.IdVenda
		JOIN Produto as p
			ON p.Id = vp.IdProduto
	WHERE v.StatusVenda != 'Paga'
 
 -- 60. Liste os clientes que nunca fizeram uma venda.


		
-- 61. Mostre a quantidade de animais por cliente.

SELECT	cl.Nome,
		COUNT(*) AS Animias 
	FROM Animal AS a
		JOIN Cliente as cl
			ON cl.Id = a.IdCliente
GROUP BY cl.Nome


-- 62. Mostre a quantidade de animais por espécie.

SELECT	r.Nome,
		COUNT(*) 
	FROM Animal AS a
		JOIN Raca as r
			ON r.Id = a.IdRaca
		JOIN Especie as e
			ON e.Id = r.IdEspecie
GROUP BY r.Nome


-- 63. Mostre a quantidade de animais por raça.

SELECT e.Nome,
		COUNT(*)
	FROM Animal AS a
		JOIN Raca as r
			ON r.Id = a.IdRaca
		JOIN Especie as e
			ON e.Id = r.IdEspecie
GROUP BY e.Nome

-- 64. Mostre a quantidade de produtos por categoria.

SELECT cp.Nome,
		COUNT(*) as Quantidade 
	FROM Produto AS p
		JOIN CategoriaProduto as cp
			ON cp.Id = p.IdCategoriaProduto
GROUP BY cp.Nome

-- 65. Mostre o total vendido por venda.

SELECT COUNT(v.ValorTotal) AS TotalVenda
	FROM Venda AS v

-- 66. Mostre o total gasto por cada cliente.



-- 67. Mostre a quantidade de vendas por cliente.




/*-------------------------------------------------------------*/

UPDATE Cliente 
	SET 
		Nome = 'Mayk Gabriel'
WHERE Id = 1



