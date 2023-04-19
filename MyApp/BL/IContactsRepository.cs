using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp
{
    public interface IContactsRepository
    {
        List<Contact> GetAll();
        Contact Get(int id);
        void Add(Contact contact);
        void Update(Contact contact, int id);
        bool Delete(int id);
        List<Contact> Search(string searchname, string searchlastname, string searchphone, string searchemail, string searchprivatenumber);
    }
}
