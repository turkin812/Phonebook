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
    public partial class FormProviders : Form
    {
        public FormProviders()
        {
            InitializeComponent();
        }
<<<<<<< HEAD

        private void buttonProviderRegister_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        public string ProviderName
        {
            get { return textBoxProviderName.Text; }

            set { textBoxProviderName.Text = value; }
        }
        public string ProviderScore
        {
            get { return textBoxProviderScore.Text; }

            set { textBoxProviderScore.Text = value; }
        }

        private void buttonProviderCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
=======
>>>>>>> f3950dcd69782ea235800390b425d8ebd1adf2c5
    }
}
