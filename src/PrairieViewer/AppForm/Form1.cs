using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string pathDemoData = System.IO.Path.GetFullPath("../../../../../data/stripped");
            UpdateDataGridFromFilesystem(pathDemoData);
        }

        private void UpdateDataGridFromFilesystem(string pathFolder)
        {
            DataTable table = new DataTable();
            table.Columns.Add("name", typeof(string));
            table.Columns.Add("version", typeof(string));
            table.Columns.Add("type", typeof(string));
            table.Columns.Add("frames", typeof(int));
            table.Columns.Add("laserName", typeof(string));
            table.Columns.Add("laserPower", typeof(double));
            table.Columns.Add("duration (sec)", typeof(double));
            table.Columns.Add("framerate (fps)", typeof(double));

            foreach (string dataFolder in System.IO.Directory.GetDirectories(pathFolder))
            {
                var pv = new PrairieViewer.PrairieFolder(dataFolder);
                double frameTimeLast = pv.info.FrameTimes[pv.info.FrameTimes.Length - 1];
                double framesPerSec = pv.info.FrameTimes.Length / frameTimeLast;

                DataRow row = table.NewRow();
                int column = 0;
                row.SetField(column++, pv.FolderName);
                row.SetField(column++, pv.info.Version);
                row.SetField(column++, pv.info.SequenceType);
                row.SetField(column++, pv.info.FrameTimes.Length);
                row.SetField(column++, pv.info.LaserName);
                row.SetField(column++, Math.Round(pv.info.LaserPower, 2));
                row.SetField(column++, Math.Round(frameTimeLast, 2));
                row.SetField(column++, Math.Round(framesPerSec, 2));
                table.Rows.Add(row);
            }

            dataGridView1.DataSource = table;
            dataGridView1.AutoResizeColumns();
        }
    }
}
