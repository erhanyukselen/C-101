using System;

namespace Polymorphism
{
    public class Hayvanlar : Canlilar
    {
        protected void Adaptasyon(){
            Console.WriteLine("Hayvanlar adaptasyon kurabilir.");
        }


        public override void UyaranlaraTepki(){
            //base.UyaranlaraTepki();
            Console.WriteLine("Hayvanlar temase tepki verir.");
        }
    }

    public class Surungenler : Hayvanlar{
        public Surungenler(){
            base.Adaptasyon();
            base.Beslenme();
            base.Bosaltım();
            base.Solunum();
        }
        public void SurunerekHareketEderler(){
            System.Console.WriteLine("Sürüngenler sürünerek hareket ederler.");
            
        }
    }
    public class Kuslar : Hayvanlar{
        public Kuslar(){
            base.Adaptasyon();
            base.Beslenme();
            base.Bosaltım();
            base.Solunum();
            base.UyaranlaraTepki();
        }
        public void Ucmak(){
            Console.WriteLine("Kuslar ucabilir.");
        }
    }


    
}