namespace DipSA45Team12a
{
    partial class LoanDetailsForm
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
            this.DataGridTitleLabel = new System.Windows.Forms.Label();
            this.LoanHistoryButton = new System.Windows.Forms.Button();
            this.CurrentLoansButton = new System.Windows.Forms.Button();
            this.LoanHistoryDataGridView = new System.Windows.Forms.DataGridView();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.MemberIDBox = new System.Windows.Forms.TextBox();
            this.MemberIDLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LoanHistoryDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridTitleLabel
            // 
            this.DataGridTitleLabel.AutoSize = true;
            this.DataGridTitleLabel.Location = new System.Drawing.Point(286, 113);
            this.DataGridTitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DataGridTitleLabel.Name = "DataGridTitleLabel";
            this.DataGridTitleLabel.Size = new System.Drawing.Size(69, 13);
            this.DataGridTitleLabel.TabIndex = 16;
            this.DataGridTitleLabel.Text = "DataGridTitle";
            // 
            // LoanHistoryButton
            // 
            this.LoanHistoryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LoanHistoryButton.Location = new System.Drawing.Point(470, 45);
            this.LoanHistoryButton.Margin = new System.Windows.Forms.Padding(2);
            this.LoanHistoryButton.Name = "LoanHistoryButton";
            this.LoanHistoryButton.Size = new System.Drawing.Size(108, 47);
            this.LoanHistoryButton.TabIndex = 15;
            this.LoanHistoryButton.Text = "View Loan History";
            this.LoanHistoryButton.UseVisualStyleBackColor = true;
            this.LoanHistoryButton.Click += new System.EventHandler(this.LoanHistoryButton_Click);
            // 
            // CurrentLoansButton
            // 
            this.CurrentLoansButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CurrentLoansButton.Location = new System.Drawing.Point(324, 45);
            this.CurrentLoansButton.Margin = new System.Windows.Forms.Padding(2);
            this.CurrentLoansButton.Name = "CurrentLoansButton";
            this.CurrentLoansButton.Size = new System.Drawing.Size(102, 47);
            this.CurrentLoansButton.TabIndex = 14;
            this.CurrentLoansButton.Text = "View Current Loans";
            this.CurrentLoansButton.UseVisualStyleBackColor = true;
            this.CurrentLoansButton.Click += new System.EventHandler(this.CurrentLoansButton_Click);
            // 
            // LoanHistoryDataGridView
            // 
            this.LoanHistoryDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoanHistoryDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.LoanHistoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LoanHistoryDataGridView.Location = new System.Drawing.Point(46, 135);
            this.LoanHistoryDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.LoanHistoryDataGridView.Name = "LoanHistoryDataGridView";
            this.LoanHistoryDataGridView.RowTemplate.Height = 33;
            this.LoanHistoryDataGridView.Size = new System.Drawing.Size(542, 186);
            this.LoanHistoryDataGridView.TabIndex = 13;
            this.LoanHistoryDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LoanHistoryDataGridView_CellContentClick);
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(113, 72);
            this.NameBox.Margin = new System.Windows.Forms.Padding(2);
            this.NameBox.Name = "NameBox";
            this.NameBox.ReadOnly = true;
            this.NameBox.Size = new System.Drawing.Size(142, 20);
            this.NameBox.TabIndex = 12;
            this.NameBox.TabStop = false;
            // 
            // MemberIDBox
            // 
            this.MemberIDBox.Location = new System.Drawing.Point(113, 45);
            this.MemberIDBox.Margin = new System.Windows.Forms.Padding(2);
            this.MemberIDBox.Name = "MemberIDBox";
            this.MemberIDBox.ReadOnly = true;
            this.MemberIDBox.Size = new System.Drawing.Size(112, 20);
            this.MemberIDBox.TabIndex = 11;
            this.MemberIDBox.TabStop = false;
            // 
            // MemberIDLabel
            // 
            this.MemberIDLabel.AutoSize = true;
            this.MemberIDLabel.Location = new System.Drawing.Point(50, 48);
            this.MemberIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MemberIDLabel.Name = "MemberIDLabel";
            this.MemberIDLabel.Size = new System.Drawing.Size(56, 13);
            this.MemberIDLabel.TabIndex = 10;
            this.MemberIDLabel.Text = "MemberID";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(50, 72);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(35, 13);
            this.NameLabel.TabIndex = 9;
            this.NameLabel.Text = "Name";
            // 
            // LoanDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 367);
            this.Controls.Add(this.DataGridTitleLabel);
            this.Controls.Add(this.LoanHistoryButton);
            this.Controls.Add(this.CurrentLoansButton);
            this.Controls.Add(this.LoanHistoryDataGridView);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.MemberIDBox);
            this.Controls.Add(this.MemberIDLabel);
            this.Controls.Add(this.NameLabel);
            this.Name = "LoanDetailsForm";
            this.Text = "Loan Details";
            this.Load += new System.EventHandler(this.LoanDetailsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LoanHistoryDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DataGridTitleLabel;
        private System.Windows.Forms.Button LoanHistoryButton;
        private System.Windows.Forms.Button CurrentLoansButton;
        private System.Windows.Forms.DataGridView LoanHistoryDataGridView;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox MemberIDBox;
        private System.Windows.Forms.Label MemberIDLabel;
        private System.Windows.Forms.Label NameLabel;
    }
}