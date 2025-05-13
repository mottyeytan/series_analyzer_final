namespace the_series_anylzer
{
    class Program
    {
        
        static List<int> series; 
        static string GetOption; 
        static int length = 0;

        static List<string> ReciveListOfNums(string[] args)
        {
            List<string> list = new List<string>();
            if (args.Length >= 3)
            {
                list = new List<string>(args);
            }
            else
            {
                string input = null;
                while (input != "-1" || list.Count <= 3)
                {
                    Console.WriteLine("please enter at least 3 numbers" +
                                      "for exit enter -1");
                    input = Console.ReadLine();
                    if (input == "-1" || list.Count >= 3)
                    {
                        break;
                    }
                    else if (input == "-1" || list.Count < 3)
                    {
                        Console.WriteLine("you must enter at least 3 numbers");
                        continue;
                    }
                    list.Add(input);
                }
            }
            return list;
        }

        static bool Intinal(List<string> nums)
        {
            if (nums.Count < 3) return false; 
            
            List<int> lst = new List<int>();
            int temp = 0;

            foreach (string num in nums)
            {
                if (!int.TryParse(num, out temp) || temp < 0)
                {
                    Console.WriteLine("invalid number: it must be a number or a positive integer");
                    return false;
                }
              lst.Add(temp);
            }
            length = lst.Count;
            series = lst;
            return true;
        }

        static void DisplayMenu()
        {
            Console.WriteLine("\n-------- NUMBER SERIES MENU --------\n");
    
            Console.WriteLine("   a │ Enter a new series");
            Console.WriteLine("   ──┼────────────────────────────────");
            Console.WriteLine("   b │ Display series (original order)");
            Console.WriteLine("   c │ Display series (reversed)");
            Console.WriteLine("   d │ Display series (sorted)");
            Console.WriteLine("   ──┼────────────────────────────────");
            Console.WriteLine("   e │ Show maximum value");
            Console.WriteLine("   f │ Show minimum value");
            Console.WriteLine("   g │ Show average");
            Console.WriteLine("   h │ Show count");
            Console.WriteLine("   i │ Show sum");
            Console.WriteLine("   ──┼────────────────────────────────");
            Console.WriteLine("   j │ Exit\n");
    
            Console.Write("   Select option: ");
        }

        static bool ValidateMenu(string input)
        {
            Console.WriteLine(input);
            string[] options = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j" };
            if (!options.Contains(input))
            {
                Console.WriteLine("please choose only between a and j");
                return false;
            }

            GetOption = input;
            return true;
        }

        static string GetInputOption()
        {
           string userInput = Console.ReadLine();
           return userInput;
        }


        static void ActivateOptions(string input)
        {
            while (true)
            {
                switch (input)
                {
                    case "a":
                    
                } 
            }
            
        }

        static string GetSeries_A()
        {
            string SeriesInput;
            List<string> lst;
            
            do
            {
                SeriesInput = Console.ReadLine();
                lst = new List<string>(SeriesInput.Split(','));

            } while (!Intinal(lst));
            return SeriesInput;
                
        }

        static List<string> DisaplySeries_B(string input)
        {
            string series = GetSeries_A();
            List<string> lst;
            lst = new List<string>(input.Split(','));
            return lst;
        }
        

        static void Main(string[] args) 
        {
            // validate the input and put them into list
            while (!Intinal(ReciveListOfNums(args))){}
           
            
            while (!ValidateMenu(GetInputOption())){}
            
 
        }
            
        
                 
                
           
       
    }
}