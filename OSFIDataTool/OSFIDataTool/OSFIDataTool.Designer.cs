namespace OSFIDataTool
{
    partial class OSFIDataTool
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
            this.TextBoxInputFile = new System.Windows.Forms.TextBox();
            this.ButtonInputFile = new System.Windows.Forms.Button();
            this.TextBoxOutputFile = new System.Windows.Forms.TextBox();
            this.ButtonOutputFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxCompanyCode = new System.Windows.Forms.TextBox();
            this.TextBoxReportCode = new System.Windows.Forms.TextBox();
            this.ButtonExecute = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // TextBoxInputFile
            // 
            this.TextBoxInputFile.Location = new System.Drawing.Point(13, 13);
            this.TextBoxInputFile.Name = "TextBoxInputFile";
            this.TextBoxInputFile.ReadOnly = true;
            this.TextBoxInputFile.Size = new System.Drawing.Size(491, 20);
            this.TextBoxInputFile.TabIndex = 0;
            // 
            // ButtonInputFile
            // 
            this.ButtonInputFile.Location = new System.Drawing.Point(510, 12);
            this.ButtonInputFile.Name = "ButtonInputFile";
            this.ButtonInputFile.Size = new System.Drawing.Size(75, 23);
            this.ButtonInputFile.TabIndex = 1;
            this.ButtonInputFile.Text = "Input File";
            this.ButtonInputFile.UseVisualStyleBackColor = true;
            // 
            // TextBoxOutputFile
            // 
            this.TextBoxOutputFile.Location = new System.Drawing.Point(13, 47);
            this.TextBoxOutputFile.Name = "TextBoxOutputFile";
            this.TextBoxOutputFile.ReadOnly = true;
            this.TextBoxOutputFile.Size = new System.Drawing.Size(491, 20);
            this.TextBoxOutputFile.TabIndex = 0;
            // 
            // ButtonOutputFile
            // 
            this.ButtonOutputFile.Location = new System.Drawing.Point(510, 46);
            this.ButtonOutputFile.Name = "ButtonOutputFile";
            this.ButtonOutputFile.Size = new System.Drawing.Size(75, 23);
            this.ButtonOutputFile.TabIndex = 1;
            this.ButtonOutputFile.Text = "Output File";
            this.ButtonOutputFile.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Company Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Report Code";
            // 
            // TextBoxCompanyCode
            // 
            this.TextBoxCompanyCode.Location = new System.Drawing.Point(99, 81);
            this.TextBoxCompanyCode.Name = "TextBoxCompanyCode";
            this.TextBoxCompanyCode.Size = new System.Drawing.Size(100, 20);
            this.TextBoxCompanyCode.TabIndex = 3;
            // 
            // TextBoxReportCode
            // 
            this.TextBoxReportCode.Location = new System.Drawing.Point(99, 115);
            this.TextBoxReportCode.Name = "TextBoxReportCode";
            this.TextBoxReportCode.Size = new System.Drawing.Size(100, 20);
            this.TextBoxReportCode.TabIndex = 3;
            // 
            // ButtonExecute
            // 
            this.ButtonExecute.Location = new System.Drawing.Point(12, 153);
            this.ButtonExecute.Name = "ButtonExecute";
            this.ButtonExecute.Size = new System.Drawing.Size(75, 23);
            this.ButtonExecute.TabIndex = 4;
            this.ButtonExecute.Text = "Execute";
            this.ButtonExecute.UseVisualStyleBackColor = true;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // OSFIDataTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 187);
            this.Controls.Add(this.ButtonExecute);
            this.Controls.Add(this.TextBoxReportCode);
            this.Controls.Add(this.TextBoxCompanyCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonOutputFile);
            this.Controls.Add(this.ButtonInputFile);
            this.Controls.Add(this.TextBoxOutputFile);
            this.Controls.Add(this.TextBoxInputFile);
            this.Name = "OSFIDataTool";
            this.Text = "OSFI Data Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxInputFile;
        private System.Windows.Forms.Button ButtonInputFile;
        private System.Windows.Forms.TextBox TextBoxOutputFile;
        private System.Windows.Forms.Button ButtonOutputFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxCompanyCode;
        private System.Windows.Forms.TextBox TextBoxReportCode;
        private System.Windows.Forms.Button ButtonExecute;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

