namespace Restaurant
{
    partial class 修改密码
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.TextBox();
            this.NEWPASS = new System.Windows.Forms.TextBox();
            this.NEWPASS1 = new System.Windows.Forms.TextBox();
            this.rdoNomal = new System.Windows.Forms.RadioButton();
            this.rdoAdm = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.OLDPASS = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("华文琥珀", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(294, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "修改密码";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("华文琥珀", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(151, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "旧密码:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("华文琥珀", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(151, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "新密码:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("华文琥珀", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(111, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "确认新密码:";
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(255, 88);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(203, 25);
            this.ID.TabIndex = 4;
            // 
            // NEWPASS
            // 
            this.NEWPASS.Location = new System.Drawing.Point(255, 181);
            this.NEWPASS.Name = "NEWPASS";
            this.NEWPASS.Size = new System.Drawing.Size(203, 25);
            this.NEWPASS.TabIndex = 6;
            // 
            // NEWPASS1
            // 
            this.NEWPASS1.Location = new System.Drawing.Point(255, 228);
            this.NEWPASS1.Name = "NEWPASS1";
            this.NEWPASS1.Size = new System.Drawing.Size(203, 25);
            this.NEWPASS1.TabIndex = 7;
            // 
            // rdoNomal
            // 
            this.rdoNomal.AutoSize = true;
            this.rdoNomal.Location = new System.Drawing.Point(255, 274);
            this.rdoNomal.Name = "rdoNomal";
            this.rdoNomal.Size = new System.Drawing.Size(88, 19);
            this.rdoNomal.TabIndex = 8;
            this.rdoNomal.TabStop = true;
            this.rdoNomal.Text = "普通用户";
            this.rdoNomal.UseVisualStyleBackColor = true;
            this.rdoNomal.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdoAdm
            // 
            this.rdoAdm.AutoSize = true;
            this.rdoAdm.Location = new System.Drawing.Point(385, 274);
            this.rdoAdm.Name = "rdoAdm";
            this.rdoAdm.Size = new System.Drawing.Size(73, 19);
            this.rdoAdm.TabIndex = 9;
            this.rdoAdm.TabStop = true;
            this.rdoAdm.Text = "管理员";
            this.rdoAdm.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(255, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 29);
            this.button1.TabIndex = 10;
            this.button1.Text = "确定(&Y)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(370, 314);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 29);
            this.button2.TabIndex = 11;
            this.button2.Text = "取消(&C)";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("华文琥珀", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(171, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "账号:";
            // 
            // OLDPASS
            // 
            this.OLDPASS.Location = new System.Drawing.Point(255, 136);
            this.OLDPASS.Name = "OLDPASS";
            this.OLDPASS.Size = new System.Drawing.Size(203, 25);
            this.OLDPASS.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("华文琥珀", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(131, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 21);
            this.label6.TabIndex = 13;
            this.label6.Text = "用户类别:";
            // 
            // 修改密码
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(679, 371);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.OLDPASS);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rdoAdm);
            this.Controls.Add(this.rdoNomal);
            this.Controls.Add(this.NEWPASS1);
            this.Controls.Add(this.NEWPASS);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "修改密码";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "点餐系统";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.TextBox NEWPASS;
        private System.Windows.Forms.TextBox NEWPASS1;
        private System.Windows.Forms.RadioButton rdoNomal;
        private System.Windows.Forms.RadioButton rdoAdm;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox OLDPASS;
        private System.Windows.Forms.Label label6;
    }
}