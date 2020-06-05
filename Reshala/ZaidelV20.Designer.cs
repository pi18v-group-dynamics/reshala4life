namespace ZaidelV20
{
    partial class ZaidelV20
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
            this.layoutMatrixA = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.layoutVectorX = new System.Windows.Forms.TableLayoutPanel();
            this.layoutVectorB = new System.Windows.Forms.TableLayoutPanel();
            this.layoutVectorU = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.пример4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пример3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пример2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пример1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.тестовыеПримерыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // layoutMatrixA
            // 
            this.layoutMatrixA.ColumnCount = 1;
            this.layoutMatrixA.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutMatrixA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutMatrixA.Location = new System.Drawing.Point(3, 54);
            this.layoutMatrixA.Name = "layoutMatrixA";
            this.layoutMatrixA.RowCount = 1;
            this.layoutMatrixA.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutMatrixA.Size = new System.Drawing.Size(532, 368);
            this.layoutMatrixA.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.label2.Location = new System.Drawing.Point(238, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Матрица";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.label3.Location = new System.Drawing.Point(568, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "X";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Размерность Матрицы:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numericUpDown1.Location = new System.Drawing.Point(150, 4);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(87, 20);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.button1.Location = new System.Drawing.Point(243, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Решить Уравнение";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // layoutVectorX
            // 
            this.layoutVectorX.CausesValidation = false;
            this.layoutVectorX.ColumnCount = 1;
            this.layoutVectorX.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutVectorX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutVectorX.Location = new System.Drawing.Point(541, 54);
            this.layoutVectorX.Name = "layoutVectorX";
            this.layoutVectorX.RowCount = 1;
            this.layoutVectorX.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutVectorX.Size = new System.Drawing.Size(70, 368);
            this.layoutVectorX.TabIndex = 1;
            // 
            // layoutVectorB
            // 
            this.layoutVectorB.ColumnCount = 1;
            this.layoutVectorB.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutVectorB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutVectorB.Location = new System.Drawing.Point(617, 54);
            this.layoutVectorB.Name = "layoutVectorB";
            this.layoutVectorB.RowCount = 1;
            this.layoutVectorB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutVectorB.Size = new System.Drawing.Size(70, 368);
            this.layoutVectorB.TabIndex = 2;
            // 
            // layoutVectorU
            // 
            this.layoutVectorU.CausesValidation = false;
            this.layoutVectorU.ColumnCount = 1;
            this.layoutVectorU.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutVectorU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutVectorU.Location = new System.Drawing.Point(693, 54);
            this.layoutVectorU.Name = "layoutVectorU";
            this.layoutVectorU.RowCount = 1;
            this.layoutVectorU.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutVectorU.Size = new System.Drawing.Size(104, 368);
            this.layoutVectorU.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.flowLayoutPanel1, 4);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.numericUpDown1);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(794, 29);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.label4.Location = new System.Drawing.Point(622, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Результат";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.label5.Location = new System.Drawing.Point(704, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Погрешность";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // пример4ToolStripMenuItem
            // 
            this.пример4ToolStripMenuItem.Name = "пример4ToolStripMenuItem";
            this.пример4ToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.пример4ToolStripMenuItem.Text = "Пример #4";
            this.пример4ToolStripMenuItem.Click += new System.EventHandler(this.пример4ToolStripMenuItem_Click);
            // 
            // пример3ToolStripMenuItem
            // 
            this.пример3ToolStripMenuItem.Name = "пример3ToolStripMenuItem";
            this.пример3ToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.пример3ToolStripMenuItem.Text = "Пример #3";
            this.пример3ToolStripMenuItem.Click += new System.EventHandler(this.пример3ToolStripMenuItem_Click);
            // 
            // пример2ToolStripMenuItem
            // 
            this.пример2ToolStripMenuItem.Name = "пример2ToolStripMenuItem";
            this.пример2ToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.пример2ToolStripMenuItem.Text = "Пример #2";
            this.пример2ToolStripMenuItem.Click += new System.EventHandler(this.пример2ToolStripMenuItem_Click);
            // 
            // пример1ToolStripMenuItem
            // 
            this.пример1ToolStripMenuItem.Name = "пример1ToolStripMenuItem";
            this.пример1ToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.пример1ToolStripMenuItem.Text = "Пример #1";
            this.пример1ToolStripMenuItem.Click += new System.EventHandler(this.пример1ToolStripMenuItem_Click_1);
            // 
            // тестовыеПримерыToolStripMenuItem
            // 
            this.тестовыеПримерыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пример1ToolStripMenuItem,
            this.пример2ToolStripMenuItem,
            this.пример3ToolStripMenuItem,
            this.пример4ToolStripMenuItem});
            this.тестовыеПримерыToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.тестовыеПримерыToolStripMenuItem.Name = "тестовыеПримерыToolStripMenuItem";
            this.тестовыеПримерыToolStripMenuItem.Size = new System.Drawing.Size(119, 21);
            this.тестовыеПримерыToolStripMenuItem.Text = "Автозаполнение";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.30769F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.615385F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.615385F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.46154F));
            this.tableLayoutPanel1.Controls.Add(this.layoutMatrixA, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.layoutVectorX, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.layoutVectorB, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.layoutVectorU, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 3, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 425);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.тестовыеПримерыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ZaidelV20
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "ZaidelV20";
            this.Text = "Решение Методом Зейделя";
            this.Load += new System.EventHandler(this.ZaidelV20_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layoutMatrixA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel layoutVectorX;
        private System.Windows.Forms.TableLayoutPanel layoutVectorB;
        private System.Windows.Forms.TableLayoutPanel layoutVectorU;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem пример4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пример3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пример2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пример1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem тестовыеПримерыToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}