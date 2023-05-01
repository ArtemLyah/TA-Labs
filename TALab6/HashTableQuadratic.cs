using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TALab6
{
    public class HashTableQuadratic<T>
    {
        public Person[] items;
        public int actualSize = 0;
        public HashTableQuadratic(int size)
        {
            items = new Person[size];
        }
        public int Add(Person item)
        {

            var key = GetHash(item);
            if (items[key] != null)
            {
                int counter = 0;
                int step = 0;
                int changeableKey = key;
                do
                {
                    if (items[changeableKey].Surname == item.Surname && items[changeableKey].Name == item.Name)
                        return 0;
                    if (items[changeableKey].Surname == "**********")
                    {
                        items[changeableKey] = item;
                        actualSize++;
                        return 1;
                    }
                    step = (int)Math.Pow(counter, 2);
                    counter++;
                    changeableKey = (key + step) % items.Length;
                } while (items[changeableKey] != null);
                items[changeableKey] = item;
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
            int step;
            int changeableKey;
            do
            {
                counter++;
                step = (int)Math.Pow(counter, 2);
                changeableKey = (key + step) % items.Length;
                if (items[changeableKey] == null)
                    return null;
            } while (items[changeableKey].Surname != item.Surname || items[changeableKey].Name != item.Name);
            return items[changeableKey];
        }
        public int Delete(Person item)
        {
            var key = GetHash(item);
            int counter = -1;
            int step; 
            int changeableKey;
            do
            {
                counter++;
                step = (int)Math.Pow(counter, 2);
                changeableKey = (key + step) % items.Length;
                if (items[changeableKey] == null)
                    return -1;
            } while (items[changeableKey].Surname != item.Surname || items[changeableKey].Name != item.Name);
            items[key + step] = new Person("**********", null);
            actualSize--;
            return 1;
        }
        public int GetHash(Person item)
        {
            return item.Key % items.Length;
        }
    }
}
