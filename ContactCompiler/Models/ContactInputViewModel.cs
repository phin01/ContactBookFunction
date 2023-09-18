using DataAccessLibrary.Models;

namespace ContactBook.Models;

public class ContactInputViewModel : IContactInputModel
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
}
