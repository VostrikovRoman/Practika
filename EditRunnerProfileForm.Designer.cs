namespace Practika
{
    partial class EditRunnerProfileForm
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.email_box = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gender_box = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.name_box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.password_box = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.surname_box = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.country_box = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.retry_password_box = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.date_box = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.save_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.topPanel.SuspendLayout();
            this.timerPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // title_form
            // 
            this.title_form.Text = "Редактирование профиля";
            // 
            // timer_stroke
            // 
            this.timer_stroke.Text = "До начала марафона 355 дней 19 часов 3 минуты 56 секунд ";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.email_box);
            this.flowLayoutPanel1.Controls.Add(this.label11);
            this.flowLayoutPanel1.Controls.Add(this.label6);
            this.flowLayoutPanel1.Controls.Add(this.name_box);
            this.flowLayoutPanel1.Controls.Add(this.label12);
            this.flowLayoutPanel1.Controls.Add(this.label7);
            this.flowLayoutPanel1.Controls.Add(this.surname_box);
            this.flowLayoutPanel1.Controls.Add(this.label8);
            this.flowLayoutPanel1.Controls.Add(this.gender_box);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.password_box);
            this.flowLayoutPanel1.Controls.Add(this.label10);
            this.flowLayoutPanel1.Controls.Add(this.date_box);
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Controls.Add(this.retry_password_box);
            this.flowLayoutPanel1.Controls.Add(this.label9);
            this.flowLayoutPanel1.Controls.Add(this.country_box);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(118, 229);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1226, 347);
            this.flowLayoutPanel1.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 34);
            this.label4.TabIndex = 11;
            this.label4.Text = "Email:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // email_box
            // 
            this.email_box.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Practika.Properties.Settings.Default, "GrayText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.email_box.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.email_box.ForeColor = global::Practika.Properties.Settings.Default.GrayText;
            this.email_box.Location = new System.Drawing.Point(234, 0);
            this.email_box.Margin = new System.Windows.Forms.Padding(3, 0, 300, 20);
            this.email_box.Name = "email_box";
            this.email_box.Size = new System.Drawing.Size(279, 34);
            this.email_box.TabIndex = 25;
            this.email_box.Text = "email";
            this.email_box.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(816, 0);
            this.label11.Margin = new System.Windows.Forms.Padding(3, 0, 100, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(225, 34);
            this.label11.TabIndex = 26;
            this.label11.Text = "Смена пароля";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(3, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(225, 34);
            this.label8.TabIndex = 20;
            this.label8.Text = "Пол:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gender_box
            // 
            this.gender_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gender_box.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gender_box.FormattingEnabled = true;
            this.gender_box.Location = new System.Drawing.Point(234, 173);
            this.gender_box.Margin = new System.Windows.Forms.Padding(3, 3, 100, 3);
            this.gender_box.Name = "gender_box";
            this.gender_box.Size = new System.Drawing.Size(279, 35);
            this.gender_box.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(3, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(225, 34);
            this.label6.TabIndex = 15;
            this.label6.Text = "Имя:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // name_box
            // 
            this.name_box.BackColor = System.Drawing.Color.White;
            this.name_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name_box.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_box.Location = new System.Drawing.Point(234, 57);
            this.name_box.Margin = new System.Windows.Forms.Padding(3, 3, 150, 20);
            this.name_box.Name = "name_box";
            this.name_box.Size = new System.Drawing.Size(279, 35);
            this.name_box.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(616, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 34);
            this.label3.TabIndex = 9;
            this.label3.Text = "Пароль:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // password_box
            // 
            this.password_box.BackColor = System.Drawing.Color.White;
            this.password_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.password_box.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password_box.Location = new System.Drawing.Point(847, 173);
            this.password_box.Margin = new System.Windows.Forms.Padding(3, 3, 20, 20);
            this.password_box.Name = "password_box";
            this.password_box.Size = new System.Drawing.Size(320, 35);
            this.password_box.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(3, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(225, 34);
            this.label7.TabIndex = 17;
            this.label7.Text = "Фамилия:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // surname_box
            // 
            this.surname_box.BackColor = System.Drawing.Color.White;
            this.surname_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.surname_box.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surname_box.Location = new System.Drawing.Point(234, 115);
            this.surname_box.Margin = new System.Windows.Forms.Padding(3, 3, 500, 20);
            this.surname_box.Name = "surname_box";
            this.surname_box.Size = new System.Drawing.Size(279, 35);
            this.surname_box.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(3, 286);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(225, 34);
            this.label9.TabIndex = 21;
            this.label9.Text = "Страна:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // country_box
            // 
            this.country_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.country_box.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.country_box.FormattingEnabled = true;
            this.country_box.Location = new System.Drawing.Point(234, 289);
            this.country_box.Name = "country_box";
            this.country_box.Size = new System.Drawing.Size(279, 35);
            this.country_box.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(616, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(225, 34);
            this.label5.TabIndex = 13;
            this.label5.Text = "Повтор пароля:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // retry_password_box
            // 
            this.retry_password_box.BackColor = System.Drawing.Color.White;
            this.retry_password_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.retry_password_box.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.retry_password_box.Location = new System.Drawing.Point(847, 231);
            this.retry_password_box.Margin = new System.Windows.Forms.Padding(3, 3, 20, 20);
            this.retry_password_box.Name = "retry_password_box";
            this.retry_password_box.Size = new System.Drawing.Size(320, 35);
            this.retry_password_box.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(3, 228);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(225, 34);
            this.label10.TabIndex = 23;
            this.label10.Text = "Дата рождения:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // date_box
            // 
            this.date_box.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.date_box.Location = new System.Drawing.Point(234, 231);
            this.date_box.Margin = new System.Windows.Forms.Padding(3, 3, 100, 3);
            this.date_box.Name = "date_box";
            this.date_box.Size = new System.Drawing.Size(279, 35);
            this.date_box.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Practika.Properties.Settings.Default, "GrayText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label12.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = global::Practika.Properties.Settings.Default.GrayText;
            this.label12.Location = new System.Drawing.Point(666, 54);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(551, 55);
            this.label12.TabIndex = 27;
            this.label12.Text = "Оставьте эти поля, незаполненными, если вы не хотите изменять пароль.";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // save_button
            // 
            this.save_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.save_button.BackColor = global::Practika.Properties.Settings.Default.ButtonExit;
            this.save_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save_button.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Practika.Properties.Settings.Default, "ButtonExit", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.save_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_button.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.save_button.Location = new System.Drawing.Point(534, 638);
            this.save_button.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(193, 42);
            this.save_button.TabIndex = 21;
            this.save_button.Text = "Сохранить";
            this.save_button.UseVisualStyleBackColor = false;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cancel_button.BackColor = global::Practika.Properties.Settings.Default.ButtonExit;
            this.cancel_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel_button.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Practika.Properties.Settings.Default, "ButtonExit", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cancel_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_button.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancel_button.Location = new System.Drawing.Point(760, 638);
            this.cancel_button.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(157, 42);
            this.cancel_button.TabIndex = 22;
            this.cancel_button.Text = "Отмена";
            this.cancel_button.UseVisualStyleBackColor = false;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // EditRunnerProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1509, 820);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "EditRunnerProfileForm";
            this.Text = "Marathon Skills 2016 - Edit runner profile";
            this.Load += new System.EventHandler(this.EditRunnerProfileForm_Load);
            this.Controls.SetChildIndex(this.flowLayoutPanel1, 0);
            this.Controls.SetChildIndex(this.timerPanel, 0);
            this.Controls.SetChildIndex(this.topPanel, 0);
            this.Controls.SetChildIndex(this.title_form, 0);
            this.Controls.SetChildIndex(this.cancel_button, 0);
            this.Controls.SetChildIndex(this.save_button, 0);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.timerPanel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox gender_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox password_box;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox country_box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox retry_password_box;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker date_box;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox name_box;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox surname_box;
        private System.Windows.Forms.Label email_box;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Button cancel_button;
    }
}