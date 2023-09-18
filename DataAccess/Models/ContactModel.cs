﻿namespace DataAccessLibrary.Models;

public class ContactModel : IContactModel
{
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}
