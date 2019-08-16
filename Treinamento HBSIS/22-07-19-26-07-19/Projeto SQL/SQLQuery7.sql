select
	a.Alunos,
	n.Nota

from Alunos a 

inner join TurmaAlunos tr on a.Id = tr.Aluno
inner join Diarios d on tr.Turma = d.Turma
left join Notas n on d.Id = n.Diario and a.id = n.Aluno



group by a.Alunos