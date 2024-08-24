namespace Practika
{
    partial class ParentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParentForm));
            this.topPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timerPanel = new System.Windows.Forms.Panel();
            this.timer_stroke = new System.Windows.Forms.Label();
            this.title_form = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.topPanel.SuspendLayout();
            this.timerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = global::Practika.Properties.Settings.Default.HeaderPanelBackground;
            this.topPanel.Controls.Add(this.label1);
            this.topPanel.Controls.Add(this.button1);
            this.topPanel.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Practika.Properties.Settings.Default, "HeaderPanelBackground", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1509, 90);
            this.topPanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Practika.Properties.Settings.Default, "Background", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label1.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = global::Practika.Properties.Settings.Default.Background;
            this.label1.Location = new System.Drawing.Point(511, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(491, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "MARATHON SKILLS 2016";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.BackColor = global::Practika.Properties.Settings.Default.ButtonExit;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Practika.Properties.Settings.Default, "ButtonExit", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(24, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // timerPanel
            // 
            this.timerPanel.BackColor = global::Practika.Properties.Settings.Default.TimerPanelBackground;
            this.timerPanel.Controls.Add(this.timer_stroke);
            this.timerPanel.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Practika.Properties.Settings.Default, "TimerPanelBackground", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.timerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.timerPanel.Location = new System.Drawing.Point(0, 766);
            this.timerPanel.Name = "timerPanel";
            this.timerPanel.Size = new System.Drawing.Size(1509, 54);
            this.timerPanel.TabIndex = 0;
            // 
            // timer_stroke
            // 
            this.timer_stroke.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::Practika.Properties.Settings.Default, "Background", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.timer_stroke.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timer_stroke.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timer_stroke.ForeColor = global::Practika.Properties.Settings.Default.Background;
            this.timer_stroke.Location = new System.Drawing.Point(0, 0);
            this.timer_stroke.Name = "timer_stroke";
            this.timer_stroke.Size = new System.Drawing.Size(1509, 54);
            this.timer_stroke.TabIndex = 3;
            this.timer_stroke.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // title_form
            // 
            this.title_form.Dock = System.Windows.Forms.DockStyle.Top;
            this.title_form.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title_form.Location = new System.Drawing.Point(0, 90);
            this.title_form.Name = "title_form";
            this.title_form.Size = new System.Drawing.Size(1509, 114);
            this.title_form.TabIndex = 2;
            this.title_form.Text = "TitleForm";
            this.title_form.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ParentForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = global::Practika.Properties.Settings.Default.Button;
            this.ClientSize = new System.Drawing.Size(1509, 820);
            this.Controls.Add(this.title_form);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.timerPanel);
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Practika.Properties.Settings.Default, "Button", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ParentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marathon Skills 2016";
            this.Load += new System.EventHandler(this.ParentForm_Load);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.timerPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        protected System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label title_form;
        public System.Windows.Forms.Label timer_stroke;
        public System.Windows.Forms.Panel timerPanel;
    }
}