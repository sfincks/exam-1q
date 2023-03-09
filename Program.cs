// Программа должна сортировать массив, оставляя только элементы в которых не более 3-х символов

// string[] array = { "я", "так", "хочу", "Чтобы", "лето", "не", "кончалось", "Чтоб", "оно", "за", "мною", "мчалось", "За", "мною", "вслед" };
// { "я", "так", "не", "оно", "за",  "За"}
string[] array = { "Это", "вам", "не", "это", "Обязательно", "бахнем", "И", "не", "раз", "Весь", "мир", "в", "труху", "Но", "потом" };
string[] newArr = shortenArray(array, 3);
System.Console.WriteLine("[" + string.Join(", ", newArr) + "]");

string[] shortenArray(string[] array, int maxSymbol)
{
    int arrleng = 0;
    for (int i = 0; i < array.Length - 1; i++)
    {
        if (array[i].Length <= maxSymbol)
        {
            arrleng++;
        }

    }
    string[] array2 = new string[arrleng];
    int count = 0;
    for (int i = 0; i < array.Length - 1; i++)
    {
        if (array[i].Length <= maxSymbol)
        {
            array2[count] = array[i];
            count++;
        }
    }
    return array2;
}


