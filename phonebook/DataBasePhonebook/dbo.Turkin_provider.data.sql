SET IDENTITY_INSERT [dbo].[Turkin_provider] ON
INSERT INTO [dbo].[Turkin_provider] ([Id], [name], [score]) VALUES (1, N'Ростелеком', 10)
INSERT INTO [dbo].[Turkin_provider] ([Id], [name], [score]) VALUES (2, N'МТС', 9.8)
INSERT INTO [dbo].[Turkin_provider] ([Id], [name], [score]) VALUES (3, N'ТрансТелеКом', 9.4)
INSERT INTO [dbo].[Turkin_provider] ([Id], [name], [score]) VALUES (4, N'Мегафон', 9.1)
INSERT INTO [dbo].[Turkin_provider] ([Id], [name], [score]) VALUES (5, N'СтартТелеком', 8.7)
SET IDENTITY_INSERT [dbo].[Turkin_provider] OFF



CREATE TABLE [dbo].[Turkin_provider] (
    [Id]    INT           IDENTITY (1, 1) NOT NULL,
    [name]  NVARCHAR (50) NOT NULL,
    [score] FLOAT (53)    NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
