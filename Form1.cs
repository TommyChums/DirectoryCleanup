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

namespace WindowsFormsApp1
{
    public partial class SubDirectoryForm : Form
    {
        string path;
        public SubDirectoryForm()
        {
            InitializeComponent();
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {
            FolderBrowserDialog browserDialog = new FolderBrowserDialog();

            browserDialog.Description = "Please Select The starting folder with duplicate subdirectories";

            if(browserDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                selectedLocation.Text = browserDialog.SelectedPath;
                path = browserDialog.SelectedPath;
            }

        }

		/*
        private string toBaseFolder(string path)
        {
            var files = Directory.GetFileSystemEntries(path);
            if(files != null)
            {
                foreach(string f in files)
                {
                    MessageBox.Show(f);
                    if (File.GetAttributes(f).HasFlag(FileAttributes.Directory))
                    {
                        return toBaseFolder(f);
                    }
                    else continue;
                }
            }
            
            return path;
        }
		*/

        private void copyToParent(string path)
        {
            var files = Directory.GetFiles(path);

            if(files != null)
            {
                //MessageBox.Show("Parent Name: " + Directory.GetParent(path).Name);
                //MessageBox.Show("File Name: " + Path.GetFileName(path));
                if(Directory.GetParent(path).Name == (Path.GetFileName(path)))
                {
                    copyFiles(files);
                    copyToParent(Directory.GetParent(path).FullName);
                }
            }
        }
        
        private void copyFiles(string[] files)
        {
            foreach(var f in files) {
	            textBox1.AppendText("Copying " + Path.GetFileName(f) + " to " + Directory.GetParent(Directory.GetParent(f).FullName).FullName);
	            textBox1.AppendText(Environment.NewLine);
                File.Move(f, Path.Combine(Directory.GetParent(Directory.GetParent(f).FullName).FullName, Path.GetFileName(f)));
               

            }
        }

        private void cleanUp(string[] files)
        {
	        foreach (string f in files) {
		        try {
			        if (File.GetAttributes(f).HasFlag(FileAttributes.Directory))
				        cleanUp(Directory.GetFileSystemEntries(f));
			        if (Directory.GetFileSystemEntries(f).Length == 0) {
				        Directory.Delete(f, false);
			        }
		        }
		        catch (Exception e) {
			        copyToParent(Directory.GetParent(f).FullName);
			        continue;
		        }

		        copyToParent(Directory.GetParent(f).FullName);
	        }
        }
			
        


        private void runCleanUp(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Visible = true;

            string[] files = Directory.GetFileSystemEntries(path);

			textBox1.AppendText("Working...");
			textBox1.AppendText(Environment.NewLine);
			textBox1.AppendText(Environment.NewLine);
			cleanUp(files);
	        textBox1.AppendText("----------Completed Successfully----------");
            MessageBox.Show("Complete!");

        }
    }
}
