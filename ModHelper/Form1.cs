using System.IO.Compression;
namespace ModHelper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string DirectoryDialogLoad(object sender, EventArgs e)
        {
            // event will trigger folder browser dialog to open on click
            DialogResult = folderBrowserDialog1.ShowDialog();
            if (DialogResult == DialogResult.OK)
            {
                return folderBrowserDialog1.SelectedPath;
            }
            else return null;
        }



        private void UnpackFiles(string origin, string destination)
        {
            DirectoryInfo startDir = new DirectoryInfo(origin);
            string startPath = origin;
            string endPath = destination;
            progressBar1.Visible = true;
            progressBar1.Minimum = 1;

            progressBar1.Maximum = startDir.GetFiles("*.zip").Length;

            progressBar1.Step = 1;

            foreach (FileInfo file in startDir.GetFiles("*.zip"))
            {
                ZipFile.ExtractToDirectory(file.FullName, endPath);
                progressBar1.PerformStep();
            }

            MessageBox.Show("Finished!");

        }

        private void fromFolderBtn_Click(object sender, EventArgs e)
        {
            string result = DirectoryDialogLoad(sender, e);

            fromFolder.Text = result;
        }

        private void toFolderBtn_Click(object sender, EventArgs e)
        {
            string result = DirectoryDialogLoad(sender, e);

            toFolder.Text = result;
        }

        private void startProcess_Click(object sender, EventArgs e)
        {
            string origin = fromFolder.Text;

            string destination = toFolder.Text;

            UnpackFiles(origin, destination);
        }
    }
}