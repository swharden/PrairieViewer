using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExperimentNotes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Experiment exp;

        private void Form1_Load(object sender, EventArgs e)
        {
            tbPathXML.Text = System.IO.Path.GetFullPath("test.xml");

            // create or load an experiment
            exp = new Experiment();
            UpdateGuiFromExperiment();
        }

        private string FormatForTextbox(string s)
        {
            return s.Replace("\r", "").Replace("\n", "\r\n");
        }

        private void UpdateGuiFromExperiment()
        {
            tbAnimal.Text = exp.animal;
            tbInternal.Text = exp.intrnl;
            tbBath.Text = exp.bath;
            tbNotes.Text = FormatForTextbox(exp.notes);

            lbTags.Items.Clear();
            foreach (Tag tag in exp.tags)
            {
                lbTags.Items.Add(tag.ToString());
            }

            btnPreview_Click(null, null);
        }

        private void UpdateExperimentFromGUI()
        {
            exp.animal = tbAnimal.Text;
            exp.intrnl = tbInternal.Text;
            exp.bath = tbBath.Text;
            exp.notes = tbNotes.Text;
        }

        private void lbTags_SelectedValueChanged(object sender, EventArgs e)
        {
            int selectedTag = lbTags.SelectedIndex;
            Tag tag = exp.tags[selectedTag];
            nudTime.Value = (decimal)tag.timeValue;
            cbTimeUnits.Text = tag.timeUnit;
            tbComment.Text = tag.comment;
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            UpdateExperimentFromGUI();
            tbXML.Text = FormatForTextbox(exp.GetXML());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            exp.modified = exp.GetTimeStamp();
        }

        private void btnTagDelete_Click(object sender, EventArgs e)
        {
            int selectedTag = lbTags.SelectedIndex;
            if (selectedTag < 0)
                return;
            exp.tags.RemoveAt(selectedTag);
            UpdateGuiFromExperiment();
            if (lbTags.Items.Count > 0)
            {
                if (selectedTag < lbTags.Items.Count)
                    lbTags.SelectedIndex = selectedTag;
                else
                    lbTags.SelectedIndex = lbTags.Items.Count-1;
            }
        }

        private void btnTagNew_Click(object sender, EventArgs e)
        {
            Tag tag = new Tag(tbComment.Text, (double)nudTime.Value, cbTimeUnits.Text);
            exp.tags.Add(tag);
            UpdateGuiFromExperiment();
            lbTags.SelectedIndex = lbTags.Items.Count - 1;
        }

        private void btnTagReplace_Click(object sender, EventArgs e)
        {
            int selectedTag = lbTags.SelectedIndex;
            if (selectedTag < 0)
                return;
            Tag tag = new Tag(tbComment.Text, (double)nudTime.Value, cbTimeUnits.Text);
            exp.tags[selectedTag] = tag;
            UpdateGuiFromExperiment();
        }
    }
}
