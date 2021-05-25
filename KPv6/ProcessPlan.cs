using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KPv6
{
    class ProcessPlan
    {
        public List<Process> processes;
        public Processor processor;
        ListBox listBoxLogs;
        ListBox listBoxProcesses;
        ListBox listBoxState;
        ListBox listBoxTime;


        public ProcessPlan(ListBox listBoxL, ListBox listBoxP, ListBox listBoxS, ListBox listBoxT, int quantum)
        {
            processes = new List<Process>();
            processor = new Processor(listBoxL);
            this.listBoxLogs = listBoxL;
            this.listBoxProcesses = listBoxP;
            this.listBoxTime = listBoxT;
            this.listBoxState = listBoxS;
            processor.quantum = quantum;
        }

        public void AddProcess(Process process)
        {
            processes.Add(process);
            UpdateList();
        }

        public void StartWorking()//Запуск Планировщика процессов
        {
            listBoxLogs.Invoke(new Action(() => listBoxLogs.Items.Add($"Квант равен {processor.quantum}")));
            listBoxLogs.Invoke(new Action(() => listBoxLogs.SelectedIndex = listBoxLogs.Items.Count - 1));
            listBoxLogs.Invoke(new Action(() => listBoxLogs.SelectedItem = null));
            int additionalTime = 0;
            while (processes.Count(x => x.processState != ProcessState.Выполнен) > 0)
            {
                processes.Sort(new ProcessComparer());
                Process process = processes[0];
                if (process.processState != ProcessState.Заблокирован)
                {
                    listBoxLogs.Invoke(new Action(() => listBoxLogs.Items.Add($"Выполняется процесс \"{process.name}\"")));
                    listBoxLogs.Invoke(new Action(() => listBoxLogs.SelectedIndex = listBoxLogs.Items.Count - 1));
                    listBoxLogs.Invoke(new Action(() => listBoxLogs.SelectedItem = null));
                    process.processState = ProcessState.Выполняется;
                    UpdateList();
                    additionalTime = processor.RunProcess(process, additionalTime);
                    listBoxLogs.Invoke(new Action(() => listBoxLogs.Items.Add($"Дополнительное время = {additionalTime}")));
                    listBoxLogs.Invoke(new Action(() => listBoxLogs.SelectedIndex = listBoxLogs.Items.Count - 1));
                    listBoxLogs.Invoke(new Action(() => listBoxLogs.SelectedItem = null));
                    if (process.workingTime == 0)
                    {
                        process.method.Invoke();
                        process.processState = ProcessState.Выполнен;
                    }
                    else
                    {
                        processes.Remove(process);
                        processes.Add(process);
                    }
                    if (process.processState == ProcessState.Выполняется)
                        process.processState = ProcessState.В_очереди;
                    processes.Sort(new ProcessComparer());
                    UpdateList();
                }
            }
        }

        public void UpdateList()//обновление вывода
        {
            Process selectedProcess = null;
            listBoxProcesses.Invoke(new Action(() => selectedProcess = (Process)listBoxProcesses.SelectedItem));
            listBoxProcesses.Invoke(new Action(() => listBoxProcesses.Items.Clear()));
            listBoxTime.Invoke(new Action(() => listBoxTime.Items.Clear()));
            listBoxState.Invoke(new Action(() => listBoxState.Items.Clear()));
            for (int i = 0; i < processes.Count; i++)
            {
                listBoxProcesses.Invoke(new Action(() => listBoxProcesses.Items.Add(processes[i])));
                listBoxTime.Invoke(new Action(() => listBoxTime.Items.Add(processes[i].workingTime)));
                listBoxState.Invoke(new Action(() => listBoxState.Items.Add(processes[i].processState)));
            }
            listBoxProcesses.Invoke(new Action(() => listBoxProcesses.SelectedItem = selectedProcess));
        }

    }
}
