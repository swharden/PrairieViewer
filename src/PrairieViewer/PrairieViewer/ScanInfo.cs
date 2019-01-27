using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace PrairieViewer
{
    public class Laser
    {
        public readonly double Power;
        public readonly string Name;
        public Laser(string name, double power)
        {
            Power = power;
            Name = name;
        }
    }

    public class ScanInfo
    {
        public string Version;
        public string Date;
        public string SequenceType;
        public double[] FrameTimes;
        public string LaserName;
        public double LaserPower;
        private Laser[] Lasers;

        public ScanInfo(string pathXML)
        {

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(pathXML);

            // top level XML properties
            Version = xmlDoc.DocumentElement.SelectSingleNode("/PVScan").Attributes["version"].Value;
            Date = xmlDoc.DocumentElement.SelectSingleNode("/PVScan").Attributes["date"].Value;

            // scan settings
            SequenceType = xmlDoc.DocumentElement.SelectSingleNode("/PVScan/Sequence").Attributes["type"].Value;

            // load all laser settings
            LaserName = "none";
            LaserPower = -1;
            XmlNodeList nodesLaserPower = xmlDoc.DocumentElement.SelectNodes("/PVScan/PVStateShard/PVStateValue[@key='laserPower']");
            if (nodesLaserPower.Count > 0)
            {
                Lasers = new Laser[3];
                foreach (XmlElement xmlLaser in nodesLaserPower[0].ChildNodes)
                {
                    int laserIndex = int.Parse(xmlLaser.Attributes["index"].Value);
                    double laserPower = double.Parse(xmlLaser.Attributes["value"].Value);
                    string laserName = xmlLaser.Attributes["description"].Value;
                    Lasers[laserIndex] = new Laser(laserName, laserPower);

                    // if this laser is 
                    if (laserPower > 0)
                    {
                        LaserName = laserName;
                        LaserPower = laserPower;
                    }
                }
            }
            else
            {
                Lasers = new Laser[0];
            }


            // frame-by-frame details
            XmlNodeList nodesFrame = xmlDoc.DocumentElement.SelectNodes("/PVScan/Sequence/Frame");
            int frameCount = nodesFrame.Count;
            FrameTimes = new double[frameCount];
            for (int i = 0; i < frameCount; i++)
                FrameTimes[i] = double.Parse(nodesFrame[i].Attributes["relativeTime"].Value);

            // display info
            Console.WriteLine("");
            Console.WriteLine($"PV version: {Version}");
            Console.WriteLine($"filename: {System.IO.Path.GetFileName(pathXML)}");
            Console.WriteLine($"scan type: {SequenceType}");
            Console.WriteLine($"frame count: {nodesFrame.Count}");
            Console.WriteLine($"lasers: {Lasers.Length}");
            Console.WriteLine($"primary laser: {LaserName} (power: {LaserPower})");

        }
    }
}
