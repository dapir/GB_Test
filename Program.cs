void PrintArray(string[] args)
{

    for (int i = 0; i < args.Length; i++)
    {
        if (args[i].Length <= 3)
        {
            Console.Write(args[i] + " ");
        }
    }
}

string[] firstStr = { "machine", "two", "kdfj", "546", "-35", "ok", "note" };
for (int j = 0; j < firstStr.Length; j++)
{
    Console.Write(firstStr[j] + " ");
}
Console.WriteLine();
string[] secondStr = { };
secondStr = firstStr;
PrintArray(secondStr);