CREATE TABLE [dbo].[Cliente] (
    [Id]   INT        NOT NULL,
    [nome] NCHAR (30) NOT NULL,
    [cpf]  NCHAR (11) NOT NULL,
    [rg]   NCHAR (8)  NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

