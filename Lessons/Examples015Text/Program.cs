
string text = "Лицом к лицу"
            + "Лица не увидать."
            + "Большое видится на расстоянье."
            + "Когда кипит морская гладь —"
            + "Корабль в плачевном состоянье.";

string rep(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for(int i =0; i< length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";   
    
    }
    
    return result;
}
string newText = rep(text, ' ' , '|');
Console.WriteLine(newText);
