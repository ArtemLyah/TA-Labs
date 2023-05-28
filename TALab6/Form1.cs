using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TALab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private static int hashTableSize = 24;
        public HashTableLinear<Person> hashTable = new HashTableLinear<Person>(hashTableSize);
        public HashTableQuadratic<Person> hashTable2 = new HashTableQuadratic<Person>(hashTableSize);
        public void ListOverwrite1(ListBox listbox)
        {
            listbox.Items.Clear();
            int counter = 0;
            for (int i = 0; i < hashTable.items.Length; i++)
            {
                if (hashTable.items[i] == null)
                    continue;
                if (hashTable.items[i].Surname == "**********")
                    continue;
                listbox.Items.Insert(counter, hashTable.items[i].Key.ToString());
                counter++;
            }
        }
        public void ListOverwrite2(ListBox listbox)
        {
            listbox.Items.Clear();
            int counter = 0;
            for (int i = 0; i < hashTable2.items.Length; i++)
            {
                if (hashTable2.items[i] == null)
                    continue;
                if (hashTable2.items[i].Surname == "**********")
                    continue;
                listbox.Items.Insert(counter, hashTable2.items[i].Key.ToString());
                counter++;
            }
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            string path = @"..\..\TextFiles\Girls.txt";
            var lines = File.ReadLines(path);
            foreach (var line in lines)
            {
                var personData = line.Split(' ');
                hashTable.Add(new Person(personData[0], personData[1], personData[2]));
                hashTable2.Add(new Person(personData[0], personData[1], personData[2]));
            }
            ListOverwrite1(listBoxKeysFirst);
            ListOverwrite2(listBoxKeysSecond);
            MessageBox.Show("Для пошуку в таблиці чи видалення з таблиці введіть прізвище та ім'я (саме в такому порядку!)\n\nДля додаваня до таблиці введіть прізвище, ім'я та дату народження (саме в такому порядку!)");
            textBoxInputFirst.Enabled = true;
            textBoxInputSecond.Enabled = true;
            btnAddFirst.Enabled = true;
            btnAddSecond.Enabled = true;
            btnSearchFirst.Enabled = true;
            btnSearchSecond.Enabled = true;
            btnDeleteFirst.Enabled = true;
            btnDeleteSecond.Enabled = true;
            btnSaveFirst.Enabled = true;
            btnSaveSecond.Enabled = true;
            btnUploadFirst.Enabled = true;
            btnUploadSecond.Enabled = true;
            btnRandomize.Enabled = true;
            btnReset.Enabled = true;
            btnStart.Visible = false;
        }

        private void btnSearchFirst_Click(object sender, EventArgs e)
        {
            listBoxOutputFirst.Items.Clear();
            var line = textBoxInputFirst.Text;
            var personData = line.Split(' ');
            if (personData.Length < 2)
                MessageBox.Show("Введено некоректні дані!");
            else
            {
                Person person = hashTable.Search(new Person(personData[0], personData[1]));
                if (person == null)
                    MessageBox.Show("Людину не знайдено!");
                else
                {
                    MessageBox.Show("Людину знайдено!");
                    listBoxOutputFirst.Items.Insert(0, "Прізвище: " + person.Surname);
                    listBoxOutputFirst.Items.Insert(1, "Ім'я: " + person.Name);
                    listBoxOutputFirst.Items.Insert(2, "Дата народження: " + person.Birthday);
                }
            }
        }

        private void btnAddFirst_Click(object sender, EventArgs e)
        {
            listBoxOutputFirst.Items.Clear();
            var line = textBoxInputFirst.Text;
            var personData = line.Split(' ');
            if (personData.Length < 3)
                MessageBox.Show("Введено некоректні дані!");
            else
            {
                if (hashTable.actualSize * 100 / hashTable.items.Length > 90)
                {
                    hashTable = RehashHashTable(hashTable);
                    if(hashTable.actualSize == hashTableSize)
                    {
                        MessageBox.Show("Хеш-таблицю заповнено!");
                        return;
                    }
                }
                int variant = hashTable.Add(new Person(personData[0], personData[1], personData[2]));
                if (variant == 1)
                {
                    MessageBox.Show("Успішно додано до таблиці!");
                    ListOverwrite1(listBoxKeysFirst);
                }
                if (variant == 0)
                    MessageBox.Show("Людину вже додано до таблиці!");
            }
        }

        private void btnDeleteFirst_Click(object sender, EventArgs e)
        {
            listBoxOutputFirst.Items.Clear();
            var line = textBoxInputFirst.Text;
            var personData = line.Split(' ');
            int variant = hashTable.Delete(new Person(personData[0], personData[1]));
            if (variant == -1)
                MessageBox.Show("Людину не знайдено!");
            else
            {
                MessageBox.Show("Успішно видалено!");
                ListOverwrite1(listBoxKeysFirst);
            }
        }
        public HashTableLinear<Person> RehashHashTable(HashTableLinear<Person> hashTable)
        {
            var hashTableNew = new HashTableLinear<Person>(hashTable.items.Length);
            foreach (var item in hashTable.items)
            {
                if (item == null) continue;
                if (item.Surname == "**********") continue;
                hashTableNew.Add(item);
            }
            return hashTableNew;
        }

        private void btnSearchSecond_Click(object sender, EventArgs e)
        {
            listBoxOutputSecond.Items.Clear();
            var line = textBoxInputSecond.Text;
            var personData = line.Split(' ');
            if (personData.Length < 2)
                MessageBox.Show("Введено некоректні дані!");
            else
            {
                Person person = hashTable2.Search(new Person(personData[0], personData[1]));
                if (person == null)
                    MessageBox.Show("Людину не знайдено!");
                else
                {
                    MessageBox.Show("Людину знайдено!");
                    listBoxOutputSecond.Items.Insert(0, "Прізвище: " + person.Surname);
                    listBoxOutputSecond.Items.Insert(1, "Ім'я: " + person.Name);
                    listBoxOutputSecond.Items.Insert(2, "Дата народження: " + person.Birthday);
                }
            }
        }

        private void btnAddSecond_Click(object sender, EventArgs e)
        {
            listBoxOutputSecond.Items.Clear();
            var line = textBoxInputSecond.Text;
            var personData = line.Split(' ');
            if (personData.Length < 3)
                MessageBox.Show("Введено некоректні дані!");
            else
            {
                if (hashTable2.actualSize * 100 / hashTable2.items.Length > 90)
                {
                    hashTable2 = RehashHashTable2(hashTable2);
                    if (hashTable2.actualSize == hashTableSize)
                    {
                        MessageBox.Show("Хеш-таблицю заповнено!");
                        return;
                    }
                }

                int variant = hashTable2.Add(new Person(personData[0], personData[1], personData[2]));
                if (variant == 1)
                {
                    MessageBox.Show("Успішно додано до таблиці!");
                    ListOverwrite2(listBoxKeysSecond);
                }
                if (variant == 0)
                    MessageBox.Show("Людину вже додано до таблиці!");
                if (variant == -1)
                    MessageBox.Show("Для цієї людини не знайдено вільної комірки!");
            }
        }

        private void btnDeleteSecond_Click(object sender, EventArgs e)
        {
            listBoxOutputSecond.Items.Clear();
            var line = textBoxInputSecond.Text;
            var personData = line.Split(' ');
            int variant = hashTable2.Delete(new Person(personData[0], personData[1]));
            if (variant == -1)
                MessageBox.Show("Людину не знайдено!");
            else
            {
                MessageBox.Show("Успішно видалено!");
                ListOverwrite2(listBoxKeysSecond);
            }
        }
        public HashTableQuadratic<Person> RehashHashTable2(HashTableQuadratic<Person> hashTable2)
        {
            var hashTableNew = new HashTableQuadratic<Person>(hashTable2.items.Length);
            foreach (var item in hashTable2.items)
            {
                if (item == null) continue;
                if (item.Surname == "**********") continue;
                hashTableNew.Add(item);
            }
            return hashTableNew;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            hashTable = new HashTableLinear<Person>(30);
            hashTable2 = new HashTableQuadratic<Person>(30);
            string path = @"..\..\TextFiles\Girls.txt";
            var lines = File.ReadLines(path);
            foreach (var line in lines)
            {
                var personData = line.Split(' ');
                hashTable.Add(new Person(personData[0], personData[1], personData[2]));
                hashTable2.Add(new Person(personData[0], personData[1], personData[2]));
            }
            ListOverwrite1(listBoxKeysFirst);
            ListOverwrite2(listBoxKeysSecond);
        }

        private void btnRandomize_Click(object sender, EventArgs e)
        {
            textBoxInputFirst.Clear();
            textBoxInputSecond.Clear();
            string path = @"..\..\TextFiles\Surnames.txt";
            var lines = File.ReadLines(path);
            var surnames = new List<string>();
            foreach (var line in lines)
            {
                surnames.Add(line.Trim());
            }
            path = @"..\..\TextFiles\Names.txt";
            lines = File.ReadLines(path);
            var names = new List<string>();
            foreach (var line in lines)
            {
                names.Add(line.Trim());
            }
            string day = (new Random().Next(1, 30)).ToString();
            if (Int32.Parse(day) < 10)
                day = 0 + day;
            string month = (new Random().Next(1, 12)).ToString();
            if (Int32.Parse(month) < 10)
                month = 0 + month;
            textBoxInputFirst.Text = surnames[new Random().Next(surnames.Count)] + " " + names[new Random().Next(names.Count)] + " " + day + "." + month + "." + new Random().Next(2003, 2005);
            textBoxInputSecond.Text = textBoxInputFirst.Text;
        }

        private void btnSaveFirst_Click(object sender, EventArgs e)
        {
            var path = @"..\..\TextFiles\GirlsHashTableLinearSave.txt";
            File.Delete(path);
            for (int i = 0; i < hashTable.items.Length; i++)
            {
                if (hashTable.items[i] == null)
                    continue;
                if (hashTable.items[i].Surname == "**********")
                    continue;
                if (i == hashTable.items.Length - 1)
                    File.AppendAllText(path, hashTable.items[i].Surname + " " + hashTable.items[i].Name + " " + hashTable.items[i].Birthday);
                else
                {
                    File.AppendAllText(path, hashTable.items[i].Surname + " " + hashTable.items[i].Name + " " + hashTable.items[i].Birthday + "\n");
                }
            }
            MessageBox.Show("Таблицю збережено до файлу!");
        }

        private void btnSaveSecond_Click(object sender, EventArgs e)
        {
            var path = @"..\..\TextFiles\GirlsHashTableQuadraticSave.txt";
            File.Delete(path);
            for (int i = 0; i < hashTable2.items.Length; i++)
            {
                if (hashTable2.items[i] == null)
                    continue;
                if (hashTable2.items[i].Surname == "**********")
                    continue;
                if (i == hashTable2.items.Length - 1)
                    File.AppendAllText(path, hashTable2.items[i].Surname + " " + hashTable2.items[i].Name + " " + hashTable2.items[i].Birthday);
                else
                {
                    File.AppendAllText(path, hashTable2.items[i].Surname + " " + hashTable2.items[i].Name + " " + hashTable2.items[i].Birthday + "\n");
                }
            }
            MessageBox.Show("Таблицю збережено до файлу!");
        }

        private void btnUploadFirst_Click(object sender, EventArgs e)
        {
            string path = @"..\..\TextFiles\GirlsHashTableLinearSave.txt";
            if (File.Exists(path))
            {
                var lines = File.ReadLines(path);
                foreach (var line in lines)
                {
                    var personData = line.Split(' ');
                    hashTable.Add(new Person(personData[0], personData[1], personData[2]));
                }
                ListOverwrite1(listBoxKeysFirst);
            }
            else
                MessageBox.Show("Файл не знайдено!");
        }

        private void btnUploadSecond_Click(object sender, EventArgs e)
        {

            string path = @"..\..\TextFiles\GirlsHashTableQuadraticSave.txt";
            if (File.Exists(path))
            {
                var lines = File.ReadLines(path);
                foreach (var line in lines)
                {
                    var personData = line.Split(' ');
                    hashTable2.Add(new Person(personData[0], personData[1], personData[2]));
                }
                ListOverwrite2(listBoxKeysSecond);
            }
            else
                MessageBox.Show("Файл не знайдено!");
        }
    }
}
