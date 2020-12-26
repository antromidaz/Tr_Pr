namespace View
{
    partial class MedRegistratorForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.patientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllPatientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewPatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteThisPatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PatientsDataGridView = new System.Windows.Forms.DataGridView();
            this.chooseButton1 = new System.Windows.Forms.Button();
            this.PatientNameLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PatientsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.patientsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(793, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // patientsToolStripMenuItem
            // 
            this.patientsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showAllPatientsToolStripMenuItem,
            this.addNewPatientToolStripMenuItem,
            this.deleteThisPatientToolStripMenuItem});
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
            // addNewPatientToolStripMenuItem
            // 
            this.addNewPatientToolStripMenuItem.Name = "addNewPatientToolStripMenuItem";
            this.addNewPatientToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.addNewPatientToolStripMenuItem.Text = "Add new patient";
            this.addNewPatientToolStripMenuItem.Click += new System.EventHandler(this.addNewPatientToolStripMenuItem_Click);
            // 
            // deleteThisPatientToolStripMenuItem
            // 
            this.deleteThisPatientToolStripMenuItem.Name = "deleteThisPatientToolStripMenuItem";
            this.deleteThisPatientToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.deleteThisPatientToolStripMenuItem.Text = "Delete this patient";
            this.deleteThisPatientToolStripMenuItem.Click += new System.EventHandler(this.deleteThisPatientToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // PatientsDataGridView
            // 
            this.PatientsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PatientsDataGridView.Location = new System.Drawing.Point(22, 58);
            this.PatientsDataGridView.Name = "PatientsDataGridView";
            this.PatientsDataGridView.ReadOnly = true;
            this.PatientsDataGridView.Size = new System.Drawing.Size(621, 185);
            this.PatientsDataGridView.TabIndex = 0;
            this.PatientsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PatientsDataGridView_CellClick);
            // 
            // chooseButton1
            // 
            this.chooseButton1.Location = new System.Drawing.Point(22, 295);
            this.chooseButton1.Name = "chooseButton1";
            this.chooseButton1.Size = new System.Drawing.Size(121, 23);
            this.chooseButton1.TabIndex = 3;
            this.chooseButton1.Text = "Choose this patient";
            this.chooseButton1.UseVisualStyleBackColor = true;
            this.chooseButton1.Click += new System.EventHandler(this.chooseButton_Click);
            // 
            // PatientNameLabel
            // 
            this.PatientNameLabel.AutoSize = true;
            this.PatientNameLabel.Location = new System.Drawing.Point(22, 264);
            this.PatientNameLabel.Name = "PatientNameLabel";
            this.PatientNameLabel.Size = new System.Drawing.Size(64, 13);
            this.PatientNameLabel.TabIndex = 4;
            this.PatientNameLabel.Text = "Not choised";
            // 
            // MedRegistratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 527);
            this.Controls.Add(this.PatientNameLabel);
            this.Controls.Add(this.chooseButton1);
            this.Controls.Add(this.PatientsDataGridView);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MedRegistratorForm";
            this.Text = "MedRegistratorForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MedRegistratorForm_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PatientsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem patientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAllPatientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewPatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteThisPatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.DataGridView PatientsDataGridView;
        private System.Windows.Forms.Button chooseButton1;
        private System.Windows.Forms.Label PatientNameLabel;
    }
}