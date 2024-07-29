namespace KyrsFisr
{
    partial class AddProdForm
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
            this.CancelBut = new System.Windows.Forms.Button();
            this.AddBut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.IDBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.BrandBox = new System.Windows.Forms.TextBox();
            this.YearBox = new System.Windows.Forms.TextBox();
            this.MaterialBox = new System.Windows.Forms.TextBox();
            this.BateryBox = new System.Windows.Forms.TextBox();
            this.CostBox = new System.Windows.Forms.TextBox();
            this.CountBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CatBox = new System.Windows.Forms.ComboBox();
            this.FindFileBut = new System.Windows.Forms.Button();
            this.ChoosePhoto = new System.Windows.Forms.OpenFileDialog();
            this.ShowPict = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ShowPict)).BeginInit();
            this.SuspendLayout();
            // 
            // CancelBut
            // 
            this.CancelBut.Location = new System.Drawing.Point(886, 12);
            this.CancelBut.Name = "CancelBut";
            this.CancelBut.Size = new System.Drawing.Size(107, 45);
            this.CancelBut.TabIndex = 0;
            this.CancelBut.Text = "Отмена";
            this.CancelBut.UseVisualStyleBackColor = true;
            this.CancelBut.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddBut
            // 
            this.AddBut.Location = new System.Drawing.Point(32, 465);
            this.AddBut.Name = "AddBut";
            this.AddBut.Size = new System.Drawing.Size(156, 45);
            this.AddBut.TabIndex = 1;
            this.AddBut.Text = "Внести в базу данных";
            this.AddBut.UseVisualStyleBackColor = true;
            this.AddBut.Click += new System.EventHandler(this.AddBut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(38, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // IDBox
            // 
            this.IDBox.Location = new System.Drawing.Point(257, 77);
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(202, 22);
            this.IDBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(38, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "Название бренда";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(40, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "Год создания";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(40, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 27);
            this.label4.TabIndex = 6;
            this.label4.Text = "Материал";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(38, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 27);
            this.label5.TabIndex = 7;
            this.label5.Text = "Батарея";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(38, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 27);
            this.label6.TabIndex = 8;
            this.label6.Text = "Категория";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(39, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 27);
            this.label7.TabIndex = 9;
            this.label7.Text = "Цена";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(40, 349);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 27);
            this.label8.TabIndex = 10;
            this.label8.Text = "Колличество";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(38, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(362, 37);
            this.label9.TabIndex = 11;
            this.label9.Text = "Добавить продукт в БД";
            // 
            // BrandBox
            // 
            this.BrandBox.Location = new System.Drawing.Point(257, 113);
            this.BrandBox.Name = "BrandBox";
            this.BrandBox.Size = new System.Drawing.Size(202, 22);
            this.BrandBox.TabIndex = 12;
            // 
            // YearBox
            // 
            this.YearBox.Location = new System.Drawing.Point(257, 153);
            this.YearBox.Name = "YearBox";
            this.YearBox.Size = new System.Drawing.Size(202, 22);
            this.YearBox.TabIndex = 13;
            // 
            // MaterialBox
            // 
            this.MaterialBox.Location = new System.Drawing.Point(257, 195);
            this.MaterialBox.Name = "MaterialBox";
            this.MaterialBox.Size = new System.Drawing.Size(202, 22);
            this.MaterialBox.TabIndex = 14;
            // 
            // BateryBox
            // 
            this.BateryBox.Location = new System.Drawing.Point(257, 235);
            this.BateryBox.Name = "BateryBox";
            this.BateryBox.Size = new System.Drawing.Size(202, 22);
            this.BateryBox.TabIndex = 15;
            // 
            // CostBox
            // 
            this.CostBox.Location = new System.Drawing.Point(257, 312);
            this.CostBox.Name = "CostBox";
            this.CostBox.Size = new System.Drawing.Size(202, 22);
            this.CostBox.TabIndex = 17;
            // 
            // CountBox
            // 
            this.CountBox.Location = new System.Drawing.Point(257, 354);
            this.CountBox.Name = "CountBox";
            this.CountBox.Size = new System.Drawing.Size(202, 22);
            this.CountBox.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(40, 405);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 27);
            this.label10.TabIndex = 19;
            this.label10.Text = "Фото";
            // 
            // CatBox
            // 
            this.CatBox.FormattingEnabled = true;
            this.CatBox.Items.AddRange(new object[] {
            "Смартфоны",
            "Ноутбуки",
            "Бытовая техника",
            "Телевизоры",
            "Планшеты",
            "Гаджеты"});
            this.CatBox.Location = new System.Drawing.Point(257, 272);
            this.CatBox.Name = "CatBox";
            this.CatBox.Size = new System.Drawing.Size(202, 24);
            this.CatBox.TabIndex = 20;
            // 
            // FindFileBut
            // 
            this.FindFileBut.Location = new System.Drawing.Point(257, 405);
            this.FindFileBut.Name = "FindFileBut";
            this.FindFileBut.Size = new System.Drawing.Size(202, 33);
            this.FindFileBut.TabIndex = 21;
            this.FindFileBut.Text = "Выбрать фотографию";
            this.FindFileBut.UseVisualStyleBackColor = true;
            this.FindFileBut.Click += new System.EventHandler(this.FindFileBut_Click);
            // 
            // ChoosePhoto
            // 
            this.ChoosePhoto.FileName = "ChoosePhoto";
            // 
            // ShowPict
            // 
            this.ShowPict.Location = new System.Drawing.Point(522, 77);
            this.ShowPict.Name = "ShowPict";
            this.ShowPict.Size = new System.Drawing.Size(471, 355);
            this.ShowPict.TabIndex = 22;
            this.ShowPict.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(662, 463);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(220, 37);
            this.label11.TabIndex = 23;
            this.label11.Text = "Изображение";
            // 
            // AddProdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1005, 522);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.ShowPict);
            this.Controls.Add(this.FindFileBut);
            this.Controls.Add(this.CatBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.CountBox);
            this.Controls.Add(this.CostBox);
            this.Controls.Add(this.BateryBox);
            this.Controls.Add(this.MaterialBox);
            this.Controls.Add(this.YearBox);
            this.Controls.Add(this.BrandBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IDBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddBut);
            this.Controls.Add(this.CancelBut);
            this.Name = "AddProdForm";
            this.Text = "AddProdForm";
            this.Load += new System.EventHandler(this.AddProdForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ShowPict)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelBut;
        private System.Windows.Forms.Button AddBut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IDBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox BrandBox;
        private System.Windows.Forms.TextBox YearBox;
        private System.Windows.Forms.TextBox MaterialBox;
        private System.Windows.Forms.TextBox BateryBox;
        private System.Windows.Forms.TextBox CostBox;
        private System.Windows.Forms.TextBox CountBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox CatBox;
        private System.Windows.Forms.Button FindFileBut;
        private System.Windows.Forms.OpenFileDialog ChoosePhoto;
        private System.Windows.Forms.PictureBox ShowPict;
        private System.Windows.Forms.Label label11;
    }
}