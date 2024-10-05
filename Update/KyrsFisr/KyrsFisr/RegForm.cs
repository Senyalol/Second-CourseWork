using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace KyrsFisr
{


    public partial class RegForm : Form
    {

        internal DataBaseClass Data;

        private List<string> Logins = new List<string>();

        internal RegForm(List<string> logs)
        {
            InitializeComponent();
            Logins = logs;

            //this.Data = Data2;
        }

        //Методы проверок

        //Проверки на спецсимволы
        public static bool HasSpecialCharacters(string input)
        {
            return Regex.IsMatch(input, @"[^a-zA-Zа-яА-Я0-9 ]");
        }

        //Проверки на нахождения хоть одного числа , если не находит число, то !
        public static bool IsNumeric(string input)
        {
            return Regex.IsMatch(input, @"[0-9]");
        }

        public static bool FullStringIsNum(string input)
        {
            return Regex.IsMatch(input, @"^\d+$");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void CreateAkkountBut_Click(object sender, EventArgs e)
        {
            string fullname = FullNameInput.Text;
            string phone = PhoneInput.Text;
            string home = AdressInput.Text;
            string post = PostInput.Text;
            string email = EmailInput.Text;
            string card = CardInput.Text;
            string Login = CreateLogin1.Text;
            string password = CreatePass1.Text;

            if (!HasSpecialCharacters(fullname) && !IsNumeric(fullname) && FullStringIsNum(phone) && !HasSpecialCharacters(phone) && FullStringIsNum(card) && !HasSpecialCharacters(card) && !HasSpecialCharacters(Login) && !HasSpecialCharacters(password))
            {



                //Если пароль ввели два раза верно
                if (CreatePass1.Text == CreatePass2.Text)
                {

                    for (int i = 0; i < Logins.Count; i++)
                    {
                        if (Logins[i] != Login)
                        {
                            bool admin = false;
                            Account akk = new Account(fullname, phone, home, post, email, card, Login, password,admin);
                            Data.AddAccount(akk);

                            this.FullNameInput.Text = null;
                            this.PhoneInput.Text = null;
                            this.AdressInput.Text = null;
                            this.PostInput.Text = null;
                            this.EmailInput.Text = null;
                            this.CardInput.Text = null;

                            string connectionString = "server=127.0.0.1;database=accounts3;user=root;password=";
                            using (MySqlConnection connection = new MySqlConnection(connectionString))
                            {
                                connection.Open();

                                // Пример SQL-запроса для добавления данных в таблицу
                                string query = "INSERT INTO users (ФИО,PhoneNum,HomeAdress,Почта,Email,Карта,Login,Password) VALUES (@значениеФИО,@значениеPhoneNum,@значениеHomeAdress,@значениеПочта,@значениеEmail,@значениеКарта,@значениеLogin,@значениеPassword)";

                                using (MySqlCommand command = new MySqlCommand(query, connection))
                                {
                                    command.Parameters.AddWithValue("@значениеФИО", fullname);
                                    command.Parameters.AddWithValue("@значениеPhoneNum", phone);
                                    command.Parameters.AddWithValue("@значениеHomeAdress", home);
                                    command.Parameters.AddWithValue("@значениеПочта", post);
                                    command.Parameters.AddWithValue("@значениеEmail", email);
                                    command.Parameters.AddWithValue("@значениеКарта", card);
                                    command.Parameters.AddWithValue("@значениеLogin", Login);
                                    command.Parameters.AddWithValue("@значениеPassword", password);

                                    command.ExecuteNonQuery();
                                }
                            }

                            MessageBox.Show("Аккаунт: " + Login + " успешно создан!");
                            break;
                            this.Hide();
                        }

                        else
                        {
                            MessageBox.Show("Логин " + Login + " уже занят!");
                        }

                    }


                }

                else
                {
                    MessageBox.Show("Пароли не совпадают");
                }

            }


        }

        private void ExitBut_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void CreateLogin1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
