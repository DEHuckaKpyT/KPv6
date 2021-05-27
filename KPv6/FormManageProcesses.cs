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
            allProcesses.Remove((Process)listBoxProcesses.SelectedItem);
            UpdateAllListBoxes();
        }

        void UpdateAllListBoxes()
        {
            processPlan.UpdateList();
            listBoxProcesses.Items.Clear();
            foreach (Process process in allProcesses)
                listBoxProcesses.Items.Add(process);
        }

        private void buttonAddProcess_Click(object sender, EventArgs e)
        {
            formChangeProcess = new FormChangeProcess(null, allProcesses, listBoxLog);
            formChangeProcess.ShowDialog();
        }

        private void listBoxProcesses_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            formChangeProcess = new FormChangeProcess((Process)listBoxProcesses.SelectedItem, allProcesses, listBoxLog);
            formChangeProcess.ShowDialog();
            UpdateAllListBoxes();
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            formChangeProcess = new FormChangeProcess((Process)listBoxProcesses.SelectedItem, allProcesses, listBoxLog);
            formChangeProcess.ShowDialog();
            UpdateAllListBoxes();
        }
    }
}
