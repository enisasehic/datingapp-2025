namespace API.Entities; //entities typically relates to the tables in databases
//ORM - An object relational mapper
//translates our code into sql commands that update our tables in the database

public class AppUser // for auth and currentUser, will have relation with member
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public required string DisplayName { get; set; }
    public required string Email { get; set; }
    public string? ImageUrl { get; set; }
    public required byte[] PasswordHash {get; set;}
    public required byte[] PasswordSalt {get; set;}

    // Nav property
    public Member Member { get; set; } = null!;

}
