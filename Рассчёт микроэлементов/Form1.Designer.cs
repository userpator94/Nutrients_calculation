namespace Рассчёт_микроэлементов
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.time_comboBox = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.mealName_listBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.productVol_textBox = new System.Windows.Forms.TextBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.add_button = new System.Windows.Forms.Button();
            this.preshow = new System.Windows.Forms.Button();
            this.listBox_products = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button_Size = new System.Windows.Forms.Button();
            this.preview_listBox = new System.Windows.Forms.ListBox();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_AddProduct = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.button_FH = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дата";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Время";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Приём пищи";
            // 
            // time_comboBox
            // 
            this.time_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.time_comboBox.FormattingEnabled = true;
            this.time_comboBox.Items.AddRange(new object[] {
            "7:00",
            "7:30",
            "8:00",
            "8:30",
            "9:00",
            "9:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30",
            "16:00",
            "16:30",
            "17:00",
            "17:30",
            "18:00",
            "18:30",
            "19:00",
            "19:30",
            "20:00",
            "20:30",
            "21:00",
            "21:30",
            "22:00",
            "22:30",
            "23:00",
            "23:30",
            "0:00",
            "0:30",
            "1:00",
            "1:30",
            "2:00"});
            this.time_comboBox.Location = new System.Drawing.Point(12, 145);
            this.time_comboBox.Name = "time_comboBox";
            this.time_comboBox.Size = new System.Drawing.Size(112, 21);
            this.time_comboBox.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 94);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(112, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // mealName_listBox
            // 
            this.mealName_listBox.FormattingEnabled = true;
            this.mealName_listBox.Items.AddRange(new object[] {
            "Завтрак",
            "Завтрак 2",
            "Обед",
            "Обед 2",
            "Полдник",
            "Полдник 2",
            "Ужин",
            "Ужин 2"});
            this.mealName_listBox.Location = new System.Drawing.Point(12, 196);
            this.mealName_listBox.Name = "mealName_listBox";
            this.mealName_listBox.Size = new System.Drawing.Size(112, 95);
            this.mealName_listBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Количество продукта, г";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(157, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Поиск продукта";
            // 
            // productVol_textBox
            // 
            this.productVol_textBox.Location = new System.Drawing.Point(12, 323);
            this.productVol_textBox.Name = "productVol_textBox";
            this.productVol_textBox.Size = new System.Drawing.Size(112, 20);
            this.productVol_textBox.TabIndex = 10;
            this.productVol_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.productVol_textBox_KeyPress);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Items.AddRange(new object[] {
            "Молочные продукты",
            "Яичные продукты",
            "Мясо, мясные продукты, готовые мясные блюда",
            "Рыба, морепродукты, готовые рыбные блюда",
            "Жиры и масла",
            "Каши, крупы, макаронные изделия",
            "Хлеб, хлебобулочные изделия, выпечка",
            "Орехи, бобовые",
            "Овощи, овощные блюда",
            "Картофель, блюда картофельные",
            "Фрукты, ягоды, фруктово-ягодные напитки",
            "Конфеты, шоколад, варенье, джемы",
            "Чай, кофе, напитки безалкогольные",
            "Алкогольные напитки",
            "Супы",
            "Детское питание",
            "Смесь сухая",
            "Смесь с крупами",
            "Иное",
            "Приправы, соусы"});
            this.listBox2.Location = new System.Drawing.Point(160, 145);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(278, 264);
            this.listBox2.TabIndex = 11;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(160, 94);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(120, 20);
            this.textBox2.TabIndex = 12;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(157, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Группы продуктов";
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(12, 361);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(112, 36);
            this.add_button.TabIndex = 14;
            this.add_button.Text = "Добавить запись";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // preshow
            // 
            this.preshow.Location = new System.Drawing.Point(724, 415);
            this.preshow.Name = "preshow";
            this.preshow.Size = new System.Drawing.Size(105, 32);
            this.preshow.TabIndex = 16;
            this.preshow.Text = "Предпросмотр";
            this.preshow.UseVisualStyleBackColor = true;
            this.preshow.Click += new System.EventHandler(this.preshow_Click);
            // 
            // listBox_products
            // 
            this.listBox_products.FormattingEnabled = true;
            this.listBox_products.Location = new System.Drawing.Point(454, 93);
            this.listBox_products.Name = "listBox_products";
            this.listBox_products.Size = new System.Drawing.Size(375, 316);
            this.listBox_products.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(451, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Продукты";
            // 
            // button_Size
            // 
            this.button_Size.Location = new System.Drawing.Point(835, 196);
            this.button_Size.Name = "button_Size";
            this.button_Size.Size = new System.Drawing.Size(15, 112);
            this.button_Size.TabIndex = 21;
            this.button_Size.Text = "}";
            this.button_Size.UseVisualStyleBackColor = true;
            this.button_Size.Click += new System.EventHandler(this.button_Size_Click);
            // 
            // preview_listBox
            // 
            this.preview_listBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.preview_listBox.FormattingEnabled = true;
            this.preview_listBox.Location = new System.Drawing.Point(874, 93);
            this.preview_listBox.Name = "preview_listBox";
            this.preview_listBox.Size = new System.Drawing.Size(160, 290);
            this.preview_listBox.TabIndex = 22;
            this.preview_listBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lst_DrawItem);
            this.preview_listBox.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.lst_MeasureItem);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(874, 386);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(160, 23);
            this.button_delete.TabIndex = 23;
            this.button_delete.Text = "Убрать позицию";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_AddProduct
            // 
            this.button_AddProduct.Location = new System.Drawing.Point(454, 415);
            this.button_AddProduct.Name = "button_AddProduct";
            this.button_AddProduct.Size = new System.Drawing.Size(119, 32);
            this.button_AddProduct.TabIndex = 24;
            this.button_AddProduct.Text = "Добавить продукт";
            this.button_AddProduct.UseVisualStyleBackColor = true;
            this.button_AddProduct.Click += new System.EventHandler(this.button_AddProduct_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(871, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Выбранные позиции";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Возраст";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(157, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Пол";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(240, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Вариант рациона";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70"});
            this.comboBox1.Location = new System.Drawing.Point(12, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 29;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "муж",
            "жен"});
            this.comboBox2.Location = new System.Drawing.Point(161, 27);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(54, 21);
            this.comboBox2.TabIndex = 30;
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "суточный",
            "ЛПП"});
            this.comboBox3.Location = new System.Drawing.Point(243, 27);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(91, 21);
            this.comboBox3.TabIndex = 31;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.rationVariant_Changed);
            // 
            // comboBox4
            // 
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.Enabled = false;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.comboBox4.Location = new System.Drawing.Point(365, 27);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(143, 21);
            this.comboBox4.TabIndex = 32;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(362, 11);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(143, 13);
            this.label12.TabIndex = 33;
            this.label12.Text = "Количество приёмов пищи";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(653, 11);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 13);
            this.label13.TabIndex = 34;
            this.label13.Text = "Рацион";
            // 
            // comboBox5
            // 
            this.comboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox5.Enabled = false;
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "1",
            "2",
            "2а",
            "3",
            "4",
            "4а",
            "4б",
            "5",
            "Витамины"});
            this.comboBox5.Location = new System.Drawing.Point(656, 27);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(91, 21);
            this.comboBox5.TabIndex = 35;
            this.comboBox5.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(532, 11);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 13);
            this.label14.TabIndex = 36;
            this.label14.Text = "Вредные факторы";
            // 
            // button_FH
            // 
            this.button_FH.Enabled = false;
            this.button_FH.Location = new System.Drawing.Point(535, 27);
            this.button_FH.Name = "button_FH";
            this.button_FH.Size = new System.Drawing.Size(97, 23);
            this.button_FH.TabIndex = 37;
            this.button_FH.Text = "Выбрать";
            this.button_FH.UseVisualStyleBackColor = true;
            this.button_FH.Click += new System.EventHandler(this.button_FH_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 461);
            this.Controls.Add(this.button_FH);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button_AddProduct);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.preview_listBox);
            this.Controls.Add(this.button_Size);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listBox_products);
            this.Controls.Add(this.preshow);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.productVol_textBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mealName_listBox);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.time_comboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Рассчёт микроэлементов";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox time_comboBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ListBox mealName_listBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox productVol_textBox;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button preshow;
        private System.Windows.Forms.ListBox listBox_products;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_Size;
        private System.Windows.Forms.ListBox preview_listBox;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_AddProduct;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button_FH;
    }
}

