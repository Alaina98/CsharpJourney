using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    internal class phoneBook
    {
        private string[] name;
        private string[] phoneNumbers;
        int size;
        int counter = 0;

        public phoneBook(int size)
        {
            this.size = size;
            this.name = new string[this.size];
            this.phoneNumbers = new string[this.size];
        }
        public string  this[int idx  , string name] { 
            get {
                for (int i = 0; i < size; i++)
                {
                    if (this.name[i] == name)
                    {
                        return phoneNumbers[i];
                    }

                }
                return "Not found";
            }
            
            set {
                phoneNumbers[idx] = value;
                this.name[idx] = name;
            
            } }
        public string this[string name]
        {
            get
            {
                for (int i = 0; i < size; i++)
                {
                    if (this.name[i] == name)
                    {
                        return this.phoneNumbers[i];
                    }
                }
                return "notfound";
            }
        }
        public void setValues(int index, string name, string numbers)
        {
            //validation
            if ((index > 0) && (index < size) && (index > counter))
            {
                this.phoneNumbers[index] = numbers;
                this.name[index] = name;
                counter++;
            }
        }

        public string getValue(string name)
        {
            //? for check
            for (int i = 0; i < name?.Length; i++)
            {
                if (this.name[i] == name)
                {
                    return phoneNumbers[i];
                }


            }
            return "not found";

        }
    }
}
