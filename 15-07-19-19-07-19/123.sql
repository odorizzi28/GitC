


	 CREATE TABLE [dbo].[notas] (
	    [Id]         INT IDENTITY (1, 1) NOT NULL,
	    [Nome]       INT NOT NULL,
	    [Nota]       INT NOT NULL,
	    [Presenca] bit NOT NULL default 0 ,
	    PRIMARY KEY CLUSTERED ([Id] ASC),
	    CONSTRAINT [FK_Notas_ToNome] FOREIGN KEY ([Nome]) REFERENCES [dbo].[Alunos] ([Id])
	);


	CREATE TABLE [dbo].[Alunos] (
	    [Id]        INT           IDENTITY (1, 1) NOT NULL,
	    [NomeAluno] VARCHAR (100) NOT NULL,
		[Turma] int not null
	    PRIMARY KEY CLUSTERED ([Id] ASC)
	);



	CREATE TABLE [dbo].[Turmas] (
	[Id]          INT           IDENTITY (1, 1) NOT NULL,
	[Nome] VARCHAR (100) NOT NULL,
	PRIMARY KEY CLUSTERED ([Id] ASC)
	);
