CREATE TABLE [dbo].Iktat
(
	[Id_Iktat] INT NOT NULL PRIMARY KEY, 
    [Iktatoszam] NCHAR(20) NOT NULL, 
    [IdUser] INT NOT NULL, 
    [Datum] DATE NOT NULL, 
    [IdTema] INT NOT NULL, 
    [Leiras] NCHAR(50) NOT NULL 
	CONSTRAINT [FK_Iktat_Temak] FOREIGN KEY ([IdTema]) REFERENCES [dbo].[Temak] ([Id_Tema]),
    CONSTRAINT [FK_Iktat_Users] FOREIGN KEY ([IdUser]) REFERENCES [dbo].[Users] ([Id_User])
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [IX_Iktat_Iktatoszam]
    ON [dbo].[Iktat]([Iktatoszam] ASC);
