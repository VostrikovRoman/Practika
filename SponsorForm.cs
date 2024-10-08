﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Practika
{
    public partial class SponsorForm : ParentForm
    {
        public SponsorForm()
        {
            InitializeComponent();
            timer1.Start();
            
        }

        private void SponsorForm_Load(object sender, EventArgs e)
        {
            TFunction.LoadRunners(runner_box);
            TFunction.runner_id = Convert.ToInt32(runner_box.SelectedValue);
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


        private void timer1_Tick(object sender, EventArgs e)
        {
            string Count = "$";
            Count += Convert.ToString(TFunction.CheckCount(count_box.Text));
                        
            count_display.Text = Count;
            count_box.Text = Convert.ToString(TFunction.CheckCount(count_box.Text));
        }

        private void minus_butt_Click(object sender, EventArgs e)
        {
            string Count = "$";
            int count = TFunction.CheckCount(count_box.Text);
            if (count >= 10)
                count -= 10;
            count_display.Text = Count + Convert.ToString(count);
            count_box.Text = Convert.ToString(count);
        }

        private void plus_butt_Click(object sender, EventArgs e)
        {
            string Count = "$";
            int count = TFunction.CheckCount(count_box.Text);
            count += 10;
            count_display.Text = Count + Convert.ToString(count);
            count_box.Text = Convert.ToString(count);
        }

        private void cancel_butt_Click(object sender, EventArgs e)
        {
            TFunction.NextMainForm("Practika.MainForm", this);
        }


        private void pay_butt_Click(object sender, EventArgs e)
        {
            if (name_box.Text.Length == 0)
            {
                MessageBox.Show("Необходимо заполнить все поля", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (card_box.Text.Length == 0)
            {
                MessageBox.Show("Необходимо заполнить все поля", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (code_box.Text.Length < 19)
            {
                MessageBox.Show("Номер карты указан неверно", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (month_box.Text.Length < 2)
            {
                MessageBox.Show("Срок действия карты указан неверно", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (Convert.ToInt32(month_box.Text) > 12 || Convert.ToInt32(month_box.Text) == 0)
                {
                    MessageBox.Show("Срок действия карты указан неверно", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (year_box.Text.Length < 4)
            {
                MessageBox.Show("Срок действия карты указан неверно", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cvc_box.Text.Length < 3)
            {
                MessageBox.Show("CVC указан неверно", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            TFunction.count_charity = count_box.Text;
            TFunction.NextMainForm("Practika.SponsorshipConfirmationForm", this);
        }

        private void runner_box_SelectionChangeCommitted(object sender, EventArgs e)
        {
            TFunction.runner_id = Convert.ToInt32(runner_box.SelectedValue);
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            TFunction.LoadInfoCharity(info_panel, "Runner.RunnerId", Convert.ToString(TFunction.runner_id), charity_name, charity_info, charity_logo);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            info_panel.Visible = false;
        }
    }
}
