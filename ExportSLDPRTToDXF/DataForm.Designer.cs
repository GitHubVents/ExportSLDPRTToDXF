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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Settings_btn = new System.Windows.Forms.Button();
            this.SpecificationDataGrid = new System.Windows.Forms.DataGridView();
            this.Search_textBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.Search_btn = new System.Windows.Forms.Button();
            this.ConfigurationsComboBox = new System.Windows.Forms.ComboBox();
            this.SearchResultList = new System.Windows.Forms.ListBox();
            this.UpLoadDxfButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpecificationDataGrid)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.06396F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.93604F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.Settings_btn, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.SpecificationDataGrid, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Search_textBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.SearchResultList, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.UpLoadDxfButton, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1157, 805);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Settings_btn
            // 
            this.Settings_btn.Location = new System.Drawing.Point(3, 753);
            this.Settings_btn.Name = "Settings_btn";
            this.Settings_btn.Size = new System.Drawing.Size(75, 22);
            this.Settings_btn.TabIndex = 10;
            this.Settings_btn.Text = "Настройки";
            this.Settings_btn.UseVisualStyleBackColor = true;
            this.Settings_btn.Click += new System.EventHandler(this.Settings_btn_Click);
            // 
            // SpecificationDataGrid
            // 
            this.SpecificationDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SpecificationDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.SpecificationDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SpecificationDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SpecificationDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpecificationDataGrid.Location = new System.Drawing.Point(212, 38);
            this.SpecificationDataGrid.MultiSelect = false;
            this.SpecificationDataGrid.Name = "SpecificationDataGrid";
            this.SpecificationDataGrid.ReadOnly = true;
            this.SpecificationDataGrid.Size = new System.Drawing.Size(942, 709);
            this.SpecificationDataGrid.TabIndex = 4;
            // 
            // Search_textBox
            // 
            this.Search_textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Search_textBox.Location = new System.Drawing.Point(3, 3);
            this.Search_textBox.Name = "Search_textBox";
            this.Search_textBox.Size = new System.Drawing.Size(203, 20);
            this.Search_textBox.TabIndex = 6;
            this.Search_textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Search_textBox_KeyDown);
            this.Search_textBox.MouseEnter += new System.EventHandler(this.Search_textBox_MouseEnter);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.75584F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.24416F));
            this.tableLayoutPanel3.Controls.Add(this.Search_btn, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.ConfigurationsComboBox, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(212, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(942, 29);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // Search_btn
            // 
            this.Search_btn.Location = new System.Drawing.Point(3, 3);
            this.Search_btn.Name = "Search_btn";
            this.Search_btn.Size = new System.Drawing.Size(132, 23);
            this.Search_btn.TabIndex = 4;
            this.Search_btn.Text = "Поиск";
            this.Search_btn.UseVisualStyleBackColor = true;
            this.Search_btn.Click += new System.EventHandler(this.Search_btn_Click);
            // 
            // ConfigurationsComboBox
            // 
            this.ConfigurationsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ConfigurationsComboBox.FormattingEnabled = true;
            this.ConfigurationsComboBox.Location = new System.Drawing.Point(142, 3);
            this.ConfigurationsComboBox.Name = "ConfigurationsComboBox";
            this.ConfigurationsComboBox.Size = new System.Drawing.Size(121, 21);
            this.ConfigurationsComboBox.TabIndex = 7;
            this.ConfigurationsComboBox.SelectedIndexChanged += new System.EventHandler(this.ConfigurationsComboBox_SelectedIndexChanged);
            this.ConfigurationsComboBox.MouseEnter += new System.EventHandler(this.ConfigurationsComboBox_MouseEnter);
            // 
            // SearchResultList
            // 
            this.SearchResultList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchResultList.Location = new System.Drawing.Point(3, 38);
            this.SearchResultList.Name = "SearchResultList";
            this.SearchResultList.Size = new System.Drawing.Size(203, 709);
            this.SearchResultList.TabIndex = 0;
            this.SearchResultList.SelectedIndexChanged += new System.EventHandler(this.SearchResultList_SelectedIndexChanged);
            // 
            // UpLoadDxfButton
            // 
            this.UpLoadDxfButton.Location = new System.Drawing.Point(212, 753);
            this.UpLoadDxfButton.Name = "UpLoadDxfButton";
            this.UpLoadDxfButton.Size = new System.Drawing.Size(102, 22);
            this.UpLoadDxfButton.TabIndex = 11;
            this.UpLoadDxfButton.Text = "Выгрузить DXF";
            this.UpLoadDxfButton.UseVisualStyleBackColor = true;
            this.UpLoadDxfButton.Click += new System.EventHandler(this.UpLoadDxfButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.VersionLabel);
            this.panel1.Controls.Add(this.StatusLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(212, 782);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(942, 20);
            this.panel1.TabIndex = 13;
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.VersionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VersionLabel.Location = new System.Drawing.Point(924, 0);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.VersionLabel.Size = new System.Drawing.Size(18, 13);
            this.VersionLabel.TabIndex = 13;
            this.VersionLabel.Text = "v.";
            this.ToolTip.SetToolTip(this.VersionLabel, "Версия");
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.StatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StatusLabel.Location = new System.Drawing.Point(0, 0);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StatusLabel.Size = new System.Drawing.Size(59, 17);
            this.StatusLabel.TabIndex = 12;
            this.StatusLabel.Text = "Статус";
            this.ToolTip.SetToolTip(this.StatusLabel, "Статус");
            // 
            // DataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 805);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DataForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpecificationDataGrid)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button Search_btn;
        private System.Windows.Forms.DataGridView SpecificationDataGrid;
        private System.Windows.Forms.TextBox Search_textBox;
        private System.Windows.Forms.ComboBox ConfigurationsComboBox;
        private System.Windows.Forms.ListBox SearchResultList;
        private System.Windows.Forms.Button Settings_btn;
        private System.Windows.Forms.Button UpLoadDxfButton;
        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label VersionLabel;
    }
}

