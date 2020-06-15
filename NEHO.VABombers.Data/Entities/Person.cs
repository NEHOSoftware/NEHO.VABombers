using System;

namespace NEHO.VABombers.Data.Entities
{
  public class Person
  {
    public int Id { get; set; }
    public string FullName { get; set; }
    public string GivenName { get; set; }
    public string CommonName { get; set; }
    public string MiddleName { get; set; }
    public string LastName { get; set; }
    public string Suffix { get; set; }
    public string Nickname { get; set; }
    public DateTime? Birthdate { get; set; }
    public Address HomeAddress { get; set; }
    public string EmailAddress { get; set; }
    public string PhoneNumber { get; set; }
  }
}