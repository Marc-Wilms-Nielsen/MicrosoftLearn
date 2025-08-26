

string[] totalOrders = {"B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"};



foreach (string order in totalOrders)

if (order.StartsWith("B"))
{
        Console.WriteLine(order);
}

