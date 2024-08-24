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
    public partial class RegistrRunnerForm : ParentForm
    {
        public RegistrRunnerForm()
        {
            InitializeComponent();
        }

        private void RegistrRunnerForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TFunction.NextMainForm("Practika.SignInForm", this);
        }
    }
}
