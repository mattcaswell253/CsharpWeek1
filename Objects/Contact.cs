using System.Collections.Generic;

namespace AddressBook.Objects
{
  public class Contact
  {
    private static List<Contact> _contactList = new List<Contact> {};

    private string _name;
    private string _phone_number;
    private string _address;
    private int _id;


    public Contact(string newName, string newPhoneNumber,
    string newAddress)
    {
      _name = newName;
      _phone_number = newPhoneNumber;
      _address = newAddress;
      _contactList.Add(this);
      _id = _contactList.Count;
    }

    public string GetName()
    {
      return _name;
    }

    public void SetName(string newName)
    {
      _name = newName;
    }

    public string GetPhoneNumber()
    {
      return _phone_number;
    }

    public void SetPhoneNumber(string newPhoneNumber)
    {
      _phone_number = newPhoneNumber;
    }

    public string GetAddress()
    {
      return _address;
    }

    public void SetAddress(string newAddress)
    {
      _address = newAddress;
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
