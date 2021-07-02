
namespace ClerkForm_2
{
    partial class OrderListForm
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
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.completeBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(456, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 26);
            this.label6.TabIndex = 4;
            this.label6.Text = "주문 일자";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(166, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "주문 상품";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(74, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "No.";
            // 
            // completeBtn
            // 
            this.completeBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Bold);
            this.completeBtn.Location = new System.Drawing.Point(460, 259);
            this.completeBtn.Name = "completeBtn";
            this.completeBtn.Size = new System.Drawing.Size(125, 33);
            this.completeBtn.TabIndex = 0;
            this.completeBtn.Text = "주문 완료";
            this.completeBtn.UseVisualStyleBackColor = true;
            this.completeBtn.Click += new System.EventHandler(this.completeBtn_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panel1.Location = new System.Drawing.Point(34, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(551, 199);
            this.panel1.TabIndex = 7;
            this.panel1.WrapContents = false;
            // 
            // OrderListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(618, 304);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.completeBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "OrderListForm";
            this.Text = "OrderListForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button completeBtn;
        private System.Windows.Forms.FlowLayoutPanel panel1;
    }
}