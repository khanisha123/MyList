using System;
using System.Collections.Generic;


namespace MyList
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> myList = new MyList<string>();            
            myList.Add1("Gunel");
            myList.Add1("Resul");
            myList.Add1("Altun");
            myList.Add1("Khanisha");
            myList.Add1("Eli");
            Console.WriteLine(myList.Count1);
        }
    }
}
