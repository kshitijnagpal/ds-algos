public bool RotateString(string A, string B)
{
    int len = A.Length;

    if (len == B.Length && len > 0)
    {
        string AA = A + A;
        return AA.Contains(B);
    }

    return false;
}
