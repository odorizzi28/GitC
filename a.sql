


	-- CREATE TABLE [dbo].[Diario] (
	--    [Id]         INT IDENTITY (1, 1) NOT NULL,
	--    [Nome]       INT NOT NULL,
	--    [Nota]       INT NOT NULL,
	--    [frequencia] INT NOT NULL,
	--    PRIMARY KEY CLUSTERED ([Id] ASC),
	--    CONSTRAINT [FK_Notas_ToNome] FOREIGN KEY ([Nome]) REFERENCES [dbo].[Alunos] ([Id])
	--);


	--CREATE TABLE [dbo].[Alunos] (
	--    [Id]        INT           IDENTITY (1, 1) NOT NULL,
	--    [NomeAluno] VARCHAR (100) NOT NULL,
	--    PRIMARY KEY CLUSTERED ([Id] ASC)
	--);



	--CREATE TABLE [dbo].[Turmas] (
	--[Id]          INT           IDENTITY (1, 1) NOT NULL,
	--[Descricao] VARCHAR (100) NOT NULL,
	--PRIMARY KEY CLUSTERED ([Id] ASC)
	--);


	--insert into [dbo].Turma
	--(Descricao) values ('1º A')
	--go
	--insert into [dbo].Turma
	--(Descricao) values ('1º B')



-- 	select 
-- NomeAluno, (Sum(Nota)/COUNT(Nota)) as 'Média',
-- iif((sum (frequencia) <=3), 'Aprovado','Reprovado' ) as 'Status',
-- Descricao
-- 
-- 
-- 		
--   from Diario, Alunos, Turma
--   group by NomeAluno, Descricao

select
       a.NomeAluno,
	   SUM(iif(n.frequencia=1,100,null)) / COUNT(n.frequencia) ,
	   SUM(n.Nota) / COUNT(n.Nota) as 'Média',
	   IIF((SUM(n.Nota) / COUNT(n.Nota) >= 7),'Aprovado','Reprovado') as 'Status Média',
	  IIF(SUM(iif(n.frequencia=1,100,null)) / COUNT(n.frequencia) >= 75,'Aprovado','Reprovado') 
	  as 'Status Frequencia'
  from Alunos a
  inner join Diario n on a.Id = n.frequencia
  group by a.NomeAluno;

