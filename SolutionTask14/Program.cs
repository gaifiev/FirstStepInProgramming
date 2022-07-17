// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// Например: 14 - НЕТ
// 46 - НЕТ
// 161 - Да

string reminderSearcher(string? str)
{
    if (str != null)
    {
        try
        {
            string answer;
            int num = int.Parse(str);
            if (((num % 7) == 0) && ((num % 23) == 0))
            {
                answer = "It's multiple for 7 and 23";
            }
            else
            {
                answer = "It's not multiple for 7 and 23";
            }
            return answer;
        }
        catch (Exception e)
        {
            return "Возникло исключение: " + e.Message;
        }
    }
    return "";
}
Console.WriteLine("Input number: ");
string? inputOne = Console.ReadLine();
Console.WriteLine(reminderSearcher(inputOne));