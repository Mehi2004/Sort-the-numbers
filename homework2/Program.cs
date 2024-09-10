// mul table with array and foreach

int[,] numbers = new int[10, 10];


int counter = 0;
int counter2 = 1;

int mul = 0;
foreach (int i in numbers)
{


    counter++;

    if (counter == 11)
    {
        counter = 1;
        counter2++;
        Console.WriteLine("");
    }
    mul = counter * counter2;
    Console.Write($"{mul}\t");
}





