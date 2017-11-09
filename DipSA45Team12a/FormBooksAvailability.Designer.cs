namespace DipSA45Team12a
{
    partial class FormBooksAvailability
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelSearchBookID = new System.Windows.Forms.Label();
            this.buttonListLoanBooks = new System.Windows.Forms.Button();
            this.buttonBkIDSearch = new System.Windows.Forms.Button();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxBkTitle = new System.Windows.Forms.TextBox();
            this.labelBookTitle = new System.Windows.Forms.Label();
            this.textBoxBookID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 100);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(517, 226);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // labelSearchBookID
            // 
            this.labelSearchBookID.AutoSize = true;
            this.labelSearchBookID.Location = new System.Drawing.Point(48, 22);
            this.labelSearchBookID.Name = "labelSearchBookID";
            this.labelSearchBookID.Size = new System.Drawing.Size(49, 13);
            this.labelSearchBookID.TabIndex = 1;
            this.labelSearchBookID.Text = "Book ID:";
            // 
            // buttonListLoanBooks
            // 
            this.buttonListLoanBooks.Location = new System.Drawing.Point(412, 29);
            this.buttonListLoanBooks.Name = "buttonListLoanBooks";
            this.buttonListLoanBooks.Size = new System.Drawing.Size(118, 42);
            this.buttonListLoanBooks.TabIndex = 2;
            this.buttonListLoanBooks.Text = "All Books Currently On Loan";
            this.buttonListLoanBooks.UseVisualStyleBackColor = true;
            this.buttonListLoanBooks.Click += new System.EventHandler(this.buttonListLoanBooks_Click);
            // 
            // buttonBkIDSearch
            // 
            this.buttonBkIDSearch.Location = new System.Drawing.Point(209, 18);
            this.buttonBkIDSearch.Name = "buttonBkIDSearch";
            this.buttonBkIDSearch.Size = new System.Drawing.Size(134, 21);
            this.buttonBkIDSearch.TabIndex = 3;
            this.buttonBkIDSearch.Text = "Search by Book ID";
            this.buttonBkIDSearch.UseVisualStyleBackColor = true;
            this.buttonBkIDSearch.Click += new System.EventHandler(this.buttonBkIDSearch_Click);
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this.button1);
            this.groupBoxSearch.Controls.Add(this.textBoxBkTitle);
            this.groupBoxSearch.Controls.Add(this.labelBookTitle);
            this.groupBoxSearch.Controls.Add(this.buttonBkIDSearch);
            this.groupBoxSearch.Controls.Add(this.textBoxBookID);
            this.groupBoxSearch.Controls.Add(this.labelSearchBookID);
            this.groupBoxSearch.Location = new System.Drawing.Point(13, 6);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(393, 88);
            this.groupBoxSearch.TabIndex = 4;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Search";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(209, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 21);
            this.button1.TabIndex = 6;
            this.button1.Text = "Search by Book Title";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxBkTitle
            // 
            this.textBoxBkTitle.Location = new System.Drawing.Point(103, 45);
            this.textBoxBkTitle.Name = "textBoxBkTitle";
            this.textBoxBkTitle.Size = new System.Drawing.Size(100, 20);
            this.textBoxBkTitle.TabIndex = 5;
            // 
            // labelBookTitle
            // 
            this.labelBookTitle.AutoSize = true;
            this.labelBookTitle.Location = new System.Drawing.Point(39, 48);
            this.labelBookTitle.Name = "labelBookTitle";
            this.labelBookTitle.Size = new System.Drawing.Size(58, 13);
            this.labelBookTitle.TabIndex = 4;
            this.labelBookTitle.Text = "Book Title:";
            // 
            // textBoxBookID
            // 
            this.textBoxBookID.Location = new System.Drawing.Point(103, 18);
            this.textBoxBookID.Name = "textBoxBookID";
            this.textBoxBookID.Size = new System.Drawing.Size(100, 20);
            this.textBoxBookID.TabIndex = 2;
            // 
            // FormBooksAvailability
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 338);
            this.Controls.Add(this.buttonListLoanBooks);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBoxSearch);
            this.Name = "FormBooksAvailability";
            this.Text = "Availability of Books On Loan";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelSearchBookID;
        private System.Windows.Forms.Button buttonListLoanBooks;
        private System.Windows.Forms.Button buttonBkIDSearch;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxBkTitle;
        private System.Windows.Forms.Label labelBookTitle;
        private System.Windows.Forms.TextBox textBoxBookID;
    }
}