using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practika
{
    static class AccessControl
    {
        static public Runner MainUser = null;
        static public bool StatusAutorization = false;

        static public int AutorizationInSystem (string Email, string Password)
        {
            string RoleUser = "";
            string ConnectionString = Properties.Settings.Default.MarathonSkillsDBConnectionString;
            string SQL = "SELECT * FROM Users WHERE Email = '" + Email + "' AND Password = '" + Password + "'";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(SQL, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows == true)
                {
                    AccessControl.StatusAutorization = true;
                    while (reader.Read())
                    {
                        RoleUser = reader.GetValue(reader.GetOrdinal("RoleId")).ToString();
                    }
                    if (RoleUser == "R")
                        MainUser = new Runner(Email);
                    else
                        if (RoleUser == "C")
                        MainUser = new Coordinator(Email);
                    else
                            if (RoleUser == "A")
                        MainUser = new Administrator(Email);
                    return 1;
                }
                else
                    return 0;
            }
        }

        static public void GetRights (Form CurrentForm)
        {
            if (StatusAutorization == false)
                TFunction.NextMainForm("Practika.SignInForm", CurrentForm);
            else
                if (MainUser.Role == "R")
                    TFunction.NextMainForm("Practika.RunnerMenuForm", CurrentForm);
                else
                    if (MainUser.Role == "C")
                        TFunction.NextMainForm("Practika.CoordinatorMenuForm", CurrentForm);
                    else
                        if (MainUser.Role == "A")
                            TFunction.NextMainForm("Practika.AdministratorMenuForm", CurrentForm);

        }

        static public void CloseAccess (Form CurrentForm)
        {
            StatusAutorization = false;
            MainUser = null;
            GetRights(CurrentForm);
        }
    }
    class Runner
    {
        public string FirstName;
        public string LastName;
        public string Role;
        public string Email;

        public Runner (string Email)
        {
            GetData(Email);
        }
        public void GetData(string Email)
        {
            string ConnectionString = Properties.Settings.Default.MarathonSkillsDBConnectionString;
            string SQL = "SELECT * FROM Users WHERE Email = '" + Email + "'";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(SQL, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    this.FirstName = reader.GetValue(reader.GetOrdinal("FirstName")).ToString();
                    this.LastName = reader.GetValue(reader.GetOrdinal("LastName")).ToString();
                    this.Role = reader.GetValue(reader.GetOrdinal("RoleId")).ToString();
                    this.Email = Email;
                }
            }
        }
    }
    class Coordinator : Runner
    {
        string EmailCurrentRunner;
        string CodeCurrentRunner;

        public Coordinator(string Email) : base(Email)
        {

        }
        public string EmailRunner
        {
            get
            {
                return EmailCurrentRunner;
            }
            set
            {
                EmailCurrentRunner = value;
                string ConnectionString = Properties.Settings.Default.MarathonSkillsDBConnectionString;
                string SQL = "SELECT RunnerId FROM Runner WHERE Email = '" + value + "'";
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(SQL, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        CodeCurrentRunner = reader.GetValue(reader.GetOrdinal("RunnerId")).ToString();
                    }
                }
            }
        }

        public string CodeRunner
        {
            get
            {
                return CodeCurrentRunner;
            }
        }
    }
    class Administrator : Runner
    {
        public string EmailCurrentUser;
        public Administrator(string Email) : base(Email)
        {

        }
    }
}
