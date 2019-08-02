namespace Library
{
    partial class Login
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
            this.txbLoginEmployeeEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbLoginPassword = new System.Windows.Forms.TextBox();
            this.btnLoginEmployee = new System.Windows.Forms.Button();
            this.btnRegsEmployee = new System.Windows.Forms.Button();
            this.chbPassword = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txbLoginEmployeeEmail
            // 
            this.txbLoginEmployeeEmail.AutoCompleteCustomSource.AddRange(new string[] {
            "cavid@mail.ru",
            "ferid@mail.ru",
            "resad@mail.ru"});
            this.txbLoginEmployeeEmail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txbLoginEmployeeEmail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txbLoginEmployeeEmail.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbLoginEmployeeEmail.Location = new System.Drawing.Point(93, 135);
            this.txbLoginEmployeeEmail.Name = "txbLoginEmployeeEmail";
            this.txbLoginEmployeeEmail.Size = new System.Drawing.Size(346, 42);
            this.txbLoginEmployeeEmail.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Email Address:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password:";
            // 
            // txbLoginPassword
            // 
            this.txbLoginPassword.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbLoginPassword.Location = new System.Drawing.Point(93, 243);
            this.txbLoginPassword.Name = "txbLoginPassword";
            this.txbLoginPassword.Size = new System.Drawing.Size(346, 42);
            this.txbLoginPassword.TabIndex = 2;
            this.txbLoginPassword.UseSystemPasswordChar = true;
            // 
            // btnLoginEmployee
            // 
            this.btnLoginEmployee.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginEmployee.Location = new System.Drawing.Point(276, 361);
            this.btnLoginEmployee.Name = "btnLoginEmployee";
            this.btnLoginEmployee.Size = new System.Drawing.Size(163, 57);
            this.btnLoginEmployee.TabIndex = 4;
            this.btnLoginEmployee.Text = "Login";
            this.btnLoginEmployee.UseVisualStyleBackColor = true;
            this.btnLoginEmployee.Click += new System.EventHandler(this.BtnLoginEmployee_Click);
            // 
            // btnRegsEmployee
            // 
            this.btnRegsEmployee.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegsEmployee.Location = new System.Drawing.Point(93, 361);
            this.btnRegsEmployee.Name = "btnRegsEmployee";
            this.btnRegsEmployee.Size = new System.Drawing.Size(156, 57);
            this.btnRegsEmployee.TabIndex = 5;
            this.btnRegsEmployee.Text = "Register";
            this.btnRegsEmployee.UseVisualStyleBackColor = true;
            this.btnRegsEmployee.Click += new System.EventHandler(this.BtnRegsEmployee_Click);
            // 
            // chbPassword
            // 
            this.chbPassword.AutoSize = true;
            this.chbPassword.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbPassword.Location = new System.Drawing.Point(93, 306);
            this.chbPassword.Name = "chbPassword";
            this.chbPassword.Size = new System.Drawing.Size(140, 20);
            this.chbPassword.TabIndex = 6;
            this.chbPassword.Text = "Show Password";
            this.chbPassword.UseVisualStyleBackColor = true;
            this.chbPassword.CheckedChanged += new System.EventHandler(this.ChbPassword_CheckedChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(529, 502);
            this.Controls.Add(this.chbPassword);
            this.Controls.Add(this.btnRegsEmployee);
            this.Controls.Add(this.btnLoginEmployee);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbLoginPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbLoginEmployeeEmail);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbLoginEmployeeEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbLoginPassword;
        private System.Windows.Forms.Button btnLoginEmployee;
        private System.Windows.Forms.Button btnRegsEmployee;
        private System.Windows.Forms.CheckBox chbPassword;
    }
}

