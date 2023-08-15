namespace HomeWork5
{
    enum StoreType
    {
        Grocery,
        Household,
        Clothing,
        Shoes
    }

    internal class Store : IDisposable
    {
        public string? Name { get; set; }
        public string? Address { get; set; }
        public StoreType Type { get; set; }

        public Store(string? name, string? address, StoreType type)
        {
            Name = name;
            Address = address;
            Type = type;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}.\nAddress: {Address}.\nType: {Type},");
        }



        public void Dispose()
        {
            Console.WriteLine($"\nStore '{Name}' is being disposed.");
        }

        //~Store()
        //{
        //    Console.WriteLine($"\nStore '{Name}' is being disposed.");
        //}
    }
}
