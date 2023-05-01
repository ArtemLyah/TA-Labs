namespace TALab6
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
            this.listBoxKeysFirst = new System.Windows.Forms.ListBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxOutputFirst = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxKeysSecond = new System.Windows.Forms.ListBox();
            this.listBoxOutputSecond = new System.Windows.Forms.ListBox();
            this.textBoxInputFirst = new System.Windows.Forms.TextBox();
            this.btnSearchFirst = new System.Windows.Forms.Button();
            this.btnAddFirst = new System.Windows.Forms.Button();
            this.btnDeleteFirst = new System.Windows.Forms.Button();
            this.textBoxInputSecond = new System.Windows.Forms.TextBox();
            this.btnSearchSecond = new System.Windows.Forms.Button();
            this.btnAddSecond = new System.Windows.Forms.Button();
            this.btnDeleteSecond = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnRandomize = new System.Windows.Forms.Button();
            this.btnSaveFirst = new System.Windows.Forms.Button();
            this.btnSaveSecond = new System.Windows.Forms.Button();
            this.btnUploadFirst = new System.Windows.Forms.Button();
            this.btnUploadSecond = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxKeysFirst
            // 
            this.listBoxKeysFirst.FormattingEnabled = true;
            this.listBoxKeysFirst.Location = new System.Drawing.Point(12, 63);
            this.listBoxKeysFirst.Name = "listBoxKeysFirst";
            this.listBoxKeysFirst.Size = new System.Drawing.Size(133, 264);
            this.listBoxKeysFirst.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(395, 183);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Старт";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "---------------------------------------Метод перший------------------------------" +
    "------------";
            // 
            // listBoxOutputFirst
            // 
            this.listBoxOutputFirst.FormattingEnabled = true;
            this.listBoxOutputFirst.Location = new System.Drawing.Point(185, 63);
            this.listBoxOutputFirst.Name = "listBoxOutputFirst";
            this.listBoxOutputFirst.Size = new System.Drawing.Size(173, 264);
            this.listBoxOutputFirst.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(510, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(316, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "-------------------------------------Метод другий--------------------------------" +
    "-----------";
            // 
            // listBoxKeysSecond
            // 
            this.listBoxKeysSecond.FormattingEnabled = true;
            this.listBoxKeysSecond.Location = new System.Drawing.Point(495, 63);
            this.listBoxKeysSecond.Name = "listBoxKeysSecond";
            this.listBoxKeysSecond.Size = new System.Drawing.Size(128, 264);
            this.listBoxKeysSecond.TabIndex = 5;
            // 
            // listBoxOutputSecond
            // 
            this.listBoxOutputSecond.FormattingEnabled = true;
            this.listBoxOutputSecond.Location = new System.Drawing.Point(676, 63);
            this.listBoxOutputSecond.Name = "listBoxOutputSecond";
            this.listBoxOutputSecond.Size = new System.Drawing.Size(167, 264);
            this.listBoxOutputSecond.TabIndex = 6;
            // 
            // textBoxInputFirst
            // 
            this.textBoxInputFirst.Enabled = false;
            this.textBoxInputFirst.Location = new System.Drawing.Point(12, 333);
            this.textBoxInputFirst.Name = "textBoxInputFirst";
            this.textBoxInputFirst.Size = new System.Drawing.Size(346, 20);
            this.textBoxInputFirst.TabIndex = 7;
            // 
            // btnSearchFirst
            // 
            this.btnSearchFirst.Enabled = false;
            this.btnSearchFirst.Location = new System.Drawing.Point(12, 359);
            this.btnSearchFirst.Name = "btnSearchFirst";
            this.btnSearchFirst.Size = new System.Drawing.Size(75, 23);
            this.btnSearchFirst.TabIndex = 8;
            this.btnSearchFirst.Text = "Пошук";
            this.btnSearchFirst.UseVisualStyleBackColor = true;
            this.btnSearchFirst.Click += new System.EventHandler(this.btnSearchFirst_Click);
            // 
            // btnAddFirst
            // 
            this.btnAddFirst.Enabled = false;
            this.btnAddFirst.Location = new System.Drawing.Point(147, 359);
            this.btnAddFirst.Name = "btnAddFirst";
            this.btnAddFirst.Size = new System.Drawing.Size(75, 23);
            this.btnAddFirst.TabIndex = 9;
            this.btnAddFirst.Text = "Додати";
            this.btnAddFirst.UseVisualStyleBackColor = true;
            this.btnAddFirst.Click += new System.EventHandler(this.btnAddFirst_Click);
            // 
            // btnDeleteFirst
            // 
            this.btnDeleteFirst.Enabled = false;
            this.btnDeleteFirst.Location = new System.Drawing.Point(283, 359);
            this.btnDeleteFirst.Name = "btnDeleteFirst";
            this.btnDeleteFirst.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteFirst.TabIndex = 10;
            this.btnDeleteFirst.Text = "Видалити";
            this.btnDeleteFirst.UseVisualStyleBackColor = true;
            this.btnDeleteFirst.Click += new System.EventHandler(this.btnDeleteFirst_Click);
            // 
            // textBoxInputSecond
            // 
            this.textBoxInputSecond.Enabled = false;
            this.textBoxInputSecond.Location = new System.Drawing.Point(495, 333);
            this.textBoxInputSecond.Name = "textBoxInputSecond";
            this.textBoxInputSecond.Size = new System.Drawing.Size(348, 20);
            this.textBoxInputSecond.TabIndex = 11;
            // 
            // btnSearchSecond
            // 
            this.btnSearchSecond.Enabled = false;
            this.btnSearchSecond.Location = new System.Drawing.Point(495, 359);
            this.btnSearchSecond.Name = "btnSearchSecond";
            this.btnSearchSecond.Size = new System.Drawing.Size(75, 23);
            this.btnSearchSecond.TabIndex = 12;
            this.btnSearchSecond.Text = "Пошук";
            this.btnSearchSecond.UseVisualStyleBackColor = true;
            this.btnSearchSecond.Click += new System.EventHandler(this.btnSearchSecond_Click);
            // 
            // btnAddSecond
            // 
            this.btnAddSecond.Enabled = false;
            this.btnAddSecond.Location = new System.Drawing.Point(633, 359);
            this.btnAddSecond.Name = "btnAddSecond";
            this.btnAddSecond.Size = new System.Drawing.Size(75, 23);
            this.btnAddSecond.TabIndex = 13;
            this.btnAddSecond.Text = "Додати";
            this.btnAddSecond.UseVisualStyleBackColor = true;
            this.btnAddSecond.Click += new System.EventHandler(this.btnAddSecond_Click);
            // 
            // btnDeleteSecond
            // 
            this.btnDeleteSecond.Enabled = false;
            this.btnDeleteSecond.Location = new System.Drawing.Point(768, 359);
            this.btnDeleteSecond.Name = "btnDeleteSecond";
            this.btnDeleteSecond.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteSecond.TabIndex = 14;
            this.btnDeleteSecond.Text = "Видалити";
            this.btnDeleteSecond.UseVisualStyleBackColor = true;
            this.btnDeleteSecond.Click += new System.EventHandler(this.btnDeleteSecond_Click);
            // 
            // btnReset
            // 
            this.btnReset.Enabled = false;
            this.btnReset.Location = new System.Drawing.Point(316, 439);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(219, 23);
            this.btnReset.TabIndex = 15;
            this.btnReset.Text = "Повернутись до початкових таблиць";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnRandomize
            // 
            this.btnRandomize.Enabled = false;
            this.btnRandomize.Location = new System.Drawing.Point(395, 359);
            this.btnRandomize.Name = "btnRandomize";
            this.btnRandomize.Size = new System.Drawing.Size(75, 23);
            this.btnRandomize.TabIndex = 16;
            this.btnRandomize.Text = "Рандом";
            this.btnRandomize.UseVisualStyleBackColor = true;
            this.btnRandomize.Click += new System.EventHandler(this.btnRandomize_Click);
            // 
            // btnSaveFirst
            // 
            this.btnSaveFirst.Enabled = false;
            this.btnSaveFirst.Location = new System.Drawing.Point(12, 388);
            this.btnSaveFirst.Name = "btnSaveFirst";
            this.btnSaveFirst.Size = new System.Drawing.Size(116, 23);
            this.btnSaveFirst.TabIndex = 17;
            this.btnSaveFirst.Text = "Зберегти таблицю";
            this.btnSaveFirst.UseVisualStyleBackColor = true;
            this.btnSaveFirst.Click += new System.EventHandler(this.btnSaveFirst_Click);
            // 
            // btnSaveSecond
            // 
            this.btnSaveSecond.Enabled = false;
            this.btnSaveSecond.Location = new System.Drawing.Point(725, 388);
            this.btnSaveSecond.Name = "btnSaveSecond";
            this.btnSaveSecond.Size = new System.Drawing.Size(118, 23);
            this.btnSaveSecond.TabIndex = 18;
            this.btnSaveSecond.Text = "Зберегти таблицю";
            this.btnSaveSecond.UseVisualStyleBackColor = true;
            this.btnSaveSecond.Click += new System.EventHandler(this.btnSaveSecond_Click);
            // 
            // btnUploadFirst
            // 
            this.btnUploadFirst.Enabled = false;
            this.btnUploadFirst.Location = new System.Drawing.Point(134, 388);
            this.btnUploadFirst.Name = "btnUploadFirst";
            this.btnUploadFirst.Size = new System.Drawing.Size(224, 23);
            this.btnUploadFirst.TabIndex = 19;
            this.btnUploadFirst.Text = "Завантаження останнього збереження";
            this.btnUploadFirst.UseVisualStyleBackColor = true;
            this.btnUploadFirst.Click += new System.EventHandler(this.btnUploadFirst_Click);
            // 
            // btnUploadSecond
            // 
            this.btnUploadSecond.Enabled = false;
            this.btnUploadSecond.Location = new System.Drawing.Point(495, 388);
            this.btnUploadSecond.Name = "btnUploadSecond";
            this.btnUploadSecond.Size = new System.Drawing.Size(224, 23);
            this.btnUploadSecond.TabIndex = 20;
            this.btnUploadSecond.Text = "Завантаження останнього збереження";
            this.btnUploadSecond.UseVisualStyleBackColor = true;
            this.btnUploadSecond.Click += new System.EventHandler(this.btnUploadSecond_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 474);
            this.Controls.Add(this.btnUploadSecond);
            this.Controls.Add(this.btnUploadFirst);
            this.Controls.Add(this.btnSaveSecond);
            this.Controls.Add(this.btnSaveFirst);
            this.Controls.Add(this.btnRandomize);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnDeleteSecond);
            this.Controls.Add(this.btnAddSecond);
            this.Controls.Add(this.btnSearchSecond);
            this.Controls.Add(this.textBoxInputSecond);
            this.Controls.Add(this.btnDeleteFirst);
            this.Controls.Add(this.btnAddFirst);
            this.Controls.Add(this.btnSearchFirst);
            this.Controls.Add(this.textBoxInputFirst);
            this.Controls.Add(this.listBoxOutputSecond);
            this.Controls.Add(this.listBoxKeysSecond);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxOutputFirst);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.listBoxKeysFirst);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxKeysFirst;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxOutputFirst;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxKeysSecond;
        private System.Windows.Forms.ListBox listBoxOutputSecond;
        private System.Windows.Forms.TextBox textBoxInputFirst;
        private System.Windows.Forms.Button btnSearchFirst;
        private System.Windows.Forms.Button btnAddFirst;
        private System.Windows.Forms.Button btnDeleteFirst;
        private System.Windows.Forms.TextBox textBoxInputSecond;
        private System.Windows.Forms.Button btnSearchSecond;
        private System.Windows.Forms.Button btnAddSecond;
        private System.Windows.Forms.Button btnDeleteSecond;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnRandomize;
        private System.Windows.Forms.Button btnSaveFirst;
        private System.Windows.Forms.Button btnSaveSecond;
        private System.Windows.Forms.Button btnUploadFirst;
        private System.Windows.Forms.Button btnUploadSecond;
    }
}

