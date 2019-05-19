using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Collections;
using System.Xml;

namespace ConfigTest.SectionHandler
{
    public class MySectionHandler : IConfigurationSectionHandler
    {
        public object Create(object parent, object configContext, System.Xml.XmlNode section)
        {
            Hashtable ht = new Hashtable();
            foreach (XmlNode node in section.ChildNodes)
            {
                if (node.Name == "add")
                {
                    ht.Add(node.Attributes["key"].Value, node.Attributes["value"].Value);
                }
            }
            return ht;
        }
    }
}
