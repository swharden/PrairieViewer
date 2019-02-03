using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PrairieViewer
{
    public class Experiment
    {
        public const int versionMajor = 1;
        public string created = "";
        public string modified = "";
        public string animal = "";
        public string intrnl = "";
        public string bath = "";
        public string notes = "";
        public readonly string pathSelectedFolder = "";
        public string pathXML { get { return System.IO.Path.Combine(pathSelectedFolder, "experiment.xml"); } }
        private string timeStampNow { get { return DateTime.Now.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss"); } }
        public List<Tag> tags { get; private set; }

        public Experiment(string pathFolder)
        {
            this.pathSelectedFolder = System.IO.Path.GetFullPath(pathFolder);
            if (!System.IO.Directory.Exists(this.pathSelectedFolder))
                throw new Exception($"Folder does not exist: {this.pathSelectedFolder}");

            LoadDefaults();
            if (System.IO.File.Exists(pathXML))
                LoadFromFile();
        }

        public void TagAdd(string comment, double timeValue, string timeUnit)
        {
            Tag tag = new Tag(comment, timeValue, timeUnit);
            tags.Add(tag);
        }

        public void TagDelete(int tagIndex)
        {
            if (tagIndex < 0 || tagIndex >= tags.Count)
                return;
            tags.RemoveAt(tagIndex);
        }

        public void TagReplace(string comment, double timeValue, string timeUnit, int tagIndex)
        {
            if (tagIndex < 0 || tagIndex >= tags.Count)
                return;
            Tag tag = new Tag(comment, timeValue, timeUnit);
            tags[tagIndex] = tag;
        }

        public string[] TagStrings()
        {
            string[] tagStrings = new string[tags.Count];
            for (int i = 0; i < tags.Count; i++)
                tagStrings[i] = tags[i].ToString();
            return tagStrings;
        }

        private void LoadDefaults()
        {
            created = timeStampNow;
            tags = new List<Tag>();
        }

        public string xml
        {
            get
            {
                XDocument xmlDoc = new XDocument();

                XElement xmlExperiment = new XElement("experiment");
                xmlExperiment.SetAttributeValue("version", $"{versionMajor}");
                xmlExperiment.SetAttributeValue("created", $"{created}");
                xmlExperiment.SetAttributeValue("modified", $"{modified}");
                xmlDoc.Add(xmlExperiment);

                XElement xmlNotes = new XElement("notes");
                xmlNotes.Value = notes.Replace("\n", "<br>").Replace("\r", "");
                xmlExperiment.Add(xmlNotes);

                XElement xmlAnimal = new XElement("animal");
                xmlAnimal.Value = animal;
                xmlExperiment.Add(xmlAnimal);

                XElement xmlBath = new XElement("bath");
                xmlBath.Value = bath;
                xmlExperiment.Add(xmlBath);

                XElement xmlInternal = new XElement("internal");
                xmlInternal.Value = intrnl;
                xmlExperiment.Add(xmlInternal);

                XElement xmlTags = new XElement("tags");
                foreach (Tag tag in tags)
                {
                    XElement xmlTag = new XElement("tag");
                    xmlTag.Value = tag.comment;
                    xmlTag.SetAttributeValue("timeValue", $"{tag.timeValue}");
                    xmlTag.SetAttributeValue("timeUnit", $"{tag.timeUnit}");
                    xmlTags.Add(xmlTag);
                }
                xmlExperiment.Add(xmlTags);

                return xmlDoc.ToString();
            }
        }

        public void Save()
        {
            modified = timeStampNow;
            System.IO.File.WriteAllText(pathXML, xml);
        }

        public void LoadFromFile()
        {
            try
            {
                XDocument xmlDoc = XDocument.Load(pathXML);
                XElement xmlExperiment = xmlDoc.Element("experiment");
                animal = xmlExperiment.Element("animal").Value;
                bath = xmlExperiment.Element("bath").Value;
                intrnl = xmlExperiment.Element("internal").Value;
                notes = xmlExperiment.Element("notes").Value.Replace("<br>", "\r\n");
                tags.Clear();

                XElement xmlTags = xmlExperiment.Element("tags");
                foreach (var xmlTag in xmlTags.Elements())
                {
                    Console.WriteLine();
                    double timeValue = double.Parse(xmlTag.Attribute("timeValue").Value);
                    string timeUnit = xmlTag.Attribute("timeUnit").Value;
                    string comment = xmlTag.Value;
                    Tag tag = new Tag(comment, timeValue, timeUnit);
                    tags.Add(tag);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"XML PARSING ERROR: {pathXML}");
                Console.WriteLine(ex);
            }
        }
    }

    public class Tag
    {
        public string timeUnit;
        public double timeValue;
        public string comment;

        public Tag(string comment, double timeValue, string timeUnit)
        {
            this.comment = comment;
            this.timeValue = timeValue;
            this.timeUnit = timeUnit;
        }

        public override string ToString()
        {
            return $"\"{comment}\" @ {timeUnit} {timeValue}";
        }
    }
}
