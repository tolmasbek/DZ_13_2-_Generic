using System;
using DZ_13_ArrayHelperSpace;
namespace DZ_13_ArrayHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] array = new int [] {10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 0};

            System.Console.WriteLine("Выберите один из действий для данного массива: ");
            System.Console.WriteLine("1. Pop – Удаляет последний элемент массива");
            System.Console.WriteLine("2. Push – Добавляет элемент с конца массива");
            System.Console.WriteLine("3. Shift – Удаляет первый элемент"); 
            System.Console.WriteLine("4. UnShift – Добавляет элемент в начало массива");
            System.Console.WriteLine("5. Slice – возвращает новый массив, содержащий копию части исходного массива");
            System.Console.Write("Ваш выбор: ");  
            int choise = int.Parse(Console.ReadLine());
            switch(choise)
            {
                case 1:
                {
                    System.Console.Write("Введите елемент для добавления: ");
                    int elem = ArrayHelper<int>.Pop(ref array);
                    System.Console.WriteLine(elem);
                    for(int i = 0; i < array.Length; i++)
                    System.Console.Write(array[i]);
                    break;
                }
                
                case 2:
                {
                    System.Console.Write("Введите елемент для добавления: ");
                    int num = int.Parse(Console.ReadLine());
                    int size = ArrayHelper<int>.Push(ref array, num);
                    System.Console.WriteLine("Размер массива " + size);
                    System.Console.Write("Созданный массив: ");
                    for(int i = 0; i < array.Length; i++)
                    System.Console.Write(array[i] + " ");
                    break;
                }
                
                case 3:
                {
                    int elem = ArrayHelper<int>.Shift(ref array);
                    System.Console.WriteLine(elem);
                    for(int i = 0; i < array.Length; i++)
                    System.Console.Write(array[i] + " ");
                    break;
                }
                case 4:
                {
                    System.Console.Write("Введите елемент для добавления: ");
                    int num = int.Parse(Console.ReadLine());

                    int size = ArrayHelper<int>.Unshift(ref array, num);
                    System.Console.WriteLine(size);
                    break;
                }
                case 5:
                {
                    for(int i = 0; i < array.Length; i++)
                    System.Console.Write(array[i] + " ");
                    
                    System.Console.WriteLine();

                    System.Console.Write("Введите начальный beginindex: ");
                    int a = int.Parse(Console.ReadLine()); 
                    
                    System.Console.Write("Введите конечный endindex: ");
                    int b = int.Parse(Console.ReadLine());
                    
                    System.Console.WriteLine("Ваш массив с началом beginindex и концом endindex");
                    int[] array2 = ArrayHelper<int>.Slice(array, a, b);
                    foreach(int item in array2)
                    {
                        System.Console.Write(item + " ");
                    }
                    break;
                }
            }    
            Console.ReadKey();
        }
    }
}
