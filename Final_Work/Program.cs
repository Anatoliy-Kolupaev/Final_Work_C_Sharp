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
PrintArray(array);
int lenghtMax = 3;
string [] newArray = new string[] {} ;
string [] result = FillNewArray(array, newArray, lenghtMax);
PrintArray(result);
string [] FillNewArray(string[] firstArray, string[] newtArray,int lengthLimit)
{
    int temp = 0;
     for (int i = 0; i < firstArray.Length; i++)
     {
        if (firstArray[i].Length <= lengthLimit)
        
         newArray[temp] = firstArray[i];
        temp++;
     }
     return newArray;
}

void PrintArray (string [] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + ",");
    }
    Console.Write(array[array.Length-1] + "]");
    Console.WriteLine();
}
