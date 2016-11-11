namespace Filename_Compare
{
    partial class AboutWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutWindow));
            this.programNameTextBox = new System.Windows.Forms.Label();
            this.authorTextBox = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.changeLogLabel = new System.Windows.Forms.Label();
            this.changeLog = new System.Windows.Forms.TextBox();
            this.versionTextBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // programNameTextBox
            // 
            this.programNameTextBox.AutoSize = true;
            this.programNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.programNameTextBox.Location = new System.Drawing.Point(12, 12);
            this.programNameTextBox.Name = "programNameTextBox";
            this.programNameTextBox.Size = new System.Drawing.Size(147, 15);
            this.programNameTextBox.TabIndex = 0;
            this.programNameTextBox.Text = "Filename Compare 32-bit";
            // 
            // authorTextBox
            // 
            this.authorTextBox.AutoSize = true;
            this.authorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.authorTextBox.Location = new System.Drawing.Point(12, 42);
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(77, 15);
            this.authorTextBox.TabIndex = 2;
            this.authorTextBox.Text = "Darrick Teng";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Location = new System.Drawing.Point(12, 57);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(315, 60);
            this.descriptionLabel.TabIndex = 4;
            this.descriptionLabel.Text = resources.GetString("descriptionLabel.Text");
            this.descriptionLabel.UseMnemonic = false;
            // 
            // changeLogLabel
            // 
            this.changeLogLabel.AutoSize = true;
            this.changeLogLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLogLabel.Location = new System.Drawing.Point(12, 118);
            this.changeLogLabel.Name = "changeLogLabel";
            this.changeLogLabel.Size = new System.Drawing.Size(101, 16);
            this.changeLogLabel.TabIndex = 5;
            this.changeLogLabel.Text = "CHANGELOG";
            // 
            // changeLog
            // 
            this.changeLog.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.changeLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.changeLog.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.changeLog.Location = new System.Drawing.Point(15, 137);
            this.changeLog.Multiline = true;
            this.changeLog.Name = "changeLog";
            this.changeLog.ReadOnly = true;
            this.changeLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.changeLog.Size = new System.Drawing.Size(315, 212);
            this.changeLog.TabIndex = 3;
            this.changeLog.KeyDown += new System.Windows.Forms.KeyEventHandler(this.changeLog_KeyDown);
            // 
            // versionTextBox
            // 
            this.versionTextBox.AutoSize = true;
            this.versionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.versionTextBox.Location = new System.Drawing.Point(12, 27);
            this.versionTextBox.Name = "versionTextBox";
            this.versionTextBox.Size = new System.Drawing.Size(81, 15);
            this.versionTextBox.TabIndex = 1;
            this.versionTextBox.Text = "Version: 1.1.3";
            // 
            // AboutWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 361);
            this.Controls.Add(this.changeLogLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.changeLog);
            this.Controls.Add(this.authorTextBox);
            this.Controls.Add(this.versionTextBox);
            this.Controls.Add(this.programNameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(360, 400);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(360, 400);
            this.Name = "AboutWindow";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About Filename Compare";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label programNameTextBox;
        private System.Windows.Forms.Label authorTextBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label changeLogLabel;
        private System.Windows.Forms.TextBox changeLog;
        private System.Windows.Forms.Label versionTextBox;
    }
}