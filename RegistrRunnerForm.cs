﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Practika
{
    public partial class RegistrRunnerForm : ParentForm
    {
        public RegistrRunnerForm()
        {
            InitializeComponent();

            TFunction.LoadCountry(country_box);
            TFunction.LoadGender(gender_box);
        }

        private void RegistrRunnerForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TFunction.NextMainForm("Practika.SignInForm", this);
        }

        private void sign_in_button_Click(object sender, EventArgs e)
        {
            foreach (Control n in this.Controls)
            {
                if (n is TextBox)
                    if ((n as TextBox).TextLength == 0)
                    {
                        MessageBox.Show("Необходимо заполнить все поля", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                if (TFunction.CheckEmail(email_box.Text) == 0)
                    return;
                if (TFunction.CheckPassword(password_box.Text, retry_password_box.Text) == 0)
                    return;
                if (TFunction.CheckAge(date_box.Value.Date) == 0)
                    return;

                string ConnectionString = Properties.Settings.Default.MarathonSkillsDBConnectionString;
                string AddUser = "INSERT INTO Users (Email, FirstName, LastName, Password, RoleId) VALUES ('" + email_box.Text + "','" +
                    name_box.Text + "','" + surname_box.Text + "','" + password_box.Text + "', 'R')";
                string AddRunner = "INSERT INTO Runner (Email, Gender, DateOfBirth, CountryCode) VALUES ('" + email_box.Text + "','" +
                    gender_box.SelectedValue + "','" + date_box.Value.Date + "','" + country_box.SelectedValue + "')";

                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(AddUser, connection);
                    command.ExecuteNonQuery();

                    command.CommandText = AddRunner;
                    command.ExecuteNonQuery();

                    if (AccessControl.AutorizationInSystem(email_box.Text, password_box.Text) == 1)
                        AccessControl.GetRights(this);
                }

            }
        }
    }
}
