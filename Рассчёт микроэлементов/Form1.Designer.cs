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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дата";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Время";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 114);
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
            this.time_comboBox.Location = new System.Drawing.Point(15, 79);
            this.time_comboBox.Name = "time_comboBox";
            this.time_comboBox.Size = new System.Drawing.Size(112, 21);
            this.time_comboBox.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(15, 28);
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
            this.mealName_listBox.Location = new System.Drawing.Point(15, 130);
            this.mealName_listBox.Name = "mealName_listBox";
            this.mealName_listBox.Size = new System.Drawing.Size(112, 95);
            this.mealName_listBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Количество продукта, г";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(160, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Поиск продукта";
            // 
            // productVol_textBox
            // 
            this.productVol_textBox.Location = new System.Drawing.Point(15, 257);
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
            this.listBox2.Location = new System.Drawing.Point(163, 79);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(278, 264);
            this.listBox2.TabIndex = 11;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(163, 28);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(120, 20);
            this.textBox2.TabIndex = 12;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(160, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Группы продуктов";
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(15, 295);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(112, 36);
            this.add_button.TabIndex = 14;
            this.add_button.Text = "Добавить запись";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // preshow
            // 
            this.preshow.Location = new System.Drawing.Point(727, 349);
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
            this.listBox_products.Location = new System.Drawing.Point(457, 27);
            this.listBox_products.Name = "listBox_products";
            this.listBox_products.Size = new System.Drawing.Size(375, 316);
            this.listBox_products.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(454, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Продукты";
            // 
            // button_Size
            // 
            this.button_Size.Location = new System.Drawing.Point(838, 130);
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
            this.preview_listBox.Location = new System.Drawing.Point(877, 27);
            this.preview_listBox.Name = "preview_listBox";
            this.preview_listBox.Size = new System.Drawing.Size(160, 290);
            this.preview_listBox.TabIndex = 22;
            this.preview_listBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lst_DrawItem);
            this.preview_listBox.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.lst_MeasureItem);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(877, 320);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(160, 23);
            this.button_delete.TabIndex = 23;
            this.button_delete.Text = "Убрать позицию";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_AddProduct
            // 
            this.button_AddProduct.Location = new System.Drawing.Point(457, 349);
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
            this.label8.Location = new System.Drawing.Point(874, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Выбранные позиции";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 391);
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
    }
}

