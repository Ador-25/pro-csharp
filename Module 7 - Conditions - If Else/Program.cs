static void GetRule(int days,out int discount)
{

    if(days == 0)
    { 
        discount = 0;
        Console.WriteLine("Your subscription has expired.");
    }
    else if(days == 1)
    {
        discount = 20;
        Console.WriteLine($"Your subscription expires within a day!\nRenew now and save {discount}%!");
    }
    else if(days >1 && days<=5) 
    {
        discount = 10;
        Console.WriteLine($"Your subscription expires in {days} days.\nRenew now and save {discount}%!");
    }
    else if (days > 5 && days <= 10)
    {
        discount = 0;
        Console.WriteLine("Your subscription will expire soon. Renew now!");
    }
    else
    {
        discount = 0;
    }

}


Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

// Your code goes here

Console.WriteLine($"Exp: {daysUntilExpiration}");
GetRule(daysUntilExpiration, out discountPercentage);
Console.WriteLine(discountPercentage);