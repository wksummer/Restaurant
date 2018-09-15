namespace Restaurant
{
    partial class MainForm
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
            this.listItem = new System.Windows.Forms.ListBox();
            this.listOrder = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCan = new System.Windows.Forms.Button();
            this.btnSure = new System.Windows.Forms.Button();
            this.cboCato = new System.Windows.Forms.ComboBox();
            this.picture = new System.Windows.Forms.PictureBox();
            this.txtDanjia = new System.Windows.Forms.TextBox();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTaocan = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(363, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "您的订单：";
            // 
            // listItem
            // 
            this.listItem.FormattingEnabled = true;
            this.listItem.ItemHeight = 12;
            this.listItem.Location = new System.Drawing.Point(28, 87);
            this.listItem.Name = "listItem";
            this.listItem.Size = new System.Drawing.Size(160, 124);
            this.listItem.TabIndex = 7;
            this.listItem.SelectedIndexChanged += new System.EventHandler(this.listItem_SelectedIndexChanged);
            // 
            // listOrder
            // 
            this.listOrder.ForeColor = System.Drawing.Color.Red;
            this.listOrder.FormattingEnabled = true;
            this.listOrder.ItemHeight = 12;
            this.listOrder.Location = new System.Drawing.Point(365, 71);
            this.listOrder.Name = "listOrder";
            this.listOrder.Size = new System.Drawing.Size(163, 208);
            this.listOrder.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "菜品：";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(242, 201);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCan
            // 
            this.btnCan.Location = new System.Drawing.Point(242, 242);
            this.btnCan.Name = "btnCan";
            this.btnCan.Size = new System.Drawing.Size(75, 23);
            this.btnCan.TabIndex = 12;
            this.btnCan.Text = "取消";
            this.btnCan.UseVisualStyleBackColor = true;
            this.btnCan.Click += new System.EventHandler(this.btnCan_Click);
            // 
            // btnSure
            // 
            this.btnSure.Location = new System.Drawing.Point(242, 282);
            this.btnSure.Name = "btnSure";
            this.btnSure.Size = new System.Drawing.Size(75, 23);
            this.btnSure.TabIndex = 13;
            this.btnSure.Text = "确定";
            this.btnSure.UseVisualStyleBackColor = true;
            this.btnSure.Click += new System.EventHandler(this.btnSure_Click);
            // 
            // cboCato
            // 
            this.cboCato.FormattingEnabled = true;
            this.cboCato.Location = new System.Drawing.Point(28, 52);
            this.cboCato.Name = "cboCato";
            this.cboCato.Size = new System.Drawing.Size(121, 20);
            this.cboCato.TabIndex = 14;
            this.cboCato.SelectedIndexChanged += new System.EventHandler(this.cboCato_SelectedIndexChanged);
            // 
            // picture
            // 
            this.picture.Location = new System.Drawing.Point(209, 71);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(138, 114);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture.TabIndex = 15;
            this.picture.TabStop = false;
            // 
            // txtDanjia
            // 
            this.txtDanjia.Location = new System.Drawing.Point(84, 290);
            this.txtDanjia.Name = "txtDanjia";
            this.txtDanjia.ReadOnly = true;
            this.txtDanjia.Size = new System.Drawing.Size(54, 21);
            this.txtDanjia.TabIndex = 16;
            // 
            // txtSum
            // 
            this.txtSum.Location = new System.Drawing.Point(391, 290);
            this.txtSum.Name = "txtSum";
            this.txtSum.ReadOnly = true;
            this.txtSum.Size = new System.Drawing.Size(53, 21);
            this.txtSum.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 18;
            this.label3.Text = "单价：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(344, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 19;
            this.label4.Text = "总计：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(144, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 20;
            this.label5.Text = "元";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(450, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 21;
            this.label6.Text = "元";
            // 
            // txtTaocan
            // 
            this.txtTaocan.Location = new System.Drawing.Point(28, 227);
            this.txtTaocan.Name = "txtTaocan";
            this.txtTaocan.ReadOnly = true;
            this.txtTaocan.Size = new System.Drawing.Size(160, 52);
            this.txtTaocan.TabIndex = 22;
            this.txtTaocan.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 326);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(263, 12);
            this.label7.TabIndex = 23;
            this.label7.Text = "*注意：关闭该页面时，未提交的订单会被取消！";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 347);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTaocan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSum);
            this.Controls.Add(this.txtDanjia);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.cboCato);
            this.Controls.Add(this.btnSure);
            this.Controls.Add(this.btnCan);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listOrder);
            this.Controls.Add(this.listItem);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "点餐系统";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listItem;
        private System.Windows.Forms.ListBox listOrder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCan;
        private System.Windows.Forms.Button btnSure;
        private System.Windows.Forms.ComboBox cboCato;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.TextBox txtDanjia;
        private System.Windows.Forms.TextBox txtSum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox txtTaocan;
        private System.Windows.Forms.Label label7;
    }
}