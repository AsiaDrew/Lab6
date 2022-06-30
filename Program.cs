
//Dictionary
Dictionary<string, double> menuItems = new Dictionary<string, double>();
menuItems.Add("hot cheetos", 1.69);
menuItems.Add("slushee", 1.39);
menuItems.Add("coca cola", 2.49);
menuItems.Add("gummy bears", 2.09);
menuItems.Add("queso dip", 3.49);
menuItems.Add("diapers", 10.99);
menuItems.Add("cigarettes", 9.09);
menuItems.Add("bic lighters", 4.69);
//list
List<string> shoppingList = new();
double total = 0;
Console.WriteLine("Welcome to Farmer Jack Gas Station!");
Console.WriteLine();
Console.WriteLine("Item\t \tPrice");
Console.WriteLine("======================");
foreach (KeyValuePair<string, double> kvp in menuItems)
{
    Console.WriteLine($"{kvp.Key}:\t${kvp.Value}");
}

bool orderItems = true;
while (orderItems == true)
{
    Console.WriteLine();
    Console.Write("What item do u want to order?  ");

    while (true)
    {
        string orderedItems = Console.ReadLine();
        // menuItems.ContainsKey(orderedItems);
        if (menuItems.ContainsKey(orderedItems))
        {
            shoppingList.Add(orderedItems);
            break;
        }
        else
        {
            Console.WriteLine("Item\t \tPrice");
            Console.WriteLine("======================");
            foreach (KeyValuePair<string, double> kvp in menuItems)
            {
                Console.WriteLine($"{kvp.Key}:\t${kvp.Value}");
            }
            Console.WriteLine("Out of stock... try again");
        }
    }

    while (true)
    {
        Console.WriteLine("Do you want to add another item to your cart? y/n");
      //  Console.WriteLine();
        string choice = Console.ReadLine();
        if (choice == "y")
        {
            break;
        }
        else if (choice == "n")
        {
            orderItems = false;
            break;
        }
        else
        {
            Console.WriteLine("Invalid, enter y or n");
        }

    }
}
double maxPrice = 0;
double minPrice = 9999;
string maxName = "";
string minName = "";
Console.WriteLine();
    Console.WriteLine($"Thank you for shopping with us today. \nYou ordered:");
foreach (string item in shoppingList)
{
    Console.WriteLine($"{item}\t${menuItems[item]}");
     total += menuItems[item];
    if (menuItems[item] < minPrice)
    {
        minPrice = menuItems[item];
        minName = item;
    }
    if (menuItems[item] > maxPrice)
    {
        maxPrice = menuItems[item];
        maxName = item;
    }
}
Console.WriteLine($"Your total is: ${total}.  \n\nYour most expensive item was {maxName} and cost ${maxPrice}. \nYour least expensive item was {minName} and cost ${minPrice}. \nSee u next time!");


//List<string> orderedItems = new List<string>();
//List<string> uniqueItems = orderedItems.Distinct().ToList();
//foreach (string item in uniqueItems)
//{
//    int quantity = orderedItems.Where(name => name == item).Count();
//    Console.WriteLine(item + " X " + quantity + "  $" + quantity * dictionary[item]);
//}
