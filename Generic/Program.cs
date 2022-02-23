using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class Otomobil<T> // otomobil sınıfı
    {
        T t1; // t tipine t1 alanı tanımladık

        public T Deger // Özellik // T hazır tanımlı geliyor tip demek hangi türde değişken yollarsak onu kabul eder
        {
            get { return t1; }
            set { t1 = value; }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Metinsel olarak generic nesnelerini oluşturmak");
            Console.WriteLine("--------------------------------------------------");

            Otomobil<string> oto1=new Otomobil<string>(); // T ye string yolluyoruz

            oto1.Deger = "Yeni doğan şahinimiz hayırlı olsun";
            string yenideger = oto1.Deger;

            Console.WriteLine("Nesnenin değeri : "+yenideger);
            Console.WriteLine("Nesnenin değerinin tipi : "+oto1.Deger.GetType());
            Console.WriteLine();
            Console.WriteLine("Karakter olarak generic nesnelerini oluşturmak");
            Console.WriteLine("------------------------------------------------");

            Otomobil<char> oto3=new Otomobil<char>();

            oto3.Deger = 'A';
            char iyenideger1=oto3.Deger;

            Console.WriteLine("Nesnenin değeri :"+iyenideger1);
            Console.WriteLine("Nesnenin değerinin tipi : " + oto3.Deger.GetType());

            Console.ReadLine();
        }

        // generics                     nongenerivs
        // List                         ArrayList
        // Idictionary<k,t>             Hashtable
        // SortedList<Tkey,Tvalue>      SortedList
    }
}
