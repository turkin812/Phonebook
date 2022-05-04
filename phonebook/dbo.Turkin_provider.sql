CREATE TABLE [dbo].[Turkin_provider] (
    [Id]    INT           IDENTITY (1, 1) NOT NULL,
    [name]  NVARCHAR (50) NOT NULL,
    [score] FLOAT    NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

