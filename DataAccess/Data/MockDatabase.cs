using DataAccessLibrary.Models;

namespace DataAccessLibrary.Data;

public class MockDatabase : IDatabase
{
    List<IContactModel> _contacts;
    public MockDatabase()
    {
        _contacts = new List<IContactModel>();
    }

    public void AddContacts(IEnumerable<IContactInputModel> contacts)
    {
        foreach (var contact in contacts)
        {
            AddContact(contact);
        }
    }

    public IEnumerable<IContactModel> GetAllContacts()
    {
        return _contacts;
    }

    private void AddContact(IContactInputModel contact)
    {
        ContactModel contactModel = new ContactModel
        {
            Id = Guid.NewGuid(),
            FirstName = contact.FirstName,
            LastName = contact.LastName
        };

        _contacts.Add(contactModel);
    }

}
