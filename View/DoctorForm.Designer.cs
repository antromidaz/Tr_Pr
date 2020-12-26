namespace View
{
    partial class DoctorForm
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
            this.patientsDataGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.patientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllPatientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientNameLabel = new System.Windows.Forms.Label();
            this.choosePatientButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.patientsDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // patientsDataGridView
            // 
            this.patientsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientsDataGridView.Location = new System.Drawing.Point(12, 49);
            this.patientsDataGridView.Name = "patientsDataGridView";
            this.patientsDataGridView.ReadOnly = true;
            this.patientsDataGridView.Size = new System.Drawing.Size(621, 340);
            this.patientsDataGridView.TabIndex = 3;
            this.patientsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.patientsDataGridView_CellClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.patientsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(794, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // patientsToolStripMenuItem
            // 
            this.patientsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showAllPatientsToolStripMenuItem});
            this.patientsToolStripMenuItem.Name = "patientsToolStripMenuItem";
            this.patientsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.patientsToolStripMenuItem.Text = "Patients";
            // 
            // showAllPatientsToolStripMenuItem
            // 
            this.showAllPatientsToolStripMenuItem.Name = "showAllPatientsToolStripMenuItem";
            this.showAllPatientsToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.showAllPatientsToolStripMenuItem.Text = "Show all patients (update)";
            this.showAllPatientsToolStripMenuItem.Click += new System.EventHandler(this.showAllPatientsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // patientNameLabel
            // 
            this.patientNameLabel.AutoSize = true;
            this.patientNameLabel.Location = new System.Drawing.Point(12, 400);
            this.patientNameLabel.Name = "patientNameLabel";
            this.patientNameLabel.Size = new System.Drawing.Size(64, 13);
            this.patientNameLabel.TabIndex = 6;
            this.patientNameLabel.Text = "Not choiesd";
            // 
            // choosePatientButton
            // 
            this.choosePatientButton.Location = new System.Drawing.Point(12, 431);
            this.choosePatientButton.Name = "choosePatientButton";
            this.choosePatientButton.Size = new System.Drawing.Size(121, 23);
            this.choosePatientButton.TabIndex = 5;
            this.choosePatientButton.Text = "Choose this patient";
            this.choosePatientButton.UseVisualStyleBackColor = true;
            this.choosePatientButton.Click += new System.EventHandler(this.choosePatientButton_Click);
            // 
            // DoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 522);
            this.Controls.Add(this.patientNameLabel);
            this.Controls.Add(this.choosePatientButton);
            this.Controls.Add(this.patientsDataGridView);
            this.Controls.Add(this.menuStrip1);
            this.Name = "DoctorForm";
            this.Text = "DoctorForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DoctorForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.patientsDataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView patientsDataGridView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem patientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAllPatientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label patientNameLabel;
        private System.Windows.Forms.Button choosePatientButton;

    }
}