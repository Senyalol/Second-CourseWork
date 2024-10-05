using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;
using System.Windows.Markup;
using MySql.Data.MySqlClient;

namespace KyrsFisr
{
    public partial class MainForm : Form
    {
       
        internal static DataBaseClass DataBase = new DataBaseClass();

        AccountForm account = new AccountForm(DataBase); //Форма для авторизации аккаунтов
        ControlForm control = new ControlForm(DataBase); //Форма для управлением данными об аккаунте
        AdminForm Admin = new AdminForm(DataBase); //Форма администратора (не допилина)

        List<Product> Products = new List<Product>(); //Список продукции

        List<CheckBox> CheckBoxes = new List<CheckBox>();
        public string defineaccount;

        CheckCheckBox CHB = new CheckCheckBox();

        
        public MainForm()
        {
            InitializeComponent();
            this.ClientCartBut.Visible = false;
            //EnterA.BackColor = ColorInClass.Instance.colorbut;

            

            account.UpdateButtonColorEvent += Account_UpdateButtonColorEvent; //Делегаты для изменения цветов аккаунта
            control.UpdateButtonColorEvent2 += Account_UpdateButtonColorEvent; //Делегаты для изменения цветов аккаунта
            Admin.UpdateButtonColorEvent2 += Account_UpdateButtonColorEvent;


            GetDataFromDB();
            
            LoadData();
           
           // AppClientCartShop();

        }

