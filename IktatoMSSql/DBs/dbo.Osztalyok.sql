CREATE TABLE [dbo].Osztalyok
(
	[Id_Osztaly] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Osztaly] NCHAR(20) NOT NULL
)

GO

CREATE UNIQUE INDEX [IX_Osztalyok_Osztaly] ON [dbo].[Osztalyok] (Osztaly)
