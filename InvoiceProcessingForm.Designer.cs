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
            grpValidationLogs = new GroupBox();
            dgvValidationLogs = new DataGridView();
            groupBox1 = new GroupBox();
            txtProcessingLogs = new RichTextBox();
            grpSummary.SuspendLayout();
            grpValidationLogs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvValidationLogs).BeginInit();
            groupBox1.SuspendLayout();
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
            txtInputFolder.Size = new Size(681, 27);
            txtInputFolder.TabIndex = 2;
            // 
            // btnProcessFiles
            // 
            btnProcessFiles.Location = new Point(540, 170);
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
            labelProcessingStatus.Location = new Point(30, 222);
            labelProcessingStatus.Name = "labelProcessingStatus";
            labelProcessingStatus.Size = new Size(123, 20);
            labelProcessingStatus.TabIndex = 4;
            labelProcessingStatus.Text = "Processing Status";
            // 
            // lblPercentage
            // 
            lblPercentage.AutoSize = true;
            lblPercentage.Location = new Point(162, 222);
            lblPercentage.Name = "lblPercentage";
            lblPercentage.Size = new Size(29, 20);
            lblPercentage.TabIndex = 5;
            lblPercentage.Text = "0%";
            // 
            // progressBar
            // 
            progressBar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            progressBar.Location = new Point(162, 254);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(537, 24);
            progressBar.TabIndex = 6;
            // 
            // grpSummary
            // 
            grpSummary.Controls.Add(lblErrors);
            grpSummary.Controls.Add(lblCompleted);
            grpSummary.Controls.Add(lblTotalInvoices);
            grpSummary.Location = new Point(30, 298);
            grpSummary.Name = "grpSummary";
            grpSummary.Size = new Size(265, 150);
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
            // grpValidationLogs
            // 
            grpValidationLogs.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpValidationLogs.Controls.Add(dgvValidationLogs);
            grpValidationLogs.Location = new Point(30, 465);
            grpValidationLogs.Name = "grpValidationLogs";
            grpValidationLogs.Size = new Size(856, 229);
            grpValidationLogs.TabIndex = 8;
            grpValidationLogs.TabStop = false;
            grpValidationLogs.Text = "Validation Logs";
            grpValidationLogs.Enter += grpValidationLogs_Enter;
            // 
            // dgvValidationLogs
            // 
            dgvValidationLogs.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvValidationLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvValidationLogs.Location = new Point(12, 38);
            dgvValidationLogs.Name = "dgvValidationLogs";
            dgvValidationLogs.RowHeadersWidth = 51;
            dgvValidationLogs.Size = new Size(834, 179);
            dgvValidationLogs.TabIndex = 0;
            dgvValidationLogs.CellContentClick += dgvValidationLogs_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(txtProcessingLogs);
            groupBox1.Location = new Point(30, 712);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(856, 331);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Processing Logs";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // txtProcessingLogs
            // 
            txtProcessingLogs.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtProcessingLogs.Location = new Point(8, 26);
            txtProcessingLogs.Name = "txtProcessingLogs";
            txtProcessingLogs.ReadOnly = true;
            txtProcessingLogs.ScrollBars = RichTextBoxScrollBars.Vertical;
            txtProcessingLogs.Size = new Size(838, 281);
            txtProcessingLogs.TabIndex = 0;
            txtProcessingLogs.Text = "";
            // 
            // InvoiceProcessingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(898, 1055);
            Controls.Add(groupBox1);
            Controls.Add(grpValidationLogs);
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
            grpValidationLogs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvValidationLogs).EndInit();
            groupBox1.ResumeLayout(false);
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
        private GroupBox grpValidationLogs;
        private DataGridView dgvValidationLogs;
        private GroupBox groupBox1;
        private RichTextBox txtProcessingLogs;
    }
}