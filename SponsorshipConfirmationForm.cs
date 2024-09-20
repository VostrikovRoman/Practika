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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing.Drawing2D;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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
            string SQL = "SELECT Charity.CharityName, " +
                " CONCAT(Users.FirstName, ' ', Users.LastName, ' - ', RegistrationEvent.BibNumber, ' (', Country.CountryName, ')') " +
                " AS Info " +
                " FROM Runner " +
                " JOIN Registration ON Runner.RunnerId = Registration.RunnerId " +
                " JOIN Charity ON Registration.CharityId = Charity.CharityId " +
                " JOIN Country ON Runner.CountryCode = Country.CountryCode" +
                " JOIN RegistrationEvent ON Registration.RegistrationId = RegistrationEvent.RegistrationId" +
                " JOIN Users ON Runner.Email = Users.Email WHERE Runner.RunnerId = " + TFunction.runner_id + "";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(SQL, connection);
                SqlDataReader Reader_fill = command.ExecuteReader();
                string charity_name = "";
                string runner = "";
                if (Reader_fill.HasRows)
                {
                    while (Reader_fill.Read())
                    {
                        charity_name = Convert.ToString(Reader_fill.GetValue(0));
                        runner = Convert.ToString(Reader_fill.GetValue(1));
                    }
                }
                Reader_fill.Close();

                charity_box.Text = charity_name;
                name_box.Text = runner;
                count_box.Text = "$" + TFunction.count_charity;

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
