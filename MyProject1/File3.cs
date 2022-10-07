class File3
{
    public static void Main()
    {
        string fileName = @"name.txt";

        try
        {
            // Create the file.
            using (StreamWriter fileStr = File.CreateText(fileName))
            {
                fileStr.WriteLine(" Prathiksha");
                fileStr.WriteLine(" S ");
                fileStr.WriteLine(" Naik ");
            }
            using (StreamReader sr = File.OpenText(fileName))
            {
                string s = "";
                Console.WriteLine(" Here is the content of the file name.txt : ");
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
                Console.WriteLine("");
            }

            Console.Write("\n The content of the first line of the file is :\n");
            if (File.Exists(fileName))
            {
                string[] lines = File.ReadAllLines(fileName);
                Console.Write(lines[0]);
            }
            Console.WriteLine();
        }
        catch (Exception MyExcep)
        {
            Console.WriteLine(MyExcep.ToString());
        }
    }
}