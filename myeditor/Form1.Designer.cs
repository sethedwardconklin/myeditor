namespace myeditor
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnselect = new System.Windows.Forms.Button();
            this.lblselect = new System.Windows.Forms.Label();
            this.rtb = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // btnselect
            // 
            this.btnselect.Location = new System.Drawing.Point(387, 12);
            this.btnselect.Name = "btnselect";
            this.btnselect.Size = new System.Drawing.Size(75, 23);
            this.btnselect.TabIndex = 0;
            this.btnselect.Text = "Select File";
            this.btnselect.UseVisualStyleBackColor = true;
            this.btnselect.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblselect
            // 
            this.lblselect.AutoSize = true;
            this.lblselect.Location = new System.Drawing.Point(296, 17);
            this.lblselect.Name = "lblselect";
            this.lblselect.Size = new System.Drawing.Size(85, 13);
            this.lblselect.TabIndex = 1;
            this.lblselect.Text = "Select a text file:";
            // 
            // rtb
            // 
            this.rtb.Location = new System.Drawing.Point(12, 53);
            this.rtb.Name = "rtb";
            this.rtb.Size = new System.Drawing.Size(776, 366);
            this.rtb.TabIndex = 2;
            this.rtb.Text = "";
            this.rtb.TextChanged += new System.EventHandler(this.rtb_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtb);
            this.Controls.Add(this.lblselect);
            this.Controls.Add(this.btnselect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnselect;
        private System.Windows.Forms.Label lblselect;
        private System.Windows.Forms.RichTextBox rtb;
    }
}

