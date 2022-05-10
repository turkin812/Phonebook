using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

<<<<<<< HEAD


=======
>>>>>>> f3950dcd69782ea235800390b425d8ebd1adf2c5
namespace WindowsFormsApp1
{
    public partial class FormMain : Form
    {
<<<<<<< HEAD
        string sConnection = @"Data Source = LAPTOP-F1HM3G7J\SQLEXPRESS;Initial Catalog = DataBasePhonebook; Integrated Security = True";
=======
        //string sConnection = @"Data Source = 192.168.0.5; Initial Catalog= KIS;
        //                     Persist Security Info=True;User ID=sa;Password=sa";
        //string sConnection = " Server=LAPTOP-F1HM3G7J\\SQLEXPRESS;Database=LocalDataBase;Trusted_Connection=True";
        string sConnection = @" Data Source = LAPTOP - F1HM3G7J\SQLEXPRESS;Initial Catalog = DataBasePhonebook; Integrated Security = True";
>>>>>>> f3950dcd69782ea235800390b425d8ebd1adf2c5
        public FormMain()
        {
            InitializeComponent();

            UpdateAbonentsDGV();
            UpdateContactsDGV();
            UpdateProvidersDGV();
            UpdatePhonebookDGV();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (tabControl_DataBase.SelectedTab == tabPageAbonents)
            {
                FormAbonents form = new FormAbonents();

                if (form.ShowDialog() == DialogResult.OK)
                {
                    var connection = new SqlConnection(sConnection);
                    connection.Open();

<<<<<<< HEAD
                    var request = @"INSERT INTO [Turkin_abonents] (surname, name, patronymic, 
                          address, birth_date, comment)
=======
                    var request = @"INSERT INTO [Abonents] (Surname, Name, Patronymic, 
                          Address, Birth_date, Comment)
>>>>>>> f3950dcd69782ea235800390b425d8ebd1adf2c5
                          VALUES ('" + form.Surname + "','" + form.NameForm +
                          "','" + form.Patronymic + "','" + form.Address +
                          "','" + form.BirthDate + "','" + form.Comment + "')";
                    var command = new SqlCommand(request, connection);
                    command.ExecuteNonQuery();

                    UpdateAbonentsDGV();
                }
            }
            if (tabControl_DataBase.SelectedTab == tabPageContacts)
            {
                var providers = new Dictionary<int, string>();
<<<<<<< HEAD
                var providersRequest = "SELECT * FROM [Turkin_provider]";
=======
                var providersRequest = "SELECT * FROM [Providers]";
>>>>>>> f3950dcd69782ea235800390b425d8ebd1adf2c5
                var connection = new SqlConnection(sConnection);
                connection.Open();
                var providersAdapter = new SqlDataAdapter(providersRequest, connection);
                var providersTable = new DataTable();

                providersAdapter.Fill(providersTable);

                foreach (DataRow row in providersTable.Rows)
                {
<<<<<<< HEAD
                    providers.Add((int)row["Id"], row["name"].ToString());
=======
                    providers.Add((int)row["Id"], row["Name"].ToString());
>>>>>>> f3950dcd69782ea235800390b425d8ebd1adf2c5
                }


                FormContacts form = new FormContacts();
                form.ProvidersData = providers;

                if (form.ShowDialog() == DialogResult.OK)
                {

<<<<<<< HEAD
                    var request = @"INSERT INTO [Turkin_contacts] (phone, type, provider_id)
=======
                    var request = @"INSERT INTO [Contacts] (Phone, Type, Provider_Id)
>>>>>>> f3950dcd69782ea235800390b425d8ebd1adf2c5
                          VALUES ('" + form.ContactPhone + "','" + form.ContactType + "','" +
                          form.ProviderId.ToString() + "')";

                    var command = new SqlCommand(request, connection);
                    command.ExecuteNonQuery();

                    UpdateContactsDGV();
                }
            }
            if (tabControl_DataBase.SelectedTab == tabPageProviders)
            {
                FormProviders form = new FormProviders();
                if (form.ShowDialog() == DialogResult.OK)
                {
                    var connection = new SqlConnection(sConnection);
                    connection.Open();
<<<<<<< HEAD
                    var request = @"INSERT INTO [Turkin_provider] (name, score)
=======
                    var request = @"INSERT INTO [Providers] (Name, Score)
>>>>>>> f3950dcd69782ea235800390b425d8ebd1adf2c5
                          VALUES ('" + form.ProviderName + "','" + form.ProviderScore + "')";
                    var command = new SqlCommand(request, connection);
                    command.ExecuteNonQuery();

                    UpdateProvidersDGV();
                }
            }
            if (tabControl_DataBase.SelectedTab == tabPagePhonebook)
            {
                var connection = new SqlConnection(sConnection);
                connection.Open();

                #region Abonents
                var abonents = new Dictionary<int, string>();
<<<<<<< HEAD
                var abonentsRequest = "SELECT * FROM [Turkin_abonents]";
=======
                var abonentsRequest = "SELECT * FROM [Abonents]";
>>>>>>> f3950dcd69782ea235800390b425d8ebd1adf2c5
                var abonentsAdapter = new SqlDataAdapter(abonentsRequest, connection);
                var abonentsTable = new DataTable();
                abonentsAdapter.Fill(abonentsTable);
                foreach (DataRow row in abonentsTable.Rows)
                {
<<<<<<< HEAD
                    abonents.Add((int)row["Id"], row["surname"].ToString() + " " +
                        row["name"].ToString() + " " + row["patronymic"].ToString());
=======
                    abonents.Add((int)row["Id"], row["Surname"].ToString() + " " +
                        row["Name"].ToString() + " " + row["Patronymic"].ToString());
>>>>>>> f3950dcd69782ea235800390b425d8ebd1adf2c5
                }
                #endregion

                #region Contacts
                var contacts = new Dictionary<int, string>();
<<<<<<< HEAD
                var contactsRequest = "SELECT * FROM [Turkin_contacts]";
=======
                var contactsRequest = "SELECT * FROM [Contacts]";
>>>>>>> f3950dcd69782ea235800390b425d8ebd1adf2c5
                var contactsAdapter = new SqlDataAdapter(contactsRequest, connection);
                var contactsTable = new DataTable();
                contactsAdapter.Fill(contactsTable);
                foreach (DataRow row in contactsTable.Rows)
                {
<<<<<<< HEAD
                    contacts.Add((int)row["Id"], row["phone"].ToString());
=======
                    contacts.Add((int)row["Id"], row["Phone"].ToString());
>>>>>>> f3950dcd69782ea235800390b425d8ebd1adf2c5
                }
                #endregion

                FormPhonebook form = new FormPhonebook();
                form.AbonentsData = abonents;
                form.ContactsData = contacts;

                if (form.ShowDialog() == DialogResult.OK)
                {

<<<<<<< HEAD
                    var request = @"INSERT INTO [Turkin_abonent_has_contact] (abonent_id, contact_id)
=======
                    var request = @"INSERT INTO [Abonents_has_Contacts] (Abonent_Id, Contact_Id)
>>>>>>> f3950dcd69782ea235800390b425d8ebd1adf2c5
                          VALUES ('" + form.AbonentId.ToString() + "','" + form.ContactId.ToString() + "')";

                    var command = new SqlCommand(request, connection);
                    command.ExecuteNonQuery();

                    UpdatePhonebookDGV();
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (tabControl_DataBase.SelectedTab == tabPageAbonents)
            {
                if (dataGridViewAbonents.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Выберите строку");
                    return;
                }

                var row = dataGridViewAbonents.SelectedRows[0];
                var connection = new SqlConnection(sConnection);
                connection.Open();
<<<<<<< HEAD
                var request = @"DELETE FROM [Turkin_abonents] WHERE Id = " + row.Cells["Id"].Value.ToString();
=======
                var request = @"DELETE FROM [Abonents] WHERE Id = " + row.Cells["Id"].Value.ToString();
>>>>>>> f3950dcd69782ea235800390b425d8ebd1adf2c5

                var command = new SqlCommand(request, connection);
                command.ExecuteNonQuery();
                connection.Close();

                UpdateAbonentsDGV();
            }
            if (tabControl_DataBase.SelectedTab == tabPageContacts)
            {
                if (dataGridViewContacts.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Выберите строку");
                    return;
                }

                var row = dataGridViewContacts.SelectedRows[0];
                var connection = new SqlConnection(sConnection);
                connection.Open();
<<<<<<< HEAD
                var request = @"DELETE FROM [Turkin_contacts] WHERE Id = " + row.Cells["Id"].Value.ToString();
=======
                var request = @"DELETE FROM [Contacts] WHERE Id = " + row.Cells["Id"].Value.ToString();
>>>>>>> f3950dcd69782ea235800390b425d8ebd1adf2c5

                var command = new SqlCommand(request, connection);
                command.ExecuteNonQuery();
                connection.Close();

                UpdateContactsDGV();
            }
            if (tabControl_DataBase.SelectedTab == tabPageProviders)
            {
                if (dataGridViewProviders.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Выберите строку");
                    return;
                }

                var row = dataGridViewProviders.SelectedRows[0];
                var connection = new SqlConnection(sConnection);
                connection.Open();
<<<<<<< HEAD
                var request = @"DELETE FROM [Turkin_provider] WHERE Id = " + row.Cells["Id"].Value.ToString();
=======
                var request = @"DELETE FROM [Providers] WHERE Id = " + row.Cells["Id"].Value.ToString();
>>>>>>> f3950dcd69782ea235800390b425d8ebd1adf2c5

                var command = new SqlCommand(request, connection);
                command.ExecuteNonQuery();
                connection.Close();

                UpdateProvidersDGV();
            }
            if (tabControl_DataBase.SelectedTab == tabPagePhonebook)
            {
                if (dataGridViewPhonebook.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Выберите строку");
                    return;
                }

                var row = dataGridViewPhonebook.SelectedRows[0];
                var connection = new SqlConnection(sConnection);
                connection.Open();
<<<<<<< HEAD
                var request = @"DELETE FROM [Turkin_abonent_has_contact] WHERE abonent_id = "
                                    + row.Cells["abonent_id"].Value.ToString() + "AND contact_id = "
                                    + row.Cells["contact_id"].Value.ToString();
=======
                var request = @"DELETE FROM [Abonents_has_Contacts] WHERE Abonent_id = "
                                    + row.Cells["Abonent_id"].Value.ToString() + "AND Contact_id = "
                                    + row.Cells["Contact_id"].Value.ToString();
>>>>>>> f3950dcd69782ea235800390b425d8ebd1adf2c5

                var command = new SqlCommand(request, connection);
                command.ExecuteNonQuery();
                connection.Close();

                UpdatePhonebookDGV();
            }
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            if (tabControl_DataBase.SelectedTab == tabPageAbonents)
            {
                var row = dataGridViewAbonents.SelectedRows.Count > 0 ? dataGridViewAbonents.SelectedRows[0] : null;
                if (row == null) return;

                FormAbonents form = new FormAbonents();
<<<<<<< HEAD
                form.Surname = row.Cells["surname"].Value.ToString();
                form.NameForm = row.Cells["name"].Value.ToString();
                form.Patronymic = row.Cells["patronymic"].Value.ToString();
                form.Address = row.Cells["address"].Value.ToString();
                form.BirthDate = row.Cells["birth_date"].Value.ToString();
                form.Comment = row.Cells["comment"].Value.ToString();
=======
                form.Surname = row.Cells["Surname"].Value.ToString();
                form.NameForm = row.Cells["Name"].Value.ToString();
                form.Patronymic = row.Cells["Patronymic"].Value.ToString();
                form.Address = row.Cells["Address"].Value.ToString();
                form.BirthDate = row.Cells["Birth_date"].Value.ToString();
                form.Comment = row.Cells["Comment"].Value.ToString();
>>>>>>> f3950dcd69782ea235800390b425d8ebd1adf2c5

                if (form.ShowDialog() == DialogResult.OK)
                {
                    var connection = new SqlConnection(sConnection);
                    connection.Open();

<<<<<<< HEAD
                    var request = @"UPDATE [Turkin_abonents] SET surname = '" + form.Surname +
                        "', name = '" + form.NameForm + "', patronymic = '" + form.Patronymic +
                        "', address = '" + form.Address + "', birth_date = '" + form.BirthDate +
                        "', comment = '" + form.Comment + "' WHERE Id = " + row.Cells["Id"].Value.ToString();
=======
                    var request = @"UPDATE [Abonents] SET Surname = '" + form.Surname +
                        "', Name = '" + form.NameForm + "', Patronymic = '" + form.Patronymic +
                        "', Address = '" + form.Address + "', Birth_date = '" + form.BirthDate +
                        "', Comment = '" + form.Comment + "' WHERE Id = " + row.Cells["Id"].Value.ToString();
>>>>>>> f3950dcd69782ea235800390b425d8ebd1adf2c5

                    var command = new SqlCommand(request, connection);
                    command.ExecuteNonQuery();
                    connection.Close();

                    UpdateAbonentsDGV();
                }
            }
            if (tabControl_DataBase.SelectedTab == tabPageContacts)
            {
                var row = dataGridViewContacts.SelectedRows.Count > 0 ? dataGridViewContacts.SelectedRows[0] : null;
                if (row == null) return;

                var providers = new Dictionary<int, string>();
<<<<<<< HEAD
                var providersRequest = "SELECT * FROM [Turkin_provider]";
=======
                var providersRequest = "SELECT * FROM [Providers]";
>>>>>>> f3950dcd69782ea235800390b425d8ebd1adf2c5
                var connection = new SqlConnection(sConnection);
                connection.Open();
                var providersAdapter = new SqlDataAdapter(providersRequest, connection);
                var providersTable = new DataTable();

                providersAdapter.Fill(providersTable);

                foreach (DataRow data_row in providersTable.Rows)
                {
<<<<<<< HEAD
                    providers.Add((int)data_row["Id"], data_row["name"].ToString());
=======
                    providers.Add((int)data_row["Id"], data_row["Name"].ToString());
>>>>>>> f3950dcd69782ea235800390b425d8ebd1adf2c5
                }

                FormContacts form = new FormContacts();
                form.ProvidersData = providers;
<<<<<<< HEAD
                form.ContactPhone = row.Cells["phone"].Value.ToString();
                form.ContactType = row.Cells["type"].Value.ToString();
                form.ProviderId = (int)row.Cells["provider_id"].Value;
=======
                form.ContactPhone = row.Cells["Phone"].Value.ToString();
                form.ContactType = row.Cells["Type"].Value.ToString();
                form.ProviderId = (int)row.Cells["Provider_Id"].Value;
>>>>>>> f3950dcd69782ea235800390b425d8ebd1adf2c5

                if (form.ShowDialog() == DialogResult.OK)
                {

<<<<<<< HEAD
                    var request = @"UPDATE [Turkin_contacts] SET phone = '" + form.ContactPhone +
                        "', type = '" + form.ContactType +
                        "', provider_id = " + form.ProviderId.ToString() +
=======
                    var request = @"UPDATE [Contacts] SET Phone = '" + form.ContactPhone +
                        "', Type = '" + form.ContactType +
                        "', Provider_Id = " + form.ProviderId.ToString() +
>>>>>>> f3950dcd69782ea235800390b425d8ebd1adf2c5
                        "WHERE Id = " + row.Cells["Id"].Value.ToString();

                    var command = new SqlCommand(request, connection);
                    command.ExecuteNonQuery();
                    connection.Close();

                    UpdateContactsDGV();
                }
            }
            if (tabControl_DataBase.SelectedTab == tabPageProviders)
            {
<<<<<<< HEAD
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

=======
>>>>>>> f3950dcd69782ea235800390b425d8ebd1adf2c5
                var row = dataGridViewProviders.SelectedRows.Count > 0 ? dataGridViewProviders.SelectedRows[0] : null;
                if (row == null) return;

                FormProviders form = new FormProviders();
<<<<<<< HEAD
                form.ProviderName = row.Cells["name"].Value.ToString();
                form.ProviderScore = row.Cells["score"].Value.ToString();
=======
                form.ProviderName = row.Cells["Name"].Value.ToString();
                form.ProviderScore = row.Cells["Score"].Value.ToString();
>>>>>>> f3950dcd69782ea235800390b425d8ebd1adf2c5

                if (form.ShowDialog() == DialogResult.OK)
                {
                    var connection = new SqlConnection(sConnection);
                    connection.Open();

<<<<<<< HEAD
                    var request = @"UPDATE [Turkin_provider] SET name = '" + form.ProviderName +
                        "', score = '" + form.ProviderScore + "' WHERE Id = " + row.Cells["Id"].Value.ToString();
=======
                    var request = @"UPDATE [Providers] SET Name = '" + form.ProviderName +
                        "', Score = '" + form.ProviderScore + "' WHERE Id = " + row.Cells["Id"].Value.ToString();
>>>>>>> f3950dcd69782ea235800390b425d8ebd1adf2c5

                    var command = new SqlCommand(request, connection);
                    command.ExecuteNonQuery();
                    connection.Close();

                    UpdateProvidersDGV();
                }
            }
            if (tabControl_DataBase.SelectedTab == tabPagePhonebook)
            {
                var row = dataGridViewPhonebook.SelectedRows.Count > 0 ? dataGridViewPhonebook.SelectedRows[0] : null;
                if (row == null) return;

                var connection = new SqlConnection(sConnection);
                connection.Open();

                #region Abonents
                var abonents = new Dictionary<int, string>();
<<<<<<< HEAD
                var abonentsRequest = "SELECT * FROM [Turkin_abonents]";
=======
                var abonentsRequest = "SELECT * FROM [Abonents]";
>>>>>>> f3950dcd69782ea235800390b425d8ebd1adf2c5
                var abonentsAdapter = new SqlDataAdapter(abonentsRequest, connection);
                var abonentsTable = new DataTable();
                abonentsAdapter.Fill(abonentsTable);
                foreach (DataRow data_row in abonentsTable.Rows)
                {
<<<<<<< HEAD
                    abonents.Add((int)data_row["Id"], data_row["surname"].ToString() + " " +
                        data_row["name"].ToString() + " " + data_row["patronymic"].ToString());
                }
                #endregion

                #region Turkin_contacts
                var contacts = new Dictionary<int, string>();
                var contactsRequest = "SELECT * FROM [Turkin_contacts]";
=======
                    abonents.Add((int)data_row["Id"], data_row["Surname"].ToString() + " " +
                        data_row["Name"].ToString() + " " + data_row["Patronymic"].ToString());
                }
                #endregion

                #region Contacts
                var contacts = new Dictionary<int, string>();
                var contactsRequest = "SELECT * FROM [Contacts]";
>>>>>>> f3950dcd69782ea235800390b425d8ebd1adf2c5
                var contactsAdapter = new SqlDataAdapter(contactsRequest, connection);
                var contactsTable = new DataTable();
                contactsAdapter.Fill(contactsTable);
                foreach (DataRow data_row in contactsTable.Rows)
                {
<<<<<<< HEAD
                    contacts.Add((int)data_row["Id"], data_row["phone"].ToString());
=======
                    contacts.Add((int)data_row["Id"], data_row["Phone"].ToString());
>>>>>>> f3950dcd69782ea235800390b425d8ebd1adf2c5
                }
                #endregion

                FormPhonebook form = new FormPhonebook();
                form.AbonentsData = abonents;
                form.ContactsData = contacts;

<<<<<<< HEAD
                form.AbonentId = (int)row.Cells["abonent_id"].Value;
                form.ContactId = (int)row.Cells["contact_id"].Value;

                if (form.ShowDialog() == DialogResult.OK)
                {
                    var request = @"UPDATE [Turkin_abonent_has_contact] SET abonent_id = "
                                    + form.AbonentId.ToString() + ", contact_id = "
                                    + form.ContactId.ToString() + "WHERE Abonent_id = "
                                    + row.Cells["abonent_id"].Value.ToString() + "AND contact_id = "
                                    + row.Cells["contact_id"].Value.ToString();
=======
                form.AbonentId = (int)row.Cells["Abonent_id"].Value;
                form.ContactId = (int)row.Cells["Contact_id"].Value;

                if (form.ShowDialog() == DialogResult.OK)
                {
                    var request = @"UPDATE [Abonents_has_Contacts] SET Abonent_id = "
                                    + form.AbonentId.ToString() + ", Contact_id = "
                                    + form.ContactId.ToString() + "WHERE Abonent_id = "
                                    + row.Cells["Abonent_id"].Value.ToString() + "AND Contact_id = "
                                    + row.Cells["Contact_id"].Value.ToString();
>>>>>>> f3950dcd69782ea235800390b425d8ebd1adf2c5

                    var command = new SqlCommand(request, connection);
                    command.ExecuteNonQuery();
                    connection.Close();

                    UpdatePhonebookDGV();
                }



            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (tabControl_DataBase.SelectedTab == tabPageAbonents)
            {
                UpdateAbonentsDGV();
            }
            if (tabControl_DataBase.SelectedTab == tabPageContacts)
            {
                UpdateContactsDGV();
            }
            if (tabControl_DataBase.SelectedTab == tabPageProviders)
            {
                UpdateProvidersDGV();
            }
            if (tabControl_DataBase.SelectedTab == tabPagePhonebook)
            {
                UpdatePhonebookDGV();
            }
        }

        private DataTable dtGridViewTable(string sAdd, string sConnect)
        {
            SqlDataAdapter aOrder = new SqlDataAdapter(sAdd, sConnect);
            DataTable tOrder = new DataTable();
            aOrder.Fill(tOrder);
            return tOrder;
        }

        private void UpdatePhonebookDGV()
        {

            string SNP = textBoxSNP.Text;
            string PhoneNumber = textBoxPhoneNumber.Text;

<<<<<<< HEAD
            string sAdd = @"SELECT * FROM [Turkin_abonents] 
                         JOIN [Turkin_abonent_has_contact] 
                         ON [Turkin_abonent_has_contact].abonent_id = [Turkin_abonents].Id 
                         JOIN [Turkin_contacts]  
                         ON [Turkin_abonent_has_contact].contact_id = [Turkin_contacts].Id
                         JOIN [Turkin_provider]
                         ON [Turkin_contacts].provider_id = [Turkin_provider].Id
                         WHERE (surname + ' ' + Turkin_abonents.name + ' ' + patronymic LIKE '%" + SNP + "%') AND (phone LIKE '%" + PhoneNumber + "%')";
=======
            string sAdd = @"SELECT * FROM [Abonents] 
                         JOIN [Abonents_has_Contacts] 
                         ON [Abonents_has_Contacts].Abonent_id = [Abonents].Id 
                         JOIN [Contacts]  
                         ON [Abonents_has_Contacts].Contact_id = [Contacts].Id
                         JOIN [Providers]
                         ON [Contacts].Provider_Id = [Providers].Id
                         WHERE (Surname + ' ' + Abonents.Name + ' ' + Patronymic LIKE '%" + SNP + "%') AND (Phone LIKE '%" + PhoneNumber + "%')";
>>>>>>> f3950dcd69782ea235800390b425d8ebd1adf2c5

            dataGridViewPhonebook.DataSource = dtGridViewTable(sAdd, sConnection);
            dataGridViewPhonebook.Columns["Id"].Visible = false;
            dataGridViewPhonebook.Columns["Id1"].Visible = false;
            dataGridViewPhonebook.Columns["Id2"].Visible = false;
<<<<<<< HEAD
            dataGridViewPhonebook.Columns["contact_id"].Visible = false;
            dataGridViewPhonebook.Columns["abonent_id"].Visible = false;
            dataGridViewPhonebook.Columns["provider_Id"].Visible = false;
            dataGridViewPhonebook.Columns["name"].HeaderText = "Имя";
            dataGridViewPhonebook.Columns["surname"].HeaderText = "Фамилия";
            dataGridViewPhonebook.Columns["patronymic"].HeaderText = "Отчество";
            dataGridViewPhonebook.Columns["address"].HeaderText = "Адрес";
            dataGridViewPhonebook.Columns["birth_date"].HeaderText = "Дата рождения";
            dataGridViewPhonebook.Columns["comment"].HeaderText = "Комментарий";
            dataGridViewPhonebook.Columns["phone"].HeaderText = "Телефон";
            dataGridViewPhonebook.Columns["type"].HeaderText = "Тип телефона";
            dataGridViewPhonebook.Columns["name1"].HeaderText = "Названиние оператора";
            dataGridViewPhonebook.Columns["score"].HeaderText = "Рейтинг";
        }
        private void UpdateContactsDGV()
        {
            string sAdd = "SELECT * FROM [Turkin_contacts]";
            dataGridViewContacts.DataSource = dtGridViewTable(sAdd, sConnection);
            dataGridViewContacts.Columns["Id"].Visible = false;
            dataGridViewContacts.Columns["phone"].HeaderText = "Телефон";
            dataGridViewContacts.Columns["type"].HeaderText = "Тип телефона";
            dataGridViewContacts.Columns["provider_id"].HeaderText = "Id оператора";
        }
        private void UpdateProvidersDGV()
        {
            string sAdd = "SELECT * FROM [Turkin_provider]";
            dataGridViewProviders.DataSource = dtGridViewTable(sAdd, sConnection);

            dataGridViewProviders.Columns["Id"].Visible = false;
            dataGridViewProviders.Columns["name"].HeaderText = "Названиние оператора";
            dataGridViewProviders.Columns["score"].HeaderText = "Рейтинг";
        }
        private void UpdateAbonentsDGV()
        {
            string sAdd = "SELECT * FROM [Turkin_abonents]";
            dataGridViewAbonents.DataSource = dtGridViewTable(sAdd, sConnection);
            dataGridViewAbonents.Columns["Id"].Visible = false;
            dataGridViewAbonents.Columns["name"].HeaderText = "Имя";
            dataGridViewAbonents.Columns["surname"].HeaderText = "Фамилия";
            dataGridViewAbonents.Columns["patronymic"].HeaderText = "Отчество";
            dataGridViewAbonents.Columns["address"].HeaderText = "Адрес";
            dataGridViewAbonents.Columns["birth_date"].HeaderText = "Дата рождения";
            dataGridViewAbonents.Columns["comment"].HeaderText = "Комментарий";
=======
            dataGridViewPhonebook.Columns["Contact_id"].Visible = false;
            dataGridViewPhonebook.Columns["Abonent_id"].Visible = false;
            dataGridViewPhonebook.Columns["Provider_Id"].Visible = false;
            dataGridViewPhonebook.Columns["Name"].HeaderText = "Имя";
            dataGridViewPhonebook.Columns["Surname"].HeaderText = "Фамилия";
            dataGridViewPhonebook.Columns["Patronymic"].HeaderText = "Отчество";
            dataGridViewPhonebook.Columns["Address"].HeaderText = "Адрес";
            dataGridViewPhonebook.Columns["Birth_date"].HeaderText = "Дата рождения";
            dataGridViewPhonebook.Columns["Comment"].HeaderText = "Комментарий";
            dataGridViewPhonebook.Columns["Phone"].HeaderText = "Телефон";
            dataGridViewPhonebook.Columns["Type"].HeaderText = "Тип телефона";
            dataGridViewPhonebook.Columns["Name1"].HeaderText = "Названиние оператора";
            dataGridViewPhonebook.Columns["Score"].HeaderText = "Рейтинг";
        }
        private void UpdateContactsDGV()
        {
            string sAdd = "SELECT * FROM [Contacts]";
            dataGridViewContacts.DataSource = dtGridViewTable(sAdd, sConnection);
            dataGridViewContacts.Columns["Id"].Visible = false;
            dataGridViewContacts.Columns["Phone"].HeaderText = "Телефон";
            dataGridViewContacts.Columns["Type"].HeaderText = "Тип телефона";
            dataGridViewContacts.Columns["Provider_Id"].HeaderText = "Id оператора";
        }
        private void UpdateProvidersDGV()
        {
            string sAdd = "SELECT * FROM [Providers]";
            dataGridViewProviders.DataSource = dtGridViewTable(sAdd, sConnection);

            dataGridViewProviders.Columns["Id"].Visible = false;
            dataGridViewProviders.Columns["Name"].HeaderText = "Названиние оператора";
            dataGridViewProviders.Columns["Score"].HeaderText = "Рейтинг";
        }
        private void UpdateAbonentsDGV()
        {
            string sAdd = "SELECT * FROM [Abonents]";
            dataGridViewAbonents.DataSource = dtGridViewTable(sAdd, sConnection);
            dataGridViewAbonents.Columns["Id"].Visible = false;
            dataGridViewAbonents.Columns["Name"].HeaderText = "Имя";
            dataGridViewAbonents.Columns["Surname"].HeaderText = "Фамилия";
            dataGridViewAbonents.Columns["Patronymic"].HeaderText = "Отчество";
            dataGridViewAbonents.Columns["Address"].HeaderText = "Адрес";
            dataGridViewAbonents.Columns["Birth_date"].HeaderText = "Дата рождения";
            dataGridViewAbonents.Columns["Comment"].HeaderText = "Комментарий";
>>>>>>> f3950dcd69782ea235800390b425d8ebd1adf2c5
        }

        private void textBoxSNP_TextChanged(object sender, EventArgs e)
        {
            UpdatePhonebookDGV();
        }
        private void textBoxPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            UpdatePhonebookDGV();
        }

        private void tabControl_DataBase_Selected(object sender, TabControlEventArgs e)
        {
            if (tabControl_DataBase.SelectedTab == tabPageAbonents) UpdateAbonentsDGV();
            if (tabControl_DataBase.SelectedTab == tabPageContacts) UpdateContactsDGV();
            if (tabControl_DataBase.SelectedTab == tabPageProviders) UpdateProvidersDGV();
            if (tabControl_DataBase.SelectedTab == tabPagePhonebook) UpdatePhonebookDGV();
        }
<<<<<<< HEAD

        private void UpdateTable(object sender, EventArgs e)
        {
            UpdatePhonebookDGV();
        }
=======
>>>>>>> f3950dcd69782ea235800390b425d8ebd1adf2c5
    }
}
