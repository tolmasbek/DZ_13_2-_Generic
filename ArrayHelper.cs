namespace DZ_13_ArrayHelperSpace
{
    public static class ArrayHelper<T>
    {
        public static T Pop(ref T[] arr)
        {
            T a;
            a=arr[arr.Length-1];
            T[] newArr = new T[arr.Length - 1];
            for (int i = 0; i < arr.Length - 1; i++ )
                newArr[i] = arr[i]; 
            arr=newArr;
            return a;
        }

        public static int Push(ref T[] arr, T elem)
        {
            T[] newArr = new T[arr.Length + 1];
            for (int i = 0; i < arr.Length; i++ )
                newArr[i] = arr[i]; 
            newArr[arr.Length] = elem;
            arr = newArr;
            return arr.Length;
        }

        public static T Shift(ref T[] arr)
        {
            T a;
            a = arr[0];
            T[] newArr = new T[arr.Length-1];
            for ( int i = 1; i < arr.Length; i++ )
                newArr[i] = arr[i]; 
            arr = newArr;
            return a;
        }

        public static int Unshift(ref T[] arr, T elem)
        {
            T[]newArr = new T [arr.Length + 1];
            newArr[0] = elem;
            for (int i = 1; i < arr.Length + 1; i++ )
                newArr[i] = arr[i - 1]; 
            newArr [arr.Length] = elem;
            return arr.Length;
        }       

        public static T[] Slice(T[] arr, int beginindex, int endindex)
        {
            int len = endindex - beginindex + 1;
            if(len < 1 || len > arr.Length || endindex > (arr.Length - 1) || beginindex < 0){
                return new T[0];
            }
            T[]newArr = new T [len];
            for(int i = beginindex; i <= endindex; i++)
            {
                newArr[i - beginindex] = arr[i];
            }
            return newArr;
        }       
        
    }
}