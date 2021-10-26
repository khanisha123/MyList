using System;
using System.Collections.Generic;
using System.Text;

namespace MyList
{
    class MyList<T>
    {
        public int Count { get; set; }
        
        private T[] arr;
        public MyList()
        {
            arr = new T[10];
        }
        public void Add1(T obj)
        {
            if ((Count!=0)&&Count % 10 == 0)
            {
                ArrayResize();
            }
            arr[Count] = obj;
            Count++;
        }
        public int Count1
        {
            get
            { 
                foreach (var item in arr)
                {
                    if (item !=null)
                    {
                        Console.WriteLine(item);
                    }
                }
                return Count;
            }
        }


        public void ArrayResize()
        {
            Array.Resize(ref arr, arr.Length + 10);
        }
        public void Clear() 
        {
            arr = new T[10];
            Count = 0;
        }
        public void AddRange(IEnumerable<T> list) 
        {
            foreach (var item in list)
            {
                Add1(item);
            }
        }
        public T Find(Predicate<T> func) 
        {
            foreach (var item in arr)
            {
                if (func(item))
                {
                    return item;
                }
                
            }
            return default;
        }
        public bool Contains(T obj) 
        {
            foreach (var item in arr)
            {
                if (Comparer<T>.Default.Compare(item,obj)==0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
