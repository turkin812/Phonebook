INSERT INTO [dbo].[Turkin_abonent_has_contact] ([abonent_id], [contact_id]) VALUES (1, 10)
INSERT INTO [dbo].[Turkin_abonent_has_contact] ([abonent_id], [contact_id]) VALUES (2, 12)
INSERT INTO [dbo].[Turkin_abonent_has_contact] ([abonent_id], [contact_id]) VALUES (3, 13)
INSERT INTO [dbo].[Turkin_abonent_has_contact] ([abonent_id], [contact_id]) VALUES (4, 14)
INSERT INTO [dbo].[Turkin_abonent_has_contact] ([abonent_id], [contact_id]) VALUES (5, 16)
INSERT INTO [dbo].[Turkin_abonent_has_contact] ([abonent_id], [contact_id]) VALUES (6, 10)
INSERT INTO [dbo].[Turkin_abonent_has_contact] ([abonent_id], [contact_id]) VALUES (6, 12)
INSERT INTO [dbo].[Turkin_abonent_has_contact] ([abonent_id], [contact_id]) VALUES (6, 13)
INSERT INTO [dbo].[Turkin_abonent_has_contact] ([abonent_id], [contact_id]) VALUES (6, 16)
INSERT INTO [dbo].[Turkin_abonent_has_contact] ([abonent_id], [contact_id]) VALUES (6, 17)
INSERT INTO [dbo].[Turkin_abonent_has_contact] ([abonent_id], [contact_id]) VALUES (7, 18)
INSERT INTO [dbo].[Turkin_abonent_has_contact] ([abonent_id], [contact_id]) VALUES (8, 20)
INSERT INTO [dbo].[Turkin_abonent_has_contact] ([abonent_id], [contact_id]) VALUES (9, 21)
INSERT INTO [dbo].[Turkin_abonent_has_contact] ([abonent_id], [contact_id]) VALUES (10, 16)
INSERT INTO [dbo].[Turkin_abonent_has_contact] ([abonent_id], [contact_id]) VALUES (10, 22)
INSERT INTO [dbo].[Turkin_abonent_has_contact] ([abonent_id], [contact_id]) VALUES (10, 23)
INSERT INTO [dbo].[Turkin_abonent_has_contact] ([abonent_id], [contact_id]) VALUES (10, 25)
INSERT INTO [dbo].[Turkin_abonent_has_contact] ([abonent_id], [contact_id]) VALUES (10, 26)
INSERT INTO [dbo].[Turkin_abonent_has_contact] ([abonent_id], [contact_id]) VALUES (10, 27)


CREATE TABLE [dbo].[Turkin_abonent_has_contact] (
    [abonent_id] INT NOT NULL,
    [contact_id] INT NOT NULL,
    CONSTRAINT [PK_Table] PRIMARY KEY CLUSTERED ([abonent_id] ASC, [contact_id] ASC),
    CONSTRAINT [FK_Turkin_abonent_has_contact_abonent_id] FOREIGN KEY ([abonent_id]) REFERENCES [dbo].[Turkin_abonents] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_Turkin_abonent_has_contact_contact_id] FOREIGN KEY ([contact_id]) REFERENCES [dbo].[Turkin_contacts] ([Id]) ON DELETE CASCADE
);
