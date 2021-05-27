using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KPv6
{
    class Methods
    {
        ListBox listBox;
        public int n;
        public double x;
        public char c;

        public Methods(ListBox listBox, int n, double x, char c)
        {
            this.listBox = listBox;
            this.n = n;
            this.x = x;
            this.c = c;
        }

        public void PrintChar()//выводит символ
        {
            listBox.Invoke(new Action(() => listBox.Items.Add("Результат выполнения \"" + c.ToString()+ "\"")));
        }
        public void PrintValuesOfSequence()//выводит значения последовательности
        {

            string forPrint = "";
            forPrint += x.ToString();
            for (int i = 1; i < n; i++)
            {
                double newX = Math.Sin(x);
                forPrint += $" {newX.ToString():N2}";
                x = newX;
            }
            listBox.Invoke(new Action(() => listBox.Items.Add("Результат выполнения \"" + forPrint + "\"")));
        }

        public void PrintDate()//выводит дату
        {
            listBox.Invoke(new Action(() => listBox.Items.Add("Результат выполнения \"" + DateTime.Now.ToString() + "\"")));
        }
    }
}
