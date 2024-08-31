using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            TFunction.LoadRunners(runner_box);
        }

        private void SponsorForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TFunction.NextMainForm("Practika.MainForm", this);
        }

        private int CheckCount (string count)
        {
            string pattern = @"^[0-9]{0,}$";
            if (count.Length == 0)
                return 0;
            else
                if (Regex.IsMatch(count, pattern) == true)
                    return Convert.ToInt32(count);
            
            return 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string Count = "$";
            Count += Convert.ToString(CheckCount(count_box.Text));
                        
            count_display.Text = Count;
            count_box.Text = Convert.ToString(CheckCount(count_box.Text));
        }

        private void minus_butt_Click(object sender, EventArgs e)
        {
            string Count = "$";
            int count = CheckCount(count_box.Text);
            if (count >= 10)
                count -= 10;
            count_display.Text = Count + Convert.ToString(count);
            count_box.Text = Convert.ToString(count);
        }

        private void plus_butt_Click(object sender, EventArgs e)
        {
            string Count = "$";
            int count = CheckCount(count_box.Text);
            count += 10;
            count_display.Text = Count + Convert.ToString(count);
            count_box.Text = Convert.ToString(count);
        }
    }
}
