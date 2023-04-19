using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyApp
{
    public partial class AddForm : Form
    {
        bool isNewRecord = false;
        ContactsForm _contactsForm = null;
        ContactRepository contactRepository = new ContactRepository();
        int id = 0;
        public AddForm(ContactsForm contactsForm, Contact contact, bool isNewRecord, int id)
        {
            InitializeComponent();
            if (isNewRecord)
            {
                btnDelete.Visible = false;
            }
            _contactsForm = contactsForm;

            if (contact != null) 
            {
                FillConatctForm(contact);
            }
            this.isNewRecord = isNewRecord;
            this.id = id;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Contact contact = new Contact();
            contact.Id = id;
            contact.Phone = txtPhone.Text;
            contact.FirstName = txtFirstName.Text;
            contact.LastName = txtLastName.Text;
            contact.PrivateNumber = txtPrivateNumber.Text;
            contact.Email = txtEmail.Text;
            contact.Age = Convert.ToInt32(txtAge.Text);

            if (isNewRecord)
            {
                contactRepository.Add(contact);
            }
            else
            {
                contactRepository.Update(contact, id);
            }
            CloseForm();
            _contactsForm.ReadData();
        }

        

        private void CloseForm()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtPrivateNumber.Text = "";
            txtEmail.Text = "";
            txtAge.Text = "";
            this.Close();
        }

        private void FillConatctForm(Contact contact)
        {
            txtFirstName.Text = contact.FirstName;
            txtLastName.Text = contact.LastName;
            txtPrivateNumber.Text = contact.PrivateNumber;
            txtPhone.Text = contact.Phone;
            txtEmail.Text = contact.Email;
            txtAge.Text = contact.Age.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool result = contactRepository.Delete(id);
            if (result)
            {
                _contactsForm.ReadData();
                CloseForm();
            }
        }

        
    }
}
