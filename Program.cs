namespace the_series_anylzer
{
    class Program
    {
        static List<int> series = new List<int>();
        static string GetOption; 
        
        //recive the args or input and return it as a list
        static List<string> ReciveListOfNums(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("please enter at least 3 numbers");
                string input = Console.ReadLine();
                List<string> series1 = new List<string>(input.Split());
                return series1;
            }
            List<string> argslst = args.ToList();
            return argslst;
        }
        
        //validate the input. || 1: that is bigger tham 3. ||  2:  its a interger  ||  3: positive number || 4: not an extra space
        static bool ValidateSeries(List<string> nums)
        {
            if (nums.Count < 3) return false;

            foreach (string item in nums)
            {
                if (item.Length == 0) return false;
                if (!item.All(char.IsDigit)) return false;
                if (item[0] == '-')return false;
                
            }
            return true;
        }
        
        
        //convert the input to list<int>
        static void ConvertInputToInt(List<string> inputList)
        {
            series = inputList.Select(int.Parse).ToList();
        }
        
        
        // display the menu
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
        // validate menu. checks if he chooesed in the range of the options.
        static bool ValidateMenu(string input)
        {
            string[] options = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j" };
            if (!options.Contains(input))
            {
                Console.WriteLine("please choose only between a and j");
                return false;
            }

            GetOption = input;
            return true;
        }
        
        //input for the menu
        static string GetInputOption()
        {
           string userInput = Console.ReadLine();
           return userInput;
        }

        // take the input and returns the right function
        static void ActivateOptions(string input)
        {
            switch (input)
            {
                case "a":
                    GetSeries_A();
                    break;
                case "b":
                    DisaplySeries_B();
                    break;
                case "c":
                    DisaplySeriesBackwords_C();
                    break;
                case "d":
                    DisplaySorted_D();
                    break;
                case "e":
                    DisplayMax_E();
                    break;
                case "f":
                    DisplayMin_F();
                    break;
                case "g":
                    DisplayAverage_G();
                    break;
                case "h":
                    DisplayCount_H();
                    break;
                case "i":
                    DisplaySum_J();
                    break;
                case "j":
                    break;
            }
        }
        

        static List<int> GetSeries_A()
        {
            string SeriesInput;
            List<string> lst;
            
            do
            {
                SeriesInput = Console.ReadLine();
                lst = new List<string>(SeriesInput.Split(' '));

            } while (!ValidateSeries(lst));

            List<int> intList = lst.ConvertAll(x => int.Parse(x.Trim()));
            
            series = intList;

            return intList;

        }

        static void DisaplySeries_B()
        {
            
            for (int i = 0; i < series.Count -1 ; i++)
            {
                Console.Write($"{series[i]}, ");
            }
            Console.Write(series[series.Count-1]);
            Console.Write("\n");
        }

        static void DisaplySeriesBackwords_C()
        {
            
            for (int i = series.Count -1 ; i > 0 ; i--)
            {
                Console.Write($"{series[i]}, ");
            }
            Console.Write(series[0]);
            Console.Write("\n");
        }

        static void DisplaySorted_D()
        {
           
            for (int i = 0; i < series.Count; i++)
            {
                bool swapped = false;
                for (int j = 0; j < series.Count - 1; j++)
                {
                    if (series[j] > series[j + 1])
                    {
                        int temp = series[j];
                        series[j] = series[j + 1];
                        series[j + 1] = temp;
                        swapped = true;
                    }
                    if (swapped) break;
                }
            }
            foreach (int i in series) Console.Write($"{i}, ");
        }

        static void DisplayMax_E()
        {
            
            int max = series[0];

            foreach (var i in series)
            {
                if (i > max) max = i;
            }
            Console.WriteLine(max);
        }

        static void DisplayMin_F()
        {
            
            int min = series[0];
            foreach (var i in series)
            {
                if (i < min) min = i;
            }
            Console.WriteLine(min);
        }

        static void DisplayAverage_G()
        {
            
            int add = 0;
            foreach (int i in series)
            {
                add += i;
            }
            Console.WriteLine(add/series.Count);
        }

        static void DisplayCount_H()
        {
            
            int count = 0;
            foreach (int i in series)
            {
                count++;
            }

            Console.WriteLine(count);
        }

        static void DisplaySum_J()
        {
           
            int sum = 0;
            foreach (int i in series)
            {
                sum += i;
            }
            Console.WriteLine(sum);
        }
        
        static void Main(string[] args) 
        {
            // validate the input and put them into list
            List<string> inputList;
            do
            {
                inputList = ReciveListOfNums(args);
                args = new string[0];
            } while (!ValidateSeries(inputList));
    
            ConvertInputToInt(inputList);
            
            
            
            while (true)
            {
                
                DisplayMenu();
                while (!ValidateMenu(GetInputOption())) {}
        
                if (GetOption == "j") break;
        
                ActivateOptions(GetOption);
            }
            
        }
    }
}
