// See https://aka.ms/new-console-template for more information

using System.Diagnostics.CodeAnalysis;
using System.Runtime.ExceptionServices;

string[] lines = File.ReadAllLines("input.txt");

int s= 0;
for (int i = 0; i < lines.Length; i++)
{
    var cont = lines[i].Split('\t');
    int[] valueArray = new int[cont.Length];
    for (int j = 0; j < cont.Length; j++)
    {
        valueArray[j] = Int32.Parse(cont[j]);
    }

  
    for (int j = 0; j < cont.Length; j++)
    {
        for (int k = 0; k < cont.Length; k++)
        {
            if (valueArray[j] % valueArray[k] == 0 && j != k)
                s += valueArray[j] / valueArray[k];
        }
    }

}

//if (charArr[0] == charArr[charArr.Length - 1])
//    s += Convert.ToInt32(charArr[0]-'0');
Console.WriteLine(s);