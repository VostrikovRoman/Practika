namespace Practika
{
    partial class SponsorshipConfirmationForm
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.minus_butt = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.topPanel.SuspendLayout();
            this.timerPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // title_form
            // 
            this.title_form.Text = "Спасибо за вашу спонсорскую поддержку!";
            // 
            // timer_stroke
            // 
            this.timer_stroke.Text = "До начала марафона 9 дней 23 часа 21 минута 35 секунд ";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(281, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(995, 96);
            this.label2.TabIndex = 8;
            this.label2.Text = "Спасибо за поддержку бегуна в Marathon Skills 2016! Ваше пожертвование пойдёт в е" +
    "го благотворительную организацию";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 303);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1509, 463);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1494, 92);
            this.label3.TabIndex = 9;
            this.label3.Text = "Имя Фамилия (номер) из Страна";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(3, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1494, 87);
            this.label4.TabIndex = 10;
            this.label4.Text = "Фонд кошек";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Practika.Properties.Settings.Default, "HeaderPanelBackground", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label5.Font = new System.Drawing.Font("Arial", 75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = global::Practika.Properties.Settings.Default.HeaderPanelBackground;
            this.label5.Location = new System.Drawing.Point(3, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1494, 132);
            this.label5.TabIndex = 11;
            this.label5.Text = "$0";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minus_butt
            // 
            this.minus_butt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minus_butt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minus_butt.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minus_butt.Location = new System.Drawing.Point(661, 31);
            this.minus_butt.Name = "minus_butt";
            this.minus_butt.Size = new System.Drawing.Size(163, 42);
            this.minus_butt.TabIndex = 23;
            this.minus_butt.Text = "Назад";
            this.minus_butt.UseVisualStyleBackColor = true;
            this.minus_butt.Click += new System.EventHandler(this.minus_butt_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.minus_butt);
            this.panel1.Location = new System.Drawing.Point(3, 314);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1506, 100);
            this.panel1.TabIndex = 24;
            // 
            // SponsorshipConfirmationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1509, 820);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label2);
            this.Name = "SponsorshipConfirmationForm";
            this.Text = "Marathon Skills 2016 - Sponsorship confirmation";
            this.Load += new System.EventHandler(this.SponsorshipConfirmationForm_Load);
            this.Controls.SetChildIndex(this.timerPanel, 0);
            this.Controls.SetChildIndex(this.topPanel, 0);
            this.Controls.SetChildIndex(this.title_form, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.flowLayoutPanel1, 0);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.timerPanel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button minus_butt;
        private System.Windows.Forms.Panel panel1;
    }
}