namespace View
{
    partial class DoctorPatientForm
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
            this.surveysDataGridView = new System.Windows.Forms.DataGridView();
            this.indicatorSkinElectricalConductivityCheckBox = new System.Windows.Forms.CheckBox();
            this.indicatorHeartRateCheckBox = new System.Windows.Forms.CheckBox();
            this.indicatorSkinHumidityCheckBox = new System.Windows.Forms.CheckBox();
            this.indicatorSkinTemperatureCheckBox = new System.Windows.Forms.CheckBox();
            this.indicatorBloodPressureCheckBox = new System.Windows.Forms.CheckBox();
            this.strengthRadioButton = new System.Windows.Forms.RadioButton();
            this.walkRadioButton = new System.Windows.Forms.RadioButton();
            this.runRadioButton = new System.Windows.Forms.RadioButton();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.middlenameTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.chooseSurveyButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.surveysDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // surveysDataGridView
            // 
            this.surveysDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.surveysDataGridView.Location = new System.Drawing.Point(26, 181);
            this.surveysDataGridView.Name = "surveysDataGridView";
            this.surveysDataGridView.ReadOnly = true;
            this.surveysDataGridView.Size = new System.Drawing.Size(509, 95);
            this.surveysDataGridView.TabIndex = 60;
            this.surveysDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.surveysDataGridView_CellClick);
            // 
            // indicatorSkinElectricalConductivityCheckBox
            // 
            this.indicatorSkinElectricalConductivityCheckBox.AutoSize = true;
            this.indicatorSkinElectricalConductivityCheckBox.Location = new System.Drawing.Point(487, 361);
            this.indicatorSkinElectricalConductivityCheckBox.Name = "indicatorSkinElectricalConductivityCheckBox";
            this.indicatorSkinElectricalConductivityCheckBox.Size = new System.Drawing.Size(159, 17);
            this.indicatorSkinElectricalConductivityCheckBox.TabIndex = 59;
            this.indicatorSkinElectricalConductivityCheckBox.Text = "Skin\'s electrical conductivity";
            this.indicatorSkinElectricalConductivityCheckBox.UseVisualStyleBackColor = true;
            // 
            // indicatorHeartRateCheckBox
            // 
            this.indicatorHeartRateCheckBox.AutoSize = true;
            this.indicatorHeartRateCheckBox.Location = new System.Drawing.Point(408, 361);
            this.indicatorHeartRateCheckBox.Name = "indicatorHeartRateCheckBox";
            this.indicatorHeartRateCheckBox.Size = new System.Drawing.Size(73, 17);
            this.indicatorHeartRateCheckBox.TabIndex = 58;
            this.indicatorHeartRateCheckBox.Text = "Heart rate";
            this.indicatorHeartRateCheckBox.UseVisualStyleBackColor = true;
            // 
            // indicatorSkinHumidityCheckBox
            // 
            this.indicatorSkinHumidityCheckBox.AutoSize = true;
            this.indicatorSkinHumidityCheckBox.Location = new System.Drawing.Point(307, 361);
            this.indicatorSkinHumidityCheckBox.Name = "indicatorSkinHumidityCheckBox";
            this.indicatorSkinHumidityCheckBox.Size = new System.Drawing.Size(95, 17);
            this.indicatorSkinHumidityCheckBox.TabIndex = 57;
            this.indicatorSkinHumidityCheckBox.Text = "Skin\'s humidity";
            this.indicatorSkinHumidityCheckBox.UseVisualStyleBackColor = true;
            // 
            // indicatorSkinTemperatureCheckBox
            // 
            this.indicatorSkinTemperatureCheckBox.AutoSize = true;
            this.indicatorSkinTemperatureCheckBox.Location = new System.Drawing.Point(188, 361);
            this.indicatorSkinTemperatureCheckBox.Name = "indicatorSkinTemperatureCheckBox";
            this.indicatorSkinTemperatureCheckBox.Size = new System.Drawing.Size(113, 17);
            this.indicatorSkinTemperatureCheckBox.TabIndex = 56;
            this.indicatorSkinTemperatureCheckBox.Text = "Skin\'s temperature";
            this.indicatorSkinTemperatureCheckBox.UseVisualStyleBackColor = true;
            // 
            // indicatorBloodPressureCheckBox
            // 
            this.indicatorBloodPressureCheckBox.AutoSize = true;
            this.indicatorBloodPressureCheckBox.Location = new System.Drawing.Point(85, 361);
            this.indicatorBloodPressureCheckBox.Name = "indicatorBloodPressureCheckBox";
            this.indicatorBloodPressureCheckBox.Size = new System.Drawing.Size(97, 17);
            this.indicatorBloodPressureCheckBox.TabIndex = 55;
            this.indicatorBloodPressureCheckBox.Text = "Blood Pressure";
            this.indicatorBloodPressureCheckBox.UseVisualStyleBackColor = true;
            // 
            // strengthRadioButton
            // 
            this.strengthRadioButton.AutoSize = true;
            this.strengthRadioButton.Location = new System.Drawing.Point(192, 334);
            this.strengthRadioButton.Name = "strengthRadioButton";
            this.strengthRadioButton.Size = new System.Drawing.Size(62, 17);
            this.strengthRadioButton.TabIndex = 51;
            this.strengthRadioButton.TabStop = true;
            this.strengthRadioButton.Text = "Strengh";
            this.strengthRadioButton.UseVisualStyleBackColor = true;
            // 
            // walkRadioButton
            // 
            this.walkRadioButton.AutoSize = true;
            this.walkRadioButton.Location = new System.Drawing.Point(136, 334);
            this.walkRadioButton.Name = "walkRadioButton";
            this.walkRadioButton.Size = new System.Drawing.Size(50, 17);
            this.walkRadioButton.TabIndex = 50;
            this.walkRadioButton.TabStop = true;
            this.walkRadioButton.Text = "Walk";
            this.walkRadioButton.UseVisualStyleBackColor = true;
            // 
            // runRadioButton
            // 
            this.runRadioButton.AutoSize = true;
            this.runRadioButton.Location = new System.Drawing.Point(85, 334);
            this.runRadioButton.Name = "runRadioButton";
            this.runRadioButton.Size = new System.Drawing.Size(45, 17);
            this.runRadioButton.TabIndex = 49;
            this.runRadioButton.TabStop = true;
            this.runRadioButton.Text = "Run";
            this.runRadioButton.UseVisualStyleBackColor = true;
            // 
            // dateTextBox
            // 
            this.dateTextBox.Location = new System.Drawing.Point(85, 305);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(100, 20);
            this.dateTextBox.TabIndex = 48;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 361);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 47;
            this.label7.Text = "Indicators";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 334);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 46;
            this.label6.Text = "Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Current Surveys ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Midlname (Отчество)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Name (Имя)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Surname (Фамилия)";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(749, 24);
            this.menuStrip1.TabIndex = 61;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // middlenameTextBox
            // 
            this.middlenameTextBox.Location = new System.Drawing.Point(160, 113);
            this.middlenameTextBox.Name = "middlenameTextBox";
            this.middlenameTextBox.Size = new System.Drawing.Size(100, 20);
            this.middlenameTextBox.TabIndex = 43;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(160, 81);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 41;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Location = new System.Drawing.Point(160, 51);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.surnameTextBox.TabIndex = 40;
            // 
            // chooseSurveyButton
            // 
            this.chooseSurveyButton.Location = new System.Drawing.Point(38, 416);
            this.chooseSurveyButton.Name = "chooseSurveyButton";
            this.chooseSurveyButton.Size = new System.Drawing.Size(131, 23);
            this.chooseSurveyButton.TabIndex = 66;
            this.chooseSurveyButton.Text = "Choose survey";
            this.chooseSurveyButton.UseVisualStyleBackColor = true;
            this.chooseSurveyButton.Click += new System.EventHandler(this.chooseSurveyButton_Click);
            // 
            // DoctorPatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 581);
            this.Controls.Add(this.chooseSurveyButton);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.surveysDataGridView);
            this.Controls.Add(this.indicatorSkinElectricalConductivityCheckBox);
            this.Controls.Add(this.indicatorHeartRateCheckBox);
            this.Controls.Add(this.indicatorSkinHumidityCheckBox);
            this.Controls.Add(this.indicatorSkinTemperatureCheckBox);
            this.Controls.Add(this.indicatorBloodPressureCheckBox);
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
            this.Name = "DoctorPatientForm";
            this.Text = "DoctorPatientForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DoctorPatientForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.surveysDataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView surveysDataGridView;
        private System.Windows.Forms.CheckBox indicatorSkinElectricalConductivityCheckBox;
        private System.Windows.Forms.CheckBox indicatorHeartRateCheckBox;
        private System.Windows.Forms.CheckBox indicatorSkinHumidityCheckBox;
        private System.Windows.Forms.CheckBox indicatorSkinTemperatureCheckBox;
        private System.Windows.Forms.CheckBox indicatorBloodPressureCheckBox;
        private System.Windows.Forms.RadioButton strengthRadioButton;
        private System.Windows.Forms.RadioButton walkRadioButton;
        private System.Windows.Forms.RadioButton runRadioButton;
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TextBox middlenameTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.Button chooseSurveyButton;
    }
}