        //Метод для передачи данных из БД в Лист продуктов
        internal List<Product> GetDataFromDB()
        {
            string connectionString = "server=127.0.0.1;database=products;user=root;password="; // Установите соответствующие значения  users

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM product"; // Замените на фактическую таблицу, из которой вы хотите извлечь данные
                MySqlCommand command = new MySqlCommand(query, connection);
                connection.Open();//sa

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Product ProductFromDB = new Product();
                        {
                            int sas = reader.GetInt32("ID");
                            ProductFromDB.Brand = reader.GetString("Бренд");
                            ProductFromDB.ConstructYear = reader.GetInt32("Год");
                            ProductFromDB.Material = reader.GetString("Материал");
                            ProductFromDB.Batery = reader.GetInt32("Батарея");
                            ProductFromDB.Category = reader.GetString("Категория");
                            ProductFromDB.Cost = reader.GetDouble("Цена");
                            ProductFromDB.ProductID = reader.GetInt32("ID");
                        };

                        Products.Add(ProductFromDB);
                    }
                }
            }

            return Products;
        }

        //Метод получения всех чекбоксов в лист
        public List<CheckBox> GetAllCheckboxes()
        {

            foreach(Control control in this.Controls)
            {

                if(control is CheckBox)
                {
                    CheckBoxes.Add((CheckBox)control);
                }

                else if(control.Controls.Count > 0)
                {
                    CheckBoxes.AddRange(GetAllCheckboxes());
                }

            }

            return CheckBoxes;
        }

        //Метод для работы дисплея (ListView)
        private void LoadData()
        {
            Display.Items.Clear();

            ImageList imageList = new ImageList();

            imageList.ImageSize = new Size(120, 75);



            string connectionString = "server=127.0.0.1;database=products;user=root;password="; // Установите соответствующие значения  users

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM product"; // Замените на фактическую таблицу, из которой вы хотите извлечь данные
                MySqlCommand command = new MySqlCommand(query, connection);
                connection.Open();//sa

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        imageList.Images.Add(new Bitmap(reader.GetString("Фото")));
                    }
                }
            }



            //
            //imageList.Images.Add(new Bitmap("C:\\Users\\semka\\source\\repos\\KyrsFisr\\images\\holod2.jpg"));
            //imageList.Images.Add(new Bitmap("C:\\Users\\semka\\source\\repos\\KyrsFisr\\images\\laptop.jpg"));

            Bitmap EmptyImage = new Bitmap(145,61);

            using(Graphics gr = Graphics.FromImage(EmptyImage))
            {
                gr.Clear(Color.White);
            }

            imageList.Images.Add(EmptyImage);

            Display.SmallImageList = imageList;

            //Вывод данных
            for(int i = 0; i < Products.Count; i++)
            {
                ListViewItem ListItem = new ListViewItem(new string[] {"", Products[i].Brand, Convert.ToString(Products[i].ConstructYear) , Products[i].Material, Convert.ToString(Products[i].Batery) , Products[i].Category, Convert.ToString(Products[i].Cost) } );
            
                ListItem.ImageIndex = i;
                Display.Items.Add(ListItem);
                
            }

            

        }
 

        //Метод для обновления состояния кнопки
        private void Account_UpdateButtonColorEvent(Color color, string text)
        {
            // Обновление цвета и текста кнопки на главной форме
            EnterA.BackColor = color;
            EnterA.Text = text;

            if (this.EnterA.Text == "Войти")
            {
                this.ClientCartBut.Visible = false;
            }

            else
            {
                this.ClientCartBut.Visible = true;
            }

        }

        //Кнопка фильтрации
        private void button1_Click(object sender, EventArgs e)
        {
            GetAllCheckboxes();

            if(this.YearLab.Visible == false)
            {

                this.YearLab.Visible = true;
                this.MaterLab.Visible = true;
                this.CatLab.Visible = true;
                this.BatLab.Visible = true;
                this.Y1.Visible = true;
                this.Y2.Visible = true;
                this.Y3.Visible = true;
                this.Y4.Visible = true;
                this.Y5.Visible = true;
                this.Y6.Visible = true;
                this.Y7.Visible = true;
                this.M1.Visible = true;
                this.M2.Visible = true;
                this.M3.Visible = true;
                this.M4.Visible = true;
                this.C1.Visible = true;
                this.C2.Visible = true;
                this.C3.Visible = true;
                this.C4.Visible = true;
                this.C5.Visible = true;
                this.C6.Visible = true;
                this.A1.Visible = true;
                this.A2.Visible = true;
                this.A3.Visible = true;
                this.A4.Visible = true;
                this.A5.Visible = true;
                this.A6.Visible = true;
                this.A7.Visible = true;
                this.A8.Visible = true;

            }

            else
            {
                this.YearLab.Visible = false;
                this.MaterLab.Visible = false;
                this.CatLab.Visible = false;
                this.BatLab.Visible = false;
                this.Y1.Visible = false;
                this.Y2.Visible = false;
                this.Y3.Visible = false;
                this.Y4.Visible = false;
                this.Y5.Visible = false;
                this.Y6.Visible = false;
                this.Y7.Visible = false;
                this.M1.Visible = false;
                this.M2.Visible = false;
                this.M3.Visible = false;
                this.M4.Visible = false;
                this.C1.Visible = false;
                this.C2.Visible = false;
                this.C3.Visible = false;
                this.C4.Visible = false;
                this.C5.Visible = false;
                this.C6.Visible = false;
                this.A1.Visible = false;
                this.A2.Visible = false;
                this.A3.Visible = false;
                this.A4.Visible = false;
                this.A5.Visible = false;
                this.A6.Visible = false;
                this.A7.Visible = false;
                this.A8.Visible = false;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //Кнопка выхода
        private void ExitButt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Кнопка входа
        
        //ssssssss
        private void EnterA_Click(object sender, EventArgs e)
        {
            
            if(EnterA.BackColor == Color.FromArgb(227, 38, 54))
            {
               // this.ClientCartBut.Visible = false;
                account.Show(); 
            }

            if (EnterA.BackColor == Color.Green)
            {
                //this.ClientCartBut.Visible = true;

                for(int i = 0; i < DataBase.accounts.Count; i++)
                {

                    if(DataBase.accounts[i].Login == EnterA.Text)
                    {

                        if (DataBase.accounts[i].Admin == false)
                        {
                            DataBase.DefineAccount = EnterA.Text;
                            control.Show();

                        }

                        else
                        {
                            DataBase.DefineAccount = EnterA.Text;
                            Admin.Show();
                        }

                    }

                }

            }



        }

        //sssssssssss
        private void SearchB_Click(object sender, EventArgs e)
        {

            if(this.Brand.Visible == false)
            {
                this.Brand.Visible = true;
                this.Year.Visible = true;
                this.Cost.Visible = true;
                this.Material.Visible = true;
                this.Batery.Visible = true;
                this.ChooseBrand.Visible = true;
                this.ChooseYear.Visible = true;
                this.DiapChooseMax.Visible = true;
                this.DiapChooseMin.Visible = true;
                this.DiapLabelMax.Visible = true;
                this.DiapLabelMin.Visible = true;
                this.MaterialChoose.Visible = true;
                this.ChooseBatery.Visible = true;
                this.Category.Visible = true;
                this.ChooseCategory.Visible = true;
                this.Ok.Visible = true;
            }

            else
            {
                this.Brand.Visible = false;
                this.Year.Visible = false;
                this.Cost.Visible = false;
                this.Material.Visible = false;
                this.Batery.Visible = false;
                this.ChooseBrand.Visible = false;
                this.ChooseYear.Visible = false;
                this.DiapChooseMax.Visible = false;
                this.DiapChooseMin.Visible = false;
                this.DiapLabelMax.Visible = false;
                this.DiapLabelMin.Visible = false;
                this.MaterialChoose.Visible = false;
                this.ChooseBatery.Visible = false;
                this.Category.Visible = false;
                this.ChooseCategory.Visible = false;
                this.Ok.Visible = false;
            }
        
        }


        private void CatLab_Click(object sender, EventArgs e)
        {

        }

        //Если я выбрал конкретный товар из списка
        private void Display_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Проверяем, выбран ли какой-либо элемент
            if (Display.SelectedItems.Count > 0)
            {
                // Получаем выбранный элемент
                ListViewItem selectedItem = Display.SelectedItems[0];

                // Извлекаем данные из выбранного элемента
                string Brand = selectedItem.SubItems[1].Text;
                int Construct = Convert.ToInt32(selectedItem.SubItems[2].Text);
                string Material = selectedItem.SubItems[3].Text;
                int Batery = Convert.ToInt32(selectedItem.SubItems[4].Text);
                string Category = selectedItem.SubItems[5].Text;

                int photoInd = selectedItem.ImageIndex;
                string imagePath = "";

                // Проверяем, содержит ли выбранный элемент изображение
                if (photoInd != -1)
                {
                    // Получаем изображение из ImageList
                    Image image = Display.SmallImageList.Images[photoInd];

                    // Сохраняем изображение во временный файл
                    string tempPath = Path.GetTempFileName();
                    image.Save(tempPath);

                    // Получаем путь к временному файлу
                    imagePath = tempPath;

                    // Проверка на правильный ввод цены (с плавающей точкой)
                    double costTech;
                    if (double.TryParse(selectedItem.SubItems[6].Text, out costTech))
                    {
                        this.defineaccount = EnterA.Text;
                        // Создаем и отображаем форму с данными выбранного элемента
                        FullInfoForm dataForm = new FullInfoForm(Brand, Construct, Material, Batery, Category, costTech, imagePath,DataBase,this.defineaccount);
                        dataForm.Show();
                    }

                }


               
                else
                {
                    // Отображаем сообщение об ошибке
                    MessageBox.Show("Некорректно указана цена:");
                }

            }
        }
  
        //При просмотре моей корзины
        private void ClientCartBut_Click(object sender, EventArgs e)
        {
            this.defineaccount = EnterA.Text;
            ClientCartForm BuyCon = new ClientCartForm(DataBase,this.defineaccount);
            BuyCon.Show();
        }

        //Метод для отображения избранных товаров
        private void Favorit_Click(object sender, EventArgs e)
        {
            this.Display.Items.Clear();
            ImageList imageList = new ImageList();

            imageList.ImageSize = new Size(145, 61);

            for (int num =  0; num < DataBase.accounts.Count; num++)
            {

                if (DataBase.accounts[num].Login == EnterA.Text )
                {
                    //Вывод данных
                    for (int i = 0; i < DataBase.accounts[num].favorites.Count; i++)
                    {
                        ListViewItem ListItem = new ListViewItem(new string[] { "", DataBase.accounts[num].favorites[i].Brand, Convert.ToString(DataBase.accounts[num].favorites[i].ConstructYear), DataBase.accounts[num].favorites[i].Material, Convert.ToString(DataBase.accounts[num].favorites[i].Batery), DataBase.accounts[num].favorites[i].Category, Convert.ToString(DataBase.accounts[num].favorites[i].Cost) });

                        imageList.Images.Add(new Bitmap(DataBase.accounts[num].favorites[i].photoPath));
                        this.Display.SmallImageList = imageList;
                        ListItem.ImageIndex = i;
                        Display.Items.Add(ListItem);

                    }
                }

            }

        }

        //Метод возвращающий дисплей в прежнее состояние
        private void MainBut_Click(object sender, EventArgs e)
        {
            this.Y1.Checked = false;
            this.Y2.Checked = false;
            this.Y3.Checked = false;
            this.Y4.Checked = false;
            this.Y5.Checked = false;
            this.Y6.Checked = false;
            this.Y7.Checked = false;
            this.M1.Checked = false;
            this.M2.Checked = false;
            this.M3.Checked = false;
            this.M4.Checked = false;
            this.C1.Checked = false; 
            this.C2.Checked = false;
            this.C3.Checked = false;
            this.C4.Checked = false;
            this.C5.Checked = false;
            this.C6.Checked = false;
            this.A1.Checked = false;
            this.A2.Checked = false;
            this.A3.Checked = false;
            this.A4.Checked = false;
            this.A5.Checked = false;
            this.A6.Checked = false;
            this.A7.Checked = false;
            this.A8.Checked = false;

            LoadData();
        }

        //Метод реализации кнопки, если нужно найти конкретный товар
        private void Ok_Click(object sender, EventArgs e)
        {

            //string FindBrand = ChooseBrand.SelectedItem.ToString();
            //int FindYear = Convert.ToInt32(ChooseYear.SelectedItem.ToString());
            //string FinMaterial = MaterialChoose.SelectedItem.ToString();
            //int FindBat = Convert.ToInt32(ChooseBatery.SelectedItem.ToString());
            //string FindCat = ChooseCategory.SelectedItem.ToString();
            int yearF;
            int batF;
           //string item = "";

           
           for(int i = 0; i < Products.Count; i++)
            {  
                   
                    //Проверку на то , что комбобокс не выбран
                    if (this.ChooseBrand != null && this.ChooseBrand.SelectedItem == null)
                    {
                        MessageBox.Show("Для точного поиска заполните поле Производитель");
                        break;
                    }

                    //Если ввели Бренд
                    else if (this.ChooseBrand.SelectedItem.ToString() == Products[i].Brand)
                    {
                        //Проверку на то , что комбобокс не выбран
                        if (this.ChooseYear != null && this.ChooseYear.SelectedItem == null)
                        {
                            MessageBox.Show("Для точного поиска заполните поле год выпуска");
                            break;
                        }

                        //Парсим год выпуска
                        if (int.TryParse(this.ChooseYear.SelectedItem.ToString(), out yearF))
                        {
                            //Если ввели год выпуска
                            if (Products[i].ConstructYear == yearF)
                            {

                                //Проверку на то , что комбобокс не выбран
                                if (this.MaterialChoose != null && this.MaterialChoose.SelectedItem == null)
                                {
                                    MessageBox.Show("Для точного поиска заполните поле материал");
                                    break;
                                }

                                //Если ввели материал корпуса
                                else if (this.MaterialChoose.SelectedItem.ToString() == Products[i].Material)
                                {

                                    //Проверку на то , что комбобокс не выбран
                                    if(this.ChooseBatery != null && this.ChooseBatery.SelectedItem == null)
                                    {
                                        MessageBox.Show("Для точного поиска заполните поле Батарея");
                                        break;
                                    }

                                    //Парсим параметры батареи
                                    if (int.TryParse(this.ChooseBatery.SelectedItem.ToString(), out batF))
                                        {
                                            //Если ввели батарею
                                            if (Products[i].Batery == batF)
                                            {
                                                //Проверку на то , что комбобокс не выбран
                                                if (this.ChooseCategory != null && this.ChooseCategory.SelectedItem == null)
                                                {
                                                    MessageBox.Show("Для точного поиска заполните поле Категория");
                                                    break;
                                                }

                                                //Если ввели категорию
                                                else if (this.ChooseCategory.SelectedItem.ToString() == Products[i].Category)
                                                {
                                                    //Если мы не указали цену                                                           
                                                    if (string.IsNullOrWhiteSpace(this.DiapChooseMin.Text) && string.IsNullOrWhiteSpace(this.DiapChooseMax.Text))
                                                    {
                                                        this.Display.Items.Clear();

                                                        ListViewItem ListItem = new ListViewItem(new string[] { "", Products[i].Brand, Convert.ToString(Products[i].ConstructYear), Products[i].Material, Convert.ToString(Products[i].Batery), Products[i].Category, Convert.ToString(Products[i].Cost) });

                                                        ListItem.ImageIndex = i;
                                                        Display.Items.Add(ListItem);
                                                    }

                                                    //Если указали цену
                                                    else 
                                                    {

                                                        //Парсим минимальную цену
                                                        double min, max;
                                                        if (double.TryParse(this.DiapChooseMin.Text, out min))
                                                        {
                                                            //Парсим максимальную цену
                                                            if (double.TryParse(this.DiapChooseMax.Text, out max))
                                                            {
                                                                
                                                                //Если нашел такой товар
                                                                if (Products[i].Cost >= min && Products[i].Cost <= max)
                                                                {
                                                                    this.Display.Items.Clear();

                                                                    ListViewItem ListItem = new ListViewItem(new string[] { "", Products[i].Brand, Convert.ToString(Products[i].ConstructYear), Products[i].Material, Convert.ToString(Products[i].Batery), Products[i].Category, Convert.ToString(Products[i].Cost) });

                                                                    ListItem.ImageIndex = i;
                                                                    Display.Items.Add(ListItem);
                                                                    
                                                                }
                                                                
                                                                //Если не нашел
                                                                else
                                                                {
                                                                    this.Display.Items.Clear();
                                                                }

                                                            }

                                                        }

                                                    
                                                    }

                                                }

                                            }

                                        }

                                }

                            }

                        }

                    }


            }


            }

        //Далее идут методы для ЧекБоксов (CheckBox)

        //ЧекБоксы с годом выпуска

        //2018
        private void Y1_CheckedChanged(object sender, EventArgs e)
        {
            //Года
            if (!this.Y2.Checked && !this.Y3.Checked && !this.Y4.Checked && !this.Y5.Checked && !this.Y6.Checked && !this.Y7.Checked)
            {
                //Материал
                if (!this.M2.Checked && !this.M3.Checked && !this.M4.Checked && !this.M1.Checked)
                {
                    //Категории
                    if (!this.C1.Checked && !this.C3.Checked && !this.C4.Checked && !this.C5.Checked && !this.C6.Checked && !this.C2.Checked)
                    {

                        //Батарея
                        if (!this.A2.Checked && !this.A3.Checked && !this.A4.Checked && !this.A5.Checked && !this.A6.Checked && !this.A7.Checked && !this.A8.Checked && !this.A1.Checked)
                        {

                            this.Display.Items.Clear();
                        }
                    }
                }

            }

            if (this.Y1.Checked)
            {

                for (int i = 0; i < Products.Count; i++)
                {
                    if (Convert.ToInt32(this.Y1.Text) == Products[i].ConstructYear)
                    {

                        ListViewItem ListItem = new ListViewItem(new string[] { "", Products[i].Brand, Convert.ToString(Products[i].ConstructYear), Products[i].Material, Convert.ToString(Products[i].Batery), Products[i].Category, Convert.ToString(Products[i].Cost) });

                        bool Notrepeat = true;
                        for (int n = 0; n < this.Display.Items.Count; n++)
                        {

                            if (this.Display.Items[n].SubItems[2].Text == Convert.ToString(Products[i].ConstructYear) && this.Display.Items[n].SubItems[3].Text == Products[i].Material && this.Display.Items[n].SubItems[4].Text == Convert.ToString(Products[i].Batery) && this.Display.Items[n].SubItems[5].Text == Products[i].Category)
                            {
                                Notrepeat = false;
                            }

                        }

                        if (Notrepeat)
                        {
                            ListItem.ImageIndex = i;
                            Display.Items.Add(ListItem);
                        }


                    }
                }

            }

            else if (!this.Y1.Checked)
            {

                for (int i = this.Display.Items.Count - 1; i >= 0; i--)
                {

                    if (this.Display.Items[i].SubItems[2].Text == this.Y1.Text)
                    {
                        this.Display.Items.RemoveAt(i);
                    }

                }

                // this.Display.Items.Clear();
            }


        }

        //2024
        private void Y7_CheckedChanged(object sender, EventArgs e)
        {

            if (!this.Y2.Checked && !this.Y3.Checked && !this.Y4.Checked && !this.Y5.Checked && !this.Y6.Checked && !this.Y1.Checked)
            {
                //Материал
                if (!this.M2.Checked && !this.M3.Checked && !this.M4.Checked && !this.M1.Checked)
                {
                    //Категории
                    if (!this.C1.Checked && !this.C3.Checked && !this.C4.Checked && !this.C5.Checked && !this.C6.Checked && !this.C2.Checked)
                    {

                        //Батарея
                        if (!this.A2.Checked && !this.A3.Checked && !this.A4.Checked && !this.A5.Checked && !this.A6.Checked && !this.A7.Checked && !this.A8.Checked && !this.A1.Checked)
                        {

                            this.Display.Items.Clear();
                        }
                    }
                }


            }

            if (this.Y7.Checked)
            {

                for (int i = 0; i < Products.Count; i++)
                {
                    if (Convert.ToInt32(this.Y7.Text) == Products[i].ConstructYear)
                    {

                        ListViewItem ListItem = new ListViewItem(new string[] { "", Products[i].Brand, Convert.ToString(Products[i].ConstructYear), Products[i].Material, Convert.ToString(Products[i].Batery), Products[i].Category, Convert.ToString(Products[i].Cost) });

                        bool Notrepeat = true;
                        for (int n = 0; n < this.Display.Items.Count; n++)
                        {

                            if (this.Display.Items[n].SubItems[2].Text == Convert.ToString(Products[i].ConstructYear) && this.Display.Items[n].SubItems[3].Text == Products[i].Material && this.Display.Items[n].SubItems[4].Text == Convert.ToString(Products[i].Batery) && this.Display.Items[n].SubItems[5].Text == Products[i].Category)
                            {
                                Notrepeat = false;
                            }

                        }

                        if (Notrepeat)
                        {
                            ListItem.ImageIndex = i;
                            Display.Items.Add(ListItem);
                        }

                    }
                }

            }

            else if (!this.Y7.Checked)
            {

                for (int i = this.Display.Items.Count - 1; i >= 0; i--)
                {

                    if (this.Display.Items[i].SubItems[2].Text == this.Y7.Text)
                    {
                        this.Display.Items.RemoveAt(i);
                    }

                }

                // this.Display.Items.Clear();
            }

        }

        //2019
        private void Y2_CheckedChanged(object sender, EventArgs e)
        {

            if (!this.Y1.Checked && !this.Y3.Checked && !this.Y4.Checked && !this.Y5.Checked && !this.Y6.Checked && !this.Y7.Checked)
            {
                //Материал
                if (!this.M2.Checked && !this.M3.Checked && !this.M4.Checked && !this.M1.Checked)
                {
                    //Категории
                    if (!this.C1.Checked && !this.C3.Checked && !this.C4.Checked && !this.C5.Checked && !this.C6.Checked && !this.C2.Checked)
                    {

                        //Батарея
                        if (!this.A2.Checked && !this.A3.Checked && !this.A4.Checked && !this.A5.Checked && !this.A6.Checked && !this.A7.Checked && !this.A8.Checked && !this.A1.Checked)
                        {

                            this.Display.Items.Clear();
                        }
                    }
                }
            }

            if (this.Y2.Checked)
            {

                for (int i = 0; i < Products.Count; i++)
                {
                    if (Convert.ToInt32(this.Y2.Text) == Products[i].ConstructYear)
                    {

                        ListViewItem ListItem = new ListViewItem(new string[] { "", Products[i].Brand, Convert.ToString(Products[i].ConstructYear), Products[i].Material, Convert.ToString(Products[i].Batery), Products[i].Category, Convert.ToString(Products[i].Cost) });

                        bool Notrepeat = true;
                        for (int n = 0; n < this.Display.Items.Count; n++)
                        {

                            if (this.Display.Items[n].SubItems[2].Text == Convert.ToString(Products[i].ConstructYear) && this.Display.Items[n].SubItems[3].Text == Products[i].Material && this.Display.Items[n].SubItems[4].Text == Convert.ToString(Products[i].Batery) && this.Display.Items[n].SubItems[5].Text == Products[i].Category)
                            {
                                Notrepeat = false;
                            }

                        }

                        if (Notrepeat)
                        {
                            ListItem.ImageIndex = i;
                            Display.Items.Add(ListItem);
                        }

                    }
                }

            }

            else if (!this.Y2.Checked)
            {

                for (int i = this.Display.Items.Count - 1; i >= 0; i--)
                {

                    if (this.Display.Items[i].SubItems[2].Text == this.Y2.Text)
                    {
                        this.Display.Items.RemoveAt(i);
                    }

                }

                // this.Display.Items.Clear();
            }

        }

        //2020
        private void Y3_CheckedChanged(object sender, EventArgs e)
        {
            if (!this.Y2.Checked && !this.Y1.Checked && !this.Y4.Checked && !this.Y5.Checked && !this.Y6.Checked && !this.Y7.Checked)
            {
                //Материал
                if (!this.M2.Checked && !this.M3.Checked && !this.M4.Checked && !this.M1.Checked)
                {
                    //Категории
                    if (!this.C1.Checked && !this.C3.Checked && !this.C4.Checked && !this.C5.Checked && !this.C6.Checked && !this.C2.Checked)
                    {

                        //Батарея
                        if (!this.A2.Checked && !this.A3.Checked && !this.A4.Checked && !this.A5.Checked && !this.A6.Checked && !this.A7.Checked && !this.A8.Checked && !this.A1.Checked)
                        {

                            this.Display.Items.Clear();
                        }
                    }
                }
            }

            if (this.Y3.Checked)
            {

                for (int i = 0; i < Products.Count; i++)
                {
                    if (Convert.ToInt32(this.Y3.Text) == Products[i].ConstructYear)
                    {

                        ListViewItem ListItem = new ListViewItem(new string[] { "", Products[i].Brand, Convert.ToString(Products[i].ConstructYear), Products[i].Material, Convert.ToString(Products[i].Batery), Products[i].Category, Convert.ToString(Products[i].Cost) });

                        bool Notrepeat = true;
                        for (int n = 0; n < this.Display.Items.Count; n++)
                        {

                            if (this.Display.Items[n].SubItems[2].Text == Convert.ToString(Products[i].ConstructYear) && this.Display.Items[n].SubItems[3].Text == Products[i].Material && this.Display.Items[n].SubItems[4].Text == Convert.ToString(Products[i].Batery) && this.Display.Items[n].SubItems[5].Text == Products[i].Category)
                            {
                                Notrepeat = false;
                            }

                        }

                        if (Notrepeat)
                        {
                            ListItem.ImageIndex = i;
                            Display.Items.Add(ListItem);
                        }

                    }
                }

            }

            else if (!this.Y3.Checked)
            {

                for (int i = this.Display.Items.Count - 1; i >= 0; i--)
                {

                    if (this.Display.Items[i].SubItems[2].Text == this.Y3.Text)
                    {
                        this.Display.Items.RemoveAt(i);
                    }

                }

                // this.Display.Items.Clear();
            }
        }

        //2021
        private void Y4_CheckedChanged(object sender, EventArgs e)
        {

            if (!this.Y2.Checked && !this.Y3.Checked && !this.Y1.Checked && !this.Y5.Checked && !this.Y6.Checked && !this.Y7.Checked)
            {
                //Материал
                if (!this.M2.Checked && !this.M3.Checked && !this.M4.Checked && !this.M1.Checked)
                {
                    //Категории
                    if (!this.C1.Checked && !this.C3.Checked && !this.C4.Checked && !this.C5.Checked && !this.C6.Checked && !this.C2.Checked)
                    {

                        //Батарея
                        if (!this.A2.Checked && !this.A3.Checked && !this.A4.Checked && !this.A5.Checked && !this.A6.Checked && !this.A7.Checked && !this.A8.Checked && !this.A1.Checked)
                        {

                            this.Display.Items.Clear();
                        }
                    }
                }
            }

            if (this.Y4.Checked)
            {

                for (int i = 0; i < Products.Count; i++)
                {
                    if (Convert.ToInt32(this.Y4.Text) == Products[i].ConstructYear)
                    {

                        ListViewItem ListItem = new ListViewItem(new string[] { "", Products[i].Brand, Convert.ToString(Products[i].ConstructYear), Products[i].Material, Convert.ToString(Products[i].Batery), Products[i].Category, Convert.ToString(Products[i].Cost) });

                        bool Notrepeat = true;
                        for (int n = 0; n < this.Display.Items.Count; n++)
                        {

                            if (this.Display.Items[n].SubItems[2].Text == Convert.ToString(Products[i].ConstructYear) && this.Display.Items[n].SubItems[3].Text == Products[i].Material && this.Display.Items[n].SubItems[4].Text == Convert.ToString(Products[i].Batery) && this.Display.Items[n].SubItems[5].Text == Products[i].Category)
                            {
                                Notrepeat = false;
                            }

                        }

                        if (Notrepeat)
                        {
                            ListItem.ImageIndex = i;
                            Display.Items.Add(ListItem);
                        }

                    }
                }

            }

            else if (!this.Y4.Checked)
            {

                for (int i = this.Display.Items.Count - 1; i >= 0; i--)
                {

                    if (this.Display.Items[i].SubItems[2].Text == this.Y4.Text)
                    {
                        this.Display.Items.RemoveAt(i);
                    }

                }

                // this.Display.Items.Clear();
            }

        }

        //2022
        private void Y5_CheckedChanged(object sender, EventArgs e)
        {

            if (!this.Y2.Checked && !this.Y3.Checked && !this.Y4.Checked && !this.Y1.Checked && !this.Y6.Checked && !this.Y7.Checked)
            {
                //Материал
                if (!this.M2.Checked && !this.M3.Checked && !this.M4.Checked && !this.M1.Checked)
                {
                    //Категории
                    if (!this.C1.Checked && !this.C3.Checked && !this.C4.Checked && !this.C5.Checked && !this.C6.Checked && !this.C2.Checked)
                    {

                        //Батарея
                        if (!this.A2.Checked && !this.A3.Checked && !this.A4.Checked && !this.A5.Checked && !this.A6.Checked && !this.A7.Checked && !this.A8.Checked && !this.A1.Checked)
                        {

                            this.Display.Items.Clear();
                        }
                    }
                }
            }

            if (this.Y5.Checked)
            {

                for (int i = 0; i < Products.Count; i++)
                {
                    if (Convert.ToInt32(this.Y5.Text) == Products[i].ConstructYear)
                    {

                        ListViewItem ListItem = new ListViewItem(new string[] { "", Products[i].Brand, Convert.ToString(Products[i].ConstructYear), Products[i].Material, Convert.ToString(Products[i].Batery), Products[i].Category, Convert.ToString(Products[i].Cost) });

                        bool Notrepeat = true;
                        for (int n = 0; n < this.Display.Items.Count; n++)
                        {

                            if (this.Display.Items[n].SubItems[2].Text == Convert.ToString(Products[i].ConstructYear) && this.Display.Items[n].SubItems[3].Text == Products[i].Material && this.Display.Items[n].SubItems[4].Text == Convert.ToString(Products[i].Batery) && this.Display.Items[n].SubItems[5].Text == Products[i].Category)
                            {
                                Notrepeat = false;
                            }

                        }

                        if (Notrepeat)
                        {
                            ListItem.ImageIndex = i;
                            Display.Items.Add(ListItem);
                        }

                    }
                }

            }

            else if (!this.Y5.Checked)
            {

                for (int i = this.Display.Items.Count - 1; i >= 0; i--)
                {

                    if (this.Display.Items[i].SubItems[2].Text == this.Y5.Text)
                    {
                        this.Display.Items.RemoveAt(i);
                    }

                }

                // this.Display.Items.Clear();
            }
        
        }

        //2023
        private void Y6_CheckedChanged(object sender, EventArgs e)
        {

            if (!this.Y2.Checked && !this.Y3.Checked && !this.Y4.Checked && !this.Y5.Checked && !this.Y1.Checked && !this.Y7.Checked)
            {
                //Материал
                if (!this.M2.Checked && !this.M3.Checked && !this.M4.Checked && !this.M1.Checked)
                {
                    //Категории
                    if (!this.C1.Checked && !this.C3.Checked && !this.C4.Checked && !this.C5.Checked && !this.C6.Checked && !this.C2.Checked)
                    {

                        //Батарея
                        if (!this.A2.Checked && !this.A3.Checked && !this.A4.Checked && !this.A5.Checked && !this.A6.Checked && !this.A7.Checked && !this.A8.Checked && !this.A1.Checked)
                        {

                            this.Display.Items.Clear();
                        }
                    }
                }
            }

            if (this.Y6.Checked)
            {

                for (int i = 0; i < Products.Count; i++)
                {
                    if (Convert.ToInt32(this.Y6.Text) == Products[i].ConstructYear)
                    {

                        ListViewItem ListItem = new ListViewItem(new string[] { "", Products[i].Brand, Convert.ToString(Products[i].ConstructYear), Products[i].Material, Convert.ToString(Products[i].Batery), Products[i].Category, Convert.ToString(Products[i].Cost) });

                        bool Notrepeat = true;
                        for (int n = 0; n < this.Display.Items.Count; n++)
                        {

                            if (this.Display.Items[n].SubItems[2].Text == Convert.ToString(Products[i].ConstructYear) && this.Display.Items[n].SubItems[3].Text == Products[i].Material && this.Display.Items[n].SubItems[4].Text == Convert.ToString(Products[i].Batery) && this.Display.Items[n].SubItems[5].Text == Products[i].Category)
                            {
                                Notrepeat = false;
                            }

                        }

                        if (Notrepeat)
                        {
                            ListItem.ImageIndex = i;
                            Display.Items.Add(ListItem);
                        }

                    }
                }

            }

            else if (!this.Y6.Checked)
            {

                for (int i = this.Display.Items.Count - 1; i >= 0; i--)
                {
                    if (this.Display.Items[i].SubItems[2].Text == this.Y6.Text)
                    {
                        this.Display.Items.RemoveAt(i);
                    }
                }

                // this.Display.Items.Clear();
            }
        
        }

                //Чекбоксы с материалом
        
        //Сталь
        private void M1_CheckedChanged(object sender, EventArgs e)
        {
            if (!this.M2.Checked && !this.M3.Checked && !this.M4.Checked)
            {
                this.Display.Items.Clear();
            }

            if (this.M1.Checked)
            {

                for (int i = 0; i < Products.Count; i++)
                {
                    if (this.M1.Text == Products[i].Material)
                    {

                        ListViewItem ListItem = new ListViewItem(new string[] { "", Products[i].Brand, Convert.ToString(Products[i].ConstructYear), Products[i].Material, Convert.ToString(Products[i].Batery), Products[i].Category, Convert.ToString(Products[i].Cost) });

                        ListItem.ImageIndex = i;
                        Display.Items.Add(ListItem);

                    }
                }

            }

            else if (!this.M1.Checked)
            {

                for (int i = this.Display.Items.Count - 1; i >= 0; i--)
                {

                    if (this.Display.Items[i].SubItems[3].Text == this.M1.Text)
                    {
                        this.Display.Items.RemoveAt(i);
                    }

                }

                // this.Display.Items.Clear();
            }
        }

        //Латунь
        private void M2_CheckedChanged(object sender, EventArgs e)
        {

            if (!this.M1.Checked && !this.M3.Checked && !this.M4.Checked)
            {
                this.Display.Items.Clear();
            }

            if (this.M2.Checked)
            {

                for (int i = 0; i < Products.Count; i++)
                {
                    if (this.M2.Text == Products[i].Material)
                    {

                        ListViewItem ListItem = new ListViewItem(new string[] { "", Products[i].Brand, Convert.ToString(Products[i].ConstructYear), Products[i].Material, Convert.ToString(Products[i].Batery), Products[i].Category, Convert.ToString(Products[i].Cost) });

                        ListItem.ImageIndex = i;
                        Display.Items.Add(ListItem);

                    }
                }

            }

            else if (!this.M2.Checked)
            {

                for (int i = this.Display.Items.Count - 1; i >= 0; i--)
                {

                    if (this.Display.Items[i].SubItems[3].Text == this.M2.Text)
                    {
                        this.Display.Items.RemoveAt(i);
                    }

                }

                // this.Display.Items.Clear();
            }

        }

        //Алюминий
        private void M3_CheckedChanged(object sender, EventArgs e)
        {
            if (!this.M2.Checked && !this.M1.Checked && !this.M4.Checked)
            {
                this.Display.Items.Clear();
            }

            if (this.M3.Checked)
            {

                for (int i = 0; i < Products.Count; i++)
                {
                    if (this.M3.Text == Products[i].Material)
                    {

                        ListViewItem ListItem = new ListViewItem(new string[] { "", Products[i].Brand, Convert.ToString(Products[i].ConstructYear), Products[i].Material, Convert.ToString(Products[i].Batery), Products[i].Category, Convert.ToString(Products[i].Cost) });

                        ListItem.ImageIndex = i;
                        Display.Items.Add(ListItem);

                    }
                }

            }

            else if (!this.M3.Checked)
            {

                for (int i = this.Display.Items.Count - 1; i >= 0; i--)
                {

                    if (this.Display.Items[i].SubItems[3].Text == this.M3.Text)
                    {
                        this.Display.Items.RemoveAt(i);
                    }

                }

                // this.Display.Items.Clear();
            }
        }

        //Пластик
        private void M4_CheckedChanged(object sender, EventArgs e)
        {
            if (!this.M2.Checked && !this.M3.Checked && !this.M1.Checked)
            {
                this.Display.Items.Clear();
            }

            if (this.M4.Checked)
            {

                for (int i = 0; i < Products.Count; i++)
                {
                    if (this.M4.Text == Products[i].Material)
                    {

                        ListViewItem ListItem = new ListViewItem(new string[] { "", Products[i].Brand, Convert.ToString(Products[i].ConstructYear), Products[i].Material, Convert.ToString(Products[i].Batery), Products[i].Category, Convert.ToString(Products[i].Cost) });

                        ListItem.ImageIndex = i;
                        Display.Items.Add(ListItem);

                    }
                }

            }

            else if (!this.M4.Checked)
            {

                for (int i = this.Display.Items.Count - 1; i >= 0; i--)
                {

                    if (this.Display.Items[i].SubItems[3].Text == this.M4.Text)
                    {
                        this.Display.Items.RemoveAt(i);
                    }

                }

                // this.Display.Items.Clear();
            }
        }

                //Чекбоксы категорий
        
        //Ноутбуки
        private void C2_CheckedChanged(object sender, EventArgs e)
        {
            if (!this.C1.Checked && !this.C3.Checked && !this.C4.Checked  && !this.C5.Checked && !this.C6.Checked)
            {
                this.Display.Items.Clear();
            }

            if (this.C2.Checked)
            {

                for (int i = 0; i < Products.Count; i++)
                {
                    if (this.C2.Text == Products[i].Category)
                    {

                        ListViewItem ListItem = new ListViewItem(new string[] { "", Products[i].Brand, Convert.ToString(Products[i].ConstructYear), Products[i].Material, Convert.ToString(Products[i].Batery), Products[i].Category, Convert.ToString(Products[i].Cost) });

                        ListItem.ImageIndex = i;
                        Display.Items.Add(ListItem);

                    }
                }

            }

            else if (!this.C2.Checked)
            {

                for (int i = this.Display.Items.Count - 1; i >= 0; i--)
                {

                    if (this.Display.Items[i].SubItems[5].Text == this.C2.Text)
                    {
                        this.Display.Items.RemoveAt(i);
                    }

                }

                // this.Display.Items.Clear();
            }
        }

        //Гаджеты
        private void C6_CheckedChanged(object sender, EventArgs e)
        {

            if (!this.C1.Checked && !this.C3.Checked && !this.C4.Checked && !this.C5.Checked && !this.C2.Checked)
            {
                this.Display.Items.Clear();
            }

            if (this.C6.Checked)
            {

                for (int i = 0; i < Products.Count; i++)
                {
                    if (this.C6.Text == Products[i].Category)
                    {

                        ListViewItem ListItem = new ListViewItem(new string[] { "", Products[i].Brand, Convert.ToString(Products[i].ConstructYear), Products[i].Material, Convert.ToString(Products[i].Batery), Products[i].Category, Convert.ToString(Products[i].Cost) });

                        ListItem.ImageIndex = i;
                        Display.Items.Add(ListItem);

                    }
                }

            }

            else if (!this.C6.Checked)
            {

                for (int i = this.Display.Items.Count - 1; i >= 0; i--)
                {

                    if (this.Display.Items[i].SubItems[5].Text == this.C6.Text)
                    {
                        this.Display.Items.RemoveAt(i);
                    }

                }

                // this.Display.Items.Clear();
            }

        }

        //Сматрфоны
        private void C1_CheckedChanged(object sender, EventArgs e)
        {

            if (!this.C2.Checked && !this.C3.Checked && !this.C4.Checked && !this.C5.Checked && !this.C6.Checked)
            {
                this.Display.Items.Clear();
            }

            if (this.C1.Checked)
            {

                for (int i = 0; i < Products.Count; i++)
                {
                    if (this.C1.Text == Products[i].Category)
                    {

                        ListViewItem ListItem = new ListViewItem(new string[] { "", Products[i].Brand, Convert.ToString(Products[i].ConstructYear), Products[i].Material, Convert.ToString(Products[i].Batery), Products[i].Category, Convert.ToString(Products[i].Cost) });

                        ListItem.ImageIndex = i;
                        Display.Items.Add(ListItem);

                    }
                }

            }

            else if (!this.C1.Checked)
            {

                for (int i = this.Display.Items.Count - 1; i >= 0; i--)
                {

                    if (this.Display.Items[i].SubItems[5].Text == this.C1.Text)
                    {
                        this.Display.Items.RemoveAt(i);
                    }

                }

                // this.Display.Items.Clear();
            }

        }

        //Телевизоры
        private void C4_CheckedChanged(object sender, EventArgs e)
        {

            if (!this.C1.Checked && !this.C3.Checked && !this.C2.Checked && !this.C5.Checked && !this.C6.Checked)
            {
                this.Display.Items.Clear();
            }

            if (this.C4.Checked)
            {

                for (int i = 0; i < Products.Count; i++)
                {
                    if (this.C4.Text == Products[i].Category)
                    {

                        ListViewItem ListItem = new ListViewItem(new string[] { "", Products[i].Brand, Convert.ToString(Products[i].ConstructYear), Products[i].Material, Convert.ToString(Products[i].Batery), Products[i].Category, Convert.ToString(Products[i].Cost) });

                        ListItem.ImageIndex = i;
                        Display.Items.Add(ListItem);

                    }
                }

            }

            else if (!this.C4.Checked)
            {

                for (int i = this.Display.Items.Count - 1; i >= 0; i--)
                {

                    if (this.Display.Items[i].SubItems[5].Text == this.C4.Text)
                    {
                        this.Display.Items.RemoveAt(i);
                    }

                }

                // this.Display.Items.Clear();
            }

        }

        //Планшеты
        private void C5_CheckedChanged(object sender, EventArgs e)
        {

            if (!this.C1.Checked && !this.C3.Checked && !this.C4.Checked && !this.C2.Checked && !this.C6.Checked)
            {
                this.Display.Items.Clear();
            }

            if (this.C5.Checked)
            {

                for (int i = 0; i < Products.Count; i++)
                {
                    if (this.C5.Text == Products[i].Category)
                    {

                        ListViewItem ListItem = new ListViewItem(new string[] { "", Products[i].Brand, Convert.ToString(Products[i].ConstructYear), Products[i].Material, Convert.ToString(Products[i].Batery), Products[i].Category, Convert.ToString(Products[i].Cost) });

                        ListItem.ImageIndex = i;
                        Display.Items.Add(ListItem);

                    }
                }

            }

            else if (!this.C5.Checked)
            {

                for (int i = this.Display.Items.Count - 1; i >= 0; i--)
                {

                    if (this.Display.Items[i].SubItems[5].Text == this.C5.Text)
                    {
                        this.Display.Items.RemoveAt(i);
                    }

                }

                // this.Display.Items.Clear();
            }

        }

        //Бытовая техника
        private void C3_CheckedChanged(object sender, EventArgs e)
        {

            if (!this.C1.Checked && !this.C2.Checked && !this.C4.Checked && !this.C5.Checked && !this.C6.Checked)
            {
                this.Display.Items.Clear();
            }

            if (this.C3.Checked)
            {

                for (int i = 0; i < Products.Count; i++)
                {
                    if (this.C3.Text == Products[i].Category)
                    {

                        ListViewItem ListItem = new ListViewItem(new string[] { "", Products[i].Brand, Convert.ToString(Products[i].ConstructYear), Products[i].Material, Convert.ToString(Products[i].Batery), Products[i].Category, Convert.ToString(Products[i].Cost) });

                        ListItem.ImageIndex = i;
                        Display.Items.Add(ListItem);

                    }
                }

            }

            else if (!this.C3.Checked)
            {

                for (int i = this.Display.Items.Count - 1; i >= 0; i--)
                {

                    if (this.Display.Items[i].SubItems[5].Text == this.C3.Text)
                    {
                        this.Display.Items.RemoveAt(i);
                    }

                }

                // this.Display.Items.Clear();
            }

        }

                //Чекбоксы аккумуляторов

        //1000 
        private void A1_CheckedChanged(object sender, EventArgs e)
        {
            if (!this.A2.Checked && !this.A3.Checked && !this.A4.Checked && !this.A5.Checked && !this.A6.Checked && !this.A7.Checked && !this.A8.Checked)
            {
                this.Display.Items.Clear();
            }

            if (this.A1.Checked)
            {

                for (int i = 0; i < Products.Count; i++)
                {
                    if (Convert.ToInt32(this.A1.Text) == Products[i].Batery)
                    {

                        ListViewItem ListItem = new ListViewItem(new string[] { "", Products[i].Brand, Convert.ToString(Products[i].ConstructYear), Products[i].Material, Convert.ToString(Products[i].Batery), Products[i].Category, Convert.ToString(Products[i].Cost) });

                        ListItem.ImageIndex = i;
                        Display.Items.Add(ListItem);

                    }
                }

            }

            else if (!this.A1.Checked)
            {

                for (int i = this.Display.Items.Count - 1; i >= 0; i--)
                {

                    if (this.Display.Items[i].SubItems[4].Text == this.A1.Text)
                    {
                        this.Display.Items.RemoveAt(i);
                    }

                }

                // this.Display.Items.Clear();
            }
        }

        //2000
        private void A2_CheckedChanged(object sender, EventArgs e)
        {

            if (!this.A1.Checked && !this.A3.Checked && !this.A4.Checked && !this.A5.Checked && !this.A6.Checked && !this.A7.Checked && !this.A8.Checked)
            {
                this.Display.Items.Clear();
            }

            if (this.A2.Checked)
            {

                for (int i = 0; i < Products.Count; i++)
                {
                    if (Convert.ToInt32(this.A2.Text) == Products[i].Batery)
                    {

                        ListViewItem ListItem = new ListViewItem(new string[] { "", Products[i].Brand, Convert.ToString(Products[i].ConstructYear), Products[i].Material, Convert.ToString(Products[i].Batery), Products[i].Category, Convert.ToString(Products[i].Cost) });

                        ListItem.ImageIndex = i;
                        Display.Items.Add(ListItem);

                    }
                }

            }

            else if (!this.A2.Checked)
            {

                for (int i = this.Display.Items.Count - 1; i >= 0; i--)
                {

                    if (this.Display.Items[i].SubItems[4].Text == this.A2.Text)
                    {
                        this.Display.Items.RemoveAt(i);
                    }

                }

                // this.Display.Items.Clear();
            }

        }

        //3000
        private void A3_CheckedChanged(object sender, EventArgs e)
        {
            if (!this.A2.Checked && !this.A1.Checked && !this.A4.Checked && !this.A5.Checked && !this.A6.Checked && !this.A7.Checked && !this.A8.Checked)
            {
                this.Display.Items.Clear();
            }

            if (this.A3.Checked)
            {

                for (int i = 0; i < Products.Count; i++)
                {
                    if (Convert.ToInt32(this.A3.Text) == Products[i].Batery)
                    {

                        ListViewItem ListItem = new ListViewItem(new string[] { "", Products[i].Brand, Convert.ToString(Products[i].ConstructYear), Products[i].Material, Convert.ToString(Products[i].Batery), Products[i].Category, Convert.ToString(Products[i].Cost) });

                        ListItem.ImageIndex = i;
                        Display.Items.Add(ListItem);

                    }
                }

            }

            else if (!this.A3.Checked)
            {

                for (int i = this.Display.Items.Count - 1; i >= 0; i--)
                {

                    if (this.Display.Items[i].SubItems[4].Text == this.A3.Text)
                    {
                        this.Display.Items.RemoveAt(i);
                    }

                }

                // this.Display.Items.Clear();
            }
        }

        //4000
        private void A4_CheckedChanged(object sender, EventArgs e)
        {

            if (!this.A2.Checked && !this.A3.Checked && !this.A1.Checked && !this.A5.Checked && !this.A6.Checked && !this.A7.Checked && !this.A8.Checked)
            {
                this.Display.Items.Clear();
            }

            if (this.A4.Checked)
            {

                for (int i = 0; i < Products.Count; i++)
                {
                    if (Convert.ToInt32(this.A4.Text) == Products[i].Batery)
                    {

                        ListViewItem ListItem = new ListViewItem(new string[] { "", Products[i].Brand, Convert.ToString(Products[i].ConstructYear), Products[i].Material, Convert.ToString(Products[i].Batery), Products[i].Category, Convert.ToString(Products[i].Cost) });

                        ListItem.ImageIndex = i;
                        Display.Items.Add(ListItem);

                    }
                }

            }

            else if (!this.A4.Checked)
            {

                for (int i = this.Display.Items.Count - 1; i >= 0; i--)
                {

                    if (this.Display.Items[i].SubItems[4].Text == this.A4.Text)
                    {
                        this.Display.Items.RemoveAt(i);
                    }

                }

                // this.Display.Items.Clear();
            }

        }

        //5000
        private void A5_CheckedChanged(object sender, EventArgs e)
        {

            if (!this.A2.Checked && !this.A3.Checked && !this.A4.Checked && !this.A1.Checked && !this.A6.Checked && !this.A7.Checked && !this.A8.Checked)
            {
                this.Display.Items.Clear();
            }

            if (this.A5.Checked)
            {

                for (int i = 0; i < Products.Count; i++)
                {
                    if (Convert.ToInt32(this.A5.Text) == Products[i].Batery)
                    {

                        ListViewItem ListItem = new ListViewItem(new string[] { "", Products[i].Brand, Convert.ToString(Products[i].ConstructYear), Products[i].Material, Convert.ToString(Products[i].Batery), Products[i].Category, Convert.ToString(Products[i].Cost) });

                        ListItem.ImageIndex = i;
                        Display.Items.Add(ListItem);

                    }
                }

            }

            else if (!this.A5.Checked)
            {

                for (int i = this.Display.Items.Count - 1; i >= 0; i--)
                {

                    if (this.Display.Items[i].SubItems[4].Text == this.A5.Text)
                    {
                        this.Display.Items.RemoveAt(i);
                    }

                }

                // this.Display.Items.Clear();
            }

        }

        //6000
        private void A6_CheckedChanged(object sender, EventArgs e)
        {

            if (!this.A2.Checked && !this.A3.Checked && !this.A4.Checked && !this.A5.Checked && !this.A1.Checked && !this.A7.Checked && !this.A8.Checked)
            {
                this.Display.Items.Clear();
            }

            if (this.A6.Checked)
            {

                for (int i = 0; i < Products.Count; i++)
                {
                    if (Convert.ToInt32(this.A6.Text) == Products[i].Batery)
                    {

                        ListViewItem ListItem = new ListViewItem(new string[] { "", Products[i].Brand, Convert.ToString(Products[i].ConstructYear), Products[i].Material, Convert.ToString(Products[i].Batery), Products[i].Category, Convert.ToString(Products[i].Cost) });

                        ListItem.ImageIndex = i;
                        Display.Items.Add(ListItem);

                    }
                }

            }

            else if (!this.A6.Checked)
            {

                for (int i = this.Display.Items.Count - 1; i >= 0; i--)
                {

                    if (this.Display.Items[i].SubItems[4].Text == this.A6.Text)
                    {
                        this.Display.Items.RemoveAt(i);
                    }

                }

                // this.Display.Items.Clear();
            }

        }

        //8000
        private void A7_CheckedChanged(object sender, EventArgs e)
        {

            if (!this.A2.Checked && !this.A3.Checked && !this.A4.Checked && !this.A5.Checked && !this.A6.Checked && !this.A1.Checked && !this.A8.Checked)
            {
                this.Display.Items.Clear();
            }

            if (this.A7.Checked)
            {

                for (int i = 0; i < Products.Count; i++)
                {
                    if (Convert.ToInt32(this.A7.Text) == Products[i].Batery)
                    {

                        ListViewItem ListItem = new ListViewItem(new string[] { "", Products[i].Brand, Convert.ToString(Products[i].ConstructYear), Products[i].Material, Convert.ToString(Products[i].Batery), Products[i].Category, Convert.ToString(Products[i].Cost) });

                        ListItem.ImageIndex = i;
                        Display.Items.Add(ListItem);

                    }
                }

            }

            else if (!this.A7.Checked)
            {

                for (int i = this.Display.Items.Count - 1; i >= 0; i--)
                {

                    if (this.Display.Items[i].SubItems[4].Text == this.A7.Text)
                    {
                        this.Display.Items.RemoveAt(i);
                    }

                }

                // this.Display.Items.Clear();
            }

        }

        //Отсутсвтует
        private void A8_CheckedChanged(object sender, EventArgs e)
        {

            if (!this.A2.Checked && !this.A3.Checked && !this.A4.Checked && !this.A5.Checked && !this.A6.Checked && !this.A7.Checked && !this.A1.Checked)
            {
                this.Display.Items.Clear();
            }

            if (this.A8.Checked)
            {

                for (int i = 0; i < Products.Count; i++)
                {
                    if (Convert.ToInt32(this.A8.Text) == Products[i].Batery)
                    {

                        ListViewItem ListItem = new ListViewItem(new string[] { "", Products[i].Brand, Convert.ToString(Products[i].ConstructYear), Products[i].Material, Convert.ToString(Products[i].Batery), Products[i].Category, Convert.ToString(Products[i].Cost) });

                        ListItem.ImageIndex = i;
                        Display.Items.Add(ListItem);

                    }
                }

            }

            else if (!this.A8.Checked)
            {

                for (int i = this.Display.Items.Count - 1; i >= 0; i--)
                {

                    if (this.Display.Items[i].SubItems[4].Text == this.A8.Text)
                    {
                        this.Display.Items.RemoveAt(i);
                    }

                }

                // this.Display.Items.Clear();
            }

        }

    }

    }

