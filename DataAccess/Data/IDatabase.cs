using DataAccessLibrary.Models;

namespace DataAccessLibrary.Data
{
    public interface IDatabase
    {
        void AddContacts(IEnumerable<IContactInputModel> contacts);
        IEnumerable<IContactModel> GetAllContacts();
    }
}