
namespace ADOdotNetConecterArchitecture
{
    partial class DisconnectedForm1
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
            this.btnshow.Location = new System.Drawing.Point(432, 266);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(172, 23);
            this.btnshow.TabIndex = 35;
            this.btnshow.Text = "Show All Emps";
            this.btnshow.UseVisualStyleBackColor = true;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // empgrid
            // 
            this.empgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.empgrid.Location = new System.Drawing.Point(349, 56);
            this.empgrid.Name = "empgrid";
            this.empgrid.Size = new System.Drawing.Size(341, 189);
            this.empgrid.TabIndex = 34;
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(102, 266);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 33;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(199, 266);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(84, 23);
            this.btnsearch.TabIndex = 32;
            this.btnsearch.Text = "Search By ID";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(199, 222);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 31;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(102, 222);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 30;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // txtsal
            // 
            this.txtsal.Location = new System.Drawing.Point(174, 177);
            this.txtsal.Name = "txtsal";
            this.txtsal.Size = new System.Drawing.Size(100, 20);
            this.txtsal.TabIndex = 29;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(174, 116);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 20);
            this.txtname.TabIndex = 28;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(174, 56);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 27;
            // 
            // lblsal
            // 
            this.lblsal.AutoSize = true;
            this.lblsal.Location = new System.Drawing.Point(100, 180);
            this.lblsal.Name = "lblsal";
            this.lblsal.Size = new System.Drawing.Size(36, 13);
            this.lblsal.TabIndex = 26;
            this.lblsal.Text = "Salary";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(100, 119);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(35, 13);
            this.lblname.TabIndex = 25;
            this.lblname.Text = "Name";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(99, 59);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(42, 13);
            this.lblid.TabIndex = 24;
            this.lblid.Text = "Emp ID";
            // 
            // DisconnectedForm1
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
            this.Name = "DisconnectedForm1";
            this.Text = "Disconnected Demo";
            this.Load += new System.EventHandler(this.DisconnectedForm1_Load);
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