using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KPv6
{
    public class Processor
    {
        public int quantum;//размер кванта времени
        ListBox listBox;
        public Processor(ListBox listBox)
        {
            this.listBox = listBox;
        }

        public int RunProcess(Process process, int additionalTime)//выполнение процесса
        {
            int currentQuantum = quantum + additionalTime;
            int workTime = process.workingTime - currentQuantum < 0 ? process.workingTime : currentQuantum;
            additionalTime = currentQuantum - workTime;
            process.workingTime -= workTime;
            Thread.Sleep(workTime * 100);
            listBox.Invoke(new Action(() => listBox.Items.Add($"Процесс \"{process.name}\" был вытеснен через {workTime}")));
            return additionalTime;
        }
    }
}
