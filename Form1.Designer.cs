namespace InvoiceProcessingSystem
{
    partial class InvoiceProcessingForm
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
            progressBar = new ProgressBar();
            labelProgress = new Label();
            lblPercentage = new Label();
            btnProcessInvoices = new Button();
            grpSummary = new GroupBox();
            lblTotalInvoices = new Label();
            lblCompleted = new Label();
            lblErrors = new Label();
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
            grpProcessing.Controls.Add(progressBar);
            grpProcessing.Controls.Add(labelProgress);
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
            // progressBar
            // 
            progressBar.Location = new Point(6, 70);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(450, 20);
            progressBar.TabIndex = 6;
            progressBar.Click += progressBar1_Click;
            // 
            // labelProgress
            // 
            labelProgress.AutoSize = true;
            labelProgress.Location = new Point(6, 47);
            labelProgress.Name = "labelProgress";
            labelProgress.Size = new Size(65, 20);
            labelProgress.TabIndex = 0;
            labelProgress.Text = "Progress";
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
            // btnProcessInvoices
            // 
            btnProcessInvoices.Location = new Point(188, 336);
            btnProcessInvoices.Name = "btnProcessInvoices";
            btnProcessInvoices.Size = new Size(159, 44);
            btnProcessInvoices.TabIndex = 8;
            btnProcessInvoices.Text = "Process Invoices";
            btnProcessInvoices.UseVisualStyleBackColor = true;
            // 
            // grpSummary
            // 
            grpSummary.Controls.Add(lblErrors);
            grpSummary.Controls.Add(lblCompleted);
            grpSummary.Controls.Add(lblTotalInvoices);
            grpSummary.Location = new Point(30, 413);
            grpSummary.Name = "grpSummary";
            grpSummary.Size = new Size(282, 171);
            grpSummary.TabIndex = 9;
            grpSummary.TabStop = false;
            grpSummary.Text = "Processing Summary";
            // 
            // lblTotalInvoices
            // 
            lblTotalInvoices.AutoSize = true;
            lblTotalInvoices.Location = new Point(6, 34);
            lblTotalInvoices.Name = "lblTotalInvoices";
            lblTotalInvoices.Size = new Size(114, 20);
            lblTotalInvoices.TabIndex = 10;
            lblTotalInvoices.Text = "Total Invoices: 0";
            // 
            // lblCompleted
            // 
            lblCompleted.AutoSize = true;
            lblCompleted.Location = new Point(6, 76);
            lblCompleted.Name = "lblCompleted";
            lblCompleted.Size = new Size(98, 20);
            lblCompleted.TabIndex = 11;
            lblCompleted.Text = "Completed: 0";
            // 
            // lblErrors
            // 
            lblErrors.AutoSize = true;
            lblErrors.Location = new Point(6, 122);
            lblErrors.Name = "lblErrors";
            lblErrors.Size = new Size(62, 20);
            lblErrors.TabIndex = 12;
            lblErrors.Text = "Errors: 0";
            // 
            // InvoiceProcessingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 711);
            Controls.Add(grpSummary);
            Controls.Add(btnProcessInvoices);
            Controls.Add(lblPercentage);
            Controls.Add(grpProcessing);
            Controls.Add(btnBrowse);
            Controls.Add(txtFilePath);
            Controls.Add(lblFile);
            Controls.Add(lblTitle);
            Name = "InvoiceProcessingForm";
            Text = "Invoice Processing Form";
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
        private Label labelProgress;
        private ProgressBar progressBar;
        private Label lblProcessingStatus;
        private Label lblPercentage;
        private Button btnProcessInvoices;
        private GroupBox grpSummary;
        private Label lblTotalInvoices;
        private Label lblErrors;
        private Label lblCompleted;
    }
}
