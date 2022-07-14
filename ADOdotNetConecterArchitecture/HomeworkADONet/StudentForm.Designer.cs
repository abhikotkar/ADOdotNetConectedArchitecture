
namespace ADOdotNetConecterArchitecture.HomeworkADONet
{
    partial class StudentForm
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
            this.txtperc = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtno = new System.Windows.Forms.TextBox();
            this.lblperc = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lblno = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.empgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnshow
            // 
            this.btnshow.Location = new System.Drawing.Point(437, 259);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(172, 23);
            this.btnshow.TabIndex = 59;
            this.btnshow.Text = "Show All Emps";
            this.btnshow.UseVisualStyleBackColor = true;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // empgrid
            // 
            this.empgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.empgrid.Location = new System.Drawing.Point(354, 49);
            this.empgrid.Name = "empgrid";
            this.empgrid.Size = new System.Drawing.Size(341, 189);
            this.empgrid.TabIndex = 58;
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(107, 259);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 57;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(204, 259);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(84, 23);
            this.btnsearch.TabIndex = 56;
            this.btnsearch.Text = "Search By ID";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(204, 215);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 55;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(107, 215);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 54;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // txtperc
            // 
            this.txtperc.Location = new System.Drawing.Point(179, 170);
            this.txtperc.Name = "txtperc";
            this.txtperc.Size = new System.Drawing.Size(100, 20);
            this.txtperc.TabIndex = 53;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(179, 109);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 20);
            this.txtname.TabIndex = 52;
            // 
            // txtno
            // 
            this.txtno.Location = new System.Drawing.Point(179, 49);
            this.txtno.Name = "txtno";
            this.txtno.Size = new System.Drawing.Size(100, 20);
            this.txtno.TabIndex = 51;
            // 
            // lblperc
            // 
            this.lblperc.AutoSize = true;
            this.lblperc.Location = new System.Drawing.Point(105, 173);
            this.lblperc.Name = "lblperc";
            this.lblperc.Size = new System.Drawing.Size(62, 13);
            this.lblperc.TabIndex = 50;
            this.lblperc.Text = "Percentage";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(105, 112);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(35, 13);
            this.lblname.TabIndex = 49;
            this.lblname.Text = "Name";
            // 
            // lblno
            // 
            this.lblno.AutoSize = true;
            this.lblno.Location = new System.Drawing.Point(104, 52);
            this.lblno.Name = "lblno";
            this.lblno.Size = new System.Drawing.Size(42, 13);
            this.lblno.TabIndex = 48;
            this.lblno.Text = "Roll No";
            // 
            // StudentForm
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
            this.Controls.Add(this.txtperc);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtno);
            this.Controls.Add(this.lblperc);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.lblno);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.Load += new System.EventHandler(this.StudentForm_Load);
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
        private System.Windows.Forms.TextBox txtperc;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtno;
        private System.Windows.Forms.Label lblperc;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblno;
    }
}