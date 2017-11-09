namespace DipSA45Team12a
{
    partial class FormEditMembCat
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
            this.labelCatagory = new System.Windows.Forms.Label();
            this.comboBoxCat = new System.Windows.Forms.ComboBox();
            this.textBoxCurQuota = new System.Windows.Forms.TextBox();
            this.textBoxNewQuota = new System.Windows.Forms.TextBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCatagory
            // 
            this.labelCatagory.AutoSize = true;
            this.labelCatagory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCatagory.Location = new System.Drawing.Point(108, 15);
            this.labelCatagory.Name = "labelCatagory";
            this.labelCatagory.Size = new System.Drawing.Size(131, 16);
            this.labelCatagory.TabIndex = 0;
            this.labelCatagory.Text = "Member Catagory";
            // 
            // comboBoxCat
            // 
            this.comboBoxCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCat.FormattingEnabled = true;
            this.comboBoxCat.Items.AddRange(new object[] {
            "UNDERGRADUATE",
            "GRADUATE",
            "STAFF"});
            this.comboBoxCat.Location = new System.Drawing.Point(86, 34);
            this.comboBoxCat.Name = "comboBoxCat";
            this.comboBoxCat.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCat.TabIndex = 1;
            this.comboBoxCat.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBoxCurQuota
            // 
            this.textBoxCurQuota.Enabled = false;
            this.textBoxCurQuota.Location = new System.Drawing.Point(213, 34);
            this.textBoxCurQuota.Name = "textBoxCurQuota";
            this.textBoxCurQuota.Size = new System.Drawing.Size(28, 20);
            this.textBoxCurQuota.TabIndex = 2;
            // 
            // textBoxNewQuota
            // 
            this.textBoxNewQuota.Location = new System.Drawing.Point(149, 95);
            this.textBoxNewQuota.Name = "textBoxNewQuota";
            this.textBoxNewQuota.Size = new System.Drawing.Size(40, 20);
            this.textBoxNewQuota.TabIndex = 3;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(77, 134);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(75, 23);
            this.buttonSubmit.TabIndex = 4;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "New Loan Quota";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(166, 134);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormEditMembCat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 210);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.textBoxNewQuota);
            this.Controls.Add(this.textBoxCurQuota);
            this.Controls.Add(this.comboBoxCat);
            this.Controls.Add(this.labelCatagory);
            this.Name = "FormEditMembCat";
            this.Text = "Manage Member Category";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCatagory;
        private System.Windows.Forms.ComboBox comboBoxCat;
        private System.Windows.Forms.TextBox textBoxCurQuota;
        private System.Windows.Forms.TextBox textBoxNewQuota;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCancel;
    }
}