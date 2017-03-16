namespace ExportSLDPRTToDXF
{
    partial class DataForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Search_textBox = new System.Windows.Forms.TextBox();
            this.Settings_btn = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.Search_btn = new System.Windows.Forms.Button();
            this.ConfigurationsComboBox = new System.Windows.Forms.ComboBox();
            this.SearchResultList = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.06396F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.93604F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Search_textBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Settings_btn, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.SearchResultList, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1157, 775);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(212, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(942, 668);
            this.dataGridView1.TabIndex = 4;
            // 
            // Search_textBox
            // 
            this.Search_textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Search_textBox.Location = new System.Drawing.Point(3, 3);
            this.Search_textBox.Name = "Search_textBox";
            this.Search_textBox.Size = new System.Drawing.Size(203, 20);
            this.Search_textBox.TabIndex = 6;
            // 
            // Settings_btn
            // 
            this.Settings_btn.Location = new System.Drawing.Point(3, 712);
            this.Settings_btn.Name = "Settings_btn";
            this.Settings_btn.Size = new System.Drawing.Size(75, 23);
            this.Settings_btn.TabIndex = 9;
            this.Settings_btn.Text = "Настройки";
            this.Settings_btn.UseVisualStyleBackColor = true;
            this.Settings_btn.Click += new System.EventHandler(this.Settings_btn_Click_1);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.26025F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.73975F));
            this.tableLayoutPanel3.Controls.Add(this.Search_btn, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.ConfigurationsComboBox, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(212, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(561, 29);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // Search_btn
            // 
            this.Search_btn.Location = new System.Drawing.Point(3, 3);
            this.Search_btn.Name = "Search_btn";
            this.Search_btn.Size = new System.Drawing.Size(73, 23);
            this.Search_btn.TabIndex = 4;
            this.Search_btn.Text = "Поиск";
            this.Search_btn.UseVisualStyleBackColor = true;
            this.Search_btn.Click += new System.EventHandler(this.Search_btn_Click);
            // 
            // ConfigurationsComboBox
            // 
            this.ConfigurationsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ConfigurationsComboBox.FormattingEnabled = true;
            this.ConfigurationsComboBox.Location = new System.Drawing.Point(83, 3);
            this.ConfigurationsComboBox.Name = "ConfigurationsComboBox";
            this.ConfigurationsComboBox.Size = new System.Drawing.Size(121, 21);
            this.ConfigurationsComboBox.TabIndex = 7;
            this.ConfigurationsComboBox.SelectedIndexChanged += new System.EventHandler(this.ConfigurationsComboBox_SelectedIndexChanged);
            // 
            // SearchResultList
            // 
            this.SearchResultList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchResultList.Location = new System.Drawing.Point(3, 38);
            this.SearchResultList.Name = "SearchResultList";
            this.SearchResultList.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.SearchResultList.Size = new System.Drawing.Size(203, 668);
            this.SearchResultList.TabIndex = 0;
            this.SearchResultList.SelectedIndexChanged += new System.EventHandler(this.SearchResultList_SelectedIndexChanged);
            // 
            // DataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 775);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DataForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button Search_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox Search_textBox;
        private System.Windows.Forms.Button Settings_btn;
        private System.Windows.Forms.ComboBox ConfigurationsComboBox;
        private System.Windows.Forms.ListBox SearchResultList;
    }
}

