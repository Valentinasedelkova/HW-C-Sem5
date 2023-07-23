// // Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] GenArray(int length, int min, int max)
{
  int[] array = new int[length];
  Random random = new Random();
  for (int i = 0; i < length; i++)
  {
    array[i] = random.Next(min, max);
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

   int NumbersSum (int[] array)
   {
    int sum = 0;
    for (int j = 1; j < array.Length; j+=2)
    {
    
         sum += array[j]; 
        
    }
    return sum; 
}

int GetInfo(string message)
{
    Console.Write(message);
    int inputNum = Convert.ToInt32(Console.ReadLine());
    return inputNum;
}

int number = GetInfo("Введите значение размера массива: ");
int min = GetInfo("Введите минимальное значение диапазона массива: ");
int max = GetInfo("Введите максимальное значение диапазона массива: ");

int[] array = GenArray(number, min, max);
PrintArray(array); 
int sum = NumbersSum(array);
Console.WriteLine($"-> {sum}");
