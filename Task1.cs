Console.WriteLine("Enter a number");
int num = int.Parse(Console.ReadLine());
bool isPowerOfTwo = true;

if (num <= 0)
{
    isPowerOfTwo = false;
}
else
{
    while (num > 1)
    {
        if (num % 2 != 0)
        {
            isPowerOfTwo = false;
            break;
        }
        num /= 2;
    }
}

Console.WriteLine(isPowerOfTwo);
