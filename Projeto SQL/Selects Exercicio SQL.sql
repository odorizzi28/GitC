--Trazer somente como marcas que Felipe cadastrou

select m.Nome, m.UsuInc from Marcas m
where m.UsuInc = (select u.id from Usuarios u
                  where u.Usuario like 'Felipe');




--Trazer somente como marcas que descrevem o Giomar

select m.Nome, m.UsuInc from Marcas m
where m.UsuInc = (select u.id from Usuarios u
                  where u.Usuario like 'Giomar');



--Trazer somente uma quantidade de marcas que o Felipe cadastrou no maior para menor

select COUNT(UsuInc) as 'Quantidade' from Marcas where UsuInc = 1
order by COUNT(UsuInc) desc;

--Trazer somente uma quantidade de marcas que fazem parte do cadastro do menor para maior

select COUNT(UsuInc)as 'Quantidade' from Marcas where UsuInc = 2
order by COUNT(UsuInc) desc;

--Trazer somente uma quantidade de marcas que Felipe e Giomar cadastraram 

select COUNT(UsuInc) as 'Quantidade' from Marcas where UsuInc <> 0;

--Trazer somente os carros que Felipe cadastrou

select Modelo from Carros where UsuInc = 1;

--Trazer somente os carros que Giomar cadastrou

select Modelo from Carros where UsuInc = 2;

--Trazer somente uma quantidade de carros que Felipe cadastrou maior para menor

select COUNT(UsuInc) as 'Quantidade' from Carros where UsuInc = 1
order by  Quantidade desc;


--Trazer somente uma quantidade de carros que Giomar cadastrou menor para maior

select COUNT(UsuInc) as 'Quantidade' from Carros where UsuInc = 2
order by  Quantidade desc;

--Trazer somente uma quantidade de carros que Felipe e Giomar cadastraram 

select COUNT(UsuInc) as 'Quantidade' from Carros where UsuInc <> 0;

--Trazer somente os carros das marcas que Felipe cadastrou

select Modelo from Carros c where c.UsuInc = (select u.id from Usuarios u where u.Usuario = 'Felipe');
		


--Trazer apenas os carros das marcas que o Giomar cadastrou

select Modelo from Carros c where c.UsuInc = (select u.id from Usuarios u where u.Usuario = 'Giomar');

--Trazer somente uma quantidade de carros das marcas que Felipe cadastrou maior para menor
select count(Modelo) as 'Quantidade' from Carros c where c.UsuInc = (select u.id from Usuarios u where u.Usuario = 'Felipe')
 order by Quantidade asc;

--Trazer somente uma quantidade de carros das marcas Giomar cadastrou menor para maior

select count(Modelo) as 'Quantidade' from Carros c where c.UsuInc = (select u.id from Usuarios u where u.Usuario = 'Giomar')
order by Quantidade asc;

--trazer o valor total de vendas 2019

select sum(Valor) as 'Valor total 2019'  from Vendas where  year (DatInc) = '2019' ;

--Trazer a quantidade total de vendas 2019

select count(*) as 'Quantidade de Vendas' from Vendas where  year (DatInc) = '2019' ;

--Trazer o valor total de vendas em cada ano e ordernar do maior para menor

select 
YEAR(DatInc) as 'Ano' ,
sum(Valor) as 'Quantidade' 

from Vendas 
group by YEAR(DatInc)
order by Quantidade DESC;

--Trazer uma quantidade de vendas em cada ano e ordernar do maior para menor

select 
YEAR(DatInc) as 'Ano' ,
count(*) as 'Quantidade' 

from Vendas 
group by YEAR(DatInc)
order by Quantidade DESC;


select 
sum (Quantidade)  as 'Quantidade',
MONTH(DatInc) as 'Mes',
YEAR(DatInc) as 'Ano'

from Vendas 

group by YEAR(DatInc),MONTH(DatInc)
order by Quantidade desc ;


--Trazer o mês de cada ano que retornou o maior valor de vendas
	--- Tradução "Retornar ao grupo por mês e ordernar do maior para menor"

	
	select 
	sum (Valor)  as 'Valor',
	MONTH(DatInc) as 'Mes',
	YEAR(DatInc) as 'Ano'
	
	from Vendas 
	
	group by YEAR(DatInc),MONTH(DatInc)
	order by Valor desc ;


--Trazer o valor total de vendas que Felipe realizou

select sum(Valor) as 'Valor total de Vendas'
from Vendas where UsuInc = 1;


--Trazer o valor total de vendas que Giomar realizou

select sum(Valor) as 'Valor total de Vendas'
from Vendas where UsuInc = 2;


--Trazer o valor total de vendas que Felipe realizou

select sum (Valor) as 'Quantidade Total de Vendas do Felipe' from Vendas where UsuInc = 1;

--Trazer uma quantidade de vendas que o Giomar realizou

select sum (Valor) as 'Quantidade Total de Vendas do Giomar' from Vendas where UsuInc = 2;


--Trazer uma quantidade total de vendas que Felipe e Giomar realizaram do maior para menor

select count (Quantidade) as 'Quantidade' from Vendas
order by Quantidade desc;



--Trazer o valor de vendas que Felipe e Giomar realizaram ordenando do maior para menor

select sum (Valor) as 'Quantidade' from Vendas
order by sum (Valor) desc;



--Trazer uma marca mais vendida de todos os anos
	-- Tradução "Retornar todas as marcas que foram vendidas e ordernadas da maior para menor"

	select YEAR(v.DatInc) as 'Ano',
			v.Quantidade,
			m.Nome
	
	from Marcas M 
	inner join Carros C on M.Id = c.Marca
	inner join Vendas V on c.Id = V.Carro

	group by YEAR(v.DatInc),v.Quantidade,m.Nome
	order by v.Quantidade desc;

--Trazer o valor total da marca mais vendida de todos os anos

	select 

			sum(V.Valor*v.Quantidade) as 'ValorTotal', 
			m.Nome
	
	from Marcas M 
	inner join Carros C on M.Id = c.Marca
	inner join Vendas V on c.Id = V.Carro

	group by m.Nome
	order by sum(v.Valor) desc;


--Trazer uma quantidade de carro mais vendido de todos os anos
	select 
	
			sum(V.Quantidade) as 'ValorTotal', 
			m.Nome
	
	from Marcas M 
	inner join Carros C on M.Id = c.Marca
	inner join Vendas V on c.Id = V.Carro
	
	group by m.Nome
	order by sum(V.Quantidade) desc;


--Trazer o valor do carro mais vendido de todos os anos


select 
	
			V.Valor, 
			c.Modelo,
			YEAR(V.DatInc) as 'Ano'
	
	from Marcas M 
	inner join Carros C on M.Id = c.Marca
	inner join Vendas V on c.Id = V.Carro
	
	order by v.Valor desc;
	