namespace JokesWebApp.Models
{
    using Microsoft.AspNetCore.Identity;

    public class Joke
    {
        public int Id { get; set; }
     
        public string JokeQuestion { get; set; }
        public string JokeAns { get; set; }

        public Joke()
        {
            
        }

    }
}
