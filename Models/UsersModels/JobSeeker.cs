namespace Kursach.Models.UsersModels
{
    public class JobSeeker
    {
        public int Id { get; set; }     
        public string IdentityId { get; set; }   
        public AppUser Identity { get; set; }  
        public string Location {get; set;}
    }
}