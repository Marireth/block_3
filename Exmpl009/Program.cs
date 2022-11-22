int Max(int arg1,int arg2,int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
 int []array = {8,0,72,156,4,74,15,89,23};

 int max = Max(
    Max(array[0], array[1], array[3]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8])
 );

Console.WriteLine(max);