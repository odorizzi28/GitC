
--CREATE TABLE [dbo].[Notas] (
--    [Id]   INT IDENTITY (1, 1) NOT NULL,
--    [Nome] INT NOT NULL,
--    [Nota] INT NOT NULL,
--	  [frequencia] bit not null,
--    PRIMARY KEY CLUSTERED ([Id] ASC),
--    CONSTRAINT [FK_Notas_ToNome] FOREIGN KEY ([Nome]) REFERENCES [dbo].[Alunos] ([Id])
--);


-- 	CREATE TABLE [dbo].[Alunos] (
--     [Id]        INT           IDENTITY (1, 1) NOT NULL,
--     [NomeAluno] VARCHAR (100) NOT NULL,
--     PRIMARY KEY CLUSTERED ([Id] ASC)
-- );


-- CREATE TABLE [dbo].[Turmas] (
--    [Id] int IDENTITY (1, 1) NOT NULL,
--    [NomeDaTurma] VARCHAR (100) NOT NULL,
--    PRIMARY KEY CLUSTERED ([Id] ASC)
-- );


--insert into [dbo].[Alunos]
--(NomeAluno) values ('Edilson')
--
--go
--
--insert into [dbo].[Alunos]
--(NomeAluno) values ('Ricardo')
--
--go
--
--
--insert into [dbo].[Alunos]
--(NomeAluno) values ('Willian')
--
--go
--
--insert into [dbo].[Alunos]
--(NomeAluno) values ('Junior')
--
--go
--
--insert into [dbo].[Alunos]
--(NomeAluno) values ('Ana')
--

--insert into [dbo].[Turmas]
--(NomeDaTurma) values ('1 Ano A')
--go
--
--insert into [dbo].[Turmas]
--(NomeDaTurma) values ('1 Ano B')
--
--go
--
--insert into [dbo].[Turmas]
--(NomeDaTurma) values ('1 Ano C')



select 
	NomeAluno,
	Nota
	

from Notas, Turmas,Alunos










