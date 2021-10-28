using System;

namespace EKZAMEN_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ListSparePart listsparePart = new ListSparePart();
            for (var i = 0; i < 10; i++){
                listsparePart.ADD(new SparePart ("JAPAN"+i.ToString(), i+1, i+1,"NISSAN"+i.ToString(), "NV - 200"+i.ToString(), "podveska"+i.ToString());
                }



 //      write
            Xmll xmll = new Xmll();
           
            xmll.SaveXml(listsparePart);
            
            //      read
           ListSparePart listsparePartLoad = new ListSparePart();
            listsparePartLoad = xmll.LoadXml();
        
           for (var i = 0; i < listsparePartLoad.Count; i++)
           {
               Console.WriteLine(listsparePartLoad[i]);
           }

            
        }
    }
}
