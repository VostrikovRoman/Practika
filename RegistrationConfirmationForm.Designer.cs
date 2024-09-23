namespace Practika
{
    partial class RegistrationConfirmationForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.topPanel.SuspendLayout();
            this.timerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // title_form
            // 
            this.title_form.Text = "Спасибо за вашу регистрацию в качестве бегуна!";
            // 
            // timer_stroke
            // 
            this.timer_stroke.Text = "До начала марафона 356 дней 16 часов 58 минут 44 секунды ";
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(0, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1509, 54);
            this.label2.TabIndex = 9;
            this.label2.Text = "Спасибо за вашу регистрацию в качестве бегуна в Marathon Skills 2016!";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(0, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1509, 68);
            this.label3.TabIndex = 10;
            this.label3.Text = "С вами свяжутся по поводу оплаты.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = global::Practika.Properties.Settings.Default.Button;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Practika.Properties.Settings.Default, "Button", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(679, 372);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 3, 30, 30);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 41);
            this.button3.TabIndex = 11;
            this.button3.Text = "ОК";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // RegistrationConfirmationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1509, 820);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "RegistrationConfirmationForm";
            this.Text = "Marathon Skills 2016 - Registration confirmation";
            this.Load += new System.EventHandler(this.RegistrationConfirmationForm_Load);
            this.Controls.SetChildIndex(this.timerPanel, 0);
            this.Controls.SetChildIndex(this.topPanel, 0);
            this.Controls.SetChildIndex(this.title_form, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.button3, 0);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.timerPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
    }
}