Create Table [dbo].[Diario]
(
[id] int not null primary key identity (1,1),
[nome] varchar (100) not null,
[Materia] varchar (50) not null,
[Nota1] int not null,
[Nota2] int not null,
[Nota3] int not null,
[Media] as ((Nota1+Nota2+Nota3)/3),
[Status] as iif ((Nota1+Nota2+Nota3)/3 >= 7,  'Aprovado','Reprovado')

)

