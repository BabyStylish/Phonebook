namespace Phonebook
{
    partial class Register_Data
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnNewData = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSaveChanges = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.infoGroupBox = new System.Windows.Forms.GroupBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.infoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2,
            this.btnNewData,
            this.toolStripSeparator3,
            this.btnSaveChanges,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(492, 84);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 84);
            // 
            // btnNewData
            // 
            this.btnNewData.Image = global::Phonebook.Properties.Resources._296566_file_directory_ordered_order_instructions_icon;
            this.btnNewData.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnNewData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNewData.Name = "btnNewData";
            this.btnNewData.Size = new System.Drawing.Size(110, 81);
            this.btnNewData.Text = "New Data";
            this.btnNewData.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 84);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Enabled = false;
            this.btnSaveChanges.Image = global::Phonebook.Properties.Resources._285657_floppy_guardar_save_icon;
            this.btnSaveChanges.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSaveChanges.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(132, 81);
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 84);
            // 
            // infoGroupBox
            // 
            this.infoGroupBox.Controls.Add(this.btnClear);
            this.infoGroupBox.Controls.Add(this.label8);
            this.infoGroupBox.Controls.Add(this.label5);
            this.infoGroupBox.Controls.Add(this.label6);
            this.infoGroupBox.Controls.Add(this.label3);
            this.infoGroupBox.Controls.Add(this.label4);
            this.infoGroupBox.Controls.Add(this.txtComment);
            this.infoGroupBox.Controls.Add(this.txtAddress);
            this.infoGroupBox.Controls.Add(this.txtEmail);
            this.infoGroupBox.Controls.Add(this.txtPhoneNumber);
            this.infoGroupBox.Controls.Add(this.txtLName);
            this.infoGroupBox.Controls.Add(this.txtFName);
            this.infoGroupBox.Controls.Add(this.label2);
            this.infoGroupBox.Controls.Add(this.txtID);
            this.infoGroupBox.Controls.Add(this.label1);
            this.infoGroupBox.Enabled = false;
            this.infoGroupBox.Location = new System.Drawing.Point(13, 88);
            this.infoGroupBox.Name = "infoGroupBox";
            this.infoGroupBox.Size = new System.Drawing.Size(452, 332);
            this.infoGroupBox.TabIndex = 2;
            this.infoGroupBox.TabStop = false;
            this.infoGroupBox.Text = "Information";
            this.infoGroupBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(88, 59);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(239, 20);
            this.txtID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(88, 85);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(239, 20);
            this.txtFName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "First Name";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(88, 137);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(239, 20);
            this.txtPhoneNumber.TabIndex = 5;
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(88, 111);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(239, 20);
            this.txtLName.TabIndex = 4;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(88, 189);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(239, 20);
            this.txtAddress.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(88, 163);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(239, 20);
            this.txtEmail.TabIndex = 6;
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(88, 215);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(239, 20);
            this.txtComment.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Phone Number";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Last Name";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Comment";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(338, 282);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(108, 44);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Register_Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 474);
            this.Controls.Add(this.infoGroupBox);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Register_Data";
            this.Text = "Form2";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.infoGroupBox.ResumeLayout(false);
            this.infoGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNewData;
        private System.Windows.Forms.ToolStripButton btnSaveChanges;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.GroupBox infoGroupBox;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnClear;
    }
}