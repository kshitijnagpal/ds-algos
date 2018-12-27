bool isPalindrome(string s)
{
    int start = 0;
    int end = s.Length - 1;
    int middle = (start + end) / 2;

    while (start < middle)
    {
        if (s[start++] != s[end--])
        {
            return false;
        }
    }

    if (start == middle)
        return true;

    return false;
}
