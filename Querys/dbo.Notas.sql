CREATE TABLE [dbo].[Notas] (
    [Id]   INT IDENTITY (1, 1) NOT NULL,
    [Nome] INT NOT NULL,
    [Nota] INT NOT NULL,
    [frequencia] BIT NOT NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Notas_ToNome] FOREIGN KEY ([Nome]) REFERENCES [dbo].[Alunos] ([Id])
);

