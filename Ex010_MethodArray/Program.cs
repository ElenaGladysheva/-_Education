
Console.Clear();

int[] array = {1,55,44,2,99,45,99,56};
int n = array.Length;
int index = 0;
int find = 99;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break; 
    }
    index++;
}
