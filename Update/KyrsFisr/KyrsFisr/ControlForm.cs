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
    public partial class ControlForm : Form
    {

        private DataBaseClass DataBase;

        public delegate void UpdateButtonColorDelegate(Color color, string text);
        public event UpdateButtonColorDelegate UpdateButtonColorEvent2;

        internal ControlForm(DataBaseClass DData)
        {
            InitializeComponent();
            this.DataBase = DData;
 
        }

        //Метод загрузки формы
        private void ControlForm_Activated(object sender, EventArgs e)
        {
            for (int i = 0; i < DataBase.accounts.Count; i++)
            {

                if (DataBase.accounts[i].Login == DataBase.DefineAccount)
                {
                    label2.Text = DataBase.accounts[i].FIO;
                    label3.Text = DataBase.accounts[i].phoneNumber;
                    label4.Text = DataBase.accounts[i].homeNumber;
                    label5.Text = DataBase.accounts[i].Post;
                    label6.Text = DataBase.accounts[i].email;
                    label7.Text = DataBase.accounts[i].CardNumber;



                }

            }
        }

        //Метод кнопки выхода из аккаунта
        private void ExitAccountBut_Click(object sender, EventArgs e)
        {
            Color backColor = Color.FromArgb(227, 38, 54);
            string backText = "Войти";

            UpdateButtonColorEvent2?.Invoke(backColor, backText);
            this.Hide();
        }

        private void ExitABut_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
