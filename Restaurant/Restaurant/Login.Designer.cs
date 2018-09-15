namespace Restaurant
{
    partial class Login
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPkey = new System.Windows.Forms.TextBox();
            this.rdoNorm = new System.Windows.Forms.RadioButton();
            this.rdoAdm = new System.Windows.Forms.RadioButton();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnChg = new System.Windows.Forms.Button();
            this.btnSignup = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(48, 48);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 81);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("华文琥珀", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(192, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "The Megalodon Restaurant";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("华文琥珀", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(269, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Welcome to";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("华文琥珀", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(121, 180);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "User：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("华文琥珀", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(79, 220);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Password：";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(201, 171);
            this.txtUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(248, 25);
            this.txtUser.TabIndex = 5;
            // 
            // txtPkey
            // 
            this.txtPkey.Location = new System.Drawing.Point(201, 220);
            this.txtPkey.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPkey.Name = "txtPkey";
            this.txtPkey.Size = new System.Drawing.Size(248, 25);
            this.txtPkey.TabIndex = 6;
            // 
            // rdoNorm
            // 
            this.rdoNorm.AutoSize = true;
            this.rdoNorm.Font = new System.Drawing.Font("宋体", 9F);
            this.rdoNorm.Location = new System.Drawing.Point(215, 272);
            this.rdoNorm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoNorm.Name = "rdoNorm";
            this.rdoNorm.Size = new System.Drawing.Size(88, 19);
            this.rdoNorm.TabIndex = 7;
            this.rdoNorm.TabStop = true;
            this.rdoNorm.Text = "普通用户";
            this.rdoNorm.UseVisualStyleBackColor = true;
            // 
            // rdoAdm
            // 
            this.rdoAdm.AutoSize = true;
            this.rdoAdm.Font = new System.Drawing.Font("宋体", 9F);
            this.rdoAdm.Location = new System.Drawing.Point(357, 272);
            this.rdoAdm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoAdm.Name = "rdoAdm";
            this.rdoAdm.Size = new System.Drawing.Size(73, 19);
            this.rdoAdm.TabIndex = 8;
            this.rdoAdm.TabStop = true;
            this.rdoAdm.Text = "管理员";
            this.rdoAdm.UseVisualStyleBackColor = true;
            // 
            // btnLog
            // 
            this.btnLog.Location = new System.Drawing.Point(101, 318);
            this.btnLog.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(100, 29);
            this.btnLog.TabIndex = 9;
            this.btnLog.Text = "登录";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // btnChg
            // 
            this.btnChg.Location = new System.Drawing.Point(397, 318);
            this.btnChg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnChg.Name = "btnChg";
            this.btnChg.Size = new System.Drawing.Size(100, 29);
            this.btnChg.TabIndex = 10;
            this.btnChg.Text = "修改密码";
            this.btnChg.UseVisualStyleBackColor = true;
            this.btnChg.Click += new System.EventHandler(this.btnChg_Click);
            // 
            // btnSignup
            // 
            this.btnSignup.Location = new System.Drawing.Point(252, 318);
            this.btnSignup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Size = new System.Drawing.Size(100, 29);
            this.btnSignup.TabIndex = 11;
            this.btnSignup.Text = "注册";
            this.btnSignup.UseVisualStyleBackColor = true;
            this.btnSignup.Click += new System.EventHandler(this.btnSignup_Click);
            // 
            // Login
            // 
            this.AcceptButton = this.btnLog;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(603, 378);
            this.Controls.Add(this.btnSignup);
            this.Controls.Add(this.btnChg);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.rdoAdm);
            this.Controls.Add(this.rdoNorm);
            this.Controls.Add(this.txtPkey);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "点餐系统";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPkey;
        private System.Windows.Forms.RadioButton rdoNorm;
        private System.Windows.Forms.RadioButton rdoAdm;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnChg;
        private System.Windows.Forms.Button btnSignup;
    }
}

