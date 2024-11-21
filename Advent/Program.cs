// See https://aka.ms/new-console-template for more information

using System.Diagnostics.CodeAnalysis;
using System.Runtime.ExceptionServices;
using System.Runtime.Serialization;

string[] lines = File.ReadAllLines("input.txt");
int[][] m= new int[600][];
for (int i = 0; i < 600; i++)
{
    m[i] = new int[600];
}

for (int i = 0; i < 600; i++)
{
    for (int j = 0; j < 600; j++)
    {
        m[i][j] = 0;
    }
}

int ci = 300;
int cj = 300;
m[ci][cj] = 1;
const int nr = 361527;
while (true)
{
    //dreapta
    while (true)
    {
        cj++;
        m[ci][cj] = vecini(m, ci, cj);
        if (m[ci][cj] > nr)
        {
            Console.WriteLine(m[ci][cj]);
            ci = 1;
            cj = 1;
        }

        if (m[ci - 1][cj] == 0) break;
    }
    //sus
    while(true){
        ci--;
        m[ci][cj] = vecini(m, ci, cj);
        
        if (m[ci][cj] > nr)
        {
            Console.WriteLine(m[ci][cj]);
            ci = 1;
            cj = 1;
        }
        if (m[ci][cj - 1] == 0) break;
    }
    //stg
    while (true)
    {
        cj--;
        m[ci][cj] = vecini(m, ci, cj);
      
        if (m[ci][cj] > nr)
        {
            Console.WriteLine(m[ci][cj]);
            ci = 1;
            cj = 1;
        }
        if (m[ci + 1][cj] == 0) break;
    }
    //jos
    while (true)
    {
        ci++;
        m[ci][cj] = vecini(m, ci, cj);
        
        if (m[ci][cj] > nr)
        {
            Console.WriteLine(m[ci][cj]);
            ci = 1;
            cj = 1;
        }
        if (m[ci][cj + 1] == 0) break;
    }

    if (ci == 0 && cj == 0)
        break;
}


int vecini(int[][] m, int i, int j)
{
    var s = 0;
    s += m[i + 1][j + 1] + m[i + 1][j] + m[i + 1][j - 1] + m[i][j - 1] + m[i][j + 1] + m[i - 1][j - 1] + m[i - 1][j] +
         m[i - 1][j + 1];
    return s;
}



int s = 0;

//if (charArr[0] == charArr[charArr.Length - 1])
//    s += Convert.ToInt32(charArr[0]-'0');
Console.WriteLine(Math.Sqrt(361527));