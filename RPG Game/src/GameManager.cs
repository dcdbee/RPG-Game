using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace RPG_Game.src
{
    public class GameManager
    {
        private bool newGame = false;
        private string path = "info.xml";
        private Trainer Player = new Trainer();
        public GameManager()
        {
        }

        #region Getters + Setters
        public Trainer GetPlayer()
        {
            return Player;
        }
        public void SetPlayer(Trainer input)
        {
            Player = input;
        }
        #endregion

        public void Load()
        {
            if (SaveExists())
            {
                Player = InternalLoader<Trainer>();
            }
        }

        public void InternalSaver<T>(T serializableObject)
        {
            string filepath = "info.xml";
            if (SaveExists())
            {
                File.WriteAllText(filepath, "");
            }
            var serializer = new DataContractSerializer(typeof(T));
            var settings = new XmlWriterSettings()
            {
                Indent = true,
                IndentChars = "\t",
            };
            var writer = XmlWriter.Create(filepath, settings);
            serializer.WriteObject(writer, serializableObject);
            writer.Close();
        }
        private T InternalLoader<T>()
        {
            string filepath = "info.xml";
            var fileStream = new FileStream(filepath, FileMode.Open);
            var reader = XmlDictionaryReader.CreateTextReader(fileStream, new XmlDictionaryReaderQuotas());
            var serializer = new DataContractSerializer(typeof(T));
            T serializableObject = (T)serializer.ReadObject(reader, true);
            reader.Close();
            fileStream.Close();
            return serializableObject;
        }
        public bool SaveExists()
        {
            bool valid;
            try
            {
                valid = true;
                XDocument xd1 = new XDocument();
                xd1 = XDocument.Load(path);
            }
            catch (XmlException exception)
            {
                valid = false;
            }
            return valid;
        }
    }
}
