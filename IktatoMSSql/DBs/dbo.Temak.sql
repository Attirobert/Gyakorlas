CREATE TABLE [dbo].Temak
(
	[Id_Tema] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Tema] NCHAR(20) NOT NULL
)

GO

CREATE UNIQUE INDEX [IX_Temak_Tema] ON [dbo].[Temak] ([Tema])
