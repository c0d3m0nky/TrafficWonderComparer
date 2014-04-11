namespace TrafficWonderComparer
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtPlayer = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.dgvComparison = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbStopSelector = new System.Windows.Forms.ComboBox();
            this.nudPlayerCnt = new System.Windows.Forms.NumericUpDown();
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.tsslMain = new System.Windows.Forms.ToolStripStatusLabel();
            this.Level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TopScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeastStops = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stops = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbShowAllLevels = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nudMaxStops = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComparison)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlayerCnt)).BeginInit();
            this.ssMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxStops)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPlayer
            // 
            this.txtPlayer.Location = new System.Drawing.Point(13, 13);
            this.txtPlayer.Name = "txtPlayer";
            this.txtPlayer.Size = new System.Drawing.Size(100, 20);
            this.txtPlayer.TabIndex = 0;
            this.txtPlayer.Text = "c0d3m0nk3y";
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(119, 13);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(36, 23);
            this.btnGo.TabIndex = 1;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // dgvComparison
            // 
            this.dgvComparison.AllowUserToAddRows = false;
            this.dgvComparison.AllowUserToDeleteRows = false;
            this.dgvComparison.AllowUserToResizeRows = false;
            this.dgvComparison.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvComparison.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvComparison.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvComparison.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvComparison.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComparison.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Level,
            this.TopScore,
            this.Score,
            this.Dif,
            this.LeastStops,
            this.Stops});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvComparison.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvComparison.Location = new System.Drawing.Point(0, 67);
            this.dgvComparison.Name = "dgvComparison";
            this.dgvComparison.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvComparison.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvComparison.RowHeadersWidth = 10;
            this.dgvComparison.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvComparison.Size = new System.Drawing.Size(474, 345);
            this.dgvComparison.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Until";
            // 
            // cmbStopSelector
            // 
            this.cmbStopSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStopSelector.FormattingEnabled = true;
            this.cmbStopSelector.Items.AddRange(new object[] {
            "Comparer Reached",
            "Top Players"});
            this.cmbStopSelector.Location = new System.Drawing.Point(195, 13);
            this.cmbStopSelector.Name = "cmbStopSelector";
            this.cmbStopSelector.Size = new System.Drawing.Size(121, 21);
            this.cmbStopSelector.TabIndex = 5;
            // 
            // nudPlayerCnt
            // 
            this.nudPlayerCnt.Location = new System.Drawing.Point(322, 14);
            this.nudPlayerCnt.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPlayerCnt.Name = "nudPlayerCnt";
            this.nudPlayerCnt.Size = new System.Drawing.Size(42, 20);
            this.nudPlayerCnt.TabIndex = 6;
            this.nudPlayerCnt.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            // 
            // ssMain
            // 
            this.ssMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslMain});
            this.ssMain.Location = new System.Drawing.Point(0, 415);
            this.ssMain.Name = "ssMain";
            this.ssMain.Size = new System.Drawing.Size(474, 22);
            this.ssMain.SizingGrip = false;
            this.ssMain.TabIndex = 7;
            // 
            // tsslMain
            // 
            this.tsslMain.Name = "tsslMain";
            this.tsslMain.Size = new System.Drawing.Size(0, 17);
            // 
            // Level
            // 
            this.Level.HeaderText = "Level";
            this.Level.Name = "Level";
            this.Level.Width = 58;
            // 
            // TopScore
            // 
            this.TopScore.HeaderText = "Top Score";
            this.TopScore.Name = "TopScore";
            this.TopScore.Width = 82;
            // 
            // Score
            // 
            this.Score.HeaderText = "Score";
            this.Score.Name = "Score";
            this.Score.ReadOnly = true;
            this.Score.Width = 60;
            // 
            // Dif
            // 
            this.Dif.HeaderText = "Dif";
            this.Dif.Name = "Dif";
            this.Dif.Width = 45;
            // 
            // LeastStops
            // 
            this.LeastStops.HeaderText = "Least Stops";
            this.LeastStops.Name = "LeastStops";
            this.LeastStops.Width = 88;
            // 
            // Stops
            // 
            this.Stops.HeaderText = "Stops";
            this.Stops.Name = "Stops";
            this.Stops.ReadOnly = true;
            this.Stops.Width = 59;
            // 
            // cbShowAllLevels
            // 
            this.cbShowAllLevels.AutoSize = true;
            this.cbShowAllLevels.Location = new System.Drawing.Point(13, 42);
            this.cbShowAllLevels.Name = "cbShowAllLevels";
            this.cbShowAllLevels.Size = new System.Drawing.Size(101, 17);
            this.cbShowAllLevels.TabIndex = 8;
            this.cbShowAllLevels.Text = "Show All Levels";
            this.cbShowAllLevels.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "MaxStops";
            // 
            // nudMaxStops
            // 
            this.nudMaxStops.Location = new System.Drawing.Point(180, 41);
            this.nudMaxStops.Maximum = new decimal(new int[] {
            14,
            0,
            0,
            0});
            this.nudMaxStops.Name = "nudMaxStops";
            this.nudMaxStops.Size = new System.Drawing.Size(36, 20);
            this.nudMaxStops.TabIndex = 10;
            this.nudMaxStops.Value = new decimal(new int[] {
            14,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 437);
            this.Controls.Add(this.nudMaxStops);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbShowAllLevels);
            this.Controls.Add(this.ssMain);
            this.Controls.Add(this.nudPlayerCnt);
            this.Controls.Add(this.cmbStopSelector);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvComparison);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.txtPlayer);
            this.MinimumSize = new System.Drawing.Size(490, 475);
            this.Name = "Form1";
            this.Text = "Traffic Wonder Comparer";
            ((System.ComponentModel.ISupportInitialize)(this.dgvComparison)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlayerCnt)).EndInit();
            this.ssMain.ResumeLayout(false);
            this.ssMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxStops)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPlayer;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.DataGridView dgvComparison;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbStopSelector;
        private System.Windows.Forms.NumericUpDown nudPlayerCnt;
        private System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.ToolStripStatusLabel tsslMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn Level;
        private System.Windows.Forms.DataGridViewTextBoxColumn TopScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn Score;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dif;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeastStops;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stops;
        private System.Windows.Forms.CheckBox cbShowAllLevels;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudMaxStops;
    }
}

