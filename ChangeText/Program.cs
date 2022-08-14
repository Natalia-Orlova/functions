//Дан текст. Необходимо заменить все пробелы черточками, 
//меленькие "к" заменить большими "К", 
//большие "С" заменить на маленькие "с".

string text = "Буквы разные писать "
            + "тонким перышком в тетрадь "
            + "учат в школе, учат в школе, учат в школе";

string Replace (string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i]==oldValue) result = result + newValue;
        else result = result + text[i];
    }
    return result;
}
string newText = Replace(text,' ','|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(text,'к','К');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(text,'е','Е');
Console.WriteLine(newText);