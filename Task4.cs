Console.WriteLine("Enter a decimal number:");
int dec = int.Parse(Console.ReadLine());

convert(dec);

string convert(int dec)
{
    if (dec == 0)
    {
        Console.WriteLine(0);
    }
    
    string bin = "";
    
    while (dec > 0)
    {
        int remainder = dec % 2;
        bin = remainder + bin;
        dec /= 2;
    }
    
    Console.WriteLine(bin);
}
