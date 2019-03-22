
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

//reverse an integer (with overflow check)
int reverse(int num)
{
    int result = 0;

    while (num != 0)
    {
        int tail = num % 10;
        int newResult = result * 10 + tail;

        //check for overflow
        if ((newResult - tail) / 10 != result)
            return 0;

        result = newResult;

        //reduce the number
        num = num / 10;
    }

    return result;
}

static void Main(string[] args)
{
    Program obj = new Program();
    Console.WriteLine(obj.IsPalindrome(145));

    Console.ReadLine();
}
    