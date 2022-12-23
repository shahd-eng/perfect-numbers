// See https://aka.ms/new-console-template for more information
Console.WriteLine("Please enter The Begning : ");

 int firstnum = int.Parse(Console.ReadLine());

Console.WriteLine("please enter the End: ");

int secondnum = int.Parse(Console.ReadLine());

Console.WriteLine("The Perfect numbers within the given range : ");

for (int j = firstnum; j <= secondnum; j++)
{
   int i = 1;
   int sum = 0;
    while (i < j)
    {
        if (j % i == 0)
            sum = sum + i;
        i++;
    }
    if (sum == j)
        Console.WriteLine("{0} ", j);
}
Console.WriteLine("  ");