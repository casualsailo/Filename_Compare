namespace Filename_Compare
{
    partial class Form1
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
            this.textBox_source = new System.Windows.Forms.TextBox();
            this.textBox_target = new System.Windows.Forms.TextBox();
            this.label_source = new System.Windows.Forms.Label();
            this.label_target = new System.Windows.Forms.Label();
            this.button_source = new System.Windows.Forms.Button();
            this.button_target = new System.Windows.Forms.Button();
            this.button_compare = new System.Windows.Forms.Button();
            this.label_output = new System.Windows.Forms.Label();
            this.textBox_output = new System.Windows.Forms.TextBox();
            this.label_output_directory = new System.Windows.Forms.Label();
            this.folderBrowser_source = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowser_destination = new System.Windows.Forms.FolderBrowserDialog();
            this.checkBox_subfolder = new System.Windows.Forms.CheckBox();
            this.checkBox_IgnoreSourceExt = new System.Windows.Forms.CheckBox();
            this.checkBox_IgnoreTargetExt = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutFilenameCompareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_source
            // 
            this.textBox_source.Location = new System.Drawing.Point(10, 55);
            this.textBox_source.Name = "textBox_source";
            this.textBox_source.Size = new System.Drawing.Size(320, 20);
            this.textBox_source.TabIndex = 0;
            // 
            // textBox_target
            // 
            this.textBox_target.Location = new System.Drawing.Point(10, 105);
            this.textBox_target.Name = "textBox_target";
            this.textBox_target.Size = new System.Drawing.Size(320, 20);
            this.textBox_target.TabIndex = 1;
            // 
            // label_source
            // 
            this.label_source.AutoSize = true;
            this.label_source.Location = new System.Drawing.Point(10, 40);
            this.label_source.Name = "label_source";
            this.label_source.Size = new System.Drawing.Size(89, 13);
            this.label_source.TabIndex = 2;
            this.label_source.Text = "Source Directory:";
            // 
            // label_target
            // 
            this.label_target.AutoSize = true;
            this.label_target.Location = new System.Drawing.Point(10, 90);
            this.label_target.Name = "label_target";
            this.label_target.Size = new System.Drawing.Size(86, 13);
            this.label_target.TabIndex = 3;
            this.label_target.Text = "Target Directory:";
            // 
            // button_source
            // 
            this.button_source.Location = new System.Drawing.Point(280, 35);
            this.button_source.Name = "button_source";
            this.button_source.Size = new System.Drawing.Size(50, 20);
            this.button_source.TabIndex = 4;
            this.button_source.Text = "Browse";
            this.button_source.UseVisualStyleBackColor = true;
            this.button_source.Click += new System.EventHandler(this.button_source_Click);
            // 
            // button_target
            // 
            this.button_target.Location = new System.Drawing.Point(280, 85);
            this.button_target.Name = "button_target";
            this.button_target.Size = new System.Drawing.Size(50, 20);
            this.button_target.TabIndex = 5;
            this.button_target.Text = "Browse";
            this.button_target.UseVisualStyleBackColor = true;
            this.button_target.Click += new System.EventHandler(this.button_destination_Click);
            // 
            // button_compare
            // 
            this.button_compare.Location = new System.Drawing.Point(5, 240);
            this.button_compare.Name = "button_compare";
            this.button_compare.Size = new System.Drawing.Size(325, 25);
            this.button_compare.TabIndex = 6;
            this.button_compare.Text = "Compare";
            this.button_compare.UseVisualStyleBackColor = true;
            this.button_compare.Click += new System.EventHandler(this.button_compare_Click);
            // 
            // label_output
            // 
            this.label_output.AutoSize = true;
            this.label_output.Location = new System.Drawing.Point(10, 195);
            this.label_output.Name = "label_output";
            this.label_output.Size = new System.Drawing.Size(87, 13);
            this.label_output.TabIndex = 7;
            this.label_output.Text = "Output Directory:";
            // 
            // textBox_output
            // 
            this.textBox_output.Location = new System.Drawing.Point(65, 210);
            this.textBox_output.Name = "textBox_output";
            this.textBox_output.Size = new System.Drawing.Size(265, 20);
            this.textBox_output.TabIndex = 8;
            this.textBox_output.Text = "Missing_Files";
            // 
            // label_output_directory
            // 
            this.label_output_directory.AutoSize = true;
            this.label_output_directory.Location = new System.Drawing.Point(10, 214);
            this.label_output_directory.Name = "label_output_directory";
            this.label_output_directory.Size = new System.Drawing.Size(54, 13);
            this.label_output_directory.TabIndex = 9;
            this.label_output_directory.Text = "C:\\Temp\\";
            // 
            // checkBox_subfolder
            // 
            this.checkBox_subfolder.AutoSize = true;
            this.checkBox_subfolder.Location = new System.Drawing.Point(10, 135);
            this.checkBox_subfolder.Name = "checkBox_subfolder";
            this.checkBox_subfolder.Size = new System.Drawing.Size(96, 17);
            this.checkBox_subfolder.TabIndex = 10;
            this.checkBox_subfolder.Text = "Use subfolders";
            this.checkBox_subfolder.UseVisualStyleBackColor = true;
            // 
            // checkBox_IgnoreSourceExt
            // 
            this.checkBox_IgnoreSourceExt.AutoSize = true;
            this.checkBox_IgnoreSourceExt.Location = new System.Drawing.Point(10, 155);
            this.checkBox_IgnoreSourceExt.Name = "checkBox_IgnoreSourceExt";
            this.checkBox_IgnoreSourceExt.Size = new System.Drawing.Size(144, 17);
            this.checkBox_IgnoreSourceExt.TabIndex = 11;
            this.checkBox_IgnoreSourceExt.Text = "Ignore source extensions";
            this.checkBox_IgnoreSourceExt.UseVisualStyleBackColor = true;
            // 
            // checkBox_IgnoreTargetExt
            // 
            this.checkBox_IgnoreTargetExt.AutoSize = true;
            this.checkBox_IgnoreTargetExt.Location = new System.Drawing.Point(155, 155);
            this.checkBox_IgnoreTargetExt.Name = "checkBox_IgnoreTargetExt";
            this.checkBox_IgnoreTargetExt.Size = new System.Drawing.Size(139, 17);
            this.checkBox_IgnoreTargetExt.TabIndex = 12;
            this.checkBox_IgnoreTargetExt.Text = "Ignore target extensions";
            this.checkBox_IgnoreTargetExt.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(334, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutFilenameCompareToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.aboutToolStripMenuItem.Text = "Help";
            // 
            // aboutFilenameCompareToolStripMenuItem
            // 
            this.aboutFilenameCompareToolStripMenuItem.Name = "aboutFilenameCompareToolStripMenuItem";
            this.aboutFilenameCompareToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.aboutFilenameCompareToolStripMenuItem.Text = "About Filename Compare";
            this.aboutFilenameCompareToolStripMenuItem.Click += new System.EventHandler(this.aboutFilenameCompareToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 271);
            this.Controls.Add(this.checkBox_IgnoreTargetExt);
            this.Controls.Add(this.checkBox_IgnoreSourceExt);
            this.Controls.Add(this.checkBox_subfolder);
            this.Controls.Add(this.label_output_directory);
            this.Controls.Add(this.textBox_output);
            this.Controls.Add(this.label_output);
            this.Controls.Add(this.button_compare);
            this.Controls.Add(this.button_target);
            this.Controls.Add(this.button_source);
            this.Controls.Add(this.label_target);
            this.Controls.Add(this.label_source);
            this.Controls.Add(this.textBox_target);
            this.Controls.Add(this.textBox_source);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filename Compare";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_source;
        private System.Windows.Forms.TextBox textBox_target;
        private System.Windows.Forms.Label label_source;
        private System.Windows.Forms.Label label_target;
        private System.Windows.Forms.Button button_source;
        private System.Windows.Forms.Button button_target;
        private System.Windows.Forms.Button button_compare;
        private System.Windows.Forms.Label label_output;
        private System.Windows.Forms.TextBox textBox_output;
        private System.Windows.Forms.Label label_output_directory;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser_source;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser_destination;
        private System.Windows.Forms.CheckBox checkBox_subfolder;
        private System.Windows.Forms.CheckBox checkBox_IgnoreSourceExt;
        private System.Windows.Forms.CheckBox checkBox_IgnoreTargetExt;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutFilenameCompareToolStripMenuItem;
    }
}

