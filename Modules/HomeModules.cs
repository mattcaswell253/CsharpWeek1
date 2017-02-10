using Nancy;
using System.Collections.Generic;
using AddressBook.Objects;

namespace AddressBookApp
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        List<Contact> contactList = Contact.GetAll();
        return View["index.cshtml"];
      };

      Get["/address/form"] = _ => {
        return View["address_form.cshtml"];
      };

      Post["/contact/new"] = _ => {
        var newContact = new Contact(Request.Form["contact-name"], Request.Form["address"], Request.Form["phone-number"]);
        return View["contact_new.cshtml", newContact];
      };

    }
  }
}
