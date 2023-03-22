using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrintCmakeFiles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string foldPath = dialog.SelectedPath;
                //MessageBox.Show("已选择文件夹:" + foldPath, "选择文件夹提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.textDir.Text = foldPath;
            }
        }

        private List<string> getDirFiles(DirectoryInfo dir,string path,string[] suffixs)
        {
            List<string> result = new List<string>();
            DirectoryInfo[] directs = dir.GetDirectories();
            foreach(DirectoryInfo subDir in directs)
            {
                string subDirName = subDir.Name;
                string subpath = path + subDirName + "/";
                List<string> dirfiles = getDirFiles(subDir, subpath, suffixs);
                result.AddRange(dirfiles);
            }
            FileInfo[] files = dir.GetFiles().Where(file => {
                string fname = file.Name;
                int idx = fname.LastIndexOf('.');
                if(idx < 0 || idx == fname.Length - 1)
                {
                    return false;
                }
                bool wr = suffixs.Contains(fname.Substring(idx + 1).ToLower());
                return wr;
            }).ToArray();
            foreach(FileInfo subfile in files) {
                result.Add(path + subfile.Name);
            }
            return result;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            string prefix = textPrefix.Text.Trim();
            if (prefix.Length == 0)
            {
                MessageBox.Show("Please input prefix.");
                return;
            }
            string suffix = textSuffix.Text.Trim();

            string dir = textDir.Text.Trim();
            if (dir.Length == 0)
            {
                MessageBox.Show("Please select or input source dir.");
                return;
            }

            DirectoryInfo d = new DirectoryInfo(dir);
            if (!d.Exists)
            {
                MessageBox.Show("Dir not found,Please select or input source dir.");
                return;
            }

            string lineSuffix = radioBtnN.Checked ? "\n" : "\r\n";

            string[] suffixs = suffix.Split(',');

            List<string> files = getDirFiles(d, "/", suffixs);

            StringBuilder sb = new StringBuilder("");
            foreach (string file in files)
            {
                sb.Append(prefix + file + lineSuffix);
            }
            string outputtxt = sb.ToString();
            textOutput.Text = outputtxt;

        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(textOutput.Text);
        }
    }
}
