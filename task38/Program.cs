// // Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] GenArray(int length)
{
  double[] array = new double[length];
  Random random = new Random();
  for (int i = 0; i < length; i++)
  {
    double randomNumber = random.NextDouble() * 100;
    array[i] = randomNumber;
  }

    return array;
}

void PrintArray(double[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        System.Console.Write($"{array[i]}, ");
    }
    System.Console.Write($"{array[array.Length -1]}");
   System.Console.Write("]");
   
}

   double FindMin (double[] array)
   {
    double min = array[0];
    for (int j = 1; j < array.Length; j++)
    {
    if (array[j] < min)
    {
        min = array[j];
    }
        
    }
    return min; 
}

double FindMax (double[] array)
   {
    double max = array[0];
    for (int j = 1; j < array.Length; j++)
    {
    if (array[j] > max)
    {
        max = array[j];
    }
        
    }
    return max; 
}

double FindMaxMinDiff (double min, double max)
{
    double result = max - min;
    return result;
}

int GetInfo(string message)
{
    Console.Write(message);
    int inputNum = Convert.ToInt32(Console.ReadLine());
    return inputNum;
}

int number = GetInfo("Введите значение размера массива: ");

double[] array = GenArray(number);
PrintArray(array); 
double min1 = FindMin(array);
double max1 = FindMax(array);
double diff = FindMaxMinDiff(min1, max1);
Console.WriteLine($"-> {max1} - {min1} = {diff}");
