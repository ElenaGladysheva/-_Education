//вид 1. (Метод без входных и выходных данных)
/*
void Method1()
{
    Console.WriteLine("Автор...");
}
Method1();
*/
//вид 2. (На вход принимаем, а на выход переменных нет.)
/*
void Method2(string msg)
{
   Console.WriteLine(msg); 
}
 Method2("Текс");
*/
/*
 void Method21(string msg, int count)
{  
    int i = 0;
    while(i < count)
    {
        Console.WriteLine(msg);
        i++;
    }  
}
Method21(count: 4, msg: "Текст");
*/


//Вид 3. (Ничего не принимают, возвращают переменную.)
/*
int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);
*/


//Вид 4. (Есть переменные и на вход и навыход)
/*
string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
*/


// Цикл for
/*
string Method41(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;

}

 string res = Method41(10, "z");
 Console.WriteLine(res);
 */


 //Цикл в цикле

for (int i = 2; i <=10; i++)
{
    for (int j = 2; j <=10; j++)
    {
        Console.WriteLine($"{i}x{j} = {i*j}");
    }
    Console.WriteLine();
}
   








