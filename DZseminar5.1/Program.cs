



int[] myArray = new int[4];
Random rand = new Random();
Console.Write ("[");
int res = 0;
    for (int i = 0; i < myArray.Length; i++)
{   myArray[i] = rand.Next(999);
        if (myArray[i] % 2 == 0) res++;
    
        Console.Write( myArray [i] +(i < myArray.Length -1? "," : ""));
}           
Console.Write("]"+"->"+ res);

