﻿void FillArray(int[] collection)
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(0,10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(col[position]+" ");
        position++;
    }

}

int IndexOff (int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while( index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }

        index++;
    }
        
    return position;
                
}

 
int[] array = new int[10];

FillArray(array);
PrintArray(array);
Console.WriteLine();

Console.WriteLine(IndexOff(array,4));





