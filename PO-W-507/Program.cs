// Autor. mgr. inż Piotr Bilski
// Programowanie Obiektowe

using System;

namespace PO_W_507
{
    // ======== 1 ========
    class Figura
    {
        public string FigType { get; set; }
        public void UstawNaroznik()
        {
            Console.WriteLine("  Ustawiono punkt zaczepienia");
        }
    }
    class Rownoleglobok : Figura
    {
        public void Narysuj()
        {
            Console.WriteLine("  Narysowano równoległobok");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // utworzenie obiektu klasy pochodnej
            Rownoleglobok obj1 = new Rownoleglobok();
            // wywołanie właściwości zadeklarowanej w klasie
            // nadrzędnej i ustawienie typu opisowego
            obj1.FigType = "Prostokąt";
            // wyświetlenie wartości pola prywatnego FigType
            Console.WriteLine("\n  " + obj1.FigType);
            // wywołanie metody z nadklasy
            obj1.UstawNaroznik();
            // wywołanie metody z klasy własnej
            obj1.Narysuj();
            Console.ReadKey();
        }
    }

    // ========  2  ========
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        // tworzenie obiektu typu pochodnego
    //        Rownoleglobok obj1 = new Rownoleglobok();
    //        obj1.FigType = "Prostokąt";
    //        Console.WriteLine(obj1.FigType);
    //        obj1.UstawNaroznik();
    //        obj1.Narysuj();

    //        // tworzenie obiektu typu nadrzędnego
    //        Figura obj2 = new Figura();
    //        obj2.FigType = "JakaśInnaFigura";
    //        Console.WriteLine(obj2.FigType);
    //        obj2.UstawNaroznik();
    //        // wywołanie metody z typu pochodnego
    //        obj2.Narysuj();
    //    }
    //}

    // ======== 3 ========
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Rownoleglobok obj1 = new Rownoleglobok();
    //        // przepisanie obiekty klasy pochodnej do 
    //        // obiektu klasy nadrzędnej
    //        Figura obj2 = obj1;
    //        Console.WriteLine(obj2.FigType);
    //        obj2.UstawNaroznik();
    //        obj2.Narysuj();
    //        Console.ReadKey();
    //    }
    //}
}
