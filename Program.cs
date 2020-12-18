using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var WeeklyMenu = new Dictionary<String, dynamic>();
            WeeklyMenu["Monday"] = new { starter = "Goat Cheese Salad", soup = "Goose Bouillon", maincourse = "Wild Boar Stew", dessert = "Dobos Torte", beverage = "Tea, Natural Apple Juice, Wines" };
            WeeklyMenu["Tuesday"] = new { starter = "Passage Pastrami Baguette", soup = "Paloc Soup", maincourse = "Shrimps", dessert = "Tokaji Cake", beverage = "Tea, Natural Cranberry Juice, Wines" };
            WeeklyMenu["Wednesday"] = new { starter = "Beef Tartar", soup = "Goulash Soup", maincourse = "Pörkölt and Paprikás", dessert = "Somlói Galuska", beverage = "Tea, Natural Orange Juice, Wines" };
            WeeklyMenu["Thursday"] = new { starter = "French Cheese Plate", soup = "French Onion Soup", maincourse = "Bresse Chicken", dessert = "Opera Slice", beverage = "Tea, Natural Vegetable Juice, Wines" };
            WeeklyMenu["Friday"] = new { starter = "Párisi Chicken Salad", soup = "Beef Stew", maincourse = "Cauliflower Bolognese", dessert = "Somloi Trifle", beverage = "Tea, Natural Watermelon Juice, Wines" };
            WeeklyMenu["Saturday"] = new { starter = "Ceasar Salad", soup = "Green Chicken Chili Soup", maincourse = "Grand Aioli", dessert = "Palacsinta", beverage = "Tea, Natural Peach Juice, Wines" };
            WeeklyMenu["Sunday"] = new { starter = "Baked Spring Rolls", soup = "Bajai Fish Soup", maincourse = "Wiener Schnitzel", dessert = "Chak-Chak", beverage = "Tea, Natural Pineapple Juice, Wines" };

           
            DateTime time1 = new DateTime(2020, 12, 18, 13, 30, 00);
            DateTime time2 = new DateTime(2020, 12, 18, 15, 00, 00);
            DateTime time3 = new DateTime(2020, 12, 19, 15, 30, 00);
            DateTime time4 = new DateTime(2020, 12, 19, 17, 00, 00);
            var reserved = new Dictionary<int, dynamic>();
            reserved[1] = new { table = "Table1", time = time1, person = "Albert", guestsnum = 5 };
            reserved[2] = new { table = "Table3", time = time2, person = "Zoltan", guestsnum = 3 };
            reserved[3] = new { table = "Table4", time = time3, person = "Szabina", guestsnum = 6 };
            reserved[4] = new { table = "Table2", time = time4, person = "Adam", guestsnum = 2 };

           
            Console.WriteLine("\nHello, Dear Customer! Welcome to 'Puzzles' Restaurant. To start the reservation process, please, enter your name.");
            var user = Console.ReadLine();


            Console.Write("Please, enter desired date and time in the following format, to see tables availability. \nRestaurant closes at 19:00 due to curfew introduced by Hungarian Government, therefore latest reservation time is 17:00  \nFormat:  DD/MM/YYYY H:MM PM/AM \n");
            DateTime reservationdate = DateTime.Parse(Console.ReadLine());
          
            var Tables = new List<string>()
            {"Table1","Table2","Table3","Table4"};
            
            foreach (var item in reserved.Keys)
            {
                
                var value = reserved[item].time;
                if (DateTime.Compare(reservationdate.Date, value.Date) == 0)
                {
                    Tables.Remove(reserved[item].table);
                }
            }
            if (Tables.Count != 0)
            {
                Console.WriteLine("\nThe following tables are available:");
                Tables.ForEach(i => Console.WriteLine("{0}\t", i));
                Console.WriteLine("\nDo you want to make a reservation?");
                var answer = Console.ReadLine();
                if ((answer == "yes") || (answer == "Yes") || (answer == "YES") || (answer == "y") || (answer == "Y")) 
                    {
                    Console.WriteLine("\nChoose table number from the list above (1/2/3/4)");
                    var tablechosen = Console.ReadLine();
                    if ((tablechosen == "1") || (tablechosen == "2") || (tablechosen == "3") || (tablechosen == "4"))
                    {
                        
                        var tabletoreserve = "Table" + tablechosen;
                        Console.WriteLine("\nChoose number of guests");
                        int gueststoreserve = int.Parse(Console.ReadLine());
                        int j = reserved.Keys.Max();
                        reserved[j + 1] = new { table = tabletoreserve, time = reservationdate, person = user, guestsnum = gueststoreserve };
                        Console.WriteLine($"\nDear {reserved[j + 1].person}, you reservation information is as follows: \nDate and Time: {reserved[j + 1].time}, {reserved[j + 1].time.DayOfWeek}  \nTable: {tablechosen} \nNumber of Guests {reserved[j + 1].guestsnum}. ");

                        Console.WriteLine($"\nMenu List for Your Reservation Day:  \nStarter: {WeeklyMenu[reserved[j + 1].time.DayOfWeek.ToString()].starter} \n \nSoup: {WeeklyMenu[reserved[j + 1].time.DayOfWeek.ToString()].soup} \n \nMain Course: {WeeklyMenu[reserved[j + 1].time.DayOfWeek.ToString()].maincourse}\n \nDessert: {WeeklyMenu[reserved[j + 1].time.DayOfWeek.ToString()].dessert}\n \nBeverages: {WeeklyMenu[reserved[j + 1].time.DayOfWeek.ToString()].beverage}\n \nThank you for your reservation! See you at our restaurant!");
                    }
                    else 
                    {
                        Console.WriteLine("\nSorry, invalid table, choose table again from the list above");
                        var tablechosen1 = Console.ReadLine();
                        var tabletoreserve1 = "Table" + tablechosen1;
                        Console.WriteLine("\nChoose number of guests");
                        int gueststoreserve = int.Parse(Console.ReadLine());
                        int j = reserved.Keys.Max();
                        reserved[j + 1] = new { table = tabletoreserve1, time = reservationdate, person = user, guestsnum = gueststoreserve };
                        Console.WriteLine($"\n Dear {reserved[j + 1].person}, you reservation information is as follows: \n Date and Time: {reserved[j + 1].time}, {reserved[j + 1].time.DayOfWeek}  \n Table: {tablechosen1} \n Number of Guests {reserved[j + 1].guestsnum}. ");

                        Console.WriteLine($"\nMenu List for Your Reservation Day:  \nStarter: {WeeklyMenu[reserved[j + 1].time.DayOfWeek.ToString()].starter}\n \nSoup: {WeeklyMenu[reserved[j + 1].time.DayOfWeek.ToString()].soup}\n \nMain Course: {WeeklyMenu[reserved[j + 1].time.DayOfWeek.ToString()].maincourse}\n \nDessert: {WeeklyMenu[reserved[j + 1].time.DayOfWeek.ToString()].dessert}\n \nBeverages: {WeeklyMenu[reserved[j + 1].time.DayOfWeek.ToString()].beverage}\n \nThank you for your reservation! See you at our restaurant!");
                    }
                }
                else
                {
                    Console.Write("You are welcome anytime at our restaurant, thanks for choosing 'Puzzles', have a nice day!");
                }
            }
            
            
        }
    }
}
