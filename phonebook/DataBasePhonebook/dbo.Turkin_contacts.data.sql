SET IDENTITY_INSERT [dbo].[Turkin_contacts] ON
INSERT INTO [dbo].[Turkin_contacts] ([Id], [phone], [type], [provider_id]) VALUES (10, N'89121234567', N'Мобильный', 2)
INSERT INTO [dbo].[Turkin_contacts] ([Id], [phone], [type], [provider_id]) VALUES (12, N'89121234567', N'Домашний', 2)
INSERT INTO [dbo].[Turkin_contacts] ([Id], [phone], [type], [provider_id]) VALUES (13, N'89121234567', N'Мобильный', 3)
INSERT INTO [dbo].[Turkin_contacts] ([Id], [phone], [type], [provider_id]) VALUES (14, N'89121234567', N'Домашний', 3)
INSERT INTO [dbo].[Turkin_contacts] ([Id], [phone], [type], [provider_id]) VALUES (16, N'89121234521', N'Мобильный', 1)
INSERT INTO [dbo].[Turkin_contacts] ([Id], [phone], [type], [provider_id]) VALUES (17, N'89121234523', N'Мобильный', 1)
INSERT INTO [dbo].[Turkin_contacts] ([Id], [phone], [type], [provider_id]) VALUES (18, N'89121234522', N'Мобильный', 1)
INSERT INTO [dbo].[Turkin_contacts] ([Id], [phone], [type], [provider_id]) VALUES (19, N'89121234525', N'Домашний', 2)
INSERT INTO [dbo].[Turkin_contacts] ([Id], [phone], [type], [provider_id]) VALUES (20, N'89121234599', N'Домашний', 2)
INSERT INTO [dbo].[Turkin_contacts] ([Id], [phone], [type], [provider_id]) VALUES (21, N'89121234500', N'Мобильный', 2)
INSERT INTO [dbo].[Turkin_contacts] ([Id], [phone], [type], [provider_id]) VALUES (22, N'891212345', N'Домашний', 2)
INSERT INTO [dbo].[Turkin_contacts] ([Id], [phone], [type], [provider_id]) VALUES (23, N'891212345', N'Мобильный', 2)
INSERT INTO [dbo].[Turkin_contacts] ([Id], [phone], [type], [provider_id]) VALUES (25, N'891212345', N'Мобильный', 3)
INSERT INTO [dbo].[Turkin_contacts] ([Id], [phone], [type], [provider_id]) VALUES (26, N'891212345', N'891212345', 3)
INSERT INTO [dbo].[Turkin_contacts] ([Id], [phone], [type], [provider_id]) VALUES (27, N'891212345', N'Мобильный', 1)
SET IDENTITY_INSERT [dbo].[Turkin_contacts] OFF



CREATE TABLE [dbo].[Turkin_contacts] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [phone]       NVARCHAR (50) NOT NULL,
    [type]        NVARCHAR (50) NOT NULL,
    [provider_id] INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Turkin_contacts_providers] FOREIGN KEY ([provider_id]) REFERENCES [dbo].[Turkin_provider] ([Id]) ON DELETE CASCADE
);
