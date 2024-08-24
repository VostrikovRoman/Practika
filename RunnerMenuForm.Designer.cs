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
            this.topPanel.SuspendLayout();
            this.timerPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            // 
            // title_form
            // 
            this.title_form.Text = "Меню бегуна";
            // 
            // timer_stroke
            // 
            this.timer_stroke.Size = new System.Drawing.Size(1509, 44);
            this.timer_stroke.Text = "До начала марафона 58 дней 5 часов 58 минут 42 секунды ";
            // 
            // timerPanel
            // 
            this.timerPanel.Location = new System.Drawing.Point(0, 776);
            this.timerPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            // 
            // RunnerMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1509, 820);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "RunnerMenuForm";
            this.Text = "Marathon Skills 2016 - Runner menu";
            this.Load += new System.EventHandler(this.RunnerMenuForm_Load);
            this.Controls.SetChildIndex(this.timerPanel, 0);
            this.Controls.SetChildIndex(this.topPanel, 0);
            this.Controls.SetChildIndex(this.title_form, 0);
            this.Controls.SetChildIndex(this.flowLayoutPanel1, 0);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.timerPanel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}