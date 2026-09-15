namespace InvoiceProcessingSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblFile = new Label();
            txtFilePath = new TextBox();
            btnBrowse = new Button();
            grpProcessing = new GroupBox();
            lblProcessingStatus = new Label();
            progressBar1 = new ProgressBar();
            label1 = new Label();
            lblPercentage = new Label();
            button1 = new Button();
            grpSummary = new GroupBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            grpProcessing.SuspendLayout();
            grpSummary.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(217, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(360, 38);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Invoice Processing System";
            // 
            // lblFile
            // 
            lblFile.AutoSize = true;
            lblFile.Location = new Point(24, 87);
            lblFile.Name = "lblFile";
            lblFile.Size = new Size(62, 20);
            lblFile.TabIndex = 2;
            lblFile.Text = "CSV File";
            // 
            // txtFilePath
            // 
            txtFilePath.Location = new Point(24, 123);
            txtFilePath.Name = "txtFilePath";
            txtFilePath.Size = new Size(400, 27);
            txtFilePath.TabIndex = 3;
            txtFilePath.Text = "No file selected";
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(442, 122);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(94, 29);
            btnBrowse.TabIndex = 4;
            btnBrowse.Text = "Browse...";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // grpProcessing
            // 
            grpProcessing.Controls.Add(lblProcessingStatus);
            grpProcessing.Controls.Add(progressBar1);
            grpProcessing.Controls.Add(label1);
            grpProcessing.Location = new Point(24, 171);
            grpProcessing.Name = "grpProcessing";
            grpProcessing.Size = new Size(508, 147);
            grpProcessing.TabIndex = 5;
            grpProcessing.TabStop = false;
            grpProcessing.Text = "Processing";
            // 
            // lblProcessingStatus
            // 
            lblProcessingStatus.AutoSize = true;
            lblProcessingStatus.Location = new Point(6, 109);
            lblProcessingStatus.Name = "lblProcessingStatus";
            lblProcessingStatus.Size = new Size(167, 20);
            lblProcessingStatus.TabIndex = 7;
            lblProcessingStatus.Text = "Waiting for processing...";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(6, 70);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(450, 20);
            progressBar1.TabIndex = 6;
            progressBar1.Click += progressBar1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 47);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 0;
            label1.Text = "Progress";
            // 
            // lblPercentage
            // 
            lblPercentage.AutoSize = true;
            lblPercentage.Location = new Point(486, 241);
            lblPercentage.Name = "lblPercentage";
            lblPercentage.Size = new Size(29, 20);
            lblPercentage.TabIndex = 7;
            lblPercentage.Text = "0%";
            // 
            // button1
            // 
            button1.Location = new Point(188, 336);
            button1.Name = "button1";
            button1.Size = new Size(159, 44);
            button1.TabIndex = 8;
            button1.Text = "Process Invoices";
            button1.UseVisualStyleBackColor = true;
            // 
            // grpSummary
            // 
            grpSummary.Controls.Add(label4);
            grpSummary.Controls.Add(label3);
            grpSummary.Controls.Add(label2);
            grpSummary.Location = new Point(30, 413);
            grpSummary.Name = "grpSummary";
            grpSummary.Size = new Size(282, 171);
            grpSummary.TabIndex = 9;
            grpSummary.TabStop = false;
            grpSummary.Text = "Processing Summary";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 34);
            label2.Name = "label2";
            label2.Size = new Size(114, 20);
            label2.TabIndex = 10;
            label2.Text = "Total Invoices: 0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 76);
            label3.Name = "label3";
            label3.Size = new Size(98, 20);
            label3.TabIndex = 11;
            label3.Text = "Completed: 0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 122);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 12;
            label4.Text = "Errors: 0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 711);
            Controls.Add(grpSummary);
            Controls.Add(button1);
            Controls.Add(lblPercentage);
            Controls.Add(grpProcessing);
            Controls.Add(btnBrowse);
            Controls.Add(txtFilePath);
            Controls.Add(lblFile);
            Controls.Add(lblTitle);
            Name = "Form1";
            Text = "InvoiceProcessingForm";
            Load += Form1_Load;
            grpProcessing.ResumeLayout(false);
            grpProcessing.PerformLayout();
            grpSummary.ResumeLayout(false);
            grpSummary.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTitle;
        private Label lblFile;
        private TextBox txtFilePath;
        private Button btnBrowse;
        private GroupBox grpProcessing;
        private Label label1;
        private ProgressBar progressBar1;
        private Label lblProcessingStatus;
        private Label lblPercentage;
        private Button button1;
        private GroupBox grpSummary;
        private Label label2;
        private Label label4;
        private Label label3;
    }
}
