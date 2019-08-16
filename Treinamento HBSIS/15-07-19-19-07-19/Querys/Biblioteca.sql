--	CREATE TABLE [dbo].[Usuarios] (
--	    [Id]     INT           IDENTITY (1, 1) NOT NULL,
--	    [Nome]   VARCHAR (100) NOT NULL,
--	    [Login]  VARCHAR (50)  NOT NULL,
--	    [Senha]  VARCHAR (50)  NOT NULL,
--	    [Email]  VARCHAR (100) NOT NULL,
--	    [Ativo]  BIT           NOT NULL,
--	    [UsuInc] INT           NOT NULL,
--	    [UsuAlt] INT           NOT NULL,
--	    [DatInc] DATETIME      DEFAULT (getdate()) NOT NULL,
--	    [DatAlt] DATETIME      DEFAULT (getdate()) NOT NULL,
--	    PRIMARY KEY CLUSTERED ([Id] ASC)
--	);
--	


	

--CREATE TABLE [dbo].[Generos] (
--    [Id] INT IDENTITY (1, 1) NOT NULL,
--    [Tipo]   VARCHAR (200) NOT NULL,
--    [Descrição]  VARCHAR (1000)  NOT NULL,
--    
--);


--	CREATE TABLE [dbo].[Editora] (
--	    [Id]     INT           IDENTITY (1, 1) NOT NULL,
--	    [Nome]   VARCHAR (200) NOT NULL,
--	    [Descricao]  VARCHAR (1000)  NOT NULL,
--	   
--	);
--

--	CREATE TABLE [dbo].[Autores] (
--	    [Id] INT IDENTITY (1, 1) NOT NULL,
--	    [Nome]   VARCHAR (200) NOT NULL,
--	    [Descricao]  VARCHAR (1000)  NOT NULL,
--	   
--	);
--


--	CREATE TABLE [dbo].[LivroAutor] (
--	    [Livro] INT NOT NULL,
--	    [Autor] INT NOT NULL
--	      
--	);
 
 

CREATE TABLE [dbo].[Livros] (
	    [Id] INT IDENTITY (1, 1) NOT NULL,
		[Registro] int not null,
	    [Titulo]   VARCHAR (1200) NOT NULL,
		[Isbn]  VARCHAR (15)  NOT NULL,
		[Genero]  VARCHAR (200)  NOT NULL,
	    [Editora]  VARCHAR (50)  NOT NULL,
	    [Sinopse] VARCHAR (MAX) NOT NULL,
		[Observacoes]  VARCHAR (1000) NULL,
	    [UsuInt] INT NOT NULL,
		[UsuAlt] INT  NOT NULL,
		[DatInt] DATETIME NOT NULL DEFAULT GETDATE(),
		[DatAlt] DATETIME NOT NULL DEFAULT GETDATE()
		
		CONSTRAINT [FK_lIVROS_TO_GENERO] FOREIGN KEY ([GENERO]) REFERENCES[GENERO]([ID]),

		CONSTRAINT[FK_lIVROS_TO_EDITORA] FOREIGN KEY ([EDITORA]) REFERENCES[EDITORA]([ID]),

		CONSTRAINT[FK_lIVROS_TO_USUARIOINT]	FOREIGN KEY ([UsuInt])	REFERENCES[UsuInt]([ID]),

		CONSTRAINT[FK_lIVROS_TO_USUARIOALT]	FOREIGN KEY ([UsuAlt])REFERENCES[UsuAlt]([ID]),
	   
	   
	);
	