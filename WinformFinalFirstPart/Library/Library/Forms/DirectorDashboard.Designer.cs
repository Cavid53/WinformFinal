namespace Library.Forms
{
    partial class DirectorDashboard
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
            this.btnNewUser = new System.Windows.Forms.Button();
            this.dgvEmployeeList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNewUser
            // 
            this.btnNewUser.Location = new System.Drawing.Point(857, 12);
            this.btnNewUser.Name = "btnNewUser";
            this.btnNewUser.Size = new System.Drawing.Size(117, 39);
            this.btnNewUser.TabIndex = 0;
            this.btnNewUser.Text = "button1";
            this.btnNewUser.UseVisualStyleBackColor = true;
            this.btnNewUser.Click += new System.EventHandler(this.BtnNewUser_Click);
            // 
            // dgvEmployeeList
            // 
            this.dgvEmployeeList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployeeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployeeList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvEmployeeList.Location = new System.Drawing.Point(0, 310);
            this.dgvEmployeeList.Name = "dgvEmployeeList";
            this.dgvEmployeeList.RowHeadersWidth = 51;
            this.dgvEmployeeList.RowTemplate.Height = 24;
            this.dgvEmployeeList.Size = new System.Drawing.Size(986, 209);
            this.dgvEmployeeList.TabIndex = 1;
            this.dgvEmployeeList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvEmployeeList_CellDoubleClick);
            // 
            // DirectorDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 519);
            this.Controls.Add(this.dgvEmployeeList);
            this.Controls.Add(this.btnNewUser);
            this.Name = "DirectorDashboard";
            this.Text = "DirectorDashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DirectorDashboard_FormClosing);
            this.Load += new System.EventHandler(this.DirectorDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNewUser;
        private System.Windows.Forms.DataGridView dgvEmployeeList;
    }
}