﻿int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}

int a1 = 15;
int b1 = 21;
int c1 = 34;
int a2 = 14;
int b2 = 31;
int c2 = 81;
int a3 = 17;
int b3 = 24;
int c3 = 14;

int max =   Max(
                Max(a1, b1, c1),
                Max(a2, b2, c2), 
                Max(a3, b3, c3)
            );


Console.WriteLine(max);

