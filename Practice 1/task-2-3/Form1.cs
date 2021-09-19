using System;
using System.Windows.Forms;
using System.IO;

namespace task_2_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            locationTextBox.Text = ofd.FileName;
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            try
            {
                TextReader tr = new StreamReader(locationTextBox.Text);
                try { displayTextBox.Text = tr.ReadToEnd(); }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
                finally { tr.Close(); }
            }
            catch (FileNotFoundException)
            { MessageBox.Show("File doesn't exist."); }
            catch (UnauthorizedAccessException)
            { MessageBox.Show("You have no access to this file."); }
            catch (Exception ex) { MessageBox.Show(ex.Message); } 
        }
    }
}