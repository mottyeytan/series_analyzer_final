namespace the_series_anylzer
{
    class Program
    {
        
        static List<int> series;
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
                while (input != "-1")
                {
                    Console.WriteLine("please enter a number" +
                                      "for exit enter -1");
                    input = Console.ReadLine();
                    if (input == "-1") break;
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
              if (!int.TryParse(num, out temp)||temp<0)return false;
              lst.Add(temp);
            }
            length = lst.Count;
            series = lst;
            return true;
        }
        
        
        

        static void Main(string[] args) 
        {
            while (!Intinal(ReciveListOfNums(args))){}
            
 
        }
            
        
                 
                
           
       
    }
}