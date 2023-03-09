// Программа должна сортировать массив, оставляя только элементы в которых не более 3-х символов

// string[] array = { "я", "так", "хочу", "Чтобы", "лето", "не", "кончалось", "Чтоб", "оно", "за", "мною", "мчалось", "За", "мною", "вслед" };
// { "я", "так", "не", "оно", "за",  "За"}
// string[] array = { "Это", "вам", "не", "это", "Обязательно", "бахнем", "И", "не", "раз", "Весь", "мир", "в", "труху", "Но", "потом" };
// [Это вам не это И не раз мир в Но]
string[] array = getArray();
string[] newArr = shortenArray(array, 3);
System.Console.WriteLine("[" + string.Join(" ", newArr) + "]");

string[] shortenArray(string[] array, int maxSymbol)
{
    int arrleng = 0;
    for (int i = 0; i < array.Length ; i++)
    {
        if (array[i].Length <= maxSymbol)
        {
            arrleng++;
        }

    }
    string[] array2 = new string[arrleng];
    int count = 0;
    for (int i = 0; i < array.Length ; i++)
    {
        if (array[i].Length <= maxSymbol)
        {
            array2[count] = array[i];
            count++;
        }
    }
    return array2;
}

string[] getArray()
{
    System.Console.WriteLine("Введите количество строк");
    int Length = Convert.ToInt32(Console.ReadLine());
    string[] array = new string[Length];
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.WriteLine($"Введите строку №{i + 1}");
        array[i] = Console.ReadLine();
    }
    System.Console.WriteLine("Вы ввели следующие строки");
    System.Console.WriteLine("[" + string.Join(" ", array) + "]");
    return array;
}


