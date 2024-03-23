namespace Lab1
{
    partial class Bai8
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
            this.lbNhapMonAn = new System.Windows.Forms.Label();
            this.txtAddFood = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lwFood = new System.Windows.Forms.ListView();
            this.lb1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbNhapMonAn
            // 
            this.lbNhapMonAn.AutoSize = true;
            this.lbNhapMonAn.Location = new System.Drawing.Point(26, 41);
            this.lbNhapMonAn.Name = "lbNhapMonAn";
            this.lbNhapMonAn.Size = new System.Drawing.Size(71, 13);
            this.lbNhapMonAn.TabIndex = 0;
            this.lbNhapMonAn.Text = "Nhập món ăn";
            // 
            // txtAddFood
            // 
            this.txtAddFood.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddFood.Location = new System.Drawing.Point(128, 34);
            this.txtAddFood.Name = "txtAddFood";
            this.txtAddFood.Size = new System.Drawing.Size(100, 20);
            this.txtAddFood.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(153, 60);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(81, 96);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(211, 51);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Tìm đồ ăn";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(153, 153);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 3;
            this.btnDel.Text = "Xoá";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(153, 200);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.Color.White;
            this.txtResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 39F);
            this.txtResult.Location = new System.Drawing.Point(276, 308);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(435, 61);
            this.txtResult.TabIndex = 4;
            // 
            // lwFood
            // 
            this.lwFood.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lwFood.HideSelection = false;
            this.lwFood.Location = new System.Drawing.Point(415, 33);
            this.lwFood.Name = "lwFood";
            this.lwFood.Size = new System.Drawing.Size(296, 231);
            this.lwFood.TabIndex = 5;
            this.lwFood.UseCompatibleStateImageBehavior = false;
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lb1.Location = new System.Drawing.Point(23, 332);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(226, 31);
            this.lb1.TabIndex = 6;
            this.lb1.Text = "Hôm nay ăn món:";
            // 
            // Bai8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.lwFood);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtAddFood);
            this.Controls.Add(this.lbNhapMonAn);
            this.Name = "Bai8";
            this.Text = "Bai8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNhapMonAn;
        private System.Windows.Forms.TextBox txtAddFood;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.ListView lwFood;
        private System.Windows.Forms.Label lb1;
    }
}