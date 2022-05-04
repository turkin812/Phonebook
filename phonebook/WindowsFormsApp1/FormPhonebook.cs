using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormPhonebook : Form
    {
        public FormPhonebook()
        {
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        public Dictionary<int, string> AbonentsData
        {
            set
            {
                comboBoxAbonent.DataSource = value.ToArray();
                comboBoxAbonent.DisplayMember = "value";
            }
        }

        public int AbonentId
        {
            get
            {
                return ((KeyValuePair<int, string>)comboBoxAbonent.SelectedItem).Key;
            }

            set
            {
                for (int i = 0; i < comboBoxAbonent.Items.Count; i++)
                {
                    if (((KeyValuePair<int, string>)comboBoxAbonent.Items[i]).Key == value)
                    {
                        comboBoxAbonent.SelectedIndex = i;
                        break;
                    }
                }
            }
        }

        public Dictionary<int, string> ContactsData
        {
            set
            {
                comboBoxContact.DataSource = value.ToArray();
                comboBoxContact.DisplayMember = "value";
            }
        }

        public int ContactId
        {
            get
            {
                return ((KeyValuePair<int, string>)comboBoxContact.SelectedItem).Key;
            }

            set
            {
                for (int i = 0; i < comboBoxContact.Items.Count; i++)
                {
                    if (((KeyValuePair<int, string>)comboBoxContact.Items[i]).Key == value)
                    {
                        comboBoxContact.SelectedIndex = i;
                        break;
                    }
                }
            }
        }
    }
}
