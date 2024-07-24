using Contacts_Angular_App.Data;
using Contacts_Angular_App.Models;
using Contacts_Angular_App.Models.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Contacts_Angular_App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        public ContactsDbContext _dbContext { get; }

        public ContactsController(ContactsDbContext contactsDbContext)
        {
            _dbContext = contactsDbContext;
        }


        [HttpGet]
        public IActionResult GetAllContacts()
        {
            var contacts = _dbContext.Contacts.ToList();

            return Ok(contacts);
        }

        [HttpPost]
        public IActionResult AddContact(AddContactRequestDTO contactRequest)
        {
            var domainModelContact = new Contact
            {
                Id = Guid.NewGuid(),
                Name = contactRequest.Name,
                Email = contactRequest.Email,
                Phone = contactRequest.Phone,
                Favorite = contactRequest.Favorite
            };

            _dbContext.Contacts.Add(domainModelContact);
            _dbContext.SaveChanges();

            return Ok(domainModelContact.Id);
        }
    }
}
