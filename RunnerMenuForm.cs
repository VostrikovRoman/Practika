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
    public partial class RunnerMenuForm : ParentUserForm
    {
        public RunnerMenuForm()
        {
            InitializeComponent();
        }

        private void RunnerMenuForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            contacts_panel.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            contacts_panel.Visible = true; 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TFunction.NextMainForm("Practika.RegisterEventForm", this);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TFunction.NextMainForm("Practika.EditRunnerProfileForm", this);
        }
    }
}
