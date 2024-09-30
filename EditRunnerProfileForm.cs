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
    public partial class EditRunnerProfileForm : ParentUserForm
    {
        public EditRunnerProfileForm()
        {
            InitializeComponent();
        }

        private void EditRunnerProfileForm_Load(object sender, EventArgs e)
        {
            TFunction.LoadComboBox(country_box, "Country", "CountryName", "CountryCode");
            TFunction.LoadComboBox(gender_box, "Gender", "Gender", "Gender");

            email_box.Text = AccessControl.sign_in_email;


            string ConnectionString = Properties.Settings.Default.MarathonSkillsDBConnectionString;
            string SQL = "SELECT Users.FirstName, Users.LastName, Runner.Gender, Runner.DateOfBirth, Runner.CountryCode FROM Users " +
                "JOIN Runner ON Users.Email = Runner.Email WHERE Users.Email = '" + AccessControl.sign_in_email + "'";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(SQL, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        name_box.Text = Convert.ToString(reader.GetValue(0));
                        surname_box.Text = Convert.ToString(reader.GetValue(1));
                        gender_box.SelectedValue = Convert.ToString(reader.GetValue(2));
                        date_box.Value = Convert.ToDateTime(reader.GetValue(3));
                        country_box.SelectedValue = Convert.ToString(reader.GetValue(4));
                    }
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TFunction.NextMainForm("Practika.RunnerMenuForm", this);
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            TFunction.NextMainForm("Practika.RunnerMenuForm", this);
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите изменить данные профиля?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (Control n in this.Controls)
                {
                    if (name_box.Text.Length == 0)
                    {
                        MessageBox.Show("Необходимо заполнить все поля", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (surname_box.Text.Length == 0)
                    {
                        MessageBox.Show("Необходимо заполнить все поля", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (TFunction.CheckEmail(email_box.Text) == 0)
                        return;
                    if (TFunction.CheckAge(date_box.Value.Date) == 0)
                        return;
                    
                    
                    string ConnectionString = Properties.Settings.Default.MarathonSkillsDBConnectionString;
                    string SQL_1 = "UPDATE Users SET Users.FirstName = '" + name_box.Text + "', Users.LastName = '" + surname_box.Text + "' WHERE Email = '" + AccessControl.sign_in_email + "' ";
                    string SQL_2 = "UPDATE Runner SET Runner.Gender = '" + gender_box.SelectedValue + "', Runner.DateOfBirth = '" + date_box.Value + "', Runner.CountryCode = '" + 
                        country_box.SelectedValue + "' WHERE Email = '" + AccessControl.sign_in_email + "' ";
                    string SQL_3 = "UPDATE Users SET Users.FirstName = '" + name_box.Text + "', Users.LastName = '" + surname_box.Text + "', Users.Password = '" + password_box.Text + "' WHERE Email = '" + AccessControl.sign_in_email + "' ";

                    if (password_box.Text.Length != 0 || retry_password_box.Text.Length != 0)
                    {
                        if (TFunction.CheckPassword(password_box.Text, retry_password_box.Text) == 0)
                            return;

                        using (SqlConnection connection = new SqlConnection(ConnectionString))
                        {
                            connection.Open();
                            SqlCommand command = new SqlCommand(SQL_3, connection);
                            command.ExecuteNonQuery();
                            SqlCommand command_2 = new SqlCommand(SQL_2, connection);
                            command_2.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        using (SqlConnection connection = new SqlConnection(ConnectionString))
                        {
                            connection.Open();
                            SqlCommand command = new SqlCommand(SQL_1, connection);
                            command.ExecuteNonQuery();
                            SqlCommand command_2 = new SqlCommand(SQL_2, connection);
                            command_2.ExecuteNonQuery();
                        }
                    }


                }
                AccessControl.GetRights(this);
            }
            else
                return;
        }
    }
}
