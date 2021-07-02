
namespace ClerkForm_2
{
    partial class LoginForm
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
            this.loginBtn = new System.Windows.Forms.Button();
            this.idLbl = new System.Windows.Forms.Label();
            this.passLbl = new System.Windows.Forms.Label();
            this.idTBox = new System.Windows.Forms.TextBox();
            this.PassTBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(56, 362);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(216, 41);
            this.loginBtn.TabIndex = 0;
            this.loginBtn.Text = "login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // idLbl
            // 
            this.idLbl.AutoSize = true;
            this.idLbl.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.idLbl.Location = new System.Drawing.Point(57, 132);
            this.idLbl.Name = "idLbl";
            this.idLbl.Size = new System.Drawing.Size(27, 21);
            this.idLbl.TabIndex = 1;
            this.idLbl.Text = "ID";
            // 
            // passLbl
            // 
            this.passLbl.AutoSize = true;
            this.passLbl.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.passLbl.Location = new System.Drawing.Point(57, 233);
            this.passLbl.Name = "passLbl";
            this.passLbl.Size = new System.Drawing.Size(85, 21);
            this.passLbl.TabIndex = 1;
            this.passLbl.Text = "PassWord";
            // 
            // idTBox
            // 
            this.idTBox.Location = new System.Drawing.Point(61, 178);
            this.idTBox.Name = "idTBox";
            this.idTBox.Size = new System.Drawing.Size(180, 21);
            this.idTBox.TabIndex = 2;
            // 
            // PassTBox
            // 
            this.PassTBox.Location = new System.Drawing.Point(61, 280);
            this.PassTBox.Name = "PassTBox";
            this.PassTBox.Size = new System.Drawing.Size(180, 21);
            this.PassTBox.TabIndex = 2;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(326, 450);
            this.Controls.Add(this.PassTBox);
            this.Controls.Add(this.idTBox);
            this.Controls.Add(this.passLbl);
            this.Controls.Add(this.idLbl);
            this.Controls.Add(this.loginBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "로그인";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label idLbl;
        private System.Windows.Forms.Label passLbl;
        private System.Windows.Forms.TextBox idTBox;
        private System.Windows.Forms.TextBox PassTBox;
    }
}