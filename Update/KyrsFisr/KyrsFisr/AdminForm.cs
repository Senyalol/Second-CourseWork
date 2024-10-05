using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace KyrsFisr
{
    public partial class AdminForm : Form
    {

        private DataBaseClass DataBase;

        private AddProdForm AddProduct = new AddProdForm();

        internal AdminForm(DataBaseClass data)
        {
            InitializeComponent();
            GetDataFromDB();
            this.DataBase = data;

            for(int i = 0; i < products.Count; i++)
            {
                ChooseProduct.Items.Add(products[i].ProductID);
            }


            

        }

        public delegate void UpdateButtonColorDelegate(Color color, string text);
        public event UpdateButtonColorDelegate UpdateButtonColorEvent2;

        List<Product> products = new List<Product>();

        private string changphot;

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
                            ProductFromDB.count = reader.GetInt32("Count");
                            ProductFromDB.photop = reader.GetString("Фото");
                            ProductFromDB.photop = ProductFromDB.photop.Replace("\\\\", "\\");

                        };

                        products.Add(ProductFromDB);
                    }


                }
            }

            return products;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Color backColor = Color.FromArgb(227, 38, 54);
            string backText = "Войти";

            UpdateButtonColorEvent2?.Invoke(backColor, backText);
            this.Hide();
        }

        private void Hide_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        // Где-то вне метода
        ImageList imageList = new ImageList();

        // Словарь для хранения индексов изображений
        Dictionary<int, int> imageIndexes = new Dictionary<int, int>();

        //Действие выбора ID товара
        private void ChooseProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.AdminDisplay.Items.Clear();
            imageList.ImageSize = new Size(120, 75);

            for (int i = 0; i < products.Count; i++)
            {
                if (i == ChooseProduct.SelectedIndex)
                {
                   

                    ListViewItem ListItem = new ListViewItem(new string[] { "", products[i].Brand, Convert.ToString(products[i].ConstructYear), products[i].Material, Convert.ToString(products[i].Batery), products[i].Category, Convert.ToString(products[i].Cost) });

                    // Проверяем, есть ли уже индекс изображения для данного продукта
                    if (!imageIndexes.ContainsKey(i))
                    {
                        imageList.Images.Add(new Bitmap(products[i].photop));
                        imageIndexes.Add(i, imageList.Images.Count - 1); // Сохраняем индекс изображения
                    }

                    this.AdminDisplay.SmallImageList = imageList;
                    ListItem.ImageIndex = imageIndexes[i]; // Устанавливаем индекс изображения
                    AdminDisplay.Items.Add(ListItem);
                }
            }
        }

        //Кнопка изменить продукт
        private void ChangeProd_Click(object sender, EventArgs e)
        {
            if(ChooseProduct.SelectedIndex != -1)
            {
                if(label.Visible == false)
                {
                    label.Visible = true;
                    ChooseParamProd.Visible = true;
                }

                else
                {
                    label.Visible = false;
                    ChooseParamProd.Visible = false;
                    label3.Visible = false;
                    NewDataProduct.Visible = false;
                    OkBut.Visible = false;
                }

            }

            else
            {
                MessageBox.Show("Пожалуйста выберите ID товара который хотите изменить");
            }

        }

        //Действие выбор параметра продукта                 (Требуется серьезная доработка)
        private void ChooseParamProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            label3.Visible = true;
            NewDataProduct.Visible = true;
            OkBut.Visible = true;

            for (int i = 0; i < products.Count; i++)
            {
                if (i == ChooseProduct.SelectedIndex)
                {

                        if (ChooseParamProd.SelectedItem.ToString() == "Бренд")
                        {
                            NewDataProduct.Text = products[i].Brand.ToString();
                        }

                        else if (ChooseParamProd.SelectedItem.ToString() == "Год")
                        {
                            NewDataProduct.Text = products[i].ConstructYear.ToString();
                        }

                        else if (ChooseParamProd.SelectedItem.ToString() == "Материал")
                        {
                            NewDataProduct.Text = products[i].Material.ToString();
                        }

                        else if (ChooseParamProd.SelectedItem.ToString() == "Батарея")
                        {
                            NewDataProduct.Text = products[i].Batery.ToString();
                        }

                        else if (ChooseParamProd.SelectedItem.ToString() == "Категория")
                        {
                            NewDataProduct.Text = products[i].Category.ToString();
                        }

                        else if (ChooseParamProd.SelectedItem.ToString() == "Цена")
                        {
                            NewDataProduct.Text = products[i].Cost.ToString();
                        }

                        else if (ChooseParamProd.SelectedItem.ToString() == "Колличество")
                        {
                            NewDataProduct.Text = products[i].count.ToString();
                        }

                        else if (ChooseParamProd.SelectedItem.ToString() == "Фото")
                        {
                            this.NewDataProduct.Clear();
                            if(ChangePhoto.ShowDialog() == DialogResult.OK){

                                this.changphot = ChangePhoto.FileName;
                            }//ChangePhoto
                        }

                }
            }

        }

        //Кнопка добавить продукт
        private void AddProd_Click(object sender, EventArgs e)
        {
            AddProduct.Show();
        }

        //Кнопка удалить продукт
        private void DelProd_Click(object sender, EventArgs e)
        {
            
            string connectionString = "server=127.0.0.1;database=products;user=root;password="; // Установите соответствующие значения  users

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // Пример SQL-запроса для добавления данных в таблицу
                string query = "DELETE FROM product WHERE ID = @ID";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    int IDinDB = ChooseProduct.SelectedIndex + 1;
                    command.Parameters.AddWithValue("@ID", IDinDB);

                    command.ExecuteNonQuery();
                }

                connection.Close();
                MessageBox.Show("Товар был успешно удален из Базы Данных!");
            }

        }

        //Кнопка для внесения изменения в параметр продукта
        private void OkBut_Click(object sender, EventArgs e)
        {
            string connectionString = "server=127.0.0.1;database=products;user=root;password="; // Установите соответствующие значения  users

            int idprod = ChooseProduct.SelectedIndex + 1;
            string parameterName = ChooseParamProd.SelectedItem.ToString();
            string newValue = NewDataProduct.Text;

            if (ChooseParamProd.SelectedItem.ToString() == "Фото")
            {

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Пример SQL-запроса для добавления данных в таблицу
                    string query = $"UPDATE product SET {parameterName} = @newValue WHERE ID = @ID";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@ID", idprod);
                        command.Parameters.AddWithValue("@newValue", this.changphot);

                        command.ExecuteNonQuery();
                    }

                    connection.Close();
                    MessageBox.Show("Данные о товаре успешно перезаписаны!");
                }

            }

            else
            {
                 using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // Пример SQL-запроса для добавления данных в таблицу
                string query = $"UPDATE product SET {parameterName} = @newValue WHERE ID = @ID";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    
                    command.Parameters.AddWithValue("@ID", idprod);
                    command.Parameters.AddWithValue("@newValue",newValue);

                    command.ExecuteNonQuery();
                }

                connection.Close();
                MessageBox.Show("Данные о товаре успешно перезаписаны!");
            }
            }

        }
    }
}
