
namespace ClerkForm_2
{
    partial class UserControl1
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.idlbl = new System.Windows.Forms.RadioButton();
            this.productlbl = new System.Windows.Forms.Label();
            this.timelbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(525, 38);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // idlbl
            // 
            this.idlbl.AutoSize = true;
            this.idlbl.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.idlbl.Location = new System.Drawing.Point(12, 7);
            this.idlbl.Name = "idlbl";
            this.idlbl.Size = new System.Drawing.Size(49, 25);
            this.idlbl.TabIndex = 2;
            this.idlbl.Text = "   1";
            this.idlbl.UseVisualStyleBackColor = true;
            this.idlbl.CheckedChanged += new System.EventHandler(this.idlbl_CheckedChanged);
            this.idlbl.Click += new System.EventHandler(this.idlbl_Click);
            // 
            // productlbl
            // 
            this.productlbl.AutoSize = true;
            this.productlbl.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productlbl.Location = new System.Drawing.Point(118, 9);
            this.productlbl.Name = "productlbl";
            this.productlbl.Size = new System.Drawing.Size(102, 21);
            this.productlbl.TabIndex = 3;
            this.productlbl.Text = "상품명 외 1건";
            this.productlbl.Click += new System.EventHandler(this.productlbl_Click);
            // 
            // timelbl
            // 
            this.timelbl.AutoSize = true;
            this.timelbl.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.timelbl.Location = new System.Drawing.Point(345, 9);
            this.timelbl.Name = "timelbl";
            this.timelbl.Size = new System.Drawing.Size(162, 21);
            this.timelbl.TabIndex = 4;
            this.timelbl.Text = "2021-05-20-19:38:28";
            this.timelbl.Click += new System.EventHandler(this.timelbl_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.timelbl);
            this.Controls.Add(this.productlbl);
            this.Controls.Add(this.idlbl);
            this.Controls.Add(this.button1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(525, 38);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton idlbl;
        private System.Windows.Forms.Label productlbl;
        private System.Windows.Forms.Label timelbl;
    }
}
