using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XML
{
    public class MyClass
    {
        string id = "Hospital";
        int size = 10;
        Point position = new Point(20, 30);
        string password = "1234567890_password";
        List<string> items = new List<string>();


        // xml атрибут 
        [XmlAttribute("SerialID")]
        public string ID
        {
            get { return id; }
            set { id = value; }
        }
        [XmlAttribute("Length")]
        public int Size
        {
            get { return size; }
            set { size = value; }
        }
        [XmlElement("Pos")]
        public Point Position { get { return position; } set {  position = value; } }

        //исключаемм из процесса сериализации/десериализации.
        [XmlIgnore]
        public string Password
        { get { return password; } set {  password = value; } }

        [XmlArray("List")]
        [XmlArrayItem("Element")]
        public List<string> Items
        { get { return items; } set {  items = value; } }
    }
}
