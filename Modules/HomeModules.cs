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
      var contactList = Contact.GetAll();
        return View["index.cshtml", contactList];
      };

      Get["/address/form"] = _ => {
        return View["address_form.cshtml"];
      };

      Post["/contact/new"] = _ => {
        var newContact = new Contact(Request.Form["contact-name"], Request.Form["address"], Request.Form["phone-number"]);
        return View["contact_new.cshtml", newContact];
      };

      Get["/contacts/{id}"] = parameters => {
        var contact = Contact.Find(parameters.id);
        return View["view_contact.cshtml", contact];
      };

      Post["/contacts/clear"] = _ => {
      Contact.ClearAll();
      return View["contacts_cleared.cshtml"];
    };
    }
  }
}
