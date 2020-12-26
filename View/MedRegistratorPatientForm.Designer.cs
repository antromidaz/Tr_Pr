namespace View
{
    partial class MedRegistratorPatientForm
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
            this.middlenameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.runRadioButton = new System.Windows.Forms.RadioButton();
            this.walkRadioButton = new System.Windows.Forms.RadioButton();
            this.strengthRadioButton = new System.Windows.Forms.RadioButton();
            this.saveSureveyButton = new System.Windows.Forms.Button();
            this.createSurveyButton = new System.Windows.Forms.Button();
            this.deleteSurveyButton = new System.Windows.Forms.Button();
            this.indicatorBloodPressureCheckBox = new System.Windows.Forms.CheckBox();
            this.indicatorSkinTemperatureCheckBox = new System.Windows.Forms.CheckBox();
            this.indicatorSkinHumidityCheckBox = new System.Windows.Forms.CheckBox();
            this.indicatorHeartRateCheckBox = new System.Windows.Forms.CheckBox();
            this.indicatorSkinElectricalConductivityCheckBox = new System.Windows.Forms.CheckBox();
            this.surveysDataGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.surveysDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // middlenameTextBox
            // 
            this.middlenameTextBox.Location = new System.Drawing.Point(155, 102);
            this.middlenameTextBox.Name = "middlenameTextBox";
            this.middlenameTextBox.Size = new System.Drawing.Size(100, 20);
            this.middlenameTextBox.TabIndex = 13;
            this.middlenameTextBox.TextChanged += new System.EventHandler(this.middlenameTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Midlname (Отчество)";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(155, 76);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 11;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Location = new System.Drawing.Point(155, 51);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.surnameTextBox.TabIndex = 10;
            this.surnameTextBox.TextChanged += new System.EventHandler(this.surnameTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Name (Имя)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Surname (Фамилия)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Current Surveys ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Type";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 328);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Indicators";
            // 
            // dateTextBox
            // 
            this.dateTextBox.Location = new System.Drawing.Point(80, 272);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(100, 20);
            this.dateTextBox.TabIndex = 19;
            this.dateTextBox.TextChanged += new System.EventHandler(this.dateTextBox_TextChanged);
            // 
            // runRadioButton
            // 
            this.runRadioButton.AutoSize = true;
            this.runRadioButton.Location = new System.Drawing.Point(80, 301);
            this.runRadioButton.Name = "runRadioButton";
            this.runRadioButton.Size = new System.Drawing.Size(45, 17);
            this.runRadioButton.TabIndex = 20;
            this.runRadioButton.TabStop = true;
            this.runRadioButton.Text = "Run";
            this.runRadioButton.UseVisualStyleBackColor = true;
            this.runRadioButton.CheckedChanged += new System.EventHandler(this.surveyTypeRadioButton_Checked);
            // 
            // walkRadioButton
            // 
            this.walkRadioButton.AutoSize = true;
            this.walkRadioButton.Location = new System.Drawing.Point(131, 301);
            this.walkRadioButton.Name = "walkRadioButton";
            this.walkRadioButton.Size = new System.Drawing.Size(50, 17);
            this.walkRadioButton.TabIndex = 21;
            this.walkRadioButton.TabStop = true;
            this.walkRadioButton.Text = "Walk";
            this.walkRadioButton.UseVisualStyleBackColor = true;
            this.walkRadioButton.CheckedChanged += new System.EventHandler(this.surveyTypeRadioButton_Checked);
            // 
            // strengthRadioButton
            // 
            this.strengthRadioButton.AutoSize = true;
            this.strengthRadioButton.Location = new System.Drawing.Point(187, 301);
            this.strengthRadioButton.Name = "strengthRadioButton";
            this.strengthRadioButton.Size = new System.Drawing.Size(62, 17);
            this.strengthRadioButton.TabIndex = 22;
            this.strengthRadioButton.TabStop = true;
            this.strengthRadioButton.Text = "Strengh";
            this.strengthRadioButton.UseVisualStyleBackColor = true;
            this.strengthRadioButton.CheckedChanged += new System.EventHandler(this.surveyTypeRadioButton_Checked);
            // 
            // saveSureveyButton
            // 
            this.saveSureveyButton.Location = new System.Drawing.Point(30, 391);
            this.saveSureveyButton.Name = "saveSureveyButton";
            this.saveSureveyButton.Size = new System.Drawing.Size(75, 23);
            this.saveSureveyButton.TabIndex = 28;
            this.saveSureveyButton.Text = "Save survey";
            this.saveSureveyButton.UseVisualStyleBackColor = true;
            this.saveSureveyButton.Click += new System.EventHandler(this.saveSureveyButton_Click);
            // 
            // createSurveyButton
            // 
            this.createSurveyButton.Location = new System.Drawing.Point(121, 391);
            this.createSurveyButton.Name = "createSurveyButton";
            this.createSurveyButton.Size = new System.Drawing.Size(116, 23);
            this.createSurveyButton.TabIndex = 29;
            this.createSurveyButton.Text = "Create new survey";
            this.createSurveyButton.UseVisualStyleBackColor = true;
            this.createSurveyButton.Click += new System.EventHandler(this.createSurveyButton_Click);
            // 
            // deleteSurveyButton
            // 
            this.deleteSurveyButton.Location = new System.Drawing.Point(259, 390);
            this.deleteSurveyButton.Name = "deleteSurveyButton";
            this.deleteSurveyButton.Size = new System.Drawing.Size(117, 23);
            this.deleteSurveyButton.TabIndex = 30;
            this.deleteSurveyButton.Text = "Delete this survey";
            this.deleteSurveyButton.UseVisualStyleBackColor = true;
            this.deleteSurveyButton.Click += new System.EventHandler(this.deleteSurveyButton_Click);
            // 
            // indicatorBloodPressureCheckBox
            // 
            this.indicatorBloodPressureCheckBox.AutoSize = true;
            this.indicatorBloodPressureCheckBox.Location = new System.Drawing.Point(80, 328);
            this.indicatorBloodPressureCheckBox.Name = "indicatorBloodPressureCheckBox";
            this.indicatorBloodPressureCheckBox.Size = new System.Drawing.Size(97, 17);
            this.indicatorBloodPressureCheckBox.TabIndex = 32;
            this.indicatorBloodPressureCheckBox.Text = "Blood Pressure";
            this.indicatorBloodPressureCheckBox.UseVisualStyleBackColor = true;
            this.indicatorBloodPressureCheckBox.Click += new System.EventHandler(this.indicatorBloodPressureCheckBox_Click);
            // 
            // indicatorSkinTemperatureCheckBox
            // 
            this.indicatorSkinTemperatureCheckBox.AutoSize = true;
            this.indicatorSkinTemperatureCheckBox.Location = new System.Drawing.Point(183, 328);
            this.indicatorSkinTemperatureCheckBox.Name = "indicatorSkinTemperatureCheckBox";
            this.indicatorSkinTemperatureCheckBox.Size = new System.Drawing.Size(113, 17);
            this.indicatorSkinTemperatureCheckBox.TabIndex = 33;
            this.indicatorSkinTemperatureCheckBox.Text = "Skin\'s temperature";
            this.indicatorSkinTemperatureCheckBox.UseVisualStyleBackColor = true;
            this.indicatorSkinTemperatureCheckBox.Click += new System.EventHandler(this.indicatorSkinTemperatureCheckBox_Click);
            // 
            // indicatorSkinHumidityCheckBox
            // 
            this.indicatorSkinHumidityCheckBox.AutoSize = true;
            this.indicatorSkinHumidityCheckBox.Location = new System.Drawing.Point(302, 328);
            this.indicatorSkinHumidityCheckBox.Name = "indicatorSkinHumidityCheckBox";
            this.indicatorSkinHumidityCheckBox.Size = new System.Drawing.Size(95, 17);
            this.indicatorSkinHumidityCheckBox.TabIndex = 34;
            this.indicatorSkinHumidityCheckBox.Text = "Skin\'s humidity";
            this.indicatorSkinHumidityCheckBox.UseVisualStyleBackColor = true;
            this.indicatorSkinHumidityCheckBox.Click += new System.EventHandler(this.indicatorSkinHumidityCheckBox_Click);
            // 
            // indicatorHeartRateCheckBox
            // 
            this.indicatorHeartRateCheckBox.AutoSize = true;
            this.indicatorHeartRateCheckBox.Location = new System.Drawing.Point(403, 328);
            this.indicatorHeartRateCheckBox.Name = "indicatorHeartRateCheckBox";
            this.indicatorHeartRateCheckBox.Size = new System.Drawing.Size(73, 17);
            this.indicatorHeartRateCheckBox.TabIndex = 35;
            this.indicatorHeartRateCheckBox.Text = "Heart rate";
            this.indicatorHeartRateCheckBox.UseVisualStyleBackColor = true;
            this.indicatorHeartRateCheckBox.Click += new System.EventHandler(this.indicatorHeartRateCheckBox_Click);
            // 
            // indicatorSkinElectricalConductivityCheckBox
            // 
            this.indicatorSkinElectricalConductivityCheckBox.AutoSize = true;
            this.indicatorSkinElectricalConductivityCheckBox.Location = new System.Drawing.Point(482, 328);
            this.indicatorSkinElectricalConductivityCheckBox.Name = "indicatorSkinElectricalConductivityCheckBox";
            this.indicatorSkinElectricalConductivityCheckBox.Size = new System.Drawing.Size(159, 17);
            this.indicatorSkinElectricalConductivityCheckBox.TabIndex = 36;
            this.indicatorSkinElectricalConductivityCheckBox.Text = "Skin\'s electrical conductivity";
            this.indicatorSkinElectricalConductivityCheckBox.UseVisualStyleBackColor = true;
            this.indicatorSkinElectricalConductivityCheckBox.Click += new System.EventHandler(this.indicatorSkinElectrincalConductivityCheckBox_Click);
            // 
            // surveysDataGridView
            // 
            this.surveysDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.surveysDataGridView.Location = new System.Drawing.Point(27, 171);
            this.surveysDataGridView.Name = "surveysDataGridView";
            this.surveysDataGridView.ReadOnly = true;
            this.surveysDataGridView.Size = new System.Drawing.Size(509, 95);
            this.surveysDataGridView.TabIndex = 37;
            this.surveysDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.surveysGridView_CellClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(739, 24);
            this.menuStrip1.TabIndex = 38;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click_1);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // MedRegistratorPatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 531);
            this.Controls.Add(this.surveysDataGridView);
            this.Controls.Add(this.indicatorSkinElectricalConductivityCheckBox);
            this.Controls.Add(this.indicatorHeartRateCheckBox);
            this.Controls.Add(this.indicatorSkinHumidityCheckBox);
            this.Controls.Add(this.indicatorSkinTemperatureCheckBox);
            this.Controls.Add(this.indicatorBloodPressureCheckBox);
            this.Controls.Add(this.deleteSurveyButton);
            this.Controls.Add(this.createSurveyButton);
            this.Controls.Add(this.saveSureveyButton);
            this.Controls.Add(this.strengthRadioButton);
            this.Controls.Add(this.walkRadioButton);
            this.Controls.Add(this.runRadioButton);
            this.Controls.Add(this.dateTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.middlenameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MedRegistratorPatientForm";
            this.Text = "MedRegistratorPatientForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MedRegistratorPatientForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.surveysDataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox middlenameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.RadioButton runRadioButton;
        private System.Windows.Forms.RadioButton walkRadioButton;
        private System.Windows.Forms.RadioButton strengthRadioButton;
        private System.Windows.Forms.Button saveSureveyButton;
        private System.Windows.Forms.Button createSurveyButton;
        private System.Windows.Forms.Button deleteSurveyButton;
        private System.Windows.Forms.CheckBox indicatorBloodPressureCheckBox;
        private System.Windows.Forms.CheckBox indicatorSkinTemperatureCheckBox;
        private System.Windows.Forms.CheckBox indicatorSkinHumidityCheckBox;
        private System.Windows.Forms.CheckBox indicatorHeartRateCheckBox;
        private System.Windows.Forms.CheckBox indicatorSkinElectricalConductivityCheckBox;
        private System.Windows.Forms.DataGridView surveysDataGridView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}