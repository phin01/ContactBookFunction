namespace DataAccessLibrary.Models
{
    public interface IContactModel
    {
        string FirstName { get; set; }
        Guid Id { get; set; }
        string LastName { get; set; }
    }
}