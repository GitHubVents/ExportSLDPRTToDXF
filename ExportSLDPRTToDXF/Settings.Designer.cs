namespace ExportSLDPRTToDXF
{
    partial class Settings
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
            this.BOMcomboBox = new System.Windows.Forms.ComboBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.VaultsComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ConnectionStrToDBTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DXFPath_txt = new System.Windows.Forms.TextBox();
            this.FolderDXF = new System.Windows.Forms.Button();
            this.SaveSettings = new System.Windows.Forms.Button();
            this.ClouseSettings = new System.Windows.Forms.Button();
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
            this.groupBox1.Controls.Add(this.BOMcomboBox);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.VaultsComboBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ConnectionStrToDBTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(676, 167);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Подключение";
            // 
            // BOMcomboBox
            // 
            this.BOMcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BOMcomboBox.FormattingEnabled = true;
            this.BOMcomboBox.Location = new System.Drawing.Point(214, 129);
            this.BOMcomboBox.Name = "BOMcomboBox";
            this.BOMcomboBox.Size = new System.Drawing.Size(140, 21);
            this.BOMcomboBox.TabIndex = 13;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(214, 76);
            this.textBox4.Name = "textBox4";
            this.textBox4.PasswordChar = '*';
            this.textBox4.Size = new System.Drawing.Size(140, 20);
            this.textBox4.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Пароль MS SQL:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Пользователь MS SQL:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(214, 50);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(140, 20);
            this.textBox3.TabIndex = 9;
            // 
            // VaultsComboBox
            // 
            this.VaultsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VaultsComboBox.FormattingEnabled = true;
            this.VaultsComboBox.Location = new System.Drawing.Point(214, 102);
            this.VaultsComboBox.Name = "VaultsComboBox";
            this.VaultsComboBox.Size = new System.Drawing.Size(140, 21);
            this.VaultsComboBox.TabIndex = 8;
            this.VaultsComboBox.SelectedIndexChanged += new System.EventHandler(this.VaultsComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Хранилище SOLIDWORKS PDM:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Строка подключение к MS SQL Server:";
            // 
            // ConnectionStringToDataBase
            // 
            this.ConnectionStrToDBTextBox.Location = new System.Drawing.Point(214, 24);
            this.ConnectionStrToDBTextBox.Name = "ConnectionStringToDataBase";
            this.ConnectionStrToDBTextBox.Size = new System.Drawing.Size(451, 20);
            this.ConnectionStrToDBTextBox.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DXFPath_txt);
            this.groupBox2.Controls.Add(this.FolderDXF);
            this.groupBox2.Location = new System.Drawing.Point(12, 185);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(676, 60);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DXF";
            // 
            // DXFPath_txt
            // 
            this.DXFPath_txt.Location = new System.Drawing.Point(214, 21);
            this.DXFPath_txt.Name = "DXFPath_txt";
            this.DXFPath_txt.Size = new System.Drawing.Size(454, 20);
            this.DXFPath_txt.TabIndex = 7;
            // 
            // FolderDXF
            // 
            this.FolderDXF.Location = new System.Drawing.Point(9, 19);
            this.FolderDXF.Name = "FolderDXF";
            this.FolderDXF.Size = new System.Drawing.Size(141, 23);
            this.FolderDXF.TabIndex = 6;
            this.FolderDXF.Text = "Папка сохранения DXF файов";
            this.FolderDXF.UseVisualStyleBackColor = true;
            this.FolderDXF.Click += new System.EventHandler(this.FolderDXF_Click);
            // 
            // SaveSettings
            // 
            this.SaveSettings.Location = new System.Drawing.Point(392, 251);
            this.SaveSettings.Name = "SaveSettings";
            this.SaveSettings.Size = new System.Drawing.Size(141, 23);
            this.SaveSettings.TabIndex = 7;
            this.SaveSettings.Text = "Сохранить";
            this.SaveSettings.UseVisualStyleBackColor = true;
            this.SaveSettings.Click += new System.EventHandler(this.SaveSettings_Click);
            // 
            // ClouseSettings
            // 
            this.ClouseSettings.Location = new System.Drawing.Point(539, 251);
            this.ClouseSettings.Name = "ClouseSettings";
            this.ClouseSettings.Size = new System.Drawing.Size(141, 23);
            this.ClouseSettings.TabIndex = 8;
            this.ClouseSettings.Text = "Отмена";
            this.ClouseSettings.UseVisualStyleBackColor = true;
            this.ClouseSettings.Click += new System.EventHandler(this.button3_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 305);
            this.Controls.Add(this.ClouseSettings);
            this.Controls.Add(this.SaveSettings);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки";
            this.Load += new System.EventHandler(this.Settings_Load);
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
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox VaultsComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ConnectionStrToDBTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox DXFPath_txt;
        private System.Windows.Forms.Button FolderDXF;
        private System.Windows.Forms.Button SaveSettings;
        private System.Windows.Forms.Button ClouseSettings;
        private System.Windows.Forms.ComboBox BOMcomboBox;
    }
}