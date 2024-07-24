using Contacts_Angular_App.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace Contacts_Angular_App.Data
{
    public class ContactsDbContext : DbContext
    {
        public ContactsDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Contact> Contacts { get; set; }
    }
}
