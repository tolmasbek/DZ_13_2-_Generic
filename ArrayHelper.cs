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
            a=arr[0];
            T[] newArr = new T[arr.Length-1];
            for ( int i = 1; i < arr.Length; i++ )
                newArr[i] = arr[i]; 
            arr=newArr;
            return a;
        }
    }
}