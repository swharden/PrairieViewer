using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathHere = System.IO.Path.GetFullPath("./");
            string pathDemoData = System.IO.Path.GetFullPath("../../../../../data/stripped");

            if (!System.IO.Directory.Exists(pathDemoData))
                throw new Exception($"demo data path cannot be found: {pathDemoData}");
            else
                System.Console.WriteLine($"Using demo data path: {pathDemoData}");

            string[] dataFolders = System.IO.Directory.GetDirectories(pathDemoData);
            foreach (string dataFolder in dataFolders)
            {
                var fldr = new PrairieViewer.PrairieFolder(dataFolder);
            }

            Console.WriteLine("\npress ENTER to exit...");
            Console.ReadLine();
        }
    }
}
