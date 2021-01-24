using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int> { };
            dictionary.Add("Ahmet", 16);
            dictionary.Add("Mehmet", 30);

            for (int i = 0; i < dictionary.keys.Length; i++)
            {
                Console.WriteLine(dictionary.keys[i].ToString() + " : " + dictionary.values[i].ToString());
            }

        }
    }
}
