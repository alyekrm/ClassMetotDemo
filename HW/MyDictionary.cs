using System;
using System.Collections.Generic;
using System.Text;

namespace HW
{

    class MyDictionary<T,Y>
    {
        T[] keys;
        Y[] values;
        public MyDictionary()
        {
            keys = new T[0];
            values = new Y[0];
        }
        public void Add(T key,Y value)
        {

            
            T[] tempKey = keys;
            Y[] tempValue = values;


            keys = new T[keys.Length + 1];
            values = new Y[values.Length + 1];

            for (int i = 0; i < tempKey.Length; i++)
            {
                keys[i] = tempKey[i];
                values[i] = tempValue[i];
            }
            
            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;
        }

        

        public int Count
        {
            get { return  keys.Length; }
        }
        public T[] Keys
        {
            get { return keys; }
        }

        public Y[] Values
        {
            get { return values; }
        }


 
   
    }
}
