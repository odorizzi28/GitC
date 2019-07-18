CREATE TABLE [dbo].[AulaCsharp]
(
[Id] INT PRIMARY KEY IDENTITY(1,1) not null,
[Aluno] varchar (100) not null,
[Idade] int null,
[Ativo] bit not null,
[UsuInc] int not null,
[UsuAlt] int not null,
[DatInc] date not null,
[DatAlt] date not null
)
go
 insert into dbo.AulaCsharp
 (Aluno,Idade,Ativo,UsuInc,UsuAlt,DatInc,DatAlt)
 values
('Edilson',24,1,3,1,GETDATE(),GETDATE()) 
go


 insert into dbo.AulaCsharp
 (Aluno,Idade,Ativo,UsuInc,UsuAlt,DatInc,DatAlt)
 values
('Ana',23,2,1,1,GETDATE(),GETDATE()) 
go



 insert into dbo.AulaCsharp
 (Aluno,Idade,Ativo,UsuInc,UsuAlt,DatInc,DatAlt)
 values
('Jorge',43,43,1,1,GETDATE(),GETDATE()) 
go



 insert into dbo.AulaCsharp
 (Aluno,Idade,Ativo,UsuInc,UsuAlt,DatInc,DatAlt)
 values
('Rafael',26,54,1,1,GETDATE(),GETDATE()) 
go



 insert into dbo.AulaCsharp
 (Aluno,Idade,Ativo,UsuInc,UsuAlt,DatInc,DatAlt)
 values
('Kevin',41,1,1,0,GETDATE(),GETDATE()) 
go




SELECT * FROM AULACSHARP

drop table AulaCsharp