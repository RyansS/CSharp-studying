using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassIndexer
{
    class TelefonicAgend
    {
        private Dictionary<string, string> contacts = new Dictionary<string, string>();

        public string this[string name]
        {
            get
            {
                if (contacts.ContainsKey(name))
                {
                    return contacts[name];
                }
                else
                {
                    return "Contact wasn't found";
                }
            }

            set
            {
                contacts[name] = value;
            }
        }
    }
}
