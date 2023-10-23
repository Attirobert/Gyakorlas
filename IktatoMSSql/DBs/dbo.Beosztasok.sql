CREATE TABLE [dbo].Beosztasok
(
	[Id_Beosztas] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Beosztas] NCHAR(20) NOT NULL
)

GO

CREATE UNIQUE INDEX [IX_Bosztasok_Beosztas] ON [dbo].[Bosztasok] ([Beosztas])
