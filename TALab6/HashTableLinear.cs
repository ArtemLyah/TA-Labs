using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TALab6
{
    public class HashTableLinear<T>
    {
        public Person[] items;
        public int actualSize = 0;
        public HashTableLinear(int size)
        {
            items = new Person[size];
        }
        public int Add(Person item)
        {
            
            var key = GetHash(item);
            if (items[key] != null)
            {
                int counter = 0;
                int changeableKey = key;
                do
                {
                    if (items[changeableKey + counter].Surname == item.Surname && items[changeableKey + counter].Name == item.Name)
                        return 0;
                    if (items[changeableKey + counter].Surname == "**********")
                    {
                        items[changeableKey + counter] = item;
                        actualSize++;
                        return 1;
                    }
                    counter++;
                    if(changeableKey + counter > items.Length - 1)
                    {
                        changeableKey = 1;
                        counter = 0;
                    }
                } while (items[changeableKey + counter] != null);
                items[changeableKey + counter] = item;
                actualSize++;
                return 1;
            }
            else
            {
                items[key] = item;
                actualSize++;
                return 1;
            }
        }
        public Person Search(Person item)
        {
            var key = GetHash(item);
            int counter = -1;
            do
            {
                counter++;
                if (key + counter > items.Length - 1)
                {
                    key = 1;
                    counter = 0;
                }
                if (items[key + counter] == null)
                    return null;

            } while (items[key + counter].Surname != item.Surname || items[key + counter].Name != item.Name);
            return items[key + counter];
        }
        public int Delete(Person item)
        {
            var key = GetHash(item);
            int counter = -1;
            do
            {
                counter++;
                if (key + counter > items.Length - 1)
                {
                    key = 1;
                    counter = 0;
                }
                if (items[key + counter] == null)
                    return -1;

            } while (items[key + counter].Surname != item.Surname || items[key + counter].Name != item.Name);
            items[key + counter] = new Person("**********", null);
            actualSize--;
            return 1;
        }
        public int GetHash(Person item)
        {
            return item.Key % items.Length;
        }
    }
}
