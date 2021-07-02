
namespace ClerkForm_2
{
    partial class ConfigForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.changeBtn = new System.Windows.Forms.Button();
            this.checkPw = new System.Windows.Forms.TextBox();
            this.newPW = new System.Windows.Forms.TextBox();
            this.nowPw = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(74, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 26);
            this.label2.TabIndex = 11;
            this.label2.Text = "비밀번호 변경";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.changeBtn);
            this.panel1.Controls.Add(this.checkPw);
            this.panel1.Controls.Add(this.newPW);
            this.panel1.Controls.Add(this.nowPw);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(34, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(551, 223);
            this.panel1.TabIndex = 12;
            // 
            // changeBtn
            // 
            this.changeBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.changeBtn.Location = new System.Drawing.Point(94, 160);
            this.changeBtn.Name = "changeBtn";
            this.changeBtn.Size = new System.Drawing.Size(75, 32);
            this.changeBtn.TabIndex = 13;
            this.changeBtn.Text = "변경";
            this.changeBtn.UseVisualStyleBackColor = true;
            this.changeBtn.Click += new System.EventHandler(this.changeBtn_Click);
            // 
            // checkPw
            // 
            this.checkPw.Location = new System.Drawing.Point(163, 121);
            this.checkPw.Name = "checkPw";
            this.checkPw.Size = new System.Drawing.Size(100, 21);
            this.checkPw.TabIndex = 12;
            // 
            // newPW
            // 
            this.newPW.Location = new System.Drawing.Point(163, 80);
            this.newPW.Name = "newPW";
            this.newPW.Size = new System.Drawing.Size(100, 21);
            this.newPW.TabIndex = 12;
            // 
            // nowPw
            // 
            this.nowPw.Location = new System.Drawing.Point(163, 34);
            this.nowPw.Name = "nowPw";
            this.nowPw.Size = new System.Drawing.Size(100, 21);
            this.nowPw.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(40, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "비밀번호 확인";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(40, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "새로운 비밀번호";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(40, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "현재 비밀번호";
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(618, 304);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Name = "ConfigForm";
            this.Text = "ConfigForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox nowPw;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button changeBtn;
        private System.Windows.Forms.TextBox checkPw;
        private System.Windows.Forms.TextBox newPW;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}