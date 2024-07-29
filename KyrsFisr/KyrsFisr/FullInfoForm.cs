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
using System.Windows.Media.Media3D;

namespace KyrsFisr
{
    public partial class FullInfoForm : Form
    {
        private DataBaseClass Data;

        public string InfoAboutAccountNow;
        Favorite fav = new Favorite();

        private string photka;
        internal FullInfoForm(string brand, int year, string mat, int bat, string cat, double cost, string photos, DataBaseClass dat, string defAcc)
        {
            InitializeComponent();
            

            this.TopMost = true;

            this.label2.Text = brand;
            this.label3.Text = Convert.ToString(year);
            this.label4.Text = mat;
            this.label5.Text = Convert.ToString(bat);
            this.label6.Text = cat;
            string round = cost.ToString("0.00");
            this.label7.Text = Convert.ToString(round);

            this.InfoAboutAccountNow = defAcc;

            //Размер фотки 535; 369

            Image photosas = Image.FromFile(photos);
            Bitmap resizedImage = new Bitmap(photosas, new Size(400, 300));
            this.DisplayForm.Image = resizedImage;
            this.DisplayForm.Size = new Size(400, 300);
            this.DisplayForm.SizeMode = PictureBoxSizeMode.StretchImage;
            //this.DisplayForm.Image = Image.FromFile(photos);
            this.photka = photos;

            Data = dat;
            GetDataFromDB();

        }


