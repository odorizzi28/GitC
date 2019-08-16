    	create table [dbo].[Diario1]
    	(
    	[id] int not null primary key identity (1,1),
    	[nome] varchar (100) not null,
    	[Materia] varchar (50) not null,
    	[Nota1] int not null,
    	[Nota2] int not null,
    	[Nota3] int not null,
    	[Nota4] int not null,
    	[Nota5] int not null,
    	[Nota6] int not null,
    	)
    
     		insert into dbo.Diario1
       (nome,Materia,Nota1,Nota2,Nota3,Nota4,Nota5,Nota6)
       values
      ('Joao','Paint3D',9,9,9,9,3,7) 
     
    select
    id,
    nome,
    materia,
    	((nota1+nota2+nota3+nota4+nota5+nota6) /6) as 'Media',
    	iif(((nota1+nota2+nota3+nota4+nota5+nota6) /6)>=7, 'Aprovado','Reprovado') as 'Status' from Diario1
    
    

select
  nome,
  materia,
  	((nota1+nota2+nota3+nota4+nota5+nota6) /6) as 'Media',
  	iif(((nota1+nota2+nota3+nota4+nota5+nota6) /6)>=7, 'Aprovado','Reprovado') as 'Status' from Diario1
  