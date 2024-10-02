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
    public partial class MainForm : ParentForm
    {
        public MainForm()
        {
            InitializeComponent();
            label2.Text = "Москва, Россия\nсреда 21 октября 2016";
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TFunction.NextMainForm("Practika.InfoForm", this);
        }

        private void login_button_Click_1(object sender, EventArgs e)
        {
            TFunction.NextMainForm("Practika.SignInForm", this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TFunction.NextMainForm("Practika.RegisterForm", this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TFunction.NextMainForm("Practika.SponsorForm", this);
        }
    }
}
