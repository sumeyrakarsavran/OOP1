using System;
using System.Collections.Generic;

namespace Dictionary_
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(3, "Sümeyra");
            myDictionary.Add(5, "Eslem");
            myDictionary.Add(7, "Şeyma");

            myDictionary.Key(7);
        }
    }

    class MyDictionary<TKey,TValue>
    {
        List<TKey> _keys;
        List<TValue> _values;

        public MyDictionary()
        {
            _keys = new List<TKey>();
            _values = new List<TValue>();
        }

        public void Add(TKey key,TValue value)
        {
            _keys.Add(key);
            _values.Add(value);
        }

        public void Key(TKey key)
        {
            Console.WriteLine(_values[_keys.IndexOf(key)]);
        }
    }
}
