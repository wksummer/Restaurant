﻿namespace Restaurant
{
    partial class AddNor
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
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPkey = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("华文琥珀", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(88, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "增加普通员工";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("华文琥珀", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(40, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "username：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("华文琥珀", 10.5F);
            this.label3.Location = new System.Drawing.Point(43, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "password：";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(127, 79);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(122, 21);
            this.txtUser.TabIndex = 3;
            // 
            // txtPkey
            // 
            this.txtPkey.Location = new System.Drawing.Point(127, 121);
            this.txtPkey.Name = "txtPkey";
            this.txtPkey.Size = new System.Drawing.Size(122, 21);
            this.txtPkey.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(106, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddNor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 227);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPkey);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddNor";
            this.Text = "增加普通员工";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPkey;
        private System.Windows.Forms.Button button1;
    }
}