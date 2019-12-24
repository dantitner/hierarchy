using GameCore.Interfaces;
using GameCore.Util;
using System;
using System.Xml;

namespace GameCore.Systems
{
    public class Loader : ILoader
    {
        private readonly string _xmlPath;

        public Loader(string xmlPath)
        {
            _xmlPath = xmlPath;
        }

        public string LoadChest()
        {
            var list = LoadNodeList("StoryEvents/ChestEvents/event");
            var index = StaticRandom.Next(0, list.Count - 1);
            var result = list.Item(index).InnerText;
            return result;
        }

        public string LoadIntro()
        {
            var list = LoadNodeList("StoryEvents/Intros/intro");
            var index = StaticRandom.Next(0,list.Count-1);
            var result = list.Item(index).InnerText;
            return result;
        }

        public string LoadOutro()
        {
            var list = LoadNodeList("StoryEvents/Outros/outro");
            var index = StaticRandom.Next(0, list.Count - 1);
            var result = list.Item(index).InnerText;
            return result;
        }



        private XmlNodeList LoadNodeList(string path)
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(_xmlPath);
            return xmlDocument.SelectNodes(path);

        }
    }
}
