using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KPv6
{
    public partial class Form1 : Form
    {
        ProcessPlan processPlan;
        Process lastSelectedProcess;
        Thread thread;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshProcesses();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (thread != null) thread.Abort();
            RefreshProcesses();
            processPlan.processor.quantum = int.Parse(textBox1.Text);
            thread = new Thread(new ThreadStart(processPlan.StartWorking));
            thread.Start();
        }

        private void buttonStopProc_Click(object sender, EventArgs e)
        {
            Process selectedProcess = (Process)listBoxProcesses.SelectedItem;
            if (selectedProcess != null)
            {
                lastSelectedProcess = selectedProcess;
            }
            if (lastSelectedProcess != null)
            {
                if (lastSelectedProcess.processState == ProcessState.В_очереди || lastSelectedProcess.processState == ProcessState.Выполняется)
                    lastSelectedProcess.processState = ProcessState.Заблокирован;
                else if (lastSelectedProcess.processState == ProcessState.Заблокирован)
                    lastSelectedProcess.processState = ProcessState.В_очереди;
            }

            processPlan.UpdateList();
        }

        private void listBoxStateAndTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox listBox = (ListBox)sender;
            listBox.SelectedItem = null;
        }
        void RefreshProcesses()
        {
            listBoxLog.Items.Clear();
            processPlan = new ProcessPlan(listBoxLog, listBoxProcesses, listBoxState, listBoxTime, int.Parse(textBox1.Text));
            Methods methods = new Methods(listBoxLog);
            processPlan.AddProcess(new Process("Вывод значений элементов последовательности", 40, methods.PrintValuesOfSequence));
            processPlan.AddProcess(new Process("Вывод символа", 12, methods.PrintChar));
            processPlan.AddProcess(new Process("Вывод текущего времени", 13, methods.PrintDate));
            processPlan.AddProcess(new Process("Вывод символа", 16, methods.PrintChar));
            processPlan.AddProcess(new Process("Вывод текущего времени", 19, methods.PrintDate));
            processPlan.AddProcess(new Process("Вывод значений элементов последовательности", 56, methods.PrintValuesOfSequence));
            processPlan.AddProcess(new Process("Вывод символа", 44, methods.PrintChar));
            processPlan.AddProcess(new Process("Вывод текущего времени", 33, methods.PrintDate));
            processPlan.AddProcess(new Process("Вывод символа", 36, methods.PrintChar));
            processPlan.AddProcess(new Process("Вывод текущего времени", 59, methods.PrintDate));
        }
    }
}
