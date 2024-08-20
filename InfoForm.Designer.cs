namespace Practika
{
    partial class InfoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.charityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marathonSkillsDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marathonSkillsDBDataSet = new Practika.MarathonSkillsDBDataSet();
            this.usersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.genderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.genderTableAdapter = new Practika.MarathonSkillsDBDataSetTableAdapters.GenderTableAdapter();
            this.userTableAdapter = new Practika.MarathonSkillsDBDataSetTableAdapters.UsersTableAdapter();
            this.charityTableAdapter = new Practika.MarathonSkillsDBDataSetTableAdapters.CharityTableAdapter();
            this.topPanel.SuspendLayout();
            this.timerPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.charityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marathonSkillsDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marathonSkillsDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // title_form
            // 
            this.title_form.Size = new System.Drawing.Size(1509, 130);
            this.title_form.Text = "Подробная информация";
            // 
            // timer_stroke
            // 
            this.timer_stroke.Text = "До начала марафона 67 дней 22 часа 9 минут 8 секунд ";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Controls.Add(this.button4);
            this.flowLayoutPanel1.Controls.Add(this.button5);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(218, 220);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 53, 3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1291, 546);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.BackColor = global::Practika.Properties.Settings.Default.Button;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Practika.Properties.Settings.Default, "Button", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(3, 3);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 3, 30, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(516, 108);
            this.button2.TabIndex = 3;
            this.button2.Text = "MarathonSkills 2016";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = global::Practika.Properties.Settings.Default.Button;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Practika.Properties.Settings.Default, "Button", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(552, 3);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 3, 30, 30);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(516, 108);
            this.button3.TabIndex = 4;
            this.button3.Text = "Насколько долгий марафон";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = global::Practika.Properties.Settings.Default.Button;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Practika.Properties.Settings.Default, "Button", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(3, 144);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 3, 30, 30);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(516, 108);
            this.button4.TabIndex = 5;
            this.button4.Text = "Предыдущие результаты";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = global::Practika.Properties.Settings.Default.Button;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Practika.Properties.Settings.Default, "Button", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(552, 144);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 3, 30, 30);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(516, 108);
            this.button5.TabIndex = 6;
            this.button5.Text = "Список благотворительных организаций";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // charityBindingSource
            // 
            this.charityBindingSource.DataMember = "Charity";
            this.charityBindingSource.DataSource = this.marathonSkillsDBDataSetBindingSource;
            // 
            // marathonSkillsDBDataSetBindingSource
            // 
            this.marathonSkillsDBDataSetBindingSource.DataSource = this.marathonSkillsDBDataSet;
            this.marathonSkillsDBDataSetBindingSource.Position = 0;
            // 
            // marathonSkillsDBDataSet
            // 
            this.marathonSkillsDBDataSet.DataSetName = "MarathonSkillsDBDataSet";
            this.marathonSkillsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userBindingSource1
            // 
            this.usersBindingSource1.DataMember = "Users";
            this.usersBindingSource1.DataSource = this.marathonSkillsDBDataSetBindingSource;
            // 
            // genderBindingSource
            // 
            this.genderBindingSource.DataMember = "Gender";
            this.genderBindingSource.DataSource = this.marathonSkillsDBDataSetBindingSource;
            // 
            // userBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.marathonSkillsDBDataSetBindingSource;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 220);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 546);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1309, 220);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 546);
            this.panel2.TabIndex = 9;
            // 
            // genderTableAdapter
            // 
            this.genderTableAdapter.ClearBeforeFill = true;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // charityTableAdapter
            // 
            this.charityTableAdapter.ClearBeforeFill = true;
            // 
            // InfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1509, 820);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "InfoForm";
            this.Text = "Marathon Skills 2016 - Find out more information";
            this.Load += new System.EventHandler(this.InfoForm_Load);
            this.Controls.SetChildIndex(this.timerPanel, 0);
            this.Controls.SetChildIndex(this.topPanel, 0);
            this.Controls.SetChildIndex(this.title_form, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.flowLayoutPanel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.timerPanel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.charityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marathonSkillsDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marathonSkillsDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private System.Windows.Forms.BindingSource marathonSkillsDBDataSetBindingSource;
        private MarathonSkillsDBDataSet marathonSkillsDBDataSet;
        private System.Windows.Forms.BindingSource genderBindingSource;
        private MarathonSkillsDBDataSetTableAdapters.GenderTableAdapter genderTableAdapter;
        private System.Windows.Forms.BindingSource usersBindingSource1;
        private MarathonSkillsDBDataSetTableAdapters.UsersTableAdapter userTableAdapter;
        private System.Windows.Forms.BindingSource charityBindingSource;
        private MarathonSkillsDBDataSetTableAdapters.CharityTableAdapter charityTableAdapter;
    }
}