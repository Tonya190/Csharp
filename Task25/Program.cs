/*
Задайте произвольную строку. Выясните, является ли она палиндромом.
*/
string line = "love";
bool result = IsPalindrom(line);
System.Console.WriteLine(result ? "Да":"Нет");
bool IsPalindrom(string line)
{
    string str = new string(line.Where(char.IsLetterOrDigit).ToArray()).ToLower();
    return str.SequenceEqual(str.Reverse());
}