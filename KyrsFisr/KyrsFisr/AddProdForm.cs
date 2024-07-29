using Microsoft.Win32;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace KyrsFisr
{
    public partial class AddProdForm : Form
    {

        CheckNumberOnly numcheck = new CheckNumberOnly();
        CheckOnlyString str = new CheckOnlyString();

        public AddProdForm()
        {
            InitializeComponent();
        }

        //Кнопка для сокрытия формы
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        //Кнопка для внесения данных о товаре в БД
        private void AddBut_Click(object sender, EventArgs e)
        {

            //Провекра
            if(numcheck.check(IDBox.Text) == true &&

               numcheck.check(YearBox.Text) == true &&
               numcheck.check(BateryBox.Text) == true &&
               numcheck.check(CountBox.Text) == true  &&
               str.check(BrandBox.Text) == true &&
               str.check(MaterialBox.Text) == true)
                
                {

                int addID = Convert.ToInt32(IDBox.Text);
                string addBrand = BrandBox.Text;
                int addYear = Convert.ToInt32(YearBox.Text);
                string addmaterial = MaterialBox.Text;
                int addbatery = Convert.ToInt32(BateryBox.Text);
                string addcategory = CatBox.SelectedItem.ToString();
                float addcost = float.Parse(CostBox.Text);
                int addcount = Convert.ToInt32(CountBox.Text);
                string addphoto = ChoosePhoto.FileName;


                string connectionString = "server=127.0.0.1;database=products;user=root;password=";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();


                    string query = "INSERT INTO product (ID,Бренд,Год,Материал,Батарея,Категория,Цена,Count,Фото) VALUES (@значениеID" +
                        ",@значениеBrand,@значениеYear,@значениеMaterial,@значениеBat,@значениеCat,@значениеCost,@значениеCount,@значениеPhoto)";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@значениеID", addID);
                        command.Parameters.AddWithValue("@значениеBrand", addBrand);
                        command.Parameters.AddWithValue("@значениеYear", addYear);
                        command.Parameters.AddWithValue("@значениеMaterial", addmaterial);
                        command.Parameters.AddWithValue("@значениеBat", addbatery);
                        command.Parameters.AddWithValue("@значениеCat", addcategory);
                        command.Parameters.AddWithValue("@значениеCost", addcost);
                        command.Parameters.AddWithValue("@значениеCount", addcount);
                        command.Parameters.AddWithValue("@значениеPhoto", addphoto);

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Товар был внесен в Базу Данных!");
                
                    IDBox.Clear();
                    BrandBox.Clear();
                    YearBox.Clear();
                    MaterialBox.Clear();
                    BateryBox.Clear();
                    CatBox.SelectedItem = "";
                    CostBox.Clear();
                    CountBox.Clear();

                }

                }

        }

        //Кнопка для выбора фотографии
        private void FindFileBut_Click(object sender, EventArgs e)
        {
            // ChoosePhoto.ShowDialog(this);
            ChoosePhoto.Filter = "Изображения (*.jpg, *.png)|*.jpg;*.png|Все файлы (*.*)|*.*";

            if (ChoosePhoto.ShowDialog() == DialogResult.OK)
            {
                
                string photonow = ChoosePhoto.FileName; 
                Image photka = Image.FromFile(photonow);

                Bitmap resizedImage = new Bitmap(photka, new Size(300, 300));
                
                ShowPict.Image = resizedImage;
                ShowPict.Size = new Size(300, 300);
                ShowPict.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void AddProdForm_Load(object sender, EventArgs e)
        {

        }
    }
}
