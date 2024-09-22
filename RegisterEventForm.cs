using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
