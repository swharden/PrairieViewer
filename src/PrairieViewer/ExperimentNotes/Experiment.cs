using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ExperimentNotes
{
    class Experiment
    {
        public const int versionMajor = 1;
        public string created = "";
        public string modified = "";
        public string animal = "";
        public string intrnl = "";
        public string bath = "";
        public string notes = "";
        public List<Tag> tags;

        public Experiment()
        {
            created = GetTimeStamp();
            tags = new List<Tag>();
        }

        public string GetDisplayString()
        {
            string message = $"Experiment (version {versionMajor})\n";
            message += $"Animal: {animal}\n";
            message += $"Internal: {intrnl}\n";
            message += $"Bath: {bath}\n";
            for (int i = 0; i < tags.Count; i++)
            {
                Tag tag = tags[i];
                message += $"TAG {i + 1}: {tag}\n";
            }
            message += $"Notes: {notes}\n";
            message.Trim();
            return message;
        }

        public string GetTimeStamp()
        {
            return DateTime.Now.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss");
        }

        public string GetXML()
        {

            XDocument xmlDoc = new XDocument();

            XElement xmlExperiment = new XElement("Experiment");
            xmlExperiment.SetAttributeValue("version", $"{versionMajor}");
            xmlExperiment.SetAttributeValue("created", $"{created}");
            xmlExperiment.SetAttributeValue("modified", $"{modified}");
            xmlDoc.Add(xmlExperiment);

            XElement xmlNotes = new XElement("notes");
            xmlNotes.Value = notes.Replace("\n", "\\n").Replace("\r", "");
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

    public class Tag
    {
        public string timeUnit;
        public double timeValue;
        public string comment;

        public Tag(string comment, double value, string unit)
        {
            this.comment = comment;
            this.timeValue = value;
            this.timeUnit = unit;
        }

        public override string ToString()
        {
            return $"\"{comment}\" @ {timeUnit} {timeValue}";
        }
    }
}
