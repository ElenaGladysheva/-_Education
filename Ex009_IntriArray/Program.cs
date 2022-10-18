int MuxFun (int arg1, int arg2, int arg3)
{   
    Console.Clear();
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
    
}

int[] array = { 11, 2256, 34, 41, 55, 64, 17, 228, 91 };

int max = MuxFun (
           MuxFun(array[0],array[1],array[2]),
           MuxFun(array[3],array[4],array[5]), 
           MuxFun(array[6],array[7],array[8]));

 Console.WriteLine(max);
