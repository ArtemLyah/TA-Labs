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
            this.textBoxTreasuresNumber = new System.Windows.Forms.TextBox();
            this.listBoxOutput = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxMinNumber = new System.Windows.Forms.TextBox();
            this.textBoxMaxNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonRandomize = new System.Windows.Forms.Button();
            this.buttonSort = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.BubbleSort = new System.Windows.Forms.Label();
            this.QuickSort = new System.Windows.Forms.Label();
            this.MergeSort = new System.Windows.Forms.Label();
            this.HeapSort = new System.Windows.Forms.Label();
            this.LSDSort = new System.Windows.Forms.Label();
            this.MSDSort = new System.Windows.Forms.Label();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelBubbleSort = new System.Windows.Forms.Label();
            this.labelQuickSort = new System.Windows.Forms.Label();
            this.labelMergeSort = new System.Windows.Forms.Label();
            this.labelHeapSort = new System.Windows.Forms.Label();
            this.labelLSDSort = new System.Windows.Forms.Label();
            this.labelMSDSort = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxTreasuresNumber
            // 
            this.textBoxTreasuresNumber.Location = new System.Drawing.Point(57, 68);
            this.textBoxTreasuresNumber.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTreasuresNumber.Name = "textBoxTreasuresNumber";
            this.textBoxTreasuresNumber.Size = new System.Drawing.Size(177, 22);
            this.textBoxTreasuresNumber.TabIndex = 0;
            // 
            // listBoxOutput
            // 
            this.listBoxOutput.FormattingEnabled = true;
            this.listBoxOutput.ItemHeight = 16;
            this.listBoxOutput.Location = new System.Drawing.Point(57, 121);
            this.listBoxOutput.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxOutput.Name = "listBoxOutput";
            this.listBoxOutput.Size = new System.Drawing.Size(412, 388);
            this.listBoxOutput.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(567, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Сортування скарбів";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введіть кількість скарбів:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 48);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Значення від:";
            // 
            // textBoxMinNumber
            // 
            this.textBoxMinNumber.Location = new System.Drawing.Point(264, 68);
            this.textBoxMinNumber.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMinNumber.Name = "textBoxMinNumber";
            this.textBoxMinNumber.Size = new System.Drawing.Size(96, 22);
            this.textBoxMinNumber.TabIndex = 5;
            // 
            // textBoxMaxNumber
            // 
            this.textBoxMaxNumber.Location = new System.Drawing.Point(391, 68);
            this.textBoxMaxNumber.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMaxNumber.Name = "textBoxMaxNumber";
            this.textBoxMaxNumber.Size = new System.Drawing.Size(79, 22);
            this.textBoxMaxNumber.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(387, 48);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "до:";
            // 
            // buttonRandomize
            // 
            this.buttonRandomize.Location = new System.Drawing.Point(536, 121);
            this.buttonRandomize.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRandomize.Name = "buttonRandomize";
            this.buttonRandomize.Size = new System.Drawing.Size(315, 50);
            this.buttonRandomize.TabIndex = 8;
            this.buttonRandomize.Text = "Рандомізувати";
            this.buttonRandomize.UseVisualStyleBackColor = true;
            this.buttonRandomize.Click += new System.EventHandler(this.buttonRandomize_Click);
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(536, 178);
            this.buttonSort.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(315, 50);
            this.buttonSort.TabIndex = 10;
            this.buttonSort.Text = "Сортувати";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(536, 236);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(315, 50);
            this.buttonClear.TabIndex = 11;
            this.buttonClear.Text = "Очистити";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // BubbleSort
            // 
            this.BubbleSort.AutoSize = true;
            this.BubbleSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BubbleSort.Location = new System.Drawing.Point(532, 326);
            this.BubbleSort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BubbleSort.Name = "BubbleSort";
            this.BubbleSort.Size = new System.Drawing.Size(102, 20);
            this.BubbleSort.TabIndex = 12;
            this.BubbleSort.Text = "BubbleSort: ";
            // 
            // QuickSort
            // 
            this.QuickSort.AutoSize = true;
            this.QuickSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuickSort.Location = new System.Drawing.Point(532, 358);
            this.QuickSort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.QuickSort.Name = "QuickSort";
            this.QuickSort.Size = new System.Drawing.Size(93, 20);
            this.QuickSort.TabIndex = 13;
            this.QuickSort.Text = "QuickSort: ";
            // 
            // MergeSort
            // 
            this.MergeSort.AutoSize = true;
            this.MergeSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MergeSort.Location = new System.Drawing.Point(532, 391);
            this.MergeSort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MergeSort.Name = "MergeSort";
            this.MergeSort.Size = new System.Drawing.Size(97, 20);
            this.MergeSort.TabIndex = 14;
            this.MergeSort.Text = "MergeSort: ";
            // 
            // HeapSort
            // 
            this.HeapSort.AutoSize = true;
            this.HeapSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeapSort.Location = new System.Drawing.Point(532, 423);
            this.HeapSort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HeapSort.Name = "HeapSort";
            this.HeapSort.Size = new System.Drawing.Size(85, 20);
            this.HeapSort.TabIndex = 15;
            this.HeapSort.Text = "HeapSort:";
            // 
            // LSDSort
            // 
            this.LSDSort.AutoSize = true;
            this.LSDSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LSDSort.Location = new System.Drawing.Point(532, 457);
            this.LSDSort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LSDSort.Name = "LSDSort";
            this.LSDSort.Size = new System.Drawing.Size(84, 20);
            this.LSDSort.TabIndex = 16;
            this.LSDSort.Text = "LSDSort: ";
            // 
            // MSDSort
            // 
            this.MSDSort.AutoSize = true;
            this.MSDSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MSDSort.Location = new System.Drawing.Point(532, 489);
            this.MSDSort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MSDSort.Name = "MSDSort";
            this.MSDSort.Size = new System.Drawing.Size(88, 20);
            this.MSDSort.TabIndex = 17;
            this.MSDSort.Text = "MSDSort: ";
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(57, 525);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(177, 50);
            this.buttonLoad.TabIndex = 18;
            this.buttonLoad.Text = "Завантажити з файлу";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(295, 525);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(175, 50);
            this.buttonSave.TabIndex = 19;
            this.buttonSave.Text = "Зберегти в новий файл";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelBubbleSort
            // 
            this.labelBubbleSort.AutoSize = true;
            this.labelBubbleSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelBubbleSort.Location = new System.Drawing.Point(641, 321);
            this.labelBubbleSort.Name = "labelBubbleSort";
            this.labelBubbleSort.Size = new System.Drawing.Size(91, 20);
            this.labelBubbleSort.TabIndex = 20;
            this.labelBubbleSort.Text = "Not sorted.";
            // 
            // labelQuickSort
            // 
            this.labelQuickSort.AutoSize = true;
            this.labelQuickSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelQuickSort.Location = new System.Drawing.Point(641, 358);
            this.labelQuickSort.Name = "labelQuickSort";
            this.labelQuickSort.Size = new System.Drawing.Size(91, 20);
            this.labelQuickSort.TabIndex = 21;
            this.labelQuickSort.Text = "Not sorted.";
            // 
            // labelMergeSort
            // 
            this.labelMergeSort.AutoSize = true;
            this.labelMergeSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelMergeSort.Location = new System.Drawing.Point(641, 391);
            this.labelMergeSort.Name = "labelMergeSort";
            this.labelMergeSort.Size = new System.Drawing.Size(91, 20);
            this.labelMergeSort.TabIndex = 22;
            this.labelMergeSort.Text = "Not sorted.";
            // 
            // labelHeapSort
            // 
            this.labelHeapSort.AutoSize = true;
            this.labelHeapSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelHeapSort.Location = new System.Drawing.Point(641, 423);
            this.labelHeapSort.Name = "labelHeapSort";
            this.labelHeapSort.Size = new System.Drawing.Size(91, 20);
            this.labelHeapSort.TabIndex = 23;
            this.labelHeapSort.Text = "Not sorted.";
            // 
            // labelLSDSort
            // 
            this.labelLSDSort.AutoSize = true;
            this.labelLSDSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelLSDSort.Location = new System.Drawing.Point(641, 457);
            this.labelLSDSort.Name = "labelLSDSort";
            this.labelLSDSort.Size = new System.Drawing.Size(91, 20);
            this.labelLSDSort.TabIndex = 24;
            this.labelLSDSort.Text = "Not sorted.";
            // 
            // labelMSDSort
            // 
            this.labelMSDSort.AutoSize = true;
            this.labelMSDSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelMSDSort.Location = new System.Drawing.Point(641, 489);
            this.labelMSDSort.Name = "labelMSDSort";
            this.labelMSDSort.Size = new System.Drawing.Size(91, 20);
            this.labelMSDSort.TabIndex = 25;
            this.labelMSDSort.Text = "Not sorted.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 587);
            this.Controls.Add(this.labelMSDSort);
            this.Controls.Add(this.labelLSDSort);
            this.Controls.Add(this.labelHeapSort);
            this.Controls.Add(this.labelMergeSort);
            this.Controls.Add(this.labelQuickSort);
            this.Controls.Add(this.labelBubbleSort);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.MSDSort);
            this.Controls.Add(this.LSDSort);
            this.Controls.Add(this.HeapSort);
            this.Controls.Add(this.MergeSort);
            this.Controls.Add(this.QuickSort);
            this.Controls.Add(this.BubbleSort);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.buttonRandomize);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxMaxNumber);
            this.Controls.Add(this.textBoxMinNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxOutput);
            this.Controls.Add(this.textBoxTreasuresNumber);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(950, 634);
            this.MinimumSize = new System.Drawing.Size(950, 634);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTreasuresNumber;
        private System.Windows.Forms.ListBox listBoxOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxMinNumber;
        private System.Windows.Forms.TextBox textBoxMaxNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonRandomize;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label BubbleSort;
        private System.Windows.Forms.Label QuickSort;
        private System.Windows.Forms.Label MergeSort;
        private System.Windows.Forms.Label HeapSort;
        private System.Windows.Forms.Label LSDSort;
        private System.Windows.Forms.Label MSDSort;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelBubbleSort;
        private System.Windows.Forms.Label labelQuickSort;
        private System.Windows.Forms.Label labelMergeSort;
        private System.Windows.Forms.Label labelHeapSort;
        private System.Windows.Forms.Label labelLSDSort;
        private System.Windows.Forms.Label labelMSDSort;
    }
}

