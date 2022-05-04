SET IDENTITY_INSERT [dbo].[Turkin_abonents] ON
INSERT INTO [dbo].[Turkin_abonents] ([Id], [surname], [name], [patronymic], [address], [birth_date], [comment]) VALUES (1, N'Змеев', N'Александр', N'', N'Нижний Новгород', N'2001-05-23 00:00:00', N'ЗА')
INSERT INTO [dbo].[Turkin_abonents] ([Id], [surname], [name], [patronymic], [address], [birth_date], [comment]) VALUES (2, N'Скороходов', N'Егор', NULL, N'Нижний Новгород', N'2001-04-24 00:00:00', N'СЕ')
INSERT INTO [dbo].[Turkin_abonents] ([Id], [surname], [name], [patronymic], [address], [birth_date], [comment]) VALUES (3, N'Акулина', N'Людмила', NULL, N'Нижний Новгород', N'2001-05-24 00:00:00', N'АЛ')
INSERT INTO [dbo].[Turkin_abonents] ([Id], [surname], [name], [patronymic], [address], [birth_date], [comment]) VALUES (4, N'Налчаджан', N'Мариам', NULL, N'Нижний Новгород', N'2001-04-26 00:00:00', N'МН')
INSERT INTO [dbo].[Turkin_abonents] ([Id], [surname], [name], [patronymic], [address], [birth_date], [comment]) VALUES (5, N'Изотов', N'Даниил', NULL, N'Нижний Новгород', N'2001-04-27 00:00:00', N'ИД')
INSERT INTO [dbo].[Turkin_abonents] ([Id], [surname], [name], [patronymic], [address], [birth_date], [comment]) VALUES (6, N'Ковригин', N'Никита', NULL, N'Нижний Новгород', N'2001-04-28 00:00:00', N'КН')
INSERT INTO [dbo].[Turkin_abonents] ([Id], [surname], [name], [patronymic], [address], [birth_date], [comment]) VALUES (7, N'Дубков', N'Никита', NULL, N'Нижний Новгород', N'2001-06-02 00:00:00', N'ДН')
INSERT INTO [dbo].[Turkin_abonents] ([Id], [surname], [name], [patronymic], [address], [birth_date], [comment]) VALUES (8, N'Книга', N'Виталий', NULL, N'Нижний Новгород', N'2001-04-04 00:00:00', N'КВ')
INSERT INTO [dbo].[Turkin_abonents] ([Id], [surname], [name], [patronymic], [address], [birth_date], [comment]) VALUES (9, N'Яковлев', N'Илья', NULL, N'Нижний Новгород', N'2001-05-05 00:00:00', N'ЯК')
INSERT INTO [dbo].[Turkin_abonents] ([Id], [surname], [name], [patronymic], [address], [birth_date], [comment]) VALUES (10, N'Глебов', N'Игорь', NULL, N'Нижний Новгород', N'2001-07-06 00:00:00', N'ГИ')
SET IDENTITY_INSERT [dbo].[Turkin_abonents] OFF


CREATE TABLE [dbo].[Turkin_abonents] (
    [Id]         INT           IDENTITY (1, 1) NOT NULL,
    [surname]    NVARCHAR (50) NOT NULL,
    [name]       NVARCHAR (50) NOT NULL,
    [patronymic] NVARCHAR (50) NULL,
    [address]    TEXT          NOT NULL,
    [birth_date] DATETIME      NOT NULL,
    [comment]    TEXT          NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

