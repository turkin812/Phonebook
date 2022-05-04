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
    public partial class FormAbonents : Form
    {
        public FormAbonents()
        {
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
        public string Surname
        {
            get { return textBoxSurname.Text; }

            set { textBoxSurname.Text = value; }
        }
        public string NameForm
        {
            get { return textBoxName.Text; }

            set { textBoxName.Text = value; }
        }
        public string Patronymic
        {
            get { return textBoxPatronymic.Text; }

            set { textBoxPatronymic.Text = value; }
        }
        public string Address
        {
            get { return textBoxAddress.Text; }

            set { textBoxAddress.Text = value; }
        }
        public string BirthDate
        {
            get { return textBoxBirthDate.Text; }

            set { textBoxBirthDate.Text = value; }
        }
        public string Comment
        {
            get { return textBoxComment.Text; }

            set { textBoxComment.Text = value; }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
