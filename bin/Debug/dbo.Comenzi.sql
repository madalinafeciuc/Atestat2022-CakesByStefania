CREATE TABLE [dbo].[Comenzi]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Nume] NVARCHAR(50) NULL, 
    [Prenume] NVARCHAR(50) NULL, 
    [Nume_prajitura] NVARCHAR(50) NULL, 
    [Nr_buc] INT NULL, 
    [Observatii] NVARCHAR(MAX) NULL
)
