
namespace ADOdotNetConecterArchitecture
{
    partial class Employee
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
            this.btnshow = new System.Windows.Forms.Button();
            this.empgrid = new System.Windows.Forms.DataGridView();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.txtsal = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.lblsal = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.empgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnshow
            // 
            this.btnshow.Location = new System.Drawing.Point(426, 243);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(172, 23);
            this.btnshow.TabIndex = 23;
            this.btnshow.Text = "Show All Emps";
            this.btnshow.UseVisualStyleBackColor = true;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // empgrid
            // 
            this.empgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.empgrid.Location = new System.Drawing.Point(343, 33);
            this.empgrid.Name = "empgrid";
            this.empgrid.Size = new System.Drawing.Size(341, 189);
            this.empgrid.TabIndex = 22;
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(96, 243);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 21;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(193, 243);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(84, 23);
            this.btnsearch.TabIndex = 20;
            this.btnsearch.Text = "Search By ID";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(193, 199);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 19;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(96, 199);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 18;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // txtsal
            // 
            this.txtsal.Location = new System.Drawing.Point(168, 154);
            this.txtsal.Name = "txtsal";
            this.txtsal.Size = new System.Drawing.Size(100, 20);
            this.txtsal.TabIndex = 17;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(168, 93);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 20);
            this.txtname.TabIndex = 16;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(168, 33);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 15;
            // 
            // lblsal
            // 
            this.lblsal.AutoSize = true;
            this.lblsal.Location = new System.Drawing.Point(94, 157);
            this.lblsal.Name = "lblsal";
            this.lblsal.Size = new System.Drawing.Size(36, 13);
            this.lblsal.TabIndex = 14;
            this.lblsal.Text = "Salary";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(94, 96);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(35, 13);
            this.lblname.TabIndex = 13;
            this.lblname.Text = "Name";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(93, 36);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(42, 13);
            this.lblid.TabIndex = 12;
            this.lblid.Text = "Emp ID";
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnshow);
            this.Controls.Add(this.empgrid);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.txtsal);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.lblsal);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.lblid);
            this.Name = "Employee";
            this.Text = "Employee ADO.Net Connectivity Demo";
            this.Load += new System.EventHandler(this.Employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.empgrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.DataGridView empgrid;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TextBox txtsal;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label lblsal;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblid;
    }
}