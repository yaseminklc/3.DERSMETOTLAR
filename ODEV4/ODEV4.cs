using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    internal class  MyDictionary<T>
    {


        T[] array;
        T[] tempArray;
        public MyDictionary()
        {
            array = new T[0];

        }
        public void Add(T item)
        {
            tempArray = array;
            array = new T[array.Length + 1];

            for (int i = 0; i < tempArray.Length; i++)
            {
                tempArray[i] = array[i];
            }
            array[array.Length - 1] = item;
        }





    }


}