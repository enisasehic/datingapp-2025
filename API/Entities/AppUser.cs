namespace API.Entities; //entities typically relates to the tables in databases
//ORM - An object relational mapper
//translates our code into sql commands that update our tables in the database

public class AppUser
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public required string DisplayName { get; set; }
    public required string Email { get; set; }
}
