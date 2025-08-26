






string[] values = { "12,3", "45", "ABC", "11", "DEF" };

decimal outedDecimal = 0;
string message = "";
decimal total = 0;


foreach (string value in values)
{
    if (decimal.TryParse(value, out outedDecimal))
    {
        total += outedDecimal;
        Console.WriteLine($"Adding {outedDecimal}");
    }
    else
    {
        message += value;

    }
}
Console.WriteLine($"Total Measurement: {total}");
Console.WriteLine($"Non-numeric data: {message}");




