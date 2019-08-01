select 
tr.Nome as	'Turmas',
		a.Alunos

from Turmas tr 
Inner join TurmaAlunos ta on tr.Id = ta.Turma
inner join Alunos a on ta.Aluno = a.Id
--Trago todas os alunos




select d.[Data],
		tr.Aluno,
		ISNULL(n.Nota,0) as 'Média',
		iif(isnull(p.Id,0)>0,'Presente','Ausente') as 'Presenças'

from Diarios d 


	inner join TurmaAlunos tr on d.Turma = tr.Turma
	left join Presenca p on d.Id = p.Diario and tr.Aluno = p.Aluno
	left join Notas n on tr.Aluno = n.Aluno and d.Id = n.Diario
