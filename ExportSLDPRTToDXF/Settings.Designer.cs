namespace ExportSLDPRTToDXF
{
    partial class SettingsForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SQLDB_textBox = new System.Windows.Forms.TextBox();
            this.SQLName_textBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BOMcomboBox = new System.Windows.Forms.ComboBox();
            this.Pass_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Login_textBox = new System.Windows.Forms.TextBox();
            this.VaultsComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DXFPath_txt = new System.Windows.Forms.TextBox();
            this.FolderDXF = new System.Windows.Forms.Button();
            this.ClouseSettings = new System.Windows.Forms.Button();
            this.SaveSettings = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.SQLDB_textBox);
            this.groupBox1.Controls.Add(this.SQLName_textBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.BOMcomboBox);
            this.groupBox1.Controls.Add(this.Pass_textBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Login_textBox);
            this.groupBox1.Controls.Add(this.VaultsComboBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(480, 186);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Подключение";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Спецификация:";
            // 
            // SQLDB_textBox
            // 
            this.SQLDB_textBox.Location = new System.Drawing.Point(268, 38);
            this.SQLDB_textBox.Name = "SQLDB_textBox";
            this.SQLDB_textBox.Size = new System.Drawing.Size(206, 20);
            this.SQLDB_textBox.TabIndex = 17;
            // 
            // SQLName_textBox
            // 
            this.SQLName_textBox.Location = new System.Drawing.Point(268, 13);
            this.SQLName_textBox.Name = "SQLName_textBox";
            this.SQLName_textBox.Size = new System.Drawing.Size(206, 20);
            this.SQLName_textBox.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Имя базы данных:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Имя MS SQL Server:";
            // 
            // BOMcomboBox
            // 
            this.BOMcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BOMcomboBox.FormattingEnabled = true;
            this.BOMcomboBox.Location = new System.Drawing.Point(268, 143);
            this.BOMcomboBox.Name = "BOMcomboBox";
            this.BOMcomboBox.Size = new System.Drawing.Size(206, 21);
            this.BOMcomboBox.TabIndex = 13;
            // 
            // Pass_textBox
            // 
            this.Pass_textBox.Location = new System.Drawing.Point(268, 90);
            this.Pass_textBox.Name = "Pass_textBox";
            this.Pass_textBox.PasswordChar = '*';
            this.Pass_textBox.Size = new System.Drawing.Size(206, 20);
            this.Pass_textBox.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Пароль MS SQL:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Пользователь MS SQL:";
            // 
            // Login_textBox
            // 
            this.Login_textBox.Location = new System.Drawing.Point(268, 64);
            this.Login_textBox.Name = "Login_textBox";
            this.Login_textBox.Size = new System.Drawing.Size(206, 20);
            this.Login_textBox.TabIndex = 9;
            // 
            // VaultsComboBox
            // 
            this.VaultsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VaultsComboBox.FormattingEnabled = true;
            this.VaultsComboBox.Location = new System.Drawing.Point(268, 116);
            this.VaultsComboBox.Name = "VaultsComboBox";
            this.VaultsComboBox.Size = new System.Drawing.Size(206, 21);
            this.VaultsComboBox.TabIndex = 8;
            this.VaultsComboBox.SelectedIndexChanged += new System.EventHandler(this.VaultsComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Хранилище SOLIDWORKS PDM:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DXFPath_txt);
            this.groupBox2.Controls.Add(this.FolderDXF);
            this.groupBox2.Location = new System.Drawing.Point(14, 204);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(478, 60);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DXF";
            // 
            // DXFPath_txt
            // 
            this.DXFPath_txt.Location = new System.Drawing.Point(9, 19);
            this.DXFPath_txt.Name = "DXFPath_txt";
            this.DXFPath_txt.Size = new System.Drawing.Size(316, 20);
            this.DXFPath_txt.TabIndex = 7;
            // 
            // FolderDXF
            // 
            this.FolderDXF.Location = new System.Drawing.Point(331, 19);
            this.FolderDXF.Name = "FolderDXF";
            this.FolderDXF.Size = new System.Drawing.Size(141, 23);
            this.FolderDXF.TabIndex = 6;
            this.FolderDXF.Text = "Папка сохранения DXF файов";
            this.FolderDXF.UseVisualStyleBackColor = true;
            this.FolderDXF.Click += new System.EventHandler(this.FolderDXF_Click);
            // 
            // ClouseSettings
            // 
            this.ClouseSettings.Location = new System.Drawing.Point(345, 270);
            this.ClouseSettings.Name = "ClouseSettings";
            this.ClouseSettings.Size = new System.Drawing.Size(141, 23);
            this.ClouseSettings.TabIndex = 8;
            this.ClouseSettings.Text = "Отмена";
            this.ClouseSettings.UseVisualStyleBackColor = true;
            this.ClouseSettings.Click += new System.EventHandler(this.CloseSettings_Click);
            // 
            // SaveSettings
            // 
            this.SaveSettings.Location = new System.Drawing.Point(198, 270);
            this.SaveSettings.Name = "SaveSettings";
            this.SaveSettings.Size = new System.Drawing.Size(141, 23);
            this.SaveSettings.TabIndex = 7;
            this.SaveSettings.Text = "Сохранить";
            this.SaveSettings.UseVisualStyleBackColor = true;
            this.SaveSettings.Click += new System.EventHandler(this.SaveSettings_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 305);
            this.Controls.Add(this.ClouseSettings);
            this.Controls.Add(this.SaveSettings);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(516, 343);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(516, 343);
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Pass_textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Login_textBox;
        private System.Windows.Forms.ComboBox VaultsComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox DXFPath_txt;
        private System.Windows.Forms.Button FolderDXF;
        private System.Windows.Forms.Button ClouseSettings;
        private System.Windows.Forms.ComboBox BOMcomboBox;
        private System.Windows.Forms.Button SaveSettings;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SQLDB_textBox;
        private System.Windows.Forms.TextBox SQLName_textBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}