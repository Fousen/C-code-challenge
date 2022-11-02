using System;
using System.Collections.Generic;

namespace Assesment
{
    public class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Cast { get; set; }
        public double TicketPrice { get; set; }

        public Movie(string title, string cast, double price)
        {
            Title = title;
            Cast = cast;
            TicketPrice = price;
        }
    }
    public class Ticket
    {
        public Movie Movie { get; set; }
        public DateTime BookingDate { get; set; }
        public int TicketCount { get; set; }
        public double TotalAmount { get; set; }
       
        public Ticket(DateTime bookingDate, int ticketCount, Movie selectedMovie, double totalAmount)
        {
            BookingDate = bookingDate;
            TicketCount = ticketCount;
            TotalAmount = totalAmount;
        }
    }
    public class Program
    {
        public static List<Movie> moviesList = new List<Movie>();
        public static List<Ticket> ticketsList = new List<Ticket>();

        static void Main(string[] args)
        {
            Default();
            System.Console.WriteLine("********************************\n" +
                          "MOVIE TICKET BOOKING APPLICATION\n" +
                          "********************************");

            System.Console.WriteLine("Please provide movie cast names");
            string movieTitle = "", movieCast = "";
            double ticketPrice = 0;
            foreach (Movie movie in moviesList)
            {
                System.Console.WriteLine($"{movie.ID}. {movie.Title}");
            }

            try
            {
                System.Console.Write("Dear viewer, please enter the movie name you want to watch\n\n");
                movieTitle = Console.ReadLine().ToLower();
                System.Console.Write("Enter the cast names (Cast names seperated by comma) ");
                movieCast = Console.ReadLine();
                System.Console.Write("Enter the ticket price : ");
                ticketPrice = double.Parse(Console.ReadLine());
                if (movieCast == "")
                {
                    throw new Exception("Movie cast cannot be empty. Please provide valid value");
                }
                if (movieTitle == "")
                {
                    throw new Exception("Movie title cannot be empty. Please provide valid value");
                }
                if (ticketPrice == 0)
                {
                    throw new Exception("Incorrect value for Movie price. Please provide valid value");
                }
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.Message);
                Main(args);
            }
            foreach (Movie movie in moviesList)
            {
                if (movie.Title.Equals(movieTitle))
                {
                    System.Console.WriteLine($"Dear Viewer you have chosen to watch : {movie.ID}");
                    System.Console.WriteLine($"Movie Name : {movie.Title}\nMovie Cast : {movie.Cast}\nTicket Price : {movie.TicketPrice}");
                    System.Console.WriteLine("Do you want to buy ticket for this movie (yes or no)");
                    string choice = Console.ReadLine().ToLower();
                    if (choice.Equals("yes"))
                    {
                        System.Console.WriteLine("Please enter the date on which you want to buy the tickets in dd/mm/yyyy");
                        DateTime bookingDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
                        System.Console.WriteLine("How many tickets do you want ?");
                        int ticketCount = int.Parse(Console.ReadLine());
                        System.Console.WriteLine("Dear viewers your movie details are as follows :");
                        double totalAmount = ticketCount * movie.TicketPrice;
                        BuyTickets(bookingDate,ticketCount,movie,totalAmount);
                        //ticketsList.Add(ticket);
                        System.Console.WriteLine($"Movie name : {movie.Title}\nBooking date : {bookingDate}\nTotal price : {totalAmount}");
                        System.Console.WriteLine("Thank you enjoy your movie, Have a great day!");
                    }
                }
            }
        }

        public static Movie CreateMovie(string title, string cast, double price)
        {
            Movie movie = new Movie(title, cast, price);
            return movie;
        }
        public static Ticket BuyTickets(DateTime bookingDate, int ticketCount, Movie selectedMovie, double totalAmount)
        {
            Ticket ticket = new Ticket(bookingDate, ticketCount, selectedMovie, totalAmount);
            ticketsList.Add(ticket);
            return ticket;
        }
        public static void Default()
        {
            Movie movie = new Movie("bigil", "Vijay,Nayanthara", 100);
            Movie movie1 = new Movie("darbar", "Rajini,sunil", 100);
            Movie movie2 = new Movie("pattas", "Dhanush,Sneha", 100);
            moviesList.Add(movie);
            moviesList.Add(movie1);
            moviesList.Add(movie2);
        }
    }
}

    