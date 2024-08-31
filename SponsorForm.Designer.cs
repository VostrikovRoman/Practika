namespace Practika
{
    partial class SponsorForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.name_box = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.runner_box = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.card_box = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.count_display = new System.Windows.Forms.Label();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.minus_butt = new System.Windows.Forms.Button();
            this.count_box = new System.Windows.Forms.TextBox();
            this.plus_butt = new System.Windows.Forms.Button();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pay_butt = new System.Windows.Forms.Button();
            this.cancel_butt = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.code_box = new System.Windows.Forms.MaskedTextBox();
            this.month_box = new System.Windows.Forms.MaskedTextBox();
            this.year_box = new System.Windows.Forms.MaskedTextBox();
            this.cvc_box = new System.Windows.Forms.MaskedTextBox();
            this.topPanel.SuspendLayout();
            this.timerPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // title_form
            // 
            this.title_form.Text = "Спонсор бегуна";
            // 
            // timer_stroke
            // 
            this.timer_stroke.Text = "До начала марафона 13 дней 2 часа 12 минут 15 секунд ";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(246, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1033, 96);
            this.label2.TabIndex = 7;
            this.label2.Text = "Пожалуйста, выберите бегуна, которого вы хотели бы спонсировать и сумму, которую " +
    "вы хотели бы спонсировать. Спасибо за вашу поддержку бегунов и их благотворитель" +
    "ных учреждений.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(24, 280);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1452, 467);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label3);
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel4);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 3, 100, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(654, 464);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(651, 57);
            this.label3.TabIndex = 9;
            this.label3.Text = "Информация о Спонсоре";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.label5);
            this.flowLayoutPanel4.Controls.Add(this.name_box);
            this.flowLayoutPanel4.Controls.Add(this.label6);
            this.flowLayoutPanel4.Controls.Add(this.runner_box);
            this.flowLayoutPanel4.Controls.Add(this.label7);
            this.flowLayoutPanel4.Controls.Add(this.card_box);
            this.flowLayoutPanel4.Controls.Add(this.label11);
            this.flowLayoutPanel4.Controls.Add(this.code_box);
            this.flowLayoutPanel4.Controls.Add(this.label12);
            this.flowLayoutPanel4.Controls.Add(this.month_box);
            this.flowLayoutPanel4.Controls.Add(this.year_box);
            this.flowLayoutPanel4.Controls.Add(this.label8);
            this.flowLayoutPanel4.Controls.Add(this.cvc_box);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 77);
            this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(651, 394);
            this.flowLayoutPanel4.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(225, 34);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ваше имя:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // name_box
            // 
            this.name_box.BackColor = System.Drawing.Color.White;
            this.name_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name_box.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_box.Location = new System.Drawing.Point(234, 3);
            this.name_box.Margin = new System.Windows.Forms.Padding(3, 3, 20, 20);
            this.name_box.Name = "name_box";
            this.name_box.Size = new System.Drawing.Size(392, 35);
            this.name_box.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(3, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(225, 34);
            this.label6.TabIndex = 9;
            this.label6.Text = "Бегун:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // runner_box
            // 
            this.runner_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.runner_box.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.runner_box.FormattingEnabled = true;
            this.runner_box.Location = new System.Drawing.Point(234, 61);
            this.runner_box.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.runner_box.Name = "runner_box";
            this.runner_box.Size = new System.Drawing.Size(392, 35);
            this.runner_box.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(3, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(225, 34);
            this.label7.TabIndex = 13;
            this.label7.Text = "Владелец карты:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // card_box
            // 
            this.card_box.BackColor = System.Drawing.Color.White;
            this.card_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.card_box.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.card_box.Location = new System.Drawing.Point(234, 119);
            this.card_box.Margin = new System.Windows.Forms.Padding(3, 3, 20, 20);
            this.card_box.Name = "card_box";
            this.card_box.Size = new System.Drawing.Size(392, 35);
            this.card_box.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(3, 174);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(225, 34);
            this.label11.TabIndex = 15;
            this.label11.Text = "Номер  карты:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(3, 235);
            this.label12.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(225, 34);
            this.label12.TabIndex = 17;
            this.label12.Text = "Срок действия:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(3, 293);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(225, 34);
            this.label8.TabIndex = 19;
            this.label8.Text = "CVC:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.label4);
            this.flowLayoutPanel3.Controls.Add(this.label9);
            this.flowLayoutPanel3.Controls.Add(this.label10);
            this.flowLayoutPanel3.Controls.Add(this.count_display);
            this.flowLayoutPanel3.Controls.Add(this.flowLayoutPanel5);
            this.flowLayoutPanel3.Controls.Add(this.flowLayoutPanel6);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(760, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(654, 464);
            this.flowLayoutPanel3.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(651, 57);
            this.label4.TabIndex = 10;
            this.label4.Text = "Благотворительность";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(3, 57);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 0, 3, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(651, 35);
            this.label9.TabIndex = 11;
            this.label9.Text = "Фонд кошек";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(3, 122);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(651, 49);
            this.label10.TabIndex = 12;
            this.label10.Text = "Сумма пожертвования";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // count_display
            // 
            this.count_display.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Practika.Properties.Settings.Default, "HeaderPanelBackground", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.count_display.Font = new System.Drawing.Font("Arial", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.count_display.ForeColor = global::Practika.Properties.Settings.Default.HeaderPanelBackground;
            this.count_display.Location = new System.Drawing.Point(3, 181);
            this.count_display.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.count_display.Name = "count_display";
            this.count_display.Size = new System.Drawing.Size(651, 74);
            this.count_display.TabIndex = 13;
            this.count_display.Text = "$0";
            this.count_display.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Controls.Add(this.panel1);
            this.flowLayoutPanel5.Controls.Add(this.minus_butt);
            this.flowLayoutPanel5.Controls.Add(this.count_box);
            this.flowLayoutPanel5.Controls.Add(this.plus_butt);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(3, 265);
            this.flowLayoutPanel5.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(651, 48);
            this.flowLayoutPanel5.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 45);
            this.panel1.TabIndex = 24;
            // 
            // minus_butt
            // 
            this.minus_butt.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minus_butt.Location = new System.Drawing.Point(209, 3);
            this.minus_butt.Name = "minus_butt";
            this.minus_butt.Size = new System.Drawing.Size(51, 35);
            this.minus_butt.TabIndex = 22;
            this.minus_butt.Text = "-";
            this.minus_butt.UseVisualStyleBackColor = true;
            this.minus_butt.Click += new System.EventHandler(this.minus_butt_Click);
            // 
            // count_box
            // 
            this.count_box.BackColor = System.Drawing.Color.White;
            this.count_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.count_box.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.count_box.Location = new System.Drawing.Point(266, 3);
            this.count_box.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.count_box.Name = "count_box";
            this.count_box.Size = new System.Drawing.Size(122, 35);
            this.count_box.TabIndex = 22;
            this.count_box.Text = "0";
            this.count_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // plus_butt
            // 
            this.plus_butt.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plus_butt.Location = new System.Drawing.Point(394, 3);
            this.plus_butt.Name = "plus_butt";
            this.plus_butt.Size = new System.Drawing.Size(51, 35);
            this.plus_butt.TabIndex = 23;
            this.plus_butt.Text = "+";
            this.plus_butt.UseVisualStyleBackColor = true;
            this.plus_butt.Click += new System.EventHandler(this.plus_butt_Click);
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.Controls.Add(this.panel2);
            this.flowLayoutPanel6.Controls.Add(this.pay_butt);
            this.flowLayoutPanel6.Controls.Add(this.cancel_butt);
            this.flowLayoutPanel6.Location = new System.Drawing.Point(3, 391);
            this.flowLayoutPanel6.Margin = new System.Windows.Forms.Padding(3, 75, 3, 3);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(651, 48);
            this.flowLayoutPanel6.TabIndex = 25;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(167, 45);
            this.panel2.TabIndex = 24;
            // 
            // pay_butt
            // 
            this.pay_butt.BackColor = global::Practika.Properties.Settings.Default.ButtonExit;
            this.pay_butt.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Practika.Properties.Settings.Default, "ButtonExit", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.pay_butt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pay_butt.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pay_butt.Location = new System.Drawing.Point(176, 3);
            this.pay_butt.Name = "pay_butt";
            this.pay_butt.Size = new System.Drawing.Size(144, 35);
            this.pay_butt.TabIndex = 22;
            this.pay_butt.Text = "Заплатить";
            this.pay_butt.UseVisualStyleBackColor = false;
            this.pay_butt.Click += new System.EventHandler(this.pay_butt_Click);
            // 
            // cancel_butt
            // 
            this.cancel_butt.BackColor = global::Practika.Properties.Settings.Default.ButtonExit;
            this.cancel_butt.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Practika.Properties.Settings.Default, "ButtonExit", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cancel_butt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_butt.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancel_butt.Location = new System.Drawing.Point(326, 3);
            this.cancel_butt.Name = "cancel_butt";
            this.cancel_butt.Size = new System.Drawing.Size(144, 35);
            this.cancel_butt.TabIndex = 23;
            this.cancel_butt.Text = "Отмена";
            this.cancel_butt.UseVisualStyleBackColor = false;
            this.cancel_butt.Click += new System.EventHandler(this.cancel_butt_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // code_box
            // 
            this.code_box.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.code_box.Location = new System.Drawing.Point(234, 177);
            this.code_box.Mask = "0000 0000 0000 0000";
            this.code_box.Name = "code_box";
            this.code_box.PromptChar = ' ';
            this.code_box.Size = new System.Drawing.Size(392, 35);
            this.code_box.TabIndex = 22;
            // 
            // month_box
            // 
            this.month_box.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.month_box.Location = new System.Drawing.Point(234, 235);
            this.month_box.Margin = new System.Windows.Forms.Padding(3, 20, 15, 3);
            this.month_box.Mask = "00";
            this.month_box.Name = "month_box";
            this.month_box.PromptChar = ' ';
            this.month_box.Size = new System.Drawing.Size(50, 35);
            this.month_box.TabIndex = 23;
            this.month_box.ValidatingType = typeof(System.DateTime);
            // 
            // year_box
            // 
            this.year_box.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.year_box.Location = new System.Drawing.Point(302, 235);
            this.year_box.Margin = new System.Windows.Forms.Padding(3, 20, 15, 3);
            this.year_box.Mask = "0000";
            this.year_box.Name = "year_box";
            this.year_box.PromptChar = ' ';
            this.year_box.Size = new System.Drawing.Size(133, 35);
            this.year_box.TabIndex = 24;
            this.year_box.ValidatingType = typeof(System.DateTime);
            // 
            // cvc_box
            // 
            this.cvc_box.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cvc_box.Location = new System.Drawing.Point(234, 293);
            this.cvc_box.Margin = new System.Windows.Forms.Padding(3, 20, 15, 3);
            this.cvc_box.Mask = "000";
            this.cvc_box.Name = "cvc_box";
            this.cvc_box.PromptChar = ' ';
            this.cvc_box.Size = new System.Drawing.Size(74, 35);
            this.cvc_box.TabIndex = 25;
            this.cvc_box.ValidatingType = typeof(System.DateTime);
            // 
            // SponsorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1509, 820);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label2);
            this.Name = "SponsorForm";
            this.Text = "Marathon Skills 2016 - Sponsor a runner";
            this.Load += new System.EventHandler(this.SponsorForm_Load);
            this.Controls.SetChildIndex(this.timerPanel, 0);
            this.Controls.SetChildIndex(this.topPanel, 0);
            this.Controls.SetChildIndex(this.title_form, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.flowLayoutPanel1, 0);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.timerPanel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.flowLayoutPanel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox name_box;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox card_box;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox runner_box;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label count_display;
        private System.Windows.Forms.Button minus_butt;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button plus_butt;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button pay_butt;
        private System.Windows.Forms.Button cancel_butt;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox count_box;
        private System.Windows.Forms.MaskedTextBox code_box;
        private System.Windows.Forms.MaskedTextBox month_box;
        private System.Windows.Forms.MaskedTextBox year_box;
        private System.Windows.Forms.MaskedTextBox cvc_box;
    }
}