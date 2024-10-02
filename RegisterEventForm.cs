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
using System.Xml;

namespace Practika
{
    public partial class RegisterEventForm : ParentUserForm
    {
        public RegisterEventForm()
        {
            InitializeComponent();
            timer1.Start();
            radioButton1.Checked = true;
        }

        private int final_cost = 0;

        private void RegisterEventForm_Load(object sender, EventArgs e)
        {
            TFunction.LoadComboBox(charity_box, "Charity", "CharityName", "CharityId");

            string ConnectionString = Properties.Settings.Default.MarathonSkillsDBConnectionString;
            string SQL = "SELECT Cost, COUNT (RaceKitOptionId), RaceKitOptionId FROM RaceKitOption";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(SQL, connection);
                SqlDataReader reader = command.ExecuteReader();

                RadioButton[] array = { radioButton1, radioButton2, radioButton3 };

                if (reader.HasRows)
                {
                    for (int i = 0; i < Convert.ToInt32(reader[1]); i++)
                    {
                        array[i].Text = "Вариант " + Convert.ToString(reader[2]) + " ($" + Convert.ToString(reader[0]) + "):";
                    }
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TFunction.NextMainForm("Practika.RunnerMenuForm", this);
        }

        private void info_button_Click(object sender, EventArgs e)
        {
            TFunction.LoadInfoCharity(info_panel, "Charity.CharityId", Convert.ToString(charity_box.SelectedValue), charity_name, charity_info, charity_logo);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            info_panel.Visible = false;
        }

        private void registr_button_Click(object sender, EventArgs e)
        {
            if (count_box.Text == "0")
            {
                MessageBox.Show("Необходимо ввести сумму взноса", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == false)
            {
                MessageBox.Show("Необходимо выбрать вид марафона", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            TFunction.NextMainForm("Practika.RegistrationConfirmationForm", this);
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            TFunction.NextMainForm("Practika.RunnerMenuForm", this);
        }

        private int RaceKitOption()
        {
            int cost = 0;

            if (radioButton2.Checked)
                cost = 20;
            else if (radioButton3.Checked)
                cost = 45;

            return cost;
        }

        private int TypeMarathon()
        {
            int cost = 0;

            if (checkBox1.Checked)
                cost += 145;
            if (checkBox2.Checked)
                cost += 75;
            if (checkBox3.Checked)
                cost += 20;

            return cost;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count_box.Text = Convert.ToString(TFunction.CheckCount(count_box.Text));
            final_cost = RaceKitOption() + TypeMarathon();
            
            count_display.Text = "$" + Convert.ToString(final_cost);
        }

    }
}
