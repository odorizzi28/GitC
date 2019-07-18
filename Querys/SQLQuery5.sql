select 
	Aluno,
	Idade,
	iif(Ativo = 1,'Ativo','Inativo') as 'Status'
from AulaCsharp 
Where Id in
(select id from AulaCsharp where idade >21)
order by Idade asc 