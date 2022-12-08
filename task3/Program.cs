// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]
Random random = new Random();
int [] arr = new int [8];
for (int i=0;i<arr.Length-1;i++)
    arr[i] = random.Next(-9, 10);
void PrintArray(int[]array)
{
    int count = array.Length;
    for(int i=0;i<count;i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
PrintArray(arr);