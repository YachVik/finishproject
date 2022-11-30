using System;    
using System.IO;

    int N=5;/*длина массива*/
    string [] A={"213","ed","dfdfdfd","","jjjjj","jkjkjk"};
    string [] B=new string[N];

    int  j = 0;

    for(int i=0; i<=N; i++)
    {
        if(A[i].Length<=3)
        {
            B[j]=A[i];
            j++;
        }
        
    }
    for(int i=0; i<=j; i++)
        Console.Write($"{B[i]} ");
 
