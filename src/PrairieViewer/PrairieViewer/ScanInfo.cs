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
        public int FrameCount;
        public double FramePeriod;
        public double FrameRate { get { return 1.0 / FramePeriod; } }
        private Laser[] Lasers;
        public string PathXML;

        public ScanInfo(string pathXML)
        {
            PathXML = System.IO.Path.GetFullPath(pathXML);

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(pathXML);

            // top level XML properties
            Version = xmlDoc.DocumentElement.SelectSingleNode("/PVScan").Attributes["version"].Value;
            Date = xmlDoc.DocumentElement.SelectSingleNode("/PVScan").Attributes["date"].Value;

            // scan settings
            SequenceType = xmlDoc.DocumentElement.SelectSingleNode("/PVScan/Sequence").Attributes["type"].Value;

            // frame period
            XmlNodeList nodesFramePeriod = xmlDoc.DocumentElement.SelectNodes("/PVScan/PVStateShard/PVStateValue[@key='framePeriod']");
            if (nodesFramePeriod.Count > 0)
                FramePeriod = double.Parse(nodesFramePeriod[0].Attributes["value"].Value);

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
            FrameCount = nodesFrame.Count;
            FrameTimes = new double[FrameCount];
            for (int i = 0; i < FrameCount; i++)
                FrameTimes[i] = double.Parse(nodesFrame[i].Attributes["relativeTime"].Value);            
        }

        public string GetInfo()
        {
            string message = "";
            message += $"PV version: {Version}\n";
            message += $"filename: {System.IO.Path.GetFileName(PathXML)}\n";
            message += $"scan type: {SequenceType}\n";
            message += $"frame count: {FrameCount}\n";
            message += $"frame period: {Math.Round(FramePeriod, 3)} sec ({Math.Round(FrameRate, 3)} Hz)\n";
            message += $"lasers: {Lasers.Length}\n";
            message += $"primary laser: {LaserName} (power: {Math.Round(LaserPower, 2)})\n";
            return message.Trim();
        }
    }
}
