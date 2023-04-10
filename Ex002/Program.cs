// Задача 32: Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие 
// отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

/*
int[] array = {-4, -8, 8, 2} ;
PrintArray(array);
int[] array2 = NegArray(array);


PrintArray(array2);

void PrintArray(int[] array)
{
    Console.Write("{");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]},");
    }
    Console.WriteLine(array[^1] + "}");
}

void NegArray(int[] array1)
{
    for (int i = 0; i < array1.Length; i++)
    {
        array1[i] = -array1[i];
    }
}
*/


int[] array = { -4, -8, 8, 2 };
PrintArray(array);
int[] array2 = NegArray(array);


PrintArray(array2);

void PrintArray(int[] array)
{
  Console.Write("{");
  for (int i = 0; i < array.Length - 1; i++)
  {
    Console.Write($"{array[i]},");
  }
  Console.WriteLine(array[^1] + "}");
}

void NegArray(int[] array1)
{
  for (int i = 0; i < array1.Length; i++)
  {
    array1[i] = -array1[i];
  }
}
