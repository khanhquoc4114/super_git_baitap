namespace Lab1
{
    partial class Bai4
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
            this.lbScreen = new System.Windows.Forms.Label();
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtChair = new System.Windows.Forms.TextBox();
            this.gbChair = new System.Windows.Forms.GroupBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gbChair.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbSelectPhim
            // 
            this.cbSelectPhim.Location = new System.Drawing.Point(16, 15);
            this.cbSelectPhim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbSelectPhim.Name = "cbSelectPhim";
            this.cbSelectPhim.Size = new System.Drawing.Size(208, 24);
            this.cbSelectPhim.TabIndex = 6;
            this.cbSelectPhim.SelectedIndexChanged += new System.EventHandler(this.cbSelectPhim_SelectedIndexChanged);
            // 
            // cbSelectRoom
            // 
            this.cbSelectRoom.Enabled = false;
            this.cbSelectRoom.Location = new System.Drawing.Point(231, 15);
            this.cbSelectRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbSelectRoom.Name = "cbSelectRoom";
            this.cbSelectRoom.Size = new System.Drawing.Size(121, 24);
            this.cbSelectRoom.TabIndex = 6;
            this.cbSelectRoom.SelectedIndexChanged += new System.EventHandler(this.cbSelectRoom_SelectedIndexChanged);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(773, 15);
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
            // lbScreen
            // 
            this.lbScreen.AutoSize = true;
            this.lbScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbScreen.Location = new System.Drawing.Point(188, 78);
            this.lbScreen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbScreen.Name = "lbScreen";
            this.lbScreen.Size = new System.Drawing.Size(124, 31);
            this.lbScreen.TabIndex = 3;
            this.lbScreen.Text = "Màn hình";
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Location = new System.Drawing.Point(587, 119);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(301, 22);
            this.txtName.TabIndex = 0;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbName.Location = new System.Drawing.Point(511, 119);
            this.lbName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(50, 17);
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
            this.checkBox1.Location = new System.Drawing.Point(69, 17);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(57, 41);
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
            this.checkBox2.Location = new System.Drawing.Point(153, 17);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(57, 41);
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
            this.checkBox3.Location = new System.Drawing.Point(237, 17);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(57, 41);
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
            this.checkBox4.Location = new System.Drawing.Point(321, 17);
            this.checkBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(57, 41);
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
            this.checkBox5.Location = new System.Drawing.Point(405, 17);
            this.checkBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(57, 41);
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
            this.checkBox6.Location = new System.Drawing.Point(69, 75);
            this.checkBox6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(57, 41);
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
            this.checkBox8.Location = new System.Drawing.Point(237, 75);
            this.checkBox8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(57, 41);
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
            this.checkBox9.Location = new System.Drawing.Point(321, 75);
            this.checkBox9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(57, 41);
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
            this.checkBox10.Location = new System.Drawing.Point(405, 75);
            this.checkBox10.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(57, 41);
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
            this.checkBox11.Location = new System.Drawing.Point(69, 133);
            this.checkBox11.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(59, 41);
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
            this.checkBox12.Location = new System.Drawing.Point(153, 133);
            this.checkBox12.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(59, 41);
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
            this.checkBox13.Location = new System.Drawing.Point(237, 133);
            this.checkBox13.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox13.Name = "checkBox13";
            this.checkBox13.Size = new System.Drawing.Size(59, 41);
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
            this.checkBox14.Location = new System.Drawing.Point(321, 133);
            this.checkBox14.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox14.Name = "checkBox14";
            this.checkBox14.Size = new System.Drawing.Size(59, 41);
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
            this.checkBox15.Location = new System.Drawing.Point(405, 133);
            this.checkBox15.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox15.Name = "checkBox15";
            this.checkBox15.Size = new System.Drawing.Size(59, 41);
            this.checkBox15.TabIndex = 9;
            this.checkBox15.Tag = "ghe";
            this.checkBox15.Text = "C5";
            this.checkBox15.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 31);
            this.label2.TabIndex = 10;
            this.label2.Text = "B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 139);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 31);
            this.label3.TabIndex = 10;
            this.label3.Text = "C";
            // 
            // txtChair
            // 
            this.txtChair.BackColor = System.Drawing.SystemColors.Window;
            this.txtChair.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtChair.Location = new System.Drawing.Point(588, 151);
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
            this.gbChair.Controls.Add(this.label3);
            this.gbChair.Controls.Add(this.checkBox6);
            this.gbChair.Controls.Add(this.label2);
            this.gbChair.Controls.Add(this.checkBox3);
            this.gbChair.Controls.Add(this.label1);
            this.gbChair.Controls.Add(this.checkBox11);
            this.gbChair.Controls.Add(this.checkBox14);
            this.gbChair.Controls.Add(this.checkBox4);
            this.gbChair.Controls.Add(this.checkBox10);
            this.gbChair.Controls.Add(this.checkBox12);
            this.gbChair.Controls.Add(this.checkBox9);
            this.gbChair.Controls.Add(this.checkBox7);
            this.gbChair.Controls.Add(this.checkBox8);
            this.gbChair.Controls.Add(this.checkBox13);
            this.gbChair.Location = new System.Drawing.Point(15, 119);
            this.gbChair.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbChair.Name = "gbChair";
            this.gbChair.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbChair.Size = new System.Drawing.Size(492, 191);
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
            this.checkBox7.Location = new System.Drawing.Point(153, 75);
            this.checkBox7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(57, 41);
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
            this.label4.Location = new System.Drawing.Point(511, 155);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 17);
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
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Thành tiền";
            // 
            // Bai4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(904, 330);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMoney);
            this.Controls.Add(this.gbChair);
            this.Controls.Add(this.txtChair);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lbScreen);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.cbSelectRoom);
            this.Controls.Add(this.cbSelectPhim);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Bai4";
            this.Text = "Bài 4";
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
        private System.Windows.Forms.Label lbScreen;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtChair;
        private System.Windows.Forms.GroupBox gbChair;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}