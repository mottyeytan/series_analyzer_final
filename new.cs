using System;

class MainClass {

    public static int StringChallenge(string str) {

        string[] exclude = {"a", "e", "i", "o", "u"};
        int count = 0;
        foreach (string s in str.Split(' '))
        {
            if (!exclude.Contains(s))
            {
                count++;
            }
        }
        
        return count;

    }

    // keep this function call here
    static void Main() {

        Console.WriteLine(StringChallenge(Console.ReadLine()));
    
    } 

}