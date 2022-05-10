string[] inputArr1 = { "hello", "2", "world", ":-)" };
string[] inputArr2 = { "1234", "1567", "-2", "computer science" };
string[] inputArr3 = { "Russia", "Denmark", "Kazan" };
string[] inputArr4 = { "" };

string[] inputArr = inputArr4;
System.Console.WriteLine("[" + String.Join(", ", BuildOutArr(GetInfo(inputArr), inputArr)) + "]");

info GetInfo(string[] inpArr)
{
    int len = inpArr.Length;
    info infoInputArr = new info(len);
    for (int i = 0; i < len; i++)
    {
        if (inpArr[i].Length <= 3)
            {
                infoInputArr.infoArr[i] = 1;
                infoInputArr.count += 1;
            }
        else
            infoInputArr.infoArr[i] = 0;
    }
    return infoInputArr;
}

string[] BuildOutArr(info inf, string[] inpArr)
{
    int len = inpArr.Length;
    string[] outArr = new string[inf.count];
    for (int i = 0, j = 0; i < len; i++)
    {
        if (inf.infoArr[i] == 1)
        {
            outArr[j] = inpArr[i];
            j += 1;
        }
    }
    return outArr;
}

struct info //Структура для хранения информации о входном массиве
{
    public int[] infoArr;
    public int count;

    public info(int length)
    {
        this.infoArr = new int[length];
        this.count = 0;
    }
}
