using System;

namespace Polymorphism
{
    public class Canlilar
    {
        protected void Beslenme(){
            Console.WriteLine("Canlılar beslenir.");
        }
        protected void Solunum(){
            Console.WriteLine("Canlılar solunum yapar.");
        }
        protected void Bosaltım(){
            Console.WriteLine("Canlılar bosaltım yapar.");
        }

        public virtual void UyaranlaraTepki(){
            Console.Write("Canlılar uyaranlara tepki verir.");
        }
        
    } 
}