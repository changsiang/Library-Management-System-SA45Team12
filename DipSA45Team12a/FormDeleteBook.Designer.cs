namespace DipSA45Team12a
{
    partial class FormDeleteBook
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
            this.buttonDelete = new System.Windows.Forms.Button();
            this.groupBoxBkInfo = new System.Windows.Forms.GroupBox();
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
            this.buttonRetrievebk = new System.Windows.Forms.Button();
            this.textBoxBookID = new System.Windows.Forms.TextBox();
            this.labelBookID = new System.Windows.Forms.Label();
            this.groupBoxBkInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(545, 227);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 17;
            this.buttonCancel.Text = "Close";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(436, 227);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 16;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // groupBoxBkInfo
            // 
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
            this.groupBoxBkInfo.Location = new System.Drawing.Point(4, 49);
            this.groupBoxBkInfo.Name = "groupBoxBkInfo";
            this.groupBoxBkInfo.Size = new System.Drawing.Size(622, 174);
            this.groupBoxBkInfo.TabIndex = 14;
            this.groupBoxBkInfo.TabStop = false;
            this.groupBoxBkInfo.Text = "Book Information";
            // 
            // textBoxShelfLocal
            // 
            this.textBoxShelfLocal.Enabled = false;
            this.textBoxShelfLocal.Location = new System.Drawing.Point(432, 52);
            this.textBoxShelfLocal.Name = "textBoxShelfLocal";
            this.textBoxShelfLocal.Size = new System.Drawing.Size(150, 20);
            this.textBoxShelfLocal.TabIndex = 9;
            // 
            // labelBkLocation
            // 
            this.labelBkLocation.AutoSize = true;
            this.labelBkLocation.Location = new System.Drawing.Point(348, 54);
            this.labelBkLocation.Name = "labelBkLocation";
            this.labelBkLocation.Size = new System.Drawing.Size(78, 13);
            this.labelBkLocation.TabIndex = 8;
            this.labelBkLocation.Text = "Shelf Location:";
            // 
            // textBoxCallNumber
            // 
            this.textBoxCallNumber.Enabled = false;
            this.textBoxCallNumber.Location = new System.Drawing.Point(432, 27);
            this.textBoxCallNumber.Name = "textBoxCallNumber";
            this.textBoxCallNumber.Size = new System.Drawing.Size(150, 20);
            this.textBoxCallNumber.TabIndex = 7;
            // 
            // labelBkCallNo
            // 
            this.labelBkCallNo.AutoSize = true;
            this.labelBkCallNo.Location = new System.Drawing.Point(359, 29);
            this.labelBkCallNo.Name = "labelBkCallNo";
            this.labelBkCallNo.Size = new System.Drawing.Size(67, 13);
            this.labelBkCallNo.TabIndex = 6;
            this.labelBkCallNo.Text = "Call Number:";
            // 
            // textBoxBkRemark
            // 
            this.textBoxBkRemark.Location = new System.Drawing.Point(6, 103);
            this.textBoxBkRemark.Multiline = true;
            this.textBoxBkRemark.Name = "textBoxBkRemark";
            this.textBoxBkRemark.Size = new System.Drawing.Size(610, 65);
            this.textBoxBkRemark.TabIndex = 5;
            // 
            // labelRemarks
            // 
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
            this.textBoxISBN.Enabled = false;
            this.textBoxISBN.Location = new System.Drawing.Point(92, 53);
            this.textBoxISBN.Name = "textBoxISBN";
            this.textBoxISBN.Size = new System.Drawing.Size(231, 20);
            this.textBoxISBN.TabIndex = 3;
            // 
            // labelBkISBN
            // 
            this.labelBkISBN.AutoSize = true;
            this.labelBkISBN.Location = new System.Drawing.Point(47, 56);
            this.labelBkISBN.Name = "labelBkISBN";
            this.labelBkISBN.Size = new System.Drawing.Size(35, 13);
            this.labelBkISBN.TabIndex = 2;
            this.labelBkISBN.Text = "ISBN:";
            // 
            // textBoxBkTitle
            // 
            this.textBoxBkTitle.Enabled = false;
            this.textBoxBkTitle.Location = new System.Drawing.Point(92, 27);
            this.textBoxBkTitle.Name = "textBoxBkTitle";
            this.textBoxBkTitle.Size = new System.Drawing.Size(231, 20);
            this.textBoxBkTitle.TabIndex = 1;
            // 
            // labelBkTitle
            // 
            this.labelBkTitle.AutoSize = true;
            this.labelBkTitle.Location = new System.Drawing.Point(24, 30);
            this.labelBkTitle.Name = "labelBkTitle";
            this.labelBkTitle.Size = new System.Drawing.Size(58, 13);
            this.labelBkTitle.TabIndex = 0;
            this.labelBkTitle.Text = "Book Title:";
            // 
            // buttonRetrievebk
            // 
            this.buttonRetrievebk.Location = new System.Drawing.Point(177, 17);
            this.buttonRetrievebk.Name = "buttonRetrievebk";
            this.buttonRetrievebk.Size = new System.Drawing.Size(75, 23);
            this.buttonRetrievebk.TabIndex = 12;
            this.buttonRetrievebk.Text = "Retrieve";
            this.buttonRetrievebk.UseVisualStyleBackColor = true;
            this.buttonRetrievebk.Click += new System.EventHandler(this.buttonRetrievebk_Click);
            // 
            // textBoxBookID
            // 
            this.textBoxBookID.Location = new System.Drawing.Point(70, 17);
            this.textBoxBookID.Name = "textBoxBookID";
            this.textBoxBookID.Size = new System.Drawing.Size(100, 20);
            this.textBoxBookID.TabIndex = 11;
            // 
            // labelBookID
            // 
            this.labelBookID.AutoSize = true;
            this.labelBookID.Location = new System.Drawing.Point(12, 20);
            this.labelBookID.Name = "labelBookID";
            this.labelBookID.Size = new System.Drawing.Size(52, 13);
            this.labelBookID.TabIndex = 10;
            this.labelBookID.Text = "Book ID: ";
            // 
            // FormDeleteBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 266);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.groupBoxBkInfo);
            this.Controls.Add(this.buttonRetrievebk);
            this.Controls.Add(this.textBoxBookID);
            this.Controls.Add(this.labelBookID);
            this.Name = "FormDeleteBook";
            this.Text = "Delete Book";
            this.Load += new System.EventHandler(this.FormDeleteBook_Load);
            this.groupBoxBkInfo.ResumeLayout(false);
            this.groupBoxBkInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.GroupBox groupBoxBkInfo;
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
        private System.Windows.Forms.Button buttonRetrievebk;
        private System.Windows.Forms.TextBox textBoxBookID;
        private System.Windows.Forms.Label labelBookID;
    }
}