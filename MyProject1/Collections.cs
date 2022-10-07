using System.Collections;

class Collections {
    public static void Main()
    {

        
        DictionaryDemo();
        HashtableDemo();


    }
    public static void DictionaryDemo()
{
        Dictionary<string, string> dict = new Dictionary<string, string>();
        dict.Add("  Prathiksha", "Developer  ");
        dict.Add("  Prarthana", "Tester  ");
        dict.Add("  Ankith", "Database  ");
        Console.WriteLine("DICTIONARY");
        foreach (KeyValuePair<string, string> kvp in dict)
        {
            Console.Write(kvp.Key.ToString() + " ");
            Console.Write(kvp.Value.ToString());
            Console.WriteLine();
        }
        

    
    Console.WriteLine("*********************************");

}
    public static void HashtableDemo()
    {
        Hashtable hashtable = new Hashtable();
        hashtable.Add(1, "C#");
        hashtable.Add(2, "Java");
        hashtable.Add("Backend", "Python");
        Console.WriteLine("HASHTABLE");
       
        ICollection key = hashtable.Keys;
        foreach (var contents in key)
        {
            Console.WriteLine($"  {hashtable[contents]}  ");
        }
        

    }
}