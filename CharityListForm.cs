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

namespace Practika
{
    public partial class CharityListForm : ParentForm
    {
        public CharityListForm()
        {
            InitializeComponent();
            string ConnectionString = Properties.Settings.Default.MarathonSkillsDBConnectionString;
            string SQL = "SELECT * FROM Charity";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(SQL, connection);
                DataTable TableCharity = new DataTable();
                adapter.Fill(TableCharity);

                for (int i = 0; i < TableCharity.Rows.Count; i++)
                {
                    real_table_charity.Rows.Add();
                    real_table_charity.Rows[i].Cells["CharityName"].Value = TableCharity.Rows[i]["CharityName"].ToString();
                    real_table_charity.Rows[i].Cells["CharityDescription"].Value = TableCharity.Rows[i]["CharityDescription"].ToString();
                    real_table_charity.Rows[i].Cells["CharityLogo"].Value = Image.FromFile(@"C:\Users\rmnvs\Documents\Институт\2 курс\Практика\Practika\logo_charity\" + TableCharity.Rows[i]["CharityLogo"].ToString());
                }
            }
        }

        private void CharityListForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TFunction.NextMainForm("Practika.InfoForm", this);
        }
    }
}
