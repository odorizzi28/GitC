	select 
		TipoDog,
		(sum (TotalVendas)) as 'Total de Vendas',
		(month (DataVenda)) as 'Mes'
		 
	from FoodTruck
	Where MONTH(DataVenda) between 4 and 5 -- between 4 and 5 tras os valores dentro do mes 4 e 5

group by TipoDog, (month(DataVenda))
order by 'Total de Vendas' desc