﻿namespace CorporateClash.Forms
{
    partial class FrmOptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOptions));
            this.grpOptions = new System.Windows.Forms.GroupBox();
            this.chkSavePassword = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.chkRandomBackgrounds = new System.Windows.Forms.CheckBox();
            this.chkClickSounds = new System.Windows.Forms.CheckBox();
            this.chkCursor = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.grpOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpOptions
            // 
            this.grpOptions.Controls.Add(this.chkSavePassword);
            this.grpOptions.Controls.Add(this.button1);
            this.grpOptions.Controls.Add(this.chkRandomBackgrounds);
            this.grpOptions.Controls.Add(this.chkClickSounds);
            this.grpOptions.Controls.Add(this.chkCursor);
            this.grpOptions.ForeColor = System.Drawing.Color.White;
            this.grpOptions.Location = new System.Drawing.Point(12, 12);
            this.grpOptions.Name = "grpOptions";
            this.grpOptions.Size = new System.Drawing.Size(304, 162);
            this.grpOptions.TabIndex = 0;
            this.grpOptions.TabStop = false;
            this.grpOptions.Text = "Options";
            // 
            // chkSavePassword
            // 
            this.chkSavePassword.AutoSize = true;
            this.chkSavePassword.Location = new System.Drawing.Point(6, 88);
            this.chkSavePassword.Name = "chkSavePassword";
            this.chkSavePassword.Size = new System.Drawing.Size(167, 17);
            this.chkSavePassword.TabIndex = 6;
            this.chkSavePassword.Text = "Save password (Windows 10)";
            this.chkSavePassword.UseVisualStyleBackColor = true;
            this.chkSavePassword.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(219, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Logs Folder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chkRandomBackgrounds
            // 
            this.chkRandomBackgrounds.AutoSize = true;
            this.chkRandomBackgrounds.Location = new System.Drawing.Point(6, 65);
            this.chkRandomBackgrounds.Name = "chkRandomBackgrounds";
            this.chkRandomBackgrounds.Size = new System.Drawing.Size(162, 17);
            this.chkRandomBackgrounds.TabIndex = 4;
            this.chkRandomBackgrounds.Text = "Enable random backgrounds";
            this.chkRandomBackgrounds.UseVisualStyleBackColor = true;
            // 
            // chkClickSounds
            // 
            this.chkClickSounds.AutoSize = true;
            this.chkClickSounds.Location = new System.Drawing.Point(6, 42);
            this.chkClickSounds.Name = "chkClickSounds";
            this.chkClickSounds.Size = new System.Drawing.Size(124, 17);
            this.chkClickSounds.TabIndex = 3;
            this.chkClickSounds.Text = "Enable Click Sounds";
            this.chkClickSounds.UseVisualStyleBackColor = true;
            // 
            // chkCursor
            // 
            this.chkCursor.AutoSize = true;
            this.chkCursor.Location = new System.Drawing.Point(6, 19);
            this.chkCursor.Name = "chkCursor";
            this.chkCursor.Size = new System.Drawing.Size(109, 17);
            this.chkCursor.TabIndex = 1;
            this.chkCursor.Text = "Enable TT Cursor";
            this.chkCursor.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LightGray;
            this.btnCancel.Location = new System.Drawing.Point(18, 180);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.LightGray;
            this.btnConfirm.Location = new System.Drawing.Point(231, 180);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 4;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // FrmOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(328, 214);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.grpOptions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options";
            this.Load += new System.EventHandler(this.Options_Load);
            this.grpOptions.ResumeLayout(false);
            this.grpOptions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpOptions;
        private System.Windows.Forms.CheckBox chkCursor;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.CheckBox chkClickSounds;
        private System.Windows.Forms.CheckBox chkRandomBackgrounds;
		private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox chkSavePassword;
    }
}