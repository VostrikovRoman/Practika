namespace Practika
{
    partial class RunnerMenuForm
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
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.contacts_panel = new System.Windows.Forms.Panel();
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.charity_name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.topPanel.SuspendLayout();
            this.timerPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.contacts_panel.SuspendLayout();
            this.flowLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Margin = new System.Windows.Forms.Padding(2);
            // 
            // title_form
            // 
            this.title_form.Text = "Меню бегуна";
            // 
            // timer_stroke
            // 
            this.timer_stroke.Size = new System.Drawing.Size(1509, 44);
            this.timer_stroke.Text = "До начала марафона 357 дней 11 часов 12 минут 36 секунд ";
            // 
            // timerPanel
            // 
            this.timerPanel.Location = new System.Drawing.Point(0, 776);
            this.timerPanel.Margin = new System.Windows.Forms.Padding(2);
            this.timerPanel.Size = new System.Drawing.Size(1509, 44);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Controls.Add(this.button4);
            this.flowLayoutPanel1.Controls.Add(this.button5);
            this.flowLayoutPanel1.Controls.Add(this.button6);
            this.flowLayoutPanel1.Controls.Add(this.button7);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(282, 257);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 53, 3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(969, 346);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = global::Practika.Properties.Settings.Default.Button;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Practika.Properties.Settings.Default, "Button", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(3, 3);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 3, 30, 30);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(449, 89);
            this.button3.TabIndex = 3;
            this.button3.Text = "Регистрация на марафон";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackColor = global::Practika.Properties.Settings.Default.Button;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Practika.Properties.Settings.Default, "Button", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(485, 3);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 3, 30, 30);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(449, 89);
            this.button4.TabIndex = 4;
            this.button4.Text = "Мои результаты";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.BackColor = global::Practika.Properties.Settings.Default.Button;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Practika.Properties.Settings.Default, "Button", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(3, 125);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 3, 30, 30);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(449, 89);
            this.button5.TabIndex = 5;
            this.button5.Text = "Редактирование профиля";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.BackColor = global::Practika.Properties.Settings.Default.Button;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Practika.Properties.Settings.Default, "Button", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(485, 125);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 3, 30, 30);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(449, 89);
            this.button6.TabIndex = 6;
            this.button6.Text = "Мой спонсор";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.BackColor = global::Practika.Properties.Settings.Default.Button;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Practika.Properties.Settings.Default, "Button", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(3, 247);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 3, 30, 30);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(449, 89);
            this.button7.TabIndex = 7;
            this.button7.Text = "Контакты";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // contacts_panel
            // 
            this.contacts_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contacts_panel.Controls.Add(this.flowLayoutPanel7);
            this.contacts_panel.Controls.Add(this.pictureBox4);
            this.contacts_panel.Location = new System.Drawing.Point(374, 207);
            this.contacts_panel.Name = "contacts_panel";
            this.contacts_panel.Size = new System.Drawing.Size(754, 433);
            this.contacts_panel.TabIndex = 10;
            this.contacts_panel.Visible = false;
            // 
            // flowLayoutPanel7
            // 
            this.flowLayoutPanel7.Controls.Add(this.label3);
            this.flowLayoutPanel7.Controls.Add(this.charity_name);
            this.flowLayoutPanel7.Controls.Add(this.label2);
            this.flowLayoutPanel7.Controls.Add(this.label4);
            this.flowLayoutPanel7.Controls.Add(this.label5);
            this.flowLayoutPanel7.Controls.Add(this.label6);
            this.flowLayoutPanel7.Controls.Add(this.label7);
            this.flowLayoutPanel7.Location = new System.Drawing.Point(34, 39);
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            this.flowLayoutPanel7.Size = new System.Drawing.Size(687, 383);
            this.flowLayoutPanel7.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(689, 44);
            this.label3.TabIndex = 13;
            this.label3.Text = "Контакты";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // charity_name
            // 
            this.charity_name.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.charity_name.Location = new System.Drawing.Point(3, 44);
            this.charity_name.Name = "charity_name";
            this.charity_name.Size = new System.Drawing.Size(689, 44);
            this.charity_name.TabIndex = 11;
            this.charity_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(684, 76);
            this.label2.TabIndex = 12;
            this.label2.Text = "Для получения дополнительной информаци, пожалуйста, свяжитесь с координаторами";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(3, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 69);
            this.label4.TabIndex = 14;
            this.label4.Text = "Телефон:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(128, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(544, 69);
            this.label5.TabIndex = 15;
            this.label5.Text = "+55 11 9988 77 66";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(3, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 69);
            this.label6.TabIndex = 16;
            this.label6.Text = "Email:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(84, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(544, 69);
            this.label7.TabIndex = 17;
            this.label7.Text = "coordinators@marathonskills.org";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = global::Practika.Properties.Resources.delete;
            this.pictureBox4.Location = new System.Drawing.Point(710, 8);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 27;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // RunnerMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1509, 820);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.contacts_panel);
            this.Name = "RunnerMenuForm";
            this.Text = "Marathon Skills 2016 - Runner menu";
            this.Load += new System.EventHandler(this.RunnerMenuForm_Load);
            this.Controls.SetChildIndex(this.contacts_panel, 0);
            this.Controls.SetChildIndex(this.flowLayoutPanel1, 0);
            this.Controls.SetChildIndex(this.timerPanel, 0);
            this.Controls.SetChildIndex(this.topPanel, 0);
            this.Controls.SetChildIndex(this.title_form, 0);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.timerPanel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.contacts_panel.ResumeLayout(false);
            this.flowLayoutPanel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel contacts_panel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel7;
        private System.Windows.Forms.Label charity_name;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}