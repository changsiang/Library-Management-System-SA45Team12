namespace DipSA45Team12a
{
    partial class FormEditBook
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
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPub = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtauthor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerPub = new System.Windows.Forms.DateTimePicker();
            this.cbotType = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.RichTextBox();
            this.cboSub = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelNewStk = new System.Windows.Forms.Label();
            this.txtNewStock = new System.Windows.Forms.TextBox();
            this.labelCurStock = new System.Windows.Forms.Label();
            this.txtShelf = new System.Windows.Forms.TextBox();
            this.txtTotalStock = new System.Windows.Forms.TextBox();
            this.txtCall = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtISBN
            // 
            this.txtISBN.Enabled = false;
            this.txtISBN.Location = new System.Drawing.Point(118, 43);
            this.txtISBN.Margin = new System.Windows.Forms.Padding(2);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(171, 20);
            this.txtISBN.TabIndex = 173;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(391, 256);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(80, 36);
            this.btnUpdate.TabIndex = 171;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 196);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 111;
            this.label10.Text = "Description";
            // 
            // txtPub
            // 
            this.txtPub.Location = new System.Drawing.Point(108, 164);
            this.txtPub.Margin = new System.Windows.Forms.Padding(2);
            this.txtPub.Name = "txtPub";
            this.txtPub.Size = new System.Drawing.Size(171, 20);
            this.txtPub.TabIndex = 123;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 86);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 107;
            this.label6.Text = "Title";
            // 
            // txtauthor
            // 
            this.txtauthor.Location = new System.Drawing.Point(107, 109);
            this.txtauthor.Margin = new System.Windows.Forms.Padding(2);
            this.txtauthor.Name = "txtauthor";
            this.txtauthor.Size = new System.Drawing.Size(171, 20);
            this.txtauthor.TabIndex = 122;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 113);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 108;
            this.label7.Text = "Author";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(107, 82);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(2);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(171, 20);
            this.txtTitle.TabIndex = 121;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 141);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 109;
            this.label8.Text = "Pub Year";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 170);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 110;
            this.label9.Text = "Publisher";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 153;
            this.label2.Text = "Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 48);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 154;
            this.label3.Text = "Subject";
            // 
            // dateTimePickerPub
            // 
            this.dateTimePickerPub.CustomFormat = "dd-MMM-yyyy";
            this.dateTimePickerPub.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerPub.Location = new System.Drawing.Point(108, 138);
            this.dateTimePickerPub.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerPub.Name = "dateTimePickerPub";
            this.dateTimePickerPub.Size = new System.Drawing.Size(171, 20);
            this.dateTimePickerPub.TabIndex = 13;
            // 
            // cbotType
            // 
            this.cbotType.DisplayMember = "Subject";
            this.cbotType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbotType.FormattingEnabled = true;
            this.cbotType.Items.AddRange(new object[] {
            "FICTION",
            "NON-FICTION"});
            this.cbotType.Location = new System.Drawing.Point(92, 22);
            this.cbotType.Margin = new System.Windows.Forms.Padding(2);
            this.cbotType.Name = "cbotType";
            this.cbotType.Size = new System.Drawing.Size(171, 21);
            this.cbotType.TabIndex = 162;
            this.cbotType.ValueMember = "Subject";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(105, 60);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 124;
            this.label11.Text = "Warning";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(108, 196);
            this.txtDesc.Margin = new System.Windows.Forms.Padding(2);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(171, 79);
            this.txtDesc.TabIndex = 14;
            this.txtDesc.Text = "";
            // 
            // cboSub
            // 
            this.cboSub.DisplayMember = "Description";
            this.cboSub.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSub.FormattingEnabled = true;
            this.cboSub.Items.AddRange(new object[] {
            "General Works",
            "Philosophy - Religion",
            "History of civilization",
            "History",
            "History of America",
            "Geography ~ Anthropology",
            "Social sciences",
            "Economics",
            "Sociology",
            "Real Estate",
            "Political Science",
            "Law",
            "Education",
            "Music",
            "Fine Arts",
            "Languages - Literature",
            "Science",
            "Medicine",
            "Agriculture",
            "Technology - Engineering",
            "Military Science",
            "Naval Science",
            "Bibliography - Library Science",
            "Classic",
            "Crime Detective",
            "Fable",
            "Fairy Tale",
            "Fantasy",
            "Folklore",
            "Historical",
            "Horror",
            "Humor",
            "Legend",
            "Mystery",
            "Mythology",
            "Realistic",
            "Science Fiction",
            "Short Story",
            "Suspense Thriller"});
            this.cboSub.Location = new System.Drawing.Point(92, 44);
            this.cboSub.Margin = new System.Windows.Forms.Padding(2);
            this.cboSub.Name = "cboSub";
            this.cboSub.Size = new System.Drawing.Size(171, 21);
            this.cboSub.TabIndex = 161;
            this.cboSub.ValueMember = "Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 48);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 170;
            this.label5.Text = "ISBN";
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(497, 256);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(80, 36);
            this.BtnCancel.TabIndex = 172;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbotType);
            this.groupBox1.Controls.Add(this.cboSub);
            this.groupBox1.Location = new System.Drawing.Point(326, 19);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(284, 75);
            this.groupBox1.TabIndex = 174;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Classification";
            // 
            // labelNewStk
            // 
            this.labelNewStk.AutoSize = true;
            this.labelNewStk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewStk.Location = new System.Drawing.Point(153, 96);
            this.labelNewStk.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNewStk.Name = "labelNewStk";
            this.labelNewStk.Size = new System.Drawing.Size(73, 13);
            this.labelNewStk.TabIndex = 167;
            this.labelNewStk.Text = "New Stock:";
            // 
            // txtNewStock
            // 
            this.txtNewStock.Location = new System.Drawing.Point(230, 93);
            this.txtNewStock.Margin = new System.Windows.Forms.Padding(2);
            this.txtNewStock.Name = "txtNewStock";
            this.txtNewStock.Size = new System.Drawing.Size(33, 20);
            this.txtNewStock.TabIndex = 168;
            // 
            // labelCurStock
            // 
            this.labelCurStock.AutoSize = true;
            this.labelCurStock.Location = new System.Drawing.Point(12, 96);
            this.labelCurStock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCurStock.Name = "labelCurStock";
            this.labelCurStock.Size = new System.Drawing.Size(75, 13);
            this.labelCurStock.TabIndex = 158;
            this.labelCurStock.Text = "Current Stock:";
            // 
            // txtShelf
            // 
            this.txtShelf.Location = new System.Drawing.Point(92, 60);
            this.txtShelf.Margin = new System.Windows.Forms.Padding(2);
            this.txtShelf.Name = "txtShelf";
            this.txtShelf.Size = new System.Drawing.Size(171, 20);
            this.txtShelf.TabIndex = 165;
            // 
            // txtTotalStock
            // 
            this.txtTotalStock.Enabled = false;
            this.txtTotalStock.Location = new System.Drawing.Point(92, 93);
            this.txtTotalStock.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotalStock.Name = "txtTotalStock";
            this.txtTotalStock.Size = new System.Drawing.Size(33, 20);
            this.txtTotalStock.TabIndex = 166;
            // 
            // txtCall
            // 
            this.txtCall.Location = new System.Drawing.Point(92, 32);
            this.txtCall.Margin = new System.Windows.Forms.Padding(2);
            this.txtCall.Name = "txtCall";
            this.txtCall.Size = new System.Drawing.Size(171, 20);
            this.txtCall.TabIndex = 164;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(38, 62);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 13);
            this.label14.TabIndex = 157;
            this.label14.Text = "Shelf:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 35);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 13);
            this.label13.TabIndex = 156;
            this.label13.Text = "Call Number:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtDesc);
            this.groupBox2.Controls.Add(this.dateTimePickerPub);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtPub);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtauthor);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtTitle);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(11, 11);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(295, 288);
            this.groupBox2.TabIndex = 175;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Book Details";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelNewStk);
            this.groupBox3.Controls.Add(this.txtNewStock);
            this.groupBox3.Controls.Add(this.labelCurStock);
            this.groupBox3.Controls.Add(this.txtShelf);
            this.groupBox3.Controls.Add(this.txtTotalStock);
            this.groupBox3.Controls.Add(this.txtCall);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Location = new System.Drawing.Point(326, 106);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(284, 137);
            this.groupBox3.TabIndex = 176;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Book Location and Status";
            // 
            // FormEditBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 320);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Name = "FormEditBook";
            this.Text = "Edit Book Information";
            this.Load += new System.EventHandler(this.FormEditBook_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPub;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtauthor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerPub;
        private System.Windows.Forms.ComboBox cbotType;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox txtDesc;
        private System.Windows.Forms.ComboBox cboSub;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelNewStk;
        private System.Windows.Forms.TextBox txtNewStock;
        private System.Windows.Forms.Label labelCurStock;
        private System.Windows.Forms.TextBox txtShelf;
        private System.Windows.Forms.TextBox txtTotalStock;
        private System.Windows.Forms.TextBox txtCall;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}