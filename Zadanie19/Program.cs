
Console.WriteLine("Ведите пятизначное число: ");
string? num = Console.ReadLine();

string Shifter(string number)
{
    char[] numberArray = number.ToCharArray();
    Array.Reverse(numberArray);
    return new string(numberArray);
}

bool LetterInNumbers(string let)
{
    int n = let.Length;
    bool yes = true;
    if (n == 5)
    {
        for (int i = 0; i < n; i++)
        {
            // if (Char.IsLetter(let[i]) == true || Char.IsSymbol(let[i]) == true)
            if (Char.IsDigit(let[i]) == false)
            {
                yes = false;
                return yes;
            }
        }
        return yes;
    }
    else
    {
        yes = false;
        return yes;
    }
}

bool letter = LetterInNumbers(num!);
string shifter = Shifter(num!);

if (letter == true)
{
    if (shifter == num) 
        Console.WriteLine($"{num} является палиндромом? -> Да!");
    else Console.WriteLine($"{num} является палиндромом? -> Нет!");
}
else Console.WriteLine($"{num} -> Некорректный ввод!" +
    "\nНеобходимо ввести пятизначное число в диапазоне от 10000 до 99999" +
    "\nНапример: 12321 ");