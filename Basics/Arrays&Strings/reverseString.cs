//iterative
char[] reverse(char[] str)
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


static void Main(string[] args)
{
    Program obj = new Program();

    char[] str = new char[]
    {
                'k', 's', 'h', 'i', 't', 'i', 'j'
    };

    Console.WriteLine(obj.reverse(str));
    Console.ReadLine();
}

////////////////////////////////////////////////////////////////////
//Recursive
string reverse(string str)
{
    if (str.Length < 2)
        return str;

    return reverse(str.Substring(1)) + str[0];
}
