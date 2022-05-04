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
    public partial class FormContacts : Form
    {
        public FormContacts()
        {
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        public Dictionary<int, string> ProvidersData
        {
            set
            {
                comboBoxProviders.DataSource = value.ToArray();
                comboBoxProviders.DisplayMember = "value";
            }
        }

        public int ProviderId
        {
            get
            {
                return ((KeyValuePair<int, string>)comboBoxProviders.SelectedItem).Key;
            }

            set
            {
                for (int i = 0; i < comboBoxProviders.Items.Count; i++)
                {
                    if (((KeyValuePair<int, string>)comboBoxProviders.Items[i]).Key == value)
                    {
                        comboBoxProviders.SelectedIndex = i;
                        break;
                    }
                }
            }
        }

        public string ContactPhone
        {
            get { return textBoxPhoneNumber.Text; }

            set { textBoxPhoneNumber.Text = value; }
        }
        public string ContactType
        {
            get { return textBoxPhoneType.Text; }

            set { textBoxPhoneType.Text = value; }
        }


        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
