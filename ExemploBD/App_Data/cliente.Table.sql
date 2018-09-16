CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [nome] NCHAR(30) NOT NULL, 
    [cpf] NCHAR(11) NOT NULL, 
    [rg] NCHAR(8) NOT NULL, 
    CONSTRAINT [PK_Table] PRIMARY KEY ([Id]), 
)
