string[] ArrayString (int size)
{
    string[] arrayString = new string[size]; 
    
    
    for(int i = 0; i < size; i++)
    {
     
     arrayString[i] = Convert.ToString(Console.ReadLine());
     
    }
    return arrayString;
}
