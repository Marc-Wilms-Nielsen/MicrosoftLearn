Random random = new Random();
int daysUntilExpiration = random.Next(10);
int discountPercentage = 0;

if (daysUntilExpiration <= 10 && daysUntilExpiration >= 6)
{
    Console.WriteLine($"Your subscription will expire soon. Renew now! {daysUntilExpiration}");
}
else if (daysUntilExpiration <= 5 && daysUntilExpiration >= 2)
{
    discountPercentage = 10;
    Console.WriteLine($"Your subscribtion exspires in {daysUntilExpiration} days.\n Renew now and save {discountPercentage}%");
}
else if (daysUntilExpiration == 1) 
{
    discountPercentage = 20;
    Console.WriteLine($"Your subscribtion exspires in {daysUntilExpiration} days.\n Renew now and save {discountPercentage}%");
}
