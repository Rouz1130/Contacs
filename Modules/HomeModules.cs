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


      Get]["/contact_new"] = _ => {
        return View["contact_new.cshtml"];
      };


      Get["/"]
