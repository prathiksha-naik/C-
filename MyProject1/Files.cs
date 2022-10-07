class Files
{
    static void Main(string[] args)
    {
        
        string mainFile = @"C:\Users\EI13144\GitHub Repos\C-Sharp-Programs\MyProject1\mainFile.txt";
        string newlyCreatedFile = @"newFile.txt";
        string movingFile = @"movingFile.txt";


        if (File.Exists(newlyCreatedFile))
        {
            Console.WriteLine("File already exist");
        }
        else
        {
            File.Create(newlyCreatedFile);
            Console.WriteLine("File " + newlyCreatedFile + " created");
        }

        

       //Reading File
       Console.WriteLine("Reading File1");
       string str = File.ReadAllText(newlyCreatedFile);
       Console.WriteLine(str);
        
        Console.WriteLine();

        //COPY
        File.Copy(mainFile, newlyCreatedFile, true);
        
        Console.WriteLine("COPIED FROM COPYTXT ");
        string str2 = File.ReadAllText(newlyCreatedFile);
        Console.WriteLine(str2);
        //delete
        File.Delete(newlyCreatedFile);
        Console.WriteLine("File deleted: " + newlyCreatedFile);
        string lastFile = @"lastFile.txt";
        try
        {
            // Moving the file
            File.Move(movingFile, lastFile);
            Console.WriteLine(mainFile + " has been moved to " + lastFile);
        }
        catch (IOException ex)
        {
            Console.WriteLine(ex);
        }
        File.Delete(lastFile);
    }
}
