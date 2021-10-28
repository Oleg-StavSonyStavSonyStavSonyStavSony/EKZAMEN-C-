using System;
using System.IO;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace EKZAMEN_C_
{
    public class Xmll{


        public void SaveXml(ListSparePart listsparePartLoad){
             // write
             XmlSerializer formatter = new XmlSerializer(typeof(ListSparePart));
             using(FileStream stream = new FileStream("SparePart.xml", FileMode.OpenOrCreate)){
                 formatter.Serialize(stream, listsparePartLoad);
             }
        }
        public ListSparePart LoadXml(){
             //      read
            ListSparePart listsparePartLoad = new ListSparePart();
            XmlSerializer formatter = new XmlSerializer(typeof(ListSparePart));
            using(FileStream stream = new FileStream("SparePart.xml", FileMode.OpenOrCreate)){
               return listsparePartLoad = (ListSparePart)formatter.Deserialize(stream);
            }
        }
    }
}