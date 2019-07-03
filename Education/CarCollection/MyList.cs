﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public class MyList<T> : IMyList<T>
    {
        protected T[] array;

        public MyList()
        {
            array = new T[0];
        }

        public void Add(T a)
        {
            T[] tempArray = new T[array.Length + 1];

            for (int i = 0; i < array.Length; i++)
            {
                tempArray[i] = array[i];
            }

            tempArray[array.Length] = a;
            array = tempArray;
        }

        public T this[int index]
        {
            get
            {
                return array[index];
            }
        }

        public int Count
        {
            get
            {
                return array.Length;
            }
        }

        public void Clear()
        {
            array = new T[0];
        }

        public bool Contains(T item)
        {

            for (int i = 0; i < array.Length; i++)
            {
                if (this.array[i].Equals(item))
                {
                    return true;
                }
            }
            return false;
        }

        public override string ToString()
        {
            string str = null;
            for (int i = 0; i < array.Length; i++)
            {
                str += this.array[i] + " ";
            }
            return "arrays length " + array.Length + "arrays elememts " + str;
        }
    }
}

