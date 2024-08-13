
using PatikaWeek5PracticeIMDBList;

// Creating an new object list
List<Movie> movieList = new List<Movie>();

while (true) // loop that will take data until the user finishes
{
    
    Console.WriteLine("Lütfen girmek istediğiniz filmin adını yazınız(Bitirmek istediğinizde lütfen q yazınız): ");
    string movieName = Console.ReadLine(); 

    if (movieName.ToLower() == "q") // The condition to end loop
    {
        break;
    }

    Console.WriteLine("Lütfen filmin imdb puanını yazınız: ");
    bool basarili = double.TryParse(Console.ReadLine(), out double imdbRate);

    if (basarili && imdbRate >= 0 && imdbRate <= 10) // Checking the data whether it is double and between 4 and 9
    {
        Movie movie = new Movie(imdbRate, movieName);
        movieList.Add(movie); // Adding movie object to the list 

    }

    else
    {
        Console.WriteLine("Hatalı giriş yaptınız! Lütfen 0 ile 10 arasında geçerli bir imdb puanı giriniz.");
    }
}

Console.WriteLine("----- Tüm Filmler -----"); // Display all movie
foreach (var movie in movieList) 
{
    movie.DisplayAllMovies();
}

Console.WriteLine("----- İmdb Puanı 4 ve 9 Arasındaki Filmler -----");
foreach (var movie in movieList) // Display movies that imdb rate between 4 and 9
{
    movie.DisplayOnly4Between9();
}

Console.WriteLine("------- A Harfi ile Başlayan Filmler --------"); 
foreach (var movie in movieList) // Display movies that start with letter "A"
{
    movie.DisplayStartingLetterA();
}