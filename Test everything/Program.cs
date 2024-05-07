namespace DSA
{
    class TestClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine(5 / 2);
        }

        public static int Print(int n)
        {
            if(n == 0)
                return 0;
            else
            {
                Console.WriteLine(n);
                return Print(n-1);
            }    
        }
    }
}