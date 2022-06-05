Console.WriteLine("2 Hello, World!");
int[] array1 = new int[] { 1, 8, 3, 2, 6 };
int sizze = 5;
int CurrentIndex  = 0;
int MaxNumberIndex  = 0;
int MaxNumber  = array1[0];
while(CurrentIndex<sizze)
{
    if(array1[CurrentIndex]>MaxNumber) 
        {
            MaxNumber = array1[CurrentIndex];
        MaxNumberIndex = CurrentIndex;
        }
    CurrentIndex = CurrentIndex + 1;
}
    

Console.Write("Наибольшее число=");
Console.WriteLine(MaxNumber);
Console.Write("Индекс наибольшего числа=");
Console.WriteLine(MaxNumberIndex);