        //Метод закрытия формы
        private void ExButt_Click(object sender, EventArgs e)
        {
            this.label2.Text = null;
            this.label3.Text = null;
            this.label4.Text = null;
            this.label5.Text = null;
            this.label6.Text = null;
            this.label7.Text = null;

            this.Hide();
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

        private void BuyButton_Click(object sender, EventArgs e)
        {
            bool elementNotFound = true;
            for (int i = 0; i < Data.accounts.Count; i++)
            {
                if (Data.accounts[i].Login == InfoAboutAccountNow)
                {
                    elementNotFound = false;



              

                    for (int j = 0; j < Products.Count; j++)
                    {
                        if (Products[j].Brand == label2.Text && Products[j].ConstructYear == Convert.ToInt32(label3.Text) && Products[j].Material == label4.Text && Products[j].Batery == Convert.ToInt32(label5.Text) && Products[j].Category == label6.Text)
                        {
                            Product prod = new Product(Products[j].Brand, Products[j].ConstructYear, Products[j].Material, Products[j].Batery, Products[j].Category, Products[j].Cost, Products[j].ProductID);
                            BuyerForm buy = new BuyerForm(prod, Data.accounts[i].homeNumber, Data.accounts[i].Post);
                            buy.Show();
                        }
                    }



                }

            }

            if (elementNotFound)
            {
                MessageBox.Show("Чтобы использовать эту функцию необходимо войти в аккаунт.");
            }
        }

        //Метод добавления в корзину товара
        private void AddConBut_Click(object sender, EventArgs e)
        {
            bool elementNotFound = true;

            //Data.DefineAccount;
            for (int i = 0; i < Data.accounts.Count; i++)
            {

                if (Data.accounts[i].Login == InfoAboutAccountNow)
                {
                   elementNotFound = false;

                   string br =  this.label2.Text;
                   int yearConstr = Convert.ToInt32(this.label3.Text);
                   string mater = this.label4.Text;
                   int bt = Convert.ToInt32(this.label5.Text);
                   string ct =  this.label6.Text;
                   double cst = Convert.ToDouble(this.label7.Text);
                   int id;
                   
                   for(int ind = 0; ind < Products.Count; ind++)
                   {

                        if (Products[ind].Brand == br && Products[ind].ConstructYear == yearConstr && Products[ind].Material == mater && Products[ind].Batery == bt && Products[ind].Category == ct)
                        {
                            id = Products[ind].ProductID;
                            Product BuyItem = new Product(br, yearConstr, mater, bt, ct, cst, id);
                   
                            Data.accounts[i].ClientShopCart.Add(BuyItem);
                   
                            MessageBox.Show("Товар: " + this.label6.Text + " " + this.label2.Text + " был добавлен в корзину.");
                        }

                   }


                   
                }

            }

            if (elementNotFound)
            {
                MessageBox.Show("Чтобы использовать эту функцию необходимо войти в аккаунт.");
            }

        }

        //Метод для проверки на "Один конкретный товар в избранном"
        

        //Метод добавления товара в избранное
        private void FavoriteBut_Click(object sender, EventArgs e)
        {
            string brandF = this.label2.Text;
            int yearF = Convert.ToInt32(this.label3.Text);
            string matF = this.label4.Text;
            int batF = Convert.ToInt32(this.label5.Text);
            string catF = this.label6.Text;
            double costF = Convert.ToDouble(this.label7.Text);
            string photki = this.photka;
            int id = 1;

            Favorite favProd = new Favorite(brandF,yearF,matF,batF,catF,costF, id, photki);

            bool elementNotFound = true;

            for (int i = 0; i < Data.accounts.Count; i++)
            {

                if (Data.accounts[i].Login == InfoAboutAccountNow)
                {
                    elementNotFound = false;


                    if (Data.accounts[i].favorites.Count == 0)
                    {
                        Data.accounts[i].favorites.Add(favProd);
                        MessageBox.Show("Товар " + this.label6.Text + " добавлен в избранное");
                    }


                    else 
                    {
                        bool IsAlreadyAtFav = false;
                        for (int n = 0; n < Data.accounts[i].favorites.Count; n++)
                        {

                            if (Data.accounts[i].favorites[n].Brand == favProd.Brand && Data.accounts[i].favorites[n].ConstructYear == favProd.ConstructYear && Data.accounts[i].favorites[n].Material == favProd.Material && Data.accounts[i].favorites[n].Batery == favProd.Batery && Data.accounts[i].favorites[n].Category == favProd.Category && Data.accounts[i].favorites[n].Cost == favProd.Cost)
                            {
                                IsAlreadyAtFav = true;


                            }


                        }
                            if (!IsAlreadyAtFav)
                            {
                                 Data.accounts[i].favorites.Add(favProd);
                                 MessageBox.Show("Товар " + this.label6.Text + " добавлен в избранное");
                                 this.RemoveFavBut.Visible = true;
                            }
                           
                            else if (IsAlreadyAtFav)
                            {
                                MessageBox.Show("Этот товар уже в избранном");
                            }
                    }

                                
                     

                    
                
                }

            }

            if (elementNotFound)
            {
                MessageBox.Show("Чтобы использовать эту функцию необходимо войти в аккаунт.");
            }

        }

        //Метод удаления из избранного
        private void RemoveFavBut_Click(object sender, EventArgs e)
        {
            bool elementNotFound = true;
            bool isFav = true;

            for (int i = 0; i < Data.accounts.Count; i++)
            {
                if (Data.accounts[i].Login == InfoAboutAccountNow)
                {
                    elementNotFound = false;
                    for(int number = 0; number < Data.accounts[i].favorites.Count; number++)
                    {
                        if (Data.accounts[i].favorites[number].Brand == this.label2.Text && Data.accounts[i].favorites[number].Category == this.label6.Text)
                        {
                            isFav = false;
                            Data.accounts[i].favorites.RemoveAt(number);
                            MessageBox.Show("Товар был удален из избранного!");
                        }
                    }

                    if (isFav)
                    {
                        MessageBox.Show("Этот товар не находился в избранном");
                    }
                }
            }

              if (elementNotFound)
              {
                 MessageBox.Show("Чтобы использовать эту функцию необходимо войти в аккаунт");
              }

          

        }

        //Метод для удаления из корзины
        private void RemoveFromCartBut_Click(object sender, EventArgs e)
        {
            bool isNotFind = true;
            bool isNotFindCart = true;

                for(int i = 0; i < Data.accounts.Count; i++)
                {
                    if (Data.accounts[i].Login == InfoAboutAccountNow)
                    {
                        isNotFind = false;
                        for (int n=0; n < Data.accounts[i].ClientShopCart.Count; n++)
                        {
                            if (Data.accounts[i].ClientShopCart[n].Brand == this.label2.Text && Data.accounts[i].ClientShopCart[n].Category == this.label6.Text)
                            {
                                isNotFindCart = false;
                                Data.accounts[i].ClientShopCart.RemoveAt(n);
                                MessageBox.Show("Товар был удален из корзины товаров.");
                            }


                        }
                            
                        if (isNotFindCart)
                        {
                           MessageBox.Show("Данный товар не находился в вашей корзине товаров.");
                        }

                    }


                }

                if(isNotFind)
                {
                    MessageBox.Show("Чтобы использовать эту функцию необходимо войти в аккаунт.");
                }

        }

    }
}
