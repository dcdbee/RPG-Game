using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace RPG_Game.src
{
    public class GameManager
    {
        private string path = "info.xml";
        private Trainer Player = new Trainer();
        public GameManager()
        {
            Player = Loader<Trainer>();
            Console.WriteLine(Player.GetName());
            Console.WriteLine(Player.GetPokemonList()[0].GetID());
        }

        public void Saver<T>(T serializableObject)
        {
            string filepath = "info.xml";
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
        public T Loader<T>()
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
    }
}
