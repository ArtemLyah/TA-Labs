namespace TALab10
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BubbleSort = new System.Windows.Forms.Label();
            this.QuickSort = new System.Windows.Forms.Label();
            this.MergeSort = new System.Windows.Forms.Label();
            this.HeapSort = new System.Windows.Forms.Label();
            this.LSDSort = new System.Windows.Forms.Label();
            this.MSDSort = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(43, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(134, 20);
            this.textBox1.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(43, 98);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(310, 316);
            this.listBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(444, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Сортування скарбів";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введіть кількість скарбів:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Значення від:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(198, 55);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(73, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(293, 55);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(60, 20);
            this.textBox3.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(290, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "до:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(402, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(236, 41);
            this.button1.TabIndex = 8;
            this.button1.Text = "Рандомізувати";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(402, 145);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(236, 41);
            this.button3.TabIndex = 10;
            this.button3.Text = "Сортувати";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(402, 192);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(236, 41);
            this.button2.TabIndex = 11;
            this.button2.Text = "Очистити";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // BubbleSort
            // 
            this.BubbleSort.AutoSize = true;
            this.BubbleSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BubbleSort.Location = new System.Drawing.Point(399, 265);
            this.BubbleSort.Name = "BubbleSort";
            this.BubbleSort.Size = new System.Drawing.Size(86, 17);
            this.BubbleSort.TabIndex = 12;
            this.BubbleSort.Text = "BubbleSort: ";
            // 
            // QuickSort
            // 
            this.QuickSort.AutoSize = true;
            this.QuickSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuickSort.Location = new System.Drawing.Point(399, 291);
            this.QuickSort.Name = "QuickSort";
            this.QuickSort.Size = new System.Drawing.Size(78, 17);
            this.QuickSort.TabIndex = 13;
            this.QuickSort.Text = "QuickSort: ";
            // 
            // MergeSort
            // 
            this.MergeSort.AutoSize = true;
            this.MergeSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MergeSort.Location = new System.Drawing.Point(399, 318);
            this.MergeSort.Name = "MergeSort";
            this.MergeSort.Size = new System.Drawing.Size(82, 17);
            this.MergeSort.TabIndex = 14;
            this.MergeSort.Text = "MergeSort: ";
            // 
            // HeapSort
            // 
            this.HeapSort.AutoSize = true;
            this.HeapSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeapSort.Location = new System.Drawing.Point(399, 344);
            this.HeapSort.Name = "HeapSort";
            this.HeapSort.Size = new System.Drawing.Size(72, 17);
            this.HeapSort.TabIndex = 15;
            this.HeapSort.Text = "HeapSort:";
            // 
            // LSDSort
            // 
            this.LSDSort.AutoSize = true;
            this.LSDSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LSDSort.Location = new System.Drawing.Point(399, 371);
            this.LSDSort.Name = "LSDSort";
            this.LSDSort.Size = new System.Drawing.Size(69, 17);
            this.LSDSort.TabIndex = 16;
            this.LSDSort.Text = "LSDSort: ";
            // 
            // MSDSort
            // 
            this.MSDSort.AutoSize = true;
            this.MSDSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MSDSort.Location = new System.Drawing.Point(399, 397);
            this.MSDSort.Name = "MSDSort";
            this.MSDSort.Size = new System.Drawing.Size(72, 17);
            this.MSDSort.TabIndex = 17;
            this.MSDSort.Text = "MSDSort: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 450);
            this.Controls.Add(this.MSDSort);
            this.Controls.Add(this.LSDSort);
            this.Controls.Add(this.HeapSort);
            this.Controls.Add(this.MergeSort);
            this.Controls.Add(this.QuickSort);
            this.Controls.Add(this.BubbleSort);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label BubbleSort;
        private System.Windows.Forms.Label QuickSort;
        private System.Windows.Forms.Label MergeSort;
        private System.Windows.Forms.Label HeapSort;
        private System.Windows.Forms.Label LSDSort;
        private System.Windows.Forms.Label MSDSort;
    }
}

