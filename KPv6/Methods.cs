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
        Random rand = new Random();

        public Methods(ListBox listBox)
        {
            this.listBox = listBox;
        }

        public void PrintChar()//выводит символ
        {
            listBox.Invoke(new Action(() => listBox.Items.Add("Результат выполнения \"" + (char)rand.Next(0, 255) + "\"")));
        }
        public void PrintValuesOfSequence()//выводит значения последовательности
        {
            int n = 3;
            double x = 1;

            string forPrint = "";
            forPrint += x.ToString();
            for (int i = 1; i < n; i++)
            {
                double newX = Math.Sin(x);
                forPrint += " " + newX.ToString();
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
