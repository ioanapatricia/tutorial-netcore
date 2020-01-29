namespace DatingApp.API.Models
{
    public class Like
    {
        public int LikerId { get; set; } // the user's id that likes another user 
        public int LikeeId { get; set; } // the user's id that is being liked by another user 
        public User Liker { get; set; }
        public User Likee { get; set; }
    }
}