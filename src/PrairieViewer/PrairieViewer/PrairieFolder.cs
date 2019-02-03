using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrairieViewer
{

    public class PrairieFolder
    {
        public readonly string PathFolder;
        public readonly string FolderName;
        public string PathXML { get; private set; }
        public string PathENV { get; private set; }
        public string PathCFG { get; private set; }
        public string[] PathsTIF { get; private set; }
        public ScanInfo info;

        public PrairieFolder(string pathFolder)
        {
            PathFolder = pathFolder;
            FolderName = System.IO.Path.GetFileName(pathFolder);
            ReadFileNames();

            if (PathXML != null)
                info = new ScanInfo(PathXML);
        }

        private void ReadFileNames()
        {
            List<string> pathsTIF = new List<string>();
            foreach (string filePath in System.IO.Directory.GetFiles(PathFolder)) { 
                string fileName = System.IO.Path.GetFileName(filePath);
                int numberOfDashes = fileName.Split('-').Length - 1;
                if (fileName.EndsWith(".xml") && numberOfDashes == 3)
                    PathXML = filePath;
                if (fileName.EndsWith(".env") && numberOfDashes == 3)
                    PathENV = filePath;
                if (fileName.EndsWith(".cfg") && numberOfDashes == 3)
                    PathCFG = filePath;
                if (fileName.EndsWith(".tif"))
                    pathsTIF.Add(filePath);
            }
            PathsTIF = pathsTIF.ToArray();
        }
    }
}
