using ContactBook.Models;

namespace ContactBook.Controllers;

public class ContactValidator : IContactValidator
{
    public List<ContactInputViewModel> GetValidContacts(List<ContactInputViewModel> contacts)
    {
        List<ContactInputViewModel> validContacts = new();

        foreach (ContactInputViewModel contact in contacts)
        {
            if (IsContactValid(contact))
            {
                validContacts.Add(contact);
            }
        }

        return validContacts;

    }

    private bool IsContactValid(ContactInputViewModel contact)
    {
        if (contact.FirstName != null && contact.LastName != null)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
