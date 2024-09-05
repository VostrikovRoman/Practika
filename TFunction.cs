using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Text.RegularExpressions;

namespace Practika
{
    static class TFunction
    {
        static public void NextMainForm(string TypeNextMainForm, Form CurrentForm)
        {
            Type T = Type.GetType(TypeNextMainForm);
            object MainForm = Activator.CreateInstance(T);

            Program.Context.MainForm = (MainForm as Form);
            (MainForm as Form).Show();
            CurrentForm.Dispose();
        }

        static public void LoadCountry(ComboBox country_box)
        {
            string ConnectionString = Properties.Settings.Default.MarathonSkillsDBConnectionString;
            string SQL = "SELECT * FROM Country";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(SQL, connection);

                DataTable table_country = new DataTable();
                adapter.Fill(table_country);
                country_box.DataSource = table_country;
                country_box.DisplayMember = "CountryName";
                country_box.ValueMember = "CountryCode";

            }
        }

        static public void LoadGender(ComboBox gender_box)
        {
            string ConnectionString = Properties.Settings.Default.MarathonSkillsDBConnectionString;
            string SQL = "SELECT * FROM Gender";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(SQL, connection);

                DataTable table_gender = new DataTable();
                adapter.Fill(table_gender);
                gender_box.DataSource = table_gender;
                gender_box.DisplayMember = "Gender";
                gender_box.ValueMember = "Gender";

            }
        }

        static public void LoadRunners(ComboBox runner_box)
        {
            string ConnectionString = Properties.Settings.Default.MarathonSkillsDBConnectionString;
            string SQL = "SELECT CONCAT(Users.FirstName, ' ', Users.LastName, ' - ', RegistrationEvent.BibNumber, ' (', Country.CountryName, ')') " +
                "AS Info, Runner.RunnerId " +
                "FROM Runner " +
                "JOIN Users ON Runner.Email = Users.Email " +
                "JOIN Country ON Runner.CountryCode = Country.CountryCode " +
                "JOIN Registration ON Runner.RunnerId = Registration.RunnerId " +
                "JOIN RegistrationEvent ON Registration.RegistrationId = RegistrationEvent.RegistrationId";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(SQL, connection);
            
                DataTable table_runner = new DataTable();
                adapter.Fill(table_runner);
                runner_box.DataSource = table_runner;
                runner_box.DisplayMember = "Info";
                runner_box.ValueMember = "RunnerId";
            }
        }

        static public string runner_id;

        static public int CheckEmail(string email_box)
        {
            string ConnectionString = Properties.Settings.Default.MarathonSkillsDBConnectionString;
            string SQL = "SELECT * FROM Users WHERE Email = '" + email_box + "'";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(SQL, connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows == true)
                {
                    MessageBox.Show("Данный адрес электронной почты уже занят", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }
                string pattern = @"^[A-Za-z]+[A-Za-z0-9\-_][A-Za-z0-9]+@[A-Za-z]{2,}\.[A-Za-z]{2,6}$";
                if (Regex.IsMatch(email_box, pattern) == false)
                {
                    MessageBox.Show("Адрес электронной почты указан неверно", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }
                return 1;
            }
        }

        static public int CheckPassword(string password_box, string retry_password_box)
        {
            int numbers_count = 0;
            int upper_letters_count = 0;
            int specific_symbols_count = 0;
            string specific_symbols = "!@#$%^";

            foreach (char c in password_box)
            {
                if (char.IsUpper(c))
                    upper_letters_count++;
                if (char.IsLower(c))
                    numbers_count++;
                for (int i = 0; i < specific_symbols.Length; i++)
                {
                    if (c == specific_symbols[i])
                        specific_symbols_count++;
                }
            }
            if (numbers_count <1 || upper_letters_count <1 || specific_symbols_count <1 || password_box.Length < 6)
            {
                MessageBox.Show("Пароль указан неверно", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            if (password_box != retry_password_box)
            {
                MessageBox.Show("Пароли не совпадают", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            return 1;
        }

        static public int CheckAge (DateTime date_box)
        {
            int diff_age = DateTime.Now.Year - date_box.Year;

            if (DateTime.Now.Month == date_box.Month || DateTime.Now.Day < date_box.Day)
                diff_age--;
            if (diff_age < 10)
            {
                MessageBox.Show("Для регистрации возраст должен составлять более 10 лет", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            return 1;
        }

    }
}
