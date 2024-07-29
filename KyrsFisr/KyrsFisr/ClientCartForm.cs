using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;

namespace KyrsFisr
{
    public partial class ClientCartForm : Form
    {
        public string log;
        DataBaseClass DB = new DataBaseClass();

        List<Product> products = new List<Product>();

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

                        products.Add(ProductFromDB);
                    }
                }
            }

            return products;
        }

        internal ClientCartForm(DataBaseClass data,string defineLogin)
        {
            InitializeComponent();
            this.TopMost = true;

            this.log = defineLogin;

            GetDataFromDB();

            for(int i = 0; i < data.accounts.Count; i++)
            {

                if (data.accounts[i].Login == defineLogin)
                {

                    for(int ind = 0; ind < data.accounts[i].ClientShopCart.Count; ind++)
                    {
                        int refreshind = ind + 1;
                        string item = "№" + refreshind + " " + data.accounts[i].ClientShopCart[ind].Brand + " " + data.accounts[i].ClientShopCart[ind].Category;
                        this.DisplayCart2.Items.Add(item); 
                           
                    }

                }

            }
            this.DisplayCart2.Refresh();

            DB = data;

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BuyButton_Click(object sender, EventArgs e)
        {

            string connectionString = "server=127.0.0.1;database=products;user=root;password="; // Установите соответствующие значения  users

            for (int i = 0; i < DB.accounts.Count; i++)
            {

                if (DB.accounts[i].Login == log)
                {

                    for(int ind = 0; ind < DB.accounts[i].ClientShopCart.Count; ind++)
                    {

                        using (MySqlConnection connection = new MySqlConnection(connectionString))
                        {
                            connection.Open();
                            using (MySqlCommand command = new MySqlCommand("UPDATE Product SET Count = Count - 1 WHERE ID = @ProductID", connection))
                            {
                                
                                command.Parameters.AddWithValue("@ProductID", DB.accounts[i].ClientShopCart[ind].ProductID);

                                

                                // Выполнение команды
                                int rowsAffected = command.ExecuteNonQuery();

                                if (rowsAffected <= 0)
                                {
                                    MessageBox.Show("Товар с таким ID не найден.");
                                    
                                }
                              
                            }
                        }


                    }

                }

            }

            for (int i = 0; i < DB.accounts.Count; i++)
            {

                if (DB.accounts[i].Login == log)
                {

                    DB.accounts[i].ClientShopCart.Clear();

                }
            }

            MessageBox.Show("Все товары, которые находились у вас в корзине , успешно оплачены!");
            this.DisplayCart2.Items.Clear();
        }

        //Метод кнопки для удаления товара из корзины
        private void RemoveBut_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < DB.accounts.Count; i++)
            {
                if (DB.accounts[i].Login == log)
                {
                    // Удаляем элементы в обратном порядке
                    for (int j = DisplayCart2.CheckedIndices.Count - 1; j >= 0; j--)
                    {
                        int index = DisplayCart2.CheckedIndices[j];

                        // Удаляем элемент из корзины
                        DB.accounts[i].ClientShopCart.RemoveAt(index);

                        // Обновляем CheckedListBox, чтобы он отражал изменения
                        DisplayCart2.Items.RemoveAt(index);
                    }
                }
            }

            // Обновление UI
            DisplayCart2.Refresh();
        }


    }
}
