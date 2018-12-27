bool isPalindrome(int num)
{
    int result = 0;
    int temp = 0;
    int orgNum = num;

    while (num != 0)
    {
        result = result * 10;
        temp = num % 10;
        result = result + temp;
        num = num / 10;
    }

    if (orgNum == result)
        return true;

    return false;
}
