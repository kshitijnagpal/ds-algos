char [] reverse(char[] str)
{
    int start = 0;
    int end = str.Length - 1;
    char temp;

    while (start < end)
    {
        temp = str[start];
        str[start] = str[end];
        str[end] = temp;

        start++;
        end--;
    }

    return str;
}

//Recursive
string reverse(string str)
{
    if (str.Length < 2)
        return str;

    return reverse(str.Substring(1)) + str[0];
}
