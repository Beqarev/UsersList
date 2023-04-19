using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MyApp.DAL
{
    public  class DbContext
    {
        string path = @"D:\DB.txt";
        List<Contact> contactList = new List<Contact>();
        public List<Contact> GetContacts()
        {
            using (StreamReader reader = new StreamReader(path))
            {
                contactList.Clear();
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var _contacts = line.Split(' ');
                    Contact contact = new Contact();
                    contact.FirstName = _contacts[0];
                    contact.LastName = _contacts[1];
                    contact.PrivateNumber = _contacts[2];
                    contact.Email = _contacts[3];
                    contact.Age = int.Parse(_contacts[4]);
                    contactList.Add(contact);
                }
            }
            return contactList.ToList();
        }

        public Contact GetContactById(int id)
        {
            return contactList[id];
        }

        public Contact GetContactByPn(string pn)
        {
            return contactList.FirstOrDefault(x=>x.PrivateNumber==pn);
        }

        public void AddConatact(Contact contact) 
        {
            string content = $"{contact.FirstName} {contact.LastName} {contact.PrivateNumber} {contact.Email} {contact.Age}";
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(content);
            }
        }

        public void UpdateConatact(Contact contact, int id)
        {
            GetContacts();
            var _contact = GetContactById(id);
            

            contactList.Remove(_contact);
            contactList.Add(contact);
            File.Delete(path);
            using (StreamWriter sw = File.AppendText(path))
            {
                foreach (var item in contactList)
                {
                    string content = $"{item.FirstName} {item.LastName} {item.PrivateNumber} {item.Email} {item.Age}";
                    sw.WriteLine(content);
                }
            }
        }

        public bool DeleteConatact(string pn)
        {
            GetContacts();
            var _contact = GetContactByPn(pn);
            bool result = contactList.Remove(_contact);
            if (result)
            {
                File.Delete(path);
                using (StreamWriter sw = File.AppendText(path))
                {
                    foreach (var item in contactList)
                    {
                        string content = $"{item.FirstName} {item.LastName} {item.PrivateNumber} {item.Email} {item.Age}";
                        sw.WriteLine(content);
                    }
                }
                return true;
            }
            return false;
        }

    }
}
