using System;

namespace EKZAMEN_C_
{
    public class MyClass{
        ListSparePart listsparePart = new ListSparePart();
        Xmll xmll = new Xmll();
        public void Start(){ 
            Console.WriteLine("[1] - Admin]\n[2] - User\n[3] - EXIT");
            int choice = int.Parse(Console.ReadLine());
            do {
                 if(choice == 1){
                    Console.WriteLine("MENU Admin]");
                    Console.WriteLine("[1] - Search for a new part\n[2] - Search used spare parts\n[3] - EXIT");
                    if(choice == 3){
                        break;
                    }
                    if(choice == 1){
                        ListSparePart listsparePartLoad = new ListSparePart();
                        listsparePartLoad = this.PrintXML();
                        
                    }




                }


                if(choice == 2){
                    Console.WriteLine("MENU User]");
                    Console.WriteLine("[1] - Search for a new part\n[2] - Search used spare parts\n[5] - EXIT");
                    if(choice == 5){
                        break;

                    }


                }
                if(choice == 3){


                }

              
              }while(choice != 3);
        }

        public void InitList()
        {
            for (var i = 0; i < 10; i++){
                listsparePart.ADD(new SparePart ("JAPAN"+i.ToString(), i+1, i+1,"NISSAN"+i.ToString(), "NV - 200"+i.ToString(), "podveska"+i.ToString()));
                }
                this.RidXML();
        }

        public void RidXML(){
            xmll.SaveXml(listsparePart);
        }
        
        public ListSparePart PrintXML(){
            //      read
           ListSparePart listsparePartLoad = new ListSparePart();
            listsparePartLoad = xmll.LoadXml();
        
           for (var i = 0; i < listsparePartLoad.Count; i++)
           {
               Console.WriteLine(listsparePartLoad[i]);
           }
           return listsparePartLoad;
        }
    }
}