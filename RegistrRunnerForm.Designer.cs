namespace Practika
{
    partial class RegistrRunnerForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.email_box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.password_box = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.retry_password_box = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.name_box = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.surname_box = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.gender_box = new System.Windows.Forms.ComboBox();
            this.country_box = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.date_box = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sign_in_button = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
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
            this.title_form.Text = "Регистрация бегуна";
            // 
            // timer_stroke
            // 
            this.timer_stroke.Text = "До начала марафона 20 дней 14 часов 5 минут 10 секунд ";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(350, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(798, 73);
            this.label2.TabIndex = 6;
            this.label2.Text = "Пожалуйста, заполните всю информацию, чтобы зарегистрироваться в качестве бегуна." +
    "";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // email_box
            // 
            this.email_box.BackColor = System.Drawing.Color.White;
            this.email_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.email_box.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.email_box.Location = new System.Drawing.Point(234, 7);
            this.email_box.Margin = new System.Windows.Forms.Padding(3, 7, 20, 20);
            this.email_box.Name = "email_box";
            this.email_box.Size = new System.Drawing.Size(320, 35);
            this.email_box.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 34);
            this.label3.TabIndex = 9;
            this.label3.Text = "Пароль:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // password_box
            // 
            this.password_box.BackColor = System.Drawing.Color.White;
            this.password_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.password_box.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password_box.Location = new System.Drawing.Point(234, 69);
            this.password_box.Margin = new System.Windows.Forms.Padding(3, 7, 20, 20);
            this.password_box.Name = "password_box";
            this.password_box.Size = new System.Drawing.Size(320, 35);
            this.password_box.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(3, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(225, 34);
            this.label5.TabIndex = 13;
            this.label5.Text = "Повторите пароль:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // retry_password_box
            // 
            this.retry_password_box.BackColor = System.Drawing.Color.White;
            this.retry_password_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.retry_password_box.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.retry_password_box.Location = new System.Drawing.Point(234, 131);
            this.retry_password_box.Margin = new System.Windows.Forms.Padding(3, 7, 20, 20);
            this.retry_password_box.Name = "retry_password_box";
            this.retry_password_box.Size = new System.Drawing.Size(320, 35);
            this.retry_password_box.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(3, 186);
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
            this.name_box.Location = new System.Drawing.Point(234, 193);
            this.name_box.Margin = new System.Windows.Forms.Padding(3, 7, 20, 20);
            this.name_box.Name = "name_box";
            this.name_box.Size = new System.Drawing.Size(320, 35);
            this.name_box.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(3, 248);
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
            this.surname_box.Location = new System.Drawing.Point(234, 255);
            this.surname_box.Margin = new System.Windows.Forms.Padding(3, 7, 20, 20);
            this.surname_box.Name = "surname_box";
            this.surname_box.Size = new System.Drawing.Size(320, 35);
            this.surname_box.TabIndex = 16;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.email_box);
            this.flowLayoutPanel1.Controls.Add(this.label8);
            this.flowLayoutPanel1.Controls.Add(this.gender_box);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.password_box);
            this.flowLayoutPanel1.Controls.Add(this.label9);
            this.flowLayoutPanel1.Controls.Add(this.country_box);
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Controls.Add(this.retry_password_box);
            this.flowLayoutPanel1.Controls.Add(this.label10);
            this.flowLayoutPanel1.Controls.Add(this.date_box);
            this.flowLayoutPanel1.Controls.Add(this.label6);
            this.flowLayoutPanel1.Controls.Add(this.name_box);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.label7);
            this.flowLayoutPanel1.Controls.Add(this.surname_box);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(97, 312);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1159, 313);
            this.flowLayoutPanel1.TabIndex = 18;
            // 
            // gender_box
            // 
            this.gender_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gender_box.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gender_box.FormattingEnabled = true;
            this.gender_box.Location = new System.Drawing.Point(808, 3);
            this.gender_box.Name = "gender_box";
            this.gender_box.Size = new System.Drawing.Size(320, 35);
            this.gender_box.TabIndex = 18;
            // 
            // country_box
            // 
            this.country_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.country_box.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.country_box.FormattingEnabled = true;
            this.country_box.Location = new System.Drawing.Point(808, 65);
            this.country_box.Name = "country_box";
            this.country_box.Size = new System.Drawing.Size(320, 35);
            this.country_box.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(577, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(225, 34);
            this.label8.TabIndex = 20;
            this.label8.Text = "Пол:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(577, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(225, 34);
            this.label9.TabIndex = 21;
            this.label9.Text = "Страна:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // date_box
            // 
            this.date_box.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.date_box.Location = new System.Drawing.Point(808, 127);
            this.date_box.Name = "date_box";
            this.date_box.Size = new System.Drawing.Size(320, 35);
            this.date_box.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(577, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(225, 34);
            this.label10.TabIndex = 23;
            this.label10.Text = "Дата рождения:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(577, 189);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(551, 35);
            this.panel1.TabIndex = 24;
            // 
            // sign_in_button
            // 
            this.sign_in_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.sign_in_button.BackColor = global::Practika.Properties.Settings.Default.ButtonExit;
            this.sign_in_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sign_in_button.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Practika.Properties.Settings.Default, "ButtonExit", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.sign_in_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sign_in_button.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sign_in_button.Location = new System.Drawing.Point(519, 660);
            this.sign_in_button.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.sign_in_button.Name = "sign_in_button";
            this.sign_in_button.Size = new System.Drawing.Size(245, 42);
            this.sign_in_button.TabIndex = 19;
            this.sign_in_button.Text = "Зарегистрироваться";
            this.sign_in_button.UseVisualStyleBackColor = false;
            this.sign_in_button.Click += new System.EventHandler(this.sign_in_button_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = global::Practika.Properties.Settings.Default.ButtonExit;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Practika.Properties.Settings.Default, "ButtonExit", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(785, 660);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 42);
            this.button2.TabIndex = 20;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // RegistrRunnerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1509, 820);
            this.Controls.Add(this.sign_in_button);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label2);
            this.Name = "RegistrRunnerForm";
            this.Text = "Marathon Skills 2016 - Registr runner";
            this.Load += new System.EventHandler(this.RegistrRunnerForm_Load);
            this.Controls.SetChildIndex(this.timerPanel, 0);
            this.Controls.SetChildIndex(this.topPanel, 0);
            this.Controls.SetChildIndex(this.title_form, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.flowLayoutPanel1, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.sign_in_button, 0);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.timerPanel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox email_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox password_box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox retry_password_box;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox name_box;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox surname_box;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox gender_box;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox country_box;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker date_box;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button sign_in_button;
        private System.Windows.Forms.Button button2;
    }
}