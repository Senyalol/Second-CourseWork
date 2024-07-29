using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace KyrsFisr
{

      internal class Account
    {

        public string FIO { get; set; }

        public bool Admin { get; set; }

        public string phoneNumber { get; set; }
        public string homeNumber { get; set; }
        public string Post { get; set; }
        public string email { get; set; }
        public string CardNumber { get;set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public List<Product> ClientShopCart { get; set; } = new List<Product> { };

        //public List<Product> AddCon(Product product)
        //{
        //    this.ClientShopCart.Add(product);
        //    return ClientShopCart;
        //}

        public List<Favorite> favorites { get; set; } = new List<Favorite> { };

        //Конструкторы с параметрами (Перегрузки)
        public Account(string F, string phone, string home, string post, string email, string card, string Login, string password, List<Favorite> SomeFav)
        {
            this.FIO = F;
            this.phoneNumber = phone;
            this.homeNumber = home;
            this.Post = post;
            this.email = email;
            this.CardNumber = card;
            this.Login = Login;
            this.Password = password;
            this.favorites = SomeFav;
        }

        public Account(string F, string phone, string home, string post, string email, string card, string Login, string password, bool admin)
        {
            this.FIO = F;
            this.phoneNumber = phone;
            this.homeNumber = home;
            this.Post = post;
            this.email = email;
            this.CardNumber = card;
            this.Login = Login;
            this.Password = password;
            this.Admin = admin;
        }

        public Account(string F, string phone, string home, string post, string email, string card, string Login, string password, List<Product> con)
        {
            this.FIO = F;
            this.phoneNumber = phone;
            this.homeNumber = home;
            this.Post = post;
            this.email = email;
            this.CardNumber = card;
            this.Login = Login;
            this.Password = password;
            this.ClientShopCart = con;
        }

        public Account()
        {

        }
    }

      internal class Product
    {

        public string Brand { get; set; }
    
        public int ConstructYear { get; set; }

        public string Material { get; set; }

        public int Batery { get; set; } //m. A.h

        public string Category { get; set; }

        public double Cost { get; set; }

        public int ProductID { get; set; }

        public string photop { get; set; }

        public int count { get; set; }

       public Product(string brand, int constructYear, string material, int  batery, string category, double cost, int id)
        {
            Brand = brand;
            ConstructYear = constructYear;
            Material = material;
            Batery = batery;
            Category = category;
            Cost = cost;
            ProductID = id;
        }

        public Product(string brand, int constructYear, string material, int batery, string category, double cost, int id, string photop1, int count1)
        {
            Brand = brand;
            ConstructYear = constructYear;
            Material = material;
            Batery = batery;
            Category = category;
            Cost = cost;
            ProductID = id;
            photop = photop1;
            count = count1;
        }

        public Product() { 
        
        }

    }

      internal class Favorite: Product
    {
        public int index { get; set; }

        public string photoPath { get; set; }

        public Favorite(string brand, int constructYear, string material, int batery, string category, double cost,int id,int ind) : base(brand, constructYear, material, batery, category, cost,id)
        {
            index = ind;
        }

        public Favorite(string brand, int constructYear, string material, int batery, string category, double cost,int id, string p) : base(brand, constructYear, material, batery, category, cost, id)
        {
            
                Brand = brand;
                ConstructYear = constructYear;
                Material = material;
                Batery = batery;
                Category = category;
                Cost = cost;
                photoPath = p;
                ProductID= id;
        }

        public Favorite()
        {

        }
    
    }

      internal class DataBaseClass
        {

        //Для передачи данных о товаре между формами 
        public string Brand { get; set; }

        public int ConstructYear { get; set; }

        public string Material { get; set; }

        public int Batery { get; set; } //m. A.h

        public string Category { get; set; }

        public double Cost { get; set; }


        //По части аккаунтов
        public string DefineAccount;

        public DataBaseClass()
        {

        }

        //БД для аккаунтов пользователей
        public List<Account> accounts = new List<Account>();

        //Метод для добавления аккаунта в список аккаунтов
        public List<Account> AddAccount(Account account)
        {
            accounts.Add(account);
            return accounts;
        }

        //Метод для удаления аккаунта из списка аккаунтов
        public List<Account> RemoveAccount(int number)
        {
            accounts.RemoveAt(number);
            return accounts;
        }

        
        //По части продукции

        



    }

      public class ColorInClass
            {
                public Color colorbut;

                public string textbut;

                private static ColorInClass ob;

                public static ColorInClass Instance
                {
                    get
                    {
                        if (ob == null)
                        {
                            ob = new ColorInClass();
                        }
                        return ob;
                    }
                }
            }


    interface IChecker
    {
        bool check(object obj);

    }

    class CheckNumberOnly : IChecker
    {

        private bool OnlyNumbersInString(string str)
        {
            return Regex.IsMatch(str, @"^\d+$");
        }

        public bool check(object obj)
        {
            if (obj is string)
            {
                
                string num = (string)obj;

                if (OnlyNumbersInString(num))
                {
                    return true;
                }


                else if(!OnlyNumbersInString(num))
                {
                    MessageBox.Show("К сожалению строка: " + obj.ToString() + " введена некорректно");
                    return false;
                }
                
            }

            MessageBox.Show("К сожалению строка: " + obj.ToString() + " введена некорректно");
            return false;

        }
    }

    class CheckOnlyString : IChecker
    {
        private bool IsNumeric(string input)
        {
            return Regex.IsMatch(input, @"[0-9]");
        }

        private bool HasSpecialCharacters(string input)
        {
            return Regex.IsMatch(input, @"[^a-zA-Zа-яА-Я0-9 ]");
        }

        public bool check(object obj)
        {
            if (obj is string)
            {
                string str = (string)obj;

                if(!IsNumeric(str) && !HasSpecialCharacters(str))
                {
                    return true;
                }

                else /*if(IsNumeric(str) && HasSpecialCharacters(str))*/
                {
                    MessageBox.Show("К сожалению строка: " + obj.ToString() + " введена некорректно");
                    return false;
                }

            }

            MessageBox.Show("К сожалению строка: " + obj.ToString() + " введена некорректно");
            return false;

        }


    }

    class CheckCheckBox : IChecker
    {

       // List<CheckBox> CheckBoxes = new List<CheckBox>();

        public bool check(object obj) {

            if (obj is CheckBox)
            {
                CheckBox box = (CheckBox)obj;

                if (box.IsChecked == true)
                {
                    return true;
                }

                else
                {
                    return false;
                }

            }

            return false;

        }

        public bool CheckIsAllCheckboxesIsNull(List<CheckBox> checkBoxes)
        {

            bool temp = false;

            for(int i = 0; i < checkBoxes.Count; i++)
            {

               if(check(checkBoxes[i]) == true)
                {
                    temp = true;
                    
                }

            }


            return temp;

        }


    }


}
