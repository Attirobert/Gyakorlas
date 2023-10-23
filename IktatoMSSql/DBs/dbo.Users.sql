CREATE TABLE [dbo].Users
(
	[Id_User] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Nev] NCHAR(20) NOT NULL, 
    [Jelszo] NCHAR(10) NOT NULL DEFAULT 1234, 
    [Admin] TINYINT NOT NULL DEFAULT 0, 
    CONSTRAINT [CK_Users_Admin] CHECK (Admin = 1 OR Admin = 0)
)

GO

CREATE UNIQUE INDEX [IX_Users_Nev] ON [dbo].[Users] (Nev)