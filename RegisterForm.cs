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
    public partial class RegisterForm : ParentForm
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TFunction.NextMainForm("Practika.MainForm", this);
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            TFunction.NextMainForm("Practika.SignInForm", this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TFunction.NextMainForm("Practika.SignInForm", this);
        }
    }
}
