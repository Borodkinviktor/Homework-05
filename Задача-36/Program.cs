/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

int [] RandomArray()
{
    int [] array = new int[6];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(-10, 10);
    }
    return array;
}

void PrintResult(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int SummElements(int [] array)
{
    int summ = 0;

    for (int i = 0; i < array.Length; i++)
      {
       if(array[i] %2 != 0)
         {
            summ += array[i];
         }
      }
   return summ;
}

int  [] arr = RandomArray();
PrintResult(arr);
Console.WriteLine();
int resultOddSumma = SummElements(arr);
int resultOddSumm = SummElements(arr);
Console.WriteLine($"Сумма нечетных элементов {resultOddSumm}");


