int MuxFun (int arg1, int arg2, int arg3)
{   
    Console.Clear();
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
    
}

int a1 = 54;
int b1 = 4;
int c1 = 89;
int a2 = 56;
int b2 = 1111;
int c2 = 10000;
int a3 = 0;
int b3 = -102;
int c3 = 29;

// int max1 = MuxFun(a1,b1,c1);
// int max2 = MuxFun(a2,b2,c2);
// int max3 = MuxFun(a3,b3,c3);
// int max = MuxFun (max1, max2, max3);

int max = MuxFun (MuxFun(a1,b1,c1),
                  MuxFun(a2,b2,c2), 
                  MuxFun(a3,b3,c3));

Console.WriteLine(max);

