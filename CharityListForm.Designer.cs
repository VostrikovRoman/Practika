namespace Practika
{
    partial class CharityListForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.real_table_charity = new System.Windows.Forms.DataGridView();
            this.CharityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CharityDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CharityLogo = new System.Windows.Forms.DataGridViewImageColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.topPanel.SuspendLayout();
            this.timerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.real_table_charity)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // title_form
            // 
            this.title_form.Text = "Список благотворительных организаций";
            // 
            // timer_stroke
            // 
            this.timer_stroke.Text = "До начала марафона 346 дней 20 часов 40 минут 31 секунда ";
            // 
            // real_table_charity
            // 
            this.real_table_charity.AllowUserToAddRows = false;
            this.real_table_charity.AllowUserToDeleteRows = false;
            this.real_table_charity.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.real_table_charity.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.real_table_charity.BackgroundColor = global::Practika.Properties.Settings.Default.Button;
            this.real_table_charity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.real_table_charity.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.real_table_charity.ColumnHeadersHeight = 30;
            this.real_table_charity.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CharityName,
            this.CharityDescription,
            this.CharityLogo});
            this.real_table_charity.DataBindings.Add(new System.Windows.Forms.Binding("BackgroundColor", global::Practika.Properties.Settings.Default, "Button", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.real_table_charity.DefaultCellStyle = dataGridViewCellStyle4;
            this.real_table_charity.GridColor = System.Drawing.Color.Gray;
            this.real_table_charity.Location = new System.Drawing.Point(205, 261);
            this.real_table_charity.Name = "real_table_charity";
            this.real_table_charity.ReadOnly = true;
            this.real_table_charity.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.real_table_charity.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.real_table_charity.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.real_table_charity.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.real_table_charity.Size = new System.Drawing.Size(1105, 481);
            this.real_table_charity.TabIndex = 3;
            // 
            // CharityName
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.CharityName.DefaultCellStyle = dataGridViewCellStyle2;
            this.CharityName.HeaderText = "Наименование";
            this.CharityName.Name = "CharityName";
            this.CharityName.ReadOnly = true;
            this.CharityName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // CharityDescription
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CharityDescription.DefaultCellStyle = dataGridViewCellStyle3;
            this.CharityDescription.HeaderText = "Описание";
            this.CharityDescription.Name = "CharityDescription";
            this.CharityDescription.ReadOnly = true;
            // 
            // CharityLogo
            // 
            this.CharityLogo.HeaderText = "Логотип";
            this.CharityLogo.Name = "CharityLogo";
            this.CharityLogo.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(202, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1108, 120);
            this.label2.TabIndex = 4;
            this.label2.Text = "Это - список всех благотворительных учреждений, которые поддерживаются в Marathon" +
    " Skills 2016. Спасибо за помощь, вы поддерживаете их, спонсируя бегунов!";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 204);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 562);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1308, 204);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(201, 562);
            this.panel2.TabIndex = 6;
            // 
            // CharityListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1509, 820);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.real_table_charity);
            this.Controls.Add(this.label2);
            this.Name = "CharityListForm";
            this.Text = "Marathon Skills 2016 - List of charities";
            this.Load += new System.EventHandler(this.CharityListForm_Load);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.timerPanel, 0);
            this.Controls.SetChildIndex(this.topPanel, 0);
            this.Controls.SetChildIndex(this.title_form, 0);
            this.Controls.SetChildIndex(this.real_table_charity, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.timerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.real_table_charity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView real_table_charity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CharityName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CharityDescription;
        private System.Windows.Forms.DataGridViewImageColumn CharityLogo;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}