using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using TALab10.DataSorting;

namespace TALab10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<int> listOfTreasures = new List<int>();
        List<int> listCopy1 = new List<int>();
        List<int> listCopy2 = new List<int>();
        List<int> listCopy3 = new List<int>();
        List<int> listCopy4 = new List<int>();
        List<int> listCopy5 = new List<int>();

        int treasuresNumber;
        int minNumber;
        int maxNumber;

        private void buttonSort_Click(object sender, EventArgs e)
        {
            if (listBoxOutput.Items.Count == 0)
            {
                MessageBox.Show("Немає масиву для сортування!");
                return;
            }
            
            listBoxOutput.Items.Clear();
            
            listCopy1.AddRange(listOfTreasures);
            listCopy2.AddRange(listOfTreasures);
            listCopy3.AddRange(listOfTreasures);
            listCopy4.AddRange(listOfTreasures);
            listCopy5.AddRange(listOfTreasures);

            var watch = new System.Diagnostics.Stopwatch();

            watch.Start();
            SortingAlgorithms.QuickSort(listOfTreasures);
            watch.Stop();
            labelQuickSort.Text = watch.Elapsed.ToString();
            watch.Restart();
            SortingAlgorithms.BubbleSort(listCopy1);
            watch.Stop();
            labelBubbleSort.Text = watch.Elapsed.ToString();
            watch.Restart();
            SortingAlgorithms.MergeSort(listCopy2);
            watch.Stop();
            labelMergeSort.Text = watch.Elapsed.ToString();
            watch.Restart();
            SortingAlgorithms.HeapSort(listCopy3);
            watch.Stop();
            labelHeapSort.Text = watch.Elapsed.ToString();
            watch.Restart();
            SortingAlgorithms.LSDSort(listCopy4, maxNumber);
            watch.Stop();
            labelLSDSort.Text = watch.Elapsed.ToString();
            watch.Restart();
            SortingAlgorithms.MSDSort(listCopy5, maxNumber);
            watch.Stop();
            labelMSDSort.Text = watch.Elapsed.ToString();

            foreach (int i in listOfTreasures)
            {
                listBoxOutput.Items.Add(i.ToString());
            }

            listCopy1.Clear();
            listCopy2.Clear();
            listCopy3.Clear();
            listCopy4.Clear();
            listCopy5.Clear();
        }

        private void buttonRandomize_Click(object sender, EventArgs e)
        {
            try
            {
                treasuresNumber = int.Parse(textBoxTreasuresNumber.Text);
                minNumber = int.Parse(textBoxMinNumber.Text);
                maxNumber = int.Parse(textBoxMaxNumber.Text);
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Введіть інформацію про скарби!");
                return;
            }
            catch (FormatException) 
            {
                MessageBox.Show("Неправильний формат даних про скарби!");
                return;
            }

            if (treasuresNumber <= 0 || minNumber <= 0 || maxNumber <= 0)
            {
                MessageBox.Show("Кількість скарбів та їх розміри мають бути більшими за нуль!");
                return;
            }
            if (minNumber > maxNumber)
            {
                MessageBox.Show("Мінімальний розмір скарбу має бути меншим, за максимальний!");
                return;
            }

            Random random = new Random();

            for (int i = 0; i < treasuresNumber; i++)
            {
                int randomTreasure = random.Next(minNumber, maxNumber + 1);
                listOfTreasures.Add(randomTreasure);
                listBoxOutput.Items.Add(randomTreasure.ToString());
            }
            textBoxTreasuresNumber.Text = null;
            textBoxMinNumber.Text = null;
            textBoxMaxNumber.Text = null;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxTreasuresNumber.Clear();
            textBoxMinNumber.Clear();
            textBoxMaxNumber.Clear();
            listBoxOutput.Items.Clear();
            listOfTreasures.Clear();
            listCopy1.Clear();
            listCopy2.Clear();
            listCopy3.Clear();
            listCopy4.Clear();
            listCopy5.Clear();
            labelQuickSort.Text = "Not sorted.";
            labelBubbleSort.Text = "Not sorted.";
            labelMergeSort.Text = "Not sorted.";
            labelHeapSort.Text = "Not sorted.";
            labelLSDSort.Text = "Not sorted.";
            labelMSDSort.Text = "Not sorted.";
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            listBoxOutput.Items.Clear();
            listOfTreasures.Clear();

            StreamReader sr = new StreamReader("..//..//ParticalSortedArray.txt");

            var line = sr.ReadLine();

            if (line == null)
            {
                MessageBox.Show("Файл не містить масиву!");
            }

            while (line != null)
            {
                try
                {
                    listOfTreasures.Add(int.Parse(line));
                }
                catch (FormatException)
                {
                    listOfTreasures.Clear();
                    MessageBox.Show("Файл містить некоректні елементи!");
                    return;
                }
                
                listBoxOutput.Items.Add(line);
                line = sr.ReadLine();
            }

            sr.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (listBoxOutput.Items.Count == 0)
            {
                MessageBox.Show("Немає масиву для збереження!");
                return;
            }

            StreamWriter sw = new StreamWriter("..//..//NewArray.txt");

            foreach (var item in listBoxOutput.Items)
            {
                sw.WriteLine(item.ToString());
            }

            sw.Close();

            MessageBox.Show("Файл успішно збережений!");
        }
    }
}
