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
    public partial class FormViewProcessing : Form
    {
        ProcessPlan processPlan;
        Process lastSelectedProcess;
        Thread thread;
        FormManageProcesses formMeneger;
        List<Process> allProcesses;
        public FormViewProcessing()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshProcesses();
            formMeneger = new FormManageProcesses(allProcesses, listBoxProcesses, listBoxLog, processPlan);
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
            allProcesses = new List<Process>();
            processPlan = new ProcessPlan(listBoxLog, listBoxProcesses, listBoxState, listBoxTime, int.Parse(textBox1.Text), allProcesses);
            Methods methods = new Methods(listBoxLog, 3, 0.5, (char)new Random().Next(0, 255));
            processPlan.AddProcess(new Process("Вывод значений элементов последовательности", "Значения последовательности", 40, methods.PrintValuesOfSequence));
            methods = new Methods(listBoxLog, 3, 0.5, (char)new Random().Next(0, 255));
            processPlan.AddProcess(new Process("Вывод символа", "Случайный символ", 12, methods.PrintChar));
            methods = new Methods(listBoxLog, 3, 0.5, (char)new Random().Next(0, 255));
            processPlan.AddProcess(new Process("Вывод текущего времени", "Текущая дата", 13, methods.PrintDate));
            methods = new Methods(listBoxLog, 3, 0.5, (char)new Random().Next(0, 255));
            processPlan.AddProcess(new Process("Вывод символа", "Случайный символ", 16, methods.PrintChar));
            methods = new Methods(listBoxLog, 3, 0.5, (char)new Random().Next(0, 255));
            processPlan.AddProcess(new Process("Вывод текущего времени", "Текущая дата", 19, methods.PrintDate));
            methods = new Methods(listBoxLog, 3, 0.5, (char)new Random().Next(0, 255));
            processPlan.AddProcess(new Process("Вывод значений элементов последовательности", "Значения последовательности", 56, methods.PrintValuesOfSequence));
            methods = new Methods(listBoxLog, 3, 0.5, (char)new Random().Next(0, 255));
            processPlan.AddProcess(new Process("Вывод символа", "Случайный символ", 44, methods.PrintChar));
            methods = new Methods(listBoxLog, 3, 0.5, (char)new Random().Next(0, 255));
            processPlan.AddProcess(new Process("Вывод текущего времени", "Текущая дата", 33, methods.PrintDate));
            methods = new Methods(listBoxLog, 3, 0.5, (char)new Random().Next(0, 255));
            processPlan.AddProcess(new Process("Вывод символа", "Случайный символ", 36, methods.PrintChar));
            methods = new Methods(listBoxLog, 3, 0.5, (char)new Random().Next(0, 255));
            processPlan.AddProcess(new Process("Вывод текущего времени", "Текущая дата", 59, methods.PrintDate));
        }

        private void buttonOpenManager_Click(object sender, EventArgs e)
        {
            formMeneger.ShowDialog();
        }
    }
}
