namespace View
{
    partial class EnterForm
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
            this.EnterButton = new System.Windows.Forms.Button();
            this.DoctorRadioButton = new System.Windows.Forms.RadioButton();
            this.MedRegistratorRadioButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // EnterButton
            // 
            this.EnterButton.Location = new System.Drawing.Point(330, 295);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(140, 49);
            this.EnterButton.TabIndex = 7;
            this.EnterButton.Text = "Enter";
            this.EnterButton.UseVisualStyleBackColor = true;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // DoctorRadioButton
            // 
            this.DoctorRadioButton.AutoSize = true;
            this.DoctorRadioButton.Location = new System.Drawing.Point(357, 223);
            this.DoctorRadioButton.Name = "DoctorRadioButton";
            this.DoctorRadioButton.Size = new System.Drawing.Size(57, 17);
            this.DoctorRadioButton.TabIndex = 13;
            this.DoctorRadioButton.TabStop = true;
            this.DoctorRadioButton.Text = "Doctor";
            this.DoctorRadioButton.UseVisualStyleBackColor = true;
            this.DoctorRadioButton.CheckedChanged += new System.EventHandler(this.EnterChoiseRadioButtons_CheckedChanged);
            // 
            // MedRegistratorRadioButton
            // 
            this.MedRegistratorRadioButton.AutoSize = true;
            this.MedRegistratorRadioButton.Location = new System.Drawing.Point(357, 192);
            this.MedRegistratorRadioButton.Name = "MedRegistratorRadioButton";
            this.MedRegistratorRadioButton.Size = new System.Drawing.Size(97, 17);
            this.MedRegistratorRadioButton.TabIndex = 12;
            this.MedRegistratorRadioButton.TabStop = true;
            this.MedRegistratorRadioButton.Text = "MedRegistrator";
            this.MedRegistratorRadioButton.UseVisualStyleBackColor = true;
            this.MedRegistratorRadioButton.CheckedChanged += new System.EventHandler(this.EnterChoiseRadioButtons_CheckedChanged);
            // 
            // EnterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 549);
            this.Controls.Add(this.DoctorRadioButton);
            this.Controls.Add(this.MedRegistratorRadioButton);
            this.Controls.Add(this.EnterButton);
            this.Name = "EnterForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EnterButton;
        private System.Windows.Forms.RadioButton DoctorRadioButton;
        private System.Windows.Forms.RadioButton MedRegistratorRadioButton;
    }
}

