using Nancy;
using System.Collections.Generic;
using AdressBook.Objects;

namespace AddressBookApp
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };

      Get["/address/form"] = _ => {
        return View["address_form.cshtml"];
      };

      Post["/contact/new"] = _ => {
        var newContact = new Contact(Request.Form["contact-name"], Request.Form["address"], Request.Form["phone-number"]);
        List<Contact> allContacts = Contact.GetAll();
        return View["contact_new.cshtml", AllContacts];
      }

    };
  }
}
