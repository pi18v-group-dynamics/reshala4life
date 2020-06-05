namespace Reshala
{
    partial class Gaus
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_Row = new System.Windows.Forms.ComboBox();
            this.comboBox_Column = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column_Result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_Solve = new System.Windows.Forms.Button();
            this.button_AutoValues = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Количество переменных(столбцов)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(286, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Количество уровнений(строк)";
            // 
            // comboBox_Row
            // 
            this.comboBox_Row.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Row.FormattingEnabled = true;
            this.comboBox_Row.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.comboBox_Row.Location = new System.Drawing.Point(491, 10);
            this.comboBox_Row.Name = "comboBox_Row";
            this.comboBox_Row.Size = new System.Drawing.Size(40, 24);
            this.comboBox_Row.TabIndex = 7;
            this.comboBox_Row.SelectedValueChanged += new System.EventHandler(this.comboBox_Row_SelectedValueChanged);
            // 
            // comboBox_Column
            // 
            this.comboBox_Column.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Column.FormattingEnabled = true;
            this.comboBox_Column.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.comboBox_Column.Location = new System.Drawing.Point(244, 10);
            this.comboBox_Column.Name = "comboBox_Column";
            this.comboBox_Column.Size = new System.Drawing.Size(40, 24);
            this.comboBox_Column.TabIndex = 6;
            this.comboBox_Column.SelectedValueChanged += new System.EventHandler(this.comboBox_Column_SelectedValueChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Result});
            this.dataGridView1.Location = new System.Drawing.Point(3, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(794, 326);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView1_EditingControlShowing);
            // 
            // Column_Result
            // 
            this.Column_Result.Frozen = true;
            this.Column_Result.HeaderText = "Результат";
            this.Column_Result.MinimumWidth = 6;
            this.Column_Result.Name = "Column_Result";
            this.Column_Result.ReadOnly = true;
            this.Column_Result.Width = 125;
            // 
            // button_Solve
            // 
            this.button_Solve.Location = new System.Drawing.Point(537, 6);
            this.button_Solve.Name = "button_Solve";
            this.button_Solve.Size = new System.Drawing.Size(128, 31);
            this.button_Solve.TabIndex = 10;
            this.button_Solve.Text = "Решить СЛАУ";
            this.button_Solve.UseVisualStyleBackColor = true;
            this.button_Solve.Click += new System.EventHandler(this.button_Solve_Click);
            // 
            // button_AutoValues
            // 
            this.button_AutoValues.Location = new System.Drawing.Point(666, 6);
            this.button_AutoValues.Name = "button_AutoValues";
            this.button_AutoValues.Size = new System.Drawing.Size(128, 31);
            this.button_AutoValues.TabIndex = 11;
            this.button_AutoValues.Text = "Автозаполнение";
            this.button_AutoValues.UseVisualStyleBackColor = true;
            this.button_AutoValues.Click += new System.EventHandler(this.button_AutoValues_Click);
            // 
            // Gaus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 377);
            this.Controls.Add(this.comboBox_Row);
            this.Controls.Add(this.comboBox_Column);
            this.Controls.Add(this.button_AutoValues);
            this.Controls.Add(this.button_Solve);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Gaus";
            this.Text = "Gaus";
            this.Load += new System.EventHandler(this.Gaus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_Row;
        private System.Windows.Forms.ComboBox comboBox_Column;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_Solve;
        private System.Windows.Forms.Button button_AutoValues;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Result;
    }
}