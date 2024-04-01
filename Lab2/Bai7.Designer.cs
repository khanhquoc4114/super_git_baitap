using System.Windows.Forms;

namespace Lab2
{
    partial class Bai7
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
            this.FilePictureContent = new System.Windows.Forms.PictureBox();
            this.txtFileContent = new System.Windows.Forms.RichTextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tvFile = new System.Windows.Forms.TreeView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ptrBox = new System.Windows.Forms.PictureBox();
            this.rtBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.FilePictureContent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrBox)).BeginInit();
            this.SuspendLayout();
            // 
            // FilePictureContent
            // 
            this.FilePictureContent.Location = new System.Drawing.Point(783, 12);
            this.FilePictureContent.Name = "FilePictureContent";
            this.FilePictureContent.Size = new System.Drawing.Size(806, 891);
            this.FilePictureContent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FilePictureContent.TabIndex = 3;
            this.FilePictureContent.TabStop = false;
            this.FilePictureContent.Visible = false;
            // 
            // txtFileContent
            // 
            this.txtFileContent.Location = new System.Drawing.Point(783, 12);
            this.txtFileContent.Name = "txtFileContent";
            this.txtFileContent.ReadOnly = true;
            this.txtFileContent.Size = new System.Drawing.Size(806, 891);
            this.txtFileContent.TabIndex = 4;
            this.txtFileContent.Text = "";
            this.txtFileContent.Visible = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tvFile);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel2.Controls.Add(this.rtBox);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 221;
            this.splitContainer1.TabIndex = 0;
            // 
            // tvFile
            // 
            this.tvFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvFile.Location = new System.Drawing.Point(0, 0);
            this.tvFile.Name = "tvFile";
            this.tvFile.Size = new System.Drawing.Size(221, 450);
            this.tvFile.TabIndex = 0;
            this.tvFile.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.tvFile_BeforeExpand);
            this.tvFile.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvFile_NodeMouseDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ptrBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(575, 450);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File Reader";
            // 
            // ptrBox
            // 
            this.ptrBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptrBox.Location = new System.Drawing.Point(3, 16);
            this.ptrBox.Name = "ptrBox";
            this.ptrBox.Size = new System.Drawing.Size(569, 431);
            this.ptrBox.TabIndex = 0;
            this.ptrBox.TabStop = false;
            // 
            // rtBox
            // 
            this.rtBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtBox.Location = new System.Drawing.Point(0, 0);
            this.rtBox.Name = "rtBox";
            this.rtBox.Size = new System.Drawing.Size(575, 450);
            this.rtBox.TabIndex = 1;
            this.rtBox.Text = "";
            // 
            // Bai7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Bai7";
            this.Text = "Bài 7";
            ((System.ComponentModel.ISupportInitialize)(this.FilePictureContent)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptrBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox FilePictureContent;
        private System.Windows.Forms.RichTextBox txtFileContent;
        private System.Windows.Forms.TreeView tvFile;
        private System.Windows.Forms.PictureBox ptrBox;
        private System.Windows.Forms.RichTextBox rtBox;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}