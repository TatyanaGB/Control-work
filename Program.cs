string[] myArray = new string[] { "hello", "2", "world",  ":-)" };
string[] myTwoArray = new string[myArray.Length];
CharsArray(myArray, myTwoArray);
PrintArray(myTwoArray);

void CharsArray(string[] myArray, string[] myTwoArray)
 {
    int count = 0;
    for (int i = 0; i < myArray.Length; i++)
    {
      if (myArray[i].Length <= 3)
      {
        myTwoArray[count] = myArray[i];
        count++;
      }  
    }   
  }    

void PrintArray(string[] myArray)
{
    for (int i = 0; i < myArray.Length; i++)
    {
        Console.Write($"{myArray[i]} ");
    }
    Console.WriteLine();
}
