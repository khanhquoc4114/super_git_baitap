using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Bai7 : Form
    {
        public Bai7()
        {
            InitializeComponent();
            LoadDriveNodes();
        }
        // Tạo các node là ổ đĩa
        void LoadDriveNodes()
        {
            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                if (drive.IsReady)
                {
                    TreeNode root = new TreeNode(drive.Name);
                    root.Nodes.Add(null, "Processing ...");
                    tvFile.Nodes.Add(root);
                }
            }
        }

        // Phương thức bất đồng bộ
        async Task DirectoryExpandAsync(TreeNode root)
        {
            try
            {
                var dirInfo = new DirectoryInfo(root.FullPath);

                // Lặp qua các thư mục con và thêm chúng vào cây khi chúng được tải bất đồng bộ
                foreach (DirectoryInfo dir in await Task.Run(() => dirInfo.GetDirectories()))
                {
                    var newNode = new TreeNode(dir.Name);
                    newNode.Nodes.Add(null, "Processing ...");
                    root.Nodes.Add(newNode);
                }

                // Lặp qua các tập tin trong thư mục và thêm chúng vào cây
                foreach (FileInfo file in await Task.Run(() => dirInfo.GetFiles()))
                {
                    root.Nodes.Add(new TreeNode(file.Name));
                }
            }
            catch (UnauthorizedAccessException) // Xử lý trường hợp truy cập bị từ chối
            {
                root.Nodes.Add(new TreeNode("Access Denied"));
            }
            catch (Exception ex) // Xử lý các trường hợp khác
            {

                root.Nodes.Add(new TreeNode("Error: " + ex.Message));
            }
        }

        private void tvFile_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node.Nodes[0].Text == "Processing ...")
            {
                e.Node.Nodes.Clear();
                _ = DirectoryExpandAsync(e.Node);
            }
        }
        //
        // Xử lý khi nút bị double click
        //
        private void tvFile_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            string path = e.Node.FullPath;
            if (File.Exists(path))
            {
                string FileType = Path.GetExtension(path).ToLower();
                if (FileType == ".jpg" || FileType == ".png" || FileType == ".ico")
                {
                    ptrBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    using var fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                    ptrBox.Image = Image.FromStream(fs);
                    ptrBox.BringToFront();
                }
                else if (FileType == ".txt" || FileType == ".json")
                {
                    using var sr = new StreamReader(path, Encoding.UTF8);
                    rtBox.Text = sr.ReadToEnd();
                    rtBox.BringToFront();
                }
            }
        }
    }
}