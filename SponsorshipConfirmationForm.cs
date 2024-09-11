using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Practika
{
    public partial class SponsorshipConfirmationForm : ParentForm
    {
        public SponsorshipConfirmationForm()
        {
            InitializeComponent();
        }

        private void SponsorshipConfirmationForm_Load(object sender, EventArgs e)
        {
            string ConnectionString = Properties.Settings.Default.MarathonSkillsDBConnectionString;
            string SQL = "SELECT Charity.CharityName FROM Runner JOIN Registration ON Runner.RunnerId = Registration.RunnerId JOIN Charity ON Registration.CharityId = Charity.CharityId" +
                " WHERE Runner.RunnerId = " + TFunction.runner_id + "";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(SQL, connection);
                charity_box.Text = Convert.ToString(command.ExecuteScalar());

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TFunction.NextMainForm("Practika.MainForm", this);
        }

        private void minus_butt_Click(object sender, EventArgs e)
        {
            TFunction.NextMainForm("Practika.MainForm", this);
        }
    }
}
