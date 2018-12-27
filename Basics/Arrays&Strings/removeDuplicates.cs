char[] removeDuplicates(char[] str)
{
    int length=str.Length;

    if (length == 0)
        return str;

    if (length < 2)
        return str;

    bool [] hit= new bool[256];
    int i;

    int pos=0;

    for(i=0;i<length;i++)
    {
        if(!hit[str[i]])
        {
            str[pos]=str[i];
            hit[str[i]]=true;
            pos++;
        }
    }

    return str;
}
