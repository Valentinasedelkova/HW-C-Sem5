// // Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] GenArray(int length)
{
  int[] array = new int[length];
  Random random = new Random();
  for (int i = 0; i < length; i++)
  {
    array[i] = random.Next(100, 1000);
  }

    return array;
}

void PrintArray(int[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        System.Console.Write($"{array[i]}, ");
    }
    System.Console.Write($"{array[array.Length -1]}");
   System.Console.Write("]");
   
}

   int NumbersCount (int[] array)
   {
    int count = 0;
    for (int j = 0; j < array.Length; j++)
    {
        if (array[j] % 2 == 0)
        {
         count++; 
        }
    }
    return count; 
}

int GetInfo(string message)
{
    Console.Write(message);
    int inputNum = Convert.ToInt32(Console.ReadLine());
    return inputNum;
}

int number = GetInfo("Введите значение размера массива: ");
int[] array = GenArray(number);
PrintArray(array); 
int count = NumbersCount(array);
Console.WriteLine($"-> {count}");