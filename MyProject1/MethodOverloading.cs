using System;


    class MethodOverloading
    {
        public void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public void Add(float x, float y)
        {
            Console.WriteLine(x + y);
        }
        public void Add(string s1, string s2)
        {
            Console.WriteLine(s1 +" "+ s2);
        }
        static void Main(string[] args)
        {
            MethodOverloading obj = new MethodOverloading();
            obj.Add(10, 20);
            obj.Add(10.5f, 20.5f);
            obj.Add("Prathiksha", "Naik");
            Console.ReadKey();
        }
    }
