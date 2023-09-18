using ContactBook.Models;

namespace ContactBook.Controllers
{
    public interface IContactValidator
    {
        List<ContactInputViewModel> GetValidContacts(List<ContactInputViewModel> contacts);
    }
}