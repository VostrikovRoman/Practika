namespace Practika
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.marathonSkillsDBDataSet = new Practika.MarathonSkillsDBDataSet();
            this.marathonSkillsDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.positionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.positionTableAdapter = new Practika.MarathonSkillsDBDataSetTableAdapters.PositionTableAdapter();
            this.positionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payPeriodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payRateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marathonSkillsDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marathonSkillsDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.positionIDDataGridViewTextBoxColumn,
            this.positionNameDataGridViewTextBoxColumn,
            this.positionDescriptionDataGridViewTextBoxColumn,
            this.payPeriodDataGridViewTextBoxColumn,
            this.payRateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.positionBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(800, 302);
            this.dataGridView1.TabIndex = 0;
            // 
            // marathonSkillsDBDataSet
            // 
            this.marathonSkillsDBDataSet.DataSetName = "MarathonSkillsDBDataSet";
            this.marathonSkillsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // marathonSkillsDBDataSetBindingSource
            // 
            this.marathonSkillsDBDataSetBindingSource.DataSource = this.marathonSkillsDBDataSet;
            this.marathonSkillsDBDataSetBindingSource.Position = 0;
            // 
            // positionBindingSource
            // 
            this.positionBindingSource.DataMember = "Position";
            this.positionBindingSource.DataSource = this.marathonSkillsDBDataSetBindingSource;
            // 
            // positionTableAdapter
            // 
            this.positionTableAdapter.ClearBeforeFill = true;
            // 
            // positionIDDataGridViewTextBoxColumn
            // 
            this.positionIDDataGridViewTextBoxColumn.DataPropertyName = "PositionID";
            this.positionIDDataGridViewTextBoxColumn.HeaderText = "PositionID";
            this.positionIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.positionIDDataGridViewTextBoxColumn.Name = "positionIDDataGridViewTextBoxColumn";
            this.positionIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // positionNameDataGridViewTextBoxColumn
            // 
            this.positionNameDataGridViewTextBoxColumn.DataPropertyName = "PositionName";
            this.positionNameDataGridViewTextBoxColumn.HeaderText = "PositionName";
            this.positionNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.positionNameDataGridViewTextBoxColumn.Name = "positionNameDataGridViewTextBoxColumn";
            this.positionNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // positionDescriptionDataGridViewTextBoxColumn
            // 
            this.positionDescriptionDataGridViewTextBoxColumn.DataPropertyName = "PositionDescription";
            this.positionDescriptionDataGridViewTextBoxColumn.HeaderText = "PositionDescription";
            this.positionDescriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.positionDescriptionDataGridViewTextBoxColumn.Name = "positionDescriptionDataGridViewTextBoxColumn";
            this.positionDescriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // payPeriodDataGridViewTextBoxColumn
            // 
            this.payPeriodDataGridViewTextBoxColumn.DataPropertyName = "PayPeriod";
            this.payPeriodDataGridViewTextBoxColumn.HeaderText = "PayPeriod";
            this.payPeriodDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.payPeriodDataGridViewTextBoxColumn.Name = "payPeriodDataGridViewTextBoxColumn";
            this.payPeriodDataGridViewTextBoxColumn.Width = 125;
            // 
            // payRateDataGridViewTextBoxColumn
            // 
            this.payRateDataGridViewTextBoxColumn.DataPropertyName = "PayRate";
            this.payRateDataGridViewTextBoxColumn.HeaderText = "PayRate";
            this.payRateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.payRateDataGridViewTextBoxColumn.Name = "payRateDataGridViewTextBoxColumn";
            this.payRateDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marathonSkillsDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marathonSkillsDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource marathonSkillsDBDataSetBindingSource;
        private MarathonSkillsDBDataSet marathonSkillsDBDataSet;
        private System.Windows.Forms.BindingSource positionBindingSource;
        private MarathonSkillsDBDataSetTableAdapters.PositionTableAdapter positionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn payPeriodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn payRateDataGridViewTextBoxColumn;
    }
}

