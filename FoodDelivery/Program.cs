class FoodDelivery
{
    public static void Main(string[] args)
    {
        int chickenCount = int.Parse(Console.ReadLine());
        int fishCount = int.Parse(Console.ReadLine());
        int vegetarianCount = int.Parse(Console.ReadLine());
        
        double chickenMenuPrice=10.35;

        double fishMenuPrice=12.40;

        double vegetarianMenuPrice = 8.15;

        double delivery = 2.50;

        double bill = chickenCount * chickenMenuPrice + fishCount * fishMenuPrice +
                      vegetarianCount * vegetarianMenuPrice;
        double dessert =  bill * 0.20;

        double totalAmount = bill + dessert+delivery;
        
        Console.WriteLine(totalAmount);
    }
    }