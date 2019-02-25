using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Assignment5.Data
{
    public class ItemsData
    {
        [XmlArray]
        public List<Item> Items { get; set; }

        public ItemsData()
        {
            Items = new List<Item>();
        }
    }
}
