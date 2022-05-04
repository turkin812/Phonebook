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



namespace WindowsFormsApp1
{
    public partial class FormMain : Form
    {
        string sConnection = @"Data Source = LAPTOP-F1HM3G7J\SQLEXPRESS;Initial Catalog = DataBasePhonebook; Integrated Security = True";
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

                    var request = @"INSERT INTO [Turkin_abonents] (surname, name, patronymic, 
                          address, birth_date, comment)
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
                var providersRequest = "SELECT * FROM [Turkin_provider]";
                var connection = new SqlConnection(sConnection);
                connection.Open();
                var providersAdapter = new SqlDataAdapter(providersRequest, connection);
                var providersTable = new DataTable();

                providersAdapter.Fill(providersTable);

                foreach (DataRow row in providersTable.Rows)
                {
                    providers.Add((int)row["Id"], row["name"].ToString());
                }


                FormContacts form = new FormContacts();
                form.ProvidersData = providers;

                if (form.ShowDialog() == DialogResult.OK)
                {

                    var request = @"INSERT INTO [Turkin_contacts] (phone, type, provider_id)
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
                    var request = @"INSERT INTO [Turkin_provider] (name, score)
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
                var abonentsRequest = "SELECT * FROM [Turkin_abonents]";
                var abonentsAdapter = new SqlDataAdapter(abonentsRequest, connection);
                var abonentsTable = new DataTable();
                abonentsAdapter.Fill(abonentsTable);
                foreach (DataRow row in abonentsTable.Rows)
                {
                    abonents.Add((int)row["Id"], row["surname"].ToString() + " " +
                        row["name"].ToString() + " " + row["patronymic"].ToString());
                }
                #endregion

                #region Contacts
                var contacts = new Dictionary<int, string>();
                var contactsRequest = "SELECT * FROM [Turkin_contacts]";
                var contactsAdapter = new SqlDataAdapter(contactsRequest, connection);
                var contactsTable = new DataTable();
                contactsAdapter.Fill(contactsTable);
                foreach (DataRow row in contactsTable.Rows)
                {
                    contacts.Add((int)row["Id"], row["phone"].ToString());
                }
                #endregion

                FormPhonebook form = new FormPhonebook();
                form.AbonentsData = abonents;
                form.ContactsData = contacts;

                if (form.ShowDialog() == DialogResult.OK)
                {

                    var request = @"INSERT INTO [Turkin_abonent_has_contact] (abonent_id, contact_id)
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
                var request = @"DELETE FROM [Turkin_abonents] WHERE Id = " + row.Cells["Id"].Value.ToString();

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
                var request = @"DELETE FROM [Turkin_contacts] WHERE Id = " + row.Cells["Id"].Value.ToString();

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
                var request = @"DELETE FROM [Turkin_provider] WHERE Id = " + row.Cells["Id"].Value.ToString();

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
                var request = @"DELETE FROM [Turkin_abonent_has_contact] WHERE abonent_id = "
                                    + row.Cells["abonent_id"].Value.ToString() + "AND contact_id = "
                                    + row.Cells["contact_id"].Value.ToString();

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
                form.Surname = row.Cells["surname"].Value.ToString();
                form.NameForm = row.Cells["name"].Value.ToString();
                form.Patronymic = row.Cells["patronymic"].Value.ToString();
                form.Address = row.Cells["address"].Value.ToString();
                form.BirthDate = row.Cells["birth_date"].Value.ToString();
                form.Comment = row.Cells["comment"].Value.ToString();

                if (form.ShowDialog() == DialogResult.OK)
                {
                    var connection = new SqlConnection(sConnection);
                    connection.Open();

                    var request = @"UPDATE [Turkin_abonents] SET surname = '" + form.Surname +
                        "', name = '" + form.NameForm + "', patronymic = '" + form.Patronymic +
                        "', address = '" + form.Address + "', birth_date = '" + form.BirthDate +
                        "', comment = '" + form.Comment + "' WHERE Id = " + row.Cells["Id"].Value.ToString();

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
                var providersRequest = "SELECT * FROM [Turkin_provider]";
                var connection = new SqlConnection(sConnection);
                connection.Open();
                var providersAdapter = new SqlDataAdapter(providersRequest, connection);
                var providersTable = new DataTable();

                providersAdapter.Fill(providersTable);

                foreach (DataRow data_row in providersTable.Rows)
                {
                    providers.Add((int)data_row["Id"], data_row["name"].ToString());
                }

                FormContacts form = new FormContacts();
                form.ProvidersData = providers;
                form.ContactPhone = row.Cells["phone"].Value.ToString();
                form.ContactType = row.Cells["type"].Value.ToString();
                form.ProviderId = (int)row.Cells["provider_id"].Value;

                if (form.ShowDialog() == DialogResult.OK)
                {

                    var request = @"UPDATE [Turkin_contacts] SET phone = '" + form.ContactPhone +
                        "', type = '" + form.ContactType +
                        "', provider_id = " + form.ProviderId.ToString() +
                        "WHERE Id = " + row.Cells["Id"].Value.ToString();

                    var command = new SqlCommand(request, connection);
                    command.ExecuteNonQuery();
                    connection.Close();

                    UpdateContactsDGV();
                }
            }
            if (tabControl_DataBase.SelectedTab == tabPageProviders)
            {
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

                var row = dataGridViewProviders.SelectedRows.Count > 0 ? dataGridViewProviders.SelectedRows[0] : null;
                if (row == null) return;

                FormProviders form = new FormProviders();
                form.ProviderName = row.Cells["name"].Value.ToString();
                form.ProviderScore = row.Cells["score"].Value.ToString();

                if (form.ShowDialog() == DialogResult.OK)
                {
                    var connection = new SqlConnection(sConnection);
                    connection.Open();

                    var request = @"UPDATE [Turkin_provider] SET name = '" + form.ProviderName +
                        "', score = '" + form.ProviderScore + "' WHERE Id = " + row.Cells["Id"].Value.ToString();

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
                var abonentsRequest = "SELECT * FROM [Turkin_abonents]";
                var abonentsAdapter = new SqlDataAdapter(abonentsRequest, connection);
                var abonentsTable = new DataTable();
                abonentsAdapter.Fill(abonentsTable);
                foreach (DataRow data_row in abonentsTable.Rows)
                {
                    abonents.Add((int)data_row["Id"], data_row["surname"].ToString() + " " +
                        data_row["name"].ToString() + " " + data_row["patronymic"].ToString());
                }
                #endregion

                #region Turkin_contacts
                var contacts = new Dictionary<int, string>();
                var contactsRequest = "SELECT * FROM [Turkin_contacts]";
                var contactsAdapter = new SqlDataAdapter(contactsRequest, connection);
                var contactsTable = new DataTable();
                contactsAdapter.Fill(contactsTable);
                foreach (DataRow data_row in contactsTable.Rows)
                {
                    contacts.Add((int)data_row["Id"], data_row["phone"].ToString());
                }
                #endregion

                FormPhonebook form = new FormPhonebook();
                form.AbonentsData = abonents;
                form.ContactsData = contacts;

                form.AbonentId = (int)row.Cells["abonent_id"].Value;
                form.ContactId = (int)row.Cells["contact_id"].Value;

                if (form.ShowDialog() == DialogResult.OK)
                {
                    var request = @"UPDATE [Turkin_abonent_has_contact] SET abonent_id = "
                                    + form.AbonentId.ToString() + ", contact_id = "
                                    + form.ContactId.ToString() + "WHERE Abonent_id = "
                                    + row.Cells["abonent_id"].Value.ToString() + "AND contact_id = "
                                    + row.Cells["contact_id"].Value.ToString();

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

            string sAdd = @"SELECT * FROM [Turkin_abonents] 
                         JOIN [Turkin_abonent_has_contact] 
                         ON [Turkin_abonent_has_contact].abonent_id = [Turkin_abonents].Id 
                         JOIN [Turkin_contacts]  
                         ON [Turkin_abonent_has_contact].contact_id = [Turkin_contacts].Id
                         JOIN [Turkin_provider]
                         ON [Turkin_contacts].provider_id = [Turkin_provider].Id
                         WHERE (surname + ' ' + Turkin_abonents.name + ' ' + patronymic LIKE '%" + SNP + "%') AND (phone LIKE '%" + PhoneNumber + "%')";

            dataGridViewPhonebook.DataSource = dtGridViewTable(sAdd, sConnection);
            dataGridViewPhonebook.Columns["Id"].Visible = false;
            dataGridViewPhonebook.Columns["Id1"].Visible = false;
            dataGridViewPhonebook.Columns["Id2"].Visible = false;
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

        private void UpdateTable(object sender, EventArgs e)
        {
            UpdatePhonebookDGV();
        }
    }
}
