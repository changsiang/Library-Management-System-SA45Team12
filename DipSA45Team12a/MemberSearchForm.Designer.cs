namespace DipSA45Team12a
{
    partial class MemberSearchForm
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
            this.buttonClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ViewLoansButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.ColumnComboBox = new System.Windows.Forms.ComboBox();
            this.SearchByLabel = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.ViewAllMembersButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(481, 298);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(121, 49);
            this.buttonClose.TabIndex = 31;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Members List";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // ViewLoansButton
            // 
            this.ViewLoansButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ViewLoansButton.Location = new System.Drawing.Point(28, 298);
            this.ViewLoansButton.Margin = new System.Windows.Forms.Padding(2);
            this.ViewLoansButton.Name = "ViewLoansButton";
            this.ViewLoansButton.Size = new System.Drawing.Size(114, 49);
            this.ViewLoansButton.TabIndex = 28;
            this.ViewLoansButton.Text = "View Loan Details";
            this.ViewLoansButton.UseVisualStyleBackColor = true;
            this.ViewLoansButton.Click += new System.EventHandler(this.ViewLoansButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.UpdateButton.Location = new System.Drawing.Point(146, 298);
            this.UpdateButton.Margin = new System.Windows.Forms.Padding(2);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(121, 49);
            this.UpdateButton.TabIndex = 27;
            this.UpdateButton.Text = "Update Member Information";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(88, 56);
            this.SearchBox.Margin = new System.Windows.Forms.Padding(2);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(115, 20);
            this.SearchBox.TabIndex = 26;
            // 
            // ColumnComboBox
            // 
            this.ColumnComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ColumnComboBox.FormattingEnabled = true;
            this.ColumnComboBox.Items.AddRange(new object[] {
            "Member ID",
            "Name",
            "Phone Number"});
            this.ColumnComboBox.Location = new System.Drawing.Point(88, 29);
            this.ColumnComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.ColumnComboBox.Name = "ColumnComboBox";
            this.ColumnComboBox.Size = new System.Drawing.Size(115, 21);
            this.ColumnComboBox.TabIndex = 25;
            // 
            // SearchByLabel
            // 
            this.SearchByLabel.AutoSize = true;
            this.SearchByLabel.Location = new System.Drawing.Point(26, 30);
            this.SearchByLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SearchByLabel.Name = "SearchByLabel";
            this.SearchByLabel.Size = new System.Drawing.Size(59, 13);
            this.SearchByLabel.TabIndex = 24;
            this.SearchByLabel.Text = "Search By:";
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(220, 53);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(2);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(74, 22);
            this.SearchButton.TabIndex = 23;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // ViewAllMembersButton
            // 
            this.ViewAllMembersButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ViewAllMembersButton.Location = new System.Drawing.Point(436, 19);
            this.ViewAllMembersButton.Margin = new System.Windows.Forms.Padding(2);
            this.ViewAllMembersButton.Name = "ViewAllMembersButton";
            this.ViewAllMembersButton.Size = new System.Drawing.Size(166, 44);
            this.ViewAllMembersButton.TabIndex = 22;
            this.ViewAllMembersButton.Text = "View All Members";
            this.ViewAllMembersButton.UseVisualStyleBackColor = true;
            this.ViewAllMembersButton.Click += new System.EventHandler(this.ViewAllMembersButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 106);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(574, 177);
            this.dataGridView1.TabIndex = 21;
            // 
            // MemberSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 366);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ViewLoansButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.ColumnComboBox);
            this.Controls.Add(this.SearchByLabel);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.ViewAllMembersButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MemberSearchForm";
            this.Text = "Member Search/Update";
            this.Load += new System.EventHandler(this.MemberSearchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ViewLoansButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.ComboBox ColumnComboBox;
        private System.Windows.Forms.Label SearchByLabel;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button ViewAllMembersButton;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}