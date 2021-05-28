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
        List<Process> processesForStart;
        public FormViewProcessing()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Methods methods;
            processesForStart = new List<Process>();
            methods = new Methods(listBoxLog, 3, 0.5, 'p');
            processesForStart.Add(new Process("Вывод значений элементов последовательности", "Значения последовательности", 40, methods.PrintValuesOfSequence, "Задан изначально"));
            methods = new Methods(listBoxLog, 3, 0.2, 'e');
            processesForStart.Add(new Process("Вывод символа", "Указанный символ", 5, methods.PrintChar, "Задан изначально"));
            methods = new Methods(listBoxLog, 2, 0.5, 'f');
            processesForStart.Add(new Process("Вывод текущего времени", "Текущая дата", 13, methods.PrintDate, "Задан изначально"));
            methods = new Methods(listBoxLog, 1, 0.7, 'a');
            processesForStart.Add(new Process("Вывод символа", "Указанный символ", 16, methods.PrintChar, "Задан изначально"));
            methods = new Methods(listBoxLog, 4, 0.5, 'q');
            processesForStart.Add(new Process("Вывод текущего времени", "Текущая дата", 19, methods.PrintDate, "Задан изначально"));
            methods = new Methods(listBoxLog, 5, 0.5, 'z');
            processesForStart.Add(new Process("Вывод значений элементов последовательности", "Значения последовательности", 56, methods.PrintValuesOfSequence, "Задан изначально"));
            methods = new Methods(listBoxLog, 3, 0.4, 'c');
            processesForStart.Add(new Process("Вывод символа", "Указанный символ", 44, methods.PrintChar, "Задан изначально"));
            methods = new Methods(listBoxLog, 1, 0.5, 'v');
            processesForStart.Add(new Process("Вывод текущего времени", "Текущая дата", 33, methods.PrintDate, "Задан изначально"));
            methods = new Methods(listBoxLog, 2, 0.7, 'x');
            processesForStart.Add(new Process("Вывод символа", "Указанный символ", 36, methods.PrintChar, "Задан изначально"));
            methods = new Methods(listBoxLog, 3, 0.9, '.');
            processesForStart.Add(new Process("Вывод текущего времени", "Текущая дата", 59, methods.PrintDate, "Задан изначально"));

            RefreshProcesses();
            processPlan.processor.quantum = int.Parse(textBox1.Text);
            formMeneger = new FormManageProcesses(processesForStart, listBoxProcesses, listBoxLog, processPlan);
            thread = new Thread(new ThreadStart(processPlan.StartWorking));
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
            listBoxProcesses.SelectedItem = null;
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
            foreach (Process process in processesForStart)
            {
                allProcesses.Add(new Process(process.name, process.nameMethod, process.workingTime, process.method, process.description));
            }
            processPlan = new ProcessPlan(listBoxLog, listBoxProcesses, listBoxState, listBoxTime, 
                int.Parse(textBox1.Text), allProcesses, labelQuantum);
            processPlan.UpdateList();
        }

        private void buttonOpenManager_Click(object sender, EventArgs e)
        {
            formMeneger.ShowDialog();
            Reset();
        }

        private void listBoxProcesses_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index == -1) return;
            e.DrawBackground();
            Process process = (Process)((ListBox)sender).Items[e.Index];
            string text = process.ToString();
            Color color = Color.White;
            if (listBoxProcesses.SelectedIndex == e.Index)
            {
                if (process.processState == ProcessState.Заблокирован) color = Color.FromArgb(255,140,140);
                if (process.processState == ProcessState.Выполнен) color = Color.FromArgb(170, 255, 170);
                if (process.processState == ProcessState.Выполняется) color = Color.FromArgb(250, 255, 170);
                if (process.processState == ProcessState.В_очереди) color = Color.FromArgb(160, 200, 255);
                e.Graphics.DrawRectangle(new Pen(Color.Black, 10), e.Bounds);
            }
            else
            {
                if (process.processState == ProcessState.Заблокирован) color = Color.FromArgb(255, 70, 70);
                if (process.processState == ProcessState.Выполнен) color = Color.FromArgb(70, 255, 70);
                if (process.processState == ProcessState.Выполняется) color = Color.FromArgb(250, 255, 100);
                if (process.processState == ProcessState.В_очереди) color = Color.FromArgb(80, 150, 255);
            }

            e.Graphics.FillRectangle(new SolidBrush(color), e.Bounds);
            e.Graphics.DrawString(text,
                    e.Font, Brushes.Black, e.Bounds, StringFormat.GenericDefault);
            e.DrawFocusRectangle();
        }

        private void listBoxProcesses_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxProcesses.Invalidate();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            Reset();
        }
        void Reset()
        {
            if (thread.ThreadState == ThreadState.Suspended) thread.Resume();
            thread.Abort();
            buttonStart.Text = "Запустить";
            RefreshProcesses();
            processPlan.processor.quantum = int.Parse(textBox1.Text);
            thread = new Thread(new ThreadStart(processPlan.StartWorking));
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            Button button = ((Button)sender);
            string name = button.Text;
            if (name == "Запустить")
            {
                if (thread.ThreadState == ThreadState.Suspended)
                {
                    thread.Resume();
                    button.Text = "Приостановить";
                }
                else
                {
                    thread.Start();
                    button.Text = "Приостановить";
                }
            }
            else
            {
                if (thread.ThreadState == ThreadState.Running || thread.ThreadState == ThreadState.WaitSleepJoin)
                {
                    thread.Suspend();
                    button.Text = "Запустить";
                }
            }
        }

        private void FormViewProcessing_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (thread.ThreadState == ThreadState.Suspended) thread.Resume();
            thread.Abort();
        }
    }
}
