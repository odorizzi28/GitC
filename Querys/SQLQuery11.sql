select 'Carros' as 'Carros',
	sum(temp.Media) as 'Vendas',
	temp.AnoVenda
	from (select 
		ModeloCarro,
		AnoFabricacao,
		(sum(NumeroDeVendas)/Count(*)) as 'Media',
		year(DataDaVenda) as 'AnoVenda'

	from TabelaCarro
	group by ModeloCarro,AnoFabricacao,month(DataDaVenda))temp
	group by temp.AnoVenda