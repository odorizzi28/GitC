select 
TipoDog,

(sum(TotalVendas)) as 'Media',
month(DataVenda) as 'Mes'

from FoodTruck
group by TipoDog, month(DataVenda)