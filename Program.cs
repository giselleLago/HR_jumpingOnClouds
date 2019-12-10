using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{

    // Complete the jumpingOnClouds function below.
    static int jumpingOnClouds(int[] c, int k)
    {
        var e = 100;
        int i = 0;
        while (i < c.Length)
        {
            if (c[i] == 0)
            {
                e = e - 1;
                i = i + k;
            }
            else
            {
                e = e - 1 - k;
                i = i + k;
            }
                
        }
        return e;

    }

    static void Main(string[] args)
    {

        string[] nk = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nk[0]);

        int k = Convert.ToInt32(nk[1]);

        int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp))
        ;
        int result = jumpingOnClouds(c, k);

        Console.WriteLine(result);
        Console.ReadKey();

    }
}
