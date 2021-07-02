
namespace ClerkForm_2
{
    partial class Form1
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.configBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.calculateBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.orderCompleteBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.orderListBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.managerId = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.configBtn);
            this.panel1.Controls.Add(this.calculateBtn);
            this.panel1.Controls.Add(this.orderCompleteBtn);
            this.panel1.Controls.Add(this.orderListBtn);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(146, 450);
            this.panel1.TabIndex = 0;
            // 
            // configBtn
            // 
            this.configBtn.AnimationHoverSpeed = 0.07F;
            this.configBtn.AnimationSpeed = 0.03F;
            this.configBtn.BackColor = System.Drawing.Color.Transparent;
            this.configBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.configBtn.BorderColor = System.Drawing.Color.Black;
            this.configBtn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.configBtn.CheckedBorderColor = System.Drawing.Color.Black;
            this.configBtn.CheckedForeColor = System.Drawing.Color.White;
            this.configBtn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("configBtn.CheckedImage")));
            this.configBtn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.configBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.configBtn.FocusedColor = System.Drawing.Color.Empty;
            this.configBtn.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold);
            this.configBtn.ForeColor = System.Drawing.Color.Maroon;
            this.configBtn.Image = null;
            this.configBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.configBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.configBtn.Location = new System.Drawing.Point(8, 313);
            this.configBtn.Name = "configBtn";
            this.configBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.configBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.configBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.configBtn.OnHoverImage = null;
            this.configBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.configBtn.OnPressedColor = System.Drawing.Color.Black;
            this.configBtn.Radius = 20;
            this.configBtn.Size = new System.Drawing.Size(156, 42);
            this.configBtn.TabIndex = 5;
            this.configBtn.Text = "비밀번호 변경";
            this.configBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.configBtn.Click += new System.EventHandler(this.configBtn_Click);
            // 
            // calculateBtn
            // 
            this.calculateBtn.AnimationHoverSpeed = 0.07F;
            this.calculateBtn.AnimationSpeed = 0.03F;
            this.calculateBtn.BackColor = System.Drawing.Color.Transparent;
            this.calculateBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.calculateBtn.BorderColor = System.Drawing.Color.Black;
            this.calculateBtn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.calculateBtn.CheckedBorderColor = System.Drawing.Color.Black;
            this.calculateBtn.CheckedForeColor = System.Drawing.Color.White;
            this.calculateBtn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("calculateBtn.CheckedImage")));
            this.calculateBtn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.calculateBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.calculateBtn.FocusedColor = System.Drawing.Color.Empty;
            this.calculateBtn.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold);
            this.calculateBtn.ForeColor = System.Drawing.Color.Maroon;
            this.calculateBtn.Image = null;
            this.calculateBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.calculateBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.calculateBtn.Location = new System.Drawing.Point(8, 263);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.calculateBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.calculateBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.calculateBtn.OnHoverImage = null;
            this.calculateBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.calculateBtn.OnPressedColor = System.Drawing.Color.Black;
            this.calculateBtn.Radius = 20;
            this.calculateBtn.Size = new System.Drawing.Size(156, 42);
            this.calculateBtn.TabIndex = 5;
            this.calculateBtn.Text = "계산기";
            this.calculateBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // orderCompleteBtn
            // 
            this.orderCompleteBtn.AnimationHoverSpeed = 0.07F;
            this.orderCompleteBtn.AnimationSpeed = 0.03F;
            this.orderCompleteBtn.BackColor = System.Drawing.Color.Transparent;
            this.orderCompleteBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.orderCompleteBtn.BorderColor = System.Drawing.Color.Black;
            this.orderCompleteBtn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.orderCompleteBtn.CheckedBorderColor = System.Drawing.Color.Black;
            this.orderCompleteBtn.CheckedForeColor = System.Drawing.Color.White;
            this.orderCompleteBtn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("orderCompleteBtn.CheckedImage")));
            this.orderCompleteBtn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.orderCompleteBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.orderCompleteBtn.FocusedColor = System.Drawing.Color.Empty;
            this.orderCompleteBtn.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold);
            this.orderCompleteBtn.ForeColor = System.Drawing.Color.Maroon;
            this.orderCompleteBtn.Image = null;
            this.orderCompleteBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.orderCompleteBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.orderCompleteBtn.Location = new System.Drawing.Point(8, 213);
            this.orderCompleteBtn.Name = "orderCompleteBtn";
            this.orderCompleteBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.orderCompleteBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.orderCompleteBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.orderCompleteBtn.OnHoverImage = null;
            this.orderCompleteBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.orderCompleteBtn.OnPressedColor = System.Drawing.Color.Black;
            this.orderCompleteBtn.Radius = 20;
            this.orderCompleteBtn.Size = new System.Drawing.Size(156, 42);
            this.orderCompleteBtn.TabIndex = 5;
            this.orderCompleteBtn.Text = "주문 완료";
            this.orderCompleteBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.orderCompleteBtn.Click += new System.EventHandler(this.orderCompleteBtn_Click);
            // 
            // orderListBtn
            // 
            this.orderListBtn.AnimationHoverSpeed = 0.07F;
            this.orderListBtn.AnimationSpeed = 0.03F;
            this.orderListBtn.BackColor = System.Drawing.Color.Transparent;
            this.orderListBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.orderListBtn.BorderColor = System.Drawing.Color.Black;
            this.orderListBtn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.orderListBtn.CheckedBorderColor = System.Drawing.Color.Black;
            this.orderListBtn.CheckedForeColor = System.Drawing.Color.White;
            this.orderListBtn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("orderListBtn.CheckedImage")));
            this.orderListBtn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.orderListBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.orderListBtn.FocusedColor = System.Drawing.Color.Empty;
            this.orderListBtn.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold);
            this.orderListBtn.ForeColor = System.Drawing.Color.Maroon;
            this.orderListBtn.Image = null;
            this.orderListBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.orderListBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.orderListBtn.Location = new System.Drawing.Point(8, 163);
            this.orderListBtn.Name = "orderListBtn";
            this.orderListBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.orderListBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.orderListBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.orderListBtn.OnHoverImage = null;
            this.orderListBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.orderListBtn.OnPressedColor = System.Drawing.Color.Black;
            this.orderListBtn.Radius = 20;
            this.orderListBtn.Size = new System.Drawing.Size(156, 42);
            this.orderListBtn.TabIndex = 5;
            this.orderListBtn.Text = "주문 내역";
            this.orderListBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.orderListBtn.Click += new System.EventHandler(this.orderListBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ClerkForm_2.Properties.Resources.롯데리아_로고;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Snow;
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.contentPanel);
            this.panel2.Controls.Add(this.managerId);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(146, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(654, 450);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ClerkForm_2.Properties.Resources.창업1;
            this.pictureBox3.Location = new System.Drawing.Point(24, 10);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(444, 100);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // contentPanel
            // 
            this.contentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.contentPanel.Location = new System.Drawing.Point(24, 118);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(618, 304);
            this.contentPanel.TabIndex = 3;
            // 
            // managerId
            // 
            this.managerId.AutoSize = true;
            this.managerId.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.managerId.Location = new System.Drawing.Point(522, 66);
            this.managerId.Name = "managerId";
            this.managerId.Size = new System.Drawing.Size(64, 21);
            this.managerId.TabIndex = 2;
            this.managerId.Text = "관리자1";
            this.managerId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ClerkForm_2.Properties.Resources.카톡프사;
            this.pictureBox2.Location = new System.Drawing.Point(592, 49);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "롯데리아 주문 현황";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Label managerId;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI.WinForms.GunaAdvenceButton orderListBtn;
        private Guna.UI.WinForms.GunaAdvenceButton configBtn;
        private Guna.UI.WinForms.GunaAdvenceButton calculateBtn;
        private Guna.UI.WinForms.GunaAdvenceButton orderCompleteBtn;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

