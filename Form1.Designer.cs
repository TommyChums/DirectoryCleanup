namespace WindowsFormsApp1
{
    partial class SubDirectoryForm
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
            this.directorySelector = new System.Windows.Forms.Button();
            this.startCleanup = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.selectedLocation = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // directorySelector
            // 
            this.directorySelector.Location = new System.Drawing.Point(516, 11);
            this.directorySelector.Name = "directorySelector";
            this.directorySelector.Size = new System.Drawing.Size(75, 23);
            this.directorySelector.TabIndex = 0;
            this.directorySelector.Text = "Folder";
            this.directorySelector.UseVisualStyleBackColor = true;
            this.directorySelector.Click += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // startCleanup
            // 
            this.startCleanup.Location = new System.Drawing.Point(516, 186);
            this.startCleanup.Name = "startCleanup";
            this.startCleanup.Size = new System.Drawing.Size(75, 23);
            this.startCleanup.TabIndex = 2;
            this.startCleanup.Text = "Start";
            this.startCleanup.UseVisualStyleBackColor = true;
            this.startCleanup.Click += new System.EventHandler(this.runCleanUp);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 40);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(498, 169);
            this.textBox1.TabIndex = 3;
            this.textBox1.Visible = false;
            this.textBox1.WordWrap = false;
            // 
            // selectedLocation
            // 
            this.selectedLocation.AllowDrop = true;
            this.selectedLocation.Enabled = false;
            this.selectedLocation.Location = new System.Drawing.Point(12, 13);
            this.selectedLocation.MinimumSize = new System.Drawing.Size(498, 20);
            this.selectedLocation.Multiline = true;
            this.selectedLocation.Name = "selectedLocation";
            this.selectedLocation.Size = new System.Drawing.Size(498, 20);
            this.selectedLocation.TabIndex = 1;
            // 
            // SubDirectoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 212);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.startCleanup);
            this.Controls.Add(this.selectedLocation);
            this.Controls.Add(this.directorySelector);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(617, 251);
            this.MinimumSize = new System.Drawing.Size(617, 251);
            this.Name = "SubDirectoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete Duplicate Directories";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button directorySelector;
        private System.Windows.Forms.Button startCleanup;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox selectedLocation;
    }
}

