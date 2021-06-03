using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KPv6
{
    public partial class FormManageProcesses : Form
    {
        List<Process> allProcesses;
        ListBox listBoxAllProcesses;
        ListBox listBoxLog;
        ProcessPlan processPlan;
        FormChangeProcess formChangeProcess;
        public FormManageProcesses()
        {
            InitializeComponent();
        }
        public FormManageProcesses(List<Process> processes, ListBox listBoxProcesses, ListBox listBoxLog, ProcessPlan processPlan)
        {
            InitializeComponent();
            allProcesses = processes;
            listBoxAllProcesses = listBoxProcesses;
            this.processPlan = processPlan;
            this.listBoxLog = listBoxLog;
        }

        private void ManageProcesses_Load(object sender, EventArgs e)
        {
            UpdateAllListBoxes();
            processPlan.UpdateList();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxProcesses.SelectedItem == null) return;
            allProcesses.Remove((Process)listBoxProcesses.SelectedItem);
            UpdateAllListBoxes();
        }

        void UpdateAllListBoxes()
        {
            processPlan.UpdateList();
            listBoxProcesses.Items.Clear();
            listBoxProcessesExtented.Items.Clear();
            listBoxProcesses.Items.Add("Название процесса");
            listBoxProcessesExtented.Items.Add($"{"Время",-6} {"Назначение процесса",-29} {"Спец инф-я",-15} {"Описание"}");
            foreach (Process process in allProcesses)
            {
                listBoxProcesses.Items.Add(process);
                if (process.nameMethod == "Значения последовательности")
                    listBoxProcessesExtented.Items.Add($"{process.workingTime + " мс",6} {process.nameMethod,-29} {$"n = {((Methods)process.method.Target).n}, x = {((Methods)process.method.Target).x:N2}",-15} {process.description}");
                if (process.nameMethod == "Указанный символ")
                    listBoxProcessesExtented.Items.Add($"{process.workingTime + " мс",6} {process.nameMethod,-29} {$"Символ = {((Methods)process.method.Target).c}",-15} {process.description}");
                if (process.nameMethod == "Текущая дата")
                    listBoxProcessesExtented.Items.Add($"{process.workingTime + " мс",6} {process.nameMethod,-29} {$"",-15} {process.description}");
            }
        }

        private void buttonAddProcess_Click(object sender, EventArgs e)
        {
            formChangeProcess = new FormChangeProcess(null, allProcesses, listBoxLog);
            formChangeProcess.ShowDialog();
            UpdateAllListBoxes();
        }

        private void listBoxProcesses_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBoxProcesses.SelectedIndex == 0) return;
            formChangeProcess = new FormChangeProcess((Process)listBoxProcesses.SelectedItem, allProcesses, listBoxLog);
            formChangeProcess.ShowDialog();
            UpdateAllListBoxes();
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            if (listBoxProcesses.SelectedItem == null) return;
            formChangeProcess = new FormChangeProcess((Process)listBoxProcesses.SelectedItem, allProcesses, listBoxLog);
            formChangeProcess.ShowDialog();
            UpdateAllListBoxes();
        }

        private void listBoxProcesses_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxProcessesExtented.SelectedIndex = listBoxProcesses.SelectedIndex;
            if (listBoxProcesses.SelectedIndex == 0) listBoxProcesses.SelectedIndex = -1;
        }

        private void listBoxProcessesExtented_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxProcesses.SelectedIndex = listBoxProcessesExtented.SelectedIndex;
            if (listBoxProcessesExtented.SelectedIndex == 0) listBoxProcessesExtented.SelectedIndex = -1;
        }

        private void listBoxProcessesExtented_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBoxProcessesExtented.SelectedIndex == 0) return;
            listBoxProcesses.SelectedIndex = listBoxProcessesExtented.SelectedIndex;
            formChangeProcess = new FormChangeProcess((Process)listBoxProcesses.SelectedItem, allProcesses, listBoxLog);
            formChangeProcess.ShowDialog();
            UpdateAllListBoxes();
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            int index = listBoxProcesses.SelectedIndex;
            if (index == 0 || index == 1 || listBoxProcesses.SelectedItem == null) return;
            Process processTemp = allProcesses[index - 1];
            allProcesses[index - 1] = allProcesses[index - 2];
            allProcesses[index - 2] = processTemp;
            UpdateAllListBoxes();
            listBoxProcesses.SelectedIndex = index - 1;
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            int index = listBoxProcesses.SelectedIndex;
            if (index == listBoxProcesses.Items.Count - 1 || listBoxProcesses.SelectedItem == null) return;
            Process processTemp = allProcesses[index - 1];
            allProcesses[index - 1] = allProcesses[index];
            allProcesses[index] = processTemp;
            UpdateAllListBoxes();
            listBoxProcesses.SelectedIndex = index + 1;
        }
    }
}
