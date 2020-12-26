namespace View
{
    partial class DoctorPatientSurveyForm
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
            this.startAndStopSurveyButton4 = new System.Windows.Forms.Button();
            this.sensorTypeComboBox = new System.Windows.Forms.ComboBox();
            this.sensorNameTextBox = new System.Windows.Forms.TextBox();
            this.activateSensorButton = new System.Windows.Forms.Button();
            this.addSensorButton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.deleteSensorButton = new System.Windows.Forms.Button();
            this.sensorConditionLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.sensorTypeLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sensorNameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sensorsDataGridView = new System.Windows.Forms.DataGridView();
            this.chartTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sensorsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // startAndStopSurveyButton4
            // 
            this.startAndStopSurveyButton4.Location = new System.Drawing.Point(340, 210);
            this.startAndStopSurveyButton4.Name = "startAndStopSurveyButton4";
            this.startAndStopSurveyButton4.Size = new System.Drawing.Size(229, 23);
            this.startAndStopSurveyButton4.TabIndex = 37;
            this.startAndStopSurveyButton4.Text = "Start/stop survey";
            this.startAndStopSurveyButton4.UseVisualStyleBackColor = true;
            this.startAndStopSurveyButton4.Click += new System.EventHandler(this.startAndStopSurveyButton_Click);
            // 
            // sensorTypeComboBox
            // 
            this.sensorTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sensorTypeComboBox.FormattingEnabled = true;
            this.sensorTypeComboBox.Location = new System.Drawing.Point(760, 73);
            this.sensorTypeComboBox.Name = "sensorTypeComboBox";
            this.sensorTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.sensorTypeComboBox.TabIndex = 36;
            // 
            // sensorNameTextBox
            // 
            this.sensorNameTextBox.Location = new System.Drawing.Point(760, 45);
            this.sensorNameTextBox.Name = "sensorNameTextBox";
            this.sensorNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.sensorNameTextBox.TabIndex = 35;
            // 
            // activateSensorButton
            // 
            this.activateSensorButton.Location = new System.Drawing.Point(484, 125);
            this.activateSensorButton.Name = "activateSensorButton";
            this.activateSensorButton.Size = new System.Drawing.Size(104, 23);
            this.activateSensorButton.TabIndex = 34;
            this.activateSensorButton.Text = "Activate";
            this.activateSensorButton.UseVisualStyleBackColor = true;
            this.activateSensorButton.Click += new System.EventHandler(this.activateSensorButton_Click);
            // 
            // addSensorButton
            // 
            this.addSensorButton.Location = new System.Drawing.Point(652, 112);
            this.addSensorButton.Name = "addSensorButton";
            this.addSensorButton.Size = new System.Drawing.Size(109, 23);
            this.addSensorButton.TabIndex = 33;
            this.addSensorButton.Text = "Add new sensor";
            this.addSensorButton.UseVisualStyleBackColor = true;
            this.addSensorButton.Click += new System.EventHandler(this.addSensorButton_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(652, 73);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "New sensor type";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(649, 45);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "New sensor name";
            // 
            // deleteSensorButton
            // 
            this.deleteSensorButton.Location = new System.Drawing.Point(484, 154);
            this.deleteSensorButton.Name = "deleteSensorButton";
            this.deleteSensorButton.Size = new System.Drawing.Size(104, 23);
            this.deleteSensorButton.TabIndex = 30;
            this.deleteSensorButton.Text = "Delete sensor";
            this.deleteSensorButton.UseVisualStyleBackColor = true;
            this.deleteSensorButton.Click += new System.EventHandler(this.deleteSensorButton_Click);
            // 
            // sensorConditionLabel
            // 
            this.sensorConditionLabel.AutoSize = true;
            this.sensorConditionLabel.Location = new System.Drawing.Point(576, 98);
            this.sensorConditionLabel.Name = "sensorConditionLabel";
            this.sensorConditionLabel.Size = new System.Drawing.Size(68, 13);
            this.sensorConditionLabel.TabIndex = 29;
            this.sensorConditionLabel.Text = "Not choosed";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(483, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Sensor condition";
            // 
            // sensorTypeLabel
            // 
            this.sensorTypeLabel.AutoSize = true;
            this.sensorTypeLabel.Location = new System.Drawing.Point(553, 71);
            this.sensorTypeLabel.Name = "sensorTypeLabel";
            this.sensorTypeLabel.Size = new System.Drawing.Size(68, 13);
            this.sensorTypeLabel.TabIndex = 27;
            this.sensorTypeLabel.Text = "Not choosed";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(483, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Sensor type";
            // 
            // sensorNameLabel
            // 
            this.sensorNameLabel.AutoSize = true;
            this.sensorNameLabel.Location = new System.Drawing.Point(555, 43);
            this.sensorNameLabel.Name = "sensorNameLabel";
            this.sensorNameLabel.Size = new System.Drawing.Size(68, 13);
            this.sensorNameLabel.TabIndex = 25;
            this.sensorNameLabel.Text = "Not choosed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(480, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Sensor name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Sensors";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(921, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // sensorsDataGridView
            // 
            this.sensorsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sensorsDataGridView.Location = new System.Drawing.Point(57, 54);
            this.sensorsDataGridView.Name = "sensorsDataGridView";
            this.sensorsDataGridView.ReadOnly = true;
            this.sensorsDataGridView.Size = new System.Drawing.Size(403, 150);
            this.sensorsDataGridView.TabIndex = 38;
            this.sensorsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sensorsDataGridView_CellClick);
            // 
            // chartTableLayoutPanel
            // 
            this.chartTableLayoutPanel.ColumnCount = 2;
            this.chartTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.chartTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.chartTableLayoutPanel.Location = new System.Drawing.Point(12, 239);
            this.chartTableLayoutPanel.Name = "chartTableLayoutPanel";
            this.chartTableLayoutPanel.RowCount = 3;
            this.chartTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.chartTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.chartTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 106F));
            this.chartTableLayoutPanel.Size = new System.Drawing.Size(897, 331);
            this.chartTableLayoutPanel.TabIndex = 41;
            // 
            // DoctorPatientSurveyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 637);
            this.Controls.Add(this.chartTableLayoutPanel);
            this.Controls.Add(this.sensorsDataGridView);
            this.Controls.Add(this.startAndStopSurveyButton4);
            this.Controls.Add(this.sensorTypeComboBox);
            this.Controls.Add(this.sensorNameTextBox);
            this.Controls.Add(this.activateSensorButton);
            this.Controls.Add(this.addSensorButton);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.deleteSensorButton);
            this.Controls.Add(this.sensorConditionLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.sensorTypeLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sensorNameLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "DoctorPatientSurveyForm";
            this.Text = "DoctorPatientSurveyForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DoctorPatientSurveyForm_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sensorsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startAndStopSurveyButton4;
        private System.Windows.Forms.ComboBox sensorTypeComboBox;
        private System.Windows.Forms.TextBox sensorNameTextBox;
        private System.Windows.Forms.Button activateSensorButton;
        private System.Windows.Forms.Button addSensorButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button deleteSensorButton;
        private System.Windows.Forms.Label sensorConditionLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label sensorTypeLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label sensorNameLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.DataGridView sensorsDataGridView;
        private System.Windows.Forms.TableLayoutPanel chartTableLayoutPanel;
    }
}