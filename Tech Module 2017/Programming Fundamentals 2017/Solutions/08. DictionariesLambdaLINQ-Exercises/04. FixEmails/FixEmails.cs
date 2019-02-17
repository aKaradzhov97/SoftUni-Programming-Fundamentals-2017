using System;
using System.Collections.Generic;

class FixEmails
{
    public static void Main()
    {
        var dict = new Dictionary<string, string>();

        while (true)
        {
            string name = Console.ReadLine(); ;
            string emailInLowerCase = "";
            if (name == "stop")
            {
                break;
            }
            else
            {
                emailInLowerCase = Console.ReadLine();
            }
            bool isUsUkEmail = false;

            if (emailInLowerCase.EndsWith(".us") || emailInLowerCase.EndsWith(".uk"))
            {
                isUsUkEmail = true;
            }

            if (isUsUkEmail == false)
            {
                if (dict.ContainsKey(name))
                {
                    dict[name] = emailInLowerCase;
                }
                else
                {
                    dict.Add(name, emailInLowerCase);
                }
            }
        }
        foreach (KeyValuePair<string, string> email in dict)
        {
            Console.WriteLine($"{email.Key} -> {email.Value}");
        }
    }
}