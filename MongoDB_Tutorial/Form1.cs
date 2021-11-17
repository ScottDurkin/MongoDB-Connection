using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;

namespace MongoDB_Tutorial
{
    public partial class Form1 : Form
    {
        MongoClient m_Client;
        IMongoDatabase m_Database;
        IMongoCollection<Contact> m_collection;

        public Form1()
        {
            InitializeComponent();

            m_Client = new MongoClient("Connection String");
            m_Database = m_Client.GetDatabase("Database Name");
            m_collection = m_Database.GetCollection<Contact>("Collection Name");
        }

        private void IDB_SAVE_Click(object sender, EventArgs e)
        {
            try
            {
                Contact contact = new Contact();

                contact.Name = IDE_NAME.Text;
                contact.PhoneNumber = Convert.ToInt32(IDE_NUMBER.Text);

                m_collection.InsertOne(contact);

                MessageBox.Show("New contact added");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
