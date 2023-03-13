using System;
class Program{
    static void Main(string[] args) {
        int order;
        int dow =0;
        int tod =0;
        int weekendset =2;
        int breakfastset =5;
        int coffee =0;

        while (true) {
        Console.Write("Order Day of week 1-7! : ");
        dow = int.Parse(Console.ReadLine());
        Console.Write("Order Time of Day 8-18 : ");
        tod = int.Parse(Console.ReadLine());
        Console.WriteLine("Select the order ");
        Console.Write("Order Time of Day 8-18 : ");
        if(order == "END") {
            Console.WriteLine("Thank you for purchase");
            break;
        }
        switch(order)
        {
            
            case "Breakfast Set":
            if(tod > 11){
                Console.WriteLine("Sorry your order is not available");
                break;
                
            }
            if(breakfastset== 0) {
                Console.WriteLine("Sorry your order is out of stock");
                break;
            }
            breakfastset--;
            Console.WriteLine("Your order will get soon");
            break;
            
            case "Weekend Set":
            if(dow <=5){
                Console.WriteLine("Sorry your order is not available");
                break;
            }
            if(weekendset==0){
                Console.WriteLine("Sorry your order is out of stock");
                break;
            }
            weekendset--;
            Console.WriteLine("Your order is success please grab your food");
            break;
            
            case "Coffee":
            if(coffee==0);{
                Console.WriteLine("Sorry your order is out of stock");
                break;
            }
            coffee--;
            Console.WriteLine("Your order is success please grab your coffee");
            break;

            default:
            Console.WriteLine("Please enter a valid menu");
            break;
        }
}
}
}