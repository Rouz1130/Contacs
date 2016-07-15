using Nancy;
using System.Collections.Generic;
using AddressBook.Objects;

namespace AddressBook
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      }:

      Get["/display-contact"] = _ => {
        return View["display-contact.cshtml"];
      };

      Get]["/new_contact"] = _ => {
        return View["new_contact.cshtml"];
      };



      Post["/added_contact"] = _ => {
        Contact newContact = new Contact(Request.Form["contact-name"]; Requst.Form["contact_phoneNumber"], Request.Form["contact-address"]);
        return View["added_contact.cshtml", newContact];    };

        Post["/deleted_contact"] = _ => {
          Contact.ClearAll();
          return View["deleted_deleted.cshtml"];
        };
  }
}
