using GameCore.Interfaces;
using GameCore.Util;
using System;
using System.Xml;

namespace GameCore.Systems
{
    public class Loader : ILoader
    {
        private const string OUTROPATH = "StoryEvents/Outros/outro";
        private const string INTROPATH = "StoryEvents/Intros/intro";
        private const string CHESTPATH = "StoryEvents/ChestEvents/event";

        private readonly string _xmlPath;

        public Loader(string xmlPath)
        {
            _xmlPath = xmlPath;
        }

        public string LoadChest()
        {
            return FindRandomItemInnerText(CHESTPATH);
        }

        public string LoadIntro()
        {
            return FindRandomItemInnerText(INTROPATH);
        }

        public string LoadOutro()
        {
            return FindRandomItemInnerText(OUTROPATH);
        }


        private string FindRandomItemInnerText(string path)
        {
            var list = LoadNodeList(path);
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
