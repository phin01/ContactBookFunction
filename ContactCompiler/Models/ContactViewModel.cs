using DataAccessLibrary.Models;

namespace ContactBook.Models;

public class ContactViewModel : IContactModel
{
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}
