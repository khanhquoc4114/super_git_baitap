namespace Lab2
{
    partial class Bai5
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
            this.cbSelectPhim = new System.Windows.Forms.ComboBox();
            this.cbSelectRoom = new System.Windows.Forms.ComboBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnBuy = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.checkBox13 = new System.Windows.Forms.CheckBox();
            this.checkBox14 = new System.Windows.Forms.CheckBox();
            this.checkBox15 = new System.Windows.Forms.CheckBox();
            this.txtChair = new System.Windows.Forms.TextBox();
            this.gbChair = new System.Windows.Forms.GroupBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnOut = new System.Windows.Forms.Button();
            this.gbChair.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbSelectPhim
            // 
            this.cbSelectPhim.Enabled = false;
            this.cbSelectPhim.Location = new System.Drawing.Point(93, 11);
            this.cbSelectPhim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbSelectPhim.Name = "cbSelectPhim";
            this.cbSelectPhim.Size = new System.Drawing.Size(124, 24);
            this.cbSelectPhim.TabIndex = 6;
            this.cbSelectPhim.SelectedIndexChanged += new System.EventHandler(this.cbSelectPhim_SelectedIndexChanged);
            // 
            // cbSelectRoom
            // 
            this.cbSelectRoom.Enabled = false;
            this.cbSelectRoom.Location = new System.Drawing.Point(223, 11);
            this.cbSelectRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbSelectRoom.Name = "cbSelectRoom";
            this.cbSelectRoom.Size = new System.Drawing.Size(121, 24);
            this.cbSelectRoom.TabIndex = 6;
            this.cbSelectRoom.SelectedIndexChanged += new System.EventHandler(this.cbSelectRoom_SelectedIndexChanged);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(772, 15);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(116, 31);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(515, 279);
            this.btnDel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(131, 31);
            this.btnDel.TabIndex = 2;
            this.btnDel.Text = "Xoá";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnBuy
            // 
            this.btnBuy.Location = new System.Drawing.Point(655, 279);
            this.btnBuy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(233, 31);
            this.btnBuy.TabIndex = 2;
            this.btnBuy.Text = "Mua";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Location = new System.Drawing.Point(369, 57);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(301, 22);
            this.txtName.TabIndex = 0;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbName.Location = new System.Drawing.Point(293, 57);
            this.lbName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(59, 20);
            this.lbName.TabIndex = 8;
            this.lbName.Text = "Họ tên";
            // 
            // checkBox1
            // 
            this.checkBox1.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.checkBox1.Location = new System.Drawing.Point(8, 23);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(69, 49);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Tag = "ghe";
            this.checkBox1.Text = "A1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox2.AutoSize = true;
            this.checkBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.checkBox2.Location = new System.Drawing.Point(92, 23);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(69, 49);
            this.checkBox2.TabIndex = 9;
            this.checkBox2.Tag = "ghe";
            this.checkBox2.Text = "A2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox3.AutoSize = true;
            this.checkBox3.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.checkBox3.Location = new System.Drawing.Point(176, 23);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(69, 49);
            this.checkBox3.TabIndex = 9;
            this.checkBox3.Tag = "ghe";
            this.checkBox3.Text = "A3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox4.AutoSize = true;
            this.checkBox4.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.checkBox4.Location = new System.Drawing.Point(260, 23);
            this.checkBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(69, 49);
            this.checkBox4.TabIndex = 9;
            this.checkBox4.Tag = "ghe";
            this.checkBox4.Text = "A4";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox5.AutoSize = true;
            this.checkBox5.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.checkBox5.Location = new System.Drawing.Point(344, 23);
            this.checkBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(69, 49);
            this.checkBox5.TabIndex = 9;
            this.checkBox5.Tag = "ghe";
            this.checkBox5.Text = "A5";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox6.AutoSize = true;
            this.checkBox6.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.checkBox6.Location = new System.Drawing.Point(8, 81);
            this.checkBox6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(69, 49);
            this.checkBox6.TabIndex = 9;
            this.checkBox6.Tag = "ghe";
            this.checkBox6.Text = "B1";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox8.AutoSize = true;
            this.checkBox8.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.checkBox8.Location = new System.Drawing.Point(176, 81);
            this.checkBox8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(69, 49);
            this.checkBox8.TabIndex = 9;
            this.checkBox8.Tag = "ghe";
            this.checkBox8.Text = "B3";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            this.checkBox9.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox9.AutoSize = true;
            this.checkBox9.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.checkBox9.Location = new System.Drawing.Point(260, 81);
            this.checkBox9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(69, 49);
            this.checkBox9.TabIndex = 9;
            this.checkBox9.Tag = "ghe";
            this.checkBox9.Text = "B4";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            this.checkBox10.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox10.AutoSize = true;
            this.checkBox10.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.checkBox10.Location = new System.Drawing.Point(344, 81);
            this.checkBox10.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(69, 49);
            this.checkBox10.TabIndex = 9;
            this.checkBox10.Tag = "ghe";
            this.checkBox10.Text = "B5";
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox11
            // 
            this.checkBox11.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox11.AutoSize = true;
            this.checkBox11.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.checkBox11.Location = new System.Drawing.Point(8, 139);
            this.checkBox11.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(71, 49);
            this.checkBox11.TabIndex = 9;
            this.checkBox11.Tag = "ghe";
            this.checkBox11.Text = "C1";
            this.checkBox11.UseVisualStyleBackColor = true;
            // 
            // checkBox12
            // 
            this.checkBox12.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox12.AutoSize = true;
            this.checkBox12.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.checkBox12.Location = new System.Drawing.Point(92, 139);
            this.checkBox12.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(71, 49);
            this.checkBox12.TabIndex = 9;
            this.checkBox12.Tag = "ghe";
            this.checkBox12.Text = "C2";
            this.checkBox12.UseVisualStyleBackColor = true;
            // 
            // checkBox13
            // 
            this.checkBox13.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox13.AutoSize = true;
            this.checkBox13.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox13.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.checkBox13.Location = new System.Drawing.Point(176, 139);
            this.checkBox13.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox13.Name = "checkBox13";
            this.checkBox13.Size = new System.Drawing.Size(71, 49);
            this.checkBox13.TabIndex = 9;
            this.checkBox13.Tag = "ghe";
            this.checkBox13.Text = "C3";
            this.checkBox13.UseVisualStyleBackColor = true;
            // 
            // checkBox14
            // 
            this.checkBox14.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox14.AutoSize = true;
            this.checkBox14.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox14.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.checkBox14.Location = new System.Drawing.Point(260, 139);
            this.checkBox14.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox14.Name = "checkBox14";
            this.checkBox14.Size = new System.Drawing.Size(71, 49);
            this.checkBox14.TabIndex = 9;
            this.checkBox14.Tag = "ghe";
            this.checkBox14.Text = "C4";
            this.checkBox14.UseVisualStyleBackColor = true;
            // 
            // checkBox15
            // 
            this.checkBox15.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox15.AutoSize = true;
            this.checkBox15.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox15.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.checkBox15.Location = new System.Drawing.Point(344, 139);
            this.checkBox15.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox15.Name = "checkBox15";
            this.checkBox15.Size = new System.Drawing.Size(71, 49);
            this.checkBox15.TabIndex = 9;
            this.checkBox15.Tag = "ghe";
            this.checkBox15.Text = "C5";
            this.checkBox15.UseVisualStyleBackColor = true;
            // 
            // txtChair
            // 
            this.txtChair.BackColor = System.Drawing.SystemColors.Window;
            this.txtChair.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtChair.Location = new System.Drawing.Point(370, 89);
            this.txtChair.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtChair.Name = "txtChair";
            this.txtChair.ReadOnly = true;
            this.txtChair.Size = new System.Drawing.Size(299, 22);
            this.txtChair.TabIndex = 11;
            this.txtChair.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gbChair
            // 
            this.gbChair.Controls.Add(this.checkBox5);
            this.gbChair.Controls.Add(this.checkBox15);
            this.gbChair.Controls.Add(this.checkBox1);
            this.gbChair.Controls.Add(this.checkBox2);
            this.gbChair.Controls.Add(this.checkBox6);
            this.gbChair.Controls.Add(this.checkBox3);
            this.gbChair.Controls.Add(this.checkBox11);
            this.gbChair.Controls.Add(this.checkBox14);
            this.gbChair.Controls.Add(this.checkBox4);
            this.gbChair.Controls.Add(this.checkBox10);
            this.gbChair.Controls.Add(this.checkBox12);
            this.gbChair.Controls.Add(this.checkBox9);
            this.gbChair.Controls.Add(this.checkBox7);
            this.gbChair.Controls.Add(this.checkBox8);
            this.gbChair.Controls.Add(this.checkBox13);
            this.gbChair.Location = new System.Drawing.Point(13, 187);
            this.gbChair.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbChair.Name = "gbChair";
            this.gbChair.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbChair.Size = new System.Drawing.Size(427, 191);
            this.gbChair.TabIndex = 12;
            this.gbChair.TabStop = false;
            this.gbChair.Text = "Ghế";
            // 
            // checkBox7
            // 
            this.checkBox7.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox7.AutoSize = true;
            this.checkBox7.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.checkBox7.Location = new System.Drawing.Point(92, 81);
            this.checkBox7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(69, 49);
            this.checkBox7.TabIndex = 9;
            this.checkBox7.Tag = "ghe";
            this.checkBox7.Text = "B2";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // txtMoney
            // 
            this.txtMoney.BackColor = System.Drawing.SystemColors.Window;
            this.txtMoney.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMoney.Location = new System.Drawing.Point(653, 187);
            this.txtMoney.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.ReadOnly = true;
            this.txtMoney.Size = new System.Drawing.Size(234, 22);
            this.txtMoney.TabIndex = 13;
            this.txtMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(293, 91);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Ghế";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(511, 187);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Thành tiền";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(12, 12);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 15;
            this.btnOpen.Text = "Mở";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnOut
            // 
            this.btnOut.Location = new System.Drawing.Point(772, 53);
            this.btnOut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(116, 28);
            this.btnOut.TabIndex = 16;
            this.btnOut.Text = "Xuất";
            this.btnOut.UseVisualStyleBackColor = true;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // Bai5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(903, 396);
            this.Controls.Add(this.btnOut);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMoney);
            this.Controls.Add(this.gbChair);
            this.Controls.Add(this.txtChair);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.cbSelectRoom);
            this.Controls.Add(this.cbSelectPhim);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Bai5";
            this.Text = "Bài 5";
            this.gbChair.ResumeLayout(false);
            this.gbChair.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbSelectPhim;
        private System.Windows.Forms.ComboBox cbSelectRoom;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.CheckBox checkBox11;
        private System.Windows.Forms.CheckBox checkBox12;
        private System.Windows.Forms.CheckBox checkBox13;
        private System.Windows.Forms.CheckBox checkBox14;
        private System.Windows.Forms.CheckBox checkBox15;
        private System.Windows.Forms.TextBox txtChair;
        private System.Windows.Forms.GroupBox gbChair;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnOut;
    }
}