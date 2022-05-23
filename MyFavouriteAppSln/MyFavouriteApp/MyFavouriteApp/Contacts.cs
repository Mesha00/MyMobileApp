using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavouriteApp
{
    public class Contacts
    {
        public Contacts()
        {

        }
        public Contacts(string name,DateTime lastSeen)
        {
            Name = name;
            LastSeen = lastSeen;
        }

        public string Name { set; get; }

        public DateTime LastSeen { set; get; }
    }
}
