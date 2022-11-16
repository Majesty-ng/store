using System;
using System.Globalization;
using System.Windows;
using System.Runtime;
using System.Xml;
using System.Linq;
using store;

namespace Majesty
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Blue;


            //Console.Write("start Y/N: ");
            //String name = Console.ReadLine();
            //Console.Write("start Name: ");
            //String Route = Console.ReadLine();
            //Console.Write("start number: ");
            //int Budget = Convert.ToInt32( Console.ReadLine());


            //Console.WriteLine(No(2,10));
            //Console.Write("input name: ");
            //String name = Console.ReadLine();




            //Console.Write("input budget: ");
            //while (!int.TryParse(Console.ReadLine(), out bugdet))
            //    Console.WriteLine("input must be an integer: ");
            //Console.Write("hello user");

            //Console.ReadKey();

            //bool check;

            //Console.Write("input name: ");
            //String sentence = Console.ReadLine();
            //while (true)
            //{
            //    if (String.IsNullOrEmpty(sentence))
            //    {
            //        Console.Write("please dont leave it empty: ");
            //    }
            //    //else if(sentence.Split(' ').Length < 6)
            //    //{
            //    //    Console.Write("please enter at least six words: ");
            //    //}

            //    else break;
            //    sentence = Console.ReadLine();

            //}


            //declared the user variable and universal int
            bool check;
            int budget;
            String AI = "21 Savage";
            int universalbudget = 1000;
            String restart = "true";


            do
            {
                Console.Write("Enter your name: ");
                String username = Console.ReadLine();
                String verify = "false";
                try
                {
                    Convert.ToInt32(username);
                }
                catch
                {
                    verify = "true";
                }
                while(verify != "true"|| username=="")
                {
                    Console.WriteLine("oga invalid input, type in a string");
                    Console.Write("Enter your name again: ");
                    username = Console.ReadLine();
                    try
                    {
                        Convert.ToInt32(username);
                    }
                    catch
                    {
                        verify = "true";
                    }
                }
                //do while loop for correct int data type input of budget
                do
                {
                    Console.WriteLine($"hello {username} what is your tansportation budget");
                    Console.Write("Please enter a valid number:  ");
                    check = int.TryParse(Console.ReadLine(), out budget);

                }
                while (!check);

                //user prompts
                //user universal data prompts
                Console.WriteLine($"Hello ! user {username}\n" +
                    $"I am your guide and/ AI :{AI} ,for the day\n you are currently at shoprite");
                Console.WriteLine("////////////////////////////////////////////////////////////////////////////////////////////////////////");
                Console.WriteLine($"Your transport budget is {budget}");
                Console.WriteLine();
                Console.WriteLine("////////////////////////////////////////////////////////////////////////////////////////////////////////");
                Console.ReadKey();
                Console.WriteLine("which route would you love to take\n(1)New market\n(2)New layout\n(3)Holy ghost");
                Console.Write("choose your route: ");
                String route = Console.ReadLine();

                //if statements for routes
                if (route.ToLower() == "new market")
                {
                    Console.WriteLine("alright user\nWhat mode of transport would you prefer");
                    Console.WriteLine();
                    Console.WriteLine("Mininum required budget:\n(1)keke = 1000\n(2)bus = 700");
                    Console.WriteLine();
                    Console.Write("(1)Keke  or\n(2)Bus\n: ");
                    String modeoftransport = Console.ReadLine();

                    //if statement for modeof transport
                    if (modeoftransport.ToLower() == "keke")
                    {
                        //boolean for budget true and false
                        bool checkbudget = budget < universalbudget;


                        //if statement for checking if budget is greater than required budget
                        if (checkbudget == true)
                        {
                            int diffbudget = universalbudget - budget;
                            Console.WriteLine($"your budget is below the required amount needed to take this option\nyou require {diffbudget} to be able to " +
                                $"take this option");
                            Console.Write($"would you like to top up, Y/N: ");
                            String condition = Console.ReadLine();

                            //if statement for continuation of code
                            if (condition.ToLower() == "y")
                            {
                                Console.Write("please input your new budget: ");
                                int topup = Convert.ToInt32(Console.ReadLine());

                                //do while loop for checking if topup is greater than required required budget
                                do
                                {
                                    Console.Write("budget was lower than expected try again: ");
                                    topup = Convert.ToInt32(Console.ReadLine());

                                }
                                while (topup <= 1000);
                                Console.WriteLine("kekeman: Good day, where u dey go?");
                                Console.Write($"{username}: ");
                                String destination = Console.ReadLine();

                                //if statement for route
                                if (destination.ToLower() == "new market")
                                {
                                    Console.WriteLine("kekeman: of course i can take you there it costs 100 naira");
                                    Console.ReadLine();
                                }
                                //else if statement for aptech route
                                else if (destination.ToLower() == "apthech")
                                {
                                    Console.WriteLine("kekeman: we don't got there from here but i can take you to new market,nah 100 naira");
                                    Console.ReadLine();
                                }
                                else
                                {
                                    Console.WriteLine("kekeman: we don't got there from here but i can take you to new market,nah 100 naira");
                                    Console.ReadLine();
                                }

                                Console.WriteLine($"kekeman: Last bus stop oga {username}, go there you will see keke going to akwata");
                                Console.WriteLine();
                                Console.WriteLine($"{AI}:When you get to akwata, take another keke going to HRC");
                                Console.WriteLine($"when you get to HRC, crossover to the buiding opposite and you have gotten to apthech");
                                Console.Write($"Are you there yet?,Y/N:  ");
                                String condition2 = Console.ReadLine();
                                do
                                {
                                    Console.WriteLine("here are the instructions again");
                                    Console.WriteLine($"kekeman: Last bus stop oga {username}, go there you will see keke going to akwata");
                                    Console.WriteLine();
                                    Console.WriteLine($"{AI}:When you get to akwata, take another keke going to HRC");
                                    Console.WriteLine($"when you get to HRC, crossover to the buiding opposite and you have gotten to apthech");
                                    Console.Write($"Are you there yet?,Y/N:  ");
                                    condition2 = Console.ReadLine();
                                }
                                while (condition2 != "y");
                                Console.WriteLine($"{AI}: Well done user {username}, you are now in aptech");
                            }
                            else
                            {
                                Console.Write($"{AI}:Then we would have to use the bus mode of transport user {username}");
                                Console.WriteLine($"bus conductor: where u dey go?:");
                                Console.Write($"{username}: ");
                                String destination = Console.ReadLine();
                                if (destination.ToLower() == "new market")
                                {
                                    Console.WriteLine("bus conductor: i fit take you there, na 100 naira we dey collect");
                                    Console.ReadLine();
                                }
                                else if (destination.ToLower() == "aptech")
                                {
                                    Console.WriteLine("bus conductor: we don't go there from here but i can take you to new market,nah 100 naira");
                                    Console.ReadLine();
                                }
                                else
                                {
                                    Console.WriteLine("bus conductor: we don't go there from here but i can take you to new market,nah 100 naira");
                                    Console.ReadLine();
                                }

                                Console.WriteLine($"bus conductor: Last bus stop oga {username}, go there you will see bus going to akwata");
                                Console.WriteLine();
                                Console.WriteLine($"{AI}:When you get to akwata, take another big bus going to HRC");
                                Console.WriteLine($"when you get to HRC, crossover to the buiding opposite and you have gotten to aptech");
                                Console.Write($"user {username} Are you there yet?,Y/N:  ");
                                String condition2 = Console.ReadLine();
                                do
                                {
                                    Console.WriteLine("here are the instructions again");
                                    Console.WriteLine($"bus conductor: Last bus stop oga {username}, go there you will see a bus going to akwata");
                                    Console.WriteLine();
                                    Console.WriteLine($"{AI}:When you get to akwata, take another big bus going to HRC");
                                    Console.WriteLine($"when you get to HRC, crossover to the buiding opposite and you have gotten to aptech");
                                    Console.Write($"Are you there yet?,Y/N:  ");
                                    condition2 = Console.ReadLine();
                                }
                                while (condition2 != "y");
                                Console.WriteLine($"{AI}: Well done user {username}, you are now in aptech");

                            }


                        }
                        else if (checkbudget == false)
                        {
                            Console.WriteLine("it works");
                            Console.WriteLine("kekeman: Good day, where u dey go?");
                            Console.Write($"{username}: ");
                            String destination = Console.ReadLine();

                            //if statement for route
                            if (destination.ToLower() == "new market")
                            {
                                Console.WriteLine("kekeman: of course i can take you there it costs 100 naira");
                                Console.ReadLine();
                            }
                            else if (destination.ToLower() == "aptech")
                            {
                                Console.WriteLine("kekeman: we don't go there from here but i can take you to new market,nah 100 naira");
                                Console.ReadLine();
                            }
                            else
                            {
                                Console.WriteLine("kekeman: we don't go there from here but i can take you to new market,nah 100 naira");
                                Console.ReadLine();
                            }

                            Console.WriteLine($"kekeman: Last bus stop oga {username}, go there you will see keke going to akwata");
                            Console.WriteLine();
                            Console.WriteLine($"{AI}:When you get to akwata, take another keke going to HRC");
                            Console.WriteLine($"when you get to HRC, crossover to the buiding opposite and you have gotten to apthech");
                            Console.Write($"Are you there yet?,Y/N:  ");
                            String condition2 = Console.ReadLine();
                            do
                            {
                                Console.WriteLine("here are the instructions again");
                                Console.WriteLine($"kekeman: Last bus stop oga {username}, go there you will see keke going to akwata");
                                Console.WriteLine();
                                Console.WriteLine($"{AI}:When you get to akwata, take another keke going to HRC");
                                Console.WriteLine($"when you get to HRC, crossover to the buiding opposite and you have gotten to apthech");
                                Console.Write($"Are you there yet?,Y/N:  ");
                                condition2 = Console.ReadLine();
                            }
                            while (condition2 != "y");
                            Console.WriteLine($"{AI}: Well done user {username}, you are now in aptech");

                        }
                    }
                    else if (modeoftransport.ToLower() == "bus")
                    {
                        Console.WriteLine($"bus conductor: where u dey go?:");
                        Console.Write($"{username}: ");
                        String destination = Console.ReadLine();
                        if (destination.ToLower() == "new market")
                        {
                            Console.WriteLine("bus conductor: i fit take you there, na 100 naira we dey collect");
                            Console.ReadLine();
                        }
                        else if (destination.ToLower() == "aptech")
                        {
                            Console.WriteLine("bus conductor: we don't go there from here but i can take you to new market,nah 100 naira");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("bus conductor: we don't go there from here but i can take you to new market,nah 100 naira");
                            Console.ReadLine();
                        }

                        Console.WriteLine($"bus conductor: Last bus stop oga {username}, go there you will see bus going to akwata");
                        Console.WriteLine();
                        Console.WriteLine($"{AI}:When you get to akwata, take another big bus going to HRC");
                        Console.WriteLine($"when you get to HRC, crossover to the buiding opposite and you have gotten to aptech");
                        Console.Write($"user {username} Are you there yet?,Y/N:  ");
                        String condition2 = Console.ReadLine();
                        do
                        {
                            Console.WriteLine("here are the instructions again");
                            Console.WriteLine($"bus conductor: Last bus stop oga {username}, go there you will see a bus going to akwata");
                            Console.WriteLine();
                            Console.WriteLine($"{AI}:When you get to akwata, take another big bus going to HRC");
                            Console.WriteLine($"when you get to HRC, crossover to the buiding opposite and you have gotten to aptech");
                            Console.Write($"Are you there yet?,Y/N:  ");
                            condition2 = Console.ReadLine();
                        }
                        while (condition2 != "y");
                        Console.WriteLine($"{AI}: Well done user {username}, you are now in aptech");


                    }
                }
                else if (route.ToLower() == "holy ghost")
                {
                    //user prompt
                    Console.WriteLine("alright user\nWhat mode of transport would you prefer");
                    Console.WriteLine();
                    Console.WriteLine("Mininum required budget:\n(1)keke = 1000\n(2)bus = 700");
                    Console.WriteLine();
                    Console.Write("(1)Keke  or\n(2)Bus\n: ");
                    String modeoftransport = Console.ReadLine();

                    //if statement for modeof transport
                    if (modeoftransport.ToLower() == "keke")
                    {
                        //boolean for budget true and false
                        bool checkbudget = budget < universalbudget;


                        //if statement for checking if budget is greater than required budget
                        if (checkbudget == true)
                        {
                            //code for diff btwn budget
                            int diffbudget = universalbudget - budget;
                            Console.WriteLine($"your budget is below the required amount needed to take this option\nyou require {diffbudget} to be able to " +
                                $"take this option");
                            Console.WriteLine($"would you like to change your budget, Y/N: ");
                            String condition = Console.ReadLine();

                            //if statement for continuation of code
                            if (condition.ToLower() == "y")
                            {
                                Console.Write("please input your new budget: ");
                                int topup = Convert.ToInt32(Console.ReadLine());

                                //do while loop for checking if topup is greater than required required budget
                                do
                                {
                                    Console.Write("budget was lower than expected try again: ");
                                    topup = Convert.ToInt32(Console.ReadLine());

                                }
                                while (topup < 1000);
                                Console.WriteLine("kekeman: Good day, where u dey go?");
                                Console.Write($"{username}: ");
                                String destination = Console.ReadLine();

                                //if statement for route
                                if (destination.ToLower() == "holy ghost")
                                {
                                    Console.WriteLine("kekeman: of course i can take you there it costs 100 naira");
                                    Console.ReadLine();
                                }
                                else if (destination.ToLower() == "aptech")
                                {
                                    Console.WriteLine("kekeman: we don't got there from here but i can take you to holy ghost,nah 100 naira");
                                    Console.ReadLine();
                                }//end of if statement for route
                                else
                                {
                                    Console.WriteLine("kekeman: we don't got there from here but i can take you to holy ghost,nah 100 naira");
                                    Console.ReadLine();
                                }

                                Console.WriteLine($"kekeman: Last bus stop oga {username}, go there you will see keke going to Gariki or kenyatta" +
                                    $"ask to be dropped off at HRC");
                                Console.WriteLine();
                                Console.WriteLine($"kekeman:oga where will you be dropping?");
                                Console.ReadLine();
                                Console.WriteLine($"{username}:I will drop off at HRC bus stop");
                                Console.WriteLine($"{AI}: when you get to HRC, crossover to the buiding opposite and you have gotten to apthech");
                                Console.Write($"Are you there yet?,Y/N:  ");
                                String condition2 = Console.ReadLine();
                                do//check if the user got to the final destination
                                {
                                    Console.WriteLine($"kekeman:oga where will you be dropping?");
                                    Console.ReadLine();
                                    Console.WriteLine($"{username}:I will drop off at HRC bus stop");
                                    Console.WriteLine($"{AI}: when you get to HRC, crossover to the buiding opposite and you have gotten to apthech");
                                    Console.Write($"Are you there yet?,Y/N:  ");
                                    condition2 = Console.ReadLine();
                                }
                                while (condition2 != "y");
                            }
                            else
                            {
                                Console.Write($"Then we would have to take the bus mode user {username}");
                                Console.WriteLine($"bus conductor: where u dey go?:");
                                Console.Write($"{username}: ");
                                String destination = Console.ReadLine();
                                if (destination.ToLower() == "holy ghost")
                                {
                                    Console.WriteLine("bus conductor: i fit take you there, na 100 naira we dey collect");
                                    Console.ReadLine();
                                }
                                else if (destination.ToLower() == "aptech")
                                {
                                    Console.WriteLine("bus conductor: we don't go there from here but i can take you to new market,nah 100 naira");
                                    Console.ReadLine();
                                }
                                else
                                {
                                    Console.WriteLine("bus conductor: we don't go there from here but i can take you to holy ghost,nah 100 naira");
                                    Console.ReadLine();
                                }

                                Console.WriteLine($"bus conductor: Last bus stop oga {username}, go there you will see bus going to gariki or kenyatta");
                                Console.WriteLine();
                                Console.WriteLine($"{AI}:Tell the coductor you are dropping off at HRC busstop");
                                Console.WriteLine($"when you get to HRC, crossover to the buiding opposite and you have gotten to aptech");
                                Console.Write($"user {username} Are you there yet?,Y/N:  ");
                                String condition2 = Console.ReadLine();
                                do
                                {
                                    Console.WriteLine("here are the instructions again");
                                    Console.WriteLine($"bus conductor: Last bus stop oga {username}, go there you will see bus going to gariki or kenyatta");
                                    Console.WriteLine();
                                    Console.WriteLine($"{AI}:Tell the coductor you are dropping off at HRC busstop");
                                    Console.WriteLine($"when you get to HRC, crossover to the buiding opposite and you have gotten to aptech");
                                    Console.Write($"user {username} Are you there yet?,Y/N:  ");
                                    condition2 = Console.ReadLine();
                                }
                                while (condition2 != "y");
                                Console.WriteLine($"{AI}: Well done user {username}, you are now in aptech");

                            }


                        }
                        else if (checkbudget == false)
                        {
                            Console.WriteLine("it works");
                            Console.WriteLine("kekeman: Good day, where u dey go?");
                            Console.Write($"{username}: ");
                            String destination = Console.ReadLine();

                            //if statement for route
                            if (destination.ToLower() == "holy ghost")
                            {
                                Console.WriteLine("kekeman: of course i can take you there it costs 100 naira");
                                Console.ReadLine();
                            }
                            else if (destination.ToLower() == "aptech")
                            {
                                Console.WriteLine("kekeman: we don't got there from here but i can take you to holy ghost,nah 100 naira");
                                Console.ReadLine();
                            }
                            else
                            {
                                Console.WriteLine("kekeman: we don't got there from here but i can take you to holy ghost,nah 100 naira");
                                Console.ReadLine();
                            }

                            Console.WriteLine($"kekeman: Last bus stop oga {username}, go there you will see keke going to Gariki or kenyatta" +
                                $"ask to be dropped off at HRC");
                            Console.WriteLine();
                            Console.WriteLine($"kekeman:oga where will you be dropping?");
                            Console.ReadLine();
                            Console.WriteLine($"{username}:I will drop off at HRC bus stop");
                            Console.WriteLine($"{AI}: when you get to HRC, crossover to the buiding opposite and you have gotten to apthech");
                            Console.Write($"Are you there yet?,Y/N:  ");
                            String condition2 = Console.ReadLine();
                            do
                            {
                                Console.WriteLine($"kekeman:oga where will you be dropping?");
                                Console.ReadLine();
                                Console.WriteLine($"{username}:I will drop off at HRC bus stop");
                                Console.WriteLine($"{AI}: when you get to HRC, crossover to the buiding opposite and you have gotten to apthech");
                                Console.Write($"Are you there yet?,Y/N:  ");
                                condition2 = Console.ReadLine();
                            }
                            while (condition2 != "y");
                        }
                    }
                    else if (modeoftransport.ToLower() == "bus")
                    {
                        Console.WriteLine($"bus conductor: where u dey go?:");
                        Console.Write($"{username}: ");
                        String destination = Console.ReadLine();
                        if (destination.ToLower() == "holy ghost")
                        {
                            Console.WriteLine("bus conductor: i fit take you there, na 100 naira we dey collect");
                            Console.ReadLine();
                        }
                        else if (destination.ToLower() == "aptech")
                        {
                            Console.WriteLine("bus conductor: we don't go there from here but i can take you to new market,nah 100 naira");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("bus conductor: we don't go there from here but i can take you to new market,nah 100 naira");
                            Console.ReadLine();
                        }

                        Console.WriteLine($"bus conductor: Last bus stop oga {username}, go there you will see keke going to Gariki or kenyatta" +
                               $"ask to be dropped off at HRC");
                        Console.WriteLine();
                        Console.WriteLine($"bus conductor:oga where will you be dropping?");
                        Console.ReadLine();
                        Console.WriteLine($"{username}:I will drop off at HRC bus stop");
                        Console.WriteLine($"{AI}: when you get to HRC, crossover to the buiding opposite and you have gotten to apthech");
                        Console.Write($"Are you there yet?,Y/N:  ");
                        String condition2 = Console.ReadLine();
                        do
                        {
                            Console.WriteLine($"bus conductor:oga where will you be dropping?");
                            Console.ReadLine();
                            Console.WriteLine($"{username}:I will drop off at HRC bus stop");
                            Console.WriteLine($"{AI}: when you get to HRC, crossover to the buiding opposite and you have gotten to apthech");
                            Console.Write($"Are you there yet?,Y/N:  ");
                            condition2 = Console.ReadLine();
                        }
                        while (condition2 != "y");
                    }
                }
                else if (route.ToLower() == "new layout")
                {
                    Console.WriteLine("alright user\nWhat mode of transport would you prefer");
                    Console.WriteLine();
                    Console.WriteLine("Mininum required budget:\n(1)keke = 1000\n(2)bus = 700");
                    Console.WriteLine();
                    Console.Write("(1)Keke  or\n(2)Bus\n: ");
                    String modeoftransport = Console.ReadLine();

                    //if statement for modeof transport
                    if (modeoftransport.ToLower() == "keke")
                    {
                        //boolean for budget true and false
                        bool checkbudget = budget < universalbudget;


                        //if statement for checking if budget is greater than required budget
                        if (checkbudget == true)
                        {
                            int diffbudget = universalbudget - budget;
                            Console.WriteLine($"your budget is below the required amount needed to take this option\nyou require {diffbudget} to be able to " +
                                $"take this option");
                            Console.WriteLine($"would you like to change your budget, Y/N: ");
                            String condition = Console.ReadLine();

                            //if statement for continuation of code
                            if (condition.ToLower() == "y")
                            {
                                Console.Write("please input your new budget: ");
                                int topup = Convert.ToInt32(Console.ReadLine());

                                //do while loop for checking if topup is greater than required required budget
                                do
                                {
                                    Console.Write("budget was lower than expected try again: ");
                                    topup = Convert.ToInt32(Console.ReadLine());

                                }
                                while (topup < 1000);
                                Console.WriteLine("kekeman: Good day, where u dey go?");
                                Console.Write($"{username}: ");
                                String destination = Console.ReadLine();

                                //if statement for route
                                if (destination.ToLower() == "new layout")
                                {
                                    Console.WriteLine("kekeman: of course i can take you there it costs 100 naira");
                                    Console.ReadLine();
                                }
                                else if (destination.ToLower() == "aptech")
                                {
                                    Console.WriteLine("kekeman: we don't got there from here but i can take you to new layout,nah 100 naira");
                                    Console.ReadLine();
                                }
                                else
                                {
                                    Console.WriteLine("kekeman: we don't got there from here but i can take you to new layout,nah 100 naira");
                                    Console.ReadLine();
                                }

                                Console.WriteLine($"kekeman: Last bus stop oga {username}, go there you will see keke going to obiagu" +
                                    $"Then take a keke to HRC bus stop");
                                Console.WriteLine();
                                Console.WriteLine($"kekeman:oga where will you be dropping?");
                                Console.ReadLine();
                                Console.WriteLine($"{username}:I will drop off at HRC bus stop");
                                Console.WriteLine($"{AI}: when you get to HRC, crossover to the buiding opposite and you have gotten to apthech");
                                Console.Write($"Are you there yet?,Y/N:  ");
                                String condition2 = Console.ReadLine();
                                do
                                {
                                    Console.WriteLine($"kekeman:oga where will you be dropping?");
                                    Console.ReadLine();
                                    Console.WriteLine($"{username}:I will drop off at HRC bus stop");
                                    Console.WriteLine($"{AI}: when you get to HRC, crossover to the buiding opposite and you have gotten to apthech");
                                    Console.Write($"Are you there yet?,Y/N:  ");
                                    condition2 = Console.ReadLine();
                                }
                                while (condition2 != "y");
                            }
                            else
                            {
                                Console.Write($"Then we would have to take the bus mode user {username}");
                                Console.WriteLine($"bus conductor: where u dey go?:");
                                Console.Write($"{username}: ");
                                String destination = Console.ReadLine();
                                if (destination.ToLower() == "new layout")
                                {
                                    Console.WriteLine("bus conductor: i fit take you there, na 100 naira we dey collect");
                                    Console.ReadLine();
                                }
                                else if (destination.ToLower() == "aptech")
                                {
                                    Console.WriteLine("bus conductor: we don't go there from here but i can take you to new layout,nah 100 naira");
                                    Console.ReadLine();
                                }
                                else
                                {
                                    Console.WriteLine("bus conductor: we don't go there from here but i can take you to new layout,nah 100 naira");
                                    Console.ReadLine();
                                }

                                Console.WriteLine($"bus conductor: Last bus stop oga {username}, go there you will see bus going to obiagu");
                                Console.WriteLine();
                                Console.WriteLine($"{AI}:Take a bus from the last bus stop and drop off at  HRC busstop");
                                Console.WriteLine($"when you get to HRC, crossover to the buiding opposite and you have gotten to aptech");
                                Console.Write($"user {username} Are you there yet?,Y/N:  ");
                                String condition2 = Console.ReadLine();
                                do
                                {
                                    Console.WriteLine("here are the instructions again");
                                    Console.WriteLine($"bus conductor: Last bus stop oga {username}, go there you will see bus going to obiagu");
                                    Console.WriteLine();
                                    Console.WriteLine($"{AI}:Take a bus from the last bus stop and drop off at  HRC busstop");
                                    Console.WriteLine($"when you get to HRC, crossover to the buiding opposite and you have gotten to aptech");
                                    Console.Write($"user {username} Are you there yet?,Y/N:  ");
                                    condition2 = Console.ReadLine();
                                }
                                while (condition2 != "y");
                                Console.WriteLine($"{AI}: Well done user {username}, you are now in aptech");

                            }


                        }
                        else if (checkbudget == false)
                        {
                            Console.WriteLine("it works");
                            Console.WriteLine("kekeman: Good day, where u dey go?");
                            Console.Write($"{username}: ");
                            String destination = Console.ReadLine();

                            //if statement for route
                            if (destination.ToLower() == "new layout")
                            {
                                Console.WriteLine("kekeman: of course i can take you there it costs 100 naira");
                                Console.ReadLine();
                            }
                            else if (destination.ToLower() == "aptech")
                            {
                                Console.WriteLine("kekeman: we don't got there from here but i can take you to new layout,nah 100 naira");
                                Console.ReadLine();
                            }
                            else
                            {
                                Console.WriteLine("kekeman: we don't got there from here but i can take you to new layout,nah 100 naira");
                                Console.ReadLine();
                            }

                            Console.WriteLine($"kekeman: Last bus stop oga {username}, go there you will see keke going to obiagu" +
                                $"take another keke at the last bus stop and ask to be dropped off at HRC bus stop");
                            Console.WriteLine();
                            Console.WriteLine($"{AI}: when you get to HRC, crossover to the buiding opposite and you have gotten to apthech");
                            Console.Write($"Are you there yet?,Y/N:  ");
                            String condition2 = Console.ReadLine();
                            do
                            {
                                Console.WriteLine($"kekeman: Last bus stop oga {username}, go there you will see keke going to obiagu" +
                                 $"take another keke at the last bus stop and ask to be dropped off at HRC bus stop");
                                Console.WriteLine();
                                Console.WriteLine($"{AI}: when you get to HRC, crossover to the buiding opposite and you have gotten to apthech");
                                Console.Write($"Are you there yet?,Y/N:  ");
                                condition2 = Console.ReadLine();
                            }
                            while (condition2 != "y");
                        }
                    }
                    else if (modeoftransport.ToLower() == "bus")
                    {
                        Console.WriteLine($"bus conductor: where u dey go?:");
                        Console.Write($"{username}: ");
                        String destination = Console.ReadLine();
                        if (destination.ToLower() == "holy ghost")
                        {
                            Console.WriteLine("bus conductor: i fit take you there, na 100 naira we dey collect");
                            Console.ReadLine();
                        }
                        else if (destination.ToLower() == "aptech")
                        {
                            Console.WriteLine("bus conductor: we don't go there from here but i can take you to new layout,nah 100 naira");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("bus conductor: we don't go there from here but i can take you to nnew layout,nah 100 naira");
                            Console.ReadLine();
                        }

                        Console.WriteLine($"bus conductor: Last bus stop oga {username}, go there you will see keke going to obiagu" +
                               $" Take another bus at the last bus stop and ask to be dropped off at HRC");
                        Console.WriteLine();
                        Console.WriteLine($"bus conductor:oga where will you be dropping?");
                        Console.ReadLine();
                        Console.WriteLine($"{username}:I will drop off at HRC bus stop");
                        Console.WriteLine($"{AI}: when you get to HRC, crossover to the buiding opposite and you have gotten to apthech");
                        Console.Write($"Are you there yet?,Y/N:  ");
                        String condition2 = Console.ReadLine();
                        do
                        {
                            Console.WriteLine($"bus conductor:oga where will you be dropping?");
                            Console.ReadLine();
                            Console.WriteLine($"{username}:I will drop off at HRC bus stop");
                            Console.WriteLine($"{AI}: when you get to HRC, crossover to the buiding opposite and you have gotten to apthech");
                            Console.Write($"Are you there yet?,Y/N:  ");
                            condition2 = Console.ReadLine();
                        }
                        while (condition2 != "y");
                    }

                }
                Console.Write("Do you want to end the program y/n: ");
                String checkrestart = Console.ReadLine();
                if(checkrestart != "y")
                {
                    restart = "false";
                }
            } while (restart =="false");


            Console.ReadKey();




           // Console.WriteLine(Isstring(username));
            
        }
        //static int No(int i, int a)
        //{
        //    int result = i + a;
        //    return result;  
        //}
        static String Isstring(String name)
        {            
            bool checkit = true;
            string name2 = name;
            while (true)
            {
                if (name == name2)
                {
                    foreach (char c in name)
                    {
                        if (!char.IsLetter(c))
                        {
                            return "its not a valid input";
                        }
                    }
                if (true)
                    {

                        Console.WriteLine("thank you");
                }
                if (String.IsNullOrEmpty(name))
                {
                        Console.Write("please dont leave it empty: ");
                }
                else break;
                return "thank you for your input";
                }
             Console.Write ( "hello");
             name = Console.ReadLine();
            }
            return "nigg";
        }
    }
}
            