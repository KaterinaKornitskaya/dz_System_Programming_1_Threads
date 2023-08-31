using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

// создайте класс Bank, в котором будут следующие
// свойства: int money, string name, int percent.
// Постройте класс так, чтобы при изменении одного из
// свойств класса создавался новый поток, который 
// записывал данные о свойствах класса в текстовый
// файл на жестком диске. Класс должен инкапсулировать
// в себе всю логику многопоточности.
namespace task2
{
    public partial class Form1 : Form
    {
        // создаем ссылку на объект класса Банк
        Bank obj = null;
        public Form1()
        {
            InitializeComponent();
            textBoxMoney.Text = 0.ToString();
            textBoxName.Text = 0.ToString();
            textBoxPercent.Text = 0.ToString();
            // инициализируем объект значениями из текстбоксов
            obj = new Bank(int.Parse(textBoxMoney.Text), textBoxName.Text,
                int.Parse(textBoxPercent.Text));
        }

        // обработчик кнопки Изменить (баланс)
        private void buttonMoney_Click(object sender, EventArgs e)
        {
            obj.Money = int.Parse(textBoxMoney.Text);
        }

        // обработчик кнопки Изменить (имя)
        private void buttonName_Click(object sender, EventArgs e)
        {
            obj.Name = textBoxName.Text;
        }

        // обработчик кнопки Изменить (процентную ставку)
        private void buttonPercent_Click(object sender, EventArgs e)
        {
            obj.Percent = int.Parse(textBoxPercent.Text);
        }
    }
}
