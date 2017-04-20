namespace VR_Manager
{
    partial class FormVrManager
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonSwitchBoxMode = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxBoxSwitch = new System.Windows.Forms.TextBox();
            this.buttonBoxPath = new System.Windows.Forms.Button();
            this.folderBrowserDialogBoxSwitch = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBoxSoundSwitcher = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBoxSoundSwitcher.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkGray;
            this.groupBox1.Controls.Add(this.buttonSwitchBoxMode);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxBoxSwitch);
            this.groupBox1.Controls.Add(this.buttonBoxPath);
            this.groupBox1.Location = new System.Drawing.Point(55, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(690, 215);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Box-Switch";
            // 
            // buttonSwitchBoxMode
            // 
            this.buttonSwitchBoxMode.Location = new System.Drawing.Point(443, 136);
            this.buttonSwitchBoxMode.Name = "buttonSwitchBoxMode";
            this.buttonSwitchBoxMode.Size = new System.Drawing.Size(163, 32);
            this.buttonSwitchBoxMode.TabIndex = 3;
            this.buttonSwitchBoxMode.Text = "Switch Box-Mode";
            this.buttonSwitchBoxMode.UseVisualStyleBackColor = true;
            this.buttonSwitchBoxMode.Click += new System.EventHandler(this.buttonSwitchBoxMode_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ordner auswählen:";
            // 
            // textBoxBoxSwitch
            // 
            this.textBoxBoxSwitch.Location = new System.Drawing.Point(185, 61);
            this.textBoxBoxSwitch.Name = "textBoxBoxSwitch";
            this.textBoxBoxSwitch.Size = new System.Drawing.Size(214, 29);
            this.textBoxBoxSwitch.TabIndex = 1;
            // 
            // buttonBoxPath
            // 
            this.buttonBoxPath.Location = new System.Drawing.Point(443, 58);
            this.buttonBoxPath.Name = "buttonBoxPath";
            this.buttonBoxPath.Size = new System.Drawing.Size(163, 32);
            this.buttonBoxPath.TabIndex = 0;
            this.buttonBoxPath.Text = "Ordner Auswählen";
            this.buttonBoxPath.UseVisualStyleBackColor = true;
            this.buttonBoxPath.Click += new System.EventHandler(this.buttonBoxPath_Click);
            // 
            // groupBoxSoundSwitcher
            // 
            this.groupBoxSoundSwitcher.BackColor = System.Drawing.Color.DarkGray;
            this.groupBoxSoundSwitcher.Controls.Add(this.richTextBox1);
            this.groupBoxSoundSwitcher.Location = new System.Drawing.Point(55, 309);
            this.groupBoxSoundSwitcher.Name = "groupBoxSoundSwitcher";
            this.groupBoxSoundSwitcher.Size = new System.Drawing.Size(690, 361);
            this.groupBoxSoundSwitcher.TabIndex = 4;
            this.groupBoxSoundSwitcher.TabStop = false;
            this.groupBoxSoundSwitcher.Text = "Sound-Switcher";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(30, 44);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(576, 254);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // FormVrManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1254, 892);
            this.Controls.Add(this.groupBoxSoundSwitcher);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormVrManager";
            this.Text = "VR-Manager";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxSoundSwitcher.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxBoxSwitch;
        private System.Windows.Forms.Button buttonBoxPath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogBoxSwitch;
        private System.Windows.Forms.Button buttonSwitchBoxMode;
        private System.Windows.Forms.GroupBox groupBoxSoundSwitcher;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

