using System.IO.Compression;

namespace correct_info
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void correct_info_Click(object sender, EventArgs e)
        {
            string appdataDir = Environment.GetEnvironmentVariable("appdata");
            string baseDir = appdataDir + "\\Advanced Combat Tracker";

            if (System.IO.File.Exists(".\\support_info.zip")) {
                File.Delete(".\\support_info.zip");
            }
            ZipFile.CreateFromDirectory(baseDir + "\\Config", ".\\support_info.zip", CompressionLevel.Optimal, true, System.Text.Encoding.GetEncoding("UTF-8"));
            using (ZipArchive a = ZipFile.Open(".\\support_info.zip", ZipArchiveMode.Update))
            {
                // ���O�t�@�C����
                foreach (string file in Directory.EnumerateFiles(baseDir, "*.log"))
                {
                    string entryName = file.Substring(baseDir.Length);
                    if (!File.Exists(file))
                    {
                        // �t�@�C���ł͂Ȃ�
                        continue;
                    }
                   a.CreateEntryFromFile(file, entryName);
                }
                // �ݒ�t�@�C����
                foreach (string file in Directory.EnumerateFiles(baseDir, "*.xml"))
                {
                    string entryName = file.Substring(baseDir.Length);
                    if (!File.Exists(file))
                    {
                        // �t�@�C���ł͂Ȃ�
                        continue;
                    }
                    a.CreateEntryFromFile(file, entryName);
                }
            }
            MessageBox.Show("complete!");
        }
     }
}
