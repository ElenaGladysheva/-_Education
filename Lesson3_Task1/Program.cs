// задача 1. В тексте нужно все пробелы заменить черточками,
//           маленькие буквы 'к' заменить на большие "K", а большие 
//           'C' заменить на 'c'.

string text = "– Я думаю, – сказал князь, улыбаясь,"
             +" – что, ежели бы вас послали вместо нашего милого Винценгероде,"
             +"  вы бы взяли приступом согласие прусского короля."
             +"  Вы так красноречивы. Вы дадите мне чаю?";
//string s = "qwerty"
//            012
//s[0] = q

string Replase(string text, char oldValue, char newValue)
{
    string result = String.Empty; //инициализация пустой строки
    int lenght = text.Length;

    for (int i = 0; i < lenght; i++)
    {
        if(text[i] == oldValue)
            result = result + $"{newValue}";
        else
            result = result + $"{text[i]}"; // добавление текущего символа
    } 
    return result;
}

string newText = Replase(text,' ','|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replase(text, 'к','К');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replase(text, 'С','с');
Console.WriteLine(newText);
Console.WriteLine();