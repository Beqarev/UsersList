using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MyApp
{

    public partial class ContactsForm : Form
    {
        private bool IsNewRecord { get; set; } = false;

        ContactRepository contactRepository = new ContactRepository();
        public ContactsForm()
        {
            InitializeComponent();
            ReadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IsNewRecord = true;
            AddForm addForm = new AddForm(this, null, IsNewRecord, 0);
            addForm.ShowDialog();
        }

        public void ReadData()
        {
            contactsGrid.DataSource = contactRepository.GetAll();
        }

        private void contactsGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                IsNewRecord = false;
                DataGridView dgv = sender as DataGridView;
                if (dgv == null) return;
                int id = int.Parse(dgv.CurrentRow.Cells[0].Value.ToString());
                var contact = contactRepository.Get(id);
                AddForm addForm = new AddForm(this, contact, IsNewRecord, id);
                addForm.ShowDialog();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //string search = txtSearch.Text;
            //if (string.IsNullOrEmpty(search))
            //{
            //    ReadData();
            //}
            //else
            //{
            //    var result = contactRepository.Search(search);
            //    contactsGrid.DataSource = result;
            //}

            string searchname = txtSearchFirstName.Text;
            string searchlastname = txtSearchLastName.Text;
            string searchemail = txtSearchEmail.Text;
            string searchphone = txtSearchPhone.Text;
            string searchprivatenumber = txtSearchPrivateNumber.Text;
            
            if(string.IsNullOrEmpty(searchname) && string.IsNullOrEmpty(searchlastname) && string.IsNullOrEmpty(searchemail) && string.IsNullOrEmpty(searchphone) && string.IsNullOrEmpty(searchprivatenumber))
            {
                ReadData();
            }
            else
            {
                var result = contactRepository.Search(searchname, searchlastname, searchphone, searchemail, searchprivatenumber);
                contactsGrid.DataSource = result;
            }

        }
    }


}
