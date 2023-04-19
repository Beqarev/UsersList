using MyApp.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp
{
    public class ContactRepository : IContactsRepository
    {
        //DbContext _dbContext = new DbContext(); 
        SqlDbContext _dbContext = new SqlDbContext();
        public List<Contact> GetAll()
        {
            return _dbContext.GetContacts();
        }

        public Contact Get(int id)
        {
            return _dbContext.GetContactById(id);
        }
        public void Add(Contact contact)
        {
            _dbContext.AddContact(contact);
        }
        public void Update(Contact contact, int id)
        {
            _dbContext.UpdateConatact(contact, id);
        }
        public bool Delete(int id)
        {
            return _dbContext.DeleteConatact(id);
        }

        public List<Contact> Search(string searchname, string searchlastname, string searchphone, string searchemail, string searchprivatenumber)
        {
            return _dbContext.SearchContact(searchname, searchlastname, searchphone, searchemail, searchprivatenumber);
        }

    }
}
