string userChoice = "";
while (userChoice.ToLower() != "y" && userChoice.ToLower() != "n")
{
    Console.Write("Строку желаете вводить в ручную? (y/n):  ");
    userChoice = Console.ReadLine();
}
string [] array = new string[]{};
if (userChoice.ToLower() == "y")
{
    Console.Write("Введите кол-во элементов массива: ");
    int n = int.Parse(Console.ReadLine());
    array = new string [n];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i+1} элемент массива: ");
        array[i] = Console.ReadLine();
        
    }
}
else
{
    array = new string[] {"hello", "2", "world", ":-)"};
}
Console.WriteLine("Заданный массив: ");
PrintArray(array);
int lenghtMax = 3;
int index = CheckArray(array, lenghtMax);
string [] newArray = new string[index];
FillNewArray(array, newArray, lenghtMax);
Console.WriteLine("Массив длинна которого < либо =3 символам: ");
PrintArray(newArray);

int CheckArray(string[] array, int lenghtMax)
{
  int result = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i].Length <= lenghtMax) result++;
  }
  return result;
}

void FillNewArray(string[] firstArray, string[] newtArray, int lenghtMax)
{
    int res = 0;
     for (int i = 0; i < firstArray.Length; i++)
     {
        if (firstArray[i].Length <= lenghtMax)
        {
         newArray[res] = firstArray[i];
         res++;
        }
     }
}

void PrintArray (string [] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + ",");
    }
    Console.Write("]");
    Console.WriteLine();
}
