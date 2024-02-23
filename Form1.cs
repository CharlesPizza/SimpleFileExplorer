using System.Windows.Forms;
namespace FileExplorer
{
    public partial class Window1 : Form
    {
        List<string> Listfiles = new List<string>();
        public Window1()
        {
            InitializeComponent();
        }

        private void Window1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Listfiles.Clear();
            listView.Items.Clear();
            using (FolderBrowserDialog fbd = new FolderBrowserDialog() { Description = "Select path" })
            {
                if (fbd.SelectedPath != null)
                {
                    fbd.Reset();
                    fbd.RootFolder = Environment.SpecialFolder.MyComputer;
                    fbd.SelectedPath = txtPath.Text;
                }
                else
                {
                    fbd.SelectedPath = @"C:\Users\";
                }
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    txtPath.Text = fbd.SelectedPath;
                    foreach(string item in Directory.GetFiles(fbd.SelectedPath))
                    {
                        imageList.Images.Add(System.Drawing.Icon.ExtractAssociatedIcon(item));
                        FileInfo fi = new FileInfo(item);
                        Listfiles.Add(fi.FullName);
                        listView.Items.Add(fi.Name, imageList.Images.Count - 1);
                    }
                }
            }
        }
    }
}
