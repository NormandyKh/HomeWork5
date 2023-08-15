namespace HomeWork5
{
    internal class Play: IDisposable
    {
        public string? Title { get; set; }
        public string? Author { get; set; }
        public string? Genre { get; set; }
        public int Year { get; set; }


        public Play(string? title, string? author, string? genre, int year)
        {
            Title = title;
            Author = author;
            Genre = genre;
            Year = year;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Title: {Title}.\nAuthor: {Author}.\nGenre: {Genre}.\nYear: {Year}.");
        }

        public void Dispose()
        {
            Console.WriteLine($"\nPlay '{Title}' is being disposed.");
        }


        //~Play()
        //{
        //    Console.WriteLine($"Play {Title} is being destructted ");
        //}
    }
}
