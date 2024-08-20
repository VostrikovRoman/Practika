using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practika
{
    public partial class SignInForm : ParentForm
    {
        public SignInForm()
        {
            InitializeComponent();
        }

        private void SignInForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TFunction.NextMainForm("Practika.MainForm", this);
        }

        private void sign_in_button_Click(object sender, EventArgs e)
        {
            if (AccessControl.AutorizationInSystem(login.Text, password.Text) == 1)
                AccessControl.GetRights(this);
            else
                MessageBox.Show("Неправильно указан логин или пароль");
        }
    }
}
