using MoviesLab;
bool runProgram = true;
List<Movie> MovieList = new List<Movie>()
{
    new Movie("Star Wars I", "scifi"),
    new Movie("Star Wars II", "scifi"),
    new Movie("Star Wars III", "scifi"),
    new Movie("Saw I", "horror"),
    new Movie("Scream", "horror"),
    new Movie("Finding Nemo", "animated"),
    new Movie("How To Train Your Dragon", "animated"),
    new Movie("Les Mis", "drama"),
    new Movie("House: The Movie", "drama"),
    new Movie("Rugrats Go to Paris", "animated")
};

Console.WriteLine("Welcome to the movie store, a thing that still totally exists.");

while (runProgram)
{
    while (true)
    {
    Console.WriteLine("What kind of movie are you looking for? We carry animated, scifi, horror, and drama films.");
    string genre = Console.ReadLine().ToLower().Trim();
        if (MovieList.Where(m => m.Category == genre).Count() > 0)
        {
            foreach (Movie m in MovieList)
            {
                if (genre == m.Category)
                {
                    Console.WriteLine(m.Title);
                }
            }
            break;
        }
        else
        {
            Console.WriteLine("We don't carry that genre");
        }
    }
    runProgram = Movie.GetContinue();
}
