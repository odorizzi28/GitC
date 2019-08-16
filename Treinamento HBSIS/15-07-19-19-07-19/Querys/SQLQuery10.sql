
insert into [dbo].NotaAluno
(nome,Materia,Nota)
  values
 ('Jorge','Matematica',9) 
 select 
 nome,
 materia,
 (sum(nota)/count(nota)) as 'Medias',
 count(nota) as 'Provas'
 from NotaAluno
 group by Nome,Materia
 order by Nome asc