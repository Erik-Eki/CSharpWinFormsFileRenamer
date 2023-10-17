using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace WinFormsFileRenamer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void openExplorer_Click(object sender, EventArgs e)
        {

            DataGridView dataGridView = this.fileTable;
            Label fileCount = this.fileCount;
            //DataGridView dataGridView = new DataGridView();
            //dataGridView.Columns.Add("Filename", "Name");
            //dataGridView.Columns.Add("File Type", "Type");


            // create a new OpenFileDialog
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            // set the Dialog properties
            folderBrowserDialog1.Description = "Select a Folder";
            folderBrowserDialog1.RootFolder = Environment.SpecialFolder.Personal;

            DialogResult result = fbd.ShowDialog();
            string selectedFolder = fbd.SelectedPath;

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(selectedFolder))
            {
                string[] files = Directory.GetFiles(selectedFolder);


                fileCount.Text = files.Length.ToString();
                //var dir = new DirectoryInfo(selectedFolder);

                // Loop through all the files in the selected folder
                //foreach (var file in dir.GetFiles())
                foreach (string file in files)
                {
                    // Get the file name and type
                    string fileName = Path.GetFileNameWithoutExtension(file);
                    string fileType = Path.GetExtension(file);
                    DateTime createdAt = File.GetCreationTime(file);

                    dataGridView.Rows.Add(fileName, "", fileType, createdAt);

                    // Create a new row with the file name and type
                    //DataGridViewRow row = new DataGridViewRow();
                    //row.Cells.Add(new DataGridViewTextBoxCell { Value = fileName });
                    //row.Cells.Add(new DataGridViewTextBoxCell { Value = fileType });
                    // Add the new row to the DataGridView
                    //dataGridView.Rows.Add(row);

                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void formatTextBox_TextChanged(object sender, EventArgs e)
        {
            formatCell();
        }

        private void formatCollapse_SelectedIndexChanged(object sender, EventArgs e)
        {
            formatCell();
        }

        void formatCell()
        {
            string objTextBox = this.formatTextBox.Text;
            //Label fileCount = this.fileCount;
            DataGridView dataGridView = this.fileTable;
            ComboBox formatCollapse = this.formatCollapse;
            int selectedIndex = formatCollapse.SelectedIndex;

            dataGridView.ReadOnly = true;
            dataGridView.Columns["newNames"].ReadOnly = false;


            switch (selectedIndex)
            {
                case 0:
                    for (int i = 0; i < dataGridView.Rows.Count; i++)
                    {
                        //dataGridView.Columns["newNames"].ReadOnly = false;
                        //dataGridView.Columns["newNames", dataGridView.CurrentCell.RowIndex].Value = objTextBox + "_" + i;
                        dataGridView.Rows[i].Cells["newNames"].Value = objTextBox + "_" + i;
                    }
                    break;
                case 1:
                    for (int i = 0; i < dataGridView.Rows.Count; i++)
                    {
                        //DateTime dateString = dataGridView.Rows[i].Cells["createdAt"].Value;
                        var dateString = DateTime.Parse(dataGridView.Rows[i].Cells["createdAt"].Value.ToString());
                        dataGridView.Rows[i].Cells["newNames"].Value = objTextBox + "_" + dateString.ToString("dd-MM-yyyy_HH-mm-ss");
                    }
                    break;
                default:
                    break;
            }
        }
    }
}