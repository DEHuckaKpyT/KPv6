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
    public partial class FormChangeProcess : Form
    {
        Process process;
        ListBox listBoxLog;
        List<Process> processes;
        public FormChangeProcess()
        {
            InitializeComponent();
        }
        public FormChangeProcess(Process process, List<Process> processes, ListBox listBoxLog)
        {
            InitializeComponent();
            this.process = process;
            this.listBoxLog = listBoxLog;
            this.processes = processes;
        }

        private void FormChangeProcess_Load(object sender, EventArgs e)
        {
            comboBoxMethodProcess.Items.Add("Случайный символ");
            comboBoxMethodProcess.Items.Add("Значения последовательности");
            comboBoxMethodProcess.Items.Add("Текущая дата");
            if (process != null)
            {
                Methods methods = (Methods)process.method.Target;
                textBoxChar.Text = methods.c.ToString();
                textBoxN.Text = methods.n.ToString();
                textBoxX.Text = methods.x.ToString();
                textBoxNameProcess.Text = process.name;
                textBoxWorkingTime.Text = process.workingTime.ToString();
                comboBoxMethodProcess.SelectedItem = process.nameMethod;
            }
            else
            {
                comboBoxMethodProcess.SelectedItem = "Текущая дата";
            }
        }

        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            if (process != null)
            {

                Methods methods = (Methods)process.method.Target;
                process.name = textBoxNameProcess.Text;
                process.workingTime = int.Parse(textBoxWorkingTime.Text);
                switch (comboBoxMethodProcess.SelectedItem)
                {
                    case "Случайный символ":
                        process.method = methods.PrintChar;
                        methods.c = Convert.ToChar(textBoxChar.Text);
                        break;
                    case "Значения последовательности":
                        process.method = methods.PrintValuesOfSequence;
                        methods.n = int.Parse(textBoxN.Text);
                        methods.x = Convert.ToDouble(textBoxX.Text);
                        break;
                    case "Текущая дата":
                        process.method = methods.PrintDate;
                        break;
                }
            }
            else
            {
                Methods curMethod = new Methods(listBoxLog, int.Parse(textBoxN.Text), Convert.ToDouble(textBoxX.Text), Convert.ToChar(textBoxChar.Text));

                switch (comboBoxMethodProcess.SelectedItem)
                {
                    case "Случайный символ":
                        processes.Add(new Process(textBoxNameProcess.Text,
                            (string)comboBoxMethodProcess.SelectedItem,
                            int.Parse(textBoxWorkingTime.Text),
                            new Action(curMethod.PrintChar)));
                        break;
                    case "Значения последовательности":
                        processes.Add(new Process(textBoxNameProcess.Text,
                            (string)comboBoxMethodProcess.SelectedItem,
                            int.Parse(textBoxWorkingTime.Text),
                            new Action(curMethod.PrintValuesOfSequence)));
                        break;
                    case "Текущая дата":
                        processes.Add(new Process(textBoxNameProcess.Text,
                            (string)comboBoxMethodProcess.SelectedItem,
                            int.Parse(textBoxWorkingTime.Text),
                            new Action(curMethod.PrintDate)));
                        break;
                }
            }
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBoxMethodProcess_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxMethodProcess.SelectedItem)
            {
                case "Случайный символ":
                    textBoxChar.Visible = true;
                    textBoxN.Visible = false;
                    textBoxX.Visible = false;
                    labelChar.Visible = true;
                    labelN.Visible = false;
                    labelX.Visible = false;
                    break;
                case "Значения последовательности":
                    textBoxChar.Visible = false;
                    textBoxN.Visible = true;
                    textBoxX.Visible = true;
                    labelChar.Visible = false;
                    labelN.Visible = true;
                    labelX.Visible = true;
                    break;
                case "Текущая дата":
                    textBoxChar.Visible = false;
                    textBoxN.Visible = false;
                    textBoxX.Visible = false;
                    labelChar.Visible = false;
                    labelN.Visible = false;
                    labelX.Visible = false;
                    break;
            }
        }
    }
}
