﻿

	
--	CREATE TABLE [dbo].[Biblioteca]
--	(
--		[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
--	    [NOME] VARCHAR(100) NOT NULL,
--		[Cep]  VARCHAR(8) NOT NULL,
--		[Ativa]  bit NOT NULL,
--		[UsuInc]  int NOT NULL,
--		[UsuAlt]  int NOT NULL,
--		[DatInc]  Datetime NOT NULL,
--		[DatAlt]  Datetime NOT NULL,
--		
--	)
--	
--	go
--	

--	CREATE TABLE [dbo].[Livros](
--		[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
--	    [NOME] VARCHAR(100) NOT NULL,
--		[Autor]  VARCHAR(100) NOT NULL,
--		[Alocado]  bit NOT NULL,
--		[Biblioteca] int NOT NULL,
--		[UsuInc]  int NOT NULL,
--		[UsuAlt]  int NOT NULL,
--		[DatInc]  Datetime NOT NULL,
--		[DatAlt]  Datetime NOT NULL,
--		CONSTRAINT [FK_Biblioteca_Id] FOREIGN KEY ([Biblioteca]) REFERENCES [dbo].[Biblioteca] ([Id])
--		--CONSTRAINT [FK_Aluno_UsuarioInc] FOREIGN KEY ([UserInc]) REFERENCES [dbo].[Biblioteca] ([Id]),
--	    --CONSTRAINT [FK_Aluno_UsuarioAlt  ] FOREIGN KEY ([UserAlt]) REFERENCES [dbo].[Biblioteca] ([Id])
--	)
--	
 --	go
 --	
 --	insert into [dbo].Biblioteca
 --	(NOME,Cep,Ativa,UsuInc,UsuAlt,DatInc,DatAlt)
 --	values
 --	('Biblioteca A',89050-200,1,0,0,GETDATE(),GETDATE());
 --	
 --	go
 --	
 --	insert into [dbo].Biblioteca
 --	(NOME,Cep,Ativa,UsuInc,UsuAlt,DatInc,DatAlt)
 --	values
 --	('Biblioteca B',89550-200,1,0,0,GETDATE(),GETDATE());
 --	
 --	
 --	
 --	
 --	
 --	
 --	insert into [dbo].Livros
 --	(NOME,Autor,Alocado,Biblioteca,UsuInc,UsuAlt,DatInc,DatAlt)
 --	values
 --	('O pequeno','O grande',1,1,1,1,GETDATE(),GETDATE());
 --	
 --	insert into [dbo].Livros
 --	(NOME,Autor,Alocado,Biblioteca,UsuInc,UsuAlt,DatInc,DatAlt)
 --	values
 --	('Como eu era antes de você','Jojo Moyes',1,1,1,1,GETDATE(),GETDATE());
 --	
 --	go
 --	
 --	insert into [dbo].Livros
 --	(NOME,Autor,Alocado,Biblioteca,UsuInc,UsuAlt,DatInc,DatAlt)
 --	values
 --	('A culpa é das estrelas','John Green',0,2,2,1,GETDATE(),GETDATE());
 --	
 --	go
 --	
 --	insert into [dbo].Livros
 --	(NOME,Autor,Alocado,Biblioteca,UsuInc,UsuAlt,DatInc,DatAlt)
 --	values
 --	('Caixa de pássaros','Josh Malerman',0,2,2,1,GETDATE(),GETDATE());
 --	
 --	
 --
 --

	--select 
	--	
	--	BL.nome,
	--	count(LV.Id) as 'QuantidadeDeLivros'
	--from Biblioteca BL
	--inner join Livros LV on BL.Id = LV.Biblioteca
	--group by BL.NOME

	
--	select 
--		
--		BL.nome,
--		count(LV.Id) as 'QuantidadeDeLivros',
--		US.Nome as 'UserNome'
--	from Biblioteca BL
--	inner join Livros LV on BL.Id = LV.Biblioteca
--	inner join Usuario US on LV.UsuInc=US.Id
--	group by BL.NOME,US.Nome


--select 
--
--	bl.NOME,
--	(select count(*) from Livros lv 
--	where lv.Biblioteca = bl.Id) 
--	as 'QuantLivros'
--
--from Biblioteca bl