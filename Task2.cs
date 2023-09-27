Console.WriteLine("Enter a number");
int N = int.Parse(Console.ReadLine());
Console.WriteLine("Enter a digit");
int digit = int.Parse(Console.ReadLine());

int onluq;
int teklik;
int count = 0;

for (int i = 1; i <= N; i++)
{
    if (i > 9)
    {
        onluq = i / 10;
        teklik = i % 10;
    }
    else
    {
        onluq = 0;
        teklik = i;
    }

    if (onluq == digit || teklik == digit)
    {
        count++;
    }
}

Console.WriteLine(count);
