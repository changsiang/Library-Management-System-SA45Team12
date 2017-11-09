namespace DipSA45Team12a
{
    partial class Loan
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxISBN = new System.Windows.Forms.TextBox();
            this.labelISBN = new System.Windows.Forms.Label();
            this.textBoxBkStatus = new System.Windows.Forms.TextBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.textBoxBkTitle = new System.Windows.Forms.TextBox();
            this.labelBkTitle = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Checkbox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.BookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoanStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxBookID = new System.Windows.Forms.TextBox();
            this.labelBookID = new System.Windows.Forms.Label();
            this.buttonLoan = new System.Windows.Forms.Button();
            this.LoanForm = new System.Windows.Forms.GroupBox();
            this.buttonRetrieveBk = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelDueDate = new System.Windows.Forms.Label();
            this.labelLoanDate = new System.Windows.Forms.Label();
            this.dateTimeDueDatePicker = new System.Windows.Forms.DateTimePicker();
            this.dateTimeLoanDatePicker = new System.Windows.Forms.DateTimePicker();
            this.buttonMembSearch = new System.Windows.Forms.Button();
            this.textBoxAvailLim = new System.Windows.Forms.TextBox();
            this.textBoxCurrLoan = new System.Windows.Forms.TextBox();
            this.textBoxMembCat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRetriMemb = new System.Windows.Forms.Button();
            this.labelMembID = new System.Windows.Forms.Label();
            this.textBoxMembID = new System.Windows.Forms.TextBox();
            this.labelMembName = new System.Windows.Forms.Label();
            this.textBoxMembName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.LoanForm.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(510, 313);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 12;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemove.Location = new System.Drawing.Point(206, 44);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(68, 30);
            this.buttonRemove.TabIndex = 11;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = false;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(133, 44);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(67, 30);
            this.buttonAdd.TabIndex = 10;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxISBN
            // 
            this.textBoxISBN.Enabled = false;
            this.textBoxISBN.Location = new System.Drawing.Point(349, 43);
            this.textBoxISBN.Name = "textBoxISBN";
            this.textBoxISBN.Size = new System.Drawing.Size(224, 20);
            this.textBoxISBN.TabIndex = 9;
            // 
            // labelISBN
            // 
            this.labelISBN.AutoSize = true;
            this.labelISBN.Location = new System.Drawing.Point(280, 47);
            this.labelISBN.Name = "labelISBN";
            this.labelISBN.Size = new System.Drawing.Size(63, 13);
            this.labelISBN.TabIndex = 8;
            this.labelISBN.Text = "Book ISBN:";
            // 
            // textBoxBkStatus
            // 
            this.textBoxBkStatus.Enabled = false;
            this.textBoxBkStatus.Location = new System.Drawing.Point(89, 46);
            this.textBoxBkStatus.Name = "textBoxBkStatus";
            this.textBoxBkStatus.Size = new System.Drawing.Size(38, 20);
            this.textBoxBkStatus.TabIndex = 7;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(16, 46);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(67, 13);
            this.labelStatus.TabIndex = 6;
            this.labelStatus.Text = "Loan Status:";
            // 
            // textBoxBkTitle
            // 
            this.textBoxBkTitle.Enabled = false;
            this.textBoxBkTitle.Location = new System.Drawing.Point(349, 17);
            this.textBoxBkTitle.Name = "textBoxBkTitle";
            this.textBoxBkTitle.Size = new System.Drawing.Size(224, 20);
            this.textBoxBkTitle.TabIndex = 5;
            // 
            // labelBkTitle
            // 
            this.labelBkTitle.AutoSize = true;
            this.labelBkTitle.Location = new System.Drawing.Point(285, 21);
            this.labelBkTitle.Name = "labelBkTitle";
            this.labelBkTitle.Size = new System.Drawing.Size(58, 13);
            this.labelBkTitle.TabIndex = 4;
            this.labelBkTitle.Text = "Book Title:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Checkbox,
            this.BookID,
            this.ISBN,
            this.BookTitle,
            this.LoanStatus});
            this.dataGridView1.Location = new System.Drawing.Point(7, 80);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(566, 75);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Checkbox
            // 
            this.Checkbox.HeaderText = "Select";
            this.Checkbox.Name = "Checkbox";
            this.Checkbox.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Checkbox.Width = 50;
            // 
            // BookID
            // 
            this.BookID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.BookID.HeaderText = "Book ID";
            this.BookID.Name = "BookID";
            this.BookID.Width = 71;
            // 
            // ISBN
            // 
            this.ISBN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.Name = "ISBN";
            this.ISBN.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ISBN.Width = 38;
            // 
            // BookTitle
            // 
            this.BookTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BookTitle.HeaderText = "Book Title";
            this.BookTitle.Name = "BookTitle";
            this.BookTitle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // LoanStatus
            // 
            this.LoanStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.LoanStatus.HeaderText = "Loan Status";
            this.LoanStatus.Name = "LoanStatus";
            this.LoanStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.LoanStatus.Width = 70;
            // 
            // textBoxBookID
            // 
            this.textBoxBookID.Location = new System.Drawing.Point(89, 18);
            this.textBoxBookID.Name = "textBoxBookID";
            this.textBoxBookID.Size = new System.Drawing.Size(100, 20);
            this.textBoxBookID.TabIndex = 1;
            // 
            // labelBookID
            // 
            this.labelBookID.AutoSize = true;
            this.labelBookID.Location = new System.Drawing.Point(31, 21);
            this.labelBookID.Name = "labelBookID";
            this.labelBookID.Size = new System.Drawing.Size(52, 13);
            this.labelBookID.TabIndex = 0;
            this.labelBookID.Text = "Book ID: ";
            // 
            // buttonLoan
            // 
            this.buttonLoan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoan.Location = new System.Drawing.Point(429, 313);
            this.buttonLoan.Name = "buttonLoan";
            this.buttonLoan.Size = new System.Drawing.Size(75, 23);
            this.buttonLoan.TabIndex = 11;
            this.buttonLoan.Text = "Loan";
            this.buttonLoan.UseVisualStyleBackColor = true;
            this.buttonLoan.Click += new System.EventHandler(this.buttonLoan_Click);
            // 
            // LoanForm
            // 
            this.LoanForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoanForm.Controls.Add(this.buttonRemove);
            this.LoanForm.Controls.Add(this.buttonAdd);
            this.LoanForm.Controls.Add(this.textBoxISBN);
            this.LoanForm.Controls.Add(this.labelISBN);
            this.LoanForm.Controls.Add(this.textBoxBkStatus);
            this.LoanForm.Controls.Add(this.labelStatus);
            this.LoanForm.Controls.Add(this.textBoxBkTitle);
            this.LoanForm.Controls.Add(this.labelBkTitle);
            this.LoanForm.Controls.Add(this.dataGridView1);
            this.LoanForm.Controls.Add(this.buttonRetrieveBk);
            this.LoanForm.Controls.Add(this.textBoxBookID);
            this.LoanForm.Controls.Add(this.labelBookID);
            this.LoanForm.Location = new System.Drawing.Point(12, 140);
            this.LoanForm.Name = "LoanForm";
            this.LoanForm.Size = new System.Drawing.Size(579, 167);
            this.LoanForm.TabIndex = 10;
            this.LoanForm.TabStop = false;
            this.LoanForm.Text = "Book Information";
            // 
            // buttonRetrieveBk
            // 
            this.buttonRetrieveBk.Location = new System.Drawing.Point(192, 17);
            this.buttonRetrieveBk.Name = "buttonRetrieveBk";
            this.buttonRetrieveBk.Size = new System.Drawing.Size(75, 23);
            this.buttonRetrieveBk.TabIndex = 2;
            this.buttonRetrieveBk.Text = "Retrieve";
            this.buttonRetrieveBk.UseVisualStyleBackColor = true;
            this.buttonRetrieveBk.Click += new System.EventHandler(this.buttonGetBook_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelDueDate);
            this.groupBox1.Controls.Add(this.labelLoanDate);
            this.groupBox1.Controls.Add(this.dateTimeDueDatePicker);
            this.groupBox1.Controls.Add(this.dateTimeLoanDatePicker);
            this.groupBox1.Controls.Add(this.buttonMembSearch);
            this.groupBox1.Controls.Add(this.textBoxAvailLim);
            this.groupBox1.Controls.Add(this.textBoxCurrLoan);
            this.groupBox1.Controls.Add(this.textBoxMembCat);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonRetriMemb);
            this.groupBox1.Controls.Add(this.labelMembID);
            this.groupBox1.Controls.Add(this.textBoxMembID);
            this.groupBox1.Controls.Add(this.labelMembName);
            this.groupBox1.Controls.Add(this.textBoxMembName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(579, 122);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Member Information";
            // 
            // labelDueDate
            // 
            this.labelDueDate.AutoSize = true;
            this.labelDueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDueDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelDueDate.Location = new System.Drawing.Point(481, 70);
            this.labelDueDate.Name = "labelDueDate";
            this.labelDueDate.Size = new System.Drawing.Size(73, 16);
            this.labelDueDate.TabIndex = 17;
            this.labelDueDate.Text = "Due Date";
            // 
            // labelLoanDate
            // 
            this.labelLoanDate.AutoSize = true;
            this.labelLoanDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoanDate.ForeColor = System.Drawing.Color.Green;
            this.labelLoanDate.Location = new System.Drawing.Point(352, 70);
            this.labelLoanDate.Name = "labelLoanDate";
            this.labelLoanDate.Size = new System.Drawing.Size(79, 16);
            this.labelLoanDate.TabIndex = 16;
            this.labelLoanDate.Text = "Loan Date";
            // 
            // dateTimeDueDatePicker
            // 
            this.dateTimeDueDatePicker.CustomFormat = "dd-MMM-yyyy";
            this.dateTimeDueDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeDueDatePicker.Location = new System.Drawing.Point(484, 89);
            this.dateTimeDueDatePicker.Name = "dateTimeDueDatePicker";
            this.dateTimeDueDatePicker.Size = new System.Drawing.Size(82, 20);
            this.dateTimeDueDatePicker.TabIndex = 15;
            // 
            // dateTimeLoanDatePicker
            // 
            this.dateTimeLoanDatePicker.CustomFormat = "dd-MMM-yyyy";
            this.dateTimeLoanDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeLoanDatePicker.Location = new System.Drawing.Point(349, 89);
            this.dateTimeLoanDatePicker.Name = "dateTimeLoanDatePicker";
            this.dateTimeLoanDatePicker.Size = new System.Drawing.Size(82, 20);
            this.dateTimeLoanDatePicker.TabIndex = 14;
            // 
            // buttonMembSearch
            // 
            this.buttonMembSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMembSearch.Location = new System.Drawing.Point(7, 68);
            this.buttonMembSearch.Name = "buttonMembSearch";
            this.buttonMembSearch.Size = new System.Drawing.Size(263, 48);
            this.buttonMembSearch.TabIndex = 13;
            this.buttonMembSearch.Text = "Member Search";
            this.buttonMembSearch.UseVisualStyleBackColor = true;
            this.buttonMembSearch.Click += new System.EventHandler(this.buttonMembSearch_Click);
            // 
            // textBoxAvailLim
            // 
            this.textBoxAvailLim.Enabled = false;
            this.textBoxAvailLim.Location = new System.Drawing.Point(536, 44);
            this.textBoxAvailLim.Name = "textBoxAvailLim";
            this.textBoxAvailLim.Size = new System.Drawing.Size(30, 20);
            this.textBoxAvailLim.TabIndex = 12;
            // 
            // textBoxCurrLoan
            // 
            this.textBoxCurrLoan.Enabled = false;
            this.textBoxCurrLoan.Location = new System.Drawing.Point(392, 44);
            this.textBoxCurrLoan.Name = "textBoxCurrLoan";
            this.textBoxCurrLoan.Size = new System.Drawing.Size(30, 20);
            this.textBoxCurrLoan.TabIndex = 11;
            // 
            // textBoxMembCat
            // 
            this.textBoxMembCat.Enabled = false;
            this.textBoxMembCat.Location = new System.Drawing.Point(392, 19);
            this.textBoxMembCat.Name = "textBoxMembCat";
            this.textBoxMembCat.Size = new System.Drawing.Size(181, 20);
            this.textBoxMembCat.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(316, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Current Loan: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(453, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Available Limit:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(297, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Member Category:";
            // 
            // buttonRetriMemb
            // 
            this.buttonRetriMemb.Location = new System.Drawing.Point(194, 18);
            this.buttonRetriMemb.Name = "buttonRetriMemb";
            this.buttonRetriMemb.Size = new System.Drawing.Size(75, 23);
            this.buttonRetriMemb.TabIndex = 4;
            this.buttonRetriMemb.Text = "Retrieve";
            this.buttonRetriMemb.UseVisualStyleBackColor = true;
            this.buttonRetriMemb.Click += new System.EventHandler(this.buttonRetriMemb_Click);
            // 
            // labelMembID
            // 
            this.labelMembID.AutoSize = true;
            this.labelMembID.Location = new System.Drawing.Point(18, 22);
            this.labelMembID.Name = "labelMembID";
            this.labelMembID.Size = new System.Drawing.Size(65, 13);
            this.labelMembID.TabIndex = 0;
            this.labelMembID.Text = "Member ID: ";
            // 
            // textBoxMembID
            // 
            this.textBoxMembID.Location = new System.Drawing.Point(89, 19);
            this.textBoxMembID.Name = "textBoxMembID";
            this.textBoxMembID.Size = new System.Drawing.Size(100, 20);
            this.textBoxMembID.TabIndex = 1;
            // 
            // labelMembName
            // 
            this.labelMembName.AutoSize = true;
            this.labelMembName.Location = new System.Drawing.Point(4, 48);
            this.labelMembName.Name = "labelMembName";
            this.labelMembName.Size = new System.Drawing.Size(79, 13);
            this.labelMembName.TabIndex = 3;
            this.labelMembName.Text = "Member Name:";
            // 
            // textBoxMembName
            // 
            this.textBoxMembName.Enabled = false;
            this.textBoxMembName.Location = new System.Drawing.Point(89, 45);
            this.textBoxMembName.Name = "textBoxMembName";
            this.textBoxMembName.Size = new System.Drawing.Size(181, 20);
            this.textBoxMembName.TabIndex = 2;
            // 
            // Loan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 344);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonLoan);
            this.Controls.Add(this.LoanForm);
            this.Controls.Add(this.groupBox1);
            this.Name = "Loan";
            this.Text = "Loan Transaction";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.LoanForm.ResumeLayout(false);
            this.LoanForm.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxISBN;
        private System.Windows.Forms.Label labelISBN;
        private System.Windows.Forms.TextBox textBoxBkStatus;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.TextBox textBoxBkTitle;
        private System.Windows.Forms.Label labelBkTitle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Checkbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoanStatus;
        private System.Windows.Forms.TextBox textBoxBookID;
        private System.Windows.Forms.Label labelBookID;
        private System.Windows.Forms.Button buttonLoan;
        private System.Windows.Forms.GroupBox LoanForm;
        private System.Windows.Forms.Button buttonRetrieveBk;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelLoanDate;
        private System.Windows.Forms.DateTimePicker dateTimeDueDatePicker;
        private System.Windows.Forms.DateTimePicker dateTimeLoanDatePicker;
        private System.Windows.Forms.Button buttonMembSearch;
        private System.Windows.Forms.TextBox textBoxAvailLim;
        private System.Windows.Forms.TextBox textBoxCurrLoan;
        private System.Windows.Forms.TextBox textBoxMembCat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRetriMemb;
        private System.Windows.Forms.Label labelMembID;
        private System.Windows.Forms.TextBox textBoxMembID;
        private System.Windows.Forms.Label labelMembName;
        private System.Windows.Forms.TextBox textBoxMembName;
        private System.Windows.Forms.Label labelDueDate;
    }
}