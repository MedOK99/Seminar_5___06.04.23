// Задача 33: Задайте массив. Напишите программу, которая 
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

/*
Console.Clear();

int[] array = { 6, 7, 19, 345, 3};

int n = array.Length;

int find = 6;

int index = 0;

while(index < n)
{
  if(array[index] == find)
  {
    Console.WriteLine($"В массиве {array} число {find} присутствует");
    break;
  }
  else
  Console.WriteLine($"В массиве число {find} отсутствует");
  break;
  index++; // index = index +1;
}
*/

int[] array = {6, 7, 19, 345, 3};
PrintArray(array);
Console.WriteLine("Введите число, которое надо найти");
int number = ReadNumberFromConsole();
bool result = FindNumberInArray(array, number);
if (result == true)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
 
bool FindNumberInArray(int[] array, int numberToSearch)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == numberToSearch)
        {
            return true;
        }
    }
    return false;
}
 
void PrintArray(int[] array)
{
    Console.Write("{");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]},");
    }
    Console.WriteLine(array[^1] + "}");
}
 
int ReadNumberFromConsole()
{
    string input = Console.ReadLine();
    return int.Parse(input);
}