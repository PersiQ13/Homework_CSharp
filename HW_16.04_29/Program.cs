/*Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
* 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
* 6, 1, 33 -> [6, 1, 33] */

/* 1-ое решение
int[] array;
array = new int[]{6, 1, 33};

    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
*/

/* 2-ое решение 
int[] arr = new int[8];

    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = i + 1;
    }

    foreach(int num in arr)
    {
        Console.WriteLine(num);
    }
*/

int[] arr = new int[8] {81, 72, 63, 54, 45, 36, 27, 18};
        
    foreach (int i in arr)
    {
        Console.WriteLine(i);
    }