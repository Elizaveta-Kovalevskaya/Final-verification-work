string[] ArrayString (int size)
{
    string[] arrayString = new string[size]; 
    
    
    for(int i = 0; i < size; i++)
    {
     
     arrayString[i] = Convert.ToString(Console.ReadLine());
     
    }
    return arrayString;
}

void ShowArray(string[] arrayString)
{
    Console.Write("[ ");
    for(int i = 0; i < arrayString.Length; i++)
    {
      Console.Write(arrayString[i] + " ");
    }
    Console.Write("]");    
}

void ArrString(string[] arrayString, int size)
{ 
  Console.Write("[");
  for (int i = 0; i < size; i++)
  {
      if (arrayString[i].Length <= 3)
      {
       Console.Write(arrayString[i] + " ");
      }
    
  }
  Console.Write("]");
}

Console.Write("Input a array size: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a array string: ");

string[] MyArray = ArrayString(m);
ShowArray(MyArray);
Console.WriteLine();
Console.WriteLine();
ArrString(MyArray, m);