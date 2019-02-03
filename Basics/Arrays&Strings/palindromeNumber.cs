
bool IsPalindrome(int num)
{
    int result = 0;
    int orgNum = num;

    while (num != 0)
    {
        result = result * 10 + num % 10;
        num = num / 10;
    }

    if (orgNum == result)
        return true;

    return false;
}

static void Main(string[] args)
{
    Program obj = new Program();
    Console.WriteLine(obj.IsPalindrome(145));

    Console.ReadLine();
}
    