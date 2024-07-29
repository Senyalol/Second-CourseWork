using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; // Предполагается, что вы используете MySQL, подключите соответствующую библиотеку

namespace KyrsFisr
{
    public partial class AccountForm : Form
    {
        private DataBaseClass DataBase;
        // internal static DataBaseClass DataBase2 = new DataBaseClass();
        public static List <string> AccountLogins = new List <string> ();

        public delegate void UpdateButtonColorDelegate(Color color, string text);
        public event UpdateButtonColorDelegate UpdateButtonColorEvent;

        public bool ClientCart = false;

        

        internal AccountForm(DataBaseClass dataBase)
        {
            InitializeComponent();
            this.DataBase = dataBase;
            reg.Data = dataBase;
            // DataBase2 = dataBase;
           
            Password.PasswordChar = '*';
            ColorInClass.Instance.colorbut = Color.FromArgb(227, 38, 54);

            GetDataFromDB();

            //Небольшой костыль)
            for(int i = 0; i < DataBase.accounts.Count; i++)
            {
                AccountLogins.Add(DataBase.accounts[i].Login);

            }

        }

         RegForm reg = new RegForm(AccountLogins);


        //Метод для получения данных из БД
        internal List<Account> GetDataFromDB()
        {
            string connectionString = "server=127.0.0.1;database=accounts3;user=root;password="; // Установите соответствующие значения  users

            List<Account> списокАккаунтов = new List<Account>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM users"; // Замените на фактическую таблицу, из которой вы хотите извлечь данные
                MySqlCommand command = new MySqlCommand(query, connection);
                connection.Open();//sa

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Account accountFromDB = new Account();
                        {
                            int sas = reader.GetInt32("ID");
                            accountFromDB.FIO = reader.GetString("ФИО");
                            accountFromDB.phoneNumber = reader.GetString("PhoneNum");
                            accountFromDB.homeNumber = reader.GetString("HomeAdress");
                            accountFromDB.Post = reader.GetString("Почта");
                            accountFromDB.email = reader.GetString("Email");
                            accountFromDB.CardNumber = reader.GetString("Карта");
                            accountFromDB.Login = reader.GetString("Login");
                            accountFromDB.Password = reader.GetString("Password");
                            accountFromDB.Admin = reader.GetBoolean("Admin");
                        };

                        DataBase.accounts.Add(accountFromDB);
                    }
                }
            }

            return DataBase.accounts;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {         
            reg.Show();
            
        }
        
        //Кнопка для авторизации
        private void Ok_Click(object sender, EventArgs e)
        {
            
            string Log = Login.Text;
            string password = Password.Text;

            bool Notfind = true; // Если не нашел логин

            for(int i = 0; i < DataBase.accounts.Count; i++)
            {

                if (DataBase.accounts[i].Login == Log)
                {
                    Notfind = false;
                    if (DataBase.accounts[i].Password == password)
                    {
                        
                        MessageBox.Show("Вы успешно вошли в аккаунт");
                        Color setColor = Color.Green;
                        string setText = DataBase.accounts[i].Login;

                        UpdateButtonColorEvent?.Invoke(setColor, setText);

                        this.ClientCart = true;

                        Login.Text = null; 
                        Password.Text = null;

                        this.Hide();
                    }

                }

                //else 
                //{
                //    Notfind = true;
                //}

                

            }

            if (Notfind)
            {
                MessageBox.Show("Аккаунта не существует, создайте его!");
            }

        }

        //Когда кнопка отпущена
        private void OpenPassButt_MouseUp(object sender, MouseEventArgs e)
        {
            Password.PasswordChar = '*';
        }

        //Когда кнопка зажата
        private void OpenPassButt_MouseDown(object sender, MouseEventArgs e)
        {
            Password.PasswordChar = '\0';
        }

        private void ExitButt_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void OpenPassButt_Click(object sender, EventArgs e)
        {

        }
    }
}
