SELECT * FROM Turkin_abonents JOIN Turkin_abonent_has_contact ON Turkin_abonents.Id = Turkin_abonent_has_contact.abonent_id
                                    JOIN Turkin_contacts ON Turkin_abonent_has_contact.contact_id = Turkin_contacts.Id
                                    JOIN Turkin_provider ON Turkin_provider.Id = Turkin_contacts.provider_id
                                    WHERE (surname + ' ' + Turkin_abonents.name /*+ ' ' + patronymic*/ LIKE '%%') AND (phone LIKE '%89121234567%')