namespace Practika
{
    partial class MyRaceResultsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.gender_box = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.age_box = new System.Windows.Forms.Label();
            this.sign_in_button = new System.Windows.Forms.Button();
            this.table_results = new System.Windows.Forms.DataGridView();
            this.MarathonName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MarathonDist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MarathonTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MarathonOverallPlace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MarathonPlaceByCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.topPanel.SuspendLayout();
            this.timerPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_results)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Margin = new System.Windows.Forms.Padding(2);
            // 
            // button1
            // 
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // title_form
            // 
            this.title_form.Size = new System.Drawing.Size(1509, 80);
            this.title_form.Text = "Мои результаты";
            // 
            // timer_stroke
            // 
            this.timer_stroke.Size = new System.Drawing.Size(1509, 44);
            this.timer_stroke.Text = "До начала марафона 346 дней 20 часов 28 минут 59 секунд ";
            // 
            // timerPanel
            // 
            this.timerPanel.Location = new System.Drawing.Point(0, 776);
            this.timerPanel.Margin = new System.Windows.Forms.Padding(2);
            this.timerPanel.Size = new System.Drawing.Size(1509, 44);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(363, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(798, 73);
            this.label2.TabIndex = 7;
            this.label2.Text = "Это - список всех ваших прошлых результатов гонки для Marathon Skills. Общее мест" +
    "о сравнивает всех бегунов. ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(363, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(798, 32);
            this.label3.TabIndex = 8;
            this.label3.Text = "Место по категории сравнивает бегунов одного пола и возраста.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 32);
            this.label4.TabIndex = 9;
            this.label4.Text = "Пол: ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.gender_box);
            this.flowLayoutPanel1.Controls.Add(this.label6);
            this.flowLayoutPanel1.Controls.Add(this.age_box);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(477, 297);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(777, 51);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // gender_box
            // 
            this.gender_box.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gender_box.Location = new System.Drawing.Point(74, 0);
            this.gender_box.Name = "gender_box";
            this.gender_box.Size = new System.Drawing.Size(121, 32);
            this.gender_box.TabIndex = 10;
            this.gender_box.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(201, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(258, 32);
            this.label6.TabIndex = 11;
            this.label6.Text = "Возрастная категория:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // age_box
            // 
            this.age_box.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.age_box.Location = new System.Drawing.Point(465, 0);
            this.age_box.Name = "age_box";
            this.age_box.Size = new System.Drawing.Size(249, 32);
            this.age_box.TabIndex = 12;
            this.age_box.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sign_in_button
            // 
            this.sign_in_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.sign_in_button.BackColor = global::Practika.Properties.Settings.Default.ButtonExit;
            this.sign_in_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sign_in_button.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Practika.Properties.Settings.Default, "ButtonExit", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.sign_in_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sign_in_button.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sign_in_button.Location = new System.Drawing.Point(403, 707);
            this.sign_in_button.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.sign_in_button.Name = "sign_in_button";
            this.sign_in_button.Size = new System.Drawing.Size(708, 48);
            this.sign_in_button.TabIndex = 20;
            this.sign_in_button.Text = "Показать все результаты";
            this.sign_in_button.UseVisualStyleBackColor = false;
            // 
            // table_results
            // 
            this.table_results.AllowUserToAddRows = false;
            this.table_results.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.table_results.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.table_results.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.table_results.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.table_results.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.table_results.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.table_results.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.table_results.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.table_results.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.table_results.ColumnHeadersHeight = 30;
            this.table_results.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MarathonName,
            this.MarathonDist,
            this.MarathonTime,
            this.MarathonOverallPlace,
            this.MarathonPlaceByCategory});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 14F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.table_results.DefaultCellStyle = dataGridViewCellStyle5;
            this.table_results.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.table_results.Location = new System.Drawing.Point(24, 382);
            this.table_results.Name = "table_results";
            this.table_results.ReadOnly = true;
            this.table_results.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 14.25F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.table_results.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.table_results.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 14.25F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.table_results.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.table_results.Size = new System.Drawing.Size(1461, 283);
            this.table_results.TabIndex = 21;
            // 
            // MarathonName
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.MarathonName.DefaultCellStyle = dataGridViewCellStyle3;
            this.MarathonName.HeaderText = "Марафон";
            this.MarathonName.MinimumWidth = 6;
            this.MarathonName.Name = "MarathonName";
            this.MarathonName.ReadOnly = true;
            this.MarathonName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // MarathonDist
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MarathonDist.DefaultCellStyle = dataGridViewCellStyle4;
            this.MarathonDist.HeaderText = "Дистанция";
            this.MarathonDist.MinimumWidth = 6;
            this.MarathonDist.Name = "MarathonDist";
            this.MarathonDist.ReadOnly = true;
            // 
            // MarathonTime
            // 
            this.MarathonTime.HeaderText = "Время";
            this.MarathonTime.MinimumWidth = 6;
            this.MarathonTime.Name = "MarathonTime";
            this.MarathonTime.ReadOnly = true;
            // 
            // MarathonOverallPlace
            // 
            this.MarathonOverallPlace.HeaderText = "Общее место";
            this.MarathonOverallPlace.MinimumWidth = 6;
            this.MarathonOverallPlace.Name = "MarathonOverallPlace";
            this.MarathonOverallPlace.ReadOnly = true;
            // 
            // MarathonPlaceByCategory
            // 
            this.MarathonPlaceByCategory.HeaderText = "Место по категории";
            this.MarathonPlaceByCategory.MinimumWidth = 6;
            this.MarathonPlaceByCategory.Name = "MarathonPlaceByCategory";
            this.MarathonPlaceByCategory.ReadOnly = true;
            // 
            // MyRaceResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1509, 820);
            this.Controls.Add(this.table_results);
            this.Controls.Add(this.sign_in_button);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "MyRaceResultsForm";
            this.Text = "Marathon Skills 2016 - My race results";
            this.Load += new System.EventHandler(this.MyRaceResultsForm_Load);
            this.Controls.SetChildIndex(this.timerPanel, 0);
            this.Controls.SetChildIndex(this.topPanel, 0);
            this.Controls.SetChildIndex(this.title_form, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.flowLayoutPanel1, 0);
            this.Controls.SetChildIndex(this.sign_in_button, 0);
            this.Controls.SetChildIndex(this.table_results, 0);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.timerPanel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.table_results)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label gender_box;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label age_box;
        private System.Windows.Forms.Button sign_in_button;
        private System.Windows.Forms.DataGridView table_results;
        private System.Windows.Forms.DataGridViewTextBoxColumn MarathonName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MarathonDist;
        private System.Windows.Forms.DataGridViewTextBoxColumn MarathonTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn MarathonOverallPlace;
        private System.Windows.Forms.DataGridViewTextBoxColumn MarathonPlaceByCategory;
    }
}