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
        //string sConnection = @"Data Source = 192.168.0.5; Initial Catalog= KIS;
        //                     Persist Security Info=True;User ID=sa;Password=sa";
        //string sConnection = " Server=LAPTOP-F1HM3G7J\\SQLEXPRESS;Database=LocalDataBase;Trusted_Connection=True";
        string sConnection = @" Data Source = LAPTOP - F1HM3G7J\SQLEXPRESS;Initial Catalog = DataBasePhonebook; Integrated Security = True";
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

                    var request = @"INSERT INTO [Abonents] (Surname, Name, Patronymic, 
                          Address, Birth_date, Comment)
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
                var providersRequest = "SELECT * FROM [Providers]";
                var connection = new SqlConnection(sConnection);
                connection.Open();
                var providersAdapter = new SqlDataAdapter(providersRequest, connection);
                var providersTable = new DataTable();

                providersAdapter.Fill(providersTable);

                foreach (DataRow row in providersTable.Rows)
                {
                    providers.Add((int)row["Id"], row["Name"].ToString());
                }


                FormContacts form = new FormContacts();
                form.ProvidersData = providers;

                if (form.ShowDialog() == DialogResult.OK)
                {

                    var request = @"INSERT INTO [Contacts] (Phone, Type, Provider_Id)
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
                    var request = @"INSERT INTO [Providers] (Name, Score)
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
                var abonentsRequest = "SELECT * FROM [Abonents]";
                var abonentsAdapter = new SqlDataAdapter(abonentsRequest, connection);
                var abonentsTable = new DataTable();
                abonentsAdapter.Fill(abonentsTable);
                foreach (DataRow row in abonentsTable.Rows)
                {
                    abonents.Add((int)row["Id"], row["Surname"].ToString() + " " +
                        row["Name"].ToString() + " " + row["Patronymic"].ToString());
                }
                #endregion

                #region Contacts
                var contacts = new Dictionary<int, string>();
                var contactsRequest = "SELECT * FROM [Contacts]";
                var contactsAdapter = new SqlDataAdapter(contactsRequest, connection);
                var contactsTable = new DataTable();
                contactsAdapter.Fill(contactsTable);
                foreach (DataRow row in contactsTable.Rows)
                {
                    contacts.Add((int)row["Id"], row["Phone"].ToString());
                }
                #endregion

                FormPhonebook form = new FormPhonebook();
                form.AbonentsData = abonents;
                form.ContactsData = contacts;

                if (form.ShowDialog() == DialogResult.OK)
                {

                    var request = @"INSERT INTO [Abonents_has_Contacts] (Abonent_Id, Contact_Id)
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
                var request = @"DELETE FROM [Abonents] WHERE Id = " + row.Cells["Id"].Value.ToString();

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
                var request = @"DELETE FROM [Contacts] WHERE Id = " + row.Cells["Id"].Value.ToString();

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
                var request = @"DELETE FROM [Providers] WHERE Id = " + row.Cells["Id"].Value.ToString();

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
                var request = @"DELETE FROM [Abonents_has_Contacts] WHERE Abonent_id = "
                                    + row.Cells["Abonent_id"].Value.ToString() + "AND Contact_id = "
                                    + row.Cells["Contact_id"].Value.ToString();

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
                form.Surname = row.Cells["Surname"].Value.ToString();
                form.NameForm = row.Cells["Name"].Value.ToString();
                form.Patronymic = row.Cells["Patronymic"].Value.ToString();
                form.Address = row.Cells["Address"].Value.ToString();
                form.BirthDate = row.Cells["Birth_date"].Value.ToString();
                form.Comment = row.Cells["Comment"].Value.ToString();

                if (form.ShowDialog() == DialogResult.OK)
                {
                    var connection = new SqlConnection(sConnection);
                    connection.Open();

                    var request = @"UPDATE [Abonents] SET Surname = '" + form.Surname +
                        "', Name = '" + form.NameForm + "', Patronymic = '" + form.Patronymic +
                        "', Address = '" + form.Address + "', Birth_date = '" + form.BirthDate +
                        "', Comment = '" + form.Comment + "' WHERE Id = " + row.Cells["Id"].Value.ToString();

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
                var providersRequest = "SELECT * FROM [Providers]";
                var connection = new SqlConnection(sConnection);
                connection.Open();
                var providersAdapter = new SqlDataAdapter(providersRequest, connection);
                var providersTable = new DataTable();

                providersAdapter.Fill(providersTable);

                foreach (DataRow data_row in providersTable.Rows)
                {
                    providers.Add((int)data_row["Id"], data_row["Name"].ToString());
                }

                FormContacts form = new FormContacts();
                form.ProvidersData = providers;
                form.ContactPhone = row.Cells["Phone"].Value.ToString();
                form.ContactType = row.Cells["Type"].Value.ToString();
                form.ProviderId = (int)row.Cells["Provider_Id"].Value;

                if (form.ShowDialog() == DialogResult.OK)
                {

                    var request = @"UPDATE [Contacts] SET Phone = '" + form.ContactPhone +
                        "', Type = '" + form.ContactType +
                        "', Provider_Id = " + form.ProviderId.ToString() +
                        "WHERE Id = " + row.Cells["Id"].Value.ToString();

                    var command = new SqlCommand(request, connection);
                    command.ExecuteNonQuery();
                    connection.Close();

                    UpdateContactsDGV();
                }
            }
            if (tabControl_DataBase.SelectedTab == tabPageProviders)
            {
                var row = dataGridViewProviders.SelectedRows.Count > 0 ? dataGridViewProviders.SelectedRows[0] : null;
                if (row == null) return;

                FormProviders form = new FormProviders();
                form.ProviderName = row.Cells["Name"].Value.ToString();
                form.ProviderScore = row.Cells["Score"].Value.ToString();

                if (form.ShowDialog() == DialogResult.OK)
                {
                    var connection = new SqlConnection(sConnection);
                    connection.Open();

                    var request = @"UPDATE [Providers] SET Name = '" + form.ProviderName +
                        "', Score = '" + form.ProviderScore + "' WHERE Id = " + row.Cells["Id"].Value.ToString();

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
                var abonentsRequest = "SELECT * FROM [Abonents]";
                var abonentsAdapter = new SqlDataAdapter(abonentsRequest, connection);
                var abonentsTable = new DataTable();
                abonentsAdapter.Fill(abonentsTable);
                foreach (DataRow data_row in abonentsTable.Rows)
                {
                    abonents.Add((int)data_row["Id"], data_row["Surname"].ToString() + " " +
                        data_row["Name"].ToString() + " " + data_row["Patronymic"].ToString());
                }
                #endregion

                #region Contacts
                var contacts = new Dictionary<int, string>();
                var contactsRequest = "SELECT * FROM [Contacts]";
                var contactsAdapter = new SqlDataAdapter(contactsRequest, connection);
                var contactsTable = new DataTable();
                contactsAdapter.Fill(contactsTable);
                foreach (DataRow data_row in contactsTable.Rows)
                {
                    contacts.Add((int)data_row["Id"], data_row["Phone"].ToString());
                }
                #endregion

                FormPhonebook form = new FormPhonebook();
                form.AbonentsData = abonents;
                form.ContactsData = contacts;

                form.AbonentId = (int)row.Cells["Abonent_id"].Value;
                form.ContactId = (int)row.Cells["Contact_id"].Value;

                if (form.ShowDialog() == DialogResult.OK)
                {
                    var request = @"UPDATE [Abonents_has_Contacts] SET Abonent_id = "
                                    + form.AbonentId.ToString() + ", Contact_id = "
                                    + form.ContactId.ToString() + "WHERE Abonent_id = "
                                    + row.Cells["Abonent_id"].Value.ToString() + "AND Contact_id = "
                                    + row.Cells["Contact_id"].Value.ToString();

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

            string sAdd = @"SELECT * FROM [Abonents] 
                         JOIN [Abonents_has_Contacts] 
                         ON [Abonents_has_Contacts].Abonent_id = [Abonents].Id 
                         JOIN [Contacts]  
                         ON [Abonents_has_Contacts].Contact_id = [Contacts].Id
                         JOIN [Providers]
                         ON [Contacts].Provider_Id = [Providers].Id
                         WHERE (Surname + ' ' + Abonents.Name + ' ' + Patronymic LIKE '%" + SNP + "%') AND (Phone LIKE '%" + PhoneNumber + "%')";

            dataGridViewPhonebook.DataSource = dtGridViewTable(sAdd, sConnection);
            dataGridViewPhonebook.Columns["Id"].Visible = false;
            dataGridViewPhonebook.Columns["Id1"].Visible = false;
            dataGridViewPhonebook.Columns["Id2"].Visible = false;
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
    }
}
