using System.Collections.Generic;

namespace AddressBook.Objects
{
  public class Contact
  {
    private static List<Contact> _contactList = new List<Contact> {};

    private string _name;
    private string _phoneNumber;
    private string _address;
    private int _id;


    public Contact(string name, string phoneNumber,
    string address)
    {
      _name = name;
      _phoneNumber = phoneNumber;
      _address = address;
      _contactList.Add(this);
      _id = _contactList.Count;
    }

    public string GetName()
    {
      return _name;
    }

    public void SetName(string name)
    {
      _name = name;
    }

    public string GetPhoneNumber()
    {
      return _phoneNumber;
    }

    public void SetPhoneNumber(string phoneNumber)
    {
      _phoneNumber = phoneNumber;
    }

    public string GetAddress()
    {
      return _address;
    }

    public void SetAddress(string address)
    {
      _address = address;
    }

    public int GetId()
    {
      return _id;
    }

    public static List<Contact> GetAll()
    {
      return _contactList;
    }

    public static void ClearAll()
    {
      _contactList.Clear();
    }

    public static Contact Find(int searchId)
    {
      return _contactList[searchId-1];
    }
  }
}
