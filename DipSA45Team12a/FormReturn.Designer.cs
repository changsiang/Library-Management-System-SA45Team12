namespace DipSA45Team12a
{
    partial class ReturnForm
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
            this.labelBookID = new System.Windows.Forms.Label();
            this.textBoxBookID = new System.Windows.Forms.TextBox();
            this.buttonRetrievebk = new System.Windows.Forms.Button();
            this.groupBoxMembInfo = new System.Windows.Forms.GroupBox();
            this.textBoxMembCat = new System.Windows.Forms.TextBox();
            this.textBoxMembName = new System.Windows.Forms.TextBox();
            this.textBoxMembID = new System.Windows.Forms.TextBox();
            this.labelMembCat = new System.Windows.Forms.Label();
            this.labelMembName = new System.Windows.Forms.Label();
            this.labelMembID = new System.Windows.Forms.Label();
            this.groupBoxBkInfo = new System.Windows.Forms.GroupBox();
            this.textBoxDueDate = new System.Windows.Forms.TextBox();
            this.labelDueDate = new System.Windows.Forms.Label();
            this.textBoxShelfLocal = new System.Windows.Forms.TextBox();
            this.labelBkLocation = new System.Windows.Forms.Label();
            this.textBoxCallNumber = new System.Windows.Forms.TextBox();
            this.labelBkCallNo = new System.Windows.Forms.Label();
            this.textBoxBkRemark = new System.Windows.Forms.TextBox();
            this.labelRemarks = new System.Windows.Forms.Label();
            this.textBoxISBN = new System.Windows.Forms.TextBox();
            this.labelBkISBN = new System.Windows.Forms.Label();
            this.textBoxBkTitle = new System.Windows.Forms.TextBox();
            this.labelBkTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelReturnDate = new System.Windows.Forms.Label();
            this.dateTimePickerReturnDate = new System.Windows.Forms.DateTimePicker();
            this.groupBoxMembInfo.SuspendLayout();
            this.groupBoxBkInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelBookID
            // 
            this.labelBookID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelBookID.AutoSize = true;
            this.labelBookID.Location = new System.Drawing.Point(10, 15);
            this.labelBookID.Name = "labelBookID";
            this.labelBookID.Size = new System.Drawing.Size(52, 13);
            this.labelBookID.TabIndex = 0;
            this.labelBookID.Text = "Book ID: ";
            // 
            // textBoxBookID
            // 
            this.textBoxBookID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxBookID.Location = new System.Drawing.Point(68, 12);
            this.textBoxBookID.Name = "textBoxBookID";
            this.textBoxBookID.Size = new System.Drawing.Size(100, 20);
            this.textBoxBookID.TabIndex = 1;
            // 
            // buttonRetrievebk
            // 
            this.buttonRetrievebk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonRetrievebk.Location = new System.Drawing.Point(175, 12);
            this.buttonRetrievebk.Name = "buttonRetrievebk";
            this.buttonRetrievebk.Size = new System.Drawing.Size(75, 23);
            this.buttonRetrievebk.TabIndex = 2;
            this.buttonRetrievebk.Text = "Retrieve";
            this.buttonRetrievebk.UseVisualStyleBackColor = true;
            this.buttonRetrievebk.Click += new System.EventHandler(this.buttonRetrievebk_Click);
            // 
            // groupBoxMembInfo
            // 
            this.groupBoxMembInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxMembInfo.Controls.Add(this.textBoxMembCat);
            this.groupBoxMembInfo.Controls.Add(this.textBoxMembName);
            this.groupBoxMembInfo.Controls.Add(this.textBoxMembID);
            this.groupBoxMembInfo.Controls.Add(this.labelMembCat);
            this.groupBoxMembInfo.Controls.Add(this.labelMembName);
            this.groupBoxMembInfo.Controls.Add(this.labelMembID);
            this.groupBoxMembInfo.Location = new System.Drawing.Point(13, 41);
            this.groupBoxMembInfo.Name = "groupBoxMembInfo";
            this.groupBoxMembInfo.Size = new System.Drawing.Size(622, 79);
            this.groupBoxMembInfo.TabIndex = 3;
            this.groupBoxMembInfo.TabStop = false;
            this.groupBoxMembInfo.Text = "Member Information";
            // 
            // textBoxMembCat
            // 
            this.textBoxMembCat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxMembCat.Enabled = false;
            this.textBoxMembCat.Location = new System.Drawing.Point(430, 20);
            this.textBoxMembCat.Name = "textBoxMembCat";
            this.textBoxMembCat.Size = new System.Drawing.Size(186, 20);
            this.textBoxMembCat.TabIndex = 5;
            // 
            // textBoxMembName
            // 
            this.textBoxMembName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxMembName.Enabled = false;
            this.textBoxMembName.Location = new System.Drawing.Point(92, 40);
            this.textBoxMembName.Name = "textBoxMembName";
            this.textBoxMembName.Size = new System.Drawing.Size(231, 20);
            this.textBoxMembName.TabIndex = 4;
            // 
            // textBoxMembID
            // 
            this.textBoxMembID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxMembID.Enabled = false;
            this.textBoxMembID.Location = new System.Drawing.Point(92, 17);
            this.textBoxMembID.Name = "textBoxMembID";
            this.textBoxMembID.Size = new System.Drawing.Size(100, 20);
            this.textBoxMembID.TabIndex = 3;
            // 
            // labelMembCat
            // 
            this.labelMembCat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelMembCat.AutoSize = true;
            this.labelMembCat.Location = new System.Drawing.Point(336, 20);
            this.labelMembCat.Name = "labelMembCat";
            this.labelMembCat.Size = new System.Drawing.Size(96, 13);
            this.labelMembCat.TabIndex = 2;
            this.labelMembCat.Text = "Member Catagory: ";
            // 
            // labelMembName
            // 
            this.labelMembName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelMembName.AutoSize = true;
            this.labelMembName.Location = new System.Drawing.Point(7, 40);
            this.labelMembName.Name = "labelMembName";
            this.labelMembName.Size = new System.Drawing.Size(79, 13);
            this.labelMembName.TabIndex = 1;
            this.labelMembName.Text = "Member Name:";
            // 
            // labelMembID
            // 
            this.labelMembID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelMembID.AutoSize = true;
            this.labelMembID.Location = new System.Drawing.Point(24, 20);
            this.labelMembID.Name = "labelMembID";
            this.labelMembID.Size = new System.Drawing.Size(65, 13);
            this.labelMembID.TabIndex = 0;
            this.labelMembID.Text = "Member ID: ";
            // 
            // groupBoxBkInfo
            // 
            this.groupBoxBkInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxBkInfo.Controls.Add(this.textBoxDueDate);
            this.groupBoxBkInfo.Controls.Add(this.labelDueDate);
            this.groupBoxBkInfo.Controls.Add(this.textBoxShelfLocal);
            this.groupBoxBkInfo.Controls.Add(this.labelBkLocation);
            this.groupBoxBkInfo.Controls.Add(this.textBoxCallNumber);
            this.groupBoxBkInfo.Controls.Add(this.labelBkCallNo);
            this.groupBoxBkInfo.Controls.Add(this.textBoxBkRemark);
            this.groupBoxBkInfo.Controls.Add(this.labelRemarks);
            this.groupBoxBkInfo.Controls.Add(this.textBoxISBN);
            this.groupBoxBkInfo.Controls.Add(this.labelBkISBN);
            this.groupBoxBkInfo.Controls.Add(this.textBoxBkTitle);
            this.groupBoxBkInfo.Controls.Add(this.labelBkTitle);
            this.groupBoxBkInfo.Location = new System.Drawing.Point(13, 127);
            this.groupBoxBkInfo.Name = "groupBoxBkInfo";
            this.groupBoxBkInfo.Size = new System.Drawing.Size(622, 174);
            this.groupBoxBkInfo.TabIndex = 4;
            this.groupBoxBkInfo.TabStop = false;
            this.groupBoxBkInfo.Text = "Book Information";
            // 
            // textBoxDueDate
            // 
            this.textBoxDueDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxDueDate.Enabled = false;
            this.textBoxDueDate.Location = new System.Drawing.Point(430, 27);
            this.textBoxDueDate.Name = "textBoxDueDate";
            this.textBoxDueDate.Size = new System.Drawing.Size(150, 20);
            this.textBoxDueDate.TabIndex = 11;
            // 
            // labelDueDate
            // 
            this.labelDueDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDueDate.AutoSize = true;
            this.labelDueDate.Location = new System.Drawing.Point(368, 30);
            this.labelDueDate.Name = "labelDueDate";
            this.labelDueDate.Size = new System.Drawing.Size(56, 13);
            this.labelDueDate.TabIndex = 10;
            this.labelDueDate.Text = "Due Date:";
            // 
            // textBoxShelfLocal
            // 
            this.textBoxShelfLocal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxShelfLocal.Enabled = false;
            this.textBoxShelfLocal.Location = new System.Drawing.Point(430, 77);
            this.textBoxShelfLocal.Name = "textBoxShelfLocal";
            this.textBoxShelfLocal.Size = new System.Drawing.Size(150, 20);
            this.textBoxShelfLocal.TabIndex = 9;
            // 
            // labelBkLocation
            // 
            this.labelBkLocation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelBkLocation.AutoSize = true;
            this.labelBkLocation.Location = new System.Drawing.Point(346, 79);
            this.labelBkLocation.Name = "labelBkLocation";
            this.labelBkLocation.Size = new System.Drawing.Size(78, 13);
            this.labelBkLocation.TabIndex = 8;
            this.labelBkLocation.Text = "Shelf Location:";
            // 
            // textBoxCallNumber
            // 
            this.textBoxCallNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxCallNumber.Enabled = false;
            this.textBoxCallNumber.Location = new System.Drawing.Point(430, 52);
            this.textBoxCallNumber.Name = "textBoxCallNumber";
            this.textBoxCallNumber.Size = new System.Drawing.Size(150, 20);
            this.textBoxCallNumber.TabIndex = 7;
            // 
            // labelBkCallNo
            // 
            this.labelBkCallNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelBkCallNo.AutoSize = true;
            this.labelBkCallNo.Location = new System.Drawing.Point(357, 54);
            this.labelBkCallNo.Name = "labelBkCallNo";
            this.labelBkCallNo.Size = new System.Drawing.Size(67, 13);
            this.labelBkCallNo.TabIndex = 6;
            this.labelBkCallNo.Text = "Call Number:";
            // 
            // textBoxBkRemark
            // 
            this.textBoxBkRemark.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxBkRemark.Location = new System.Drawing.Point(6, 103);
            this.textBoxBkRemark.Multiline = true;
            this.textBoxBkRemark.Name = "textBoxBkRemark";
            this.textBoxBkRemark.Size = new System.Drawing.Size(610, 65);
            this.textBoxBkRemark.TabIndex = 5;
            // 
            // labelRemarks
            // 
            this.labelRemarks.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelRemarks.AutoSize = true;
            this.labelRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRemarks.Location = new System.Drawing.Point(7, 83);
            this.labelRemarks.Name = "labelRemarks";
            this.labelRemarks.Size = new System.Drawing.Size(74, 16);
            this.labelRemarks.TabIndex = 4;
            this.labelRemarks.Text = "Remarks:";
            // 
            // textBoxISBN
            // 
            this.textBoxISBN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxISBN.Enabled = false;
            this.textBoxISBN.Location = new System.Drawing.Point(92, 53);
            this.textBoxISBN.Name = "textBoxISBN";
            this.textBoxISBN.Size = new System.Drawing.Size(231, 20);
            this.textBoxISBN.TabIndex = 3;
            // 
            // labelBkISBN
            // 
            this.labelBkISBN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelBkISBN.AutoSize = true;
            this.labelBkISBN.Location = new System.Drawing.Point(47, 56);
            this.labelBkISBN.Name = "labelBkISBN";
            this.labelBkISBN.Size = new System.Drawing.Size(35, 13);
            this.labelBkISBN.TabIndex = 2;
            this.labelBkISBN.Text = "ISBN:";
            // 
            // textBoxBkTitle
            // 
            this.textBoxBkTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxBkTitle.Enabled = false;
            this.textBoxBkTitle.Location = new System.Drawing.Point(92, 27);
            this.textBoxBkTitle.Name = "textBoxBkTitle";
            this.textBoxBkTitle.Size = new System.Drawing.Size(231, 20);
            this.textBoxBkTitle.TabIndex = 1;
            // 
            // labelBkTitle
            // 
            this.labelBkTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelBkTitle.AutoSize = true;
            this.labelBkTitle.Location = new System.Drawing.Point(24, 30);
            this.labelBkTitle.Name = "labelBkTitle";
            this.labelBkTitle.Size = new System.Drawing.Size(58, 13);
            this.labelBkTitle.TabIndex = 0;
            this.labelBkTitle.Text = "Book Title:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(283, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // buttonReturn
            // 
            this.buttonReturn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReturn.Location = new System.Drawing.Point(445, 305);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(75, 23);
            this.buttonReturn.TabIndex = 6;
            this.buttonReturn.Text = "Return";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(554, 305);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Close";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelReturnDate
            // 
            this.labelReturnDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelReturnDate.AutoSize = true;
            this.labelReturnDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReturnDate.Location = new System.Drawing.Point(432, 19);
            this.labelReturnDate.Name = "labelReturnDate";
            this.labelReturnDate.Size = new System.Drawing.Size(88, 15);
            this.labelReturnDate.TabIndex = 8;
            this.labelReturnDate.Text = "Return Date:";
            // 
            // dateTimePickerReturnDate
            // 
            this.dateTimePickerReturnDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerReturnDate.CustomFormat = "dd-MMM-yyyy";
            this.dateTimePickerReturnDate.Enabled = false;
            this.dateTimePickerReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerReturnDate.Location = new System.Drawing.Point(526, 17);
            this.dateTimePickerReturnDate.Name = "dateTimePickerReturnDate";
            this.dateTimePickerReturnDate.Size = new System.Drawing.Size(103, 20);
            this.dateTimePickerReturnDate.TabIndex = 9;
            // 
            // ReturnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 340);
            this.Controls.Add(this.dateTimePickerReturnDate);
            this.Controls.Add(this.labelReturnDate);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxBkInfo);
            this.Controls.Add(this.groupBoxMembInfo);
            this.Controls.Add(this.buttonRetrievebk);
            this.Controls.Add(this.textBoxBookID);
            this.Controls.Add(this.labelBookID);
            this.Name = "ReturnForm";
            this.Text = "Return Books";
            this.groupBoxMembInfo.ResumeLayout(false);
            this.groupBoxMembInfo.PerformLayout();
            this.groupBoxBkInfo.ResumeLayout(false);
            this.groupBoxBkInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBookID;
        private System.Windows.Forms.TextBox textBoxBookID;
        private System.Windows.Forms.Button buttonRetrievebk;
        private System.Windows.Forms.GroupBox groupBoxMembInfo;
        private System.Windows.Forms.TextBox textBoxMembCat;
        private System.Windows.Forms.TextBox textBoxMembName;
        private System.Windows.Forms.TextBox textBoxMembID;
        private System.Windows.Forms.Label labelMembCat;
        private System.Windows.Forms.Label labelMembName;
        private System.Windows.Forms.Label labelMembID;
        private System.Windows.Forms.GroupBox groupBoxBkInfo;
        private System.Windows.Forms.TextBox textBoxDueDate;
        private System.Windows.Forms.Label labelDueDate;
        private System.Windows.Forms.TextBox textBoxShelfLocal;
        private System.Windows.Forms.Label labelBkLocation;
        private System.Windows.Forms.TextBox textBoxCallNumber;
        private System.Windows.Forms.Label labelBkCallNo;
        private System.Windows.Forms.TextBox textBoxBkRemark;
        private System.Windows.Forms.Label labelRemarks;
        private System.Windows.Forms.TextBox textBoxISBN;
        private System.Windows.Forms.Label labelBkISBN;
        private System.Windows.Forms.TextBox textBoxBkTitle;
        private System.Windows.Forms.Label labelBkTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelReturnDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerReturnDate;
    }
}