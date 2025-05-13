namespace the_series_anylzer
{
    class Program
    {
        
        List<int> series = new List<int>();
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
        
        
        

        static void Main(string[] args)
        {
           recivelistofnums(args);
            }
            
        
                 
                
           
       
    }
}