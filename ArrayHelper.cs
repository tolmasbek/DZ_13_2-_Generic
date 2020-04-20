using System;

namespace DZ_13_ArrayHelperSpace
{
    public static class ArrayHelper<T>
    {
        public static T Pop(ref T[] massiv)
        {
            T a;
            a = massiv[massiv.Length-1];
            T[] newArr = new T[massiv.Length - 1];
            for (int i = 0; i < massiv.Length - 1; i++ )
                newArr[i] = massiv[i]; 
            massiv = newArr;
            return a;
        }

        public static int Push(ref T[] massiv, T elem)
        {
            T[] newArr = new T[massiv.Length + 1];
            for (int i = 0; i < massiv.Length; i++ )
                newArr[i] = massiv[i]; 
            newArr[massiv.Length] = elem;
            massiv = newArr;
            return massiv.Length;
        }

        public static T Shift(ref T[] massiv)
        {
            T a;
            a = massiv[0];
            T[] newArr = new T[massiv.Length-1];
            for ( int i = 1; i < massiv.Length; i++ )
                newArr[i - 1] = massiv[i]; 
                massiv = newArr;
            return a;
        }

        public static int Unshift(ref T[] massiv, T elem)
        {
            T[] newArr = new T [massiv.Length + 1];
            newArr[0] = elem;
            for (int i = 1; i < massiv.Length + 1; i++ )
                newArr[i] = massiv[i - 1]; 
                newArr [massiv.Length] = elem;
            return massiv.Length;
        }       

        public static T[] Slice<F>(T[] massiv, int begin_index = 0, int end_index = 0)
        {
            T[] clean;
            if(begin_index >= 0 && end_index == 0 && begin_index <= massiv.Length)
            {
                clean = new T[massiv.Length-begin_index];
                for(int i = 0; i < clean.Length; i++)
                {
                    clean[i] = massiv[begin_index];
                    begin_index++;
                }
                return clean;
            }
            else if (begin_index > massiv.Length || end_index > massiv.Length + 1)
            {
                return clean = new T[0];
            }
            else if(begin_index < 0)
            {
                int a = massiv.Length - (massiv.Length - Math.Abs(begin_index));
                clean = new T[a];
                for(int i = 0; i < clean.Length;i++)
                {
                    clean[i] = massiv[massiv.Length - a];
                    a--;
                }
                return clean;
            }
            else if(begin_index < 0 && Math.Abs(end_index) < massiv.Length)
            {
                clean = new T[massiv.Length - Math.Abs(end_index) - begin_index];
                for(int i =0; i < clean.Length;i++)
                {
                    clean[i] = massiv[begin_index];
                    begin_index++;
                }
                return massiv;
            }
            else if(begin_index < end_index)
            {
                clean = new T[massiv.Length - begin_index];
                for(int i = 0; i < clean.Length;i++)
                {
                    clean[i] = massiv[begin_index];
                    begin_index++;
                }
                return clean;
            }
            else return clean = new T[0];
        }               
    }
}