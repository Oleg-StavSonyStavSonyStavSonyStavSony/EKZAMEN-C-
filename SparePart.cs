using System;

namespace EKZAMEN_C_
{
    public class SparePart 
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public int Price { get; set; }
        public string BrandAvto { get; set; }
        public string MarakAvto { get; set; }
        public string CategoriSparePart { get; set; }
        public SparePart (){
            Name = null;
            Id = 0;
            Price = 0;
            BrandAvto = null;
            MarakAvto = null;
            CategoriSparePart = null;
        }
        public SparePart (string name, int id, int price, string brend, string mark, string categori){
            Name = name;
            Id = id;
            Price = price;
            BrandAvto = brend;
            MarakAvto = mark;
            CategoriSparePart = categori;

        }
        

        public override string ToString() => $"Id - {Id}, Name - {Name}, BrandAvto - {BrandAvto}, MarakAvto - {MarakAvto}, CategoriSparePart - {CategoriSparePart}, Price - {Price}, ";
       
    }

}