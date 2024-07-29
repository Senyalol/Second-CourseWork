using System.Drawing;

namespace KyrsFisr
{
    partial class MainForm
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
        public void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.FiltrBut = new System.Windows.Forms.Button();
            this.ChooseBrand = new System.Windows.Forms.ComboBox();
            this.ChooseYear = new System.Windows.Forms.ComboBox();
            this.MaterialChoose = new System.Windows.Forms.ComboBox();
            this.ChooseBatery = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Brand = new System.Windows.Forms.Label();
            this.Year = new System.Windows.Forms.Label();
            this.Cost = new System.Windows.Forms.Label();
            this.Material = new System.Windows.Forms.Label();
            this.Batery = new System.Windows.Forms.Label();
            this.SearchB = new System.Windows.Forms.Button();
            this.ExitButt = new System.Windows.Forms.Button();
            this.EnterA = new System.Windows.Forms.Button();
            this.Favorit = new System.Windows.Forms.Button();
            this.ChooseCategory = new System.Windows.Forms.ComboBox();
            this.Category = new System.Windows.Forms.Label();
            this.Ok = new System.Windows.Forms.Button();
            this.DiapChooseMin = new System.Windows.Forms.TextBox();
            this.DiapLabelMin = new System.Windows.Forms.Label();
            this.DiapLabelMax = new System.Windows.Forms.Label();
            this.DiapChooseMax = new System.Windows.Forms.TextBox();
            this.Y1 = new System.Windows.Forms.CheckBox();
            this.YearLab = new System.Windows.Forms.Label();
            this.Y2 = new System.Windows.Forms.CheckBox();
            this.Y3 = new System.Windows.Forms.CheckBox();
            this.Y4 = new System.Windows.Forms.CheckBox();
            this.Y5 = new System.Windows.Forms.CheckBox();
            this.Y6 = new System.Windows.Forms.CheckBox();
            this.MaterLab = new System.Windows.Forms.Label();
            this.M1 = new System.Windows.Forms.CheckBox();
            this.M2 = new System.Windows.Forms.CheckBox();
            this.M3 = new System.Windows.Forms.CheckBox();
            this.M4 = new System.Windows.Forms.CheckBox();
            this.CatLab = new System.Windows.Forms.Label();
            this.C1 = new System.Windows.Forms.CheckBox();
            this.C2 = new System.Windows.Forms.CheckBox();
            this.C3 = new System.Windows.Forms.CheckBox();
            this.C4 = new System.Windows.Forms.CheckBox();
            this.C5 = new System.Windows.Forms.CheckBox();
            this.C6 = new System.Windows.Forms.CheckBox();
            this.BatLab = new System.Windows.Forms.Label();
            this.A1 = new System.Windows.Forms.CheckBox();
            this.A2 = new System.Windows.Forms.CheckBox();
            this.A3 = new System.Windows.Forms.CheckBox();
            this.A4 = new System.Windows.Forms.CheckBox();
            this.A6 = new System.Windows.Forms.CheckBox();
            this.A5 = new System.Windows.Forms.CheckBox();
            this.A8 = new System.Windows.Forms.CheckBox();
            this.A7 = new System.Windows.Forms.CheckBox();
            this.Display = new System.Windows.Forms.ListView();
            this.photo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bran = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cyear = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cst = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClientCartBut = new System.Windows.Forms.Button();
            this.MainBut = new System.Windows.Forms.Button();
            this.Y7 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // FiltrBut
            // 
            this.FiltrBut.BackColor = System.Drawing.Color.White;
            this.FiltrBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.FiltrBut.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FiltrBut.Image = ((System.Drawing.Image)(resources.GetObject("FiltrBut.Image")));
            this.FiltrBut.Location = new System.Drawing.Point(1031, 12);
            this.FiltrBut.Name = "FiltrBut";
            this.FiltrBut.Size = new System.Drawing.Size(173, 61);
            this.FiltrBut.TabIndex = 0;
            this.FiltrBut.UseVisualStyleBackColor = false;
            this.FiltrBut.Click += new System.EventHandler(this.button1_Click);
            // 
            // ChooseBrand
            // 
            this.ChooseBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChooseBrand.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChooseBrand.FormattingEnabled = true;
            this.ChooseBrand.Items.AddRange(new object[] {
            "Samsung",
            "Apple",
            "LG",
            "Dyson",
            "Asus",
            "HP",
            "Xiaomi",
            "Sony",
            "Atlant"});
            this.ChooseBrand.Location = new System.Drawing.Point(12, 116);
            this.ChooseBrand.Name = "ChooseBrand";
            this.ChooseBrand.Size = new System.Drawing.Size(173, 27);
            this.ChooseBrand.TabIndex = 1;
            this.ChooseBrand.Visible = false;
            // 
            // ChooseYear
            // 
            this.ChooseYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChooseYear.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChooseYear.FormattingEnabled = true;
            this.ChooseYear.Items.AddRange(new object[] {
            "2024",
            "2023",
            "2022",
            "2021",
            "2020",
            "2019",
            "2018"});
            this.ChooseYear.Location = new System.Drawing.Point(12, 178);
            this.ChooseYear.Name = "ChooseYear";
            this.ChooseYear.Size = new System.Drawing.Size(173, 27);
            this.ChooseYear.TabIndex = 2;
            this.ChooseYear.Visible = false;
            // 
            // MaterialChoose
            // 
            this.MaterialChoose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MaterialChoose.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaterialChoose.FormattingEnabled = true;
            this.MaterialChoose.Items.AddRange(new object[] {
            "Алюминий",
            "Сталь",
            "Латунь",
            "Пластик"});
            this.MaterialChoose.Location = new System.Drawing.Point(12, 238);
            this.MaterialChoose.Name = "MaterialChoose";
            this.MaterialChoose.Size = new System.Drawing.Size(173, 27);
            this.MaterialChoose.TabIndex = 4;
            this.MaterialChoose.Visible = false;
            // 
            // ChooseBatery
            // 
            this.ChooseBatery.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChooseBatery.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChooseBatery.FormattingEnabled = true;
            this.ChooseBatery.Items.AddRange(new object[] {
            "1000",
            "2000",
            "3000",
            "4000",
            "5000",
            "6000",
            "8000",
            "0"});
            this.ChooseBatery.Location = new System.Drawing.Point(12, 298);
            this.ChooseBatery.Name = "ChooseBatery";
            this.ChooseBatery.Size = new System.Drawing.Size(173, 27);
            this.ChooseBatery.TabIndex = 5;
            this.ChooseBatery.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Brand
            // 
            this.Brand.AutoSize = true;
            this.Brand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Brand.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Brand.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Brand.Location = new System.Drawing.Point(12, 84);
            this.Brand.Name = "Brand";
            this.Brand.Size = new System.Drawing.Size(175, 27);
            this.Brand.TabIndex = 7;
            this.Brand.Text = "Производитель";
            this.Brand.Visible = false;
            // 
            // Year
            // 
            this.Year.AutoSize = true;
            this.Year.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Year.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Year.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Year.Location = new System.Drawing.Point(12, 146);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(142, 27);
            this.Year.TabIndex = 8;
            this.Year.Text = "Год выпуска";
            this.Year.Visible = false;
            this.Year.Click += new System.EventHandler(this.label1_Click);
            // 
            // Cost
            // 
            this.Cost.AutoSize = true;
            this.Cost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Cost.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cost.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Cost.Location = new System.Drawing.Point(12, 388);
            this.Cost.Name = "Cost";
            this.Cost.Size = new System.Drawing.Size(67, 27);
            this.Cost.TabIndex = 9;
            this.Cost.Text = "Цена";
            this.Cost.Visible = false;
            // 
            // Material
            // 
            this.Material.AutoSize = true;
            this.Material.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Material.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Material.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Material.Location = new System.Drawing.Point(12, 208);
            this.Material.Name = "Material";
            this.Material.Size = new System.Drawing.Size(118, 27);
            this.Material.TabIndex = 10;
            this.Material.Text = "Материал";
            this.Material.Visible = false;
            // 
            // Batery
            // 
            this.Batery.AutoSize = true;
            this.Batery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Batery.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Batery.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Batery.Location = new System.Drawing.Point(12, 268);
            this.Batery.Name = "Batery";
            this.Batery.Size = new System.Drawing.Size(178, 24);
            this.Batery.TabIndex = 11;
            this.Batery.Text = "Аккумулятор мА·ч";
            this.Batery.Visible = false;
            // 
            // SearchB
            // 
            this.SearchB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(38)))), ((int)(((byte)(54)))));
            this.SearchB.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchB.ForeColor = System.Drawing.Color.White;
            this.SearchB.Location = new System.Drawing.Point(12, 12);
            this.SearchB.Name = "SearchB";
            this.SearchB.Size = new System.Drawing.Size(173, 61);
            this.SearchB.TabIndex = 12;
            this.SearchB.Text = "Поиск🔍";
            this.SearchB.UseVisualStyleBackColor = false;
            this.SearchB.Click += new System.EventHandler(this.SearchB_Click);
            // 
            // ExitButt
            // 
            this.ExitButt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(38)))), ((int)(((byte)(54)))));
            this.ExitButt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ExitButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButt.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButt.ForeColor = System.Drawing.Color.Transparent;
            this.ExitButt.Location = new System.Drawing.Point(12, 604);
            this.ExitButt.Name = "ExitButt";
            this.ExitButt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ExitButt.Size = new System.Drawing.Size(187, 82);
            this.ExitButt.TabIndex = 14;
            this.ExitButt.Text = "Закончить работу";
            this.ExitButt.UseVisualStyleBackColor = false;
            this.ExitButt.Click += new System.EventHandler(this.ExitButt_Click);
            // 
            // EnterA
            // 
            this.EnterA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(38)))), ((int)(((byte)(54)))));
            this.EnterA.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnterA.ForeColor = System.Drawing.Color.White;
            this.EnterA.Location = new System.Drawing.Point(852, 12);
            this.EnterA.Name = "EnterA";
            this.EnterA.Size = new System.Drawing.Size(173, 61);
            this.EnterA.TabIndex = 15;
            this.EnterA.Text = "Войти";
            this.EnterA.UseVisualStyleBackColor = false;
            this.EnterA.Click += new System.EventHandler(this.EnterA_Click);
            // 
            // Favorit
            // 
            this.Favorit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(38)))), ((int)(((byte)(54)))));
            this.Favorit.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Favorit.ForeColor = System.Drawing.Color.White;
            this.Favorit.Location = new System.Drawing.Point(205, 12);
            this.Favorit.Name = "Favorit";
            this.Favorit.Size = new System.Drawing.Size(173, 61);
            this.Favorit.TabIndex = 17;
            this.Favorit.Text = "Избранное❤️";
            this.Favorit.UseVisualStyleBackColor = false;
            this.Favorit.Click += new System.EventHandler(this.Favorit_Click);
            // 
            // ChooseCategory
            // 
            this.ChooseCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChooseCategory.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChooseCategory.FormattingEnabled = true;
            this.ChooseCategory.Items.AddRange(new object[] {
            "Смартфоны",
            "Ноутбуки",
            "Бытовая техника",
            "Телевизоры",
            "Планшеты",
            "Гаджеты"});
            this.ChooseCategory.Location = new System.Drawing.Point(12, 358);
            this.ChooseCategory.Name = "ChooseCategory";
            this.ChooseCategory.Size = new System.Drawing.Size(173, 27);
            this.ChooseCategory.TabIndex = 18;
            this.ChooseCategory.Visible = false;
            // 
            // Category
            // 
            this.Category.AutoSize = true;
            this.Category.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Category.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Category.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Category.Location = new System.Drawing.Point(12, 328);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(120, 27);
            this.Category.TabIndex = 19;
            this.Category.Text = "Категория";
            this.Category.Visible = false;
            // 
            // Ok
            // 
            this.Ok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(72)))));
            this.Ok.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ok.ForeColor = System.Drawing.Color.Black;
            this.Ok.Location = new System.Drawing.Point(12, 512);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(187, 61);
            this.Ok.TabIndex = 20;
            this.Ok.Text = "Искать";
            this.Ok.UseVisualStyleBackColor = false;
            this.Ok.Visible = false;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // DiapChooseMin
            // 
            this.DiapChooseMin.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DiapChooseMin.Location = new System.Drawing.Point(67, 430);
            this.DiapChooseMin.Multiline = true;
            this.DiapChooseMin.Name = "DiapChooseMin";
            this.DiapChooseMin.Size = new System.Drawing.Size(132, 27);
            this.DiapChooseMin.TabIndex = 21;
            this.DiapChooseMin.Visible = false;
            // 
            // DiapLabelMin
            // 
            this.DiapLabelMin.AutoSize = true;
            this.DiapLabelMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.DiapLabelMin.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DiapLabelMin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DiapLabelMin.Location = new System.Drawing.Point(12, 426);
            this.DiapLabelMin.Name = "DiapLabelMin";
            this.DiapLabelMin.Size = new System.Drawing.Size(38, 27);
            this.DiapLabelMin.TabIndex = 22;
            this.DiapLabelMin.Text = "От";
            this.DiapLabelMin.Visible = false;
            // 
            // DiapLabelMax
            // 
            this.DiapLabelMax.AutoSize = true;
            this.DiapLabelMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DiapLabelMax.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DiapLabelMax.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DiapLabelMax.Location = new System.Drawing.Point(12, 463);
            this.DiapLabelMax.Name = "DiapLabelMax";
            this.DiapLabelMax.Size = new System.Drawing.Size(42, 27);
            this.DiapLabelMax.TabIndex = 23;
            this.DiapLabelMax.Text = "До";
            this.DiapLabelMax.Visible = false;
            // 
            // DiapChooseMax
            // 
            this.DiapChooseMax.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DiapChooseMax.Location = new System.Drawing.Point(67, 463);
            this.DiapChooseMax.Multiline = true;
            this.DiapChooseMax.Name = "DiapChooseMax";
            this.DiapChooseMax.Size = new System.Drawing.Size(132, 27);
            this.DiapChooseMax.TabIndex = 24;
            this.DiapChooseMax.Visible = false;
            // 
            // Y1
            // 
            this.Y1.AutoSize = true;
            this.Y1.BackColor = System.Drawing.Color.White;
            this.Y1.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Y1.Location = new System.Drawing.Point(1210, 45);
            this.Y1.Name = "Y1";
            this.Y1.Size = new System.Drawing.Size(63, 23);
            this.Y1.TabIndex = 25;
            this.Y1.Text = "2018";
            this.Y1.UseVisualStyleBackColor = false;
            this.Y1.Visible = false;
            this.Y1.CheckedChanged += new System.EventHandler(this.Y1_CheckedChanged);
            // 
            // YearLab
            // 
            this.YearLab.AutoSize = true;
            this.YearLab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.YearLab.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YearLab.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.YearLab.Location = new System.Drawing.Point(1211, 12);
            this.YearLab.Name = "YearLab";
            this.YearLab.Size = new System.Drawing.Size(142, 27);
            this.YearLab.TabIndex = 26;
            this.YearLab.Text = "Год выпуска";
            this.YearLab.Visible = false;
            // 
            // Y2
            // 
            this.Y2.AutoSize = true;
            this.Y2.BackColor = System.Drawing.Color.White;
            this.Y2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Y2.Location = new System.Drawing.Point(1299, 45);
            this.Y2.Name = "Y2";
            this.Y2.Size = new System.Drawing.Size(67, 23);
            this.Y2.TabIndex = 27;
            this.Y2.Text = "2019";
            this.Y2.UseVisualStyleBackColor = false;
            this.Y2.Visible = false;
            this.Y2.CheckedChanged += new System.EventHandler(this.Y2_CheckedChanged);
            // 
            // Y3
            // 
            this.Y3.AutoSize = true;
            this.Y3.BackColor = System.Drawing.Color.White;
            this.Y3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Y3.Location = new System.Drawing.Point(1381, 45);
            this.Y3.Name = "Y3";
            this.Y3.Size = new System.Drawing.Size(67, 23);
            this.Y3.TabIndex = 28;
            this.Y3.Text = "2020";
            this.Y3.UseVisualStyleBackColor = false;
            this.Y3.Visible = false;
            this.Y3.CheckedChanged += new System.EventHandler(this.Y3_CheckedChanged);
            // 
            // Y4
            // 
            this.Y4.AutoSize = true;
            this.Y4.BackColor = System.Drawing.Color.White;
            this.Y4.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Y4.Location = new System.Drawing.Point(1210, 86);
            this.Y4.Name = "Y4";
            this.Y4.Size = new System.Drawing.Size(67, 23);
            this.Y4.TabIndex = 29;
            this.Y4.Text = "2021";
            this.Y4.UseVisualStyleBackColor = false;
            this.Y4.Visible = false;
            this.Y4.CheckedChanged += new System.EventHandler(this.Y4_CheckedChanged);
            // 
            // Y5
            // 
            this.Y5.AutoSize = true;
            this.Y5.BackColor = System.Drawing.Color.White;
            this.Y5.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Y5.Location = new System.Drawing.Point(1299, 86);
            this.Y5.Name = "Y5";
            this.Y5.Size = new System.Drawing.Size(67, 23);
            this.Y5.TabIndex = 30;
            this.Y5.Text = "2022";
            this.Y5.UseVisualStyleBackColor = false;
            this.Y5.Visible = false;
            this.Y5.CheckedChanged += new System.EventHandler(this.Y5_CheckedChanged);
            // 
            // Y6
            // 
            this.Y6.AutoSize = true;
            this.Y6.BackColor = System.Drawing.Color.White;
            this.Y6.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Y6.Location = new System.Drawing.Point(1381, 86);
            this.Y6.Name = "Y6";
            this.Y6.Size = new System.Drawing.Size(67, 23);
            this.Y6.TabIndex = 31;
            this.Y6.Text = "2023";
            this.Y6.UseVisualStyleBackColor = false;
            this.Y6.Visible = false;
            this.Y6.CheckedChanged += new System.EventHandler(this.Y6_CheckedChanged);
            // 
            // MaterLab
            // 
            this.MaterLab.AutoSize = true;
            this.MaterLab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.MaterLab.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaterLab.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MaterLab.Location = new System.Drawing.Point(1211, 126);
            this.MaterLab.Name = "MaterLab";
            this.MaterLab.Size = new System.Drawing.Size(118, 27);
            this.MaterLab.TabIndex = 32;
            this.MaterLab.Text = "Материал";
            this.MaterLab.Visible = false;
            // 
            // M1
            // 
            this.M1.AutoSize = true;
            this.M1.BackColor = System.Drawing.Color.White;
            this.M1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.M1.Location = new System.Drawing.Point(1366, 165);
            this.M1.Name = "M1";
            this.M1.Size = new System.Drawing.Size(82, 28);
            this.M1.TabIndex = 33;
            this.M1.Text = "Сталь";
            this.M1.UseVisualStyleBackColor = false;
            this.M1.Visible = false;
            this.M1.CheckedChanged += new System.EventHandler(this.M1_CheckedChanged);
            // 
            // M2
            // 
            this.M2.AutoSize = true;
            this.M2.BackColor = System.Drawing.Color.White;
            this.M2.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.M2.Location = new System.Drawing.Point(1210, 199);
            this.M2.Name = "M2";
            this.M2.Size = new System.Drawing.Size(94, 28);
            this.M2.TabIndex = 34;
            this.M2.Text = "Латунь";
            this.M2.UseVisualStyleBackColor = false;
            this.M2.Visible = false;
            this.M2.CheckedChanged += new System.EventHandler(this.M2_CheckedChanged);
            // 
            // M3
            // 
            this.M3.AutoSize = true;
            this.M3.BackColor = System.Drawing.Color.White;
            this.M3.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.M3.Location = new System.Drawing.Point(1210, 165);
            this.M3.Name = "M3";
            this.M3.Size = new System.Drawing.Size(130, 28);
            this.M3.TabIndex = 35;
            this.M3.Text = "Алюминий";
            this.M3.UseVisualStyleBackColor = false;
            this.M3.Visible = false;
            this.M3.CheckedChanged += new System.EventHandler(this.M3_CheckedChanged);
            // 
            // M4
            // 
            this.M4.AutoSize = true;
            this.M4.BackColor = System.Drawing.Color.White;
            this.M4.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.M4.Location = new System.Drawing.Point(1366, 199);
            this.M4.Name = "M4";
            this.M4.Size = new System.Drawing.Size(105, 28);
            this.M4.TabIndex = 36;
            this.M4.Text = "Пластик";
            this.M4.UseVisualStyleBackColor = false;
            this.M4.Visible = false;
            this.M4.CheckedChanged += new System.EventHandler(this.M4_CheckedChanged);
            // 
            // CatLab
            // 
            this.CatLab.AutoSize = true;
            this.CatLab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.CatLab.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CatLab.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CatLab.Location = new System.Drawing.Point(1210, 235);
            this.CatLab.Name = "CatLab";
            this.CatLab.Size = new System.Drawing.Size(120, 27);
            this.CatLab.TabIndex = 37;
            this.CatLab.Text = "Категория";
            this.CatLab.Visible = false;
            this.CatLab.Click += new System.EventHandler(this.CatLab_Click);
            // 
            // C1
            // 
            this.C1.AutoSize = true;
            this.C1.BackColor = System.Drawing.Color.White;
            this.C1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.C1.Location = new System.Drawing.Point(1366, 314);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(137, 28);
            this.C1.TabIndex = 38;
            this.C1.Text = "Смартфоны";
            this.C1.UseVisualStyleBackColor = false;
            this.C1.Visible = false;
            this.C1.CheckedChanged += new System.EventHandler(this.C1_CheckedChanged);
            // 
            // C2
            // 
            this.C2.AutoSize = true;
            this.C2.BackColor = System.Drawing.Color.White;
            this.C2.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.C2.Location = new System.Drawing.Point(1210, 270);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(117, 28);
            this.C2.TabIndex = 39;
            this.C2.Text = "Ноутбуки";
            this.C2.UseVisualStyleBackColor = false;
            this.C2.Visible = false;
            this.C2.CheckedChanged += new System.EventHandler(this.C2_CheckedChanged);
            // 
            // C3
            // 
            this.C3.AutoSize = true;
            this.C3.BackColor = System.Drawing.Color.White;
            this.C3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.C3.Location = new System.Drawing.Point(1364, 358);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(165, 23);
            this.C3.TabIndex = 40;
            this.C3.Text = "Бытовая техника";
            this.C3.UseVisualStyleBackColor = false;
            this.C3.Visible = false;
            this.C3.CheckedChanged += new System.EventHandler(this.C3_CheckedChanged);
            // 
            // C4
            // 
            this.C4.AutoSize = true;
            this.C4.BackColor = System.Drawing.Color.White;
            this.C4.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.C4.Location = new System.Drawing.Point(1210, 358);
            this.C4.Name = "C4";
            this.C4.Size = new System.Drawing.Size(128, 23);
            this.C4.TabIndex = 41;
            this.C4.Text = "Телевизоры";
            this.C4.UseVisualStyleBackColor = false;
            this.C4.Visible = false;
            this.C4.CheckedChanged += new System.EventHandler(this.C4_CheckedChanged);
            // 
            // C5
            // 
            this.C5.AutoSize = true;
            this.C5.BackColor = System.Drawing.Color.White;
            this.C5.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.C5.Location = new System.Drawing.Point(1210, 314);
            this.C5.Name = "C5";
            this.C5.Size = new System.Drawing.Size(127, 28);
            this.C5.TabIndex = 42;
            this.C5.Text = "Планшеты";
            this.C5.UseVisualStyleBackColor = false;
            this.C5.Visible = false;
            this.C5.CheckedChanged += new System.EventHandler(this.C5_CheckedChanged);
            // 
            // C6
            // 
            this.C6.AutoSize = true;
            this.C6.BackColor = System.Drawing.Color.White;
            this.C6.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.C6.Location = new System.Drawing.Point(1366, 270);
            this.C6.Name = "C6";
            this.C6.Size = new System.Drawing.Size(110, 28);
            this.C6.TabIndex = 43;
            this.C6.Text = "Гаджеты";
            this.C6.UseVisualStyleBackColor = false;
            this.C6.Visible = false;
            this.C6.CheckedChanged += new System.EventHandler(this.C6_CheckedChanged);
            // 
            // BatLab
            // 
            this.BatLab.AutoSize = true;
            this.BatLab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BatLab.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BatLab.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BatLab.Location = new System.Drawing.Point(1211, 414);
            this.BatLab.Name = "BatLab";
            this.BatLab.Size = new System.Drawing.Size(215, 27);
            this.BatLab.TabIndex = 44;
            this.BatLab.Text = "Акумулятор (мА·ч)";
            this.BatLab.Visible = false;
            // 
            // A1
            // 
            this.A1.AutoSize = true;
            this.A1.BackColor = System.Drawing.Color.White;
            this.A1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.A1.Location = new System.Drawing.Point(1215, 462);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(72, 28);
            this.A1.TabIndex = 45;
            this.A1.Text = "1000";
            this.A1.UseVisualStyleBackColor = false;
            this.A1.Visible = false;
            this.A1.CheckedChanged += new System.EventHandler(this.A1_CheckedChanged);
            // 
            // A2
            // 
            this.A2.AutoSize = true;
            this.A2.BackColor = System.Drawing.Color.White;
            this.A2.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.A2.Location = new System.Drawing.Point(1313, 462);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(72, 28);
            this.A2.TabIndex = 46;
            this.A2.Text = "2000";
            this.A2.UseVisualStyleBackColor = false;
            this.A2.Visible = false;
            this.A2.CheckedChanged += new System.EventHandler(this.A2_CheckedChanged);
            // 
            // A3
            // 
            this.A3.AutoSize = true;
            this.A3.BackColor = System.Drawing.Color.White;
            this.A3.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.A3.Location = new System.Drawing.Point(1414, 462);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(72, 28);
            this.A3.TabIndex = 47;
            this.A3.Text = "3000";
            this.A3.UseVisualStyleBackColor = false;
            this.A3.Visible = false;
            this.A3.CheckedChanged += new System.EventHandler(this.A3_CheckedChanged);
            // 
            // A4
            // 
            this.A4.AutoSize = true;
            this.A4.BackColor = System.Drawing.Color.White;
            this.A4.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.A4.Location = new System.Drawing.Point(1215, 522);
            this.A4.Name = "A4";
            this.A4.Size = new System.Drawing.Size(72, 28);
            this.A4.TabIndex = 48;
            this.A4.Text = "4000";
            this.A4.UseVisualStyleBackColor = false;
            this.A4.Visible = false;
            this.A4.CheckedChanged += new System.EventHandler(this.A4_CheckedChanged);
            // 
            // A6
            // 
            this.A6.AutoSize = true;
            this.A6.BackColor = System.Drawing.Color.White;
            this.A6.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.A6.Location = new System.Drawing.Point(1414, 522);
            this.A6.Name = "A6";
            this.A6.Size = new System.Drawing.Size(72, 28);
            this.A6.TabIndex = 49;
            this.A6.Text = "6000";
            this.A6.UseVisualStyleBackColor = false;
            this.A6.Visible = false;
            this.A6.CheckedChanged += new System.EventHandler(this.A6_CheckedChanged);
            // 
            // A5
            // 
            this.A5.AutoSize = true;
            this.A5.BackColor = System.Drawing.Color.White;
            this.A5.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.A5.Location = new System.Drawing.Point(1313, 522);
            this.A5.Name = "A5";
            this.A5.Size = new System.Drawing.Size(72, 28);
            this.A5.TabIndex = 50;
            this.A5.Text = "5000";
            this.A5.UseVisualStyleBackColor = false;
            this.A5.Visible = false;
            this.A5.CheckedChanged += new System.EventHandler(this.A5_CheckedChanged);
            // 
            // A8
            // 
            this.A8.AutoSize = true;
            this.A8.BackColor = System.Drawing.Color.White;
            this.A8.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.A8.Location = new System.Drawing.Point(1329, 582);
            this.A8.Name = "A8";
            this.A8.Size = new System.Drawing.Size(42, 28);
            this.A8.TabIndex = 51;
            this.A8.Text = "0";
            this.A8.UseVisualStyleBackColor = false;
            this.A8.Visible = false;
            this.A8.CheckedChanged += new System.EventHandler(this.A8_CheckedChanged);
            // 
            // A7
            // 
            this.A7.AutoSize = true;
            this.A7.BackColor = System.Drawing.Color.White;
            this.A7.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.A7.Location = new System.Drawing.Point(1216, 582);
            this.A7.Name = "A7";
            this.A7.Size = new System.Drawing.Size(72, 28);
            this.A7.TabIndex = 52;
            this.A7.Text = "8000";
            this.A7.UseVisualStyleBackColor = false;
            this.A7.Visible = false;
            this.A7.CheckedChanged += new System.EventHandler(this.A7_CheckedChanged);
            // 
            // Display
            // 
            this.Display.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.photo,
            this.bran,
            this.Cyear,
            this.mat,
            this.bat,
            this.Cat,
            this.cst});
            this.Display.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Display.HideSelection = false;
            this.Display.Location = new System.Drawing.Point(205, 84);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(999, 602);
            this.Display.TabIndex = 53;
            this.Display.UseCompatibleStateImageBehavior = false;
            this.Display.View = System.Windows.Forms.View.Details;
            this.Display.SelectedIndexChanged += new System.EventHandler(this.Display_SelectedIndexChanged);
            // 
            // photo
            // 
            this.photo.Text = "Изображение";
            this.photo.Width = 127;
            // 
            // bran
            // 
            this.bran.Text = "Бренд";
            this.bran.Width = 66;
            // 
            // Cyear
            // 
            this.Cyear.Text = "Год выпуска";
            this.Cyear.Width = 115;
            // 
            // mat
            // 
            this.mat.Text = "Материал корпуса";
            this.mat.Width = 166;
            // 
            // bat
            // 
            this.bat.Text = "Батарея(мА/ч)";
            this.bat.Width = 132;
            // 
            // Cat
            // 
            this.Cat.Text = "Категория";
            this.Cat.Width = 93;
            // 
            // cst
            // 
            this.cst.Text = "Цена";
            // 
            // ClientCartBut
            // 
            this.ClientCartBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(38)))), ((int)(((byte)(54)))));
            this.ClientCartBut.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClientCartBut.ForeColor = System.Drawing.Color.White;
            this.ClientCartBut.Location = new System.Drawing.Point(565, 12);
            this.ClientCartBut.Name = "ClientCartBut";
            this.ClientCartBut.Size = new System.Drawing.Size(281, 61);
            this.ClientCartBut.TabIndex = 54;
            this.ClientCartBut.Text = "Моя корзина🛒";
            this.ClientCartBut.UseVisualStyleBackColor = false;
            this.ClientCartBut.Click += new System.EventHandler(this.ClientCartBut_Click);
            // 
            // MainBut
            // 
            this.MainBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(38)))), ((int)(((byte)(54)))));
            this.MainBut.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainBut.ForeColor = System.Drawing.Color.White;
            this.MainBut.Location = new System.Drawing.Point(384, 12);
            this.MainBut.Name = "MainBut";
            this.MainBut.Size = new System.Drawing.Size(173, 61);
            this.MainBut.TabIndex = 55;
            this.MainBut.Text = "Домой🏚";
            this.MainBut.UseVisualStyleBackColor = false;
            this.MainBut.Click += new System.EventHandler(this.MainBut_Click);
            // 
            // Y7
            // 
            this.Y7.AutoSize = true;
            this.Y7.BackColor = System.Drawing.Color.White;
            this.Y7.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Y7.Location = new System.Drawing.Point(1462, 86);
            this.Y7.Name = "Y7";
            this.Y7.Size = new System.Drawing.Size(67, 23);
            this.Y7.TabIndex = 56;
            this.Y7.Text = "2024";
            this.Y7.UseVisualStyleBackColor = false;
            this.Y7.Visible = false;
            this.Y7.CheckedChanged += new System.EventHandler(this.Y7_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1587, 705);
            this.Controls.Add(this.Y7);
            this.Controls.Add(this.MainBut);
            this.Controls.Add(this.ClientCartBut);
            this.Controls.Add(this.Display);
            this.Controls.Add(this.A7);
            this.Controls.Add(this.A8);
            this.Controls.Add(this.A5);
            this.Controls.Add(this.A6);
            this.Controls.Add(this.A4);
            this.Controls.Add(this.A3);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.A1);
            this.Controls.Add(this.BatLab);
            this.Controls.Add(this.C6);
            this.Controls.Add(this.C5);
            this.Controls.Add(this.C4);
            this.Controls.Add(this.C3);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.CatLab);
            this.Controls.Add(this.M4);
            this.Controls.Add(this.M3);
            this.Controls.Add(this.M2);
            this.Controls.Add(this.M1);
            this.Controls.Add(this.MaterLab);
            this.Controls.Add(this.Y6);
            this.Controls.Add(this.Y5);
            this.Controls.Add(this.Y4);
            this.Controls.Add(this.Y3);
            this.Controls.Add(this.Y2);
            this.Controls.Add(this.YearLab);
            this.Controls.Add(this.Y1);
            this.Controls.Add(this.DiapChooseMax);
            this.Controls.Add(this.DiapLabelMax);
            this.Controls.Add(this.DiapLabelMin);
            this.Controls.Add(this.DiapChooseMin);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.Category);
            this.Controls.Add(this.ChooseCategory);
            this.Controls.Add(this.Favorit);
            this.Controls.Add(this.EnterA);
            this.Controls.Add(this.ExitButt);
            this.Controls.Add(this.SearchB);
            this.Controls.Add(this.Batery);
            this.Controls.Add(this.Material);
            this.Controls.Add(this.Cost);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.Brand);
            this.Controls.Add(this.ChooseBatery);
            this.Controls.Add(this.MaterialChoose);
            this.Controls.Add(this.ChooseYear);
            this.Controls.Add(this.ChooseBrand);
            this.Controls.Add(this.FiltrBut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FiltrBut;
        private System.Windows.Forms.ComboBox ChooseBrand;
        private System.Windows.Forms.ComboBox ChooseYear;
        private System.Windows.Forms.ComboBox MaterialChoose;
        private System.Windows.Forms.ComboBox ChooseBatery;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label Brand;
        private System.Windows.Forms.Label Year;
        private System.Windows.Forms.Label Cost;
        private System.Windows.Forms.Label Material;
        private System.Windows.Forms.Label Batery;
        private System.Windows.Forms.Button SearchB;
        private System.Windows.Forms.Button ExitButt;
        public System.Windows.Forms.Button EnterA;
        private System.Windows.Forms.Button Favorit;
        private System.Windows.Forms.ComboBox ChooseCategory;
        private System.Windows.Forms.Label Category;
        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.TextBox DiapChooseMin;
        private System.Windows.Forms.Label DiapLabelMin;
        private System.Windows.Forms.Label DiapLabelMax;
        private System.Windows.Forms.TextBox DiapChooseMax;
        private System.Windows.Forms.CheckBox Y1;
        private System.Windows.Forms.Label YearLab;
        private System.Windows.Forms.CheckBox Y2;
        private System.Windows.Forms.CheckBox Y3;
        private System.Windows.Forms.CheckBox Y4;
        private System.Windows.Forms.CheckBox Y5;
        private System.Windows.Forms.CheckBox Y6;
        private System.Windows.Forms.Label MaterLab;
        private System.Windows.Forms.CheckBox M1;
        private System.Windows.Forms.CheckBox M2;
        private System.Windows.Forms.CheckBox M3;
        private System.Windows.Forms.CheckBox M4;
        private System.Windows.Forms.Label CatLab;
        private System.Windows.Forms.CheckBox C1;
        private System.Windows.Forms.CheckBox C2;
        private System.Windows.Forms.CheckBox C3;
        private System.Windows.Forms.CheckBox C4;
        private System.Windows.Forms.CheckBox C5;
        private System.Windows.Forms.CheckBox C6;
        private System.Windows.Forms.Label BatLab;
        private System.Windows.Forms.CheckBox A1;
        private System.Windows.Forms.CheckBox A2;
        private System.Windows.Forms.CheckBox A3;
        private System.Windows.Forms.CheckBox A4;
        private System.Windows.Forms.CheckBox A6;
        private System.Windows.Forms.CheckBox A5;
        private System.Windows.Forms.CheckBox A8;
        private System.Windows.Forms.CheckBox A7;
        private System.Windows.Forms.ListView Display;
        private System.Windows.Forms.ColumnHeader photo;
        private System.Windows.Forms.ColumnHeader bran;
        private System.Windows.Forms.ColumnHeader Cyear;
        private System.Windows.Forms.ColumnHeader mat;
        private System.Windows.Forms.ColumnHeader bat;
        private System.Windows.Forms.ColumnHeader Cat;
        private System.Windows.Forms.ColumnHeader cst;
        private System.Windows.Forms.Button ClientCartBut;
        private System.Windows.Forms.Button MainBut;
        private System.Windows.Forms.CheckBox Y7;
    }
}

