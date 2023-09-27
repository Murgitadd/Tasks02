Console.WriteLine("Enter a number");
int num = int.Parse(Console.ReadLine());
bool isPerfect = false;
int sum = 0;

for (int i = 1; i < num; i++)
{
    if (num % i == 0)
    {
        sum += i;
    }
}

if (sum == num)
{
    isPerfect = true;
}

Console.WriteLine(isPerfect);
