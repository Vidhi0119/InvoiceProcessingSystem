namespace InvoiceProcessingSystem
{
    partial class InvoiceProcessingForm
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
        /// Required method for Designer support.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblInputFolder = new Label();
            txtInputFolder = new TextBox();
            btnProcessFiles = new Button();
            labelProcessingStatus = new Label();
            lblPercentage = new Label();
            progressBar = new ProgressBar();
            grpSummary = new GroupBox();
            lblErrors = new Label();
            lblCompleted = new Label();
            lblTotalInvoices = new Label();
            grpResults = new GroupBox();
            dgvResults = new DataGridView();
            grpSummary.SuspendLayout();
            grpResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResults).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(217, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(354, 38);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Invoice Validation System";
            // 
            // lblInputFolder
            // 
            lblInputFolder.AutoSize = true;
            lblInputFolder.Location = new Point(18, 88);
            lblInputFolder.Name = "lblInputFolder";
            lblInputFolder.Size = new Size(92, 20);
            lblInputFolder.TabIndex = 1;
            lblInputFolder.Text = "Input Folder:";
            // 
            // txtInputFolder
            // 
            txtInputFolder.Location = new Point(18, 124);
            txtInputFolder.Name = "txtInputFolder";
            txtInputFolder.ReadOnly = true;
            txtInputFolder.Size = new Size(518, 27);
            txtInputFolder.TabIndex = 2;
            // 
            // btnProcessFiles
            // 
            btnProcessFiles.Location = new Point(377, 172);
            btnProcessFiles.Name = "btnProcessFiles";
            btnProcessFiles.Size = new Size(159, 44);
            btnProcessFiles.TabIndex = 3;
            btnProcessFiles.Text = "Process Files";
            btnProcessFiles.UseVisualStyleBackColor = true;
            btnProcessFiles.Click += btnProcessFiles_Click;
            // 
            // labelProcessingStatus
            // 
            labelProcessingStatus.AutoSize = true;
            labelProcessingStatus.Location = new Point(27, 241);
            labelProcessingStatus.Name = "labelProcessingStatus";
            labelProcessingStatus.Size = new Size(123, 20);
            labelProcessingStatus.TabIndex = 4;
            labelProcessingStatus.Text = "Processing Status";
            // 
            // lblPercentage
            // 
            lblPercentage.AutoSize = true;
            lblPercentage.Location = new Point(164, 241);
            lblPercentage.Name = "lblPercentage";
            lblPercentage.Size = new Size(29, 20);
            lblPercentage.TabIndex = 5;
            lblPercentage.Text = "0%";
            // 
            // progressBar
            // 
            progressBar.Location = new Point(162, 275);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(616, 19);
            progressBar.TabIndex = 6;
            // 
            // grpSummary
            // 
            grpSummary.Controls.Add(lblErrors);
            grpSummary.Controls.Add(lblCompleted);
            grpSummary.Controls.Add(lblTotalInvoices);
            grpSummary.Location = new Point(22, 320);
            grpSummary.Name = "grpSummary";
            grpSummary.Size = new Size(282, 164);
            grpSummary.TabIndex = 7;
            grpSummary.TabStop = false;
            grpSummary.Text = "Processing Summary";
            // 
            // lblErrors
            // 
            lblErrors.AutoSize = true;
            lblErrors.Location = new Point(8, 122);
            lblErrors.Name = "lblErrors";
            lblErrors.Size = new Size(63, 20);
            lblErrors.TabIndex = 10;
            lblErrors.Text = "Failed: 0";
            // 
            // lblCompleted
            // 
            lblCompleted.AutoSize = true;
            lblCompleted.Location = new Point(8, 80);
            lblCompleted.Name = "lblCompleted";
            lblCompleted.Size = new Size(91, 20);
            lblCompleted.TabIndex = 9;
            lblCompleted.Text = "Successful: 0";
            // 
            // lblTotalInvoices
            // 
            lblTotalInvoices.AutoSize = true;
            lblTotalInvoices.Location = new Point(8, 40);
            lblTotalInvoices.Name = "lblTotalInvoices";
            lblTotalInvoices.Size = new Size(114, 20);
            lblTotalInvoices.TabIndex = 8;
            lblTotalInvoices.Text = "Total Invoices: 0";
            // 
            // grpResults
            // 
            grpResults.Controls.Add(dgvResults);
            grpResults.Location = new Point(325, 320);
            grpResults.Name = "grpResults";
            grpResults.Size = new Size(453, 250);
            grpResults.TabIndex = 11;
            grpResults.TabStop = false;
            grpResults.Text = "File Processing Results";
            // 
            // dgvResults
            // 
            dgvResults.AllowUserToAddRows = false;
            dgvResults.AllowUserToDeleteRows = false;
            dgvResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvResults.BackgroundColor = SystemColors.Control;
            dgvResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResults.Dock = DockStyle.Fill;
            dgvResults.Location = new Point(3, 23);
            dgvResults.Name = "dgvResults";
            dgvResults.ReadOnly = true;
            dgvResults.RowHeadersWidth = 51;
            dgvResults.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvResults.Size = new Size(447, 224);
            dgvResults.TabIndex = 0;
            // 
            // InvoiceProcessingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 600);
            Controls.Add(grpResults);
            Controls.Add(grpSummary);
            Controls.Add(progressBar);
            Controls.Add(lblPercentage);
            Controls.Add(labelProcessingStatus);
            Controls.Add(btnProcessFiles);
            Controls.Add(txtInputFolder);
            Controls.Add(lblInputFolder);
            Controls.Add(lblTitle);
            Name = "InvoiceProcessingForm";
            Text = "Invoice Processing Form";
            grpSummary.ResumeLayout(false);
            grpSummary.PerformLayout();
            grpResults.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvResults).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblInputFolder;
        private TextBox txtInputFolder;
        private Button btnProcessFiles;

        private Label labelProcessingStatus;
        private Label lblPercentage;
        private ProgressBar progressBar;

        private GroupBox grpSummary;
        private Label lblTotalInvoices;
        private Label lblCompleted;
        private Label lblErrors;

        private GroupBox grpResults;
        private DataGridView dgvResults;
    }
}