----relatorio mes
--Select 
--		count (lo.CarroId) as 'Carros Alocados',
--	    cr.NomeCarro as 'Modelo dos Carros' ,
--	    (month(lo.DataLocacao)) as 'Mês'
--	   
--
--from Locacao lo
--inner join Carros Cr on lo.CarroId = Cr.Id
--group by cr.NomeCarro, month(lo.DataLocacao)
--
--
-- Relatorio Ano

--Select 
--		count(lo.CarroId) as 'Qtd Carros Alocados',
--	    cr.NomeCarro as 'Modelo dos Carros' ,
--	    Year(lo.DataLocacao) as 'Relatorio Anual'
--	   
--
--from Locacao lo
--inner join Carros Cr on lo.CarroId = Cr.Id
--group by lo.CarroId,cr.NomeCarro, year(lo.DataLocacao)
--order by year(lo.DataLocacao)

-- relatorio mais vendido por ano
Select 
		cr.NomeCarro as 'Modelo dos Carros',
		(count (lo.CarroId)) as 'Carro mais Alocados',
		Year(lo.DataLocacao) as 'Relatorio Anual'
	    
	    
	   

from Locacao lo
inner join Carros Cr on lo.CarroId = Cr.Id
group by lo.CarroId,cr.NomeCarro, year(lo.DataLocacao)
order by (lo.CarroId)


