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
            this.TextBoxInputFile1 = new System.Windows.Forms.TextBox();
            this.ButtonInputFile1 = new System.Windows.Forms.Button();
            this.TextBoxOutputFile = new System.Windows.Forms.TextBox();
            this.ButtonOutputFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxCompanyCode = new System.Windows.Forms.TextBox();
            this.TextBoxReportCode = new System.Windows.Forms.TextBox();
            this.ButtonPopulateData = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.TextBoxInputFile2 = new System.Windows.Forms.TextBox();
            this.ButtonInputFile2 = new System.Windows.Forms.Button();
            this.ButtonLoadFile = new System.Windows.Forms.Button();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBoxInputFile1
            // 
            this.TextBoxInputFile1.Location = new System.Drawing.Point(13, 13);
            this.TextBoxInputFile1.Name = "TextBoxInputFile1";
            this.TextBoxInputFile1.ReadOnly = true;
            this.TextBoxInputFile1.Size = new System.Drawing.Size(491, 20);
            this.TextBoxInputFile1.TabIndex = 0;
            // 
            // ButtonInputFile1
            // 
            this.ButtonInputFile1.Location = new System.Drawing.Point(510, 12);
            this.ButtonInputFile1.Name = "ButtonInputFile1";
            this.ButtonInputFile1.Size = new System.Drawing.Size(75, 23);
            this.ButtonInputFile1.TabIndex = 1;
            this.ButtonInputFile1.Text = "Input File 1";
            this.ButtonInputFile1.UseVisualStyleBackColor = true;
            this.ButtonInputFile1.Click += new System.EventHandler(this.ButtonInputFile1_Click);
            // 
            // TextBoxOutputFile
            // 
            this.TextBoxOutputFile.Location = new System.Drawing.Point(13, 85);
            this.TextBoxOutputFile.Name = "TextBoxOutputFile";
            this.TextBoxOutputFile.ReadOnly = true;
            this.TextBoxOutputFile.Size = new System.Drawing.Size(491, 20);
            this.TextBoxOutputFile.TabIndex = 0;
            // 
            // ButtonOutputFile
            // 
            this.ButtonOutputFile.Location = new System.Drawing.Point(510, 84);
            this.ButtonOutputFile.Name = "ButtonOutputFile";
            this.ButtonOutputFile.Size = new System.Drawing.Size(75, 23);
            this.ButtonOutputFile.TabIndex = 1;
            this.ButtonOutputFile.Text = "Output File";
            this.ButtonOutputFile.UseVisualStyleBackColor = true;
            this.ButtonOutputFile.Click += new System.EventHandler(this.ButtonOutputFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Company Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Report Code";
            // 
            // TextBoxCompanyCode
            // 
            this.TextBoxCompanyCode.Location = new System.Drawing.Point(100, 119);
            this.TextBoxCompanyCode.Name = "TextBoxCompanyCode";
            this.TextBoxCompanyCode.Size = new System.Drawing.Size(100, 20);
            this.TextBoxCompanyCode.TabIndex = 3;
            // 
            // TextBoxReportCode
            // 
            this.TextBoxReportCode.Location = new System.Drawing.Point(100, 153);
            this.TextBoxReportCode.Name = "TextBoxReportCode";
            this.TextBoxReportCode.Size = new System.Drawing.Size(100, 20);
            this.TextBoxReportCode.TabIndex = 3;
            // 
            // ButtonPopulateData
            // 
            this.ButtonPopulateData.Location = new System.Drawing.Point(134, 191);
            this.ButtonPopulateData.Name = "ButtonPopulateData";
            this.ButtonPopulateData.Size = new System.Drawing.Size(99, 23);
            this.ButtonPopulateData.TabIndex = 4;
            this.ButtonPopulateData.Text = "2.Populate Data";
            this.ButtonPopulateData.UseVisualStyleBackColor = true;
            this.ButtonPopulateData.Click += new System.EventHandler(this.ButtonPopulateData_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // TextBoxInputFile2
            // 
            this.TextBoxInputFile2.Location = new System.Drawing.Point(13, 49);
            this.TextBoxInputFile2.Name = "TextBoxInputFile2";
            this.TextBoxInputFile2.ReadOnly = true;
            this.TextBoxInputFile2.Size = new System.Drawing.Size(491, 20);
            this.TextBoxInputFile2.TabIndex = 0;
            // 
            // ButtonInputFile2
            // 
            this.ButtonInputFile2.Location = new System.Drawing.Point(510, 48);
            this.ButtonInputFile2.Name = "ButtonInputFile2";
            this.ButtonInputFile2.Size = new System.Drawing.Size(75, 23);
            this.ButtonInputFile2.TabIndex = 1;
            this.ButtonInputFile2.Text = "Input File 2";
            this.ButtonInputFile2.UseVisualStyleBackColor = true;
            this.ButtonInputFile2.Click += new System.EventHandler(this.ButtonInputFile2_Click);
            // 
            // ButtonLoadFile
            // 
            this.ButtonLoadFile.Location = new System.Drawing.Point(17, 191);
            this.ButtonLoadFile.Name = "ButtonLoadFile";
            this.ButtonLoadFile.Size = new System.Drawing.Size(111, 23);
            this.ButtonLoadFile.TabIndex = 4;
            this.ButtonLoadFile.Text = "1.Load Files If New";
            this.ButtonLoadFile.UseVisualStyleBackColor = true;
            this.ButtonLoadFile.Click += new System.EventHandler(this.ButtonLoadFile_Click);
            // 
            // ButtonExit
            // 
            this.ButtonExit.Location = new System.Drawing.Point(239, 191);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(99, 23);
            this.ButtonExit.TabIndex = 4;
            this.ButtonExit.Text = "Exit";
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // OSFIDataTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 229);
            this.Controls.Add(this.ButtonLoadFile);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.ButtonPopulateData);
            this.Controls.Add(this.TextBoxReportCode);
            this.Controls.Add(this.TextBoxCompanyCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonOutputFile);
            this.Controls.Add(this.ButtonInputFile2);
            this.Controls.Add(this.ButtonInputFile1);
            this.Controls.Add(this.TextBoxOutputFile);
            this.Controls.Add(this.TextBoxInputFile2);
            this.Controls.Add(this.TextBoxInputFile1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OSFIDataTool";
            this.Text = "OSFI Data Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxInputFile1;
        private System.Windows.Forms.Button ButtonInputFile1;
        private System.Windows.Forms.TextBox TextBoxOutputFile;
        private System.Windows.Forms.Button ButtonOutputFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxCompanyCode;
        private System.Windows.Forms.TextBox TextBoxReportCode;
        private System.Windows.Forms.Button ButtonPopulateData;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox TextBoxInputFile2;
        private System.Windows.Forms.Button ButtonInputFile2;
        private System.Windows.Forms.Button ButtonLoadFile;
        private System.Windows.Forms.Button ButtonExit;
    }
}

