namespace Practika
{
    partial class MainForm
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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.login_button = new System.Windows.Forms.Button();
            this.userTableAdapter = new Practika.MarathonSkillsDBDataSetTableAdapters.UsersTableAdapter();
            this.topPanel.SuspendLayout();
            this.timerPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.label2);
            this.topPanel.Size = new System.Drawing.Size(1509, 272);
            this.topPanel.Controls.SetChildIndex(this.label2, 0);
            this.topPanel.Controls.SetChildIndex(this.button1, 0);
            this.topPanel.Controls.SetChildIndex(this.label1, 0);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 204);
            this.button1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = false;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Arial", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Size = new System.Drawing.Size(1509, 168);
            // 
            // title_form
            // 
            this.title_form.Location = new System.Drawing.Point(0, 272);
            this.title_form.Size = new System.Drawing.Size(1509, 82);
            this.title_form.Visible = false;
            // 
            // timer_stroke
            // 
            this.timer_stroke.Size = new System.Drawing.Size(1509, 65);
            this.timer_stroke.Text = "До начала марафона 62 дня 22 часа 53 минуты 57 секунд ";
            // 
            // timerPanel
            // 
            this.timerPanel.Location = new System.Drawing.Point(0, 755);
            this.timerPanel.Size = new System.Drawing.Size(1509, 65);
            // 
            // label2
            // 
            this.label2.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Practika.Properties.Settings.Default, "GrayText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = global::Practika.Properties.Settings.Default.GrayText;
            this.label2.Location = new System.Drawing.Point(0, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1509, 104);
            this.label2.TabIndex = 2;
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = global::Practika.Properties.Settings.Default.Button;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Practika.Properties.Settings.Default, "Button", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(3, 3);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(557, 89);
            this.button2.TabIndex = 3;
            this.button2.Text = "Я хочу стать бегуном";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = global::Practika.Properties.Settings.Default.Button;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Practika.Properties.Settings.Default, "Button", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(3, 125);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(557, 89);
            this.button3.TabIndex = 4;
            this.button3.Text = "Я хочу стать спонсором бегуна";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackColor = global::Practika.Properties.Settings.Default.Button;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Practika.Properties.Settings.Default, "Button", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(3, 247);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(557, 89);
            this.button4.TabIndex = 5;
            this.button4.Text = "Я хочу узнать больше о событии";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Controls.Add(this.button4);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(481, 314);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 53, 3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(572, 346);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // login_button
            // 
            this.login_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.login_button.BackColor = global::Practika.Properties.Settings.Default.Button;
            this.login_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_button.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Practika.Properties.Settings.Default, "Button", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.login_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_button.Location = new System.Drawing.Point(1309, 678);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(171, 57);
            this.login_button.TabIndex = 7;
            this.login_button.Text = "Login";
            this.login_button.UseVisualStyleBackColor = false;
            this.login_button.Click += new System.EventHandler(this.login_button_Click_1);
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1509, 820);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Controls.SetChildIndex(this.timerPanel, 0);
            this.Controls.SetChildIndex(this.topPanel, 0);
            this.Controls.SetChildIndex(this.title_form, 0);
            this.Controls.SetChildIndex(this.flowLayoutPanel1, 0);
            this.Controls.SetChildIndex(this.login_button, 0);
            this.topPanel.ResumeLayout(false);
            this.timerPanel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        public System.Windows.Forms.Button login_button;
        private MarathonSkillsDBDataSetTableAdapters.UsersTableAdapter userTableAdapter;
    }
}