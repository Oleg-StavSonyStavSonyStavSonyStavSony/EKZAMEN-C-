using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace EKZAMEN_C_
{
     [Serializable]
    public class ListSparePart : List<SparePart>,IDisposable{
        public ListSparePart(){
           // base = new List<User>();
           
        }
        public void ADD(SparePart part){
            base.Add(part);
        }
         public  void Dispose(){
            GC.Collect(GC.GetGeneration(this));
        }
    }

}
