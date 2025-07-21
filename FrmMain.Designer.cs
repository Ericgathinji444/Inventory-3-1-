namespace CST_150_Activity_3
{
    partial class FrmMain
    {
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.btnReadFile = new System.Windows.Forms.Button();
            this.lblSelectedFile = new System.Windows.Forms.Label();
            this.lblResults = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnReadFile
            // 
            this.btnReadFile.BackColor = System.Drawing.Color.ForestGreen;
            this.btnReadFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReadFile.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnReadFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnReadFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.btnReadFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReadFile.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnReadFile.Location = new System.Drawing.Point(327, 99);
            this.btnReadFile.Name = "btnReadFile";
            this.btnReadFile.Size = new System.Drawing.Size(137, 48);
            this.btnReadFile.TabIndex = 0;
            this.btnReadFile.Text = "Read File";
            this.btnReadFile.UseVisualStyleBackColor = false;
            this.btnReadFile.Click += new System.EventHandler(this.BtnReadFileClickEvent);
            // 
            // lblSelectedFile
            // 
            this.lblSelectedFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSelectedFile.ForeColor = System.Drawing.Color.Firebrick;
            this.lblSelectedFile.Location = new System.Drawing.Point(12, 350);
            this.lblSelectedFile.Name = "lblSelectedFile";
            this.lblSelectedFile.Size = new System.Drawing.Size(758, 91);
            this.lblSelectedFile.TabIndex = 1;
            this.lblSelectedFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResults
            // 
            this.lblResults.Font = new System.Drawing.Font("Lucida Console", 10F);
            this.lblResults.Location = new System.Drawing.Point(100, 160);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(600, 170);
            this.lblResults.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.lblSelectedFile);
            this.Controls.Add(this.btnReadFile);
            this.Name = "FrmMain";
            this.Text = "Main Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReadFile;
        private System.Windows.Forms.Label lblSelectedFile;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
