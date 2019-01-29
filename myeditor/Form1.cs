using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myeditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK) // If user presses OPEN then the code below will run.
            {
                string path = openFileDialog1.FileName; // Path will equal filepath to selected file
                System.IO.StreamReader sr = new System.IO.StreamReader(path);
                rtb.Text = sr.ReadToEnd();
                // Works but cannot save
                // Figure out how to add a "save" button.

                //MessageBox.Show(path); 
            }
        }

        private void rtb_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
