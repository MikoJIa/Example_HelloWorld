// Виды методов
// Вид метода 1
void Method1()
{
    Console.WriteLine("Автор ...");
}
Method1();









// Вид метода 2 методы которые ничего не возвращяют но могут принимать аргументы
void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method2(msg:"Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method21(msg:"Текст", count: 6);

// Вид метода 3 которые что то возвращяют но не принимают.
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
//Console.WriteLine(year);



//Вид метода 4 Которые что то принимаю и что то возвращяют.
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
string res = Method4(10, "asdf");
Console.WriteLine(res);