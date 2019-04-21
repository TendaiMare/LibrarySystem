﻿namespace LibrarySystem
{
    partial class frmReturn
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboStudent = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboBooks = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.BtnReturnBook = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student";
            // 
            // cboStudent
            // 
            this.cboStudent.FormattingEnabled = true;
            this.cboStudent.Location = new System.Drawing.Point(95, 31);
            this.cboStudent.Name = "cboStudent";
            this.cboStudent.Size = new System.Drawing.Size(280, 21);
            this.cboStudent.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Books";
            // 
            // cboBooks
            // 
            this.cboBooks.FormattingEnabled = true;
            this.cboBooks.Location = new System.Drawing.Point(95, 65);
            this.cboBooks.Name = "cboBooks";
            this.cboBooks.Size = new System.Drawing.Size(280, 21);
            this.cboBooks.TabIndex = 3;
            this.cboBooks.SelectedIndexChanged += new System.EventHandler(this.cboBooks_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Due Date";
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.Location = new System.Drawing.Point(95, 116);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(280, 20);
            this.dtpDueDate.TabIndex = 5;
            // 
            // BtnReturnBook
            // 
            this.BtnReturnBook.Location = new System.Drawing.Point(21, 185);
            this.BtnReturnBook.Name = "BtnReturnBook";
            this.BtnReturnBook.Size = new System.Drawing.Size(129, 26);
            this.BtnReturnBook.TabIndex = 6;
            this.BtnReturnBook.Text = "Return Book";
            this.BtnReturnBook.UseVisualStyleBackColor = true;
            this.BtnReturnBook.Click += new System.EventHandler(this.BtnReturnBook_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(174, 185);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(104, 25);
            this.BtnClear.TabIndex = 7;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(301, 186);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(104, 25);
            this.BtnCancel.TabIndex = 8;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // frmReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 242);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnReturnBook);
            this.Controls.Add(this.dtpDueDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboBooks);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboStudent);
            this.Controls.Add(this.label1);
            this.Name = "frmReturn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Return";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboStudent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboBooks;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.Button BtnReturnBook;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnCancel;
    }
}