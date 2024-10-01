using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practika
{
    public partial class MyRaceResultsForm : ParentUserForm
    {
        public MyRaceResultsForm()
        {
            InitializeComponent();
        }

        private void MyRaceResultsForm_Load(object sender, EventArgs e)
        {
            string ConnectionString = Properties.Settings.Default.MarathonSkillsDBConnectionString;
            string SQL = "SELECT Gender, DateOfBirth FROM Runner WHERE Email = '" + AccessControl.sign_in_email + "'";
            string Results = "SELECT CONCAT (Marathon.YearHeld, ' ', Country.CountryName) AS Name, CONCAT ((CASE WHEN EventType.EventTypeId = 'FM' " +
                "THEN '42km' WHEN EventType.EventTypeId = 'HM' THEN '21km' END ) , ' ', EventType.EventTypeName) AS Dist, RegistrationEvent.RaceTime " +
                "AS Time FROM Runner " +
                "JOIN Registration ON Runner.RunnerId = Registration.RunnerId " +
                "JOIN RegistrationEvent ON Registration.RegistrationId = RegistrationEvent.RegistrationId " +
                "JOIN Event ON RegistrationEvent.EventId = Event.EventId " +
                "JOIN EventType ON Event.EventTypeId = EventType.EventTypeId " +
                "JOIN Marathon ON Event.MarathonId = Marathon.MarathonId " +
                "JOIN Country ON Marathon.CountryCode = Country.CountryCode " +
                "WHERE Runner.Email = '" + AccessControl.sign_in_email + "' AND Registration.RegistrationStatusId = 4";


            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(SQL, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if (Convert.ToString(reader[0]) == "Male")
                            gender_box.Text = "мужской";
                        if (Convert.ToString(reader[0]) == "Female")
                            gender_box.Text = "женский";
                        int age = DateTime.Now.Year - Convert.ToDateTime(reader[1]).Year;

                        if (age < 18)
                            age_box.Text = "до 18";
                        else if (age >= 18 && age <= 29)
                            age_box.Text = "18 - 29";
                        else if (age > 29 && age <= 39)
                            age_box.Text = "30 - 39";
                        else if (age > 39 && age <= 55)
                            age_box.Text = "40 - 55";
                        else if (age > 55 && age <= 70)
                            age_box.Text = "56 - 70";
                        else if (age > 70)
                            age_box.Text = "более 70";

                    }

                }
                connection.Close();

                
            }
            InitializeComponent();
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(Results, connection);
                DataTable TableResults = new DataTable();
                adapter.Fill(TableResults);

                for (int i = 0; i < TableResults.Rows.Count; i++)
                {
                    table_results.Rows.Add();
                    table_results.Rows[i].Cells["MarathonName"].Value = TableResults.Rows[i]["Name"].ToString();
                    table_results.Rows[i].Cells["MarathonDist"].Value = TableResults.Rows[i]["Dist"].ToString();
                    table_results.Rows[i].Cells["MarathonTime"].Value = TableResults.Rows[i]["Time"].ToString();

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TFunction.NextMainForm("Practika.RunnerMenuForm", this);
        }
    }
}
