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
    public partial class RegistrationConfirmationForm : ParentUserForm
    {
        public RegistrationConfirmationForm()
        {
            InitializeComponent();
        }

        private void RegistrationConfirmationForm_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            TFunction.NextMainForm("Practika.RunnerMenuForm", this);
        }
    }
}
