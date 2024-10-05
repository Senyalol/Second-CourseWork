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

namespace KyrsFisr
{
    public partial class BuyerForm : Form
    {
        private Product prod;
        private string homeadres;
        private string getpoint;

        internal BuyerForm(Product p,string home,string point)
        {
            InitializeComponent();
            
            prod = p;
            homeadres = home;
            getpoint = point;
            GetDataFromDB();

        }

        private List<Product> Products = new List<Product>();

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

        //Кнопка для сокрытия формы
        private void CancelBut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BuyB_Click(object sender, EventArgs e)
        {

            string connectionString = "server=127.0.0.1;database=products;user=root;password="; // Установите соответствующие значения  users


            if(ChooseType.SelectedIndex == 0)
            {

                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();
                        using (MySqlCommand command = new MySqlCommand("UPDATE Product SET Count = Count - 1 WHERE ID = @ProductID", connection))
                        {
                            command.Parameters.AddWithValue("@ProductID", this.prod.ProductID);

                            // Выполнение команды
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Оплата прошла успешно! ваш товар будет в пункте выдаче по адресу: " + getpoint);
                            }
                            else
                            {
                                MessageBox.Show("Товар с таким ID не найден.");
                            }
                        }
                    }
                    this.Close();
            }
            

            else if (ChooseType.SelectedIndex == 1)
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand("UPDATE Product SET Count = Count - 1 WHERE ID = @ProductID", connection))
                    {
                        command.Parameters.AddWithValue("@ProductID", this.prod.ProductID);

                        // Выполнение команды
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Оплата прошла успешно! курьер доставит товар по адресу: " + homeadres);
                        }
                        else
                        {
                            MessageBox.Show("Товар с таким ID не найден.");
                        }
                    }
                }
                this.Close();
            }
            //
        }
    }
}
