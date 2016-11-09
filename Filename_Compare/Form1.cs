using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Filename_Compare
{
    public partial class Form1 : Form
    {
        DialogResult result;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_source_Click(object sender, EventArgs e)
        {
            // put selected folder's path to source textbox
            result = folderBrowser_source.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBox_source.Text = folderBrowser_source.SelectedPath;
            }
        }

        private void button_destination_Click(object sender, EventArgs e)
        {
            // put selected folder's path to destination textbox
            result = folderBrowser_target.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBox_target.Text = folderBrowser_target.SelectedPath;
            }
        }

        private void button_compare_Click(object sender, EventArgs e)
        {
            string sourceDirectory = textBox_source.Text.Trim();
            string destinationDirectory = textBox_target.Text.Trim();
            string outputDirectory = "C:\\Temp\\" + textBox_output.Text.Trim();

            if (!Directory.Exists(sourceDirectory))
            {
                MessageBox.Show("Source folder does not exist!");
                return;
            }
            if (!Directory.Exists(destinationDirectory))
            {
                MessageBox.Show("Target folder does not exist!");
                return;
            }
            if (sourceDirectory == destinationDirectory)
            {
                MessageBox.Show("Source and target are the same!");
                return;
            }

            // grab all the filename in the source directory
            // grab all the filename in the destination directory
            // compare filename with/without file extension depending on checkbox
            string[] sourceFilePathEntries;
            string[] destinationFilePathEntries;
            if (checkBox_subfolder.Checked)
            {
                sourceFilePathEntries = Directory.GetFiles(sourceDirectory, "*", SearchOption.AllDirectories);
                destinationFilePathEntries = Directory.GetFiles(destinationDirectory, "*", SearchOption.AllDirectories);
            }
            else
            {
                sourceFilePathEntries = Directory.GetFiles(sourceDirectory, "*", SearchOption.TopDirectoryOnly);
                destinationFilePathEntries = Directory.GetFiles(destinationDirectory, "*", SearchOption.TopDirectoryOnly);
            }
            string[] sourceFileEntries;
            string[] destinationFileEntries;
            if (checkBox_IgnoreSourceExt.Checked)
            {
                sourceFileEntries = sourceFilePathEntries.Select(Path.GetFileNameWithoutExtension).ToArray();
            }
            else
            {
                sourceFileEntries = sourceFilePathEntries.Select(Path.GetFileName).ToArray();
            }

            if (checkBox_IgnoreTargetExt.Checked)
            {
                destinationFileEntries = destinationFilePathEntries.Select(Path.GetFileNameWithoutExtension).ToArray();
            }
            else
            {
                destinationFileEntries = destinationFilePathEntries.Select(Path.GetFileName).ToArray();
            }

            // place filename into dictionary as a key
            Dictionary<string, FileInfo> sourceEntries = new Dictionary<string, FileInfo>();
            for (int i = 0; i < sourceFileEntries.Length; i++)
            {
                if (!sourceEntries.ContainsKey(sourceFileEntries[i]))
                {
                    sourceEntries.Add(sourceFileEntries[i], new FileInfo() { isFound = false, filePath = sourceFilePathEntries[i] });
                }
            }

            // compare output files with input files
            // if found, mark key-value as true
            for (int i = 0; i < destinationFileEntries.Length; i++)
            {
                if (sourceEntries.ContainsKey(destinationFileEntries[i]))
                {
                    sourceEntries[destinationFileEntries[i]].isFound = true;
                }
            }

            // Create directory if it does not exist
            // If key-value pair is false, that means the destination did not contain the file from the source
            // Make a text document of the missing files
            // Copy the missing file from the source to the output folder
            Directory.CreateDirectory(outputDirectory);
            Random random = new Random();
            int randomNum = 0;
            using (StreamWriter outputFile = new StreamWriter(outputDirectory + "\\missing files.txt"))
            {
                foreach (KeyValuePair<string, FileInfo> entry in sourceEntries)
                {
                    if (entry.Value.isFound == false)
                    {
                        outputFile.Write("{0}\t\t\tSource: {1}", entry.Key, entry.Value.filePath);
                        if (File.Exists(outputDirectory + "\\" + entry.Key))
                        {
                            randomNum = random.Next();
                            outputFile.Write("\t!!!FILENAME ALREADY EXISTS IN OUTPUT!!!\t\tOutput: {0}", outputDirectory + "\\" + Path.GetFileNameWithoutExtension(entry.Value.filePath) + "-" + randomNum.ToString() + Path.GetExtension(entry.Value.filePath));
                            File.Copy(entry.Value.filePath, outputDirectory + "\\" + Path.GetFileNameWithoutExtension(entry.Value.filePath) + "-" + randomNum.ToString() + Path.GetExtension(entry.Value.filePath));
                        }
                        else
                        {
                            File.Copy(entry.Value.filePath, outputDirectory + "\\" + entry.Key);
                        }
                        outputFile.Write(Environment.NewLine);
                    }
                }
            }
            MessageBox.Show("Compare completed!");
        }

        private void aboutFilenameCompareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutWindow aboutWindow = new AboutWindow();
            aboutWindow.ShowDialog();
            aboutWindow.Dispose();
        }
    }
}
