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
using MongoDB.Bson;
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
                contact.Image = ImageToBytes(IDE_PROFILE_PIC_BOX.Image);
                m_collection.InsertOne(contact);

                MessageBox.Show("New contact added");
                IDE_NAME.Text = "";
                IDE_NUMBER.Text = "";
                IDE_PROFILE_PIC_BOX.Image = null;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public byte[] ImageToBytes(Image image)
        {
            using (var ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }

        public Image BytesToImage(byte[] byteArray)
        {
            using (var ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }


        private void IDB_SELECT_IMAGE_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Select Image";
                dlg.Filter = "jpg files (*.jpg)|*.jpg";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    IDE_PROFILE_PIC_BOX.Image = new Bitmap(dlg.FileName);
                }
            }
        }

        private void IDE_LOAD_IMAGE_Click(object sender, EventArgs e)
        {
            try
            {
                Contact _con = m_collection.Find(x => x._id == new ObjectId(IDE_LOAD_ID.Text)).FirstOrDefault();
                IDE_PROFILE_PIC_BOX.Image = BytesToImage(_con.Image);
            }
            catch(Exception ex)
            {

            }
        }

        private void IDB_CLEAR_Click(object sender, EventArgs e)
        {
            IDE_PROFILE_PIC_BOX.Image = null;
        }
    }
}
