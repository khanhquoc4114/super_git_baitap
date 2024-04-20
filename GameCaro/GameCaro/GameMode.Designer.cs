namespace GameCaro
{
    partial class GameMode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameMode));
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_Room = new System.Windows.Forms.TextBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Room = new System.Windows.Forms.Label();
            this.btn_LAN = new System.Windows.Forms.Button();
            this.btn_Same = new System.Windows.Forms.Button();
            this.btn_1Player = new System.Windows.Forms.Button();
            this.lbl_Mode = new System.Windows.Forms.Label();
            this.btn_How = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(122, 104);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(193, 22);
            this.tb_Name.TabIndex = 0;
            // 
            // tb_Room
            // 
            this.tb_Room.Location = new System.Drawing.Point(122, 145);
            this.tb_Room.Name = "tb_Room";
            this.tb_Room.Size = new System.Drawing.Size(193, 22);
            this.tb_Room.TabIndex = 1;
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(59, 107);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(44, 16);
            this.lbl_Name.TabIndex = 2;
            this.lbl_Name.Text = "Name";
            // 
            // lbl_Room
            // 
            this.lbl_Room.AutoSize = true;
            this.lbl_Room.Location = new System.Drawing.Point(59, 148);
            this.lbl_Room.Name = "lbl_Room";
            this.lbl_Room.Size = new System.Drawing.Size(44, 16);
            this.lbl_Room.TabIndex = 3;
            this.lbl_Room.Text = "Room";
            // 
            // btn_LAN
            // 
            this.btn_LAN.Location = new System.Drawing.Point(12, 45);
            this.btn_LAN.Name = "btn_LAN";
            this.btn_LAN.Size = new System.Drawing.Size(77, 36);
            this.btn_LAN.TabIndex = 4;
            this.btn_LAN.Text = "LAN";
            this.btn_LAN.UseVisualStyleBackColor = true;
            this.btn_LAN.Click += new System.EventHandler(this.btn_2Player_Click);
            // 
            // btn_Same
            // 
            this.btn_Same.Location = new System.Drawing.Point(95, 45);
            this.btn_Same.Name = "btn_Same";
            this.btn_Same.Size = new System.Drawing.Size(111, 36);
            this.btn_Same.TabIndex = 4;
            this.btn_Same.Text = "2 Player/Com";
            this.btn_Same.UseVisualStyleBackColor = true;
            this.btn_Same.Click += new System.EventHandler(this.btn_Same_Click);
            // 
            // btn_1Player
            // 
            this.btn_1Player.Location = new System.Drawing.Point(212, 45);
            this.btn_1Player.Name = "btn_1Player";
            this.btn_1Player.Size = new System.Drawing.Size(77, 36);
            this.btn_1Player.TabIndex = 4;
            this.btn_1Player.Text = "1 Player";
            this.btn_1Player.UseVisualStyleBackColor = true;
            this.btn_1Player.Click += new System.EventHandler(this.btn_1Player_Click);
            // 
            // lbl_Mode
            // 
            this.lbl_Mode.AutoSize = true;
            this.lbl_Mode.Location = new System.Drawing.Point(151, 9);
            this.lbl_Mode.Name = "lbl_Mode";
            this.lbl_Mode.Size = new System.Drawing.Size(96, 16);
            this.lbl_Mode.TabIndex = 5;
            this.lbl_Mode.Text = "Choose Option";
            // 
            // btn_How
            // 
            this.btn_How.Location = new System.Drawing.Point(295, 45);
            this.btn_How.Name = "btn_How";
            this.btn_How.Size = new System.Drawing.Size(99, 36);
            this.btn_How.TabIndex = 6;
            this.btn_How.Text = "Howtoplay";
            this.btn_How.UseVisualStyleBackColor = true;
            this.btn_How.Click += new System.EventHandler(this.btn_How_Click);
            // 
            // GameMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(406, 185);
            this.Controls.Add(this.btn_How);
            this.Controls.Add(this.lbl_Mode);
            this.Controls.Add(this.btn_1Player);
            this.Controls.Add(this.btn_Same);
            this.Controls.Add(this.btn_LAN);
            this.Controls.Add(this.lbl_Room);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.tb_Room);
            this.Controls.Add(this.tb_Name);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GameMode";
            this.Text = "Game Caro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.TextBox tb_Room;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Room;
        private System.Windows.Forms.Button btn_LAN;
        private System.Windows.Forms.Button btn_Same;
        private System.Windows.Forms.Button btn_1Player;
        private System.Windows.Forms.Label lbl_Mode;
        private System.Windows.Forms.Button btn_How;
    }
}