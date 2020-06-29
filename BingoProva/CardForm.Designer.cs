namespace BingoProva
{
    partial class CardForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.generateBingoButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bingoDataGridView = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bingoBusinessBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bingoDataGridView)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bingoBusinessBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.generateBingoButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(542, 65);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prova - Desafio do Bingo";
            // 
            // generateBingoButton
            // 
            this.generateBingoButton.BackColor = System.Drawing.Color.White;
            this.generateBingoButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.generateBingoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateBingoButton.Location = new System.Drawing.Point(447, 12);
            this.generateBingoButton.Name = "generateBingoButton";
            this.generateBingoButton.Size = new System.Drawing.Size(83, 37);
            this.generateBingoButton.TabIndex = 0;
            this.generateBingoButton.Text = "Gerar";
            this.generateBingoButton.UseVisualStyleBackColor = false;
            this.generateBingoButton.Click += new System.EventHandler(this.generateBingoButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bingoDataGridView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(542, 234);
            this.panel2.TabIndex = 1;
            // 
            // bingoDataGridView
            // 
            this.bingoDataGridView.AllowUserToAddRows = false;
            this.bingoDataGridView.AllowUserToDeleteRows = false;
            this.bingoDataGridView.AutoGenerateColumns = false;
            this.bingoDataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bingoDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.bingoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bingoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bDataGridViewTextBoxColumn,
            this.iDataGridViewTextBoxColumn,
            this.nDataGridViewTextBoxColumn,
            this.gDataGridViewTextBoxColumn,
            this.oDataGridViewTextBoxColumn});
            this.bingoDataGridView.DataSource = this.bingoBusinessBindingSource;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bingoDataGridView.DefaultCellStyle = dataGridViewCellStyle7;
            this.bingoDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bingoDataGridView.Location = new System.Drawing.Point(0, 0);
            this.bingoDataGridView.Name = "bingoDataGridView";
            this.bingoDataGridView.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bingoDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.bingoDataGridView.Size = new System.Drawing.Size(542, 234);
            this.bingoDataGridView.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SteelBlue;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 264);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(542, 35);
            this.panel3.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Autoria: Bruno Aparecido Zupp Noveli.    R.A: 95110";
            // 
            // bingoBusinessBindingSource
            // 
            this.bingoBusinessBindingSource.DataSource = typeof(BingoProva.BingoBusiness);
            // 
            // bDataGridViewTextBoxColumn
            // 
            this.bDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bDataGridViewTextBoxColumn.DataPropertyName = "B";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.bDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.bDataGridViewTextBoxColumn.HeaderText = "      B";
            this.bDataGridViewTextBoxColumn.Name = "bDataGridViewTextBoxColumn";
            this.bDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDataGridViewTextBoxColumn
            // 
            this.iDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iDataGridViewTextBoxColumn.DataPropertyName = "I";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.iDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.iDataGridViewTextBoxColumn.HeaderText = "      I";
            this.iDataGridViewTextBoxColumn.Name = "iDataGridViewTextBoxColumn";
            this.iDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nDataGridViewTextBoxColumn
            // 
            this.nDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nDataGridViewTextBoxColumn.DataPropertyName = "N";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.nDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.nDataGridViewTextBoxColumn.HeaderText = "      N";
            this.nDataGridViewTextBoxColumn.Name = "nDataGridViewTextBoxColumn";
            this.nDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gDataGridViewTextBoxColumn
            // 
            this.gDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gDataGridViewTextBoxColumn.DataPropertyName = "G";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.gDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.gDataGridViewTextBoxColumn.HeaderText = "      G";
            this.gDataGridViewTextBoxColumn.Name = "gDataGridViewTextBoxColumn";
            this.gDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // oDataGridViewTextBoxColumn
            // 
            this.oDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.oDataGridViewTextBoxColumn.DataPropertyName = "O";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.oDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.oDataGridViewTextBoxColumn.HeaderText = "      O";
            this.oDataGridViewTextBoxColumn.Name = "oDataGridViewTextBoxColumn";
            this.oDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // CardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 299);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cartela de bingo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bingoDataGridView)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bingoBusinessBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView bingoDataGridView;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.BindingSource bingoBusinessBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button generateBingoButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn bDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oDataGridViewTextBoxColumn;
    }
}