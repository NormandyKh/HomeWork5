namespace HomeWork5
{
    internal class Program
    {
        static void Main()
        {
            using (Play play1 = new("Romeo and Juliet", "William Shakespeare", "Tragedy", 1597))
            using (Play play2 = new("My thoughts, my thoughts, I am in trouble with you!", "Taras Shevchenko", "Poem", 1840))
            {
                Console.WriteLine("Play 1:");
                play1.DisplayInfo();


                Console.WriteLine("Play 2:");
                play2.DisplayInfo();
            }

            using (Store store1 = new("Tavria V", "Independence Avenue 125", StoreType.Grocery))
            using (Store store2 = new("Kopiyka", "Shopping street 35", StoreType.Household))
            {
                Console.WriteLine("Store 1:");
                store1.DisplayInfo();

                Console.WriteLine("Store 2:");
                store2.DisplayInfo();
            }
            
            Console.ReadKey();
        }
    }
}