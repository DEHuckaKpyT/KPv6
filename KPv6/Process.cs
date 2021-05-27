using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPv6
{
    public class Process
    {
        public string name;
        public int workingTime;//общее время его выполнения
        public Action method;//задача процесса
        public string nameMethod;
        public ProcessState processState;

        public Process(string name, string nameMethod, int time, Action method)
        {
            this.name = name;
            workingTime = time;
            this.method = method;
            this.nameMethod = nameMethod;
            processState = ProcessState.В_очереди;
        }
        public override string ToString()
        {
            return $"\"{name}\"";
        }
    }
}
