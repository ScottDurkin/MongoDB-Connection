using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDB_Tutorial
{
    public class Contact
    {
        public ObjectId _id { get; set; }
        public String Name { get; set; }
        public int PhoneNumber { get; set; }
    }
}
