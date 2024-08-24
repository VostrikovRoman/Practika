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
    public partial class InfoForm : ParentForm
    {
        public InfoForm()
        {
            InitializeComponent();
        }

        private void InfoForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "marathonSkillsDBDataSet.Charity". При необходимости она может быть перемещена или удалена.
            this.charityTableAdapter.Fill(this.marathonSkillsDBDataSet.Charity);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "marathonSkillsDBDataSet.User". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.marathonSkillsDBDataSet.Users);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "marathonSkillsDBDataSet.Gender". При необходимости она может быть перемещена или удалена.
            this.genderTableAdapter.Fill(this.marathonSkillsDBDataSet.Gender);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TFunction.NextMainForm("Practika.MainForm", this);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TFunction.NextMainForm("Practika.CharityListForm", this);
        }
    }
}
