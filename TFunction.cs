using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Text.RegularExpressions;
using System.Drawing;

namespace Practika
{
    static class TFunction
    {
        //Переход между формами
        static public void NextMainForm(string TypeNextMainForm, Form CurrentForm)
        {
            Type T = Type.GetType(TypeNextMainForm);
            object MainForm = Activator.CreateInstance(T);

            Program.Context.MainForm = (MainForm as Form);
            (MainForm as Form).Show();
            CurrentForm.Dispose();
        }

        //Выгрузка списка в comboBox
        static public void LoadComboBox(ComboBox box, string name_table, string display_member, string value_member)
        {
            string ConnectionString = Properties.Settings.Default.MarathonSkillsDBConnectionString;
            string SQL = "SELECT * FROM " + name_table;
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(SQL, connection);

                DataTable table = new DataTable();
                adapter.Fill(table);
                box.DataSource = table;
                box.DisplayMember = display_member;
                box.ValueMember = value_member;

            }
        }

        //Выгрузка информации о зарегистрированных бегунах (имя, фамилия, номер, страна)
        static public void LoadRunners(ComboBox runner_box)
        {
            string ConnectionString = Properties.Settings.Default.MarathonSkillsDBConnectionString;
            string SQL = "SELECT CONCAT(Users.FirstName, ' ', Users.LastName, ' - ', RegistrationEvent.BibNumber, ' (', Country.CountryName, ')') " +
                "AS Info, Runner.RunnerId " +
                "FROM Runner " +
                "JOIN Users ON Runner.Email = Users.Email " +
                "JOIN Country ON Runner.CountryCode = Country.CountryCode " +
                "JOIN Registration ON Runner.RunnerId = Registration.RunnerId " +
                "JOIN RegistrationEvent ON Registration.RegistrationId = RegistrationEvent.RegistrationId WHERE Runner.CountryCode = 'RUS'";
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

        static public int runner_id;
        static public string count_charity;

        //Валидация почты
        static public int CheckEmail(string email_box)
        {
            string pattern = @"^[A-Za-z]+[A-Za-z0-9\-_][A-Za-z0-9]+@[A-Za-z]{2,}\.[A-Za-z]{2,6}$";
            if (Regex.IsMatch(email_box, pattern) == false)
            {
                MessageBox.Show("Адрес электронной почты указан неверно", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            return 1;
        }

        //Проверка существования email
        static public int CheckBeEmail (string email_box)
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
                return 1;
            }
        }

        //Валидация пароля
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

        //Валидация возраста
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

        //Валидация суммы взноса
        static public int CheckCount(string count)
        {
            string pattern = @"^[0-9]{0,}$";
            if (count.Length == 0)
                return 0;
            else
                if (Regex.IsMatch(count, pattern) == true)
                return Convert.ToInt32(count);

            return 0;
        }

        //Выгрузка информации о благотворительной организации на всплывающее меню
        static public void LoadInfoCharity(Panel panel, string rules, string parameter, Label charity_name, Label charity_info, PictureBox charity_logo)
        {
            panel.Visible = true;
            string ConnectionString = Properties.Settings.Default.MarathonSkillsDBConnectionString;
            string SQL = "SELECT Charity.CharityName, Charity.CharityDescription, Charity.CharityLogo FROM Runner JOIN Registration ON Runner.RunnerId = Registration.RunnerId JOIN Charity ON Registration.CharityId = Charity.CharityId" +
                " WHERE " + rules + " = '" + parameter + "'";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(SQL, connection);
                SqlDataReader Reader_fill = command.ExecuteReader();
                if (Reader_fill.HasRows)
                {
                    while (Reader_fill.Read())
                    {
                        charity_name.Text = Convert.ToString(Reader_fill.GetValue(0));
                        charity_info.Text = Convert.ToString(Reader_fill.GetValue(1));
                        charity_logo.Image = Image.FromFile(@"C:\Users\rmnvs\Documents\Институт\2 курс\Практика\Practika\logo_charity\" + Convert.ToString(Reader_fill.GetValue(2)));
                    }
                }
                Reader_fill.Close();

            }
        }
    }
}
