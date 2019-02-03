using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrairieNotes
{
    public partial class Form1 : Form
    {
        string PathOutputFolder = "";
        PrairieViewer.Experiment exp;

        public Form1()
        {
            InitializeComponent();
            cbTimeUnits.Text = "min";
            PathOutputFolder = System.IO.Path.GetFullPath("../");
            //PathOutputFolder = System.IO.Path.GetFullPath("../../../../../data/stripped/");
            PathOutputFolder = System.IO.Path.GetFullPath("../../../../../data/minimal/");
            ScanExperimentFolder();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /////////////////////////////////////////////////////////////////////////////////
        // Actions

        // launch a dialog to ask for the top-level experiment folder
        private void SetFolder()
        {
            var diag = new FolderBrowserDialog();
            if (diag.ShowDialog() == DialogResult.OK)
            {
                string selectedPath = diag.SelectedPath;
                PathOutputFolder = selectedPath;
                ScanExperimentFolder();
            }
        }

        // re-scal the experiment folder and update the list of experiments
        private void ScanExperimentFolder(int selectIndex = 0)
        {
            if (!System.IO.Directory.Exists(PathOutputFolder))
            {
                lblStatus.Text = $"Directory does not exist: {PathOutputFolder}";
                return;
            }
                
            var di = new System.IO.DirectoryInfo(PathOutputFolder);
            var folderNames = di.EnumerateDirectories()
                                .OrderBy(d => d.CreationTime)
                                .Select(d => d.Name)
                                .ToList();
            folderNames.Reverse();
            for (int i = 0; i < folderNames.Count; i++)
                folderNames[i] = System.IO.Path.GetFileName(folderNames[i]);

            lbFolderNames.Items.Clear();
            lbFolderNames.Items.AddRange(folderNames.ToArray());

            if (selectIndex >= 0 && selectIndex < lbFolderNames.Items.Count)
            {
                lbFolderNames.SelectedIndex = selectIndex;
                lbFolderNames_SelectedIndexChanged(null, null);
            }

            lblStatus.Text = ($"Scanned experiment folder: {PathOutputFolder}");
        }

        // when a given folder is selected, the GUI will be updated
        private void FolderSelected(string folderName)
        {
            string pathSelected = System.IO.Path.Combine(PathOutputFolder, folderName);

            // read Prairie XML
            var pf = new PrairieViewer.PrairieFolder(pathSelected);
            tbPvInfo.Text = pf.info?.GetInfo().Replace("\n", "\r\n");

            // read experiment XML
            exp = new PrairieViewer.Experiment(pathSelected);
            UpdateGuiFromExperiment();
            SaveNeeded(false);

            // load reference images
            panel1.Controls.Clear();
            int refImageCount = 0;
            string refImageFolder = System.IO.Path.Combine(pathSelected, "References");
            if (System.IO.Directory.Exists(refImageFolder))
            {
                string[] refImagePaths = System.IO.Directory.GetFiles(refImageFolder, "*.tif");
                int nextYPos = 10;
                int fixedImageWidth = 330;
                foreach (string refImagePath in refImagePaths)
                {
                    string imageFileName = System.IO.Path.GetFileName(refImagePath);
                    if (imageFileName.Contains("16bit"))
                        continue;
                    else
                        refImageCount += 1;

                    // add the label
                    Label lbl = new Label();
                    lbl.Location = new Point(10, nextYPos);
                    lbl.Text = imageFileName;
                    lbl.AutoSize = true;
                    lbl.Font = new Font("Arial", 8);
                    panel1.Controls.Add(lbl);
                    nextYPos += 20;

                    // add the image
                    Bitmap bmp = new Bitmap(refImagePath);
                    double heightToWidthRatio = (double)bmp.Height / (double)bmp.Width;
                    PictureBox pb = new PictureBox();
                    pb.BackgroundImage = bmp;
                    pb.BackgroundImageLayout = ImageLayout.Zoom;
                    pb.Size = new Size(fixedImageWidth, (int)(fixedImageWidth * heightToWidthRatio));
                    pb.Location = new Point(10, nextYPos);
                    panel1.Controls.Add(pb);
                    nextYPos += pb.Height + 30;
                }
            }
            gbRefImages.Text = $"Reference Images ({refImageCount})";

            lblStatus.Text = $"Loaded information about {pf.FolderName}";
        }

        private void UpdateGuiFromExperiment()
        {
            tbAnimal.Text = exp.animal;
            tbBath.Text = exp.bath;
            tbInternal.Text = exp.intrnl;
            tbNotes.Text = exp.notes;
            lbTags.Items.Clear();
            lbTags.Items.AddRange(exp.TagStrings());
            lbTags_SelectedIndexChanged(null, null);
        }

        private void SaveNeeded(bool saveIsNeeded = true)
        {
            if (saveIsNeeded)
            {
                btnXmlSave.BackColor = Color.LightYellow;
                lbFolderNames.Enabled = false;
            }
            else
            {
                btnXmlSave.UseVisualStyleBackColor = true;
                lbFolderNames.Enabled = true;
            }
        }

        private void XmlLoad()
        {
            exp.LoadFromFile();
        }

        private void XmlSave()
        {
            exp.Save();
            lblStatus.Text = "Saved experiment.xml";
        }

        /////////////////////////////////////////////////////////////////////////////////
        // GUI bindings


        private void btnScanFolder_Click(object sender, EventArgs e)
        {
            ScanExperimentFolder();
        }

        private void lbFolderNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            FolderSelected(lbFolderNames.SelectedItem.ToString());
            lbFolderNames.Focus();
        }

        private void btnXmlRevert_Click(object sender, EventArgs e)
        {
            FolderSelected(lbFolderNames.SelectedItem.ToString());
        }

        private void btnXmlSave_Click_1(object sender, EventArgs e)
        {
            XmlSave();
            SaveNeeded(false);
        }

        private void lbFolderNames_DoubleClick(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(exp.pathSelectedFolder);
        }

        private void tbAnimal_TextChanged(object sender, EventArgs e)
        {
            exp.animal = tbAnimal.Text;
            SaveNeeded();
        }

        private void tbBath_TextChanged(object sender, EventArgs e)
        {
            exp.bath = tbBath.Text;
            SaveNeeded();
        }

        private void tbInternal_TextChanged(object sender, EventArgs e)
        {
            exp.intrnl = tbInternal.Text;
            SaveNeeded();
        }

        private void tbNotes_TextChanged(object sender, EventArgs e)
        {
            exp.notes = tbNotes.Text;
            SaveNeeded();
        }

        private void btnTagNew_Click(object sender, EventArgs e)
        {
            exp.TagAdd(tbComment.Text, (double)nudTime.Value, cbTimeUnits.Text);
            SaveNeeded();
            UpdateGuiFromExperiment();
        }

        private void btnTagReplace_Click(object sender, EventArgs e)
        {
            exp.TagReplace(tbComment.Text, (double)nudTime.Value, cbTimeUnits.Text, lbTags.SelectedIndex);
            SaveNeeded();
            UpdateGuiFromExperiment();
        }

        private void btnTagDelete_Click(object sender, EventArgs e)
        {
            exp.TagDelete(lbTags.SelectedIndex);
            SaveNeeded();
            UpdateGuiFromExperiment();
        }

        System.Diagnostics.Stopwatch stopwatch = System.Diagnostics.Stopwatch.StartNew();
        private void cbTimer_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTimer.Checked)
            {
                stopwatch.Restart();
                timer1.Enabled = true;
                nudTime.Enabled = false;
                cbTimeUnits.Enabled = false;
                lbTags.Enabled = false;
                cbTimeUnits.Text = "min";
                lbTags.SelectedIndex = -1;
            }
            else
            {
                timer1.Enabled = false;
                nudTime.Enabled = true;
                cbTimeUnits.Enabled = true;
                lbTags.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            double minutesPassed = stopwatch.ElapsedMilliseconds / 1000.0 / 60.0;
            nudTime.Value = (decimal)(Math.Round(minutesPassed, 2));
        }

        private void setExperimentFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var diag = new FolderBrowserDialog();
            if (diag.ShowDialog() == DialogResult.OK)
            {
                PathOutputFolder = diag.SelectedPath;
                ScanExperimentFolder();
            }
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScanExperimentFolder();
        }

        private void launchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(exp.pathSelectedFolder);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string msg = $"Are you sure you want to delete this folder?\n\n{exp.pathSelectedFolder}";
            DialogResult dialogResult = MessageBox.Show(msg, "Delete folder?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                System.IO.Directory.Delete(exp.pathSelectedFolder, true);
                ScanExperimentFolder();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Delete:
                    deleteToolStripMenuItem_Click(null, null);
                    break;
                case Keys.F5:
                    ScanExperimentFolder();
                    break;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/swharden/PrairieViewer");
        }

        private void documentationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/swharden/PrairieViewer");
        }

        private void lbTags_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbTags.SelectedIndex < 0 || lbTags.SelectedIndex >= exp.tags.Count)
            {
                btnTagReplace.Enabled = false;
                btnTagDelete.Enabled = false;
                return;
            }
            else
            {
                btnTagReplace.Enabled = true;
                btnTagDelete.Enabled = true;

                tbComment.Text = exp.tags[lbTags.SelectedIndex].comment;
                nudTime.Value = (decimal)exp.tags[lbTags.SelectedIndex].timeValue;
                cbTimeUnits.Text = exp.tags[lbTags.SelectedIndex].timeUnit;
            }
        }
    }
}
