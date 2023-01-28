using Domain.Dtos;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;
[ApiController]
[Route("[controller]")]
public class ContactController
{
    private ContactServices _contactServices;

    public ContactController()
    {
        _contactServices = new ContactServices();
    }

    [HttpGet]
    public List<ContactDto> GetContact()
    {
       return _contactServices.GetContact();
    }

    [HttpGet("GetContactByName")]
    public List<ContactDto> GetContactByName(string name)
    {
        return _contactServices.GetContactByName(name);
    }

    [HttpPost]
    public bool AddContact(ContactDto contactDto)
    {
        return _contactServices.AddContact(contactDto);
    }

    [HttpPut]
    public bool UpdateContact(ContactDto contactDto)
    {
      return  _contactServices.UpdateContact(contactDto);
    }

    [HttpDelete]
    public bool DeleteContact(int id)
    {
      return _contactServices.DeleteContact(id);
    }
}